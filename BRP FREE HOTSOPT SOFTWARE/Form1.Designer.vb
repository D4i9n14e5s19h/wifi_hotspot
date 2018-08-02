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
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.showchkbox = New System.Windows.Forms.CheckBox()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.hotspot = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.stophotspot = New System.Windows.Forms.Button()
        Me.start = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.White
        Me.RichTextBox1.Location = New System.Drawing.Point(559, 195)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(253, 230)
        Me.RichTextBox1.TabIndex = 17
        Me.RichTextBox1.Text = ""
        '
        'showchkbox
        '
        Me.showchkbox.AutoSize = True
        Me.showchkbox.Location = New System.Drawing.Point(14, 124)
        Me.showchkbox.Name = "showchkbox"
        Me.showchkbox.Size = New System.Drawing.Size(114, 19)
        Me.showchkbox.TabIndex = 4
        Me.showchkbox.Text = "Show Password"
        Me.showchkbox.UseVisualStyleBackColor = True
        '
        'pass
        '
        Me.pass.Location = New System.Drawing.Point(14, 97)
        Me.pass.Name = "pass"
        Me.pass.Size = New System.Drawing.Size(231, 21)
        Me.pass.TabIndex = 1
        Me.pass.UseSystemPasswordChar = True
        '
        'hotspot
        '
        Me.hotspot.Location = New System.Drawing.Point(14, 48)
        Me.hotspot.Name = "hotspot"
        Me.hotspot.Size = New System.Drawing.Size(231, 21)
        Me.hotspot.TabIndex = 0
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(11, 75)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(194, 15)
        Me.Label28.TabIndex = 1
        Me.Label28.Text = "Password: (Minimum 8 Character)"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(256, 45)
        Me.Panel1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label2.Location = New System.Drawing.Point(35, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "BRP Hotspot Software"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.showchkbox)
        Me.GroupBox3.Controls.Add(Me.hotspot)
        Me.GroupBox3.Controls.Add(Me.pass)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(2, 53)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(256, 155)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Hotspot Information"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(11, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Hotspot Name :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.stophotspot)
        Me.GroupBox2.Controls.Add(Me.start)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(2, 207)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(256, 61)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'stophotspot
        '
        Me.stophotspot.BackColor = System.Drawing.SystemColors.Control
        Me.stophotspot.Cursor = System.Windows.Forms.Cursors.Hand
        Me.stophotspot.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.stophotspot.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.stophotspot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.stophotspot.ForeColor = System.Drawing.Color.Black
        Me.stophotspot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.stophotspot.Location = New System.Drawing.Point(156, 19)
        Me.stophotspot.Name = "stophotspot"
        Me.stophotspot.Size = New System.Drawing.Size(89, 28)
        Me.stophotspot.TabIndex = 1
        Me.stophotspot.Text = "&Stop"
        Me.stophotspot.UseVisualStyleBackColor = False
        '
        'start
        '
        Me.start.BackColor = System.Drawing.SystemColors.Control
        Me.start.Cursor = System.Windows.Forms.Cursors.Hand
        Me.start.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.start.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.start.ForeColor = System.Drawing.Color.Black
        Me.start.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.start.Location = New System.Drawing.Point(63, 19)
        Me.start.Name = "start"
        Me.start.Size = New System.Drawing.Size(89, 28)
        Me.start.TabIndex = 0
        Me.start.Text = "&Start"
        Me.start.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(60, 272)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Developed By : Bishworaj Poudel"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(260, 295)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "BRP Free Hotspot Software V.1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents showchkbox As System.Windows.Forms.CheckBox
    Friend WithEvents pass As System.Windows.Forms.TextBox
    Friend WithEvents hotspot As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents stophotspot As System.Windows.Forms.Button
    Friend WithEvents start As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
