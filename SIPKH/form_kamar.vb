Imports System.Data
Imports System.Data.OleDb
Public Class form_kamar
    Dim Idtype As Integer
    Dim jum As Integer
    Dim idTypeKamar As Integer
    Dim idKamarTambah As Integer
    Dim lantai As Integer

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

    Sub readTypeKamar()
        DA = New OleDbDataAdapter("select id_typekamar,type from tbl_typekamar", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS)
        cmbType.DataSource = DS.Tables(0)
        cmbType.DisplayMember = "type"
        cmbType.ValueMember = "id_typekamar"
    End Sub

    Sub autoNumberIdType()
        Dim DR As DataRow
        Dim s As Integer
        Try
            DR = SQLTable("select id_typekamar as Nomor from tbl_typekamar order by id_typekamar desc").Rows(0)
            If DR.IsNull("Nomor") Then
                s = 1
            Else
                s = Format(DR("Nomor") + 1, )
            End If
        Catch ex As Exception
            s = 1
        End Try

        Idtype = s
    End Sub

    Sub autoNumberIdKamar()
        Dim DR As DataRow
        Dim s As Integer
        Try
            DR = SQLTable("select mid(id_kamar,3) as Nomor from tbl_kamar where mid(id_kamar,1,1) = " & lantai & " and mid(id_kamar,2,1) = " & idTypeKamar & " order by id_typekamar desc").Rows(0)
            If DR.IsNull("Nomor") Then
                s = 1
            Else
                s = Format(DR("Nomor") + 1, )
            End If
        Catch ex As Exception
            s = 1
        End Try

        idKamarTambah = s
    End Sub

    Private Sub form_kamar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtType.Enabled = False
        txtHarga.Enabled = False
        cmbType.Enabled = False
        txtJum.Enabled = False
        txtIdtype.Enabled = False
        txtLantai.Enabled = False
    End Sub

    Private Sub btnSimpankamar_Click(sender As Object, e As EventArgs) Handles btnSimpankamar.Click
        lantai = txtLantai.Text
        If cmbType.Text = "" Or txtJum.Text = "" Or txtLantai.Text = "" Then
            MsgBox("Data Belum Lengkap", vbInformation)
            Exit Sub
        Else
            jum = txtJum.Text
            For i = 1 To jum
                autoNumberIdKamar()
                'MsgBox(" number " & idKamarTambah & "", vbInformation)
                'MsgBox("lantai " & lantai.ToString + idTypeKamar.ToString + idKamarTambah.ToString & "", vbInformation)
                CMD.CommandText = "insert into tbl_kamar (id_kamar,id_typekamar,status) values (" & lantai.ToString + idTypeKamar.ToString + idKamarTambah.ToString & "," & idTypeKamar & ",0)"
                CMD.CommandType = CommandType.Text
                CMD.Connection = CONN
                CMD.ExecuteNonQuery()
                CMD.Dispose()
                Dispose()
                MenuAwal.ShowDgvKamar()
            Next

            MsgBox(jum & " data berhasil disimpan ", vbInformation)
        End If
    End Sub

    Private Sub btnSimpantype_Click(sender As Object, e As EventArgs) Handles btnSimpantype.Click
        If txtIdtype.Text = "" Or txtIdtype.Text = "" Or txtHarga.Text = "" Then
            MsgBox("Data Belum Lengkap", vbInformation)
            Exit Sub
        Else
            CMD.CommandText = "insert into tbl_typekamar (id_typekamar, type, harga) values (" & txtIdtype.Text & ",'" & txtType.Text & "','" & txtHarga.Text & "')"
            CMD.CommandType = CommandType.Text
            CMD.Connection = CONN
            CMD.ExecuteNonQuery()
            MsgBox("Data Berhasil Disimpan", vbInformation)
            CMD.Dispose()
            Dispose()
            MenuAwal.ShowDgv()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTambahtype.Click
        autoNumberIdType()
        txtType.Enabled = True
        txtHarga.Enabled = True
        txtIdtype.Text = Idtype
    End Sub

    Private Sub btnTambahkamar_Click(sender As Object, e As EventArgs) Handles btnTambahkamar.Click
        readTypeKamar()
        cmbType.Enabled = True
        txtJum.Enabled = True
        txtLantai.Enabled = True
    End Sub

    Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged
        CMD.CommandText = "SELECT id_typekamar from tbl_typekamar where type = '" & cmbType.Text & "'"
        CMD.Connection = CONN
        Dim rdrOLEDB As OleDbDataReader = CMD.ExecuteReader
        If rdrOLEDB.Read = True Then
            idTypeKamar = rdrOLEDB.Item(0).ToString
            rdrOLEDB.Close()
            Exit Sub
            rdrOLEDB.Close()
        End If
        rdrOLEDB.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtIdtype.Text = ""
        txtType.Enabled = False
        txtHarga.Enabled = False
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        txtType.Enabled = False
        txtJum.Enabled = False
        txtLantai.Enabled = False
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class