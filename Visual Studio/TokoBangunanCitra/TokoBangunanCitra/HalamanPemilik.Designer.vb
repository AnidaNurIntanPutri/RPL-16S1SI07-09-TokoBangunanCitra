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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
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
        Me.Label1.Location = New System.Drawing.Point(119, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TOKO BANGUNAN CITRA"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 71)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(433, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'pembelian
        '
        Me.pembelian.Location = New System.Drawing.Point(63, 201)
        Me.pembelian.Name = "pembelian"
        Me.pembelian.Size = New System.Drawing.Size(75, 23)
        Me.pembelian.TabIndex = 2
        Me.pembelian.Text = "Pembelian"
        Me.pembelian.UseVisualStyleBackColor = True
        '
        'kasir
        '
        Me.kasir.Location = New System.Drawing.Point(145, 201)
        Me.kasir.Name = "kasir"
        Me.kasir.Size = New System.Drawing.Size(75, 23)
        Me.kasir.TabIndex = 3
        Me.kasir.Text = "Kasir"
        Me.kasir.UseVisualStyleBackColor = True
        '
        'customer
        '
        Me.customer.Location = New System.Drawing.Point(227, 200)
        Me.customer.Name = "customer"
        Me.customer.Size = New System.Drawing.Size(75, 23)
        Me.customer.TabIndex = 4
        Me.customer.Text = "Customer"
        Me.customer.UseVisualStyleBackColor = True
        '
        'laporan
        '
        Me.laporan.Location = New System.Drawing.Point(309, 199)
        Me.laporan.Name = "laporan"
        Me.laporan.Size = New System.Drawing.Size(75, 23)
        Me.laporan.TabIndex = 5
        Me.laporan.Text = "Laporan"
        Me.laporan.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 269)
        Me.Controls.Add(Me.laporan)
        Me.Controls.Add(Me.customer)
        Me.Controls.Add(Me.kasir)
        Me.Controls.Add(Me.pembelian)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
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
