<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.laporan = New System.Windows.Forms.Button()
        Me.customer = New System.Windows.Forms.Button()
        Me.kasir = New System.Windows.Forms.Button()
        Me.penjualan = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'laporan
        '
        Me.laporan.Location = New System.Drawing.Point(303, 197)
        Me.laporan.Name = "laporan"
        Me.laporan.Size = New System.Drawing.Size(75, 23)
        Me.laporan.TabIndex = 11
        Me.laporan.Text = "Laporan"
        Me.laporan.UseVisualStyleBackColor = True
        '
        'customer
        '
        Me.customer.Location = New System.Drawing.Point(221, 198)
        Me.customer.Name = "customer"
        Me.customer.Size = New System.Drawing.Size(75, 23)
        Me.customer.TabIndex = 10
        Me.customer.Text = "Customer"
        Me.customer.UseVisualStyleBackColor = True
        '
        'kasir
        '
        Me.kasir.Location = New System.Drawing.Point(139, 199)
        Me.kasir.Name = "kasir"
        Me.kasir.Size = New System.Drawing.Size(75, 23)
        Me.kasir.TabIndex = 9
        Me.kasir.Text = "Kasir"
        Me.kasir.UseVisualStyleBackColor = True
        '
        'penjualan
        '
        Me.penjualan.Location = New System.Drawing.Point(57, 199)
        Me.penjualan.Name = "penjualan"
        Me.penjualan.Size = New System.Drawing.Size(75, 23)
        Me.penjualan.TabIndex = 8
        Me.penjualan.Text = "Penjualan"
        Me.penjualan.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 69)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(433, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(113, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "TOKO BANGUNAN CITRA"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 252)
        Me.Controls.Add(Me.laporan)
        Me.Controls.Add(Me.customer)
        Me.Controls.Add(Me.kasir)
        Me.Controls.Add(Me.penjualan)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents laporan As Button
    Friend WithEvents customer As Button
    Friend WithEvents kasir As Button
    Friend WithEvents penjualan As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
