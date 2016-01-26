<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.buttSaveLogin = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAPIKey = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Domains = New System.Windows.Forms.TabPage()
        Me.Records = New System.Windows.Forms.TabPage()
        Me.buttFetch = New System.Windows.Forms.Button()
        Me.listDomains = New System.Windows.Forms.ListView()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Domains.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(305, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cloudflare API app"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.buttSaveLogin)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtAPIKey)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(566, 119)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Login details"
        '
        'buttSaveLogin
        '
        Me.buttSaveLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.buttSaveLogin.Location = New System.Drawing.Point(461, 71)
        Me.buttSaveLogin.Name = "buttSaveLogin"
        Me.buttSaveLogin.Size = New System.Drawing.Size(87, 35)
        Me.buttSaveLogin.TabIndex = 9
        Me.buttSaveLogin.Text = "Save"
        Me.buttSaveLogin.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "E-Mail"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(63, 45)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(485, 20)
        Me.txtEmail.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "API Key"
        '
        'txtAPIKey
        '
        Me.txtAPIKey.Location = New System.Drawing.Point(63, 19)
        Me.txtAPIKey.Name = "txtAPIKey"
        Me.txtAPIKey.Size = New System.Drawing.Size(485, 20)
        Me.txtAPIKey.TabIndex = 5
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Domains)
        Me.TabControl1.Controls.Add(Me.Records)
        Me.TabControl1.Location = New System.Drawing.Point(814, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(343, 567)
        Me.TabControl1.TabIndex = 12
        '
        'Domains
        '
        Me.Domains.Controls.Add(Me.listDomains)
        Me.Domains.Controls.Add(Me.buttFetch)
        Me.Domains.Location = New System.Drawing.Point(4, 22)
        Me.Domains.Name = "Domains"
        Me.Domains.Padding = New System.Windows.Forms.Padding(3)
        Me.Domains.Size = New System.Drawing.Size(335, 541)
        Me.Domains.TabIndex = 0
        Me.Domains.Text = "List Domains"
        Me.Domains.UseVisualStyleBackColor = True
        '
        'Records
        '
        Me.Records.Location = New System.Drawing.Point(4, 22)
        Me.Records.Name = "Records"
        Me.Records.Padding = New System.Windows.Forms.Padding(3)
        Me.Records.Size = New System.Drawing.Size(558, 541)
        Me.Records.TabIndex = 1
        Me.Records.Text = "List Records"
        Me.Records.UseVisualStyleBackColor = True
        '
        'buttFetch
        '
        Me.buttFetch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.buttFetch.Location = New System.Drawing.Point(6, 500)
        Me.buttFetch.Name = "buttFetch"
        Me.buttFetch.Size = New System.Drawing.Size(323, 35)
        Me.buttFetch.TabIndex = 12
        Me.buttFetch.Text = "Fetch List"
        Me.buttFetch.UseVisualStyleBackColor = True
        '
        'listDomains
        '
        Me.listDomains.HideSelection = False
        Me.listDomains.Location = New System.Drawing.Point(6, 6)
        Me.listDomains.Name = "listDomains"
        Me.listDomains.Size = New System.Drawing.Size(323, 488)
        Me.listDomains.TabIndex = 14
        Me.listDomains.UseCompatibleStateImageBehavior = False
        '
        'Frm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1169, 591)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Frm1"
        Me.Text = "Cloudflare API app testing"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.Domains.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents buttSaveLogin As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAPIKey As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Domains As TabPage
    Friend WithEvents listDomains As ListView
    Public WithEvents buttFetch As Button
    Friend WithEvents Records As TabPage
End Class
