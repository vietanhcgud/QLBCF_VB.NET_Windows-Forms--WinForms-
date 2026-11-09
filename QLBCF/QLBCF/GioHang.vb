Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D

Public Class GioHang
    Dim Connection As New SqlConnection

    Private Sub Laydulieu()
        Dim SAdap As New SqlDataAdapter("select * from SanPham", Connection)
        Dim STable As New DataTable
        SAdap.Fill(STable)
        txtMaSP.DataBindings.Clear()
        txtMaSP.DataBindings.Add("text", STable, "MaSP")
        txtTenSP.DataBindings.Clear()
        txtTenSP.DataBindings.Add("text", STable, "TenSP")
        txtSL.DataBindings.Clear()
        txtSL.DataBindings.Add("Text", STable, "SL")
        txtGT.DataBindings.Clear()
        txtGT.DataBindings.Add("Text", STable, "GT")
        dgvHTDS.DataSource = STable
    End Sub

    Private Sub Laydulieu1()
        Dim SAdap As New SqlDataAdapter("select * from GioHang", Connection)
        Dim STable As New DataTable
        SAdap.Fill(STable)
        dgvGioHang.DataSource = STable
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim Ma As String = txtMaSP.Text
        Dim Ten As String = txtTenSP.Text
        Dim SL As String = txtSL.Text
        Dim GT As String = txtGT.Text
        Dim cmd As New SqlCommand("Insert Into GioHang(MaSP,TenSP,SL,GT) Values('" + Ma + "', N'" + Ten + "','" + SL + "','" + GT + "')", Connection)
        cmd.ExecuteNonQuery()
        Laydulieu()
        Laydulieu1()
    End Sub

    Private Sub GioHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection = New SqlConnection("Data Source=DESKTOP-H58OFP7\VASERVER;Initial Catalog=QLBCF;Integrated Security=True")
        Connection.Open()
        Laydulieu()
        Laydulieu1()
    End Sub

    Private Sub btnXuat_Click(sender As Object, e As EventArgs) Handles btnXuat.Click
        MsgBox("Xuất hóa đơn thành công. Cảm ơn bạn đã mua hàng!!!")
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim masp As String = txtMaSP.Text
        Dim cmd As New SqlCommand("delete GioHang where MaSP ='" + masp + "'", Connection)
        cmd.ExecuteNonQuery()
        Laydulieu()
    End Sub
End Class