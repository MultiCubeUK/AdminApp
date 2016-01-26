<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.statusTB = New System.Windows.Forms.TextBox()
        Me.usernameTB = New System.Windows.Forms.TextBox()
        Me.PassTB = New System.Windows.Forms.TextBox()
        Me.LoginBTN = New System.Windows.Forms.Button()
        Me.CloseBTN = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'statusTB
        '
        Me.statusTB.Enabled = False
        Me.statusTB.Location = New System.Drawing.Point(12, 12)
        Me.statusTB.Multiline = True
        Me.statusTB.Name = "statusTB"
        Me.statusTB.Size = New System.Drawing.Size(423, 246)
        Me.statusTB.TabIndex = 0
        '
        'usernameTB
        '
        Me.usernameTB.Location = New System.Drawing.Point(6, 28)
        Me.usernameTB.Name = "usernameTB"
        Me.usernameTB.Size = New System.Drawing.Size(170, 20)
        Me.usernameTB.TabIndex = 1
        '
        'PassTB
        '
        Me.PassTB.Location = New System.Drawing.Point(6, 54)
        Me.PassTB.Name = "PassTB"
        Me.PassTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(63)
        Me.PassTB.Size = New System.Drawing.Size(170, 20)
        Me.PassTB.TabIndex = 2
        '
        'LoginBTN
        '
        Me.LoginBTN.Location = New System.Drawing.Point(6, 80)
        Me.LoginBTN.Name = "LoginBTN"
        Me.LoginBTN.Size = New System.Drawing.Size(75, 23)
        Me.LoginBTN.TabIndex = 3
        Me.LoginBTN.Text = "Login"
        Me.LoginBTN.UseVisualStyleBackColor = True
        '
        'CloseBTN
        '
        Me.CloseBTN.Location = New System.Drawing.Point(101, 80)
        Me.CloseBTN.Name = "CloseBTN"
        Me.CloseBTN.Size = New System.Drawing.Size(75, 23)
        Me.CloseBTN.TabIndex = 4
        Me.CloseBTN.Text = "Close"
        Me.CloseBTN.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.usernameTB)
        Me.GroupBox1.Controls.Add(Me.CloseBTN)
        Me.GroupBox1.Controls.Add(Me.PassTB)
        Me.GroupBox1.Controls.Add(Me.LoginBTN)
        Me.GroupBox1.Location = New System.Drawing.Point(130, 264)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(189, 114)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Login"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 402)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.statusTB)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Login"
        Me.ShowIcon = False
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents statusTB As System.Windows.Forms.TextBox
    Friend WithEvents usernameTB As System.Windows.Forms.TextBox
    Friend WithEvents PassTB As System.Windows.Forms.TextBox
    Friend WithEvents LoginBTN As System.Windows.Forms.Button
    Friend WithEvents CloseBTN As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
