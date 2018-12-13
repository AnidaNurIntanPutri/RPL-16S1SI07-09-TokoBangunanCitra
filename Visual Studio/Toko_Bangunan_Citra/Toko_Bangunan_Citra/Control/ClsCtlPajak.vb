Imports System.Data.OleDb
Imports Toko_Bangunan_Citra


Public Class ClsCtlPajak
    Function kodebaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OleDbDataAdapter("select Max(right(no_delivery,3)) from Delivery", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "" & Strings.Right("000" & kodeakhir + 1, 3)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function


    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Dim Data As New ClsEntPajak
        Data = Ob
        CMD = New OleDbCommand("Insert into delivery values ('" & Data.no_delivery & "','" & Data.id_kurir & "','" _
                               & Data.no_nota & "','" & Data.alamat_kirim & "','" _
                               & Data.tanggal_kirim & "','" & Data.jam_kirim & "')", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        Dim Data As New ClsEntDelivery
        Data = Ob
        CMD = New OleDbCommand("update delivery set alamat = '" _
        & Data.alamat_kirim & "','" & Data.tanggal_kirim & "','" & Data.jam_kirim & "','" _
        & "' where no_delivery ='" & Data.no_delivery & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        CMD = New OleDbCommand("delete from delivery " _
                                  & "where no_delivery ='" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("Select * from delivery", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_delivery")
            Dim grid As New DataView(DTS.Tables("Tabel_delivery"))

            Return grid

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Try
            DTA = New OleDbDataAdapter("Select * from delivery where no_delivery " _
                                        & "like '%" & kunci & "%'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Cari_delivery")
            Dim grid As New DataView(DTS.Tables("Cari_delivery"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Function cekDeliveryDireferensi(kunci As String) As Boolean
        Dim cek As Boolean
        cek = True
        Try
            DTA = New OleDbDataAdapter("Select count(no_delivery) from delivery " _
                                       & "where no_delivery = '" & kunci & "'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "cek")
            If DTS.Tables("cek").Rows(0)(0).ToString > 0 Then cek = False
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return cek
    End Function

End Class
