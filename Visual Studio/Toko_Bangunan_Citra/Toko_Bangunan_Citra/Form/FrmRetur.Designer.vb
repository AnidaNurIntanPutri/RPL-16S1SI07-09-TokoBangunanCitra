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
        Me.Label1.Location = New System.Drawing.Point(24, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Retur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 122)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No Nota"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 202)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Kode Member"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(354, 48)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tanggal Retur"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(354, 122)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Alamat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 282)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Jumlah Barang"
        '
        'LblNoRetur
        '
        Me.LblNoRetur.AutoSize = True
        Me.LblNoRetur.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNoRetur.Location = New System.Drawing.Point(24, 72)
        Me.LblNoRetur.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNoRetur.Name = "LblNoRetur"
        Me.LblNoRetur.Size = New System.Drawing.Size(82, 20)
        Me.LblNoRetur.TabIndex = 6
        Me.LblNoRetur.Text = "R070191"
        '
        'TxtNotaRetur
        '
        Me.TxtNotaRetur.Location = New System.Drawing.Point(28, 146)
        Me.TxtNotaRetur.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtNotaRetur.Name = "TxtNotaRetur"
        Me.TxtNotaRetur.Size = New System.Drawing.Size(258, 26)
        Me.TxtNotaRetur.TabIndex = 7
        '
        'TxtKdMember
        '
        Me.TxtKdMember.Location = New System.Drawing.Point(28, 226)
        Me.TxtKdMember.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtKdMember.Name = "TxtKdMember"
        Me.TxtKdMember.Size = New System.Drawing.Size(258, 26)
        Me.TxtKdMember.TabIndex = 8
        '
        'TxtJmlRetur
        '
        Me.TxtJmlRetur.Location = New System.Drawing.Point(28, 306)
        Me.TxtJmlRetur.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtJmlRetur.Name = "TxtJmlRetur"
        Me.TxtJmlRetur.Size = New System.Drawing.Size(258, 26)
        Me.TxtJmlRetur.TabIndex = 9
        '
        'DTTanggal
        '
        Me.DTTanggal.Location = New System.Drawing.Point(358, 72)
        Me.DTTanggal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DTTanggal.Name = "DTTanggal"
        Me.DTTanggal.Size = New System.Drawing.Size(258, 26)
        Me.DTTanggal.TabIndex = 10
        '
        'TxtAlmatRetur
        '
        Me.TxtAlmatRetur.Location = New System.Drawing.Point(358, 146)
        Me.TxtAlmatRetur.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtAlmatRetur.Multiline = True
        Me.TxtAlmatRetur.Name = "TxtAlmatRetur"
        Me.TxtAlmatRetur.Size = New System.Drawing.Size(248, 127)
        Me.TxtAlmatRetur.TabIndex = 11
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(358, 306)
        Me.BtnSimpan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(112, 35)
        Me.BtnSimpan.TabIndex = 12
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'BtnKembali
        '
        Me.BtnKembali.Location = New System.Drawing.Point(496, 306)
        Me.BtnKembali.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnKembali.Name = "BtnKembali"
        Me.BtnKembali.Size = New System.Drawing.Size(112, 35)
        Me.BtnKembali.TabIndex = 13
        Me.BtnKembali.Text = "Kembali"
        Me.BtnKembali.UseVisualStyleBackColor = True
        '
        'DGTRetur
        '
        Me.DGTRetur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGTRetur.Location = New System.Drawing.Point(28, 380)
        Me.DGTRetur.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DGTRetur.Name = "DGTRetur"
        Me.DGTRetur.Size = New System.Drawing.Size(580, 152)
        Me.DGTRetur.TabIndex = 14
        '
        'FrmRetur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 574)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
