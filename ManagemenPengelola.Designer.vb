<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManagemenPengelola
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManagemenPengelola))
        RefreshButton = New Button()
        DataPengelola = New DataGridView()
        Label1 = New Label()
        CType(DataPengelola, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' RefreshButton
        ' 
        RefreshButton.Location = New Point(342, 497)
        RefreshButton.Margin = New Padding(4, 2, 4, 2)
        RefreshButton.Name = "RefreshButton"
        RefreshButton.Size = New Size(201, 62)
        RefreshButton.TabIndex = 8
        RefreshButton.Text = "Refresh"
        RefreshButton.UseVisualStyleBackColor = True
        ' 
        ' DataPengelola
        ' 
        DataPengelola.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataPengelola.Location = New Point(20, 143)
        DataPengelola.Margin = New Padding(4, 2, 4, 2)
        DataPengelola.Name = "DataPengelola"
        DataPengelola.RowHeadersWidth = 82
        DataPengelola.Size = New Size(843, 324)
        DataPengelola.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 13.875F)
        Label1.Location = New Point(254, 19)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(403, 42)
        Label1.TabIndex = 5
        Label1.Text = "Managemen Pengelola"
        ' 
        ' ManagemenPengelola
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(884, 582)
        Controls.Add(RefreshButton)
        Controls.Add(DataPengelola)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(6, 6, 6, 6)
        Name = "ManagemenPengelola"
        Text = "Form2"
        CType(DataPengelola, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents RefreshButton As Button
    Friend WithEvents DataPengelola As DataGridView
    Friend WithEvents Label1 As Label
End Class
