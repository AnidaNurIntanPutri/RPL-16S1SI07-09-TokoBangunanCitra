﻿Public Class ClsEntPembelian
    Private kodebeli As String
    Private kodeoperator As String
    Private kodesup As String
    Private tgl As Date

    Public Property kode_beli() As String
        Get
            Return kodebeli
        End Get
        Set(value As String)
            kodebeli = value
        End Set
    End Property

    Public Property kode_operator() As String
        Get
            Return kodeoperator
        End Get
        Set(value As String)
            kodeoperator = value
        End Set
    End Property


    Public Property kode_sup() As String
        Get
            Return kodesup
        End Get
        Set(value As String)
            kodesup = value
        End Set
    End Property

    Public Property tgl_beli() As Date
        Get
            Return tgl
        End Get
        Set(value As Date)
            tgl = value
        End Set
    End Property

End Class
