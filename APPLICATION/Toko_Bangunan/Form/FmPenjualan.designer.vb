<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FmPenjualan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmPenjualan))
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.txtkembalian = New System.Windows.Forms.TextBox()
        Me.txtbayar = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.hapus = New System.Windows.Forms.Button()
        Me.ubah = New System.Windows.Forms.Button()
        Me.simpan = New System.Windows.Forms.Button()
        Me.txtjumlah = New System.Windows.Forms.TextBox()
        Me.txtkodebarang = New System.Windows.Forms.TextBox()
        Me.jumlah_ = New System.Windows.Forms.Label()
        Me.kode_barang = New System.Windows.Forms.Label()
        Me.txtkasir = New System.Windows.Forms.Label()
        Me.txtnonota = New System.Windows.Forms.Label()
        Me.DGPenjualan = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(388, 3)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(114, 101)
        Me.pictureBox1.TabIndex = 41
        Me.pictureBox1.TabStop = False
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(159, 389)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(100, 23)
        Me.button2.TabIndex = 40
        Me.button2.Text = "PRINT"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(23, 389)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(97, 23)
        Me.button1.TabIndex = 39
        Me.button1.Text = "KREDIT"
        Me.button1.UseVisualStyleBackColor = True
        '
        'txtkembalian
        '
        Me.txtkembalian.Location = New System.Drawing.Point(341, 342)
        Me.txtkembalian.Name = "txtkembalian"
        Me.txtkembalian.Size = New System.Drawing.Size(140, 20)
        Me.txtkembalian.TabIndex = 38
        '
        'txtbayar
        '
        Me.txtbayar.Location = New System.Drawing.Point(341, 299)
        Me.txtbayar.Name = "txtbayar"
        Me.txtbayar.Size = New System.Drawing.Size(140, 20)
        Me.txtbayar.TabIndex = 37
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(341, 256)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(140, 20)
        Me.txttotal.TabIndex = 36
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(338, 326)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(68, 13)
        Me.label4.TabIndex = 35
        Me.label4.Text = "KEMBALIAN"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(338, 284)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(43, 13)
        Me.label3.TabIndex = 34
        Me.label3.Text = "BAYAR"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(338, 241)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(42, 13)
        Me.label2.TabIndex = 33
        Me.label2.Text = "TOTAL"
        '
        'hapus
        '
        Me.hapus.Location = New System.Drawing.Point(307, 79)
        Me.hapus.Name = "hapus"
        Me.hapus.Size = New System.Drawing.Size(75, 23)
        Me.hapus.TabIndex = 29
        Me.hapus.Text = "HAPUS"
        Me.hapus.UseVisualStyleBackColor = True
        '
        'ubah
        '
        Me.ubah.Location = New System.Drawing.Point(307, 50)
        Me.ubah.Name = "ubah"
        Me.ubah.Size = New System.Drawing.Size(75, 23)
        Me.ubah.TabIndex = 28
        Me.ubah.Text = "UBAH"
        Me.ubah.UseVisualStyleBackColor = True
        '
        'simpan
        '
        Me.simpan.Location = New System.Drawing.Point(307, 21)
        Me.simpan.Name = "simpan"
        Me.simpan.Size = New System.Drawing.Size(75, 23)
        Me.simpan.TabIndex = 27
        Me.simpan.Text = "SIMPAN"
        Me.simpan.UseVisualStyleBackColor = True
        '
        'txtjumlah
        '
        Me.txtjumlah.Location = New System.Drawing.Point(129, 83)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.Size = New System.Drawing.Size(100, 20)
        Me.txtjumlah.TabIndex = 26
        '
        'txtkodebarang
        '
        Me.txtkodebarang.Location = New System.Drawing.Point(11, 83)
        Me.txtkodebarang.Name = "txtkodebarang"
        Me.txtkodebarang.Size = New System.Drawing.Size(100, 20)
        Me.txtkodebarang.TabIndex = 25
        '
        'jumlah_
        '
        Me.jumlah_.AutoSize = True
        Me.jumlah_.Location = New System.Drawing.Point(126, 66)
        Me.jumlah_.Name = "jumlah_"
        Me.jumlah_.Size = New System.Drawing.Size(40, 13)
        Me.jumlah_.TabIndex = 24
        Me.jumlah_.Text = "Jumlah"
        '
        'kode_barang
        '
        Me.kode_barang.AutoSize = True
        Me.kode_barang.Location = New System.Drawing.Point(8, 66)
        Me.kode_barang.Name = "kode_barang"
        Me.kode_barang.Size = New System.Drawing.Size(69, 13)
        Me.kode_barang.TabIndex = 23
        Me.kode_barang.Text = "Kode Barang"
        '
        'txtkasir
        '
        Me.txtkasir.AutoSize = True
        Me.txtkasir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkasir.Location = New System.Drawing.Point(126, 10)
        Me.txtkasir.Name = "txtkasir"
        Me.txtkasir.Size = New System.Drawing.Size(35, 13)
        Me.txtkasir.TabIndex = 22
        Me.txtkasir.Text = "Kasir"
        '
        'txtnonota
        '
        Me.txtnonota.AutoSize = True
        Me.txtnonota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnonota.Location = New System.Drawing.Point(8, 10)
        Me.txtnonota.Name = "txtnonota"
        Me.txtnonota.Size = New System.Drawing.Size(54, 13)
        Me.txtnonota.TabIndex = 21
        Me.txtnonota.Text = "No Nota"
        '
        'DGPenjualan
        '
        Me.DGPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPenjualan.Location = New System.Drawing.Point(11, 116)
        Me.DGPenjualan.Margin = New System.Windows.Forms.Padding(2)
        Me.DGPenjualan.Name = "DGPenjualan"
        Me.DGPenjualan.RowTemplate.Height = 28
        Me.DGPenjualan.Size = New System.Drawing.Size(289, 97)
        Me.DGPenjualan.TabIndex = 42
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(23, 256)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 28
        Me.DataGridView2.Size = New System.Drawing.Size(286, 97)
        Me.DataGridView2.TabIndex = 43
        '
        'FmPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 428)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DGPenjualan)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.txtkembalian)
        Me.Controls.Add(Me.txtbayar)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.hapus)
        Me.Controls.Add(Me.ubah)
        Me.Controls.Add(Me.simpan)
        Me.Controls.Add(Me.txtjumlah)
        Me.Controls.Add(Me.txtkodebarang)
        Me.Controls.Add(Me.jumlah_)
        Me.Controls.Add(Me.kode_barang)
        Me.Controls.Add(Me.txtkasir)
        Me.Controls.Add(Me.txtnonota)
        Me.Name = "FmPenjualan"
        Me.Text = "Form1"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents txtkembalian As TextBox
    Private WithEvents txtbayar As TextBox
    Private WithEvents txttotal As TextBox
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents hapus As Button
    Private WithEvents ubah As Button
    Private WithEvents simpan As Button
    Private WithEvents txtjumlah As TextBox
    Private WithEvents txtkodebarang As TextBox
    Private WithEvents jumlah_ As Label
    Private WithEvents kode_barang As Label
    Private WithEvents txtkasir As Label
    Private WithEvents txtnonota As Label
    Friend WithEvents DGPenjualan As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
End Class
