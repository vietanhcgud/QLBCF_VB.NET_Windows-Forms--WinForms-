<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SanPham
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMaSP = New System.Windows.Forms.TextBox()
        Me.txtSL = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTenSP = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvHTDS = New System.Windows.Forms.DataGridView()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        CType(Me.dgvHTDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(98, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Sản Phẩm:"
        '
        'txtMaSP
        '
        Me.txtMaSP.Location = New System.Drawing.Point(178, 53)
        Me.txtMaSP.Name = "txtMaSP"
        Me.txtMaSP.Size = New System.Drawing.Size(100, 20)
        Me.txtMaSP.TabIndex = 1
        '
        'txtSL
        '
        Me.txtSL.Location = New System.Drawing.Point(178, 79)
        Me.txtSL.Name = "txtSL"
        Me.txtSL.Size = New System.Drawing.Size(100, 20)
        Me.txtSL.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(98, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Số Lượng:"
        '
        'txtGT
        '
        Me.txtGT.Location = New System.Drawing.Point(389, 79)
        Me.txtGT.Name = "txtGT"
        Me.txtGT.Size = New System.Drawing.Size(100, 20)
        Me.txtGT.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(309, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Giá Tiền:"
        '
        'txtTenSP
        '
        Me.txtTenSP.Location = New System.Drawing.Point(389, 53)
        Me.txtTenSP.Name = "txtTenSP"
        Me.txtTenSP.Size = New System.Drawing.Size(100, 20)
        Me.txtTenSP.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(309, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Tên Sản Phẩm:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(142, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(316, 31)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "DANH MỤC SẢN PHẨM"
        '
        'dgvHTDS
        '
        Me.dgvHTDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHTDS.Location = New System.Drawing.Point(12, 154)
        Me.dgvHTDS.Name = "dgvHTDS"
        Me.dgvHTDS.Size = New System.Drawing.Size(574, 128)
        Me.dgvHTDS.TabIndex = 11
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(101, 112)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(97, 25)
        Me.btnThem.TabIndex = 12
        Me.btnThem.Text = "Thêm Sản Phẩm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(245, 112)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(97, 25)
        Me.btnSua.TabIndex = 13
        Me.btnSua.Text = "Sửa Sản Phẩm"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(392, 112)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(97, 25)
        Me.btnXoa.TabIndex = 14
        Me.btnXoa.Text = "Xóa Sản Phẩm"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'SanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 294)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.dgvHTDS)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtGT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTenSP)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSL)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMaSP)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SanPham"
        Me.Text = "Danh Sách Sản Phẩm"
        CType(Me.dgvHTDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtMaSP As TextBox
    Friend WithEvents txtSL As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtGT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTenSP As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dgvHTDS As DataGridView
    Friend WithEvents btnThem As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnXoa As Button
End Class
