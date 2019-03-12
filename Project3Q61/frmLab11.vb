Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class frmLab11
    Dim strConn As String = ConfigurationManager.ConnectionStrings("lab1.My.MySettings.myCon").ConnectionString
    Dim strSql As String
    Dim Conn As New SqlConnection
    Dim selectRow As Integer
    Private Sub frmLab11_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call conDB()
    End Sub
    Private Sub conDB()
        If Conn.State = ConnectionState.Open Then
            Conn.Close()
        End If
        Conn.ConnectionString = strConn
        Conn.Open()
    End Sub
    Private Sub btnChoice1_Click(sender As System.Object, e As System.EventArgs) Handles btnChoice1.Click
        Call conDB()
        strSql = "select * from products where productname LIKE 'N%'"
        Dim da As SqlDataAdapter = New SqlDataAdapter(strSql, Conn)
        Dim ds As DataSet = New DataSet
        da.Fill(ds, "tbData")
        dgvData.ReadOnly = True
        dgvData.DataSource = ds.Tables("tbData")
        dgvData.Columns(0).HeaderCell.Value = "รหัสสินค้า"
        dgvData.Columns(1).HeaderCell.Value = "ชื่อสินค้า"
        dgvData.Columns(2).HeaderText = "รหัสผู้ผลิต"
        dgvData.Columns(3).HeaderText = "คงเหลือ"
        dgvData.Columns(4).HeaderText = "เป็นเงิน"
        dgvData.Columns(5).HeaderText = "ราคาต่อหน่วย"
        dgvData.Columns(6).HeaderText = "หน่วยสินค้าพร้อมส่ง"
        dgvData.Columns(7).HeaderText = "หน่วยสั่งซื้อ"
        dgvData.Columns(8).HeaderText = "เรียงลำดับระดับใหม่"
        dgvData.Columns(9).HeaderText = "ยกเลิก"
        dgvData.Columns(0).Width = 80
        dgvData.Columns(1).Width = 150
        dgvData.Columns(2).Width = 80
        dgvData.Columns(3).Width = 80
        dgvData.Columns(4).Width = 100
        dgvData.Columns(5).Width = 80
        dgvData.Columns(6).Width = 200
        dgvData.Columns(7).Width = 80
        dgvData.Columns(8).Width = 200
        dgvData.Columns(9).Width = 80
        Conn.Close()
    End Sub

    Private Sub btnChoice2_Click(sender As System.Object, e As System.EventArgs) Handles btnChoice2.Click
        Call conDB()
        strSql = "select ProductID,ProductName,UnitPrice,UnitsInstock,(UnitPrice*UnitsInstock) from products where productID  LIKE '%64%'"
        Dim da As SqlDataAdapter = New SqlDataAdapter(strSql, Conn)
        Dim ds As DataSet = New DataSet
        ds.Tables.Clear()
        da.Fill(ds, "tbData1")
        dgvData.ReadOnly = True
        dgvData.DataSource = ds.Tables("tbData1")
        dgvData.Columns(0).HeaderCell.Value = "รหัสสินค้า"
        dgvData.Columns(1).HeaderCell.Value = "ชื่อสินค้า"
        dgvData.Columns(2).HeaderText = "ราคาต่อหน่วย"
        dgvData.Columns(3).HeaderText = "คงเหลือ"
        dgvData.Columns(4).HeaderText = "ราคารวม"
        dgvData.Columns(0).Width = 80
        dgvData.Columns(1).Width = 150
        dgvData.Columns(2).Width = 80
        dgvData.Columns(3).Width = 80
        dgvData.Columns(4).Width = 80
        Conn.Close()
    End Sub

    Private Sub btnChoice3_Click(sender As System.Object, e As System.EventArgs) Handles btnChoice3.Click
        Call conDB()
        strSql = "select country,count(CustomerId) from customers GROUP BY country HAVING country = 'Brazil' "
        Dim da As SqlDataAdapter = New SqlDataAdapter(strSql, Conn)
        Dim ds As DataSet = New DataSet
        ds.Tables.Clear()
        da.Fill(ds, "tbData2")
        dgvData.ReadOnly = True
        dgvData.DataSource = ds.Tables("tbData2")
        dgvData.Columns(0).HeaderCell.Value = "ประเทศ"
        dgvData.Columns(1).HeaderCell.Value = "จำนวน"
        dgvData.Columns(0).Width = 100
        dgvData.Columns(1).Width = 80
        Conn.Close()
    End Sub

    Private Sub btnChoice4_Click(sender As System.Object, e As System.EventArgs) Handles btnChoice4.Click
        Call conDB()
        strSql = " 	SELECT dbo.Products.ProductName,dbo.[Order Details].Quantity,dbo.Customers.ContactName FROM dbo.[Order Details]INNER JOIN dbo.Orders ON dbo.[Order Details].OrderID = dbo.Orders.OrderID INNER JOIN dbo.Customers ON dbo.Customers.CustomerID = dbo.Orders.CustomerID INNER JOIN dbo.Products ON dbo.[Order Details].ProductID = dbo.Products.ProductID where Customers.ContactName ='Yang Wang'"
        Dim da As SqlDataAdapter = New SqlDataAdapter(strSql, Conn)
        Dim ds As DataSet = New DataSet
        ds.Tables.Clear()
        da.Fill(ds, "tbData2")
        dgvData.ReadOnly = True
        dgvData.DataSource = ds.Tables("tbData2")
        dgvData.Columns(0).HeaderCell.Value = "ชื่อสินค้า"
        dgvData.Columns(1).HeaderCell.Value = "จำนวน"
        dgvData.Columns(2).HeaderCell.Value = "ชื่อลูกค้า"
        dgvData.Columns(0).Width = 200
        dgvData.Columns(1).Width = 80
        dgvData.Columns(2).Width = 80
        Conn.Close()
    End Sub

    Private Sub btnChoice5_Click(sender As System.Object, e As System.EventArgs) Handles btnChoice5.Click
        Call conDB()
        strSql = "select productName,UnitsInstock from products where UnitsInstock < 10 "
        Dim da As SqlDataAdapter = New SqlDataAdapter(strSql, Conn)
        Dim ds As DataSet = New DataSet
        ds.Tables.Clear()
        da.Fill(ds, "tbData2")
        dgvData.ReadOnly = True
        dgvData.DataSource = ds.Tables("tbData2")
        dgvData.Columns(0).HeaderCell.Value = "ชื่อสินค้า"
        dgvData.Columns(1).HeaderCell.Value = "จำนวนคงเหลือ"
        dgvData.Columns(0).Width = 200
        dgvData.Columns(1).Width = 100
        Conn.Close()
    End Sub

    Private Sub btnChoice6_Click(sender As System.Object, e As System.EventArgs) Handles btnChoice6.Click
        Call conDB()
        strSql = "SELECT dbo.[Order Details].OrderID,dbo.[Order Details].ProductID,dbo.Products.ProductName,dbo.[Order Details].UnitPrice,dbo.[Order Details].Quantity,dbo.[Order Details].Discount FROM dbo.[Order Details] ,dbo.Products WHERE [Order Details].OrderID = '10255'"
        Dim da As SqlDataAdapter = New SqlDataAdapter(strSql, Conn)
        Dim ds As DataSet = New DataSet
        ds.Tables.Clear()
        da.Fill(ds, "tbData5")
        dgvData.ReadOnly = True
        dgvData.DataSource = ds.Tables("tbData5")
        dgvData.Columns(0).HeaderCell.Value = "เลขที่ใบสั่งซื้อ"
        dgvData.Columns(1).HeaderCell.Value = "รหัสสินค้า"
        dgvData.Columns(2).HeaderCell.Value = "ชื่อสินค้า"
        dgvData.Columns(3).HeaderCell.Value = "ราคาต่อหน่วย"
        dgvData.Columns(4).HeaderCell.Value = "จำนวน"
        dgvData.Columns(5).HeaderCell.Value = "ส่วนลด"
        dgvData.Columns(0).Width = 80
        dgvData.Columns(1).Width = 100
        dgvData.Columns(2).Width = 200
        dgvData.Columns(3).Width = 80
        dgvData.Columns(4).Width = 80
        dgvData.Columns(5).Width = 80


        Conn.Close()
    End Sub

    Private Sub btnChoice7_Click(sender As System.Object, e As System.EventArgs) Handles btnChoice7.Click
        Call conDB()
        strSql = "SELECT dbo.[Order Details].OrderID,dbo.Products.ProductName,dbo.[Order Details].Quantity FROM dbo.Products INNER JOIN dbo.[Order Details] ON dbo.Products.ProductID = dbo.[Order Details].ProductID WHERE [Order Details].OrderID = '10255' "
        Dim da As SqlDataAdapter = New SqlDataAdapter(strSql, Conn)
        Dim ds As DataSet = New DataSet
        ds.Tables.Clear()
        da.Fill(ds, "tbData2")
        dgvData.ReadOnly = True
        dgvData.DataSource = ds.Tables("tbData2")
        dgvData.Columns(0).HeaderCell.Value = "เลขที่ใบสั่งซื้อ"
        dgvData.Columns(1).HeaderCell.Value = "ชื่อสินค้า"
        dgvData.Columns(2).HeaderCell.Value = "จำนวนสั่งซื้อ"
        dgvData.Columns(0).Width = 200
        dgvData.Columns(1).Width = 200
        dgvData.Columns(2).Width = 100
        Conn.Close()
    End Sub

    Private Sub btnChoice8_Click(sender As System.Object, e As System.EventArgs) Handles btnChoice8.Click
        Call conDB()
        strSql = "SELECT dbo.Orders.OrderID,dbo.Customers.CustomerID,dbo.Customers.CompanyName,dbo.Customers.ContactName,dbo.Customers.ContactTitle,dbo.Customers.Address,dbo.Customers.City,dbo.Customers.Region,dbo.Customers.PostalCode,dbo.Customers.Country FROM dbo.Customers INNER JOIN dbo.Orders ON dbo.Orders.CustomerID = dbo.Customers.CustomerID WHERE Orders.OrderID = '10347'"
        Dim da As SqlDataAdapter = New SqlDataAdapter(strSql, Conn)
        Dim ds As DataSet = New DataSet
        ds.Tables.Clear()
        da.Fill(ds, "tbData2")
        dgvData.ReadOnly = True
        dgvData.DataSource = ds.Tables("tbData2")
        dgvData.Columns(0).HeaderCell.Value = "เลขที่ใบเสร็จ"
        dgvData.Columns(1).HeaderCell.Value = "รหัสลูกค้า"
        dgvData.Columns(2).HeaderCell.Value = "ชื่อบริษัท"
        dgvData.Columns(3).HeaderCell.Value = "ชื่อลูกค้า"
        dgvData.Columns(4).HeaderCell.Value = "ชื่อแผนก"
        dgvData.Columns(5).HeaderCell.Value = "ที่อยู่"
        dgvData.Columns(6).HeaderCell.Value = "เมือง"
        dgvData.Columns(7).HeaderCell.Value = "ตัวย่อ"
        dgvData.Columns(8).HeaderCell.Value = "รหัสไปรษณีย์"
        dgvData.Columns(9).HeaderCell.Value = "ชื่อประเทศ"
        dgvData.Columns(0).Width = 100
        dgvData.Columns(1).Width = 100
        dgvData.Columns(2).Width = 200
        dgvData.Columns(3).Width = 100
        dgvData.Columns(4).Width = 150
        dgvData.Columns(5).Width = 100
        dgvData.Columns(6).Width = 80
        dgvData.Columns(7).Width = 80
        dgvData.Columns(8).Width = 100
        dgvData.Columns(9).Width = 100
        Conn.Close()
    End Sub

    Private Sub btnChoice9_Click(sender As System.Object, e As System.EventArgs) Handles btnChoice9.Click
        Call conDB()
        strSql = "SELECT dbo.Suppliers.CompanyName,dbo.Products.ProductName,dbo.[Order Details].OrderID,dbo.[Order Details].Quantity FROM dbo.Suppliers INNER JOIN dbo.Products ON dbo.Suppliers.SupplierID = dbo.Products.SupplierID INNER JOIN dbo.[Order Details] ON dbo.[Order Details].ProductID = dbo.Products.ProductID WHERE dbo.Suppliers.CompanyName = 'Exotic Liquids' "
        Dim da As SqlDataAdapter = New SqlDataAdapter(strSql, Conn)
        Dim ds As DataSet = New DataSet
        ds.Tables.Clear()
        da.Fill(ds, "tbData2")
        dgvData.ReadOnly = True
        dgvData.DataSource = ds.Tables("tbData2")
        dgvData.Columns(0).HeaderCell.Value = "ชื่อบริษัทที่ขาย"
        dgvData.Columns(1).HeaderCell.Value = "ชื่อสินค้า"
        dgvData.Columns(2).HeaderCell.Value = "เลขที่สั่งซื้อ"
        dgvData.Columns(3).HeaderCell.Value = "จำนวน"
        dgvData.Columns(0).Width = 200
        dgvData.Columns(1).Width = 100
        dgvData.Columns(2).Width = 100
        dgvData.Columns(3).Width = 100
        Conn.Close()
    End Sub

    Private Sub btnChoice10_Click(sender As System.Object, e As System.EventArgs) Handles btnChoice10.Click
        Call conDB()
        strSql = "SELECT sum(dbo.[Order Details].Quantity),dbo.Customers.Country FROM dbo.Customers INNER JOIN dbo.Orders ON dbo.Customers.CustomerID = dbo.Orders.CustomerID INNER JOIN dbo.[Order Details] ON dbo.Orders.OrderID = dbo.[Order Details].OrderID GROUP BY Customers.Country HAVING Customers.Country = 'italy'"
        Dim da As SqlDataAdapter = New SqlDataAdapter(strSql, Conn)
        Dim ds As DataSet = New DataSet
        ds.Tables.Clear()
        da.Fill(ds, "tbData2")
        dgvData.ReadOnly = True
        dgvData.DataSource = ds.Tables("tbData2")
        dgvData.Columns(0).HeaderCell.Value = "จำนวนครั้ง"
        dgvData.Columns(1).HeaderCell.Value = "เมือง"
        dgvData.Columns(0).Width = 100
        dgvData.Columns(1).Width = 100
        Conn.Close()
    End Sub
End Class
