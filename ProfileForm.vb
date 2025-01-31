Imports System.Data.Odbc

Public Class ProfileForm
    Private Sub ProfileForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If LoginForm.isLoggedIn = True Then
            ' Mengambil data profil pengguna berdasarkan LoginForm.userId
            LoadProfile()
        Else
            MsgBox("Silakan login terlebih dahulu", MsgBoxStyle.Exclamation, "Error")
            Me.Close() ' Menutup form jika pengguna belum login
        End If
    End Sub

    Private Sub LoadProfile()
        Try
            ' Isi data profil ke TextBox
            InputUsername.Text = LoginForm.username
            InputEmail.Text = LoginForm.email
            InputFullname.Text = LoginForm.fullname

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub EditProfile()
        Try
            Dim query As String = "UPDATE admin SET username = ?, email = ?, name = ? WHERE id = ?"

            Using cmd As New OdbcCommand(query, Conn)
                cmd.Parameters.AddWithValue("?", InputUsername.Text)
                cmd.Parameters.AddWithValue("?", InputEmail.Text)
                cmd.Parameters.AddWithValue("?", InputFullname.Text)
                cmd.Parameters.AddWithValue("?", LoginForm.userId)

                cmd.ExecuteNonQuery()
                MsgBox("Profil berhasil diperbarui", MsgBoxStyle.Information, "Success")
            End Using

            LoginForm.username = InputUsername.Text
            LoginForm.email = InputEmail.Text
            LoginForm.fullname = InputFullname.Text

        Catch ex As Exception
            MsgBox("Terjadi kesalahan saat memperbarui profil: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        EditProfile()
    End Sub
End Class
