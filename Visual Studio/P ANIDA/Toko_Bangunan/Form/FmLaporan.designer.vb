<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmLaporan
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
        Dim pictureBox1 As System.Windows.Forms.PictureBox
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmLaporan))
        Me.backgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.kembali = New System.Windows.Forms.Button()
        Me.kirim = New System.Windows.Forms.Button()
        Me.pembelian = New System.Windows.Forms.Button()
        Me.pajak = New System.Windows.Forms.Button()
        Me.penjualan = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.tahunan = New System.Windows.Forms.Button()
        Me.bulanan = New System.Windows.Forms.Button()
        Me.harian = New System.Windows.Forms.Button()
        pictureBox1 = New System.Windows.Forms.PictureBox()
        CType(pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pictureBox1
        '
        pictureBox1.ErrorImage = CType(resources.GetObject("pictureBox1.ErrorImage"), System.Drawing.Image)
        pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        pictureBox1.InitialImage = CType(resources.GetObject("pictureBox1.InitialImage"), System.Drawing.Image)
        pictureBox1.Location = New System.Drawing.Point(44, 11)
        pictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        pictureBox1.Name = "pictureBox1"
        pictureBox1.Size = New System.Drawing.Size(88, 92)
        pictureBox1.TabIndex = 19
        pictureBox1.TabStop = False
        '
        'kembali
        '
        Me.kembali.Location = New System.Drawing.Point(490, 380)
        Me.kembali.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.kembali.Name = "kembali"
        Me.kembali.Size = New System.Drawing.Size(112, 35)
        Me.kembali.TabIndex = 18
        Me.kembali.Text = "KEMBALI"
        Me.kembali.UseVisualStyleBackColor = True
        '
        'kirim
        '
        Me.kirim.Location = New System.Drawing.Point(368, 380)
        Me.kirim.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.kirim.Name = "kirim"
        Me.kirim.Size = New System.Drawing.Size(112, 35)
        Me.kirim.TabIndex = 17
        Me.kirim.Text = "KIRIM"
        Me.kirim.UseVisualStyleBackColor = True
        '
        'pembelian
        '
        Me.pembelian.Location = New System.Drawing.Point(490, 66)
        Me.pembelian.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pembelian.Name = "pembelian"
        Me.pembelian.Size = New System.Drawing.Size(142, 35)
        Me.pembelian.TabIndex = 16
        Me.pembelian.Text = "PEMBELIAN"
        Me.pembelian.UseVisualStyleBackColor = True
        '
        'pajak
        '
        Me.pajak.Location = New System.Drawing.Point(368, 68)
        Me.pajak.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pajak.Name = "pajak"
        Me.pajak.Size = New System.Drawing.Size(112, 35)
        Me.pajak.TabIndex = 15
        Me.pajak.Text = "PAJAK"
        Me.pajak.UseVisualStyleBackColor = True
        '
        'penjualan
        '
        Me.penjualan.Location = New System.Drawing.Point(210, 69)
        Me.penjualan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.penjualan.Name = "penjualan"
        Me.penjualan.Size = New System.Drawing.Size(147, 35)
        Me.penjualan.TabIndex = 14
        Me.penjualan.Text = "PENJUALAN"
        Me.penjualan.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(206, 28)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(279, 20)
        Me.label1.TabIndex = 13
        Me.label1.Text = "LAPORAN TOKO BANGUNAN CITRA"
        '
        'tahunan
        '
        Me.tahunan.Location = New System.Drawing.Point(8, 272)
        Me.tahunan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tahunan.Name = "tahunan"
        Me.tahunan.Size = New System.Drawing.Size(148, 35)
        Me.tahunan.TabIndex = 12
        Me.tahunan.Text = "TAHUNAN"
        Me.tahunan.UseVisualStyleBackColor = True
        '
        'bulanan
        '
        Me.bulanan.Location = New System.Drawing.Point(8, 200)
        Me.bulanan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bulanan.Name = "bulanan"
        Me.bulanan.Size = New System.Drawing.Size(148, 35)
        Me.bulanan.TabIndex = 11
        Me.bulanan.Text = "BULANAN"
        Me.bulanan.UseVisualStyleBackColor = True
        '
        'harian
        '
        Me.harian.Location = New System.Drawing.Point(8, 128)
        Me.harian.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.harian.Name = "harian"
        Me.harian.Size = New System.Drawing.Size(148, 35)
        Me.harian.TabIndex = 10
        Me.harian.Text = "HARIAN"
        Me.harian.UseVisualStyleBackColor = True
        '
        'FmLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 429)
        Me.Controls.Add(pictureBox1)
        Me.Controls.Add(Me.kembali)
        Me.Controls.Add(Me.kirim)
        Me.Controls.Add(Me.pembelian)
        Me.Controls.Add(Me.pajak)
        Me.Controls.Add(Me.penjualan)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.tahunan)
        Me.Controls.Add(Me.bulanan)
        Me.Controls.Add(Me.harian)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FmLaporan"
        Me.Text = "FmLaporan"
        CType(pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents backgroundWorker1 As System.ComponentModel.BackgroundWorker
    Private WithEvents kembali As Button
    Private WithEvents kirim As Button
    Private WithEvents pembelian As Button
    Private WithEvents pajak As Button
    Private WithEvents penjualan As Button
    Private WithEvents label1 As Label
    Private WithEvents tahunan As Button
    Private WithEvents bulanan As Button
    Private WithEvents harian As Button
End Class
