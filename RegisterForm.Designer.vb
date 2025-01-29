<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
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
        Label5 = New Label()
        InputUsername = New TextBox()
        InputPassword = New TextBox()
        InputEmail = New TextBox()
        InputFullname = New TextBox()
        RegisterButton = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(502, 86)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(176, 32)
        Label1.TabIndex = 0
        Label1.Text = "Form Registrasi"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(223, 194)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(121, 32)
        Label2.TabIndex = 1
        Label2.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(223, 261)
        Label3.Margin = New Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(111, 32)
        Label3.TabIndex = 2
        Label3.Text = "Password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(223, 339)
        Label4.Margin = New Padding(5, 0, 5, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 32)
        Label4.TabIndex = 3
        Label4.Text = "Email"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(223, 413)
        Label5.Margin = New Padding(5, 0, 5, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(123, 32)
        Label5.TabIndex = 4
        Label5.Text = "Full Name"
        ' 
        ' InputUsername
        ' 
        InputUsername.Location = New Point(479, 194)
        InputUsername.Margin = New Padding(5)
        InputUsername.Name = "InputUsername"
        InputUsername.Size = New Size(363, 39)
        InputUsername.TabIndex = 5
        ' 
        ' InputPassword
        ' 
        InputPassword.Location = New Point(479, 261)
        InputPassword.Margin = New Padding(5)
        InputPassword.Name = "InputPassword"
        InputPassword.PasswordChar = "*"c
        InputPassword.Size = New Size(363, 39)
        InputPassword.TabIndex = 6
        ' 
        ' InputEmail
        ' 
        InputEmail.Location = New Point(479, 339)
        InputEmail.Margin = New Padding(5)
        InputEmail.Name = "InputEmail"
        InputEmail.Size = New Size(363, 39)
        InputEmail.TabIndex = 7
        ' 
        ' InputFullname
        ' 
        InputFullname.Location = New Point(479, 413)
        InputFullname.Margin = New Padding(5)
        InputFullname.Name = "InputFullname"
        InputFullname.Size = New Size(363, 39)
        InputFullname.TabIndex = 8
        ' 
        ' RegisterButton
        ' 
        RegisterButton.Location = New Point(479, 541)
        RegisterButton.Margin = New Padding(5)
        RegisterButton.Name = "RegisterButton"
        RegisterButton.Size = New Size(153, 46)
        RegisterButton.TabIndex = 9
        RegisterButton.Text = "Register"
        RegisterButton.UseVisualStyleBackColor = True
        ' 
        ' RegisterForm
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1064, 702)
        Controls.Add(RegisterButton)
        Controls.Add(InputFullname)
        Controls.Add(InputEmail)
        Controls.Add(InputPassword)
        Controls.Add(InputUsername)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(5)
        Name = "RegisterForm"
        Text = "RegisterButton"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents InputUsername As TextBox
    Friend WithEvents InputPassword As TextBox
    Friend WithEvents InputEmail As TextBox
    Friend WithEvents InputFullname As TextBox
    Friend WithEvents RegisterButton As Button
End Class
