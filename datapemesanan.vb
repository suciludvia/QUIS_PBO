Public Class datapemesanan
    Private Sub Reload()
        opemesanan.GetAllData2(DataGridView1)
    End Sub
    Private Sub datapemesanan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Reload()
    End Sub
End Class