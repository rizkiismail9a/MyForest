<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        InputUsername = New TextBox()
        InputPassword = New TextBox()
        LoginButton = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(60, 145)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 32)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(60, 234)
        Label2.Name = "Label2"
        Label2.Size = New Size(111, 32)
        Label2.TabIndex = 1
        Label2.Text = "Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.Location = New Point(60, 47)
        Label3.Name = "Label3"
        Label3.Size = New Size(161, 32)
        Label3.TabIndex = 2
        Label3.Text = "Login Admin"
        ' 
        ' InputUsername
        ' 
        InputUsername.Location = New Point(265, 145)
        InputUsername.Name = "InputUsername"
        InputUsername.Size = New Size(393, 39)
        InputUsername.TabIndex = 3
        ' 
        ' InputPassword
        ' 
        InputPassword.Location = New Point(265, 231)
        InputPassword.Name = "InputPassword"
        InputPassword.PasswordChar = "*"c
        InputPassword.Size = New Size(393, 39)
        InputPassword.TabIndex = 4
        ' 
        ' LoginButton
        ' 
        LoginButton.Location = New Point(265, 341)
        LoginButton.Name = "LoginButton"
        LoginButton.Size = New Size(150, 46)
        LoginButton.TabIndex = 5
        LoginButton.Text = "Login"
        LoginButton.UseVisualStyleBackColor = True
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(LoginButton)
        Controls.Add(InputPassword)
        Controls.Add(InputUsername)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "LoginForm"
        Text = "LoginForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents InputUsername As TextBox
    Friend WithEvents InputPassword As TextBox
    Friend WithEvents LoginButton As Button
End Class
