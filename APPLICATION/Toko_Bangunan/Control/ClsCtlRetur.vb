Imports System.Data.OleDb
Imports Toko_Bangunan

Public Class ClsCtlRetur : Implements InfProses

    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Dim Data As New ClsEntRetur
        Data = Ob
        CMD = New OleDbCommand("Insert into RETUR values ('" & Data.NoRtr & "','" & Data.NotaRtr & "','" _
                                   & Data.KdMbr & "','" & Data.JmlRtr & "','" & Data.TglRtr & "','" & Data.KtrgnRtr & "')", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        Dim Data As New ClsEntRetur
        Data = Ob
        CMD = New OleDbCommand("update RETUR set NO_RETUR = '" _
            & Data.NoRtr & "',NO_NOTA='" & Data.NotaRtr & "',KD_MEMBER='" & Data.KdMbr & "',JUMLAH='" & Data.JmlRtr & "',TANGGAL='" & Data.TglRtr & "',KETERANGAN='" _
             & Data.KtrgnRtr & "' where NO_RETUR ='" & Data.NoRtr & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        CMD = New OleDbCommand("delete from RETUR " _
                                          & "where NO_RETUR ='" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function
    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("select * from RETUR", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_RETUR")
            Dim grid As New DataView(DTS.Tables("Tabel_RETUR"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Throw New NotImplementedException()
    End Function

    Function kodebaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OleDbDataAdapter("select Max(right(NO_RETUR,3)) from RETUR", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))

            baru = "R0" & Strings.Right("000" & kodeakhir + 1, 3)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class


