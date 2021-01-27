Public Class pilihstudio

    Sub tampildata()
        DBConnect()
        Dim str As String
        mycommand.Connection = conn
        str = "select * from tb_studio where kd_studio = '" & pilihan & "'"
        mycommand = New System.Data.OleDb.OleDbCommand(str, conn)
        DR = mycommand.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            pesantiket.txtkdstudio.text = DR.Item("kd_studio")
            pesantiket.txtstudio.Text = DR.Item("nama_studio")
            pesantiket.txtjudulfilm.Text = DR.Item("judul_film")
            pesantiket.txtjamtayang.Text = DR.Item("jam_tayang")
            pesantiket.txthargatiket.Text = DR.Item("harga_tiket")
            Me.Close()
            pesantiket.Show()
            pesantiket.txttotalbayar.Enabled = False
            pesantiket.btnbayar.Enabled = False
            pesantiket.txtkdstudio.Hide()
        End If
    End Sub

    Dim pilihan As String

    Private Sub btnpilihstudio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpilihstudio.Click
        If btn1.Checked = True Then
            pilihan = "st1"
            tampildata()
        ElseIf btn2.Checked = True Then
            pilihan = "st2"
            tampildata()
        ElseIf btn3.Checked = True Then
            pilihan = "st3"
            tampildata()
        ElseIf btn4.Checked = True Then
            pilihan = "st4"
            tampildata()
        Else
            MsgBox("Mohon Pilih Studio")
        End If
    End Sub

    Private Sub pilihstudio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnpilihstudio.Focus()
    End Sub
End Class