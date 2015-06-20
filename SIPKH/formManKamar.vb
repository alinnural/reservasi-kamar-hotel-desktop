Imports System.Data
Imports System.Data.OleDb
Public Class formManKamar

    Private Sub formManKamar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIdtype.Text = codeIdtype
        txtType.Text = codeType
        txtHarga.Text = codeHargaType
        txtIdtype.Enabled = False
        txtType.Enabled = False
        txtHarga.Enabled = False
        idTypeKamar()
    End Sub
    Sub idTypeKamar()
        CMD.CommandText = "SELECT id_typekamar from tbl_kamar where id_kamar = " & codeIdkamar
        CMD.Connection = CONN
        Dim rdrOLEDB As OleDbDataReader = CMD.ExecuteReader
        If rdrOLEDB.Read = True Then
            txtIdtype.Text = rdrOLEDB.Item(0).ToString
            rdrOLEDB.Close()
            Exit Sub
            rdrOLEDB.Close()
        End If
        rdrOLEDB.Close()
    End Sub

    Private Sub btnSimpantype_Click(sender As Object, e As EventArgs) Handles btnSimpantype.Click
        If txtHarga.Enabled = False Then
            txtHarga.Enabled = True
            txtType.Enabled = True
        Else
            If txtIdtype.Text = "" Or txtType.Text = "" Or txtHarga.Text = "" Then
                MsgBox("Data Belum Lengkap", vbInformation)
                Exit Sub
            Else
                CMD.CommandText = "UPDATE tbl_typekamar SET type = '" & txtType.Text & "',harga = '" & txtHarga.Text & "' where  id_typekamar= " & txtIdtype.Text & ";"
                CMD.CommandType = CommandType.Text
                CMD.Connection = CONN
                CMD.ExecuteNonQuery()
                CMD.Dispose()
                Dispose()
                MenuAwal.ShowDgvKamar()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dispose()
    End Sub
End Class