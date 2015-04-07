' '*****************************************************************************************
' Student Names: Laurie Shields (034448142)
'                Mark Lindan (063336143)
' CVB815 - DBAccessTest
'*******************************************************************************************
Imports DBAccessLib
Imports Database
Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports System.Data.SqlClient
Imports Database.Address

<TestClass()> Public Class DBAccessTest
    Dim prod1 As Product = Nothing
    Dim cust1 As Customer = Nothing
    Dim addr1 As Address = Nothing
    Dim ordlin1 As OrderItem = Nothing
    Dim ord1 As Order = Nothing

    <TestMethod()> Public Sub TestMethod1()
    End Sub

    <TestInitialize()> Public Sub Initialize()
        Assert.IsNull(prod1)
        prod1 = New Product(0, "Something", 1.0, 1, True)
        cust1 = New Customer(0, "One", "one@one.com", 0, 0, "123-232-1243", 5342)
        'objects are created and references are updated accordingly
        Assert.IsNotNull(prod1)
        Assert.IsNotNull(cust1)
        prod1.ID = DBAccessHelper.DBInsertProduct(prod1)
        cust1.ID = DBAccessHelper.DBInsertCustomer(cust1)
        addr1 = New Address(0, cust1.ID, "123 Some Street", "Toronto", "ON", "M1K2N4", AddressType.mailing_address)
        Assert.IsNotNull(addr1)
        addr1.ID = DBAccessHelper.DBInsertAddress(addr1)
        ord1 = New Order(0, cust1.ID, Today, 10, addr1.ID)
        ord1.ID = DBAccessHelper.DBInsertOrder(ord1)
        ordlin1 = New OrderItem(0, ord1.ID, prod1.ID, 99, Nothing)
        ordlin1.ID = DBAccessHelper.DBInsertOrderItem(ordlin1)
        Assert.IsNotNull(ord1)
        Assert.IsNotNull(ordlin1)
        Assert.AreNotEqual(prod1.ID, -1)
        Assert.AreNotEqual(cust1.ID, -1)
        Assert.AreNotEqual(addr1.ID, -1)
        Assert.AreNotEqual(ord1.ID, -1)
        Assert.AreNotEqual(ordlin1.ID, -1)
    End Sub

    ' called after each test case
    <TestCleanup()> Public Sub CleanUp()
        Assert.IsNotNull(prod1)
        Assert.IsNotNull(cust1)
        Assert.IsNotNull(addr1)
        Assert.IsNotNull(ord1)
        Assert.IsNotNull(ordlin1)
        Assert.IsTrue(DBAccessHelper.DBDeleteOrderItem(ordlin1))
        Assert.IsTrue(DBAccessHelper.DBDeleteOrder(ord1))
        Assert.IsTrue(DBAccessHelper.DBDeleteProduct(prod1))
        Assert.IsTrue(DBAccessHelper.DBDeleteAddress(addr1))
        Assert.IsTrue(DBAccessHelper.DBDeleteCustomer(cust1))
        prod1 = DBAccessHelper.DBReadProductByID(prod1.ID)
        addr1 = DBAccessHelper.DBReadAddressByID(addr1.ID)
        cust1 = DBAccessHelper.DBReadCustomerByID(cust1.ID)
        ordlin1 = DBAccessHelper.DBReadOrderItemByID(ordlin1.ID)
        ord1 = DBAccessHelper.DBReadOrderByID(ord1.ID)
        ' objects are cleaned up
        Assert.IsNull(prod1)
        Assert.IsNull(cust1)
        Assert.IsNull(addr1)
        Assert.IsNull(ord1)
        Assert.IsNull(ord1)
    End Sub

    <TestMethod()> Public Sub TestDBOpenClose()
        Dim conn As SqlConnection = DBAccessHelper.DBGetConnection()
        Assert.IsNotNull(conn)
        DBAccessHelper.DBConnectionClose(conn)
        Assert.IsNull(conn)
    End Sub
    ' Test inserting a product, read it back by description, then remove it and make sure it's gone

    <TestMethod()> Public Sub TestDBInsertProduct()
        Dim p1 As New Product(0, "Test Product 2", 1.99, 12, True)
        Dim p2 As Product = Nothing

        p1.ID = DBAccessHelper.DBInsertProduct(p1)
        Assert.IsTrue(p1.ID > 0)
        ' read the product back and compare it
        p2 = DBAccessHelper.DBReadProductByID(p1.ID)
        Assert.IsNotNull(p2)
        Assert.AreEqual(p2.Description, p1.Description)
        Assert.AreEqual(p2.ID, p1.ID)
        Assert.AreEqual(p2.Inventory, p1.Inventory)
        Assert.AreEqual(p2.active, p1.active)
    End Sub

    <TestMethod()> Public Sub TestDBDeleteProduct()
        Dim p As Product = Nothing
        Assert.IsNotNull(prod1)
        Assert.IsTrue(DBAccessHelper.DBDeleteProduct(prod1))
        p = DBAccessHelper.DBReadProductByID(prod1.ID)
        ' make sure we didn't find it
        Assert.IsNull(p)
    End Sub

    <TestMethod()> Public Sub TestDBUpdateProduct()
        Dim p As Product = Nothing
        Assert.IsNotNull(prod1)
        prod1.Description = "New Description"
        prod1.Inventory = 99
        prod1.active = False
        prod1.Price = 77.77
        Assert.IsTrue(DBAccessHelper.DBUpdateProduct(prod1))
        p = DBAccessHelper.DBReadProductByID(prod1.ID)
        Assert.IsNotNull(p)
        Assert.AreEqual(p.Description, prod1.Description)
        Assert.AreEqual(p.ID, prod1.ID)
        Assert.AreEqual(p.Inventory, prod1.Inventory)
        Assert.AreEqual(p.active, prod1.active)
        Assert.AreEqual(p.Price, prod1.Price)
    End Sub

    <TestMethod()> Public Sub TestDBInsertCustomer()
        Dim c1 As New Customer(0, "Test Customer", "someemail@google.com", 0, 0, "111-222-3333", 9999.99)
        Dim c2 As Customer = Nothing

        c1.ID = DBAccessHelper.DBInsertCustomer(c1)
        Assert.IsTrue(c1.ID > 0)
        ' read the product back and compare it
        c2 = DBAccessHelper.DBReadCustomerByID(c1.ID)
        Assert.IsNotNull(c2)
        Assert.AreEqual(c2.ID, c1.ID)
        Assert.AreEqual(c2.name, c1.name)
        Assert.AreEqual(c2.email, c1.email)
        Assert.AreEqual(c2.phone_number, c1.phone_number)
        Assert.AreEqual(c2.credit_limit, c1.credit_limit)
    End Sub

    <TestMethod()> Public Sub TestDBDeleteCustomer()
        Dim c As Customer = Nothing
        Assert.IsNotNull(cust1)
        Assert.IsTrue(DBAccessHelper.DBDeleteAddress(addr1))
        Assert.IsTrue(DBAccessHelper.DBDeleteCustomer(cust1))
        c = DBAccessHelper.DBReadCustomerByID(cust1.ID)
        ' make sure we didn't find it
        Assert.IsNull(c)
    End Sub

    <TestMethod()> Public Sub TestDBUpdateCustomer()
        Dim c As Customer = Nothing
        Assert.IsNotNull(cust1)
        cust1.name = "New Name"
        cust1.email = "new@email.com"
        cust1.phone_number = "999-888-7777"
        cust1.credit_limit = 11111.11
        Assert.IsTrue(DBAccessHelper.DBUpdateCustomer(cust1))
        c = DBAccessHelper.DBReadCustomerByID(cust1.ID)
        Assert.IsNotNull(c)
        Assert.AreEqual(c.name, cust1.name)
        Assert.AreEqual(c.ID, cust1.ID)
        Assert.AreEqual(c.email, cust1.email)
        Assert.AreEqual(c.phone_number, cust1.phone_number)
        Assert.AreEqual(c.credit_limit, cust1.credit_limit)
    End Sub

    <TestMethod()> Public Sub TestDBInsertAddress()
        Dim a1 As New Address(0, cust1.ID, "111 Davis Drive", "Newmarket", "BC", "T3E2T3", AddressType.mailing_address)
        Dim a2 As Address = Nothing

        a1.ID = DBAccessHelper.DBInsertAddress(a1)
        Assert.IsTrue(a1.ID > 0)
        ' read the product back and compare it
        a2 = DBAccessHelper.DBReadAddressByID(a1.ID)
        Assert.IsNotNull(a2)
        Assert.AreEqual(a2.ID, a1.ID)
        Assert.AreEqual(a2.cust_id, a1.cust_id)
        Assert.AreEqual(a2.street, a1.street)
        Assert.AreEqual(a2.city, a1.city)
        Assert.AreEqual(a2.province, a1.province)
        Assert.AreEqual(a2.postal_code, a1.postal_code)
        Assert.AreEqual(a2.type, a1.type)
    End Sub

    <TestMethod()> Public Sub TestDBDeleteAddress()
        Dim a As Address = Nothing
        Assert.IsNotNull(addr1)
        Assert.IsTrue(DBAccessHelper.DBDeleteAddress(addr1))
        a = DBAccessHelper.DBReadAddressByID(addr1.ID)
        ' make sure we didn't find it
        Assert.IsNull(a)
    End Sub

    <TestMethod()> Public Sub TestDBUpdateAddress()
        Dim a As Address = Nothing
        Assert.IsNotNull(cust1)
        addr1.street = "987 New Street"
        addr1.city = "New City"
        addr1.province = "MB"
        addr1.postal_code = "N1N1N1"
        Assert.IsTrue(DBAccessHelper.DBUpdateAddress(addr1))
        a = DBAccessHelper.DBReadAddressByID(addr1.ID)
        Assert.IsNotNull(a)
        Assert.AreEqual(a.cust_id, addr1.cust_id)
        Assert.AreEqual(a.street, addr1.street)
        Assert.AreEqual(a.city, addr1.city)
        Assert.AreEqual(a.province, addr1.province)
        Assert.AreEqual(a.postal_code, addr1.postal_code)
        Assert.AreEqual(a.type, addr1.type)
    End Sub

    <TestMethod()> Public Sub TestDBInsertOrderAndLines()
        Dim o1 As New Order(0, cust1.ID, Today, 10, addr1.ID)
        Dim o2 As Order = Nothing

        o1.ID = DBAccessHelper.DBInsertOrder(o1)
        Assert.IsTrue(o1.ID > 0)
        ' read the product back and compare it
        o2 = DBAccessHelper.DBReadOrderByID(o1.ID)
        Assert.IsNotNull(o2)
        Assert.AreEqual(o2.customer_id, o1.customer_id)
        Assert.AreEqual(o2.order_date, o1.order_date)
        Assert.AreEqual(o2.discount, o1.discount)
        Assert.AreEqual(o2.ship_addr_id, o1.ship_addr_id)
        Dim i1 As New OrderItem(0, o1.ID, prod1.ID, 5, Nothing)
        Dim i2 As OrderItem = Nothing
        i1.ID = DBAccessHelper.DBInsertOrderItem(i1)
        Assert.IsTrue(i1.ID > 0)
        i2 = DBAccessHelper.DBReadOrderItemByID(i1.ID)
        Assert.IsNotNull(i2)
        Assert.AreEqual(i2.order_id, i1.order_id)
        Assert.AreEqual(i2.product_id, i1.product_id)
        Assert.AreEqual(i2.quantity, i1.quantity)
        Assert.AreEqual(i2.ship_date, i1.ship_date)
    End Sub

    <TestMethod()> Public Sub TestDBDeleteOrderAndLine()
        Dim o As Order = Nothing
        Dim i As OrderItem = Nothing
        Assert.IsNotNull(ordlin1)
        Assert.IsNotNull(ord1)
        Assert.IsTrue(DBAccessHelper.DBDeleteOrderItem(ordlin1))
        Assert.IsTrue(DBAccessHelper.DBDeleteOrder(ord1))
        i = DBAccessHelper.DBReadOrderItemByID(ordlin1.ID)
        Assert.IsNull(i)
        o = DBAccessHelper.DBReadOrderByID(ord1.ID)
        Assert.IsNull(o)
    End Sub

    <TestMethod()> Public Sub TestDBUpdateOrder()
        Dim o As Order = Nothing
        Assert.IsNotNull(ord1)
        ord1.customer_id = 1
        ord1.order_date = Today
        ord1.discount = 50
        ord1.ship_addr_id = 1
        Assert.IsTrue(DBAccessHelper.DBUpdateOrder(ord1))
        o = DBAccessHelper.DBReadOrderByID(ord1.ID)
        Assert.IsNotNull(o)
        Assert.AreEqual(o.ID, ord1.ID)
        Assert.AreEqual(o.customer_id, ord1.customer_id)
        Assert.AreEqual(o.order_date, ord1.order_date)
        Assert.AreEqual(o.discount, ord1.discount)
        Assert.AreEqual(o.ship_addr_id, ord1.ship_addr_id)
    End Sub

    <TestMethod()> Public Sub TestDBUpdateOrderLine()
        Dim i As OrderItem = Nothing
        Assert.IsNotNull(ordlin1)
        ordlin1.order_id = 1
        ordlin1.product_id = 2
        ordlin1.quantity = 77
        ordlin1.ship_date = Today
        Assert.IsTrue(DBAccessHelper.DBUpdateOrderItem(ordlin1))
        i = DBAccessHelper.DBReadOrderItemByID(ordlin1.ID)
        Assert.IsNotNull(i)
        Assert.AreEqual(i.ID, ordlin1.ID)
        Assert.AreEqual(i.order_id, ordlin1.order_id)
        Assert.AreEqual(i.product_id, ordlin1.product_id)
        Assert.AreEqual(i.quantity, ordlin1.quantity)
        Assert.AreEqual(i.ship_date, ordlin1.ship_date)
    End Sub
End Class