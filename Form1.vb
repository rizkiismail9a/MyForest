Imports System.Data.Odbc

Public Class Form1
    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
        If LoginForm.isLoggedIn = True Then
            AdminForm.Show()
        Else
            LoginForm.Show()
        End If

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

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        ViewData()
    End Sub

    Private Sub AboutThisAppToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutThisAppToolStripMenuItem.Click
        AboutUs.Show()
    End Sub
End Class