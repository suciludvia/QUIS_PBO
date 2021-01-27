Public Class pesantiket
    Private Sub pesantiket_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txthari.Focus()
    End Sub

    Private Sub btnpesan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpesan.Click
        Dim studio, jdlfilm, jamtayang, hari, nomorkursirow, nomorkursicol, kdstudio As String
        Dim hargatiket, jumlahtiket, totalharga As Integer

        kdstudio = txtkdstudio.Text
        studio = txtstudio.Text
        jdlfilm = txtjudulfilm.Text
        hargatiket = txthargatiket.Text
        jamtayang = txtjamtayang.Text
        hari = txthari.Text
        jumlahtiket = NumericUpDown1.Value
        nomorkursirow = txtnomorkursi_row.Text
        nomorkursicol = txtnomorkursi_col.Text

        totalharga = hargatiket * jumlahtiket

        txtojudulfilm.Text = jdlfilm
        txtostudio.Text = studio
        txtojamtayang.Text = jamtayang
        txtohargatiket.Text = hargatiket
        txtoqty.Text = jumlahtiket
        txttotalharga.Text = totalharga
        txtnomorkursi.Text = nomorkursirow & nomorkursicol
        txtohari.Text = hari

        txttotalbayar.Enabled = True
        btnbayar.Enabled = True

    End Sub

    Dim totalharga, totalbayar, totalkembaliian As Integer
    Private Sub txttotalbayar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttotalbayar.TextChanged

        totalharga = txttotalharga.Text
        totalbayar = txttotalbayar.Text

        totalkembaliian = totalbayar - totalharga

        txttotalkembalian.Text = "Rp." & totalkembaliian

    End Sub

    Private Sub btnbayar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbayar.Click
        If totalbayar < totalharga Then
            MsgBox("Maaf Uangnya Kurang :(")
            Me.txttotalbayar.Focus()
        Else
            Dim sql As String = "Insert Into tb_pesanan(kd_studio, Kursi_duduk, qty, total_bayar) Values ('" & Me.txtkdstudio.Text & "','" & Me.txtnomorkursi.Text & "','" & Me.txtoqty.Text & "','" & Me.totalharga & "')"
                mycommand.Connection = conn
                mycommand = New System.Data.OleDb.OleDbCommand(sql, conn)
            mycommand.ExecuteNonQuery()
            MsgBox("tiket berhasil dibeli")
            Me.Hide()
        End If
    End Sub
End Class