Imports DBAccessLib
Imports Database
Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports System.Data.SqlClient

<TestClass()> Public Class DBAccessTest
    Dim prod1 As Product = Nothing
    Dim prod2 As product = Nothing

    <TestMethod()> Public Sub TestMethod1()
    End Sub

    <TestInitialize()> Public Sub Initialize()
        Assert.IsNull(prod1)
        Assert.IsNull(prod2)
        prod1 = New Product(0, "Something", 1.0, 1, True)
        prod2 = New Product(0, "Other", 2.0, 2, False)
        prod1.ID = DBAccessHelper.DBInsertProduct(prod1)
        prod2.ID = DBAccessHelper.DBInsertProduct(prod2)
        'objects are created and references are updated accordingly
        Assert.IsNotNull(prod1)
        Assert.IsNotNull(prod2)
        Assert.AreNotEqual(prod1.ID, -1)
        Assert.AreNotEqual(prod2.ID, -1)
    End Sub

    ' called after each test case
    <TestCleanup()> Public Sub CleanUp()
        Assert.IsNotNull(prod1)
        Assert.IsNotNull(prod2)
        DBAccessHelper.DBDeleteProduct(prod1)
        DBAccessHelper.DBDeleteProduct(prod2)
        prod1 = DBAccessHelper.DBReadProductByID(prod1.ID)
        prod2 = DBAccessHelper.DBReadProductByID(prod2.ID)
        ' objects are cleaned up
        Assert.IsNull(prod1)
        Assert.IsNull(prod2)
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
        DBAccessHelper.DBDeleteProduct(prod1)
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
        DBAccessHelper.DBUpdateProduct(prod1)
        p = DBAccessHelper.DBReadProductByID(prod1.ID)
        Assert.IsNotNull(p)
        Assert.AreEqual(p.Description, prod1.Description)
        Assert.AreEqual(p.ID, prod1.ID)
        Assert.AreEqual(p.Inventory, prod1.Inventory)
        Assert.AreEqual(p.active, prod1.active)
        Assert.AreEqual(p.Price, prod1.Price)
    End Sub
End Class