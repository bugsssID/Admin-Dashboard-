Imports MySql.Data.MySqlClient
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Public Class CetakKKSOAUP

    Private Sub CetakKKSO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Then
            MsgBox("belum pilih kategori!", MsgBoxStyle.Critical, "info")
            Exit Sub
        End If
        Try
            Dim i, j As Integer

            Dim xlApp As Excel.Application
            Dim xlWorkBook As Excel.Workbook
            Dim xlWorkSheet As Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value

            xlApp = New Excel.Application
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.Sheets("sheet1")

            konek()
            str = "SELECT NAMA,GOL,JUMLAH_TERCATAT,COUNT(NAMA) AS NAMA  FROM master_dat_aup where GOL='" & ComboBox1.Text & "' GROUP BY NAMA;"
            Dim da As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            da.Fill(ds)

            For i = 0 To ds.Tables(0).Rows.Count - 1
                For j = 0 To ds.Tables(0).Columns.Count - 1
                    xlWorkSheet.Cells(i + 1, j + 1) = _
                    ds.Tables(0).Rows(i).Item(j)
                Next
            Next
            xlWorkSheet.SaveAs("C:\KKSO" & Format(Now, "yyyyMM") & ".xlsx")
            xlWorkBook.Close()
            xlApp.Quit()
            MsgBox("File KKSO Tersimpan ke C:\KKSO" & Format(Now, "yyyyMM") & ".xlsx")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class