Imports MySql.Data.MySqlClient
Public Class FrmupdateAUP

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "SimpanAUP" Then
            If Label2.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Or TextBox1.Text = "" Then
                MsgBox("isi dengan lengkap!", vbInformation, "Info")
                Exit Sub
            End If
            Try
                konek()
                str = "update master_dat_aup set kondisi='" & ComboBox1.Text & "',posisi='" & ComboBox2.Text & "',progres_barang='" & TextBox1.Text & "', TGL_SO='" & Format(Now, "yyyy-MM-dd") & "' where AKTIVA='" & Label2.Text.Trim & "'"
                cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Sukses", vbInformation, "Info")
                Frmbrgaktiva.viewdata()
                Me.Close()
            Catch ex As Exception
                MsgBox("Error", ex.Message)
            End Try
        ElseIf Button1.Text = "SimpanDC" Then
            If Label2.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Or TextBox1.Text = "" Then
                MsgBox("isi dengan lengkap!", vbInformation, "Info")
                Exit Sub
            End If
            Try
                konek()
                str = "update master_dat_dc set kondisi='" & ComboBox1.Text & "',posisi='" & ComboBox2.Text & "',progres_barang='" & TextBox1.Text & "', TanggalUpdate='" & Format(Now, "yyyy-MM-dd") & "' where NO_AKTIVA='" & Label2.Text.Trim & "'"
                cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Sukses", vbInformation, "Info")
                FrmbarangaktivaDC.viewdata()
                Me.Close()
            Catch ex As Exception
                MsgBox("Error", ex.Message)
            End Try
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class