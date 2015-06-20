Imports System.Data.OleDb

Module ModuleSIPKH
    Public CONN As OleDbConnection
    Public DA As OleDbDataAdapter
    Public DS As New DataSet
    Public CMD As OleDbCommand
    Public CMD2 As OleDbCommand
    Public DR As OleDbDataReader

    Public idKamar As Integer
    Public biayaKamar As Integer
    Public idPeg As String
    Public pass As String
    Public status As String
    Public alamatPeg As String
    Public username As String
    Public codeNama As String
    Public codeAlamat As String
    Public codeCI As Date
    Public codeCO As Date
    Public codeIdtransaksi As String
    Public codeIdtype As Integer
    Public codeIdkamar As Integer
    Public codeType As String
    Public codeHargaType As String
    Public codeIdfasilitas As Integer
    Public codeNamafasilitas As String
    Public codeJumlahfasilitas As String
    Public codeHargafasilitas As String

    Public Sub koneksi()
        CONN = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_hotel.accdb")
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
    End Sub
End Module
