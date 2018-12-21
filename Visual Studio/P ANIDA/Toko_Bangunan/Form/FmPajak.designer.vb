<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmPajak
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
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnUbah = New System.Windows.Forms.Button()
        Me.BtnKembali = New System.Windows.Forms.Button()
        Me.TxtNoPajak = New System.Windows.Forms.TextBox()
        Me.TxtJumlahPajak = New System.Windows.Forms.TextBox()
        Me.DTPajak = New System.Windows.Forms.DateTimePicker()
        Me.DGPajak = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DGPajak, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nomor Pajak"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(88, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jumlah Pajak"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(88, 251)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tanggal Bayar"
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(54, 305)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(104, 34)
        Me.BtnSimpan.TabIndex = 3
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(196, 305)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(104, 34)
        Me.BtnHapus.TabIndex = 4
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnUbah
        '
        Me.BtnUbah.Location = New System.Drawing.Point(345, 305)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Size = New System.Drawing.Size(104, 34)
        Me.BtnUbah.TabIndex = 5
        Me.BtnUbah.Text = "Ubah"
        Me.BtnUbah.UseVisualStyleBackColor = True
        '
        'BtnKembali
        '
        Me.BtnKembali.Location = New System.Drawing.Point(499, 305)
        Me.BtnKembali.Name = "BtnKembali"
        Me.BtnKembali.Size = New System.Drawing.Size(104, 34)
        Me.BtnKembali.TabIndex = 6
        Me.BtnKembali.Text = "Kembali"
        Me.BtnKembali.UseVisualStyleBackColor = True
        '
        'TxtNoPajak
        '
        Me.TxtNoPajak.Location = New System.Drawing.Point(232, 103)
        Me.TxtNoPajak.Name = "TxtNoPajak"
        Me.TxtNoPajak.Size = New System.Drawing.Size(347, 26)
        Me.TxtNoPajak.TabIndex = 7
        '
        'TxtJumlahPajak
        '
        Me.TxtJumlahPajak.Location = New System.Drawing.Point(232, 175)
        Me.TxtJumlahPajak.Name = "TxtJumlahPajak"
        Me.TxtJumlahPajak.Size = New System.Drawing.Size(347, 26)
        Me.TxtJumlahPajak.TabIndex = 8
        '
        'DTPajak
        '
        Me.DTPajak.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPajak.Location = New System.Drawing.Point(232, 246)
        Me.DTPajak.Name = "DTPajak"
        Me.DTPajak.Size = New System.Drawing.Size(347, 26)
        Me.DTPajak.TabIndex = 9
        '
        'DGPajak
        '
        Me.DGPajak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPajak.Location = New System.Drawing.Point(21, 359)
        Me.DGPajak.Name = "DGPajak"
        Me.DGPajak.RowTemplate.Height = 28
        Me.DGPajak.Size = New System.Drawing.Size(618, 224)
        Me.DGPajak.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(299, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 29)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "PAJAK"
        '
        'FmPajak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 619)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DGPajak)
        Me.Controls.Add(Me.DTPajak)
        Me.Controls.Add(Me.TxtJumlahPajak)
        Me.Controls.Add(Me.TxtNoPajak)
        Me.Controls.Add(Me.BtnKembali)
        Me.Controls.Add(Me.BtnUbah)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FmPajak"
        Me.Text = "Data Pajak"
        CType(Me.DGPajak, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnUbah As Button
    Friend WithEvents BtnKembali As Button
    Friend WithEvents TxtNoPajak As TextBox
    Friend WithEvents TxtJumlahPajak As TextBox
    Friend WithEvents DTPajak As DateTimePicker
    Friend WithEvents DGPajak As DataGridView
    Friend WithEvents Label4 As Label
End Class
