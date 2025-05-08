Imports MySql.Data.MySqlClient
Public Class Frmeditnonaktiva

    Private Sub Frmeditnonaktiva_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("isi QTY atau Masukan Penjelasan!", vbCritical, "Info")
            Exit Sub
        End If
        Try
            Dim lama As Double = TextBox2.Text.Trim
            Dim baru As Double = TextBox3.Text.Trim
            Dim hasil As Double
            hasil = lama - baru
            konek()
            str = "update master_brg_non_aktiva set qty='" & hasil & "',tgl_so='" & Format(Now, "yyyy-MM-dd") & "',keter='" & TextBox4.Text & "' where kode='" & Me.Text & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            FrmbarangNonAktiva.displaydata()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class