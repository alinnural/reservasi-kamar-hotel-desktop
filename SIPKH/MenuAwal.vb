Imports System.Data.OleDb
Public Class MenuAwal
    Dim codeId As String = Nothing
    Dim codeBiayaKamar As Integer = 0
    Private Sub MenuAwal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'db_hotelDataSet.tbl_transaksi' table. You can move, or remove it, as needed.
        Me.tbl_transaksiTableAdapter.Fill(Me.db_hotelDataSet.tbl_transaksi)
        koneksi()
        ShowDgv()
        ShowDgvIn()
        ShowDgvKamar()
        ShowDgvFasilitas()
        ShowDgvPegawai()
        Me.ReportViewer1.RefreshReport()
    End Sub
    Sub ShowDgv()
        DA = New OleDbDataAdapter("select id_kamar, type, harga from tbl_kamar, tbl_typekamar where tbl_kamar.status=0 and tbl_kamar.id_typekamar = tbl_typekamar.id_typekamar order by id_kamar, type, harga asc", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbl_kamar")
        dgvKamarin.DataSource = (DS.Tables("tbl_kamar"))
        dgvKamarin.ReadOnly = True
        dgvKamarin.Columns(0).HeaderText = "Nomor Kamar"
        dgvKamarin.Columns(1).HeaderText = "Type Kamar"
        dgvKamarin.Columns(2).HeaderText = "Harga"
        dgvKamarin.Columns(0).Width = 150
        dgvKamarin.Columns(1).Width = 150
        dgvKamarin.Columns(2).Width = 150
        dgvKamarin.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro
        dgvKamarin.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub
    Sub ShowDgvPegawai()
        DA = New OleDbDataAdapter("select distinct id_peg, nama, alamat, jabatan from tbl_pegawai where id_peg <> '" & lblIdpeg.Text & "'", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbl_pegawai")
        dgvPegawai.DataSource = (DS.Tables("tbl_pegawai"))
        dgvPegawai.ReadOnly = True
        dgvPegawai.Columns(0).HeaderText = "ID Pegawai"
        dgvPegawai.Columns(1).HeaderText = "Nama"
        dgvPegawai.Columns(2).HeaderText = "Alamat"
        dgvPegawai.Columns(3).HeaderText = "Jabatan"
        dgvPegawai.Columns(0).Width = 150
        dgvPegawai.Columns(1).Width = 150
        dgvPegawai.Columns(2).Width = 150
        dgvPegawai.Columns(3).Width = 150
        dgvPegawai.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro
        dgvPegawai.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub
    Sub ShowDgvIn()
        DA = New OleDbDataAdapter("select k.id_kamar, t.tgl_check_in, t.tgl_check_out, t.nama_pel, t.alamat_pel, t.id_transaksi from tbl_kamar as k, tbl_transaksi as t where k.status=1 and t.status=1 and k.id_kamar = t.id_kamar order by k.id_kamar asc", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbl_kamar")
        dgvKamarout.DataSource = (DS.Tables("tbl_kamar"))
        dgvKamarout.ReadOnly = True
        dgvKamarout.Columns(0).HeaderText = "Nomor Kamar"
        dgvKamarout.Columns(1).HeaderText = "Tanggal Checkin"
        dgvKamarout.Columns(2).HeaderText = "Tanggal Checkout"
        dgvKamarout.Columns(3).HeaderText = "Nama Pelanggan"
        dgvKamarout.Columns(4).HeaderText = "Alamat Pelanggan"
        dgvKamarout.Columns(5).HeaderText = "Nomor Transaksi"
        dgvKamarout.Columns(0).Width = 150
        dgvKamarout.Columns(1).Width = 150
        dgvKamarout.Columns(2).Width = 150
        dgvKamarout.Columns(3).Width = 150
        dgvKamarout.Columns(4).Width = 150
        dgvKamarout.Columns(5).Visible = False
        dgvKamarout.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro
        dgvKamarout.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub
    Sub ShowDgvKamar()
        DA = New OleDbDataAdapter("select k.id_kamar, t.type, t.harga from tbl_kamar as k, tbl_typekamar as t where k.id_typekamar = t.id_typekamar order by t.type, k.id_kamar, t.harga asc ", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbl_kamar")
        dgvKamar.DataSource = (DS.Tables("tbl_kamar"))
        dgvKamar.ReadOnly = True
        dgvKamar.Columns(0).HeaderText = "Nomor Kamar"
        dgvKamar.Columns(1).HeaderText = "Type Kamar"
        dgvKamar.Columns(2).HeaderText = "Harga Kamar"
        dgvKamar.Columns(0).Width = 150
        dgvKamar.Columns(1).Width = 150
        dgvKamar.Columns(2).Width = 150
        dgvKamar.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro
        dgvKamar.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub
    Sub ShowDgvFasilitas()
        DA = New OleDbDataAdapter("select * from tbl_fasilitas ", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbl_fasilitas")
        dgvFasilitas.DataSource = (DS.Tables("tbl_fasilitas"))
        dgvFasilitas.ReadOnly = True
        dgvFasilitas.Columns(0).HeaderText = "ID fasilitas"
        dgvFasilitas.Columns(1).HeaderText = "Nama"
        dgvFasilitas.Columns(2).HeaderText = "Jumlah"
        dgvFasilitas.Columns(3).HeaderText = "Harga"
        dgvFasilitas.Columns(0).Width = 150
        dgvFasilitas.Columns(1).Width = 150
        dgvFasilitas.Columns(2).Width = 150
        dgvFasilitas.Columns(3).Width = 150
        dgvFasilitas.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro
        dgvFasilitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRefreshin.Click
        ShowDgv()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCariin.Click
        DA = New OleDbDataAdapter("select id_kamar, type, harga from tbl_kamar, tbl_typekamar where tbl_kamar.status=0 and tbl_kamar.id_typekamar = tbl_typekamar.id_typekamar and id_kamar = " & txtCari.Text & " order by id_kamar asc", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbl_kamar")
        dgvKamarin.DataSource = (DS.Tables("tbl_kamar"))
        dgvKamarin.ReadOnly = True
        dgvKamarin.Columns(0).HeaderText = "Nomor Kamar"
        dgvKamarin.Columns(1).HeaderText = "Type Kamar"
        dgvKamarin.Columns(2).HeaderText = "Harga"
        dgvKamarin.Columns(0).Width = 150
        dgvKamarin.Columns(1).Width = 150
        dgvKamarin.Columns(2).Width = 150
        dgvKamarin.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro
        dgvKamarin.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub btnCariin_Click(sender As Object, e As EventArgs) Handles btnCariout.Click
        DA = New OleDbDataAdapter("select k.id_kamar, t.tgl_check_in, t.tgl_check_out, t.nama_pel, t.alamat_pel from tbl_kamar as k, tbl_transaksi as t where k.status=1 and k.id_kamar = t.id_kamar and k.id_kamar = " & txtCariin.Text & " order by k.id_kamar asc", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbl_kamar")
        dgvKamarout.DataSource = (DS.Tables("tbl_kamar"))
        dgvKamarout.ReadOnly = True
        dgvKamarout.Columns(0).HeaderText = "Nomor Kamar"
        dgvKamarout.Columns(1).HeaderText = "Tanggal Checkin"
        dgvKamarout.Columns(2).HeaderText = "Tanggal Checkout"
        dgvKamarout.Columns(3).HeaderText = "Nama Pelanggan"
        dgvKamarout.Columns(4).HeaderText = "Alamat Pelanggan"
        dgvKamarout.Columns(0).Width = 150
        dgvKamarout.Columns(1).Width = 150
        dgvKamarout.Columns(2).Width = 150
        dgvKamarout.Columns(3).Width = 150
        dgvKamarout.Columns(4).Width = 150
        dgvKamarout.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro
        dgvKamarout.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub btnRefreshin_Click(sender As Object, e As EventArgs) Handles btnRefreshout.Click
        ShowDgvIn()
    End Sub

    Private Sub dgvKamarin_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKamarin.CellDoubleClick
        Try
            With dgvKamarin
                If .Rows.Count <> 0 Then
                    codeId = .Item(0, e.RowIndex).Value
                    codeBiayaKamar = .Item(2, e.RowIndex).Value
                End If
            End With
        Catch ex As Exception

        End Try
        idKamar = codeId
        biayaKamar = codeBiayaKamar
        formCheckin.ShowDialog()
    End Sub

    Private Sub TabControl1_MouseClick(sender As Object, e As MouseEventArgs) Handles TabControl1.MouseClick
        ShowDgvIn()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        form_kamar.Show()
    End Sub

    Private Sub btnRefreshkamar_Click(sender As Object, e As EventArgs) Handles btnRefreshkamar.Click
        ShowDgvKamar()
    End Sub

    Private Sub dgvKamar_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKamar.CellDoubleClick
        Try
            With dgvKamar
                If .Rows.Count <> 0 Then
                    codeIdkamar = .Item(0, e.RowIndex).Value
                    codeType = .Item(1, e.RowIndex).Value
                    codeHargaType = .Item(2, e.RowIndex).Value
                End If
            End With
        Catch ex As Exception

        End Try
        'idKamar = codeId
        formManKamar.ShowDialog()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnHapuskamar.Click
        If MessageBox.Show("Yakin akan dihapus?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            If dgvKamar.Rows.Count > 0 Then
                If dgvKamar.SelectedRows.Count > 0 Then
                    Dim idKamar As String = dgvKamar.SelectedRows(0).Cells("id_kamar").Value
                    If Not CONN.State = ConnectionState.Open Then
                        CONN.Open()
                    End If

                    Dim cmd As New OleDbCommand
                    cmd.Connection = CONN
                    cmd.CommandText = "delete from tbl_kamar where id_kamar =" & idKamar
                    cmd.ExecuteNonQuery()
                    ShowDgvKamar()
                    CONN.Close()
                End If
                MsgBox("Data Berhasil Dihapus", vbInformation)
            End If
        Else
            MsgBox("Data Tidak Dihapus", vbInformation)
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        formFasilitas.Show()
    End Sub

    Private Sub dgvFasilitas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFasilitas.CellDoubleClick
        Try
            With dgvFasilitas
                If .Rows.Count <> 0 Then
                    codeIdfasilitas = .Item(0, e.RowIndex).Value
                    codeNamafasilitas = .Item(1, e.RowIndex).Value
                    codeJumlahfasilitas = .Item(2, e.RowIndex).Value
                    codeHargafasilitas = .Item(3, e.RowIndex).Value
                End If
            End With
        Catch ex As Exception

        End Try
        'idKamar = codeId
        formManFasilitas.ShowDialog()
    End Sub


    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles btnHapus.Click
        If MessageBox.Show("Yakin akan dihapus?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            If dgvFasilitas.Rows.Count > 0 Then
                If dgvFasilitas.SelectedRows.Count > 0 Then
                    Dim idFasilitas As String = dgvFasilitas.SelectedRows(0).Cells("id_fasilitas").Value
                    If Not CONN.State = ConnectionState.Open Then
                        CONN.Open()
                    End If

                    Dim cmd As New OleDbCommand
                    cmd.Connection = CONN
                    cmd.CommandText = "delete from tbl_fasilitas where id_fasilitas =" & idFasilitas
                    cmd.ExecuteNonQuery()
                    ShowDgvFasilitas()
                    CONN.Close()
                End If
                MsgBox("Data Berhasil Dihapus", vbInformation)
            End If
        Else
            MsgBox("Data Tidak Dihapus", vbInformation)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnRefreshpegawai.Click
        ShowDgvPegawai()
    End Sub

    Private Sub btnHapuspegawai_Click(sender As Object, e As EventArgs) Handles btnHapuspegawai.Click
        If MessageBox.Show("Yakin akan dihapus?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            If dgvPegawai.Rows.Count > 0 Then
                If dgvPegawai.SelectedRows.Count > 0 Then
                    Dim idPegawai As String = dgvPegawai.SelectedRows(0).Cells("id_peg").Value
                    If Not CONN.State = ConnectionState.Open Then
                        CONN.Open()
                    End If

                    Dim cmd As New OleDbCommand
                    cmd.Connection = CONN
                    cmd.CommandText = "delete from tbl_pegawai where id_peg ='" & idPegawai & "'"
                    cmd.ExecuteNonQuery()
                    ShowDgvPegawai()
                    CONN.Close()
                End If
                MsgBox("Data Berhasil Dihapus", vbInformation)
            End If
        Else
            MsgBox("Data Tidak Dihapus", vbInformation)
        End If
    End Sub

    Private Sub btnTambahpegawai_Click(sender As Object, e As EventArgs) Handles btnTambahpegawai.Click
        formPegawai.Show()
    End Sub

    Private Sub dgvKamarout_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKamarout.CellDoubleClick
        Try
            With dgvKamarout
                If .Rows.Count <> 0 Then
                    codeId = .Item(0, e.RowIndex).Value
                    codeNama = .Item(3, e.RowIndex).Value
                    codeAlamat = .Item(4, e.RowIndex).Value
                    codeCI = .Item(1, e.RowIndex).Value
                    codeCO = .Item(2, e.RowIndex).Value
                    codeIdtransaksi = .Item(5, e.RowIndex).Value
                End If
            End With
        Catch ex As Exception

        End Try
        idKamar = codeId
        formCheckout.ShowDialog()
    End Sub

    Private Sub tsUbahData_Click(sender As Object, e As EventArgs) Handles tsUbahData.Click
        formUbahData.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dispose()
        Form1.Show()
    End Sub

    Private Sub btnCarikamar_Click(sender As Object, e As EventArgs) Handles btnCarikamar.Click
        DA = New OleDbDataAdapter("select k.id_kamar, t.type, t.harga from tbl_kamar as k, tbl_typekamar as t where k.id_typekamar = t.id_typekamar and k.id_kamar = " & txtCarikamar.Text & " order by t.type, k.id_kamar, t.harga asc ", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbl_kamar")
        dgvKamar.DataSource = (DS.Tables("tbl_kamar"))
        dgvKamar.ReadOnly = True
        dgvKamar.Columns(0).HeaderText = "Nomor Kamar"
        dgvKamar.Columns(1).HeaderText = "Type Kamar"
        dgvKamar.Columns(2).HeaderText = "Harga Kamar"
        dgvKamar.Columns(0).Width = 150
        dgvKamar.Columns(1).Width = 150
        dgvKamar.Columns(2).Width = 150
        dgvKamar.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro
        dgvKamar.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub btnCarifasilitas_Click(sender As Object, e As EventArgs) Handles btnCarifasilitas.Click
        DA = New OleDbDataAdapter("select * from tbl_fasilitas where id_fasilitas = " & txtCarifasilitas.Text, CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbl_fasilitas")
        dgvFasilitas.DataSource = (DS.Tables("tbl_fasilitas"))
        dgvFasilitas.ReadOnly = True
        dgvFasilitas.Columns(0).HeaderText = "ID fasilitas"
        dgvFasilitas.Columns(1).HeaderText = "Nama"
        dgvFasilitas.Columns(2).HeaderText = "Jumlah"
        dgvFasilitas.Columns(3).HeaderText = "Harga"
        dgvFasilitas.Columns(0).Width = 150
        dgvFasilitas.Columns(1).Width = 150
        dgvFasilitas.Columns(2).Width = 150
        dgvFasilitas.Columns(3).Width = 150
        dgvFasilitas.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro
        dgvFasilitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub btnRefreshfasilitas_Click(sender As Object, e As EventArgs) Handles btnRefreshfasilitas.Click
        ShowDgvFasilitas()
    End Sub

    Private Sub btnCaripegawai_Click(sender As Object, e As EventArgs) Handles btnCaripegawai.Click
        DA = New OleDbDataAdapter("select distinct id_peg, nama, alamat, jabatan from tbl_pegawai where id_peg <> '" & lblIdpeg.Text & "' and id_peg ='" & txtCaripegawai.Text & "'", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbl_pegawai")
        dgvPegawai.DataSource = (DS.Tables("tbl_pegawai"))
        dgvPegawai.ReadOnly = True
        dgvPegawai.Columns(0).HeaderText = "ID Pegawai"
        dgvPegawai.Columns(1).HeaderText = "Nama"
        dgvPegawai.Columns(2).HeaderText = "Alamat"
        dgvPegawai.Columns(3).HeaderText = "Jabatan"
        dgvPegawai.Columns(0).Width = 150
        dgvPegawai.Columns(1).Width = 150
        dgvPegawai.Columns(2).Width = 150
        dgvPegawai.Columns(3).Width = 150
        dgvPegawai.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro
        dgvPegawai.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

End Class