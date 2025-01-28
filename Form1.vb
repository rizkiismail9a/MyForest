Imports System.Data.Odbc

Public Class Form1
    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
        LoginForm.isFromManagement = False

        If LoginForm.isLoggedIn = True Then
            AdminForm.Show()
        Else
            LoginForm.Show()
        End If

    End Sub

    Private Sub SearchTree()
        Try
            Dim query = $"SELECT * FROM mytrees WHERE name LIKE '%{InputSearch.Text}%'"

            Da = New OdbcDataAdapter(query, Conn)
            Ds = New DataSet()
            Ds.Clear()
            Da.Fill(Ds, "mytrees")
            MyTreeTable.DataSource = Ds.Tables("mytrees")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

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
        InputSearch.Text = ""
    End Sub

    Private Sub AboutThisAppToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutThisAppToolStripMenuItem.Click
        AboutUs.Show()
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        SearchTree()
    End Sub

    Private Sub PengelolaToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles PengelolaToolStripMenuItem.Click
        LoginForm.isFromManagement = True

        If LoginForm.isLoggedIn = True Then
            ManagemenPengelola.Show()
        Else
            LoginForm.Show()
        End If
    End Sub
End Class