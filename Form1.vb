Imports System.Net
Imports MySql.Data.MySqlClient
Public Class Form1
    Public Shared Function GetIPAddress() As String
        Dim str2 As String = New IPAddress(Dns.GetHostByName(Dns.GetHostName).AddressList(0).Address).ToString
        Return str2
    End Function
    'Sub tampildb()
    '    konek()
    '    cmd = New MySqlCommand("SELECT DISTINCT TABLE_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_SCHEMA='absen_dc' ORDER BY TABLE_NAME ASC;", conn)
    '    da = New MySqlDataAdapter(cmd)
    '    Dim dt As New DataTable
    '    da.Fill(dt)
    '    For i As Integer = 0 To dt.Rows.Count - 1
    '        With ListView1
    '            .Items.Add(dt.Rows(i)("TABLE_NAME"))
    '        End With
    '    Next
    'End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.disablemenu()
        'Me.tampildb()
        Me.Text = "Application DC " & "[IP : " & GetIPAddress() & "]" & " Versi : " & Application.ProductVersion
    End Sub

    Private Sub ABSENToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABSENToolStripMenuItem.Click
        AbsenDC.Show()
    End Sub
    Sub disablemenu()
        ABSENToolStripMenuItem.Enabled = False
        PBATKToolStripMenuItem.Enabled = False
        LAPORANToolStripMenuItem.Enabled = False
    End Sub
    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        LoginFrm.Show()
    End Sub

    Private Sub MasterTokoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterTokoToolStripMenuItem.Click
        Toko.Show()
    End Sub

    Private Sub REPORTBARANGAKTIVAAUPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REPORTBARANGAKTIVAAUPToolStripMenuItem.Click
        Frmbrgaktiva.Show()
    End Sub

    Private Sub REPORTBARANGNONAKTIVAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REPORTBARANGNONAKTIVAToolStripMenuItem.Click
        FrmbarangNonAktiva.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = "LAST UPDATE DATA : " & Format(Now, "yyyy-MM-dd" & " K " & " hh:mm:ss")
    End Sub

    Private Sub CetakQtyPeritemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CetakQtyPeritemToolStripMenuItem.Click
        CetakKKSOAUP.Show()
    End Sub

    Private Sub LISTINGSURATJALANSJToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LISTINGSURATJALANSJToolStripMenuItem.Click
        FrmSJ.ShowDialog()
    End Sub

    Private Sub REPORTBARANGDCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REPORTBARANGDCToolStripMenuItem.Click
        FrmbarangaktivaDC.Show()
    End Sub
End Class
