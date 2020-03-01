<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btn_get_data = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.tb_user = New System.Windows.Forms.TextBox()
        Me.tb_server = New System.Windows.Forms.TextBox()
        Me.lbl_server = New System.Windows.Forms.Label()
        Me.tb_pw = New System.Windows.Forms.TextBox()
        Me.lbl_pw = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_get_data
        '
        Me.btn_get_data.Location = New System.Drawing.Point(710, 357)
        Me.btn_get_data.Name = "btn_get_data"
        Me.btn_get_data.Size = New System.Drawing.Size(75, 23)
        Me.btn_get_data.TabIndex = 0
        Me.btn_get_data.Text = "取得資料"
        Me.btn_get_data.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(23, 55)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(762, 296)
        Me.DataGridView1.TabIndex = 1
        '
        'lbl_user
        '
        Me.lbl_user.AutoSize = True
        Me.lbl_user.Location = New System.Drawing.Point(274, 30)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(32, 12)
        Me.lbl_user.TabIndex = 3
        Me.lbl_user.Text = "帳號:"
        '
        'tb_user
        '
        Me.tb_user.Location = New System.Drawing.Point(312, 27)
        Me.tb_user.Name = "tb_user"
        Me.tb_user.Size = New System.Drawing.Size(124, 22)
        Me.tb_user.TabIndex = 4
        '
        'tb_server
        '
        Me.tb_server.Location = New System.Drawing.Point(73, 27)
        Me.tb_server.Name = "tb_server"
        Me.tb_server.Size = New System.Drawing.Size(177, 22)
        Me.tb_server.TabIndex = 6
        '
        'lbl_server
        '
        Me.lbl_server.AutoSize = True
        Me.lbl_server.Location = New System.Drawing.Point(28, 30)
        Me.lbl_server.Name = "lbl_server"
        Me.lbl_server.Size = New System.Drawing.Size(44, 12)
        Me.lbl_server.TabIndex = 5
        Me.lbl_server.Text = "伺服器:"
        '
        'tb_pw
        '
        Me.tb_pw.Location = New System.Drawing.Point(484, 30)
        Me.tb_pw.Name = "tb_pw"
        Me.tb_pw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_pw.Size = New System.Drawing.Size(124, 22)
        Me.tb_pw.TabIndex = 8
        '
        'lbl_pw
        '
        Me.lbl_pw.AutoSize = True
        Me.lbl_pw.Location = New System.Drawing.Point(446, 33)
        Me.lbl_pw.Name = "lbl_pw"
        Me.lbl_pw.Size = New System.Drawing.Size(32, 12)
        Me.lbl_pw.TabIndex = 7
        Me.lbl_pw.Text = "密碼:"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 384)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(823, 22)
        Me.StatusStrip1.TabIndex = 9
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(131, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 406)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.tb_pw)
        Me.Controls.Add(Me.lbl_pw)
        Me.Controls.Add(Me.tb_server)
        Me.Controls.Add(Me.lbl_server)
        Me.Controls.Add(Me.tb_user)
        Me.Controls.Add(Me.lbl_user)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_get_data)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_get_data As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lbl_user As Label
    Friend WithEvents tb_user As TextBox
    Friend WithEvents tb_server As TextBox
    Friend WithEvents lbl_server As Label
    Friend WithEvents tb_pw As TextBox
    Friend WithEvents lbl_pw As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
End Class
