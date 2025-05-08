Imports MySql.Data.MySqlClient
Module Module1
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dr As MySqlDataReader
    Public ds As DataSet
    Public dt As DataTable
    Public buil As MySqlCommandBuilder
    Public str As String
    Public tables As DataTableCollection
    Public source As New BindingSource
    Sub konek()
        Try
            Dim str As String = "Server=192.168.62.246;userid=bugs;password=262627;database=absen_dc;port=3308;default command timeout=0;Convert Zero Datetime=True;"
            conn = New MySqlConnection(str)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
