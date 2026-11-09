<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KhachHang
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
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.dgvHTDS = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSDT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTenKH = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNS = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCCCD = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnXoa = New System.Windows.Forms.Button()
        CType(Me.dgvHTDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(278, 143)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(106, 25)
        Me.btnSua.TabIndex = 25
        Me.btnSua.Text = "Sửa Khách Hàng"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(125, 143)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(116, 25)
        Me.btnThem.TabIndex = 24
        Me.btnThem.Text = "Thêm Khách Hàng"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'dgvHTDS
        '
        Me.dgvHTDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHTDS.Location = New System.Drawing.Point(36, 185)
        Me.dgvHTDS.Name = "dgvHTDS"
        Me.dgvHTDS.Size = New System.Drawing.Size(574, 128)
        Me.dgvHTDS.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(167, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(373, 31)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "DANH SÁCH KHÁCH HÀNG"
        '
        'txtSDT
        '
        Me.txtSDT.Location = New System.Drawing.Point(431, 110)
        Me.txtSDT.Name = "txtSDT"
        Me.txtSDT.Size = New System.Drawing.Size(100, 20)
        Me.txtSDT.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(333, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "SĐT:"
        '
        'txtTenKH
        '
        Me.txtTenKH.Location = New System.Drawing.Point(431, 84)
        Me.txtTenKH.Name = "txtTenKH"
        Me.txtTenKH.Size = New System.Drawing.Size(100, 20)
        Me.txtTenKH.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(333, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Tên Khách Hàng:"
        '
        'txtNS
        '
        Me.txtNS.Location = New System.Drawing.Point(216, 110)
        Me.txtNS.Name = "txtNS"
        Me.txtNS.Size = New System.Drawing.Size(100, 20)
        Me.txtNS.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(122, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Ngày Sinh:"
        '
        'txtCCCD
        '
        Me.txtCCCD.Location = New System.Drawing.Point(216, 84)
        Me.txtCCCD.Name = "txtCCCD"
        Me.txtCCCD.Size = New System.Drawing.Size(100, 20)
        Me.txtCCCD.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(122, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "CCCD:"
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(419, 143)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(112, 25)
        Me.btnXoa.TabIndex = 26
        Me.btnXoa.Text = "Xóa Khách Hàng"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'KhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 326)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.dgvHTDS)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSDT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTenKH)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCCCD)
        Me.Controls.Add(Me.Label1)
        Me.Name = "KhachHang"
        Me.Text = "a"
        CType(Me.dgvHTDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSua As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents dgvHTDS As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSDT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTenKH As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNS As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCCCD As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnXoa As Button
End Class
