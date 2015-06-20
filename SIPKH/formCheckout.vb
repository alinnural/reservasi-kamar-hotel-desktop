Imports System.Data.OleDb
Public Class formCheckout

    Private Sub formCheckout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNama.Text = codeNama
        txtAlamat.Text = codeAlamat
        txtIdkamar.Text = idKamar
        txtIdtransaksi.Text = codeIdtransaksi
        dateCheckIn.Value = codeCI
        dateCheckout.Value = codeCO
        txtAlamat.Enabled = False
        txtNama.Enabled = False
        txtIdkamar.Enabled = False
        dateCheckIn.Enabled = False
        dateCheckout.Enabled = False
        txtIdtransaksi.Visible = False
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        CMD.CommandText = "UPDATE tbl_transaksi SET status = 0 where id_transaksi = " & txtIdtransaksi.Text & ";"
        CMD.CommandType = CommandType.Text
        CMD.Connection = CONN
        CMD.ExecuteNonQuery()
        CMD.Dispose()
        CMD.CommandText = "UPDATE tbl_kamar SET status = 0 where id_kamar = " & txtIdkamar.Text & ";"
        CMD.CommandType = CommandType.Text
        CMD.Connection = CONN
        CMD.ExecuteNonQuery()
        MsgBox("Checkout Berhasil", vbInformation)
        CMD.Dispose()
        Dispose()
        MenuAwal.ShowDgvIn()
        MenuAwal.ShowDgv()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtIdtransaksi.TextChanged

    End Sub
End Class