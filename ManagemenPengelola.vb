Imports System.Data.Odbc

Public Class ManagemenPengelola
    'Koneksi ke database
    Private Sub ViewData()
        Da = New OdbcDataAdapter("SELECT id, name, username, email FROM admin", Conn)
        Ds = New DataSet()
        Ds.Clear()
        Da.Fill(Ds, "admin")
        DataPengelola.DataSource = Ds.Tables("admin")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ViewData()
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        ViewData()
    End Sub

End Class