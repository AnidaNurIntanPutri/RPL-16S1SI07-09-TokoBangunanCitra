<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMember
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
        Me.TxtNoKTP = New System.Windows.Forms.TextBox()
        Me.TxtTlpMember = New System.Windows.Forms.TextBox()
        Me.TxtNmMember = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblKdMember = New System.Windows.Forms.Label()
        Me.TxtAlmMember = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DTGMember = New System.Windows.Forms.DataGridView()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnUbah = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnKembali = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        CType(Me.DTGMember, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtNoKTP
        '
        Me.TxtNoKTP.Location = New System.Drawing.Point(176, 191)
        Me.TxtNoKTP.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtNoKTP.Name = "TxtNoKTP"
        Me.TxtNoKTP.Size = New System.Drawing.Size(355, 26)
        Me.TxtNoKTP.TabIndex = 12
        '
        'TxtTlpMember
        '
        Me.TxtTlpMember.Location = New System.Drawing.Point(176, 140)
        Me.TxtTlpMember.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtTlpMember.Name = "TxtTlpMember"
        Me.TxtTlpMember.Size = New System.Drawing.Size(355, 26)
        Me.TxtTlpMember.TabIndex = 11
        '
        'TxtNmMember
        '
        Me.TxtNmMember.Location = New System.Drawing.Point(176, 89)
        Me.TxtNmMember.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtNmMember.Name = "TxtNmMember"
        Me.TxtNmMember.Size = New System.Drawing.Size(355, 26)
        Me.TxtNmMember.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 195)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "No_KTP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 145)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Telepon"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 94)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nama Member"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Kode Member"
        '
        'lblKdMember
        '
        Me.lblKdMember.AutoSize = True
        Me.lblKdMember.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKdMember.Location = New System.Drawing.Point(171, 35)
        Me.lblKdMember.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblKdMember.Name = "lblKdMember"
        Me.lblKdMember.Size = New System.Drawing.Size(61, 20)
        Me.lblKdMember.TabIndex = 14
        Me.lblKdMember.Text = "M-001"
        '
        'TxtAlmMember
        '
        Me.TxtAlmMember.Location = New System.Drawing.Point(175, 291)
        Me.TxtAlmMember.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtAlmMember.Multiline = True
        Me.TxtAlmMember.Name = "TxtAlmMember"
        Me.TxtAlmMember.Size = New System.Drawing.Size(356, 56)
        Me.TxtAlmMember.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(47, 291)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 20)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Alamat"
        '
        'DTGMember
        '
        Me.DTGMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTGMember.Location = New System.Drawing.Point(51, 386)
        Me.DTGMember.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DTGMember.Name = "DTGMember"
        Me.DTGMember.Size = New System.Drawing.Size(646, 231)
        Me.DTGMember.TabIndex = 17
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(585, 195)
        Me.BtnSimpan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(112, 35)
        Me.BtnSimpan.TabIndex = 18
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'BtnUbah
        '
        Me.BtnUbah.Location = New System.Drawing.Point(585, 254)
        Me.BtnUbah.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Size = New System.Drawing.Size(112, 35)
        Me.BtnUbah.TabIndex = 19
        Me.BtnUbah.Text = "Ubah"
        Me.BtnUbah.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(585, 314)
        Me.BtnHapus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(112, 35)
        Me.BtnHapus.TabIndex = 20
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnKembali
        '
        Me.BtnKembali.Location = New System.Drawing.Point(585, 654)
        Me.BtnKembali.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnKembali.Name = "BtnKembali"
        Me.BtnKembali.Size = New System.Drawing.Size(112, 35)
        Me.BtnKembali.TabIndex = 21
        Me.BtnKembali.Text = "Kembali"
        Me.BtnKembali.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 234)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 20)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "E-Mail"
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(175, 234)
        Me.TxtEmail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(355, 26)
        Me.TxtEmail.TabIndex = 23
        '
        'FrmMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 708)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnKembali)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnUbah)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.DTGMember)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtAlmMember)
        Me.Controls.Add(Me.lblKdMember)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtNoKTP)
        Me.Controls.Add(Me.TxtTlpMember)
        Me.Controls.Add(Me.TxtNmMember)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmMember"
        Me.Text = "FormMember"
        CType(Me.DTGMember, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtNoKTP As TextBox
    Friend WithEvents TxtTlpMember As TextBox
    Friend WithEvents TxtNmMember As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblKdMember As Label
    Friend WithEvents TxtAlmMember As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DTGMember As DataGridView
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents BtnUbah As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnKembali As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtEmail As TextBox
End Class
