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
End Class
