Imports System.Data.OleDb
Public Class FmKredit
    Dim modeProses As Integer
    Dim baris As Integer

    'untuk mengatur pengaktifan button'
    Private Sub AturButton(st As Boolean)
        btnTambah.Enabled = st
        btnUbah.Enabled = st
        btnSimpan.Enabled = Not st
        btnHapus.Enabled = st
        btnKembali.Enabled = st
    End Sub
 
    'untuk pengisian pada datagrid sehingga data yang diinputkan dari textbox maupun combobox
    'akan menempatkan pada cell2 yang sesuai' 
    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGKredit.Rows(br)
                txtKredit.Text = .Cells(0).Value.ToString
                txtNota.Text = .Cells(1).Value.ToString
                DTTglKredit.Text = .Cells(2).Value.ToString
                DTTglLunas.Text = .Cells(3).Value.ToString
                txtJumlah.Text = .Cells(4).Value.ToString
                txtLama.Text = .Cells(5).Value.ToString
            End With
        End If
    End Sub

    'untuk menampilkan data didata grid KREDIT'
    Private Sub RefreshGrid()
        DTGrid = KontrolKredit.tampilData.ToTable
        DGKredit.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGKredit.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGKredit.CurrentCell = DGKredit.Item(1, baris)
            IsiBox(baris)
        End If
    End Sub

    'untuk mencari data kredit'
    Private Sub TampilCari(kunci As String)
        DTGrid = KontrolKredit.cariData(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGKredit.DataSource = DTGrid
            DGKredit.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGKredit.CurrentCell = DGKredit.Item(1, baris)
            IsiBox(baris)
        Else
            MsgBox("Data tidak ditemukan")
            RefreshGrid()
        End If
    End Sub

    'event ketika button tambah diklik maka dia akan menuju modeproses =1 (insert data)'
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        AturButton(False)
        modeProses = 1

        txtKredit.Text = ""
        txtNota.Text = ""
        DTTglKredit.Text = ""
        DTTglLunas.Text = ""
        txtJumlah.Text = ""
        txtLama.Text = ""

        txtKredit.Text = KontrolKredit.kodeBaru() 'memanggil function no kredit agar otomatis'
        '  txtNota.Text = KontrolPenjualan.kodeBaru()
    End Sub

    'event ketika button ubah diklik maka dia akan menuju modeproses =2 (update data)'
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        AturButton(False)
        txtKredit.Focus()
        modeProses = 2 '
    End Sub

    'event ketika button batal di klik'
    'Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
    '   RefreshGrid()
    '  AturButton(True)
    ' modeProses = 0
    ' End Sub

    'event ketika datagrid diklik cellnya'
    Private Sub DGKredit_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGKredit.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGKredit.Rows(baris).Selected = True
            IsiBox(baris)
        End If
    End Sub

    'event ketika button simpan diklik'
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        With EntitasKredit
            .NO_KREDIT = txtKredit.Text
            .NO_NOTA = txtNota.Text
            .TGL_KREDIT = DTTglKredit.Text
            .TGL_LUNAS = DTTglLunas.Text
            .JUMLAH_BARANG = txtJumlah.Text
            .LAMA_KREDIT = txtLama.Text
        End With

        If modeProses = 1 Then
            KontrolKredit.InsertData(EntitasKredit)
        ElseIf modeProses = 2 Then
            KontrolKredit.updateData(EntitasKredit)
        End If
        MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "Info")
        RefreshGrid()
    End Sub

    'event ketika btn hapus di klik'
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim status_referensi As Boolean
        status_referensi = KontrolKredit.cekKreditDireferensi(txtKredit.Text)
        If status_referensi Then
            MsgBox("Data masih digunakan, tidak boleh dihapus", MsgBoxStyle.Exclamation, "peringatan")
            Exit Sub
        End If

        If MsgBox("Apakah Anda yakin akan menghapus " & txtKredit.Text & "-" & txtNota.Text & "?",
                  MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfrimasi") = MsgBoxResult.Yes Then
            KontrolKredit.deleteData(txtKredit.Text)
        End If
        RefreshGrid()
    End Sub

    Private Sub FmKredit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call RefreshGrid()
        txtKredit.Enabled = False
        'MdiParent = FmMenuCS
        'Call TampilKredit()
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        FmPenjualan.Show()
    End Sub
End Class