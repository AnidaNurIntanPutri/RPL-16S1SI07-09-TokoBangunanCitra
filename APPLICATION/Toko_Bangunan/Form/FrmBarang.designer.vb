<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBarang
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtHgBarang = New System.Windows.Forms.TextBox()
        Me.TxtJmlBarang = New System.Windows.Forms.TextBox()
        Me.TxtNmBarang = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DTGBarang = New System.Windows.Forms.DataGridView()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnUbah = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnKembali = New System.Windows.Forms.Button()
        Me.LblKdBarang = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DTGBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblKdBarang)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtHgBarang)
        Me.GroupBox1.Controls.Add(Me.TxtJmlBarang)
        Me.GroupBox1.Controls.Add(Me.TxtNmBarang)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 18)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(636, 285)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Barang"
        '
        'TxtHgBarang
        '
        Me.TxtHgBarang.Location = New System.Drawing.Point(185, 213)
        Me.TxtHgBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtHgBarang.Name = "TxtHgBarang"
        Me.TxtHgBarang.Size = New System.Drawing.Size(288, 26)
        Me.TxtHgBarang.TabIndex = 6
        '
        'TxtJmlBarang
        '
        Me.TxtJmlBarang.Location = New System.Drawing.Point(185, 163)
        Me.TxtJmlBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtJmlBarang.Name = "TxtJmlBarang"
        Me.TxtJmlBarang.Size = New System.Drawing.Size(288, 26)
        Me.TxtJmlBarang.TabIndex = 5
        '
        'TxtNmBarang
        '
        Me.TxtNmBarang.Location = New System.Drawing.Point(185, 112)
        Me.TxtNmBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtNmBarang.Name = "TxtNmBarang"
        Me.TxtNmBarang.Size = New System.Drawing.Size(288, 26)
        Me.TxtNmBarang.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 218)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Harga Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 167)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jumlah Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 116)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Barang"
        '
        'DTGBarang
        '
        Me.DTGBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTGBarang.Location = New System.Drawing.Point(32, 349)
        Me.DTGBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DTGBarang.Name = "DTGBarang"
        Me.DTGBarang.Size = New System.Drawing.Size(636, 231)
        Me.DTGBarang.TabIndex = 2
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(32, 611)
        Me.BtnSimpan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(112, 35)
        Me.BtnSimpan.TabIndex = 3
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'BtnUbah
        '
        Me.BtnUbah.Location = New System.Drawing.Point(154, 611)
        Me.BtnUbah.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Size = New System.Drawing.Size(112, 35)
        Me.BtnUbah.TabIndex = 4
        Me.BtnUbah.Text = "Ubah"
        Me.BtnUbah.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(278, 611)
        Me.BtnHapus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(112, 35)
        Me.BtnHapus.TabIndex = 5
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnKembali
        '
        Me.BtnKembali.Location = New System.Drawing.Point(519, 611)
        Me.BtnKembali.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnKembali.Name = "BtnKembali"
        Me.BtnKembali.Size = New System.Drawing.Size(112, 35)
        Me.BtnKembali.TabIndex = 6
        Me.BtnKembali.Text = "Kembali"
        Me.BtnKembali.UseVisualStyleBackColor = True
        '
        'LblKdBarang
        '
        Me.LblKdBarang.AutoSize = True
        Me.LblKdBarang.Location = New System.Drawing.Point(181, 57)
        Me.LblKdBarang.Name = "LblKdBarang"
        Me.LblKdBarang.Size = New System.Drawing.Size(101, 20)
        Me.LblKdBarang.TabIndex = 10
        Me.LblKdBarang.Text = "LblKdBarang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 57)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Kode Barang"
        '
        'FrmBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 665)
        Me.Controls.Add(Me.BtnKembali)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnUbah)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.DTGBarang)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmBarang"
        Me.Text = "FormBarang"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DTGBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtHgBarang As TextBox
    Friend WithEvents TxtJmlBarang As TextBox
    Friend WithEvents TxtNmBarang As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DTGBarang As DataGridView
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents BtnUbah As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnKembali As Button
    Friend WithEvents LblKdBarang As Label
    Friend WithEvents Label1 As Label
End Class
