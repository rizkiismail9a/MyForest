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
        RefreshButton = New Button()
        DataPengelola = New DataGridView()
        Label1 = New Label()
        CType(DataPengelola, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' RefreshButton
        ' 
        RefreshButton.Location = New Point(184, 233)
        RefreshButton.Margin = New Padding(2, 1, 2, 1)
        RefreshButton.Name = "RefreshButton"
        RefreshButton.Size = New Size(108, 29)
        RefreshButton.TabIndex = 8
        RefreshButton.Text = "Refresh"
        RefreshButton.UseVisualStyleBackColor = True
        ' 
        ' DataPengelola
        ' 
        DataPengelola.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataPengelola.Location = New Point(11, 67)
        DataPengelola.Margin = New Padding(2, 1, 2, 1)
        DataPengelola.Name = "DataPengelola"
        DataPengelola.RowHeadersWidth = 82
        DataPengelola.Size = New Size(454, 152)
        DataPengelola.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 13.875F)
        Label1.Location = New Point(137, 9)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(207, 24)
        Label1.TabIndex = 5
        Label1.Text = "Managemen Pengelola"
        ' 
        ' ManagemenPengelola
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(476, 273)
        Controls.Add(RefreshButton)
        Controls.Add(DataPengelola)
        Controls.Add(Label1)
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
