<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GioHang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvHTDS = New System.Windows.Forms.DataGridView()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnXuat = New System.Windows.Forms.Button()
        Me.dgvGioHang = New System.Windows.Forms.DataGridView()
        Me.txtGT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTenSP = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSL = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMaSP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dgvHTDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvGioHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvHTDS
        '
        Me.dgvHTDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHTDS.Location = New System.Drawing.Point(16, 191)
        Me.dgvHTDS.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvHTDS.Name = "dgvHTDS"
        Me.dgvHTDS.RowHeadersWidth = 51
        Me.dgvHTDS.Size = New System.Drawing.Size(491, 225)
        Me.dgvHTDS.TabIndex = 1
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(259, 427)
        Me.btnThem.Margin = New System.Windows.Forms.Padding(4)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(169, 42)
        Me.btnThem.TabIndex = 2
        Me.btnThem.Text = "Thêm vào giỏ hàng"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(436, 427)
        Me.btnXoa.Margin = New System.Windows.Forms.Padding(4)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(169, 42)
        Me.btnXoa.TabIndex = 3
        Me.btnXoa.Text = "Xoá khỏi giỏ hàng"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnXuat
        '
        Me.btnXuat.Location = New System.Drawing.Point(613, 427)
        Me.btnXuat.Margin = New System.Windows.Forms.Padding(4)
        Me.btnXuat.Name = "btnXuat"
        Me.btnXuat.Size = New System.Drawing.Size(169, 42)
        Me.btnXuat.TabIndex = 4
        Me.btnXuat.Text = "Xuất hoá đơn"
        Me.btnXuat.UseVisualStyleBackColor = True
        '
        'dgvGioHang
        '
        Me.dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGioHang.Location = New System.Drawing.Point(527, 191)
        Me.dgvGioHang.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvGioHang.Name = "dgvGioHang"
        Me.dgvGioHang.RowHeadersWidth = 51
        Me.dgvGioHang.Size = New System.Drawing.Size(495, 223)
        Me.dgvGioHang.TabIndex = 5
        '
        'txtGT
        '
        Me.txtGT.Location = New System.Drawing.Point(628, 125)
        Me.txtGT.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGT.Name = "txtGT"
        Me.txtGT.Size = New System.Drawing.Size(132, 22)
        Me.txtGT.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(521, 129)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Giá Tiền:"
        '
        'txtTenSP
        '
        Me.txtTenSP.Location = New System.Drawing.Point(628, 93)
        Me.txtTenSP.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTenSP.Name = "txtTenSP"
        Me.txtTenSP.Size = New System.Drawing.Size(132, 22)
        Me.txtTenSP.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(521, 97)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Tên Sản Phẩm:"
        '
        'txtSL
        '
        Me.txtSL.Location = New System.Drawing.Point(346, 125)
        Me.txtSL.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSL.Name = "txtSL"
        Me.txtSL.Size = New System.Drawing.Size(132, 22)
        Me.txtSL.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(240, 129)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Số Lượng:"
        '
        'txtMaSP
        '
        Me.txtMaSP.Location = New System.Drawing.Point(346, 93)
        Me.txtMaSP.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaSP.Name = "txtMaSP"
        Me.txtMaSP.Size = New System.Drawing.Size(132, 22)
        Me.txtMaSP.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(240, 97)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Mã Sản Phẩm:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(412, 9)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(193, 38)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "GIỎ HÀNG"
        '
        'GioHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1037, 484)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtGT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTenSP)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSL)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMaSP)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvGioHang)
        Me.Controls.Add(Me.btnXuat)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.dgvHTDS)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "GioHang"
        Me.Text = "Giỏ Hàng"
        CType(Me.dgvHTDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvGioHang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvHTDS As DataGridView
    Friend WithEvents btnThem As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnXuat As Button
    Friend WithEvents dgvGioHang As DataGridView
    Friend WithEvents txtGT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTenSP As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSL As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMaSP As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
End Class
