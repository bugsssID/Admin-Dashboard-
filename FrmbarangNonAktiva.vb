Imports MySql.Data.MySqlClient
Public Class FrmbarangNonAktiva
    Sub displaydata()
        Try
            konek()
            Dim data As String = "select kode, nama_barang, qty, posisi, tgl_so, keter from master_brg_non_aktiva order by kode;"
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
                    .Rows.Add(dt.Rows(i)("kode"), dt.Rows(i)("nama_barang"), dt.Rows(i)("qty"), dt.Rows(i)("posisi"), dt.Rows(i)("tgl_so"), dt.Rows(i)("keter"))
                End With
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub FrmbarangNonAktiva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Listing Barang Non Aktiva | Update Date " & Format(Now, "yyyy-MM-dd")
        konek()
        Me.displaydata()
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Input" Then
            Button1.Text = "Simpan"
            konek()
            cmd = New MySqlCommand("Select * from master_brg_non_aktiva where kode in (select max(kode) from master_brg_non_aktiva)", conn)
            Dim urutan As String
            Dim hitung As Long
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then
                urutan = "N00" + "001"
            Else
                hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 3) + 1
                urutan = "N00" + Microsoft.VisualBasic.Right("000" & hitung, 3)
            End If
            TextBox1.Text = urutan
            TextBox2.Focus()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Or TextBox4.Text = "" Then
                MsgBox("isi dengan lengkap!", vbCritical, "Info")
                Exit Sub
            End If
            Try
                konek()
                str = "insert into master_brg_non_aktiva values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "','" & Format(Now, "yyyy-MM-dd") & "','" & TextBox4.Text & "')"
                cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Berhasil", vbInformation, "Info")
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
                ComboBox1.Text = ""
                Button1.Focus()
                Button1.Text = "Input"
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        ComboBox1.Text = ""
        TextBox2.Focus()
        Button1.Text = "Input"
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If DataGridView1.RowCount > 0 Then
            Dim baris As Integer
            With DataGridView1
                baris = .CurrentRow.Index
                Frmeditnonaktiva.Show()
                Frmeditnonaktiva.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(0).Value
                Frmeditnonaktiva.TextBox1.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(1).Value
                Frmeditnonaktiva.TextBox2.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(2).Value
                Frmeditnonaktiva.TextBox4.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(5).Value
            End With
        End If
    End Sub
End Class