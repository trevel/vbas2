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

    Private Shared Sub DBSQLExecute(conn As SqlClient.SqlConnection, cmd As SqlCommand)

        '# Using SqlTransaction: BeginTransaction, Commit, Rollback
        Dim transaction As SqlTransaction       '# setup for local transaction
        transaction = Nothing

        Try
            conn.Open()
            transaction = conn.BeginTransaction()   '# begin local transaction
            cmd.Transaction = transaction           '# setup command transaction
            cmd.ExecuteScalar()                     '# call SQL Stored procedure
            transaction.Commit()                    '# commit transaction
        Catch sqlExcept As SqlException          '# transaction failure
            If transaction IsNot Nothing Then
                transaction.Rollback()          '# rollback transaction
            End If
        End Try
    End Sub

    ' LAURIE - TODO:: This function is only for unit test purposes
    Public Shared Function DBReadProductByID(id As Integer) As Product
        ' Get the connection
        Dim conn As SqlClient.SqlConnection = DBAccessHelper.DBGetConnection()
        ' Create the command
        Dim cmd As SqlCommand = conn.CreateCommand
        Dim p As Product = Nothing

        ' Set the command type and text for the stored procedure
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "dbo.sp_read_product"

        ' Set up the input parameters and values
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
            id = cmd.Parameters("@id").Value
            If id = -1 Then
                ' couldn't find record
            Else
                p = New Product()
                p.ID = id
                p.Description = cmd.Parameters("@desc").Value
                p.Price = cmd.Parameters("@price").Value
                p.Inventory = cmd.Parameters("@inv").Value
                p.active = cmd.Parameters("@active").Value
            End If

        Catch sqlExcept As SqlException          '# transaction failure
            ' LAURIE - TODO add something here
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
        cmd.Parameters.Add("@id", SqlDbType.Int)
        cmd.Parameters("@id").Direction = ParameterDirection.Output
        DBAccessHelper.DBSQLExecute(conn, cmd)
        retVal = cmd.Parameters("@id").Value
        DBAccessHelper.DBConnectionClose(conn)
        conn = Nothing
        Return retVal
    End Function

    Public Shared Sub DBDeleteProduct(p As Product)
        If p Is Nothing Then
            Return
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

        DBAccessHelper.DBSQLExecute(conn, cmd)
        DBAccessHelper.DBConnectionClose(conn)
        conn = Nothing
    End Sub

    Public Shared Sub DBUpdateProduct(p As Product)
        If p Is Nothing Then
            Return
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
        DBAccessHelper.DBSQLExecute(conn, cmd)
        DBAccessHelper.DBConnectionClose(conn)
        conn = Nothing
    End Sub
End Class

