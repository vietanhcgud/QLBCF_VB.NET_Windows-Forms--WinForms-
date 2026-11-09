Imports System.Data.SqlClient
Imports System.Xml

Public Class NhanVien
    Dim Connection As New SqlConnection

    Private Sub Laydulieu()
        Dim SAdap As New SqlDataAdapter("select * from NhanVien", Connection)
        Dim STable As New DataTable
        SAdap.Fill(STable)
        txtMaNV.DataBindings.Add("text", STable, "MaNV")
        txtTenNV.DataBindings.Add("text", STable, "TenNV")
        txtNS.DataBindings.Add("Text", STable, "NS")
        txtSDT.DataBindings.Add("Text", STable, "SDT")
        dgvHTNV.DataSource = STable
    End Sub

    Private Sub NhanVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection = New SqlConnection("Data Source=DESKTOP-H58OFP7\VASERVER;Initial Catalog=QLBCF;Integrated Security=True")
        Connection.Open()
        Laydulieu()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Connection.Open()
        Dim MaNV As String = txtMaNV.Text
        Dim TenNV As String = txtTenNV.Text
        Dim NS As String = txtNS.Text
        Dim SDT As String = txtSDT.Text
        Dim cmd As New SqlCommand("Insert Into NhanVien(MaNV,TenNV,NS,SDT) Values('" + MaNV + "', N'" + TenNV + "','" + NS + "','" + SDT + "')", Connection)
        cmd.ExecuteNonQuery()
        Laydulieu()
        Connection.Close()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Connection.Open()
        Dim MaNV As String = txtMaNV.Text
        Dim TenNV As String = txtTenNV.Text
        Dim NS As String = txtNS.Text
        Dim SDT As String = txtSDT.Text
        Dim cmd As New SqlCommand("update NhanVien set MaNV= '" + MaNV + "',TenNV=N'" + TenNV + "',NS=N'" + NS + "',SDT'" + SDT + "'where MaNV ='" + MaNV + "'", Connection)
        cmd.ExecuteNonQuery()
        Laydulieu()
        Connection.Close()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Connection.Open()
        Dim MaNV As String = txtMaNV.Text
        Dim cmd As New SqlCommand("delete NhanVien where MaNV ='" + MaNV + "'", Connection)
        cmd.ExecuteNonQuery()
        Laydulieu()
        Connection.Close()
    End Sub
End Class