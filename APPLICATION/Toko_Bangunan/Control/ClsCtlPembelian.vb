Imports System.Data.OleDb
Public Class ClsCtlPembelian
    Dim SQL As String

    Function kodeBaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OleDbDataAdapter("select max(right(kodebeli,3)) from pembelian", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "PB" & Strings.Right("00" & kodeakhir + 1, 3)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function SIMPAN_DATA(ByVal _pbl As ClsEntPembelian, ByVal _item As List(Of ClsEntDetailPembelian)) As OleDbCommand
        Dim kodejual As String
        kodejual = ""
        TUTUPKONEKSI()
        With _pbl
            SQL = "SP_INSERTPEMBELIAN '" _
                & .kode_operator & "','" & Format(.tgl_beli, "yyyy/MM/dd")

            MsgBox(SQL)
            Try
                DTA = New OleDbDataAdapter(SQL, BUKAKONEKSI)
                DTS = New DataSet
                DTA.Fill(DTS, "TABEL_KODE_BELI")
                kodejual = DTS.Tables("TABEL_KODE_BELI").Rows(0)(0).ToString
                ' MsgBox(IDP)'
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

        End With
        TUTUPKONEKSI()
        For i = 0 To _item.Count - 1
            With _item(i)
                SQL = "insert into Detail_pembelian values ('" _
                  & .kode_beli & "','" & .kode_barang _
                  & "'," & .harga_beli & "," & .qty & "," & .sub_total & ")"

                CMD = New OleDbCommand(SQL, BUKAKONEKSI)
                CMD.CommandType = CommandType.Text
                CMD.ExecuteNonQuery()
                CMD = New OleDbCommand("", TUTUPKONEKSI)
                MsgBox(SQL)
            End With
        Next
        Return CMD
    End Function
End Class
