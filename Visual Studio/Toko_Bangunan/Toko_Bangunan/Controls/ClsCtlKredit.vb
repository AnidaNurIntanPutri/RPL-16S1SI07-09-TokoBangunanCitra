Public Class ClsCtlKredit
    Public Class ClsCtlKredit : Implements InfProses

        'function untuk delete data'
        Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
            CMD = New OleDbCommand("delete from kredit " & "where no_kredit='" & kunci & "'", BUKAKONEKSI)
            CMD.CommandType = CommandType.Text
            CMD.ExecuteNonQuery()
            CMD = New OleDbCommand("", TUTUPKONEKSI)
            Return CMD
        End Function


        Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
            Dim data As New ClsEntKredit
            data = Ob
            CMD = New OleDbCommand("insert into kredit values('" & data.no_kredit & "','" & data.no_nota & "','" _
                                  & data.tgl_lunas & ", " & data.alamat & ", " & data.no_ktp & ")", BUKAKONEKSI)

            CMD.CommandType = CommandType.Text
            CMD.ExecuteNonQuery()
            CMD = New OleDbCommand("", TUTUPKONEKSI)
            Return CMD
        End Function

        Function kodeBaru() As String
            Dim baru As String
            Dim kodeakhir As Integer
            Try
                DTA = New OleDbDataAdapter("select max(right(no_kredit ,3)) from kredit", BUKAKONEKSI) 'diambil 3 dari kanan berarti 001'
                DTS = New DataSet()
                DTA.Fill(DTS, "max_kode")
                kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
                baru = "K" & Strings.Right("00" & kodeakhir + 1, 3) 'K' lalu mengalami penambahan sebanyak 1  sehingga 001,002, dst
                Return baru
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function


        'function untuk menampilkan data KREDIT'
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

        'function untuk mengubah data barang'
        Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
            Dim data As New ClsEntKredit
            data = Ob
            CMD = New OleDbCommand("update kredit set no_nota='" _
                                   & data.no_nota & "',tgl_lunas='" & data.tgl_lunas _
                                   & "',alamat =" & data.alamat _
                                   & ", no_ktp = " & data.no_ktp _
                                   & " where no_kredit='" & data.no_kredit & "'", BUKAKONEKSI)
            CMD.CommandType = CommandType.Text
            CMD.ExecuteNonQuery()
            CMD = New OleDbCommand("", TUTUPKONEKSI)
            Return CMD
        End Function
    End Class
