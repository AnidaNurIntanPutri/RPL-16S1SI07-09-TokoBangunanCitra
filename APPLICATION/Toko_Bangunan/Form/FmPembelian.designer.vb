<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmPembelian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmPembelian))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.txtKdBarang = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.cmbKdSupplier = New System.Windows.Forms.ComboBox()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblKdBeli = New System.Windows.Forms.Label()
        Me.lblTglBeli = New System.Windows.Forms.Label()
        Me.lblJumlahItem = New System.Windows.Forms.Label()
        Me.lblJumlahBarang = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBayar = New System.Windows.Forms.TextBox()
        Me.btnBaru = New System.Windows.Forms.Button()
        Me.LVBeli = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 122)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(825, 46)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kd Supplier"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 212)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Barang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 302)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Harga Barang"
        '
        'btnSimpan
        '
        Me.btnSimpan.Image = CType(resources.GetObject("btnSimpan.Image"), System.Drawing.Image)
        Me.btnSimpan.Location = New System.Drawing.Point(526, 605)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(112, 48)
        Me.btnSimpan.TabIndex = 5
        Me.btnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Image = CType(resources.GetObject("btnHapus.Image"), System.Drawing.Image)
        Me.btnHapus.Location = New System.Drawing.Point(658, 608)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(112, 48)
        Me.btnHapus.TabIndex = 7
        Me.btnHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'txtKdBarang
        '
        Me.txtKdBarang.Location = New System.Drawing.Point(42, 163)
        Me.txtKdBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtKdBarang.Name = "txtKdBarang"
        Me.txtKdBarang.Size = New System.Drawing.Size(193, 26)
        Me.txtKdBarang.TabIndex = 8
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(42, 237)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(324, 26)
        Me.txtNama.TabIndex = 9
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(42, 342)
        Me.txtHarga.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(193, 26)
        Me.txtHarga.TabIndex = 11
        '
        'cmbKdSupplier
        '
        Me.cmbKdSupplier.FormattingEnabled = True
        Me.cmbKdSupplier.Location = New System.Drawing.Point(814, 86)
        Me.cmbKdSupplier.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbKdSupplier.Name = "cmbKdSupplier"
        Me.cmbKdSupplier.Size = New System.Drawing.Size(180, 28)
        Me.cmbKdSupplier.TabIndex = 12
        '
        'btnKeluar
        '
        Me.btnKeluar.Image = CType(resources.GetObject("btnKeluar.Image"), System.Drawing.Image)
        Me.btnKeluar.Location = New System.Drawing.Point(48, 608)
        Me.btnKeluar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(134, 48)
        Me.btnKeluar.TabIndex = 14
        Me.btnKeluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Image = CType(resources.GetObject("btnTambah.Image"), System.Drawing.Image)
        Me.btnTambah.Location = New System.Drawing.Point(381, 605)
        Me.btnTambah.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(112, 52)
        Me.btnTambah.TabIndex = 20
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(40, 435)
        Me.txtQty.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(193, 26)
        Me.txtQty.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(44, 406)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 20)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Qty"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(44, 46)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 20)
        Me.Label7.TabIndex = 106
        Me.Label7.Text = "No. Transaksi"
        '
        'lblKdBeli
        '
        Me.lblKdBeli.AutoSize = True
        Me.lblKdBeli.Location = New System.Drawing.Point(188, 46)
        Me.lblKdBeli.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblKdBeli.Name = "lblKdBeli"
        Me.lblKdBeli.Size = New System.Drawing.Size(67, 20)
        Me.lblKdBeli.TabIndex = 120
        Me.lblKdBeli.Text = "lblKdbeli"
        '
        'lblTglBeli
        '
        Me.lblTglBeli.AutoSize = True
        Me.lblTglBeli.Location = New System.Drawing.Point(1082, 68)
        Me.lblTglBeli.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTglBeli.Name = "lblTglBeli"
        Me.lblTglBeli.Size = New System.Drawing.Size(66, 20)
        Me.lblTglBeli.TabIndex = 126
        Me.lblTglBeli.Text = "Label11"
        '
        'lblJumlahItem
        '
        Me.lblJumlahItem.AutoSize = True
        Me.lblJumlahItem.Location = New System.Drawing.Point(276, 497)
        Me.lblJumlahItem.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJumlahItem.Name = "lblJumlahItem"
        Me.lblJumlahItem.Size = New System.Drawing.Size(116, 20)
        Me.lblJumlahItem.TabIndex = 127
        Me.lblJumlahItem.Text = "Jumlah Barang"
        '
        'lblJumlahBarang
        '
        Me.lblJumlahBarang.AutoSize = True
        Me.lblJumlahBarang.Location = New System.Drawing.Point(436, 497)
        Me.lblJumlahBarang.Name = "lblJumlahBarang"
        Me.lblJumlahBarang.Size = New System.Drawing.Size(18, 20)
        Me.lblJumlahBarang.TabIndex = 128
        Me.lblJumlahBarang.Text = "0"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Gainsboro
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Location = New System.Drawing.Point(814, 497)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(150, 31)
        Me.Label14.TabIndex = 129
        Me.Label14.Text = "Total Harga"
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.Silver
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(1024, 495)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(150, 31)
        Me.lblTotal.TabIndex = 130
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(814, 555)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 31)
        Me.Label4.TabIndex = 131
        Me.Label4.Text = "Dibayar"
        '
        'txtBayar
        '
        Me.txtBayar.Location = New System.Drawing.Point(1024, 555)
        Me.txtBayar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBayar.Name = "txtBayar"
        Me.txtBayar.Size = New System.Drawing.Size(148, 26)
        Me.txtBayar.TabIndex = 133
        '
        'btnBaru
        '
        Me.btnBaru.Image = CType(resources.GetObject("btnBaru.Image"), System.Drawing.Image)
        Me.btnBaru.Location = New System.Drawing.Point(1128, 212)
        Me.btnBaru.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBaru.Name = "btnBaru"
        Me.btnBaru.Size = New System.Drawing.Size(112, 52)
        Me.btnBaru.TabIndex = 134
        Me.btnBaru.UseVisualStyleBackColor = True
        '
        'LVBeli
        '
        Me.LVBeli.Location = New System.Drawing.Point(468, 163)
        Me.LVBeli.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LVBeli.Name = "LVBeli"
        Me.LVBeli.Size = New System.Drawing.Size(625, 301)
        Me.LVBeli.TabIndex = 135
        Me.LVBeli.UseCompatibleStateImageBehavior = False
        '
        'FmPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1258, 689)
        Me.Controls.Add(Me.LVBeli)
        Me.Controls.Add(Me.btnBaru)
        Me.Controls.Add(Me.txtBayar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblJumlahBarang)
        Me.Controls.Add(Me.lblJumlahItem)
        Me.Controls.Add(Me.lblTglBeli)
        Me.Controls.Add(Me.lblKdBeli)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.cmbKdSupplier)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtKdBarang)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FmPembelian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPembelian"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents txtKdBarang As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents cmbKdSupplier As ComboBox
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents txtQty As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblKdBeli As Label
    Friend WithEvents lblTglBeli As Label
    Friend WithEvents lblJumlahItem As Label
    Friend WithEvents lblJumlahBarang As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBayar As TextBox
    Friend WithEvents btnBaru As Button
    Friend WithEvents LVBeli As ListView
End Class
