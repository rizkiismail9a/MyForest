Imports System.Data.Odbc

Public Class LoginForm

    Public isLoggedIn As Boolean

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Try
            If InputUsername.Text = "" Or InputPassword.Text = "" Then
                MsgBox("Isi semua inputan terlebih dahulut", MsgBoxStyle.Critical, "Error")
            End If

            Connect()
            Dim query = $"SELECT *  FROM admin WHERE username = '{InputUsername.Text}'"
            cmd = New OdbcCommand(query, Conn)
            cmd.ExecuteNonQuery()

            Rd = cmd.ExecuteReader
            Rd.Read()

            If Rd.HasRows Then
                If InputPassword.Text = Rd.Item("password") Then
                    AdminForm.Show()
                    Me.Close()
                Else
                    MsgBox("Kata Sandi Salah", MsgBoxStyle.Critical, "Error")
                End If
            Else
                MsgBox("User Tidak Ditemukan", MsgBoxStyle.Exclamation, "Error")
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class