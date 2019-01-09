<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmMenuPemilik
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmMenuPemilik))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pembelian = New System.Windows.Forms.Button()
        Me.kasir = New System.Windows.Forms.Button()
        Me.customer = New System.Windows.Forms.Button()
        Me.laporan = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(178, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(320, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TOKO BANGUNAN CITRA"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(18, 109)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(433, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'pembelian
        '
        Me.pembelian.Location = New System.Drawing.Point(94, 309)
        Me.pembelian.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pembelian.Name = "pembelian"
        Me.pembelian.Size = New System.Drawing.Size(112, 35)
        Me.pembelian.TabIndex = 2
        Me.pembelian.Text = "Pembelian"
        Me.pembelian.UseVisualStyleBackColor = True
        '
        'kasir
        '
        Me.kasir.Location = New System.Drawing.Point(218, 309)
        Me.kasir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.kasir.Name = "kasir"
        Me.kasir.Size = New System.Drawing.Size(112, 35)
        Me.kasir.TabIndex = 3
        Me.kasir.Text = "Kasir"
        Me.kasir.UseVisualStyleBackColor = True
        '
        'customer
        '
        Me.customer.Location = New System.Drawing.Point(340, 308)
        Me.customer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.customer.Name = "customer"
        Me.customer.Size = New System.Drawing.Size(112, 35)
        Me.customer.TabIndex = 4
        Me.customer.Text = "Customer"
        Me.customer.UseVisualStyleBackColor = True
        '
        'laporan
        '
        Me.laporan.Location = New System.Drawing.Point(464, 306)
        Me.laporan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.laporan.Name = "laporan"
        Me.laporan.Size = New System.Drawing.Size(112, 35)
        Me.laporan.TabIndex = 5
        Me.laporan.Text = "Laporan"
        Me.laporan.UseVisualStyleBackColor = True
        '
        'FmMenuPemilik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 414)
        Me.Controls.Add(Me.laporan)
        Me.Controls.Add(Me.customer)
        Me.Controls.Add(Me.kasir)
        Me.Controls.Add(Me.pembelian)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FmMenuPemilik"
        Me.Text = "Halaman Pemilik"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pembelian As Button
    Friend WithEvents kasir As Button
    Friend WithEvents customer As Button
    Friend WithEvents laporan As Button
End Class
