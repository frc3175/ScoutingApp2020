<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnStart = New System.Windows.Forms.Button()
        Me.matchList = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.blue3Rad = New System.Windows.Forms.RadioButton()
        Me.blue2Rad = New System.Windows.Forms.RadioButton()
        Me.blue1Rad = New System.Windows.Forms.RadioButton()
        Me.red3Rad = New System.Windows.Forms.RadioButton()
        Me.red2Rad = New System.Windows.Forms.RadioButton()
        Me.red1Rad = New System.Windows.Forms.RadioButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(12, 28)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(172, 57)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start Scouting!"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'matchList
        '
        Me.matchList.FormattingEnabled = True
        Me.matchList.ItemHeight = 16
        Me.matchList.Location = New System.Drawing.Point(228, 48)
        Me.matchList.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.matchList.Name = "matchList"
        Me.matchList.Size = New System.Drawing.Size(120, 260)
        Me.matchList.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(225, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select Match:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.blue3Rad)
        Me.GroupBox1.Controls.Add(Me.blue2Rad)
        Me.GroupBox1.Controls.Add(Me.blue1Rad)
        Me.GroupBox1.Controls.Add(Me.red3Rad)
        Me.GroupBox1.Controls.Add(Me.red2Rad)
        Me.GroupBox1.Controls.Add(Me.red1Rad)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 98)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(200, 215)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Assigned Scouting Position"
        '
        'blue3Rad
        '
        Me.blue3Rad.AutoSize = True
        Me.blue3Rad.Location = New System.Drawing.Point(7, 174)
        Me.blue3Rad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.blue3Rad.Name = "blue3Rad"
        Me.blue3Rad.Size = New System.Drawing.Size(69, 21)
        Me.blue3Rad.TabIndex = 5
        Me.blue3Rad.TabStop = True
        Me.blue3Rad.Text = "Blue 3"
        Me.blue3Rad.UseVisualStyleBackColor = True
        '
        'blue2Rad
        '
        Me.blue2Rad.AutoSize = True
        Me.blue2Rad.Location = New System.Drawing.Point(7, 146)
        Me.blue2Rad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.blue2Rad.Name = "blue2Rad"
        Me.blue2Rad.Size = New System.Drawing.Size(69, 21)
        Me.blue2Rad.TabIndex = 4
        Me.blue2Rad.TabStop = True
        Me.blue2Rad.Text = "Blue 2"
        Me.blue2Rad.UseVisualStyleBackColor = True
        '
        'blue1Rad
        '
        Me.blue1Rad.AutoSize = True
        Me.blue1Rad.Location = New System.Drawing.Point(7, 118)
        Me.blue1Rad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.blue1Rad.Name = "blue1Rad"
        Me.blue1Rad.Size = New System.Drawing.Size(69, 21)
        Me.blue1Rad.TabIndex = 3
        Me.blue1Rad.TabStop = True
        Me.blue1Rad.Text = "Blue 1"
        Me.blue1Rad.UseVisualStyleBackColor = True
        '
        'red3Rad
        '
        Me.red3Rad.AutoSize = True
        Me.red3Rad.Location = New System.Drawing.Point(7, 90)
        Me.red3Rad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.red3Rad.Name = "red3Rad"
        Me.red3Rad.Size = New System.Drawing.Size(67, 21)
        Me.red3Rad.TabIndex = 2
        Me.red3Rad.TabStop = True
        Me.red3Rad.Text = "Red 3"
        Me.red3Rad.UseVisualStyleBackColor = True
        '
        'red2Rad
        '
        Me.red2Rad.AutoSize = True
        Me.red2Rad.Location = New System.Drawing.Point(7, 62)
        Me.red2Rad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.red2Rad.Name = "red2Rad"
        Me.red2Rad.Size = New System.Drawing.Size(67, 21)
        Me.red2Rad.TabIndex = 1
        Me.red2Rad.TabStop = True
        Me.red2Rad.Text = "Red 2"
        Me.red2Rad.UseVisualStyleBackColor = True
        '
        'red1Rad
        '
        Me.red1Rad.AutoSize = True
        Me.red1Rad.Checked = True
        Me.red1Rad.Location = New System.Drawing.Point(7, 34)
        Me.red1Rad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.red1Rad.Name = "red1Rad"
        Me.red1Rad.Size = New System.Drawing.Size(67, 21)
        Me.red1Rad.TabIndex = 0
        Me.red1Rad.TabStop = True
        Me.red1Rad.Text = "Red 1"
        Me.red1Rad.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 333)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.matchList)
        Me.Controls.Add(Me.btnStart)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(390, 380)
        Me.MinimumSize = New System.Drawing.Size(390, 380)
        Me.Name = "Form1"
        Me.Text = "Infinite Recharge Scout"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStart As Button
    Friend WithEvents matchList As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents blue3Rad As RadioButton
    Friend WithEvents blue2Rad As RadioButton
    Friend WithEvents blue1Rad As RadioButton
    Friend WithEvents red3Rad As RadioButton
    Friend WithEvents red2Rad As RadioButton
    Friend WithEvents red1Rad As RadioButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
