<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class auton
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(auton))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radMove = New System.Windows.Forms.RadioButton()
        Me.radNoMove = New System.Windows.Forms.RadioButton()
        Me.autonomous = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnAddHighAuto = New System.Windows.Forms.Button()
        Me.btnSubHighAuto = New System.Windows.Forms.Button()
        Me.txtHighAuto = New System.Windows.Forms.TextBox()
        Me.btnAddLowAuto = New System.Windows.Forms.Button()
        Me.btnSubLowAuto = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLowAuto = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnAddExtra = New System.Windows.Forms.Button()
        Me.btnExtraSubLow = New System.Windows.Forms.Button()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkTrench = New System.Windows.Forms.CheckBox()
        Me.chkRend = New System.Windows.Forms.CheckBox()
        Me.txtExtraBalls = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtTeamNumber = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radMove)
        Me.GroupBox1.Controls.Add(Me.radNoMove)
        Me.GroupBox1.Location = New System.Drawing.Point(249, 276)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(138, 93)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Initiation Line"
        '
        'radMove
        '
        Me.radMove.AutoSize = True
        Me.radMove.Location = New System.Drawing.Point(7, 49)
        Me.radMove.Name = "radMove"
        Me.radMove.Size = New System.Drawing.Size(71, 21)
        Me.radMove.TabIndex = 2
        Me.radMove.Text = "Moved"
        Me.radMove.UseVisualStyleBackColor = True
        '
        'radNoMove
        '
        Me.radNoMove.AutoSize = True
        Me.radNoMove.Checked = True
        Me.radNoMove.Location = New System.Drawing.Point(6, 21)
        Me.radNoMove.Name = "radNoMove"
        Me.radNoMove.Size = New System.Drawing.Size(112, 21)
        Me.radNoMove.TabIndex = 1
        Me.radNoMove.TabStop = True
        Me.radNoMove.Text = "Did not move"
        Me.radNoMove.UseVisualStyleBackColor = True
        '
        'autonomous
        '
        Me.autonomous.AutoSize = True
        Me.autonomous.Font = New System.Drawing.Font("Segoe MDL2 Assets", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.autonomous.Location = New System.Drawing.Point(146, 15)
        Me.autonomous.Name = "autonomous"
        Me.autonomous.Size = New System.Drawing.Size(201, 43)
        Me.autonomous.TabIndex = 1
        Me.autonomous.Text = "Autonomous"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnAddHighAuto)
        Me.GroupBox2.Controls.Add(Me.btnSubHighAuto)
        Me.GroupBox2.Controls.Add(Me.txtHighAuto)
        Me.GroupBox2.Controls.Add(Me.btnAddLowAuto)
        Me.GroupBox2.Controls.Add(Me.btnSubLowAuto)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtLowAuto)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 87)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 428)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Power Cells"
        '
        'btnAddHighAuto
        '
        Me.btnAddHighAuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddHighAuto.Location = New System.Drawing.Point(135, 69)
        Me.btnAddHighAuto.Name = "btnAddHighAuto"
        Me.btnAddHighAuto.Size = New System.Drawing.Size(51, 52)
        Me.btnAddHighAuto.TabIndex = 7
        Me.btnAddHighAuto.Text = "+"
        Me.btnAddHighAuto.UseVisualStyleBackColor = True
        '
        'btnSubHighAuto
        '
        Me.btnSubHighAuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubHighAuto.Location = New System.Drawing.Point(7, 69)
        Me.btnSubHighAuto.Name = "btnSubHighAuto"
        Me.btnSubHighAuto.Size = New System.Drawing.Size(49, 52)
        Me.btnSubHighAuto.TabIndex = 6
        Me.btnSubHighAuto.Text = "-"
        Me.btnSubHighAuto.UseVisualStyleBackColor = True
        '
        'txtHighAuto
        '
        Me.txtHighAuto.Location = New System.Drawing.Point(62, 82)
        Me.txtHighAuto.Name = "txtHighAuto"
        Me.txtHighAuto.ReadOnly = True
        Me.txtHighAuto.Size = New System.Drawing.Size(67, 22)
        Me.txtHighAuto.TabIndex = 5
        Me.txtHighAuto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAddLowAuto
        '
        Me.btnAddLowAuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddLowAuto.Location = New System.Drawing.Point(135, 303)
        Me.btnAddLowAuto.Name = "btnAddLowAuto"
        Me.btnAddLowAuto.Size = New System.Drawing.Size(51, 56)
        Me.btnAddLowAuto.TabIndex = 4
        Me.btnAddLowAuto.Text = "+"
        Me.btnAddLowAuto.UseVisualStyleBackColor = True
        '
        'btnSubLowAuto
        '
        Me.btnSubLowAuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubLowAuto.Location = New System.Drawing.Point(8, 305)
        Me.btnSubLowAuto.Name = "btnSubLowAuto"
        Me.btnSubLowAuto.Size = New System.Drawing.Size(49, 54)
        Me.btnSubLowAuto.TabIndex = 3
        Me.btnSubLowAuto.Text = "-"
        Me.btnSubLowAuto.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "High Goal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 284)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Low Goal"
        '
        'txtLowAuto
        '
        Me.txtLowAuto.Location = New System.Drawing.Point(62, 320)
        Me.txtLowAuto.Name = "txtLowAuto"
        Me.txtLowAuto.ReadOnly = True
        Me.txtLowAuto.Size = New System.Drawing.Size(67, 22)
        Me.txtLowAuto.TabIndex = 0
        Me.txtLowAuto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnAddExtra)
        Me.GroupBox3.Controls.Add(Me.btnExtraSubLow)
        Me.GroupBox3.Controls.Add(Me.chkTrench)
        Me.GroupBox3.Controls.Add(Me.chkRend)
        Me.GroupBox3.Controls.Add(Me.txtExtraBalls)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(249, 87)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(356, 170)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Extra"
        '
        'btnAddExtra
        '
        Me.btnAddExtra.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddExtra.Location = New System.Drawing.Point(167, 49)
        Me.btnAddExtra.Name = "btnAddExtra"
        Me.btnAddExtra.Size = New System.Drawing.Size(55, 43)
        Me.btnAddExtra.TabIndex = 7
        Me.btnAddExtra.Text = "+"
        Me.btnAddExtra.UseVisualStyleBackColor = True
        '
        'btnExtraSubLow
        '
        Me.btnExtraSubLow.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExtraSubLow.Location = New System.Drawing.Point(27, 49)
        Me.btnExtraSubLow.Name = "btnExtraSubLow"
        Me.btnExtraSubLow.Size = New System.Drawing.Size(51, 43)
        Me.btnExtraSubLow.TabIndex = 6
        Me.btnExtraSubLow.Text = "-"
        Me.btnExtraSubLow.UseVisualStyleBackColor = True
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(625, 42)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(279, 359)
        Me.txtNotes.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(622, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Notes"
        '
        'chkTrench
        '
        Me.chkTrench.AutoSize = True
        Me.chkTrench.Location = New System.Drawing.Point(198, 124)
        Me.chkTrench.Name = "chkTrench"
        Me.chkTrench.Size = New System.Drawing.Size(141, 21)
        Me.chkTrench.TabIndex = 3
        Me.chkTrench.Text = "Trench Run Grab"
        Me.chkTrench.UseVisualStyleBackColor = True
        '
        'chkRend
        '
        Me.chkRend.AutoSize = True
        Me.chkRend.Location = New System.Drawing.Point(7, 124)
        Me.chkRend.Name = "chkRend"
        Me.chkRend.Size = New System.Drawing.Size(138, 21)
        Me.chkRend.TabIndex = 2
        Me.chkRend.Text = "Rendevouz Grab"
        Me.chkRend.UseVisualStyleBackColor = True
        '
        'txtExtraBalls
        '
        Me.txtExtraBalls.Location = New System.Drawing.Point(91, 59)
        Me.txtExtraBalls.Name = "txtExtraBalls"
        Me.txtExtraBalls.ReadOnly = True
        Me.txtExtraBalls.Size = New System.Drawing.Size(62, 22)
        Me.txtExtraBalls.TabIndex = 1
        Me.txtExtraBalls.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Extra Balls Grabbed"
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(249, 407)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(655, 85)
        Me.btnSubmit.TabIndex = 4
        Me.btnSubmit.Text = "SUBMIT"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txtTeamNumber
        '
        Me.txtTeamNumber.Font = New System.Drawing.Font("Segoe MDL2 Assets", 25.8!)
        Me.txtTeamNumber.Location = New System.Drawing.Point(476, 12)
        Me.txtTeamNumber.Name = "txtTeamNumber"
        Me.txtTeamNumber.ReadOnly = True
        Me.txtTeamNumber.Size = New System.Drawing.Size(100, 50)
        Me.txtTeamNumber.TabIndex = 12
        Me.txtTeamNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.Label5.Location = New System.Drawing.Point(413, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Team:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(20, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 382)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'auton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 503)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTeamNumber)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.autonomous)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(950, 550)
        Me.MinimumSize = New System.Drawing.Size(950, 550)
        Me.Name = "auton"
        Me.Text = "Autonomous"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radMove As RadioButton
    Friend WithEvents radNoMove As RadioButton
    Friend WithEvents autonomous As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLowAuto As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtExtraBalls As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents chkTrench As CheckBox
    Friend WithEvents chkRend As CheckBox
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnAddLowAuto As Button
    Friend WithEvents btnSubLowAuto As Button
    Friend WithEvents btnExtraSubLow As Button
    Friend WithEvents btnAddExtra As Button
    Friend WithEvents btnSubHighAuto As Button
    Friend WithEvents txtHighAuto As TextBox
    Friend WithEvents btnAddHighAuto As Button
    Friend WithEvents txtTeamNumber As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
