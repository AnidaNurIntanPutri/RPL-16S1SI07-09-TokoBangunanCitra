<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmMerchandise
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtkdHadiah = New System.Windows.Forms.TextBox()
        Me.kdHadiah = New System.Windows.Forms.Label()
        Me.cmbJenis = New System.Windows.Forms.ComboBox()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.txtKdMember = New System.Windows.Forms.TextBox()
        Me.txtKategori = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGMerchandise = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.DGMerchandise, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtkdHadiah)
        Me.Panel1.Controls.Add(Me.kdHadiah)
        Me.Panel1.Controls.Add(Me.cmbJenis)
        Me.Panel1.Controls.Add(Me.btnHapus)
        Me.Panel1.Controls.Add(Me.btnUbah)
        Me.Panel1.Controls.Add(Me.btnSimpan)
        Me.Panel1.Controls.Add(Me.txtKdMember)
        Me.Panel1.Controls.Add(Me.txtKategori)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(22, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(438, 202)
        Me.Panel1.TabIndex = 0
        '
        'txtkdHadiah
        '
        Me.txtkdHadiah.Location = New System.Drawing.Point(28, 41)
        Me.txtkdHadiah.Name = "txtkdHadiah"
        Me.txtkdHadiah.Size = New System.Drawing.Size(176, 20)
        Me.txtkdHadiah.TabIndex = 11
        '
        'kdHadiah
        '
        Me.kdHadiah.AutoSize = True
        Me.kdHadiah.Location = New System.Drawing.Point(24, 25)
        Me.kdHadiah.Name = "kdHadiah"
        Me.kdHadiah.Size = New System.Drawing.Size(69, 13)
        Me.kdHadiah.TabIndex = 10
        Me.kdHadiah.Text = "Kode Hadiah"
        '
        'cmbJenis
        '
        Me.cmbJenis.FormattingEnabled = True
        Me.cmbJenis.Items.AddRange(New Object() {"Elektronik", "Alat Rumah Tangga"})
        Me.cmbJenis.Location = New System.Drawing.Point(28, 163)
        Me.cmbJenis.Name = "cmbJenis"
        Me.cmbJenis.Size = New System.Drawing.Size(176, 21)
        Me.cmbJenis.TabIndex = 9
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(291, 133)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 8
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnUbah
        '
        Me.btnUbah.Location = New System.Drawing.Point(291, 97)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(75, 23)
        Me.btnUbah.TabIndex = 7
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(291, 64)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 6
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'txtKdMember
        '
        Me.txtKdMember.Location = New System.Drawing.Point(28, 123)
        Me.txtKdMember.Name = "txtKdMember"
        Me.txtKdMember.Size = New System.Drawing.Size(176, 20)
        Me.txtKdMember.TabIndex = 4
        '
        'txtKategori
        '
        Me.txtKategori.Location = New System.Drawing.Point(28, 83)
        Me.txtKategori.Name = "txtKategori"
        Me.txtKategori.Size = New System.Drawing.Size(176, 20)
        Me.txtKategori.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jenis Hadiah"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Member"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kategori Hadiah"
        '
        'DGMerchandise
        '
        Me.DGMerchandise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGMerchandise.Location = New System.Drawing.Point(22, 211)
        Me.DGMerchandise.Name = "DGMerchandise"
        Me.DGMerchandise.Size = New System.Drawing.Size(438, 150)
        Me.DGMerchandise.TabIndex = 1
        '
        'FmMerchandise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 381)
        Me.Controls.Add(Me.DGMerchandise)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FmMerchandise"
        Me.Text = "FormMerchandise"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGMerchandise, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmbJenis As ComboBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents txtKdMember As TextBox
    Friend WithEvents txtKategori As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DGMerchandise As DataGridView
    Friend WithEvents kdHadiah As Label
    Friend WithEvents txtkdHadiah As TextBox
End Class
