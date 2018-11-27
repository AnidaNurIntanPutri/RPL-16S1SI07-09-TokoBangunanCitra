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
        Dim pictureBox1 As System.Windows.Forms.PictureBox
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
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
        pictureBox1.Location = New System.Drawing.Point(29, 7)
        pictureBox1.Name = "pictureBox1"
        pictureBox1.Size = New System.Drawing.Size(59, 60)
        pictureBox1.TabIndex = 19
        pictureBox1.TabStop = False
        '
        'kembali
        '
        Me.kembali.Location = New System.Drawing.Point(327, 247)
        Me.kembali.Name = "kembali"
        Me.kembali.Size = New System.Drawing.Size(75, 23)
        Me.kembali.TabIndex = 18
        Me.kembali.Text = "KEMBALI"
        Me.kembali.UseVisualStyleBackColor = True
        '
        'kirim
        '
        Me.kirim.Location = New System.Drawing.Point(245, 247)
        Me.kirim.Name = "kirim"
        Me.kirim.Size = New System.Drawing.Size(75, 23)
        Me.kirim.TabIndex = 17
        Me.kirim.Text = "KIRIM"
        Me.kirim.UseVisualStyleBackColor = True
        '
        'pembelian
        '
        Me.pembelian.Location = New System.Drawing.Point(327, 43)
        Me.pembelian.Name = "pembelian"
        Me.pembelian.Size = New System.Drawing.Size(95, 23)
        Me.pembelian.TabIndex = 16
        Me.pembelian.Text = "PEMBELIAN"
        Me.pembelian.UseVisualStyleBackColor = True
        '
        'pajak
        '
        Me.pajak.Location = New System.Drawing.Point(245, 44)
        Me.pajak.Name = "pajak"
        Me.pajak.Size = New System.Drawing.Size(75, 23)
        Me.pajak.TabIndex = 15
        Me.pajak.Text = "PAJAK"
        Me.pajak.UseVisualStyleBackColor = True
        '
        'penjualan
        '
        Me.penjualan.Location = New System.Drawing.Point(140, 45)
        Me.penjualan.Name = "penjualan"
        Me.penjualan.Size = New System.Drawing.Size(98, 23)
        Me.penjualan.TabIndex = 14
        Me.penjualan.Text = "PENJUALAN"
        Me.penjualan.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(137, 18)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(190, 13)
        Me.label1.TabIndex = 13
        Me.label1.Text = "LAPORAN TOKO BANGUNAN CITRA"
        '
        'tahunan
        '
        Me.tahunan.Location = New System.Drawing.Point(5, 177)
        Me.tahunan.Name = "tahunan"
        Me.tahunan.Size = New System.Drawing.Size(99, 23)
        Me.tahunan.TabIndex = 12
        Me.tahunan.Text = "TAHUNAN"
        Me.tahunan.UseVisualStyleBackColor = True
        '
        'bulanan
        '
        Me.bulanan.Location = New System.Drawing.Point(5, 130)
        Me.bulanan.Name = "bulanan"
        Me.bulanan.Size = New System.Drawing.Size(99, 23)
        Me.bulanan.TabIndex = 11
        Me.bulanan.Text = "BULANAN"
        Me.bulanan.UseVisualStyleBackColor = True
        '
        'harian
        '
        Me.harian.Location = New System.Drawing.Point(5, 83)
        Me.harian.Name = "harian"
        Me.harian.Size = New System.Drawing.Size(99, 23)
        Me.harian.TabIndex = 10
        Me.harian.Text = "HARIAN"
        Me.harian.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 279)
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
        Me.Name = "Form1"
        Me.Text = "Form1"
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
