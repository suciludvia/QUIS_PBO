Public Class home

    Private Sub btnpesantiket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpesantiket.Click
        pilihstudio.MdiParent = Me
        pilihstudio.Show()
        pilihstudio.Focus()
    End Sub

    Private Sub btnpemesanan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpemesanan.Click
        datapemesanan.MdiParent = Me
        datapemesanan.Show()
        datapemesanan.Focus()
    End Sub

    Private Sub btnupdatefilm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdatefilm.Click
        editfilm.MdiParent = Me
        editfilm.Show()
        editfilm.Focus()
    End Sub

    Private Sub home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnpesantiket.Focus()
    End Sub
End Class