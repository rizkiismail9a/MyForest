<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutUs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutUs))
        Label1 = New Label()
        Label2 = New Label()
        ListBox1 = New ListBox()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 9F)
        Label1.Location = New Point(12, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(935, 204)
        Label1.TabIndex = 0
        Label1.Text = resources.GetString("Label1.Text")
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 280)
        Label2.Name = "Label2"
        Label2.Size = New Size(341, 32)
        Label2.TabIndex = 1
        Label2.Text = "Dibuat oleh kelompok 7 IF103:"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Items.AddRange(New Object() {"Muhamad Rizki Ismail (NIM: 240401010126)", "Rizqy Fatih Al Ghifari (NIM: 240401010123)", "Mas’ud Dwi Haryanto (NIM: 240401020078)", "D", "E"})
        ListBox1.Location = New Point(12, 315)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(935, 356)
        ListBox1.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F)
        Label3.Location = New Point(12, 236)
        Label3.Name = "Label3"
        Label3.Size = New Size(736, 32)
        Label3.TabIndex = 3
        Label3.Text = "Aplikasi ini dibuat untuk memenuhi tugas UAS Pemrograman Visual"
        ' 
        ' AboutUs
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(959, 683)
        Controls.Add(Label3)
        Controls.Add(ListBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "AboutUs"
        Text = "AboutUs"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label3 As Label
End Class
