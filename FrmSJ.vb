Imports MySql.Data.MySqlClient
Imports System.IO

Public Class FrmSJ

    Private Sub FrmSJ_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg;*.jpeg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ms As New MemoryStream
        If Button1.Text = "Input" Then
            Button3.Enabled = True
            Button1.Text = "Simpan"
            konek()
            cmd = New MySqlCommand("Select * from master_sj_all where nomor in (select max(nomor) from master_sj_all)", conn)
            Dim urutan As String
            Dim hitung As Long
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then
                urutan = "SJ0" + "001"
            Else
                hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 3) + 1
                urutan = "SJ0" + Microsoft.VisualBasic.Right("000" & hitung, 3)
            End If
            TextBox1.Text = urutan
            TextBox2.Focus()
        Else
            If TextBox2.Text = "" Then
                MsgBox("isi dengan benar!", MsgBoxStyle.Critical, "info")
                Exit Sub
            End If
            Try
                konek()
                cmd = New MySqlCommand("insert into master_sj_all(nomor,nama,image)values(@nomor,@nama,@picture)", conn)
                PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                Dim data As Byte() = ms.GetBuffer()
                Dim p As New MySqlParameter("@picture", MySqlDbType.Blob)
                p.Value = data
                cmd.Parameters.Add(p)
                cmd.Parameters.Add("@nama", MySqlDbType.VarChar).Value = TextBox2.Text
                cmd.Parameters.Add("@nomor", MySqlDbType.VarChar).Value = TextBox1.Text
                cmd.ExecuteNonQuery()
                PictureBox1.Image = Nothing
                TextBox1.Clear()
                TextBox2.Clear()
                Button3.Enabled = False
                Button1.Text = "Input"
                MsgBox("SJ Berhasil disimpan", vbInformation, "info")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class