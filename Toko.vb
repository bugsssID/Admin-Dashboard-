Imports MySql.Data.MySqlClient
Public Class Toko

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Kosong!", vbCritical, "Sing Baleg!")
            Exit Sub
        End If
        str = "select toko from toko group by toko;"
        Try
            konek()
            cmd = New MySqlCommand(str, conn)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                MsgBox("Toko Sudah ada!", vbInformation, "Info")
                conn.Close()
                dr.Close()
            Else
                konek()
                str = "insert into toko values('" & TextBox1.Text.Trim & "','" & TextBox2.Text & "')"
                cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()
            End If
        Catch ex As Exception
            MsgBox("Error", vbCritical, "Error")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox1.Focus()
    End Sub

    Private Sub Toko_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        konek()
        Dim data As String = "select toko,nama from toko order by toko asc;"
        cmd = New MySqlCommand
        da = New MySqlDataAdapter
        dt = New DataTable
        With cmd
            .CommandText = data
            .Connection = conn
        End With
        With da
            .SelectCommand = cmd
            .Fill(dt)
        End With
        DataGridView1.Rows.Clear()
        For i = 0 To dt.Rows.Count - 1
            With DataGridView1
                .Rows.Add(dt.Rows(i)("toko"), dt.Rows(i)("nama"))
            End With
        Next
    End Sub
End Class