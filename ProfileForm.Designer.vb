<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProfileForm
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProfileForm))
        Label1 = New Label()
        InputUsername = New TextBox()
        InputEmail = New TextBox()
        InputFullname = New TextBox()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        EditButton = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(481, 49)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 32)
        Label1.TabIndex = 0
        Label1.Text = "Profile"
        ' 
        ' InputUsername
        ' 
        InputUsername.Location = New Point(228, 182)
        InputUsername.Margin = New Padding(5)
        InputUsername.Name = "InputUsername"
        InputUsername.Size = New Size(599, 39)
        InputUsername.TabIndex = 1
        InputUsername.TextAlign = HorizontalAlignment.Center
        ' 
        ' InputEmail
        ' 
        InputEmail.Location = New Point(228, 270)
        InputEmail.Margin = New Padding(5)
        InputEmail.Name = "InputEmail"
        InputEmail.Size = New Size(599, 39)
        InputEmail.TabIndex = 2
        InputEmail.TextAlign = HorizontalAlignment.Center
        ' 
        ' InputFullname
        ' 
        InputFullname.Location = New Point(228, 347)
        InputFullname.Margin = New Padding(5)
        InputFullname.Name = "InputFullname"
        InputFullname.Size = New Size(599, 39)
        InputFullname.TabIndex = 3
        InputFullname.TextAlign = HorizontalAlignment.Center
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(32, 32)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' EditButton
        ' 
        EditButton.Location = New Point(442, 468)
        EditButton.Margin = New Padding(6, 4, 6, 4)
        EditButton.Name = "EditButton"
        EditButton.RightToLeft = RightToLeft.No
        EditButton.Size = New Size(152, 47)
        EditButton.TabIndex = 6
        EditButton.Text = "Edit"
        EditButton.UseVisualStyleBackColor = True
        ' 
        ' ProfileForm
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1060, 591)
        Controls.Add(EditButton)
        Controls.Add(InputFullname)
        Controls.Add(InputEmail)
        Controls.Add(InputUsername)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(5)
        Name = "ProfileForm"
        Text = "ProfileForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents InputUsername As TextBox
    Friend WithEvents InputEmail As TextBox
    Friend WithEvents InputFullname As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents EditButton As Button
End Class
