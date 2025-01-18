<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        InputName = New TextBox()
        InputSciName = New TextBox()
        AddButton = New Button()
        EditButton = New Button()
        DeleteButton = New Button()
        Label5 = New Label()
        Label6 = New Label()
        InputCode = New TextBox()
        InputTreeAmount = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label1.Location = New Point(34, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(351, 32)
        Label1.TabIndex = 0
        Label1.Text = "Tambah atau Edit Data Pohon"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(34, 168)
        Label2.Name = "Label2"
        Label2.Size = New Size(152, 32)
        Label2.TabIndex = 1
        Label2.Text = "Nama Pohon"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(37, 258)
        Label3.Name = "Label3"
        Label3.Size = New Size(149, 32)
        Label3.TabIndex = 2
        Label3.Text = "Nama Ilmiah"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(34, 343)
        Label4.Name = "Label4"
        Label4.Size = New Size(165, 32)
        Label4.TabIndex = 3
        Label4.Text = "Jumlah Pohon"
        ' 
        ' InputName
        ' 
        InputName.Location = New Point(241, 168)
        InputName.Name = "InputName"
        InputName.Size = New Size(473, 39)
        InputName.TabIndex = 4
        ' 
        ' InputSciName
        ' 
        InputSciName.Location = New Point(241, 258)
        InputSciName.Name = "InputSciName"
        InputSciName.Size = New Size(473, 39)
        InputSciName.TabIndex = 5
        ' 
        ' AddButton
        ' 
        AddButton.Location = New Point(34, 458)
        AddButton.Name = "AddButton"
        AddButton.Size = New Size(221, 46)
        AddButton.TabIndex = 7
        AddButton.Text = "Tambah Pohon"
        AddButton.UseVisualStyleBackColor = True
        ' 
        ' EditButton
        ' 
        EditButton.Location = New Point(323, 458)
        EditButton.Name = "EditButton"
        EditButton.Size = New Size(221, 46)
        EditButton.TabIndex = 8
        EditButton.Text = "Edit Pohon"
        EditButton.UseVisualStyleBackColor = True
        ' 
        ' DeleteButton
        ' 
        DeleteButton.Location = New Point(609, 458)
        DeleteButton.Name = "DeleteButton"
        DeleteButton.Size = New Size(221, 46)
        DeleteButton.TabIndex = 9
        DeleteButton.Text = "Hapus Pohon"
        DeleteButton.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.Location = New Point(733, 80)
        Label5.Name = "Label5"
        Label5.Size = New Size(238, 226)
        Label5.TabIndex = 10
        Label5.Text = "untuk mengubah atau menghapus data, masukkan kode unik pohon lalu enter"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(34, 87)
        Label6.Name = "Label6"
        Label6.Size = New Size(143, 32)
        Label6.TabIndex = 11
        Label6.Text = "Kode Pohon"
        ' 
        ' InputCode
        ' 
        InputCode.Location = New Point(238, 80)
        InputCode.Name = "InputCode"
        InputCode.Size = New Size(473, 39)
        InputCode.TabIndex = 3
        ' 
        ' InputTreeAmount
        ' 
        InputTreeAmount.Location = New Point(238, 340)
        InputTreeAmount.Name = "InputTreeAmount"
        InputTreeAmount.Size = New Size(473, 39)
        InputTreeAmount.TabIndex = 6
        ' 
        ' AdminForm
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(992, 558)
        Controls.Add(InputCode)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(DeleteButton)
        Controls.Add(EditButton)
        Controls.Add(AddButton)
        Controls.Add(InputTreeAmount)
        Controls.Add(InputSciName)
        Controls.Add(InputName)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "AdminForm"
        Text = "AdminForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents InputName As TextBox
    Friend WithEvents InputSciName As TextBox
    Friend WithEvents AddButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents InputCode As TextBox
    Friend WithEvents InputTreeAmount As TextBox
End Class
