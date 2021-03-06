﻿Imports System.Data.OleDb
Imports Toko_Bangunan

Public Class ClsCtlPajak : Implements InfProses


    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Dim Data As New ClsEntPajak
        Data = Ob
        CMD = New OleDbCommand("Insert into PAJAK values ('" & Data.noP & "','" & Data.jml & "','" _
                                   & Data.tgl & "')", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
            CMD = New OleDbCommand("", TUTUPKONEKSI)
            Return CMD
        End Function

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Throw New NotImplementedException()
    End Function

    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        Dim Data As New ClsEntPajak
        Data = Ob
        CMD = New OleDbCommand("update pajak set NO_PAJAK = '" _
            & Data.noP & "', JUMLAH_PAJAK='" & Data.jml & "', TGL_BAYAR='" & Data.tgl & "' where NO_PAJAK ='" & Data.noP & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
            CMD.ExecuteNonQuery()
            CMD = New OleDbCommand("", TUTUPKONEKSI)
            Return CMD
        End Function

        Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        CMD = New OleDbCommand("delete from PAJAK " _
                                      & "where NO_PAJAK ='" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
            CMD.ExecuteNonQuery()
            CMD = New OleDbCommand("", TUTUPKONEKSI)
            Return CMD
        End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("Select * from PAJAK", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_pajak")
            Dim grid As New DataView(DTS.Tables("Tabel_pajak"))

            Return grid

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

End Class
