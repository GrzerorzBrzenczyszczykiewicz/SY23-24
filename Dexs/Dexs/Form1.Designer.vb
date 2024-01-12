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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Field1 = New System.Windows.Forms.TextBox()
        Me.Field2 = New System.Windows.Forms.TextBox()
        Me.Field3 = New System.Windows.Forms.TextBox()
        Me.Field4 = New System.Windows.Forms.TextBox()
        Me.Field5 = New System.Windows.Forms.TextBox()
        Me.P1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.P1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(883, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.SaveToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(123, 26)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(123, 26)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(12, 31)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(859, 518)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(365, 49)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(188, 29)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.Text = "Slavic Country facts"
        '
        'Field1
        '
        Me.Field1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Field1.Location = New System.Drawing.Point(37, 105)
        Me.Field1.Multiline = True
        Me.Field1.Name = "Field1"
        Me.Field1.Size = New System.Drawing.Size(125, 34)
        Me.Field1.TabIndex = 3
        '
        'Field2
        '
        Me.Field2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Field2.Location = New System.Drawing.Point(37, 159)
        Me.Field2.Multiline = True
        Me.Field2.Name = "Field2"
        Me.Field2.Size = New System.Drawing.Size(125, 34)
        Me.Field2.TabIndex = 4
        '
        'Field3
        '
        Me.Field3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Field3.Location = New System.Drawing.Point(37, 207)
        Me.Field3.Multiline = True
        Me.Field3.Name = "Field3"
        Me.Field3.Size = New System.Drawing.Size(125, 34)
        Me.Field3.TabIndex = 5
        '
        'Field4
        '
        Me.Field4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Field4.Location = New System.Drawing.Point(37, 261)
        Me.Field4.Multiline = True
        Me.Field4.Name = "Field4"
        Me.Field4.Size = New System.Drawing.Size(125, 34)
        Me.Field4.TabIndex = 6
        '
        'Field5
        '
        Me.Field5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Field5.Location = New System.Drawing.Point(37, 318)
        Me.Field5.Multiline = True
        Me.Field5.Name = "Field5"
        Me.Field5.Size = New System.Drawing.Size(125, 34)
        Me.Field5.TabIndex = 7
        '
        'P1
        '
        Me.P1.Location = New System.Drawing.Point(388, 187)
        Me.P1.Name = "P1"
        Me.P1.Size = New System.Drawing.Size(125, 62)
        Me.P1.TabIndex = 8
        Me.P1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 561)
        Me.Controls.Add(Me.P1)
        Me.Controls.Add(Me.Field5)
        Me.Controls.Add(Me.Field4)
        Me.Controls.Add(Me.Field3)
        Me.Controls.Add(Me.Field2)
        Me.Controls.Add(Me.Field1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TextBox1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.P1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Field1 As TextBox
    Friend WithEvents Field2 As TextBox
    Friend WithEvents Field3 As TextBox
    Friend WithEvents Field4 As TextBox
    Friend WithEvents Field5 As TextBox
    Friend WithEvents P1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
