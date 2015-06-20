Imports System.Data.OleDb
Public Class formFasilitas
    Dim idFasilitas As Integer
    Private Sub formFasilitas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoNumber()
        txtIdfasilitas.Text = idFasilitas
        txtIdfasilitas.Enabled = False
    End Sub
    Public Function SQLTable(ByVal Source As String) As DataTable
        Try
            Dim Adp As New OleDb.OleDbDataAdapter(Source, CONN)
            Dim DT As New DataTable

            Adp.Fill(DT)
            SQLTable = DT
        Catch ex As OleDb.OleDbException
            MsgBox(ex.Message)
            SQLTable = Nothing
        End Try
    End Function
    Sub autoNumber()
        Dim DR As DataRow
        Dim s As Integer
        Try
            DR = SQLTable("select id_fasilitas as Nomor from tbl_fasilitas order by id_fasilitas desc").Rows(0)
            If DR.IsNull("Nomor") Then
                s = 1
            Else
                s = Format(DR("Nomor") + 1, )
            End If
        Catch ex As Exception
            s = 1
        End Try

        idFasilitas = s
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtIdfasilitas.Text = "" Or txtNama.Text = "" Or txtHarga.Text = "" Or txtJumlah.Text = "" Then
            MsgBox("Data Belum Lengkap", vbInformation)
            Exit Sub
        Else
            CMD.CommandText = "insert into tbl_fasilitas (id_fasilitas, nama, jumlah, harga) values (" & txtIdfasilitas.Text & ",'" & txtNama.Text & "'," & txtJumlah.Text & ",'" & txtHarga.Text & "')"
            CMD.CommandType = CommandType.Text
            CMD.Connection = CONN
            CMD.ExecuteNonQuery()
            MsgBox("Data Berhasil Disimpan", vbInformation)
            CMD.Dispose()
            Dispose()
            MenuAwal.ShowDgvFasilitas()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dispose()
    End Sub
End Class