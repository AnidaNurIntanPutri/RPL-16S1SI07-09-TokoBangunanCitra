Public Class ClsCtlPembelian
    Public Class ClsCtlBarang : Implements InfProses

        Dim SQL As String

        'function untuk cari data berdasarkan nama barang'
        Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
            Try
                DTA = New OleDbDataAdapter("Select * from barang where nama_barang " & "like '%" & kunci & "%'", BUKAKONEKSI)
                DTS = New DataSet
                DTA.Fill(DTS, "Cari_Barang")
                Dim grid As New DataView(DTS.Tables("Cari_Barang"))
                Return grid
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        'function untuk delete data'
        Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
            CMD = New OleDbCommand("delete from barang " & "where kode_barang='" & kunci & "'", BUKAKONEKSI)
            CMD.CommandType = CommandType.Text
            CMD.ExecuteNonQuery()
            CMD = New OleDbCommand("", TUTUPKONEKSI)
            Return CMD
        End Function

        'function untuk insert data'
        'insert into tabelnya apa values sesuaikan dg atribut yang ada didatabase barang'
        Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
            Dim data As New ClsEntBarang 'mengacu pada kelas entitas barang'
            data = Ob
            CMD = New OleDbCommand("insert into barang values('" & data.kode_barang & "','" & data.kode_jenis & "','" _
                                   & data.nama_barang & "'," & data.harga & ", " & data.qty & ")", BUKAKONEKSI)

            CMD.CommandType = CommandType.Text
            CMD.ExecuteNonQuery()
            CMD = New OleDbCommand("", TUTUPKONEKSI)
            Return CMD
        End Function

        'function untuk membuat kode barang secara otomatis'
        ' kode barang BR001'
        Function kodeBaru() As String
            Dim baru As String
            Dim kodeakhir As Integer
            Try
                DTA = New OleDbDataAdapter("select max(right(kode_barang,3)) from barang", BUKAKONEKSI) 'diambil 3 dari kanan berarti 001'
                DTS = New DataSet()
                DTA.Fill(DTS, "max_kode")
                kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
                baru = "BR" & Strings.Right("00" & kodeakhir + 1, 3) 'BR' lalu mengalami penambahan sebanyak 1  sehingga 001,002, dst
                Return baru
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function


        'function untuk menampilkan data barang'
        Public Function tampilData() As DataView Implements InfProses.tampilData
            Try
                DTA = New OleDbDataAdapter("Select * from barang", BUKAKONEKSI)
                DTS = New DataSet()
                DTA.Fill(DTS, "Tabel_Barang")
                Dim grid As New DataView(DTS.Tables("Tabel_Barang"))
                Return grid
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

        'function untuk mengecek berapa banyak primary key barang yaitu kdoe barang apakah primary key tsb terdapat pada tabel yg berelasi yaitu tabel penjualan
        'kalau data ada brati tdk bisa dihapus karena tabel barang dan penj berelasi, tetapi kalau primary key blm ada
        'pada tabel penjualan maka bisa dihapus'
        Function cekBarangDireferensi(kunci As String) As Boolean
            Dim cek As Boolean
            cek = False
            Try
                DTA = New OleDbDataAdapter("Select count(kode_barang) from penjualan " _
                                               & "where kode_barang='" & kunci & "'", BUKAKONEKSI)
                DTS = New DataSet()
                DTA.Fill(DTS, "cek")
                If DTS.Tables("cek").Rows(0)(0).ToString > 0 Then cek = True
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
            Return cek
        End Function

        'function untuk mengubah data barang'
        Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
            Dim data As New ClsEntBarang
            data = Ob
            CMD = New OleDbCommand("update barang set kode_jenis='" _
                                   & data.kode_jenis & "',nama_barang='" & data.nama_barang _
                                   & "',harga =" & data.harga _
                                   & ", qty = " & data.harga _
                                   & " where kode_barang='" & data.kode_barang & "'", BUKAKONEKSI)
            CMD.CommandType = CommandType.Text
            CMD.ExecuteNonQuery()
            CMD = New OleDbCommand("", TUTUPKONEKSI)
            Return CMD
        End Function
    End Class
