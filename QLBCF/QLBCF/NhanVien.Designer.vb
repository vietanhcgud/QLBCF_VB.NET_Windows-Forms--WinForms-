<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NhanVien
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
        Me.dgvHTNV = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSDT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTenNV = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNS = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMaNV = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        CType(Me.dgvHTNV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvHTNV
        '
        Me.dgvHTNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHTNV.Location = New System.Drawing.Point(34, 149)
        Me.dgvHTNV.Name = "dgvHTNV"
        Me.dgvHTNV.Size = New System.Drawing.Size(574, 128)
        Me.dgvHTNV.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(161, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(337, 31)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "DANH SÁCH NHÂN VIÊN"
        '
        'txtSDT
        '
        Me.txtSDT.Location = New System.Drawing.Point(408, 86)
        Me.txtSDT.Name = "txtSDT"
        Me.txtSDT.Size = New System.Drawing.Size(100, 20)
        Me.txtSDT.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(328, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "SĐT:"
        '
        'txtTenNV
        '
        Me.txtTenNV.Location = New System.Drawing.Point(408, 60)
        Me.txtTenNV.Name = "txtTenNV"
        Me.txtTenNV.Size = New System.Drawing.Size(100, 20)
        Me.txtTenNV.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(328, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Tên Nhân Viên:"
        '
        'txtNS
        '
        Me.txtNS.Location = New System.Drawing.Point(197, 86)
        Me.txtNS.Name = "txtNS"
        Me.txtNS.Size = New System.Drawing.Size(100, 20)
        Me.txtNS.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(117, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Ngày Sinh:"
        '
        'txtMaNV
        '
        Me.txtMaNV.Location = New System.Drawing.Point(197, 60)
        Me.txtMaNV.Name = "txtMaNV"
        Me.txtMaNV.Size = New System.Drawing.Size(100, 20)
        Me.txtMaNV.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(117, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Mã Nhân Viên:"
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(412, 118)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(97, 25)
        Me.btnXoa.TabIndex = 24
        Me.btnXoa.Text = "Xóa Nhân Viên"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(265, 118)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(97, 25)
        Me.btnSua.TabIndex = 23
        Me.btnSua.Text = "Sửa Nhân Viên"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(121, 118)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(97, 25)
        Me.btnThem.TabIndex = 22
        Me.btnThem.Text = "Thêm Nhân Viên"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'NhanVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 298)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.dgvHTNV)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSDT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTenNV)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMaNV)
        Me.Controls.Add(Me.Label1)
        Me.Name = "NhanVien"
        Me.Text = "Danh Sách Nhân Viên"
        CType(Me.dgvHTNV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvHTNV As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSDT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTenNV As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNS As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMaNV As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnThem As Button
End Class
