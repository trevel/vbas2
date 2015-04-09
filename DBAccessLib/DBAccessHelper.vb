' '*****************************************************************************************
' Student Names: Laurie Shields (034448142)
'                Mark Lindan (063336143)
' CVB815 - DBAccessHelper
'*******************************************************************************************
Imports System.Data.SqlClient
Imports Database
Imports System.Configuration
Public Class DBAccessHelper
    Private Shared connString As String = My.Settings.ConnectionString
    ' Propagate the connection string down from Assignment_2

    Public Shared Function getConnectionString() As String
        Return connString
    End Function

    Public Shared Function DBGetConnection() As SqlClient.SqlConnection
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

    ' return the product id, -1 on fail
    Public Shared Function DBInsertOrUpdateProduct(p As Product) As Integer
        If p Is Nothing Then
            Return -1
        End If
        If p.ID = 0 Then
            Return DBInsertProduct(p)
        Else
            If DBUpdateProduct(p) Then
                Return p.ID
            Else
                Return -1
            End If
        End If
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
        cmd.Parameters.Add("@price", SqlDbType.Money, ParameterDirection.Input)
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
    Public Shared Function DBDeleteProduct(id As Integer) As Boolean
        Dim bRetVal As Boolean = False

        ' Get the connection
        Dim conn As SqlClient.SqlConnection = DBAccessHelper.DBGetConnection()
        ' Create the command
        Dim cmd As SqlCommand = conn.CreateCommand

        ' Set the command type and text for the stored procedure
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "dbo.sp_delete_product"

        ' Set up the parameters and values
        cmd.Parameters.Add("@id", SqlDbType.Int)
        cmd.Parameters("@id").Value = id

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
        cmd.Parameters.Add("@price", SqlDbType.Money)
        cmd.Parameters("@price").Value = p.Price
        cmd.Parameters.Add("@inv", SqlDbType.Int)
        cmd.Parameters("@inv").Value = p.Inventory
        cmd.Parameters.Add("@active", SqlDbType.Bit)
        If p.active = True Then
            cmd.Parameters("@active").Value = 1
        Else
            cmd.Parameters("@active").Value = 0
        End If
        If DBAccessHelper.DBSQLExecute(conn, cmd) = True Then
            bRetVal = True
        End If
        DBAccessHelper.DBConnectionClose(conn)
        conn = Nothing
        Return bRetVal
    End Function

    ' return Nothing if address not found, otherwise returns an Address
    Public Shared Function DBReadAddressByID(id As Integer) As Address
        ' Get the connection
        Dim conn As SqlClient.SqlConnection = DBAccessHelper.DBGetConnection()
        ' Create the command
        Dim cmd As SqlCommand = conn.CreateCommand
        Dim a As Address = Nothing

        ' Set the command type and text for the stored procedure
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "dbo.sp_read_address"

        ' Set up the input and output parameters
        cmd.Parameters.Add("@id", SqlDbType.Int)
        cmd.Parameters("@id").Direction = ParameterDirection.InputOutput
        cmd.Parameters("@id").Value = id
        cmd.Parameters.Add("@street", SqlDbType.NVarChar, 50)
        cmd.Parameters("@street").Direction = ParameterDirection.Output
        cmd.Parameters.Add("@city", SqlDbType.NVarChar, 50)
        cmd.Parameters("@city").Direction = ParameterDirection.Output
        cmd.Parameters.Add("@province", SqlDbType.Char, 2)
        cmd.Parameters("@province").Direction = ParameterDirection.Output
        cmd.Parameters.Add("@postcode", SqlDbType.Char, 6)
        cmd.Parameters("@postcode").Direction = ParameterDirection.Output
        cmd.Parameters.Add("@type", SqlDbType.Bit)
        cmd.Parameters("@type").Direction = ParameterDirection.Output
        cmd.Parameters.Add("@custid", SqlDbType.Int)
        cmd.Parameters("@custid").Direction = ParameterDirection.Output

        Try
            conn.Open()
            cmd.ExecuteScalar()                     '# call SQL Stored procedure
            id = cmd.Parameters("@id").Value        ' retrieve the in/out param value
            If id <> -1 Then
                ' found the record, create and populate the new address object
                a = New Address(id, cmd.Parameters("@custid").Value,
                        cmd.Parameters("@street").Value,
                        cmd.Parameters("@city").Value,
                        cmd.Parameters("@province").Value,
                        cmd.Parameters("@postcode").Value,
                        cmd.Parameters("@type").Value)
            End If

        Catch sqlExcept As SqlException
            ' nothing to do here...since the read is just a query
        Finally
            DBAccessHelper.DBConnectionClose(conn)
        End Try
        Return a
    End Function

    ' return the address id, -1 on fail
    Public Shared Function DBInsertOrUpdateAddress(a As Address) As Integer
        If a Is Nothing Then
            Return -1
        End If
        If a.ID = 0 Then
            Return DBInsertAddress(a)
        Else
            If DBUpdateAddress(a) Then
                Return a.ID
            Else
                Return -1
            End If
        End If
    End Function

    ' return the product id of the new item, -1 on fail
    Public Shared Function DBInsertAddress(a As Address) As Integer
        Dim retVal As Integer = -1
        If a Is Nothing Then
            Return -1
        End If
        ' Get the connection
        Dim conn As SqlClient.SqlConnection = DBAccessHelper.DBGetConnection()
        ' Create the command
        Dim cmd As SqlCommand = conn.CreateCommand

        ' Set the command type and text for the stored procedure
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "dbo.sp_insert_address"

        ' Set up the parameters and values
        cmd.Parameters.Add("@street", SqlDbType.NVarChar, 50, ParameterDirection.Input)
        cmd.Parameters("@street").Value = a.street
        cmd.Parameters.Add("@city", SqlDbType.NVarChar, 50, ParameterDirection.Input)
        cmd.Parameters("@city").Value = a.city
        cmd.Parameters.Add("@province", SqlDbType.Char, 2, ParameterDirection.Input)
        cmd.Parameters("@province").Value = a.province
        cmd.Parameters.Add("@postcode", SqlDbType.Char, 6, ParameterDirection.Input)
        cmd.Parameters("@postcode").Value = a.postal_code
        cmd.Parameters.Add("@type", SqlDbType.Bit, ParameterDirection.Input)
        cmd.Parameters("@type").Value = a.type
        cmd.Parameters.Add("@custid", SqlDbType.Int, ParameterDirection.Input)
        cmd.Parameters("@custid").Value = a.cust_id

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
    Public Shared Function DBDeleteAddress(id As Integer) As Boolean
        Dim bRetVal As Boolean = False

        ' Get the connection
        Dim conn As SqlClient.SqlConnection = DBAccessHelper.DBGetConnection()
        ' Create the command
        Dim cmd As SqlCommand = conn.CreateCommand

        ' Set the command type and text for the stored procedure
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "dbo.sp_delete_address"

        ' Set up the parameters and values
        cmd.Parameters.Add("@id", SqlDbType.Int)
        cmd.Parameters("@id").Value = id

        If DBAccessHelper.DBSQLExecute(conn, cmd) = True Then
            bRetVal = True
        End If
        DBAccessHelper.DBConnectionClose(conn)
        conn = Nothing
        Return bRetVal
    End Function

    ' true on success, false on fail
    Public Shared Function DBUpdateAddress(a As Address) As Boolean
        Dim bRetVal As Boolean = False
        If a Is Nothing Then
            Return bRetVal
        End If
        ' Get the connection
        Dim conn As SqlClient.SqlConnection = DBAccessHelper.DBGetConnection()
        ' Create the command
        Dim cmd As SqlCommand = conn.CreateCommand

        ' Set the command type and text for the stored procedure
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "dbo.sp_update_address"

        ' Set up the parameters and values
        cmd.Parameters.Add("@id", SqlDbType.Int)
        cmd.Parameters("@id").Value = a.ID
        cmd.Parameters.Add("@street", SqlDbType.NVarChar, 50, ParameterDirection.Input)
        cmd.Parameters("@street").Value = a.street
        cmd.Parameters.Add("@city", SqlDbType.NVarChar, 50, ParameterDirection.Input)
        cmd.Parameters("@city").Value = a.city
        cmd.Parameters.Add("@province", SqlDbType.Char, 2, ParameterDirection.Input)
        cmd.Parameters("@province").Value = a.province
        cmd.Parameters.Add("@postcode", SqlDbType.Char, 6, ParameterDirection.Input)
        cmd.Parameters("@postcode").Value = a.postal_code
        cmd.Parameters.Add("@type", SqlDbType.Bit, ParameterDirection.Input)
        cmd.Parameters("@type").Value = a.type
        cmd.Parameters.Add("@custid", SqlDbType.Int, ParameterDirection.Input)
        cmd.Parameters("@custid").Value = a.cust_id
        If DBAccessHelper.DBSQLExecute(conn, cmd) = True Then
            bRetVal = True
        End If
        DBAccessHelper.DBConnectionClose(conn)
        conn = Nothing
        Return bRetVal
    End Function

    ' return Nothing if customer not found, otherwise returns a Customer
    Public Shared Function DBReadCustomerByID(id As Integer) As Customer
        ' Get the connection
        Dim conn As SqlClient.SqlConnection = DBAccessHelper.DBGetConnection()
        ' Create the command
        Dim cmd As SqlCommand = conn.CreateCommand
        Dim c As Customer = Nothing

        ' Set the command type and text for the stored procedure
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "dbo.sp_read_customer"

        ' Set up the input and output parameters
        cmd.Parameters.Add("@id", SqlDbType.Int)
        cmd.Parameters("@id").Direction = ParameterDirection.InputOutput
        cmd.Parameters("@id").Value = id
        cmd.Parameters.Add("@name", SqlDbType.NVarChar, 50)
        cmd.Parameters("@name").Direction = ParameterDirection.Output
        cmd.Parameters.Add("@email", SqlDbType.NVarChar, 50)
        cmd.Parameters("@email").Direction = ParameterDirection.Output
        cmd.Parameters.Add("@phone", SqlDbType.NVarChar, 50)
        cmd.Parameters("@phone").Direction = ParameterDirection.Output
        cmd.Parameters.Add("@credit", SqlDbType.Money)
        cmd.Parameters("@credit").Direction = ParameterDirection.Output

        Try
            conn.Open()
            cmd.ExecuteScalar()                     '# call SQL Stored procedure
            id = cmd.Parameters("@id").Value        ' retrieve the in/out param value
            If id <> -1 Then
                ' found the record, create and populate the new customer object
                c = New Customer(id, cmd.Parameters("@name").Value,
                        cmd.Parameters("@email").Value, 0, 0,
                        cmd.Parameters("@phone").Value,
                        cmd.Parameters("@credit").Value)
            End If

        Catch sqlExcept As SqlException
            ' nothing to do here...since the read is just a query
        Finally
            DBAccessHelper.DBConnectionClose(conn)
        End Try
        Return c
    End Function

    ' return the customer id, -1 on fail
    Public Shared Function DBInsertOrUpdateCustomer(c As Customer) As Integer
        If c Is Nothing Then
            Return -1
        End If
        If c.ID = 0 Then
            Return DBInsertCustomer(c)
        Else
            If DBUpdateCustomer(c) Then
                Return c.ID
            Else
                Return -1
            End If
        End If
    End Function

    ' return the customer id of the new item, -1 on fail
    Public Shared Function DBInsertCustomer(c As Customer) As Integer
        Dim retVal As Integer = -1
        If c Is Nothing Then
            Return -1
        End If
        ' Get the connection
        Dim conn As SqlClient.SqlConnection = DBAccessHelper.DBGetConnection()
        ' Create the command
        Dim cmd As SqlCommand = conn.CreateCommand

        ' Set the command type and text for the stored procedure
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "dbo.sp_insert_customer"

        ' Set up the parameters and values
        cmd.Parameters.Add("@name", SqlDbType.NVarChar, 50, ParameterDirection.Input)
        cmd.Parameters("@name").Value = c.name
        cmd.Parameters.Add("@email", SqlDbType.NVarChar, 50, ParameterDirection.Input)
        cmd.Parameters("@email").Value = c.email
        cmd.Parameters.Add("@phone", SqlDbType.NVarChar, 50, ParameterDirection.Input)
        cmd.Parameters("@phone").Value = c.phone_number
        cmd.Parameters.Add("@credit", SqlDbType.Money)
        cmd.Parameters("@credit").Value = c.credit_limit

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
    Public Shared Function DBDeleteCustomer(id As Integer) As Boolean
        Dim bRetVal As Boolean = False

        ' Get the connection
        Dim conn As SqlClient.SqlConnection = DBAccessHelper.DBGetConnection()
        ' Create the command
        Dim cmd As SqlCommand = conn.CreateCommand

        ' Set the command type and text for the stored procedure
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "dbo.sp_delete_customer"

        ' Set up the parameters and values
        cmd.Parameters.Add("@id", SqlDbType.Int)
        cmd.Parameters("@id").Value = id

        If DBAccessHelper.DBSQLExecute(conn, cmd) = True Then
            bRetVal = True
        End If
        DBAccessHelper.DBConnectionClose(conn)
        conn = Nothing
        Return bRetVal
    End Function

    ' true on success, false on fail
    Public Shared Function DBUpdateCustomer(c As Customer) As Boolean
        Dim bRetVal As Boolean = False
        If c Is Nothing Then
            Return bRetVal
        End If
        ' Get the connection
        Dim conn As SqlClient.SqlConnection = DBAccessHelper.DBGetConnection()
        ' Create the command
        Dim cmd As SqlCommand = conn.CreateCommand

        ' Set the command type and text for the stored procedure
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "dbo.sp_update_customer"

        ' Set up the parameters and values
        cmd.Parameters.Add("@id", SqlDbType.Int)
        cmd.Parameters("@id").Value = c.ID
        cmd.Parameters.Add("@name", SqlDbType.NVarChar, 50)
        cmd.Parameters("@name").Value = c.name
        cmd.Parameters.Add("@email", SqlDbType.NVarChar, 50)
        cmd.Parameters("@email").Value = c.email
        cmd.Parameters.Add("@phone", SqlDbType.NVarChar, 50)
        cmd.Parameters("@phone").Value = c.phone_number
        cmd.Parameters.Add("@credit", SqlDbType.Money)
        cmd.Parameters("@credit").Value = c.credit_limit

        If DBAccessHelper.DBSQLExecute(conn, cmd) = True Then
            bRetVal = True
        End If
        DBAccessHelper.DBConnectionClose(conn)
        conn = Nothing
        Return bRetVal
    End Function

    ' return Nothing if order not found, otherwise returns an Order
    Public Shared Function DBReadOrderByID(id As Integer) As Order
        ' Get the connection
        Dim conn As SqlClient.SqlConnection = DBAccessHelper.DBGetConnection()
        ' Create the command
        Dim cmd As SqlCommand = conn.CreateCommand
        Dim o As Order = Nothing

        ' Set the command type and text for the stored procedure
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "dbo.sp_read_order"

        ' Set up the input and output parameters
        cmd.Parameters.Add("@id", SqlDbType.Int)
        cmd.Parameters("@id").Direction = ParameterDirection.InputOutput
        cmd.Parameters("@id").Value = id
        cmd.Parameters.Add("@custid", SqlDbType.Int)
        cmd.Parameters("@custid").Direction = ParameterDirection.Output
        cmd.Parameters.Add("@date", SqlDbType.Date)
        cmd.Parameters("@date").Direction = ParameterDirection.Output
        cmd.Parameters.Add("@disc", SqlDbType.Float)
        cmd.Parameters("@disc").Direction = ParameterDirection.Output
        cmd.Parameters.Add("@shipaddr", SqlDbType.Int)
        cmd.Parameters("@shipaddr").Direction = ParameterDirection.Output

        Try
            conn.Open()
            cmd.ExecuteScalar()                     '# call SQL Stored procedure
            id = cmd.Parameters("@id").Value        ' retrieve the in/out param value
            If id <> -1 Then
                ' found the record, create and populate the new product object
                o = New Order(id, cmd.Parameters("@custid").Value,
                                cmd.Parameters("@date").Value,
                                cmd.Parameters("@disc").Value,
                                cmd.Parameters("@shipaddr").Value)
            End If

        Catch sqlExcept As SqlException
            ' nothing to do here...since the read is just a query
        Finally
            DBAccessHelper.DBConnectionClose(conn)
        End Try
        Return o
    End Function

    ' adds or updates an order and the associated line items. line item is sent with quantity
    ' of 0 for deletion
    Public Shared Function DBInsertOrUpdateOrder(o As Order, items As List(Of OrderItem)) As Integer
        ' Get the connection
        Dim conn As SqlClient.SqlConnection = DBAccessHelper.DBGetConnection()
        Dim transaction As SqlTransaction = Nothing
        Dim cmd As SqlCommand = Nothing
        Dim bFailure As Boolean = False
        Try
            conn.Open()
            cmd = conn.CreateCommand
            transaction = conn.BeginTransaction()   '# begin the transaction
            cmd.Transaction = transaction           '# setup command transaction
            cmd.CommandType = CommandType.StoredProcedure '# command type is stored procedure
            ' for existing order we update
            If o.ID <> 0 Then
                cmd.CommandText = "dbo.sp_update_order"
                ' Set up the Input parameters
                DBSetOrderParameters(o, cmd, False)
                cmd.ExecuteScalar()                     '# call SQL Stored procedure
            Else
                ' its a new order
                cmd.CommandText = "dbo.sp_insert_order"
                ' Set up the Input parameters
                DBSetOrderParameters(o, cmd, True)
                cmd.ExecuteScalar()                     '# call SQL Stored procedure
                o.ID = cmd.Parameters("@id").Value
            End If
            ' any failure above should generate exception and fall to catch block
            ' go through the list of items and add or remove each one inside the transaction
            For Each ol As OrderItem In items
                If ol.ID = 0 Then
                    ' it's a new order line to add
                    cmd.CommandText = "dbo.sp_insert_orderline"
                    ol.order_id = o.ID
                    DBSetOrderItemParameters(ol, cmd, True)
                    cmd.ExecuteScalar()
                    ol.ID = cmd.Parameters("@id").Value
                Else
                    If ol.ship_date Is Nothing Then
                        If ol.quantity > 0 Then
                            cmd.CommandText = "dbo.sp_update_orderline"
                            DBSetOrderItemParameters(ol, cmd, False)
                        Else
                            cmd.CommandText = "dbo.sp_delete_orderline"
                            ' Set up the parameters and values
                            cmd.Parameters.Clear()
                            cmd.Parameters.Add("@id", SqlDbType.Int)
                            cmd.Parameters("@id").Value = ol.ID
                        End If
                        cmd.ExecuteScalar()
                    End If
                End If
            Next
            transaction.Commit()
        Catch sqlExcept As SqlException          '# transaction failure
            bFailure = True
            If transaction IsNot Nothing Then
                transaction.Rollback()          '# rollback transaction
            End If
        Finally
            Try
                conn.Close()
            Catch ex As Exception
                ex = Nothing
            Finally
                conn = Nothing
            End Try
        End Try
        If bFailure = True Then
            Return -1
        Else
            Return o.ID
        End If
    End Function

    ' set up the parameters to the stored procedure call for adding the order
    Private Shared Sub DBSetOrderParameters(o As Order, cmd As SqlCommand, bIsNewOrder As Boolean)
        ' Set up the parameters and values
        cmd.Parameters.Clear()
        cmd.Parameters.Add("@date", SqlDbType.Date)
        cmd.Parameters("@date").Value = o.order_date
        cmd.Parameters.Add("@custid", SqlDbType.Int)
        cmd.Parameters("@custid").Value = o.customer_id
        cmd.Parameters.Add("@disc", SqlDbType.Float)
        cmd.Parameters("@disc").Value = o.discount
        cmd.Parameters.Add("@shipaddr", SqlDbType.Int)
        cmd.Parameters("@shipaddr").Value = o.ship_addr_id
        cmd.Parameters.Add("@id", SqlDbType.Int)
        cmd.Parameters("@id").Value = o.ID
        If bIsNewOrder Then
            cmd.Parameters("@id").Direction = ParameterDirection.Output
        End If
    End Sub

    ' true on success, false on fail. Will attempt to delete order and all line
    ' items. If any items are shipped, the operation will fail
    Public Shared Function DBDeleteOrder(id As Integer) As Boolean
        Dim conn As SqlClient.SqlConnection = DBAccessHelper.DBGetConnection()
        Dim transaction As SqlTransaction = Nothing
        Dim cmd As SqlCommand = Nothing
        Dim bRetVal = True

        Try
            conn.Open()
            cmd = conn.CreateCommand
            transaction = conn.BeginTransaction()   '# begin the transaction
            cmd.Transaction = transaction           '# setup command transaction
            cmd.CommandType = CommandType.StoredProcedure '# command type is stored procedure
            cmd.CommandText = "dbo.sp_delete_order"

            ' Set up the parameters and values
            cmd.Parameters.Add("@id", SqlDbType.Int)
            cmd.Parameters("@id").Value = id
            cmd.ExecuteScalar()
            transaction.Commit()
        Catch
            bRetVal = False
            If transaction IsNot Nothing Then
                transaction.Rollback()          '# rollback transaction
            End If
        Finally
            Try
                conn.Close()
            Catch ex As Exception
                ex = Nothing
            Finally
                conn = Nothing
            End Try
        End Try
        Return bRetVal
    End Function

    ' sets up the parameters for the stored procedure call for adding an order line
    Private Shared Sub DBSetOrderItemParameters(i As OrderItem, cmd As SqlCommand, bIsNewItem As Boolean)
        cmd.Parameters.Clear()
        cmd.Parameters.Add("@shipdate", SqlDbType.Date)
        If IsNothing(i.ship_date) Then
            cmd.Parameters("@shipdate").Value = DBNull.Value
        Else
            cmd.Parameters("@shipdate").Value = i.ship_date
        End If
        cmd.Parameters.Add("@orderid", SqlDbType.Int)
        cmd.Parameters("@orderid").Value = i.order_id
        cmd.Parameters.Add("@prodid", SqlDbType.Int)
        cmd.Parameters("@prodid").Value = i.product_id
        cmd.Parameters.Add("@quantity", SqlDbType.Int)
        cmd.Parameters("@quantity").Value = i.quantity
        cmd.Parameters.Add("@id", SqlDbType.Int)
        cmd.Parameters("@id").Value = i.ID
        If bIsNewItem Then
            cmd.Parameters("@id").Direction = ParameterDirection.Output
        End If
    End Sub

    ' ship all items that we can in the order specified. Returns -1
    ' on fail otherwise returns a count of number of lines
    ' shipped
    Public Shared Function DBOrderShip(id As Integer) As Integer
        Dim conn As SqlClient.SqlConnection = DBAccessHelper.DBGetConnection()
        Dim transaction As SqlTransaction = Nothing
        Dim cmd As SqlCommand = Nothing
        Dim count As Integer = 0
        Dim dr As SqlDataReader = Nothing
        Dim tmpList As New List(Of Integer)
        Dim prodId As Integer
        Dim quantity As Integer

        Try
            conn.Open()
            cmd = conn.CreateCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT o.id FROM dbo.Order_Line o " _
                        + "JOIN dbo.Product p ON (o.product_id=p.id)  " _
                        + " WHERE o.order_id = @id " _
                        + " AND o.quantity <= p.inventory " _
                        + " AND o.ship_date IS null"

            cmd.Parameters.Add("@id", SqlDbType.Int)
            cmd.Parameters("@id").Value = id
            dr = cmd.ExecuteReader  'result set will be returned as a read only data reader
            While dr.Read()
                ' store the IDs from the order_items in a temporary list
                tmpList.Add(dr.GetInt32(0))
            End While
            dr.Close()
            ' now set up the stored procedure calls
            cmd = conn.CreateCommand
            transaction = conn.BeginTransaction()   '# begin the transaction
            cmd.Transaction = transaction
            cmd.CommandType = CommandType.StoredProcedure
            For Each i As Integer In tmpList
                cmd.Parameters.Clear()
                cmd.CommandText = "dbo.sp_ship_order_item"
                cmd.Parameters.Add("@id", SqlDbType.Int)
                cmd.Parameters("@id").Value = i
                cmd.Parameters.Add("@prodid", SqlDbType.Int)
                cmd.Parameters("@prodid").Direction = ParameterDirection.Output
                cmd.Parameters.Add("@qty", SqlDbType.Int)
                cmd.Parameters("@qty").Direction = ParameterDirection.Output
                cmd.ExecuteScalar()
                prodId = cmd.Parameters("@prodid").Value
                quantity = cmd.Parameters("@qty").Value
                cmd.Parameters.Clear()
                cmd.CommandText = "dbo.sp_product_removeinv"
                cmd.Parameters.Add("@id", SqlDbType.Int)
                cmd.Parameters("@id").Value = prodId
                cmd.Parameters.Add("@amt", SqlDbType.Int)
                cmd.Parameters("@amt").Value = quantity
                cmd.ExecuteScalar()
                count = count + 1
            Next
            transaction.Commit()
        Catch
            count = -1
            If transaction IsNot Nothing Then
                transaction.Rollback()          '# rollback transaction
            End If
        Finally
            Try
                conn.Close()
            Catch ex As Exception
                ex = Nothing
            Finally
                conn = Nothing
            End Try
        End Try
        Return count
    End Function
End Class

