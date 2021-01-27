Imports System.Data.OleDb
Public Class formeditfilm

    Private Sub btnperbarui_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnperbarui.Click
        If txtjudulfilm.Text = "" Or txthargatiket.Text = "" Or txtjamtayang.Text = "" Then
            MsgBox("Masih ada data yang belum terisi", vbInformation + vbOKOnly, "Informasi")
        Else
            Dim queryeditfilm = "update tb_studio set nama_studio='" & Me.txtstudio.Text & "' ,judul_film='" & Me.txtjudulfilm.Text & "' ,harga_tiket='" & Me.txthargatiket.Text & "' ,jam_tayang='" & Me.txtjamtayang.Text & "' where kd_studio='" & txtkodefilm.Text & "'"
            mycommand = New OleDbCommand(queryeditfilm, conn)
            mycommand.ExecuteNonQuery()
            MsgBox("Data Berhasil di Perbarui", MsgBoxStyle.Information = MsgBoxStyle.OkOnly, "Informasi")
            Me.Hide()
            editfilm.Show()
        End If
    End Sub
End Class