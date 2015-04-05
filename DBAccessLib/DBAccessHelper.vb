﻿' '*****************************************************************************************
' Student Names: Laurie Shields (034448142)
'                Mark Lindan (063336143)
' CVB815 - DBAccessHelper
'*******************************************************************************************
Imports System.Data.SqlClient
Imports Database
Imports System.Configuration
Public Class DBAccessHelper
    Public Shared Function DBGetConnection() As SqlClient.SqlConnection
        Dim connString As String = "Data Source=135.23.74.62;Initial Catalog=cvb815a_assign2;Persist Security Info=True;User ID=programaccess;Password=butterfly"
        '     Dim connString As String = System.Configuration.ConfigurationManager.ConnectionStrings("Assignment_2.My.MySettings.cvb815a_assign2ConnectionString").ConnectionString
        Return (New SqlConnection(connString))
    End Function

    Public Shared Sub DBConnectionClose(ByRef cn As SqlClient.SqlConnection)
        Try
            cn.Close()
        Catch ex As Exception
            ' Console.WriteLine(ex.Message)
            ex = Nothing
        Finally
            cn = Nothing
        End Try
    End Sub

    ' Helper method to manage the transaction and handle commit or rollback
    Private Shared Function DBSQLExecute(conn As SqlClient.SqlConnection, cmd As SqlCommand) As Boolean
        Dim bRetVal As Boolean = False
        '# Using SqlTransaction: BeginTransaction, Commit, Rollback
        Dim transaction As SqlTransaction       '# setup for local transaction
        transaction = Nothing

        Try
            conn.Open()
            transaction = conn.BeginTransaction()   '# begin local transaction
            cmd.Transaction = transaction           '# setup command transaction
            cmd.ExecuteScalar()                     '# call SQL Stored procedure
            transaction.Commit()                    '# commit transaction
            bRetVal = True
        Catch sqlExcept As SqlException          '# transaction failure
            If transaction IsNot Nothing Then
                transaction.Rollback()          '# rollback transaction
            End If
        End Try
        Return bRetVal
    End Function

    ' LAURIE - TODO:: This function is only for unit test purposes
    ' return Nothing if product not found, otherwise returns a the Product
    Public Shared Function DBReadProductByID(id As Integer) As Product
        ' Get the connection
        Dim conn As SqlClient.SqlConnection = DBAccessHelper.DBGetConnection()
        ' Create the command
        Dim cmd As SqlCommand = conn.CreateCommand
        Dim p As Product = Nothing

        ' Set the command type and text for the stored procedure
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "dbo.sp_read_product"

        ' Set up the input and output parameters
        cmd.Parameters.Add("@id", SqlDbType.Int)
        cmd.Parameters("@id").Direction = ParameterDirection.InputOutput
        cmd.Parameters("@id").Value = id
        cmd.Parameters.Add("@desc", SqlDbType.NVarChar, 50)
        cmd.Parameters("@desc").Direction = ParameterDirection.Output
        cmd.Parameters.Add("@price", SqlDbType.Money)
        cmd.Parameters("@price").Direction = ParameterDirection.Output
        cmd.Parameters.Add("@inv", SqlDbType.Int)
        cmd.Parameters("@inv").Direction = ParameterDirection.Output
        cmd.Parameters.Add("@active", SqlDbType.Bit)
        cmd.Parameters("@active").Direction = ParameterDirection.Output

        Try
            conn.Open()
            cmd.ExecuteScalar()                     '# call SQL Stored procedure
            id = cmd.Parameters("@id").Value        ' retrieve the in/out param value
            If id <> -1 Then
                ' found the record, create and populate the new product object
                p = New Product(id, cmd.Parameters("@desc").Value,
                                cmd.Parameters("@price").Value,
                                cmd.Parameters("@inv").Value,
                                cmd.Parameters("@active").Value)
            End If

        Catch sqlExcept As SqlException
            ' nothing to do here...since the read is just a query
        Finally
            DBAccessHelper.DBConnectionClose(conn)
        End Try
        Return p
    End Function

    ' return the product id of the new item, -1 on fail
    Public Shared Function DBInsertProduct(p As Product) As Integer
        Dim retVal As Integer = -1
        If p Is Nothing Then
            Return -1
        End If
        ' Get the connection
        Dim conn As SqlClient.SqlConnection = DBAccessHelper.DBGetConnection()
        ' Create the command
        Dim cmd As SqlCommand = conn.CreateCommand

        ' Set the command type and text for the stored procedure
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "dbo.sp_insert_product"

        ' Set up the parameters and values
        cmd.Parameters.Add("@desc", SqlDbType.NVarChar, 50, ParameterDirection.Input)
        cmd.Parameters("@desc").Value = p.Description
        cmd.Parameters.Add("@price", SqlDbType.Decimal, ParameterDirection.Input)
        cmd.Parameters("@price").Value = p.Price
        cmd.Parameters.Add("@inv", SqlDbType.Int, ParameterDirection.Input)
        cmd.Parameters("@inv").Value = p.Inventory
        cmd.Parameters.Add("@active", SqlDbType.Bit, ParameterDirection.Input)
        If p.active = True Then
            cmd.Parameters("@active").Value = 1
        Else
            cmd.Parameters("@active").Value = 0
        End If
        ' set up the output parameter that we use to extract the id
        cmd.Parameters.Add("@id", SqlDbType.Int)
        cmd.Parameters("@id").Direction = ParameterDirection.Output
        If DBAccessHelper.DBSQLExecute(conn, cmd) = True Then
            retVal = cmd.Parameters("@id").Value
        End If
        DBAccessHelper.DBConnectionClose(conn)
        conn = Nothing
        Return retVal
    End Function

    ' true on success, false on fail
    Public Shared Function DBDeleteProduct(p As Product) As Boolean
        Dim bRetVal As Boolean = False
        If p Is Nothing Then
            Return bRetVal
        End If
        ' Get the connection
        Dim conn As SqlClient.SqlConnection = DBAccessHelper.DBGetConnection()
        ' Create the command
        Dim cmd As SqlCommand = conn.CreateCommand

        ' Set the command type and text for the stored procedure
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "dbo.sp_delete_product"

        ' Set up the parameters and values
        cmd.Parameters.Add("@id", SqlDbType.Int)
        cmd.Parameters("@id").Value = p.ID

        If DBAccessHelper.DBSQLExecute(conn, cmd) = True Then
            bRetVal = True
        End If
        DBAccessHelper.DBConnectionClose(conn)
        conn = Nothing
        Return bRetVal
    End Function

    ' true on success, false on fail
    Public Shared Function DBUpdateProduct(p As Product) As Boolean
        Dim bRetVal As Boolean = False
        If p Is Nothing Then
            Return bRetVal
        End If
        ' Get the connection
        Dim conn As SqlClient.SqlConnection = DBAccessHelper.DBGetConnection()
        ' Create the command
        Dim cmd As SqlCommand = conn.CreateCommand

        ' Set the command type and text for the stored procedure
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "dbo.sp_update_product"

        ' Set up the parameters and values
        cmd.Parameters.Add("@id", SqlDbType.Int)
        cmd.Parameters("@id").Value = p.ID
        cmd.Parameters.Add("@desc", SqlDbType.NVarChar)
        cmd.Parameters("@desc").Value = p.Description
        cmd.Parameters.Add("@price", SqlDbType.Decimal)
        cmd.Parameters("@price").Value = p.Price
        cmd.Parameters.Add("@inv", SqlDbType.Int)
        cmd.Parameters("@inv").Value = p.Inventory
        cmd.Parameters.Add("@active", SqlDbType.Bit)
        cmd.Parameters("@active").Value = p.active
        If DBAccessHelper.DBSQLExecute(conn, cmd) = True Then
            bRetVal = True
        End If
        DBAccessHelper.DBConnectionClose(conn)
        conn = Nothing
        Return bRetVal
    End Function

    ' return Nothing if address not found, otherwise returns an Address
    Public Shared Function DBReadAddressByID(id As Integer) As Address
        Return Nothing
    End Function

    ' return the product id of the new item, -1 on fail
    Public Shared Function DBInsertAddress(a As Address) As Integer
        Return -1
    End Function

    ' true on success, false on fail
    Public Shared Function DBDeleteAddress(a As Address) As Boolean
        Return False
    End Function

    ' true on success, false on fail
    Public Shared Function DBUpdateAdddress(a As Address) As Boolean
        Return False
    End Function

    ' return Nothing if customer not found, otherwise returns a Customer
    Public Shared Function DBReadCustomerByID(id As Integer) As Customer
        Return Nothing
    End Function

    ' return the product id of the new item, -1 on fail
    Public Shared Function DBInsertCustomer(c As Customer) As Integer
        Return -1
    End Function

    ' true on success, false on fail
    Public Shared Function DBDeleteCustomer(c As Customer) As Boolean
        Return False
    End Function

    ' true on success, false on fail
    Public Shared Function DBUpdateCustomer(c As Customer) As Boolean
        Return False
    End Function

    ' return Nothing if order not found, otherwise returns an Order
    Public Shared Function DBReadOrderByID(id As Integer) As Order
        Return Nothing
    End Function

    ' return the product id of the new item, -1 on fail
    Public Shared Function DBInsertOrder(o As Order) As Integer
        Return -1
    End Function

    ' true on success, false on fail
    Public Shared Function DBDeleteOrder(o As Order) As Boolean
        Return False
    End Function

    ' true on success, false on fail
    Public Shared Function DBUpdateOrder(o As Order) As Boolean
        Return False
    End Function

    ' return Nothing if orderitem not found, otherwise returns an OrderItem
    Public Shared Function DBReadOrderItemByID(id As Integer) As OrderItem
        Return Nothing
    End Function

    ' return the product id of the new item, -1 on fail
    Public Shared Function DBInsertOrderItem(i As OrderItem) As Integer
        Return -1
    End Function

    ' true on success, false on fail
    Public Shared Function DBDeleteOrderItem(i As OrderItem) As Boolean
        Return False
    End Function

    ' true on success, false on fail
    Public Shared Function DBUpdateOrderItem(i As OrderItem) As Boolean
        Return False
    End Function
End Class

