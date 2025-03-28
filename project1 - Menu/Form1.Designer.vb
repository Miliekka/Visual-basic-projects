<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        ColorDialog1 = New ColorDialog()
        FontDialog1 = New FontDialog()
        OpenFileDialog1 = New OpenFileDialog()
        PrintDialog1 = New PrintDialog()
        MenuStrip1 = New MenuStrip()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        OpenFileToolStripMenuItem = New ToolStripMenuItem()
        CloseFileToolStripMenuItem = New ToolStripMenuItem()
        FontToolStripMenuItem = New ToolStripMenuItem()
        PrinterToolStripMenuItem = New ToolStripMenuItem()
        ColorToolStripMenuItem = New ToolStripMenuItem()
        ServiceToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {ToolStripMenuItem1})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 6
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {ServiceToolStripMenuItem, OpenFileToolStripMenuItem, CloseFileToolStripMenuItem, FontToolStripMenuItem, PrinterToolStripMenuItem, ColorToolStripMenuItem})
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(56, 20)
        ToolStripMenuItem1.Text = "Service"
        ' 
        ' OpenFileToolStripMenuItem
        ' 
        OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem"
        OpenFileToolStripMenuItem.Size = New Size(180, 22)
        OpenFileToolStripMenuItem.Text = "Open File"
        ' 
        ' CloseFileToolStripMenuItem
        ' 
        CloseFileToolStripMenuItem.Name = "CloseFileToolStripMenuItem"
        CloseFileToolStripMenuItem.Size = New Size(180, 22)
        CloseFileToolStripMenuItem.Text = "Close File"
        ' 
        ' FontToolStripMenuItem
        ' 
        FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        FontToolStripMenuItem.Size = New Size(180, 22)
        FontToolStripMenuItem.Text = "Font"
        ' 
        ' PrinterToolStripMenuItem
        ' 
        PrinterToolStripMenuItem.Name = "PrinterToolStripMenuItem"
        PrinterToolStripMenuItem.Size = New Size(180, 22)
        PrinterToolStripMenuItem.Text = "Printer"
        ' 
        ' ColorToolStripMenuItem
        ' 
        ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        ColorToolStripMenuItem.Size = New Size(180, 22)
        ColorToolStripMenuItem.Text = "Color"
        ' 
        ' ServiceToolStripMenuItem
        ' 
        ServiceToolStripMenuItem.Name = "ServiceToolStripMenuItem"
        ServiceToolStripMenuItem.Size = New Size(180, 22)
        ServiceToolStripMenuItem.Text = "Service"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 414)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OpenFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrinterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServiceToolStripMenuItem As ToolStripMenuItem

End Class
