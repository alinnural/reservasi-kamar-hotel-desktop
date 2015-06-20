Public Class formUbahData

    Private Sub formUbahData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNama.Text = MenuAwal.lblNama.Text
        txtAlamat.Text = alamatPeg
        txtUsername.Text = username
        txtAlamat.Enabled = False
        txtNama.Enabled = False
        txtPassbaru.Enabled = False
        txtPasskonfirm.Enabled = False
        txtUsername.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtAlamat.Enabled = True
        txtNama.Enabled = True
        txtPassbaru.Enabled = True
        txtUsername.Enabled = True
    End Sub

    Private Sub txtPassbaru_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassbaru.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtPassbaru.Text = "" Then
                MsgBox("Password baru harus diisi")
                txtPassbaru.Focus()
            Else
                txtPasskonfirm.Enabled = True
                txtPasskonfirm.Focus()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtPassbaru.Text <> txtPasskonfirm.Text Or txtNama.Text = "" Or txtAlamat.Text = "" Or txtPassbaru.Text = "" Or txtUsername.Text = "" Then
            MsgBox("Data Belum Lengkap", vbInformation)
            MsgBox("ID peg =" & MenuAwal.lblIdpeg.Text, vbInformation)
            Exit Sub
        Else
            CMD.CommandText = "UPDATE tbl_pegawai SET nama = '" & txtNama.Text & "',alamat = '" & txtAlamat.Text & "', username = '" & txtUsername.Text & "' where id_peg = '" & idPeg & "';"
            CMD.CommandType = CommandType.Text
            CMD.Connection = CONN
            CMD.ExecuteNonQuery()
            CMD.Dispose()
            MsgBox("Data Anda Berhasil Diubah", vbInformation)
            Close()
            MenuAwal.Show()
        End If
    End Sub
End Class