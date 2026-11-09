Imports System.Data.SqlClient

Public Class KhachHang
    Dim Connection As New SqlConnection

    Private Sub Laydulieu()
        Dim SAdap As New SqlDataAdapter("select * from KhachHang", Connection)
        Dim STable As New DataTable
        SAdap.Fill(STable)
        txtCCCD.DataBindings.Add("text", STable, "CCCD")
        txtCCCD.DataBindings.Clear()
        txtTenKH.DataBindings.Add("text", STable, "TenKH")
        txtTenKH.DataBindings.Clear()
        txtNS.DataBindings.Add("Text", STable, "NS")
        txtNS.DataBindings.Clear()
        txtSDT.DataBindings.Add("Text", STable, "SDT")
        txtSDT.DataBindings.Clear()
        dgvHTDS.DataSource = STable
    End Sub

    Private Sub KhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection = New SqlConnection("Data Source=DESKTOP-H58OFP7\VASERVER;Initial Catalog=QLBCF;Integrated Security=True")
        Connection.Open()
        Laydulieu()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Connection.Open()
        Dim CCCD As String = txtCCCD.Text
        Dim Ten As String = txtTenKH.Text
        Dim NS As String = txtNS.Text
        Dim SDT As String = txtSDT.Text
        Dim cmd As New SqlCommand("Insert Into KhachHang(CCCD,TenKH,NS,SDT) Values('" + CCCD + "', N'" + Ten + "','" + NS + "','" + SDT + "')", Connection)
        cmd.ExecuteNonQuery()
        Laydulieu()
        Connection.Close()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Connection.Open()
        Dim CCCD As String = txtCCCD.Text
        Dim cmd As New SqlCommand("delete KhachHang where CCCD ='" + CCCD + "'", Connection)
        cmd.ExecuteNonQuery()
        Laydulieu()
        Connection.Close()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Connection.Open()
        Dim CCCD As String = txtCCCD.Text
        Dim Ten As String = txtTenKH.Text
        Dim NS As String = txtNS.Text
        Dim SDT As String = txtSDT.Text
        Dim cmd As New SqlCommand("update KhachHang set CCCD= '" + CCCD + "',TenKH=N'" + Ten + "',NS=N'" + NS + "',SDT'" + SDT + "'where CCCD ='" + CCCD + "'", Connection)
        cmd.ExecuteNonQuery()
        Laydulieu()
        Connection.Close()
    End Sub
End Class