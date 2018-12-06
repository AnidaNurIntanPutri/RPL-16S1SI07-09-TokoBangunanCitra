<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRetur
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblNoRetur = New System.Windows.Forms.Label()
        Me.TxtNotaRetur = New System.Windows.Forms.TextBox()
        Me.TxtKdMember = New System.Windows.Forms.TextBox()
        Me.TxtJmlRetur = New System.Windows.Forms.TextBox()
        Me.DTTanggal = New System.Windows.Forms.DateTimePicker()
        Me.TxtAlmatRetur = New System.Windows.Forms.TextBox()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnKembali = New System.Windows.Forms.Button()
        Me.DGTRetur = New System.Windows.Forms.DataGridView()
        CType(Me.DGTRetur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Retur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No Nota"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Kode Member"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(236, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tanggal Retur"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(236, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Alamat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Jumlah Barang"
        '
        'LblNoRetur
        '
        Me.LblNoRetur.AutoSize = True
        Me.LblNoRetur.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNoRetur.Location = New System.Drawing.Point(16, 47)
        Me.LblNoRetur.Name = "LblNoRetur"
        Me.LblNoRetur.Size = New System.Drawing.Size(58, 13)
        Me.LblNoRetur.TabIndex = 6
        Me.LblNoRetur.Text = "R070191"
        '
        'TxtNotaRetur
        '
        Me.TxtNotaRetur.Location = New System.Drawing.Point(19, 95)
        Me.TxtNotaRetur.Name = "TxtNotaRetur"
        Me.TxtNotaRetur.Size = New System.Drawing.Size(173, 20)
        Me.TxtNotaRetur.TabIndex = 7
        '
        'TxtKdMember
        '
        Me.TxtKdMember.Location = New System.Drawing.Point(19, 147)
        Me.TxtKdMember.Name = "TxtKdMember"
        Me.TxtKdMember.Size = New System.Drawing.Size(173, 20)
        Me.TxtKdMember.TabIndex = 8
        '
        'TxtJmlRetur
        '
        Me.TxtJmlRetur.Location = New System.Drawing.Point(19, 199)
        Me.TxtJmlRetur.Name = "TxtJmlRetur"
        Me.TxtJmlRetur.Size = New System.Drawing.Size(173, 20)
        Me.TxtJmlRetur.TabIndex = 9
        '
        'DTTanggal
        '
        Me.DTTanggal.Location = New System.Drawing.Point(239, 47)
        Me.DTTanggal.Name = "DTTanggal"
        Me.DTTanggal.Size = New System.Drawing.Size(173, 20)
        Me.DTTanggal.TabIndex = 10
        '
        'TxtAlmatRetur
        '
        Me.TxtAlmatRetur.Location = New System.Drawing.Point(239, 95)
        Me.TxtAlmatRetur.Multiline = True
        Me.TxtAlmatRetur.Name = "TxtAlmatRetur"
        Me.TxtAlmatRetur.Size = New System.Drawing.Size(167, 84)
        Me.TxtAlmatRetur.TabIndex = 11
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(239, 199)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.BtnSimpan.TabIndex = 12
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'BtnKembali
        '
        Me.BtnKembali.Location = New System.Drawing.Point(331, 199)
        Me.BtnKembali.Name = "BtnKembali"
        Me.BtnKembali.Size = New System.Drawing.Size(75, 23)
        Me.BtnKembali.TabIndex = 13
        Me.BtnKembali.Text = "Kembali"
        Me.BtnKembali.UseVisualStyleBackColor = True
        '
        'DGTRetur
        '
        Me.DGTRetur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGTRetur.Location = New System.Drawing.Point(19, 247)
        Me.DGTRetur.Name = "DGTRetur"
        Me.DGTRetur.Size = New System.Drawing.Size(387, 99)
        Me.DGTRetur.TabIndex = 14
        '
        'FrmRetur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 373)
        Me.Controls.Add(Me.DGTRetur)
        Me.Controls.Add(Me.BtnKembali)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.TxtAlmatRetur)
        Me.Controls.Add(Me.DTTanggal)
        Me.Controls.Add(Me.TxtJmlRetur)
        Me.Controls.Add(Me.TxtKdMember)
        Me.Controls.Add(Me.TxtNotaRetur)
        Me.Controls.Add(Me.LblNoRetur)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmRetur"
        Me.Text = "FormRetur"
        CType(Me.DGTRetur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LblNoRetur As Label
    Friend WithEvents TxtNotaRetur As TextBox
    Friend WithEvents TxtKdMember As TextBox
    Friend WithEvents TxtJmlRetur As TextBox
    Friend WithEvents DTTanggal As DateTimePicker
    Friend WithEvents TxtAlmatRetur As TextBox
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents BtnKembali As Button
    Friend WithEvents DGTRetur As DataGridView
End Class
