Imports System.Data.Odbc

Public Class Form1
    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
        LoginForm.Show()
    End Sub

    'Koneksi ke database
    Private Sub ViewData()
        Connect()
        Da = New OdbcDataAdapter("Select * from mytrees", Conn)
        Ds = New DataSet()
        Ds.Clear()
        Da.Fill(Ds, "mytrees")
        MyTreeTable.DataSource = Ds.Tables("mytrees")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ViewData()
    End Sub
End Class