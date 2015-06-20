Imports System.Data.OleDb
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        koneksi()
        CMD = New OleDbCommand("select * from tbl_pegawai where username='" & txtUsername.Text & "' and password='" & txtPassword.Text & "'", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Me.Visible = False
            idPeg = DR.GetString(0)
            MenuAwal.lblNama.Text = DR.GetString(1)
            MenuAwal.lblStatus.Text = DR.GetString(3)
            status = DR.GetString(3)
            pass = DR.GetString(5)
            alamatPeg = DR.GetString(2)
            username = DR.GetString(4)
            MenuAwal.lblIdpeg.Text = idPeg
            If status = "Administrator" Then
                MenuAwal.tabCheckin.Enabled = False
                MenuAwal.tabCheckout.Enabled = False
                MenuAwal.tabLaporan.Enabled = False
                MenuAwal.Show()
            ElseIf status = "Resepsionis" Then
                MenuAwal.tabKamar.Enabled = False
                MenuAwal.tabFasilitas.Enabled = False
                MenuAwal.tabPegawai.Enabled = False
                MenuAwal.tabLaporan.Enabled = False
                MenuAwal.Show()
            ElseIf status = "Direktur" Then
                MenuAwal.tabKamar.Enabled = False
                MenuAwal.tabFasilitas.Enabled = False
                MenuAwal.tabPegawai.Enabled = False
                MenuAwal.tabCheckin.Enabled = False
                MenuAwal.tabCheckout.Enabled = False
                MenuAwal.Show()
            End If
        Else
            MsgBox("Username atau password salah, masukkan kembali!!!")
            txtUsername.Focus()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
