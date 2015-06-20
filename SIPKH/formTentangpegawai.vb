Public Class formTentangpegawai

    Private Sub formTentangpegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UBahDataToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub UbahDataToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles UbahDataToolStripMenuItem.Click
        formUbahData.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dispose()
    End Sub
End Class