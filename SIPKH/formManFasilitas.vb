Public Class formManFasilitas

    Private Sub formManFasilitas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIdfasilitas.Text = codeIdfasilitas
        txtNama.Text = codeNamafasilitas
        txtJumlah.Text = codeJumlahfasilitas
        txtHarga.Text = codeHargafasilitas
        txtIdfasilitas.Enabled = False
        txtNama.Enabled = False
        txtJumlah.Enabled = False
        txtHarga.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtNama.Enabled = False Then
            txtHarga.Enabled = True
            txtJumlah.Enabled = True
            txtNama.Enabled = True
        Else
            If txtNama.Text = "" Or txtJumlah.Text = "" Or txtHarga.Text = "" Then
                MsgBox("Data Belum Lengkap", vbInformation)
                Exit Sub
            Else
                CMD.CommandText = "UPDATE tbl_fasilitas SET nama = '" & txtNama.Text & "',jumlah = " & txtJumlah.Text & ",harga = " & txtHarga.Text & " where  id_fasilitas= " & txtIdfasilitas.Text & ";"
                CMD.CommandType = CommandType.Text
                CMD.Connection = CONN
                CMD.ExecuteNonQuery()
                CMD.Dispose()
                Dispose()
                MenuAwal.ShowDgvFasilitas()
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dispose()
    End Sub
End Class