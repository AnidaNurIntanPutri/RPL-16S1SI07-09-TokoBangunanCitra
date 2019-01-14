<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FmKredit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmKredit))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtKredit = New System.Windows.Forms.TextBox()
        Me.txtNota = New System.Windows.Forms.TextBox()
        Me.txtNamaPel = New System.Windows.Forms.TextBox()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtKTP = New System.Windows.Forms.TextBox()
        Me.DTTglLunas = New System.Windows.Forms.DateTimePicker()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.DGKredit = New System.Windows.Forms.DataGridView()
        Me.lblTglNow = New System.Windows.Forms.Label()
        CType(Me.DGKredit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Kredit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(410, 40)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No Nota"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 171)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Pelanggan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(48, 288)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(410, 171)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tanggal Pelunasan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(404, 288)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "No KTP"
        '
        'txtKredit
        '
        Me.txtKredit.Location = New System.Drawing.Point(52, 86)
        Me.txtKredit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtKredit.Name = "txtKredit"
        Me.txtKredit.Size = New System.Drawing.Size(206, 26)
        Me.txtKredit.TabIndex = 6
        '
        'txtNota
        '
        Me.txtNota.Location = New System.Drawing.Point(414, 86)
        Me.txtNota.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNota.Name = "txtNota"
        Me.txtNota.Size = New System.Drawing.Size(234, 26)
        Me.txtNota.TabIndex = 7
        '
        'txtNamaPel
        '
        Me.txtNamaPel.Location = New System.Drawing.Point(52, 218)
        Me.txtNamaPel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNamaPel.Name = "txtNamaPel"
        Me.txtNamaPel.Size = New System.Drawing.Size(307, 26)
        Me.txtNamaPel.TabIndex = 8
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(52, 332)
        Me.txtAlamat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(307, 142)
        Me.txtAlamat.TabIndex = 10
        '
        'txtKTP
        '
        Me.txtKTP.Location = New System.Drawing.Point(408, 332)
        Me.txtKTP.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtKTP.Name = "txtKTP"
        Me.txtKTP.Size = New System.Drawing.Size(298, 26)
        Me.txtKTP.TabIndex = 11
        '
        'DTTglLunas
        '
        Me.DTTglLunas.Location = New System.Drawing.Point(408, 218)
        Me.DTTglLunas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DTTglLunas.Name = "DTTglLunas"
        Me.DTTglLunas.Size = New System.Drawing.Size(298, 26)
        Me.DTTglLunas.TabIndex = 12
        '
        'btnHapus
        '
        Me.btnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.Image = CType(resources.GetObject("btnHapus.Image"), System.Drawing.Image)
        Me.btnHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHapus.Location = New System.Drawing.Point(408, 414)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(112, 52)
        Me.btnHapus.TabIndex = 13
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.Image = CType(resources.GetObject("btnSimpan.Image"), System.Drawing.Image)
        Me.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSimpan.Location = New System.Drawing.Point(537, 414)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(112, 52)
        Me.btnSimpan.TabIndex = 14
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnUbah
        '
        Me.btnUbah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUbah.Image = CType(resources.GetObject("btnUbah.Image"), System.Drawing.Image)
        Me.btnUbah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUbah.Location = New System.Drawing.Point(670, 414)
        Me.btnUbah.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(112, 52)
        Me.btnUbah.TabIndex = 15
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'btnKembali
        '
        Me.btnKembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKembali.Image = CType(resources.GetObject("btnKembali.Image"), System.Drawing.Image)
        Me.btnKembali.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKembali.Location = New System.Drawing.Point(802, 414)
        Me.btnKembali.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(112, 52)
        Me.btnKembali.TabIndex = 16
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnKembali.UseVisualStyleBackColor = True
        '
        'DGKredit
        '
        Me.DGKredit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGKredit.Location = New System.Drawing.Point(52, 502)
        Me.DGKredit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DGKredit.Name = "DGKredit"
        Me.DGKredit.Size = New System.Drawing.Size(862, 263)
        Me.DGKredit.TabIndex = 17
        '
        'lblTglNow
        '
        Me.lblTglNow.AutoSize = True
        Me.lblTglNow.Location = New System.Drawing.Point(743, 40)
        Me.lblTglNow.Name = "lblTglNow"
        Me.lblTglNow.Size = New System.Drawing.Size(113, 20)
        Me.lblTglNow.TabIndex = 18
        Me.lblTglNow.Text = "Tanggal Today"
        '
        'FmKredit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 791)
        Me.Controls.Add(Me.lblTglNow)
        Me.Controls.Add(Me.DGKredit)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.DTTglLunas)
        Me.Controls.Add(Me.txtKTP)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.txtNamaPel)
        Me.Controls.Add(Me.txtNota)
        Me.Controls.Add(Me.txtKredit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FmKredit"
        Me.Text = "FormKredit"
        CType(Me.DGKredit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtKredit As TextBox
    Friend WithEvents txtNota As TextBox
    Friend WithEvents txtNamaPel As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtKTP As TextBox
    Friend WithEvents DTTglLunas As DateTimePicker
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnKembali As Button
    Friend WithEvents DGKredit As DataGridView
    Friend WithEvents lblTglNow As Label
End Class
