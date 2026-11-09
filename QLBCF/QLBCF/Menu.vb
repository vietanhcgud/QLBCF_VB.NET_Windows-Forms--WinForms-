Public Class Menu
    Private Sub Menu_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub NhânViênToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NhânViênToolStripMenuItem.Click
        NhanVien.Show()
    End Sub

    Private Sub KháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KháchHàngToolStripMenuItem.Click
        KhachHang.Show()
    End Sub

    Private Sub SảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SảnPhẩmToolStripMenuItem.Click
        SanPham.Show()
    End Sub

    Private Sub GiỏHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GiỏHàngToolStripMenuItem.Click
        GioHang.Show()
    End Sub

    Private Sub Menu_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class