Imports System.Data
Imports System.Data.OleDb
Public Class formCheckin
    Dim id As Integer
    Dim idDetailFasilitas As Integer
    Dim hargaFasilitas As Integer = 0
    Dim hargaKamar As Integer = biayaKamar
    Dim hargaBed As Integer = 0
    Dim hargaTable As Integer = 0
    Dim hargaWar As Integer = 0
    Dim fasBed As Boolean = False
    Dim fasTable As Boolean = False
    Dim fasWardrobe As Boolean = False

    Private Sub formCheckin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoNumber()
        txtIdtransaksi.Text = id
        txtIdkamar.Text = idKamar
        txtLamainap.Text = 1
        txtBiayakamar.Text = biayaKamar
        lblHargakamar.Text = biayaKamar
        lblHargatotal.Text = biayaKamar
        txtBiayakamar.Enabled = False
        txtIdtransaksi.Enabled = False
        txtIdkamar.Enabled = False
        txtLamainap.Enabled = False
    End Sub
    Public Function SQLTable(ByVal Source As String) As DataTable
        Try
            Dim Adp As New OleDb.OleDbDataAdapter(Source, conn)
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
            DR = SQLTable("select id_transaksi as Nomor from tbl_transaksi order by id_transaksi desc").Rows(0)
            If DR.IsNull("Nomor") Then
                s = 1
            Else
                s = Format(DR("Nomor") + 1, )
            End If
        Catch ex As Exception
            s = 1
        End Try

        Id = s
    End Sub
    Sub autoNumberDetailFasilitas()
        Dim DR As DataRow
        Dim s As Integer
        Try
            DR = SQLTable("select id_detailfasilitas as Nomor from tbl_detailfasilitas order by id_detailfasilitas desc").Rows(0)
            If DR.IsNull("Nomor") Then
                s = 1
            Else
                s = Format(DR("Nomor") + 1, )
            End If
        Catch ex As Exception
            s = 1
        End Try

        idDetailFasilitas = s
    End Sub

    Private Sub ckBed_MouseClick(sender As Object, e As MouseEventArgs) Handles ckBed.MouseClick
        If fasBed.Equals(False) Then
            hargaFasilitas = hargaFasilitas + 30000
            fasBed = True
        Else
            hargaFasilitas = hargaFasilitas - 30000
            fasBed = False
        End If

        lblHargafasilitas.Text = hargaFasilitas
        lblHargatotal.Text = hargaKamar + hargaFasilitas
    End Sub

    Private Sub ckTable_MouseClick(sender As Object, e As MouseEventArgs) Handles ckTable.MouseClick
        If fasTable.Equals(False) Then
            hargaFasilitas = hargaFasilitas + 50000
            fasTable = True
        Else
            hargaFasilitas = hargaFasilitas - 50000
            fasTable = False
        End If

        lblHargafasilitas.Text = hargaFasilitas
        lblHargatotal.Text = hargaKamar + hargaFasilitas
    End Sub

    Private Sub ckWardrobe_MouseClick(sender As Object, e As MouseEventArgs) Handles ckWardrobe.MouseClick
        If fasWardrobe.Equals(False) Then
            hargaFasilitas = hargaFasilitas + 70000
            fasWardrobe = True
        Else
            hargaFasilitas = hargaFasilitas - 70000
            fasWardrobe = False
        End If

        lblHargafasilitas.Text = hargaFasilitas
        lblHargatotal.Text = hargaKamar + hargaFasilitas

       

    End Sub

    Private Sub dateCheckIn_ValueChanged(sender As Object, e As EventArgs) Handles dateCheckIn.ValueChanged
        If dateCheckIn.Value < DateTime.Now Then
            dateCheckIn.Value = DateTime.Now
        Else
            Dim datetime1 As Date = dateCheckIn.Value
            Dim datetime2 As Date = dateCheckOut.Value
            If datetime1 > datetime2 Then
                dateCheckout.Value = dateCheckIn.Value
            End If
        End If

        Dim date1 As Date = dateCheckIn.Value
        Dim date2 As Date = dateCheckout.Value
        Dim totalDays As Integer

        If date1.Year = date2.Year Then
            totalDays = date2.DayOfYear - date1.DayOfYear
        ElseIf date1.Year < date2.Year Then
            Dim akhirTahun As Date = "31/12/" & date1.Year
            Dim awalTahun As Date = "01/01/" & date2.Year
            totalDays = (akhirTahun.DayOfYear - date1.DayOfYear) + ((date2.DayOfYear - awalTahun.DayOfYear) + 1)
        End If

        txtLamainap.Text = totalDays
        Dim bil1 As Integer = txtBiayakamar.Text
        Dim bil2 As Integer = txtLamainap.Text
        Dim price As Integer = bil1 * bil2
        lblHargakamar.Text = price
        If txtLamainap.Text = "0" Then
            lblHargakamar.Text = txtBiayakamar.Text
        End If
        hargaKamar = lblHargakamar.Text
        lblHargatotal.Text = hargaKamar + hargaFasilitas
        MsgBox("date = " & dateCheckIn.Value, vbInformation)
    End Sub

    Private Sub dateCheckout_ValueChanged(sender As Object, e As EventArgs) Handles dateCheckout.ValueChanged
        Dim datetime1 As Date = dateCheckIn.Value
        Dim datetime2 As Date = dateCheckout.Value
        If datetime1 > datetime2 Then
            dateCheckout.Value = dateCheckIn.Value
        End If

        Dim date1 As Date = dateCheckIn.Value
        Dim date2 As Date = dateCheckout.Value
        Dim totalDays As Integer

        If date1.DayOfYear = date2.DayOfYear Then
            totalDays = 1
        ElseIf date1.Year = date2.Year Then
            totalDays = date2.DayOfYear - date1.DayOfYear
        ElseIf date1.Year < date2.Year Then
            Dim akhirTahun As Date = "31/12/" & date1.Year
            Dim awalTahun As Date = "01/01/" & date2.Year
            Dim j As Integer = 0
            totalDays = (akhirTahun.DayOfYear - date1.DayOfYear)
            If date2.Year <> (date1.Year + 1) Then
                For i = (date1.Year + 1) To (date2.Year - 1)
                    'j = j + 1
                    akhirTahun = "31/12/" & i
                    awalTahun = "01/01/" & i
                    totalDays = totalDays + (akhirTahun.DayOfYear - awalTahun.DayOfYear) + 1
                    'MsgBox(akhirTahun, vbInformation)
                Next
            End If
            totalDays = totalDays + ((date2.DayOfYear - awalTahun.DayOfYear) + 1)
        End If
        txtLamainap.Text = totalDays
        Dim bil1 As Integer = txtBiayakamar.Text
        Dim bil2 As Integer = txtLamainap.Text
        Dim price As Integer = bil1 * bil2
        lblHargakamar.Text = price
        If txtLamainap.Text = "0" Then
            lblHargakamar.Text = txtBiayakamar.Text
        End If
        hargaKamar = lblHargakamar.Text
        lblHargatotal.Text = hargaKamar + hargaFasilitas
    End Sub

    Private Sub txtSimpan_Click(sender As Object, e As EventArgs) Handles txtSimpan.Click
        If txtNama.Text = "" Or txtNohp.Text = "" Or txtNohp.Text = "" Then
            MsgBox("Data Belum Lengkap", vbInformation)
            Exit Sub
        Else
            CMD.CommandText = "UPDATE tbl_kamar SET status = 1 where id_kamar = " & txtIdkamar.Text & ";"
            CMD.CommandType = CommandType.Text
            CMD.Connection = CONN
            CMD.ExecuteNonQuery()
            CMD.Dispose()
            CMD.CommandText = "insert into tbl_transaksi (id_transaksi, id_peg, id_kamar, tgl_check_in, tgl_check_out, nama_pel, alamat_pel, no_hp_pel, harga_kamar, harga_fasilitas, harga_total, status) values (" & txtIdtransaksi.Text & ",'" & idPeg & "'," & idKamar & ", '" & dateCheckIn.Value & "','" & dateCheckout.Value & "','" & txtNama.Text & "','" & txtAlamat.Text & "','" & txtNohp.Text & "','" & lblHargakamar.Text & "','" & lblHargafasilitas.Text & "','" & lblHargatotal.Text & "',1)"
            CMD.CommandType = CommandType.Text
            CMD.Connection = CONN
            CMD.ExecuteNonQuery()
            CMD.Dispose()
            'Dispose()
            MenuAwal.ShowDgv()
        End If

        If ckTable.Checked.Equals(True) Then
            autoNumberDetailFasilitas()
            CMD.CommandText = "insert into tbl_detailfasilitas (id_detailfasilitas, id_transaksi, id_fasilitas) values (" & idDetailFasilitas & "," & txtIdtransaksi.Text & ",2)"
            CMD.CommandType = CommandType.Text
            CMD.Connection = CONN
            CMD.ExecuteNonQuery()
            CMD.Dispose()
        End If
        If ckWardrobe.Checked.Equals(True) Then
            autoNumberDetailFasilitas()
            CMD.CommandText = "insert into tbl_detailfasilitas (id_detailfasilitas, id_transaksi, id_fasilitas) values (" & idDetailFasilitas & "," & txtIdtransaksi.Text & ",3)"
            CMD.CommandType = CommandType.Text
            CMD.Connection = CONN
            CMD.ExecuteNonQuery()
            CMD.Dispose()
        End If
        If ckBed.Checked.Equals(True) Then
            autoNumberDetailFasilitas()
            CMD.CommandText = "insert into tbl_detailfasilitas (id_detailfasilitas, id_transaksi, id_fasilitas) values (" & idDetailFasilitas & "," & txtIdtransaksi.Text & ",1)"
            CMD.CommandType = CommandType.Text
            CMD.Connection = CONN
            CMD.ExecuteNonQuery()
            CMD.Dispose()
        End If
        MsgBox("Data Berhasil Disimpan", vbInformation)
        Dispose()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class