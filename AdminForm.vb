Imports System.Data.Odbc

Public Class AdminForm

    Dim idTree As Integer

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

    Private Sub SearchTree()
        Try
            Dim query = $"SELECT * FROM mytrees WHERE tree_code = '{InputCode.Text}'"
            cmd = New OdbcCommand(query, Conn)
            Rd = cmd.ExecuteReader
            Rd.Read()

            If Rd.HasRows Then
                InputName.Text = Rd.Item("name")
                InputCode.Text = Rd.Item("tree_code")
                InputSciName.Text = Rd.Item("scientific_name")
                InputTreeAmount.Text = Rd.Item("tree_amount")
                idTree = Rd.Item("id")
            Else
                MsgBox("Data tidak ditemukan", MsgBoxStyle.Exclamation, "Error")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
    End Sub

    Private Sub EditTree()
        Try
            Dim query = $"UPDATE mytrees SET name = '{InputName.Text}', scientific_name = '{InputSciName.Text}', tree_amount = '{InputTreeAmount.Text}', tree_code = '{InputCode.Text}' WHERE id = '{idTree}'"
            cmd = New OdbcCommand(query, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Diubah", MsgBoxStyle.Information, "Sukses")
            ClearData()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
    End Sub

    Private Sub RemoveTree()
        Try
            Dim confirm = MessageBox.Show("Apa Anda yakin menghapusnya?", "Peringatan", MessageBoxButtons.YesNo)

            If confirm = DialogResult.Yes Then
                Dim query = $"DELETE FROM mytrees WHERE tree_code = '{InputCode.Text}'"
                cmd = New OdbcCommand(query, Conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Dihapus", MsgBoxStyle.Information, "Sukses")
                ClearData()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
    End Sub


    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click

        If InputCode.Text = "" Or InputName.Text = "" Or InputSciName.Text = "" Or InputTreeAmount.Text = "" Then
            MsgBox("Harap isi semua field", MsgBoxStyle.Critical, "Error")
        Else
            AddTree()
        End If

    End Sub



    Private Sub InputTreeAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles InputTreeAmount.KeyPress

        ' Cegah user menginput selain angka
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True 'Beritahu sistem bahwa event sudah ditangani
        End If
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        If InputCode.Text = "" Or InputName.Text = "" Or InputSciName.Text = "" Or InputTreeAmount.Text = "" Then
            MsgBox("Harap isi semua field", MsgBoxStyle.Critical, "Error")
        Else
            EditTree()
        End If
    End Sub

    Private Sub InputCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles InputCode.KeyPress
        If e.KeyChar = Chr(13) Then
            SearchTree()
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If InputCode.Text = "" Or InputName.Text = "" Or InputSciName.Text = "" Or InputTreeAmount.Text = "" Then
            MsgBox("Harap isi semua field", MsgBoxStyle.Critical, "Error")
        Else
            RemoveTree()
        End If
    End Sub
End Class