Imports System.Data.OleDb

Public Class FmPembelian
    Dim baris As Integer

#Region "SUB"
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Handles Timer1.Tick
        Dim namaHari As String()
        namaHari = New String() {" \M\i\n\g\g\u", "\S\e\n\i\n", "\S\e\l\a\s\a", "\R\a\b\u", "\K\a\m\i\s", "\J\u\m\a\t", "\S\a\b\t\u"}
        lblTglBeli.Text = Format(Now, namaHari(Now.DayOfWeek()) & " yyyy/MM/dd ")
    End Sub

    Function kodeBaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OleDbDataAdapter("select max(right(KD_BELI,3)) from Pembelian", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "PB" & Strings.Right("00" & kodeakhir + 1, 3)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Sub Buattabel()
        LVBeli.Columns.Add("kodebarang", 120, HorizontalAlignment.Center)
        LVBeli.Columns.Add("Namabarang", 180, HorizontalAlignment.Center)
        LVBeli.Columns.Add("Hargabarang", 120, HorizontalAlignment.Center)
        LVBeli.Columns.Add("Qty", 120, HorizontalAlignment.Center)
        LVBeli.Columns.Add("Sub Total", 120, HorizontalAlignment.Center)


        LVBeli.View = View.Details
        LVBeli.GridLines = True
        LVBeli.FullRowSelect = True
    End Sub

    Sub JumlahLVBeli()
        Dim jumbarang As Integer = 0
        Dim jumHarga As Integer = 0
        Dim total As Double = 0
        For baris As Integer = 0 To LVBeli.Items.Count - 1
            jumbarang = jumbarang + LVBeli.Items(baris).SubItems(3).Text
            total = total + (txtHarga.Text * txtQty.Text)
            jumHarga = jumHarga + LVBeli.Items(baris).SubItems(4).Text

        Next
        lblJumlahBarang.Text = jumHarga
        lblJumlahBarang.Text = jumbarang
    End Sub
    Private Sub FmPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Buattabel()
        Call Bersih()

        lblKdBeli.Text = kodeBaru()

        lblTglBeli.Text = Today

        ' total = 0
        'MdiParent = FmMenuPemilik
    End Sub

    Sub Bersih()
        LVBeli.Items.Clear()
        lblJumlahBarang.Text = "0"
        lblTotal.Text = "0"
        txtBayar.Text = "0"
    End Sub

    Sub Bersihdata()
        txtKdBarang.Text = ""
        txtNama.Text = ""
        txtHarga.Text = ""
        txtQty.Text = ""

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim strBeli(4) As String

        strBeli(0) = txtKdBarang.Text
        strBeli(1) = txtNama.Text
        strBeli(2) = txtHarga.Text
        strBeli(3) = txtQty.Text
        strBeli(4) = txtHarga.Text * txtQty.Text

        LVBeli.Items.Add(New ListViewItem(strBeli))
        Call JumlahLVBeli()
    End Sub


    'Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

    'If MsgBox("Apakah Anda yakin akan menghapus " & lblKdBeli.Text & "-" & txtNama.Text & "?",
    '         MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfrimasi") = MsgBoxResult.Yes Then
    '   KontrolPembelian.deleteData(lblKdBeli.Text)
    'End If
    ' RefreshGrid()
    '  End Sub

    ' Private Sub refreshGrid()
    '   DTGrid = KontrolPembelian.tampilData.ToTable
    ' LVBeli.DataSource = DTGrid
    '
    'If DTGrid.Rows.Count > 0 Then
    '   baris = DTGrid.Rows.Count - 1
    '  LVBeli.Rows(DTGrid.Rows.Count - 1).Selected = True
    '      LVBeli.CurrentCell = DGKa.Item(1, baris)
    '     isiBox(baris)
    '   End If
    ' End Sub

    Private Sub btnBaru_Click(sender As Object, e As EventArgs) Handles btnBaru.Click
        Call Bersih()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim lsdetail As New List(Of ClsEntDetailPembelian)()
        If LVBeli.Items.Count = 0 Then
            MsgBox("Masukkan Menu yang akan dipesan terlebih dahulu")
            Exit Sub
        End If
        With EntitasPembelian
            .tgl_beli = Format(Now, " yyyy/MM/dd ")
            '   .total = lblTotal.Text
        End With

        For i = 0 To LVBeli.Items.Count - 1
            '  LVJual.Items(i).Selected = True
            EntitasDetailPembelian = New ClsEntDetailPembelian
            With LVBeli.Items(i)
                EntitasDetailPembelian.kode_barang = .SubItems(0).Text
                EntitasDetailPembelian.harga_beli = .SubItems(2).Text
                'EntitasDetailPembelian.jumlah = .SubItems(3).Text
                EntitasDetailPembelian.sub_total = .SubItems(4).Text
            End With
            ' MsgBox(i & " " & EntitasDetailPenjualan.kode_barang)
            lsdetail.Add(EntitasDetailPembelian)
        Next i
        For I = 0 To lsdetail.Count - 1
            MsgBox(lsdetail(I).kode_barang & " " & lsdetail(I).harga_beli)
        Next
        ' KontrolPenjualan.SIMPAN_DATA(EntitasPembelian, lsdetail)
        Bersih()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
        FmMenuPemilik.Show()
    End Sub
#End Region
End Class