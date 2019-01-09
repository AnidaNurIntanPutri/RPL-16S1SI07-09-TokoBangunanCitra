Imports System.Data.OleDb 'diimport agar oledb terbaca'
Public Class ClsCtlKredit : Implements InfProses
    'function untuk cari data berdasarkan nama'
    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Try
            DTA = New OleDbDataAdapter("Select * from kredit where no_kredit " & "like '%" & kunci & "%'", BUKAKONEKSI)
            DTS = New DataSet
            DTA.Fill(DTS, "Cari_Kredit")
            Dim grid As New DataView(DTS.Tables("Cari_Kredit"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    'function untuk delete data'
    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        CMD = New OleDbCommand("delete from kredit " & "where no_kredit='" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    'function untuk insert data'
    'insert into tabelnya apa values sesuaikan dg atribut yang ada didatabase kredit'
    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Dim data As New ClsEntKredit 'mengacu pada kelas entitas kredit'
        data = Ob
        CMD = New OleDbCommand("insert into kredit values('" & data.NO_KREDIT & "','" & data.NO_NOTA & "','" _
                               & data.TGL_KREDIT & ",'" & data.TGL_LUNAS & ",'" & data.JUMLAH_BARANG & "','" & data.LAMA_KREDIT & "')", BUKAKONEKSI)

        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    'function untuk membuat no kredit secara otomatis'
    ' nokredit BARU K0001'
    Function kodeBaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OleDbDataAdapter("select max(right(NO_KREDIT,4)) from kredit", BUKAKONEKSI) 'diambil 3 dari kanan berarti 001'
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "K" & Strings.Right("000" & kodeakhir + 1, 4) 'K' lalu mengalami penambahan sebanyak 1  sehingga 001,002, dst
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    ' Function kodeBaru() As String
    ' 'Dim baru As String
    ' Dim kodeakhir As Integer
    '  Try
    '       DTA = New OleDbDataAdapter("select max(right(NO_NOTA,4)) from penjualan", BUKAKONEKSI) 'diambil 3 dari kanan berarti 001'
    '      DTS = New DataSet()
    '      DTA.Fill(DTS, "max_kode")
    '      kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
    '      baru = "N" & Strings.Right("000" & kodeakhir + 1, 4) 'N' lalu mengalami penambahan sebanyak 1  sehingga 001,002, dst
    '      Return baru
    '  Catch ex As Exception
    '     Throw New Exception(ex.Message)
    'End Try
    '  End Function

    'function untuk menampilkan data kredit'
    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("Select * from kredit", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Kredit")
            Dim grid As New DataView(DTS.Tables("Tabel_Kredit"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    'function untuk mengecek berapa banyak primary key barang yaitu no kredit apakah primary key tsb terdapat pada tabel yg berelasi yaitu tabel penjualan
    'kalau data ada brati tdk bisa dihapus karena tabel kredit dan penj berelasi, tetapi kalau primary key blm ada
    'pada tabel penjualan maka bisa dihapus'
    Function cekKreditDireferensi(kunci As String) As Boolean
        Dim cek As Boolean
        cek = False
        Try
            DTA = New OleDbDataAdapter("Select count(no_kredit) from penjualan " _
                                        & "where no_kredit='" & kunci & "'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "cek")
            If DTS.Tables("cek").Rows(0)(0).ToString > 0 Then cek = True
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return cek
    End Function

    'function untuk mengubah data kredit'
    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        Dim data As New ClsEntKredit
        data = Ob
        CMD = New OleDbCommand("update barang set no_nota='" _
                               & data.NO_NOTA & "',tgl_kredit='" & data.TGL_KREDIT _
                               & "',tgl_lunas =" & data.TGL_LUNAS _
                               & ", jumlah_brg = " & data.JUMLAH_BARANG _
                               & ", lama_kredit = " & data.LAMA_KREDIT _
                               & " where no_kredit='" & data.NO_KREDIT & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function
End Class
