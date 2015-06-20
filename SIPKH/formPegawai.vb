Imports System.Data.OleDb
Public Class formPegawai
    Dim idPegawai As String
    Dim kodeJabatan As String
    Dim id_peg As String
    Private Sub formPegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MsgBox("kodejabatan = " & kodeJabatan & "", vbInformation)
    End Sub
    Sub cekJabatan()
        If cmbJabatan.Text.Equals("Resepsionis") Then
            kodeJabatan = "Rcp"
        ElseIf cmbJabatan.Text.Equals("Administrator") Then
            kodeJabatan = "Adm"
        End If
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
            DR = SQLTable("select mid(id_peg,4,2) as Nomor from tbl_pegawai where mid(id_peg,1,3) = '" & kodeJabatan & "' order by id_peg desc").Rows(0)
            If DR.IsNull("Nomor") Then
                s = 1
            Else
                s = Format(DR("Nomor") + 1, )
            End If
        Catch ex As Exception
            s = 1
        End Try

        idPegawai = s
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        cekJabatan()
        autoNumber()
        id_peg = kodeJabatan + idPegawai.ToString

        'If txtNama.Text = "" Or txtAlamat.Text = "" Or cmbJabatan.Text = "" Then
        '    MsgBox("Data Belum Lengkap", vbInformation)
        '    Exit Sub
        'Else
        '    CMD.CommandText = "insert into tbl_pegawai (id_peg, nama, alamat, jabatan, username, password) values ( 'Adm4','Coco','Bogor','Administrator','caca','234')"
        '    CMD.CommandType = CommandType.Text
        '    CMD.Connection = CONN
        '    CMD.ExecuteNonQuery()
        '    MsgBox("ID Pegawai = " & id_peg & "", vbInformation)
        '    MsgBox("Data Berhasil Disimpan", vbInformation)
        '    CMD.Dispose()
        '    Dispose()
        '    MenuAwal.ShowDgvFasilitas()
        'End If

        If txtNama.Text = "" Or txtAlamat.Text = "" Or cmbJabatan.Text = "" Then
            MsgBox("Data Belum Lengkap", vbInformation)
            Exit Sub
        Else
            CMD.CommandText = "insert into tbl_pegawai values ( '" & id_peg & "','" & txtNama.Text & "','" & txtAlamat.Text & "','" & cmbJabatan.Text & "','" & txtNama.Text & "','234')"
            CMD.CommandType = CommandType.Text
            CMD.Connection = CONN
            CMD.ExecuteNonQuery()
            MsgBox("Data Berhasil Disimpan", vbInformation)
            CMD.Dispose()
            Dispose()
            MenuAwal.ShowDgvPegawai()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Dispose()
    End Sub
End Class