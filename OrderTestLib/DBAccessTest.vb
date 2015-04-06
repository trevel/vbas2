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
        addr1.ID = DBAccessHelper.DBInsertAddress(addr1)
        Assert.AreNotEqual(prod1.ID, -1)
        Assert.AreNotEqual(cust1.ID, -1)
        Assert.AreNotEqual(addr1.ID, -1)
    End Sub

    ' called after each test case
    <TestCleanup()> Public Sub CleanUp()
        Assert.IsNotNull(prod1)
        Assert.IsNotNull(cust1)
        Assert.IsNotNull(addr1)
        Assert.IsTrue(DBAccessHelper.DBDeleteProduct(prod1))
        Assert.IsTrue(DBAccessHelper.DBDeleteAddress(addr1))
        Assert.IsTrue(DBAccessHelper.DBDeleteCustomer(cust1))
        prod1 = DBAccessHelper.DBReadProductByID(prod1.ID)
        addr1 = DBAccessHelper.DBReadAddressByID(addr1.ID)
        cust1 = DBAccessHelper.DBReadCustomerByID(cust1.ID)
        ' objects are cleaned up
        Assert.IsNull(prod1)
        Assert.IsNull(cust1)
        Assert.IsNull(addr1)
    End Sub

    <TestMethod()> Public Sub TestOpenClose()
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
        addr1.street = "New Street"
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
End Class