Imports System.Data.OleDb
Imports Toko_Bangunan
Public Class ClsCtlMerchandise : Implements InfProses
    'e0001'
    Function kodeBaru() As String
        Dim baru As String
        Dim kodeakhir As String
        Try
            DTA = New OleDbDataAdapter("select max(right(KD_merchandise,3)) from MERCHANDISE", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "E0" & Strings.Right("000" & kodeakhir + 1, 3)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Dim Data As New ClsEntMerchandise
        Data = Ob
        CMD = New OleDbCommand("Insert into MERCHANDISE values ('" & Data.kd_merchandise & "','" & Data.kd_Member & "','" _
                                   & Data.jenis_merchandise & "','" & Data.keterangan & "')", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Throw New NotImplementedException()
    End Function

    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        Dim Data As New ClsEntMerchandise
        Data = Ob
        CMD = New OleDbCommand("update MERCHANDISE set KD_Merchandise = '" _
            & Data.kd_merchandise & "',Kd_member='" & Data.kd_Member & "',jenis='" & Data.jenis_merchandise & "',Keterangan='" & Data.keterangan & "''" _
            & "' where KD_Merchandise ='" & Data.kd_merchandise & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        CMD = New OleDbCommand("delete from MERCHANDISE " _
                                      & "where KD_Merchandise='" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("Select * from MERCHANDISE", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_MERCHANDISE")
            Dim grid As New DataView(DTS.Tables("Tabel_MERCHANDISE"))

            Return grid

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

End Class
