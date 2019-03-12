Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class frmPractice11
    Dim strConn As String = ConfigurationManager.ConnectionStrings("lab1.My.MySettings.myCon").ConnectionString
    Dim strSql As String
    Dim Conn As SqlConnection
    Dim selectRow As Integer
    Private Sub showInformation()
        strSql = "select ProductID, ProductName, UnitPrice, UnitsInStock,(UnitPrice * UnitsInStock) as Total from Products"
        Conn = New SqlConnection
        Conn.ConnectionString = strConn
        Conn.Open()

        Dim da As SqlDataAdapter = New SqlDataAdapter(strSql, Conn)
        Dim ds As DataSet = New DataSet

        da.Fill(ds, "tbData")
        dgvInformation.ReadOnly = True
        dgvInformation.DataSource = ds.Tables("tbData")
        dgvInformation.Columns(0).HeaderCell.Value = "รหัสสินค้า"
        dgvInformation.Columns(1).HeaderCell.Value = "ชื่อสินค้า"
        dgvInformation.Columns(2).HeaderText = "ราคา"
        dgvInformation.Columns(3).HeaderText = "คงเหลือ"
        dgvInformation.Columns(4).HeaderText = "เป็นเงิน"

        dgvInformation.Columns(0).Width = 100
        dgvInformation.Columns(1).Width = 200
        dgvInformation.Columns(2).Width = 100
        dgvInformation.Columns(3).Width = 100
        dgvInformation.Columns(4).Width = 100

    End Sub
    Private Sub frmPractice11_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call showInformation()
    End Sub

    Private Sub dgvInformation_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvInformation.CellContentClick
        selectRow = dgvInformation.CurrentCell.RowIndex
        lblProId.Text = dgvInformation.CurrentRow.Cells(0).Value
        lblProName.Text = dgvInformation.Item(1, selectRow).Value
        lblUnitPrice.Text = dgvInformation.Item(2, selectRow).Value
        lblUnitInStock.Text = dgvInformation.Item(3, selectRow).Value
        lblTotal.Text = dgvInformation.Item(4, selectRow).Value
    End Sub
End Class