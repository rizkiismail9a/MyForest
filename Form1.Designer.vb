<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        MenuStrip1 = New MenuStrip()
        AdminToolStripMenuItem = New ToolStripMenuItem()
        AboutThisAppToolStripMenuItem = New ToolStripMenuItem()
        PengelolaToolStripMenuItem = New ToolStripMenuItem()
        MyTreeTable = New DataGridView()
        RefreshButton = New Button()
        Panel1 = New Panel()
        SearchButton = New Button()
        InputSearch = New TextBox()
        RegisterToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        CType(MyTreeTable, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 13.875F)
        Label1.Location = New Point(439, 54)
        Label1.Name = "Label1"
        Label1.Size = New Size(434, 42)
        Label1.TabIndex = 0
        Label1.Text = "Managemen Data Pohon"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold)
        Label2.Location = New Point(522, 117)
        Label2.Name = "Label2"
        Label2.Size = New Size(246, 55)
        Label2.TabIndex = 1
        Label2.Text = "My Forest"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(32, 32)
        MenuStrip1.Items.AddRange(New ToolStripItem() {AdminToolStripMenuItem, AboutThisAppToolStripMenuItem, PengelolaToolStripMenuItem, RegisterToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1347, 42)
        MenuStrip1.TabIndex = 2
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' AdminToolStripMenuItem
        ' 
        AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        AdminToolStripMenuItem.Size = New Size(104, 38)
        AdminToolStripMenuItem.Text = "Admin"
        ' 
        ' AboutThisAppToolStripMenuItem
        ' 
        AboutThisAppToolStripMenuItem.Name = "AboutThisAppToolStripMenuItem"
        AboutThisAppToolStripMenuItem.Size = New Size(199, 38)
        AboutThisAppToolStripMenuItem.Text = "About This App"
        ' 
        ' PengelolaToolStripMenuItem
        ' 
        PengelolaToolStripMenuItem.Name = "PengelolaToolStripMenuItem"
        PengelolaToolStripMenuItem.Size = New Size(138, 38)
        PengelolaToolStripMenuItem.Text = "Pengelola"
        ' 
        ' MyTreeTable
        ' 
        MyTreeTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        MyTreeTable.Location = New Point(12, 300)
        MyTreeTable.Name = "MyTreeTable"
        MyTreeTable.RowHeadersWidth = 82
        MyTreeTable.Size = New Size(1323, 453)
        MyTreeTable.TabIndex = 3
        ' 
        ' RefreshButton
        ' 
        RefreshButton.Location = New Point(12, 248)
        RefreshButton.Name = "RefreshButton"
        RefreshButton.Size = New Size(150, 46)
        RefreshButton.TabIndex = 4
        RefreshButton.Text = "Refresh Table"
        RefreshButton.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.trees
        Panel1.BackgroundImageLayout = ImageLayout.Zoom
        Panel1.Location = New Point(181, 99)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(305, 294)
        Panel1.TabIndex = 5
        ' 
        ' SearchButton
        ' 
        SearchButton.Location = New Point(955, 248)
        SearchButton.Margin = New Padding(4)
        SearchButton.Name = "SearchButton"
        SearchButton.Size = New Size(127, 40)
        SearchButton.TabIndex = 8
        SearchButton.Text = "Search"
        SearchButton.UseVisualStyleBackColor = True
        ' 
        ' InputSearch
        ' 
        InputSearch.Location = New Point(1091, 248)
        InputSearch.Margin = New Padding(4)
        InputSearch.Name = "InputSearch"
        InputSearch.Size = New Size(243, 39)
        InputSearch.TabIndex = 7
        ' 
        ' RegisterToolStripMenuItem
        ' 
        RegisterToolStripMenuItem.Name = "RegisterToolStripMenuItem"
        RegisterToolStripMenuItem.Size = New Size(119, 38)
        RegisterToolStripMenuItem.Text = "Register"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(138), CByte(251), CByte(143))
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(1347, 765)
        Controls.Add(SearchButton)
        Controls.Add(InputSearch)
        Controls.Add(RefreshButton)
        Controls.Add(MyTreeTable)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        Controls.Add(Panel1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.FixedSingle
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "My Forest"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(MyTreeTable, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MyTreeTable As DataGridView
    Friend WithEvents RefreshButton As Button
    Friend WithEvents AboutThisAppToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SearchButton As Button
    Friend WithEvents InputSearch As TextBox
    Friend WithEvents PengelolaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegisterToolStripMenuItem As ToolStripMenuItem


End Class
