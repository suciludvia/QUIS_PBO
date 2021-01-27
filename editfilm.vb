Public Class editfilm
    Private Sub Reload()
        oeditfilm.GetAllData(DataGridView1)
    End Sub
    Private Sub editfilm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Reload()
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        formeditfilm.txtkodefilm.Text = DataGridView1.Item(0, i).Value
        formeditfilm.txtstudio.Text = DataGridView1.Item(1, i).Value
        formeditfilm.txtjudulfilm.Text = DataGridView1.Item(2, i).Value
        formeditfilm.txthargatiket.Text = DataGridView1.Item(3, i).Value
        formeditfilm.txtjamtayang.Text = DataGridView1.Item(4, i).Value
        Me.Close()
        formeditfilm.Show()
    End Sub
End Class