﻿Imports System.Data.OleDb
Imports Toko_Bangunan
Public Class ClsCtlMerchandise : Implements InfProses
    'e0001'
    Function kodeBaru() As String
        Dim baru As String
        Dim kodeakhir As String

        Try
            DTA = New OleDbDataAdapter("select max(right(kd_hadiah,4)) from merchandise", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "E" & Strings.Right("000" & kodeakhir + 1, 4)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Dim Data As New ClsEntMerchandise
        Data = Ob
        CMD = New OleDbCommand("Insert into MERCHANDISE values ('" & Data.kd_Hadiah & "','" & Data.kategori_Hadiah & "','" _
                                   & Data.kode_member & "','" & Data.jenis_hadiah & "')", BUKAKONEKSI)
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
        CMD = New OleDbCommand("update merchandise set KD_HADIAH = '" _
            & Data.kd_Hadiah & "','" & Data.kd_Hadiah & "','" & Data.kategori_Hadiah & "','" & Data.kode_member & "','" & Data.jenis_hadiah & "','" _
            & "' where KD_HADIAH ='" & Data.kd_Hadiah & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        CMD = New OleDbCommand("delete from MERCHANDISE " _
                                      & "where KD_HADIAH ='" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("Select * from MERCHANDISE", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_merchandise")
            Dim grid As New DataView(DTS.Tables("Tabel_merchandise"))

            Return grid

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Function cekMerchandiseDireferensi(kunci As String) As Boolean
        Dim cek As Boolean
        cek = False
        Try
            DTA = New OleDbDataAdapter("Select count(KD_HADIAH) From Merchandise " _
                & "where KD_HADIAH=" & kunci & "'", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "cek")
            If DTS.Tables("cek").Rows(0)(0).ToString > 0 Then cek = True
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return cek
    End Function
End Class
