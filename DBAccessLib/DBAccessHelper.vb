' '*****************************************************************************************
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

    Public Shared Function DBInsertOrUpdateOrder(o As Order) As Integer
        If o Is Nothing Then
            Return -1
        End If
        If o.ID = 0 Then
            Return DBInsertOrder(o)
        Else
            If DBUpdateOrder(o) Then
                Return o.ID
            Else
                Return -1
            End If
        End If
    End Function

    ' return the order id of the new item, -1 on fail
    Public Shared Function DBInsertOrder(o As Order) As Integer
        Dim retVal As Integer = -1
        If o Is Nothing Then
            Return -1
        End If
        ' Get the connection
        Dim conn As SqlClient.SqlConnection = DBAccessHelper.DBGetConnection()
        ' Create the command
        Dim cmd As SqlCommand = conn.CreateCommand

        ' Set the command type and text for the stored procedure
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "dbo.sp_insert_order"

        ' Set up the parameters and values
        cmd.Parameters.Add("@date", SqlDbType.Date)
        cmd.Parameters("@date").Value = o.order_date
        cmd.Parameters.Add("@custid", SqlDbType.Int)
        cmd.Parameters("@custid").Value = o.customer_id
        cmd.Parameters.Add("@disc", SqlDbType.Float)
        cmd.Parameters("@disc").Value = o.discount
        cmd.Parameters.Add("@shipaddr", SqlDbType.Int)
        cmd.Parameters("@shipaddr").Value = o.ship_addr_id

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
    Public Shared Function DBDeleteOrder(id As Integer) As Boolean
        Dim bRetVal As Boolean = False

        ' Get the connection
        Dim conn As SqlClient.SqlConnection = DBAccessHelper.DBGetConnection()
        ' Create the command
        Dim cmd As SqlCommand = conn.CreateCommand

        ' Set the command type and text for the stored procedure
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "dbo.sp_delete_order"

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
    Public Shared Function DBUpdateOrder(o As Order) As Boolean
        Dim bRetVal As Boolean = False
        If o Is Nothing Then
            Return bRetVal
        End If
        ' Get the connection
        Dim conn As SqlClient.SqlConnection = DBAccessHelper.DBGetConnection()
        ' Create the command
        Dim cmd As SqlCommand = conn.CreateCommand

        ' Set the command type and text for the stored procedure
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "dbo.sp_update_order"

        ' Set up the parameters and values
        cmd.Parameters.Add("@id", SqlDbType.Int)
        cmd.Parameters("@id").Value = o.ID
        cmd.Parameters.Add("@date", SqlDbType.Date)
        cmd.Parameters("@date").Value = o.order_date
        cmd.Parameters.Add("@custid", SqlDbType.Int)
        cmd.Parameters("@custid").Value = o.customer_id
        cmd.Parameters.Add("@disc", SqlDbType.Float)
        cmd.Parameters("@disc").Value = o.discount
        cmd.Parameters.Add("@shipaddr", SqlDbType.Int)
        cmd.Parameters("@shipaddr").Value = o.ship_addr_id

        If DBAccessHelper.DBSQLExecute(conn, cmd) = True Then
            bRetVal = True
        End If
        DBAccessHelper.DBConnectionClose(conn)
        conn = Nothing
        Return bRetVal
    End Function

    ' return Nothing if orderitem not found, otherwise returns an OrderItem
    Public Shared Function DBReadOrderItemByID(id As Integer) As OrderItem
        ' Get the connection
        Dim conn As SqlClient.SqlConnection = DBAccessHelper.DBGetConnection()
        ' Create the command
        Dim cmd As SqlCommand = conn.CreateCommand
        Dim i As OrderItem = Nothing

        ' Set the command type and text for the stored procedure
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "dbo.sp_read_orderline"

        ' Set up the input and output parameters
        cmd.Parameters.Add("@id", SqlDbType.Int)
        cmd.Parameters("@id").Direction = ParameterDirection.InputOutput
        cmd.Parameters("@id").Value = id
        cmd.Parameters.Add("@orderid", SqlDbType.Int)
        cmd.Parameters("@orderid").Direction = ParameterDirection.Output
        cmd.Parameters.Add("@prodid", SqlDbType.Int)
        cmd.Parameters("@prodid").Direction = ParameterDirection.Output
        cmd.Parameters.Add("@shipdate", SqlDbType.Date)
        cmd.Parameters("@shipdate").Direction = ParameterDirection.Output
        cmd.Parameters.Add("@quantity", SqlDbType.Int)
        cmd.Parameters("@quantity").Direction = ParameterDirection.Output

        Try
            conn.Open()
            cmd.ExecuteScalar()                     '# call SQL Stored procedure
            id = cmd.Parameters("@id").Value        ' retrieve the in/out param value
            If id <> -1 Then
                ' found the record, create and populate the new product object
                'Public Sub New(id As Integer, order_id As Integer, product As Integer, quantity As UInteger)
                Dim ship As Date? = Nothing
                If IsDBNull(cmd.Parameters("@shipdate").Value) = False Then
                    ship = cmd.Parameters("@shipdate").Value
                End If

                i = New OrderItem(id, cmd.Parameters("@orderid").Value,
                                cmd.Parameters("@prodid").Value,
                                cmd.Parameters("@quantity").Value, ship)
            End If

        Catch sqlExcept As SqlException
            ' nothing to do here...since the read is just a query
        Finally
            DBAccessHelper.DBConnectionClose(conn)
        End Try
        Return i
    End Function

    Public Shared Function DBInsertOrUpdateOrderItem(i As OrderItem) As Integer
        If i Is Nothing Then
            Return -1
        End If
        If i.ID = 0 Then
            Return DBInsertOrderItem(i)
        Else
            If DBUpdateOrderItem(i) Then
                Return i.ID
            Else
                Return -1
            End If
        End If
    End Function

    ' return the product id of the new item, -1 on fail
    Public Shared Function DBInsertOrderItem(i As OrderItem) As Integer
        Dim retVal As Integer = -1
        If i Is Nothing Then
            Return -1
        End If
        ' Get the connection
        Dim conn As SqlClient.SqlConnection = DBAccessHelper.DBGetConnection()
        ' Create the command
        Dim cmd As SqlCommand = conn.CreateCommand

        ' Set the command type and text for the stored procedure
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "dbo.sp_insert_orderline"

        ' Set up the parameters and values
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
    Public Shared Function DBDeleteOrderItem(id As Integer) As Boolean
        Dim bRetVal As Boolean = False

        ' Get the connection
        Dim conn As SqlClient.SqlConnection = DBAccessHelper.DBGetConnection()
        ' Create the command
        Dim cmd As SqlCommand = conn.CreateCommand

        ' Set the command type and text for the stored procedure
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "dbo.sp_delete_orderline"

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
    Public Shared Function DBUpdateOrderItem(i As OrderItem) As Boolean
        Dim bRetVal As Boolean = False
        If i Is Nothing Then
            Return bRetVal
        End If
        ' Get the connection
        Dim conn As SqlClient.SqlConnection = DBAccessHelper.DBGetConnection()
        ' Create the command
        Dim cmd As SqlCommand = conn.CreateCommand

        ' Set the command type and text for the stored procedure
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "dbo.sp_update_orderline"

        ' Set up the parameters and values
        cmd.Parameters.Add("@id", SqlDbType.Int)
        cmd.Parameters("@id").Value = i.ID

        cmd.Parameters.Add("@orderid", SqlDbType.Int)
        cmd.Parameters("@orderid").Value = i.order_id
        cmd.Parameters.Add("@prodid", SqlDbType.Int)
        cmd.Parameters("@prodid").Value = i.product_id
        cmd.Parameters.Add("@quantity", SqlDbType.Int)
        cmd.Parameters("@quantity").Value = i.quantity
        cmd.Parameters.Add("@shipdate", SqlDbType.Date)
        If IsNothing(i.ship_date) Then
            cmd.Parameters("@shipdate").Value = DBNull.Value
        Else
            cmd.Parameters("@shipdate").Value = i.ship_date
        End If
        If DBAccessHelper.DBSQLExecute(conn, cmd) = True Then
            bRetVal = True
        End If
        DBAccessHelper.DBConnectionClose(conn)
        conn = Nothing
        Return bRetVal
    End Function
End Class

