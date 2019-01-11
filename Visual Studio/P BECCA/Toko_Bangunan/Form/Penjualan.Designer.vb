<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.textBox5 = New System.Windows.Forms.TextBox()
        Me.textBox4 = New System.Windows.Forms.TextBox()
        Me.textBox3 = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.caribtn = New System.Windows.Forms.Button()
        Me.cari = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.hapus = New System.Windows.Forms.Button()
        Me.ubah = New System.Windows.Forms.Button()
        Me.simpan = New System.Windows.Forms.Button()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.jumlah = New System.Windows.Forms.Label()
        Me.kodebarang = New System.Windows.Forms.Label()
        Me.kasir = New System.Windows.Forms.Label()
        Me.nonota = New System.Windows.Forms.Label()
        Me.kembali = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PenjualanDataSet = New Laporan1.penjualanDataSet()
        Me.PenjualanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PenjualanTableAdapter = New Laporan1.penjualanDataSetTableAdapters.PenjualanTableAdapter()
        Me.KodeBarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahBarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PenjualanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PenjualanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(386, 12)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(114, 101)
        Me.pictureBox1.TabIndex = 62
        Me.pictureBox1.TabStop = False
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(127, 424)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(100, 23)
        Me.button2.TabIndex = 61
        Me.button2.Text = "PRINT"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(12, 424)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(97, 23)
        Me.button1.TabIndex = 60
        Me.button1.Text = "KREDIT"
        Me.button1.UseVisualStyleBackColor = True
        '
        'textBox5
        '
        Me.textBox5.Location = New System.Drawing.Point(341, 353)
        Me.textBox5.Name = "textBox5"
        Me.textBox5.Size = New System.Drawing.Size(140, 20)
        Me.textBox5.TabIndex = 59
        '
        'textBox4
        '
        Me.textBox4.Location = New System.Drawing.Point(341, 310)
        Me.textBox4.Name = "textBox4"
        Me.textBox4.Size = New System.Drawing.Size(140, 20)
        Me.textBox4.TabIndex = 58
        '
        'textBox3
        '
        Me.textBox3.Location = New System.Drawing.Point(341, 267)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(140, 20)
        Me.textBox3.TabIndex = 57
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(338, 337)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(68, 13)
        Me.label4.TabIndex = 56
        Me.label4.Text = "KEMBALIAN"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(338, 295)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(43, 13)
        Me.label3.TabIndex = 55
        Me.label3.Text = "BAYAR"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(338, 252)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(42, 13)
        Me.label2.TabIndex = 54
        Me.label2.Text = "TOTAL"
        '
        'caribtn
        '
        Me.caribtn.Location = New System.Drawing.Point(230, 253)
        Me.caribtn.Name = "caribtn"
        Me.caribtn.Size = New System.Drawing.Size(75, 23)
        Me.caribtn.TabIndex = 53
        Me.caribtn.Text = "CARI"
        Me.caribtn.UseVisualStyleBackColor = True
        '
        'cari
        '
        Me.cari.Location = New System.Drawing.Point(9, 255)
        Me.cari.Name = "cari"
        Me.cari.Size = New System.Drawing.Size(215, 20)
        Me.cari.TabIndex = 52
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(6, 239)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(80, 13)
        Me.label1.TabIndex = 51
        Me.label1.Text = "CARI BARANG"
        '
        'hapus
        '
        Me.hapus.Location = New System.Drawing.Point(305, 80)
        Me.hapus.Name = "hapus"
        Me.hapus.Size = New System.Drawing.Size(75, 23)
        Me.hapus.TabIndex = 50
        Me.hapus.Text = "HAPUS"
        Me.hapus.UseVisualStyleBackColor = True
        '
        'ubah
        '
        Me.ubah.Location = New System.Drawing.Point(305, 51)
        Me.ubah.Name = "ubah"
        Me.ubah.Size = New System.Drawing.Size(75, 23)
        Me.ubah.TabIndex = 49
        Me.ubah.Text = "UBAH"
        Me.ubah.UseVisualStyleBackColor = True
        '
        'simpan
        '
        Me.simpan.Location = New System.Drawing.Point(305, 22)
        Me.simpan.Name = "simpan"
        Me.simpan.Size = New System.Drawing.Size(75, 23)
        Me.simpan.TabIndex = 48
        Me.simpan.Text = "SIMPAN"
        Me.simpan.UseVisualStyleBackColor = True
        '
        'textBox2
        '
        Me.textBox2.Location = New System.Drawing.Point(127, 82)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(100, 20)
        Me.textBox2.TabIndex = 47
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(9, 82)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(100, 20)
        Me.textBox1.TabIndex = 46
        '
        'jumlah
        '
        Me.jumlah.AutoSize = True
        Me.jumlah.Location = New System.Drawing.Point(124, 65)
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Size = New System.Drawing.Size(40, 13)
        Me.jumlah.TabIndex = 45
        Me.jumlah.Text = "Jumlah"
        '
        'kodebarang
        '
        Me.kodebarang.AutoSize = True
        Me.kodebarang.Location = New System.Drawing.Point(6, 65)
        Me.kodebarang.Name = "kodebarang"
        Me.kodebarang.Size = New System.Drawing.Size(69, 13)
        Me.kodebarang.TabIndex = 44
        Me.kodebarang.Text = "Kode Barang"
        '
        'kasir
        '
        Me.kasir.AutoSize = True
        Me.kasir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kasir.Location = New System.Drawing.Point(124, 9)
        Me.kasir.Name = "kasir"
        Me.kasir.Size = New System.Drawing.Size(35, 13)
        Me.kasir.TabIndex = 43
        Me.kasir.Text = "Kasir"
        '
        'nonota
        '
        Me.nonota.AutoSize = True
        Me.nonota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nonota.Location = New System.Drawing.Point(6, 9)
        Me.nonota.Name = "nonota"
        Me.nonota.Size = New System.Drawing.Size(54, 13)
        Me.nonota.TabIndex = 42
        Me.nonota.Text = "No Nota"
        '
        'kembali
        '
        Me.kembali.Location = New System.Drawing.Point(379, 424)
        Me.kembali.Name = "kembali"
        Me.kembali.Size = New System.Drawing.Size(100, 23)
        Me.kembali.TabIndex = 63
        Me.kembali.Text = "KEMBALI"
        Me.kembali.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeBarangDataGridViewTextBoxColumn, Me.JumlahBarangDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PenjualanBindingSource
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGridView1.Enabled = False
        Me.DataGridView1.Location = New System.Drawing.Point(9, 108)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(372, 127)
        Me.DataGridView1.TabIndex = 64
        '
        'PenjualanDataSet
        '
        Me.PenjualanDataSet.DataSetName = "penjualanDataSet"
        Me.PenjualanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PenjualanBindingSource
        '
        Me.PenjualanBindingSource.DataMember = "Penjualan"
        Me.PenjualanBindingSource.DataSource = Me.PenjualanDataSet
        '
        'PenjualanTableAdapter
        '
        Me.PenjualanTableAdapter.ClearBeforeFill = True
        '
        'KodeBarangDataGridViewTextBoxColumn
        '
        Me.KodeBarangDataGridViewTextBoxColumn.DataPropertyName = "KodeBarang"
        Me.KodeBarangDataGridViewTextBoxColumn.HeaderText = "KodeBarang"
        Me.KodeBarangDataGridViewTextBoxColumn.Name = "KodeBarangDataGridViewTextBoxColumn"
        Me.KodeBarangDataGridViewTextBoxColumn.Width = 150
        '
        'JumlahBarangDataGridViewTextBoxColumn
        '
        Me.JumlahBarangDataGridViewTextBoxColumn.DataPropertyName = "JumlahBarang"
        Me.JumlahBarangDataGridViewTextBoxColumn.HeaderText = "JumlahBarang"
        Me.JumlahBarangDataGridViewTextBoxColumn.Name = "JumlahBarangDataGridViewTextBoxColumn"
        Me.JumlahBarangDataGridViewTextBoxColumn.Width = 180
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 454)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.kembali)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.textBox5)
        Me.Controls.Add(Me.textBox4)
        Me.Controls.Add(Me.textBox3)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.caribtn)
        Me.Controls.Add(Me.cari)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.hapus)
        Me.Controls.Add(Me.ubah)
        Me.Controls.Add(Me.simpan)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.jumlah)
        Me.Controls.Add(Me.kodebarang)
        Me.Controls.Add(Me.kasir)
        Me.Controls.Add(Me.nonota)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PenjualanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PenjualanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents textBox5 As TextBox
    Private WithEvents textBox4 As TextBox
    Private WithEvents textBox3 As TextBox
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents caribtn As Button
    Private WithEvents cari As TextBox
    Private WithEvents label1 As Label
    Private WithEvents hapus As Button
    Private WithEvents ubah As Button
    Private WithEvents simpan As Button
    Private WithEvents textBox2 As TextBox
    Private WithEvents textBox1 As TextBox
    Private WithEvents jumlah As Label
    Private WithEvents kodebarang As Label
    Private WithEvents kasir As Label
    Private WithEvents nonota As Label
    Private WithEvents kembali As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PenjualanDataSet As penjualanDataSet
    Friend WithEvents PenjualanBindingSource As BindingSource
    Friend WithEvents PenjualanTableAdapter As penjualanDataSetTableAdapters.PenjualanTableAdapter
    Friend WithEvents KodeBarangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JumlahBarangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
