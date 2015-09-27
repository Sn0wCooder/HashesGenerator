<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SHA256TextBox = New System.Windows.Forms.TextBox()
        Me.SHA1TextBox = New System.Windows.Forms.TextBox()
        Me.MD5TextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FileTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SHA384TextBox = New System.Windows.Forms.TextBox()
        Me.SHA512TextBox = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "File size:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.AutoUpgradeEnabled = False
        Me.OpenFileDialog1.Filter = "*.*|*.*"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SHA512TextBox)
        Me.GroupBox1.Controls.Add(Me.SHA384TextBox)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.SHA256TextBox)
        Me.GroupBox1.Controls.Add(Me.SHA1TextBox)
        Me.GroupBox1.Controls.Add(Me.MD5TextBox)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(462, 176)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "File info"
        '
        'SHA256TextBox
        '
        Me.SHA256TextBox.Location = New System.Drawing.Point(68, 97)
        Me.SHA256TextBox.Name = "SHA256TextBox"
        Me.SHA256TextBox.ReadOnly = True
        Me.SHA256TextBox.Size = New System.Drawing.Size(384, 20)
        Me.SHA256TextBox.TabIndex = 6
        '
        'SHA1TextBox
        '
        Me.SHA1TextBox.Location = New System.Drawing.Point(68, 71)
        Me.SHA1TextBox.Name = "SHA1TextBox"
        Me.SHA1TextBox.ReadOnly = True
        Me.SHA1TextBox.Size = New System.Drawing.Size(384, 20)
        Me.SHA1TextBox.TabIndex = 5
        '
        'MD5TextBox
        '
        Me.MD5TextBox.Location = New System.Drawing.Point(68, 45)
        Me.MD5TextBox.Name = "MD5TextBox"
        Me.MD5TextBox.ReadOnly = True
        Me.MD5TextBox.Size = New System.Drawing.Size(384, 20)
        Me.MD5TextBox.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "SHA-256:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "SHA-1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "MD5:"
        '
        'FileTextBox
        '
        Me.FileTextBox.Location = New System.Drawing.Point(12, 12)
        Me.FileTextBox.Name = "FileTextBox"
        Me.FileTextBox.Size = New System.Drawing.Size(519, 20)
        Me.FileTextBox.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(537, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(31, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Enabled = False
        Me.ClearButton.Location = New System.Drawing.Point(480, 109)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(88, 23)
        Me.ClearButton.TabIndex = 4
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Enabled = False
        Me.SaveButton.Location = New System.Drawing.Point(480, 68)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(88, 35)
        Me.SaveButton.TabIndex = 5
        Me.SaveButton.Text = "Save into text document"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(480, 39)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(88, 23)
        Me.CalculateButton.TabIndex = 6
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(480, 138)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(88, 23)
        Me.ExitButton.TabIndex = 7
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.AutoUpgradeEnabled = False
        Me.SaveFileDialog1.FileName = "hashes"
        Me.SaveFileDialog1.Filter = "Text document (TXT File)|*.txt|Rich Text File (RTF)|*.rtf|All files|*.*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "SHA-384:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "SHA-512:"
        '
        'SHA384TextBox
        '
        Me.SHA384TextBox.Location = New System.Drawing.Point(68, 123)
        Me.SHA384TextBox.Name = "SHA384TextBox"
        Me.SHA384TextBox.ReadOnly = True
        Me.SHA384TextBox.Size = New System.Drawing.Size(384, 20)
        Me.SHA384TextBox.TabIndex = 9
        '
        'SHA512TextBox
        '
        Me.SHA512TextBox.Location = New System.Drawing.Point(68, 149)
        Me.SHA512TextBox.Name = "SHA512TextBox"
        Me.SHA512TextBox.ReadOnly = True
        Me.SHA512TextBox.Size = New System.Drawing.Size(384, 20)
        Me.SHA512TextBox.TabIndex = 10
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(514, 202)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(54, 13)
        Me.LinkLabel1.TabIndex = 8
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Follow me"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 221)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.FileTextBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HashesGenerator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SHA256TextBox As System.Windows.Forms.TextBox
    Friend WithEvents SHA1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents MD5TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FileTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents CalculateButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents SHA512TextBox As System.Windows.Forms.TextBox
    Friend WithEvents SHA384TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel

End Class
