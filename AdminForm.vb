Imports System.Data.Odbc

Public Class AdminForm

    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InputCode.Focus()
    End Sub

    Private Sub AddTree()
        Try
            Dim query = $"INSERT INTO mytrees (name, scientific_name, tree_amount, tree_code) VALUES ('{InputName.Text}', '{InputSciName.Text}', '{InputTreeAmount.Text}', '{InputCode.Text}')"
            cmd = New OdbcCommand(query, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Ditambahkan", MsgBoxStyle.Information, "Sukses")
            ClearData()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ClearData()
        InputCode.Text = ""
        InputName.Text = ""
        InputSciName.Text = ""
        InputTreeAmount.Text = ""
    End Sub


    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click

        If InputCode.Text = "" Or InputName.Text = "" Or InputSciName.Text = "" Or InputTreeAmount.Text = "" Then
            MsgBox("Harap isi semua field", MsgBoxStyle.Critical, "Error")
        Else
            AddTree()
        End If

    End Sub

    Private Sub InputTreeAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles InputTreeAmount.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True 'Beritahu sistem bahwa event sudah ditangani
        End If
    End Sub
End Class