Imports MySql.Data.MySqlClient
Public Class Frmbrgaktiva
    Private searchIndex As Integer = -1
    Sub viewdata()
        konek()
        Try
            da = New MySqlDataAdapter("SELECT AKTIVA, NAMA, STATUS, BIAYA_PEROLEHAN, BBN_PENYUSUTAN_BLN_INI,JUMLAH_TERCATAT, KONDISI, POSISI,TGL_SO, PROGRES_BARANG FROM MASTER_DAT_AUP ORDER BY AKTIVA ASC;", conn)
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub Frmbrgaktiva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Listing Barang AUP - UPDATE : " & Format(Now, "yyyy-MM-dd")
        Me.viewdata()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Parameter tidak boleh kosong", MsgBoxStyle.Critical, "Info")
            TextBox1.Focus()
        Else
            Try
                Call konek()
                Using sql As New MySqlCommand("SELECT AKTIVA, NAMA, STATUS, BIAYA_PEROLEHAN, BBN_PENYUSUTAN_BLN_INI,JUMLAH_TERCATAT, KONDISI, POSISI,TGL_SO, PROGRES_BARANG FROM MASTER_DAT_AUP where " & ComboBox1.Text & " like '%" & TextBox1.Text & "%'", conn)
                    Using dr As MySqlDataReader = sql.ExecuteReader()
                        Using dt As New DataTable
                            dt.Load(dr)
                            If dt.Rows.Count = 0 Then
                                'DataGridView1.DataSource = Nothing
                                MsgBox("Data tidak Ditemukan", MsgBoxStyle.Information, "Information")
                            Else
                                DataGridView1.AutoGenerateColumns = False
                                DataGridView1.DataSource = dt
                            End If
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            If TextBox1.Text = "" Then
                MsgBox("Parameter tidak boleh kosong", MsgBoxStyle.Critical, "Info")
                TextBox1.Focus()
            Else
                Try
                    Call konek()
                    Using sql As New MySqlCommand("SELECT AKTIVA, NAMA, STATUS, BIAYA_PEROLEHAN, BBN_PENYUSUTAN_BLN_INI,JUMLAH_TERCATAT, KONDISI, POSISI,TGL_SO, PROGRES_BARANG FROM MASTER_DAT_AUP where " & ComboBox1.Text & " like '%" & TextBox1.Text & "%'", conn)
                        Using dr As MySqlDataReader = sql.ExecuteReader()
                            Using dt As New DataTable
                                dt.Load(dr)
                                If dt.Rows.Count = 0 Then
                                    'DataGridView1.DataSource = Nothing
                                    MsgBox("Data tidak Ditemukan", MsgBoxStyle.Information, "Information")
                                Else
                                    DataGridView1.AutoGenerateColumns = False
                                    DataGridView1.DataSource = dt
                                End If
                            End Using
                        End Using
                    End Using
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    conn.Close()
                End Try
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        searchIndex = -1
    End Sub
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If DataGridView1.RowCount > 0 Then
            Dim baris As Integer
            With DataGridView1
                baris = .CurrentRow.Index
                FrmupdateAUP.Show()
                FrmupdateAUP.Label2.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(0).Value
                FrmupdateAUP.Button1.Text = "SimpanAUP"
            End With
        End If
    End Sub
End Class