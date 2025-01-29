Imports System.Data.Odbc

Public Class RegisterForm

    Private Sub RegisterUser()
        Try
            If InputUsername.Text = "" Or InputPassword.Text = "" Or InputEmail.Text = "" Or InputFullname.Text = "" Then
                MsgBox("Harap isi semua field", MsgBoxStyle.Critical, "Error")
                Exit Sub
            End If

            Dim query = $"INSERT INTO admin (username, password, email, name) VALUES ('{InputUsername.Text}', '{InputPassword.Text}', '{InputEmail.Text}', '{InputFullname.Text}')"
            cmd = New OdbcCommand(query, Conn)
            cmd.ExecuteNonQuery()

            MsgBox("Registrasi Berhasil! Silakan Login untuk memulai input data.", MsgBoxStyle.Information, "Sukses")

            Me.Close()

            LoginForm.redirect = AdminForm

            LoginForm.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        RegisterUser()
    End Sub

End Class
