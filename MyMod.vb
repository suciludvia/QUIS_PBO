Imports System.Data.OleDb
Imports System.Security.Cryptography
Module MyMod
    Public mycommand As New System.Data.OleDb.OleDbCommand
    Public myadapter As New System.Data.OleDb.OleDbDataAdapter
    Public mydata As New DataTable
    Public DR As System.Data.OleDb.OleDbDataReader
    Public SQL As String
    Public conn As New OleDbConnection
    Public cn As New Connection

    'Tabel User
    '--------------------------------
    Public user_baru As Boolean
    Public oUser As New user
    '--------------------------------

    'Tabel hasil
    '-------------------------------
    Public pemesanan_baru As Boolean
    Public opemesanan As New Pemesanan
    '--------------------------------

    'Tabel editfilm
    '-------------------------------
    Public editfilm_baru As Boolean
    Public oeditfilm As New ceditfilm
    '--------------------------------

    Public login_valid As Boolean
    Public Sub DBConnect()
        cn.DataSource = "C:\Users\ASUS\Documents\Visual Studio 2010\Projects\aplikasi penjualan tiket bioskop\aplikasi penjualan tiket bioskop\bin\Debug\db_bioskop.mdb"

        cn.Connect()
    End Sub

    Public Sub DBDisconnect()
        cn.Disconnect()
    End Sub
   
End Module