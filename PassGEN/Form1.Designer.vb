<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tb_Password = New System.Windows.Forms.TextBox()
        Me.cb_Uppercase = New System.Windows.Forms.CheckBox()
        Me.TitleBar = New System.Windows.Forms.PictureBox()
        Me.lbl_MainTitle = New System.Windows.Forms.Label()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.cb_Numbers = New System.Windows.Forms.CheckBox()
        Me.cb_SpecialChars = New System.Windows.Forms.CheckBox()
        Me.nud_PasswordLength = New System.Windows.Forms.NumericUpDown()
        Me.gb_Settings = New System.Windows.Forms.GroupBox()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.lbl_header = New System.Windows.Forms.Label()
        Me.lbl_secondHeader = New System.Windows.Forms.Label()
        Me.gb_Length = New System.Windows.Forms.GroupBox()
        Me.pgb_Strongnes = New System.Windows.Forms.ProgressBar()
        Me.pb_Evaluate07 = New System.Windows.Forms.PictureBox()
        Me.pb_Evaluate06 = New System.Windows.Forms.PictureBox()
        Me.pb_Evaluate05 = New System.Windows.Forms.PictureBox()
        Me.pb_Evaluate02 = New System.Windows.Forms.PictureBox()
        Me.pb_Evaluate03 = New System.Windows.Forms.PictureBox()
        Me.pb_Evaluate04 = New System.Windows.Forms.PictureBox()
        Me.pb_Evaluate01 = New System.Windows.Forms.PictureBox()
        CType(Me.TitleBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_PasswordLength, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_Settings.SuspendLayout()
        Me.gb_Length.SuspendLayout()
        CType(Me.pb_Evaluate07, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_Evaluate06, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_Evaluate05, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_Evaluate02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_Evaluate03, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_Evaluate04, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_Evaluate01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(305, 173)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 99)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Create"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tb_Password
        '
        Me.tb_Password.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.tb_Password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_Password.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.tb_Password.Location = New System.Drawing.Point(17, 121)
        Me.tb_Password.Name = "tb_Password"
        Me.tb_Password.ReadOnly = True
        Me.tb_Password.Size = New System.Drawing.Size(400, 24)
        Me.tb_Password.TabIndex = 1
        '
        'cb_Uppercase
        '
        Me.cb_Uppercase.AutoSize = True
        Me.cb_Uppercase.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.cb_Uppercase.Checked = True
        Me.cb_Uppercase.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_Uppercase.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.cb_Uppercase.FlatAppearance.BorderSize = 5
        Me.cb_Uppercase.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cb_Uppercase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_Uppercase.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Uppercase.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cb_Uppercase.Location = New System.Drawing.Point(6, 24)
        Me.cb_Uppercase.Name = "cb_Uppercase"
        Me.cb_Uppercase.Size = New System.Drawing.Size(59, 19)
        Me.cb_Uppercase.TabIndex = 2
        Me.cb_Uppercase.Text = "Letters"
        Me.cb_Uppercase.UseVisualStyleBackColor = False
        '
        'TitleBar
        '
        Me.TitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.TitleBar.Location = New System.Drawing.Point(0, -1)
        Me.TitleBar.Name = "TitleBar"
        Me.TitleBar.Size = New System.Drawing.Size(442, 27)
        Me.TitleBar.TabIndex = 3
        Me.TitleBar.TabStop = False
        '
        'lbl_MainTitle
        '
        Me.lbl_MainTitle.AutoSize = True
        Me.lbl_MainTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.lbl_MainTitle.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MainTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.lbl_MainTitle.Location = New System.Drawing.Point(14, 5)
        Me.lbl_MainTitle.Name = "lbl_MainTitle"
        Me.lbl_MainTitle.Size = New System.Drawing.Size(122, 15)
        Me.lbl_MainTitle.TabIndex = 4
        Me.lbl_MainTitle.Text = "PassGEN 1.0 | ALPHA"
        '
        'btn_Close
        '
        Me.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Close.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Close.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btn_Close.Location = New System.Drawing.Point(415, 2)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(20, 20)
        Me.btn_Close.TabIndex = 5
        Me.btn_Close.Text = "X"
        Me.btn_Close.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'cb_Numbers
        '
        Me.cb_Numbers.AutoSize = True
        Me.cb_Numbers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.cb_Numbers.FlatAppearance.BorderSize = 5
        Me.cb_Numbers.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cb_Numbers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_Numbers.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Numbers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cb_Numbers.Location = New System.Drawing.Point(6, 49)
        Me.cb_Numbers.Name = "cb_Numbers"
        Me.cb_Numbers.Size = New System.Drawing.Size(72, 19)
        Me.cb_Numbers.TabIndex = 6
        Me.cb_Numbers.Text = "Numbers"
        Me.cb_Numbers.UseVisualStyleBackColor = True
        '
        'cb_SpecialChars
        '
        Me.cb_SpecialChars.AutoSize = True
        Me.cb_SpecialChars.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.cb_SpecialChars.FlatAppearance.BorderSize = 5
        Me.cb_SpecialChars.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cb_SpecialChars.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_SpecialChars.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_SpecialChars.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cb_SpecialChars.Location = New System.Drawing.Point(6, 74)
        Me.cb_SpecialChars.Name = "cb_SpecialChars"
        Me.cb_SpecialChars.Size = New System.Drawing.Size(98, 19)
        Me.cb_SpecialChars.TabIndex = 7
        Me.cb_SpecialChars.Text = "Special Chars"
        Me.cb_SpecialChars.UseVisualStyleBackColor = True
        '
        'nud_PasswordLength
        '
        Me.nud_PasswordLength.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.nud_PasswordLength.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nud_PasswordLength.Font = New System.Drawing.Font("Calibri", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_PasswordLength.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.nud_PasswordLength.Increment = New Decimal(New Integer() {6, 0, 0, 0})
        Me.nud_PasswordLength.Location = New System.Drawing.Point(6, 19)
        Me.nud_PasswordLength.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.nud_PasswordLength.Minimum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.nud_PasswordLength.Name = "nud_PasswordLength"
        Me.nud_PasswordLength.Size = New System.Drawing.Size(99, 82)
        Me.nud_PasswordLength.TabIndex = 9
        Me.nud_PasswordLength.Value = New Decimal(New Integer() {12, 0, 0, 0})
        '
        'gb_Settings
        '
        Me.gb_Settings.Controls.Add(Me.cb_Numbers)
        Me.gb_Settings.Controls.Add(Me.cb_Uppercase)
        Me.gb_Settings.Controls.Add(Me.cb_SpecialChars)
        Me.gb_Settings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.gb_Settings.Location = New System.Drawing.Point(17, 167)
        Me.gb_Settings.Name = "gb_Settings"
        Me.gb_Settings.Size = New System.Drawing.Size(165, 105)
        Me.gb_Settings.TabIndex = 10
        Me.gb_Settings.TabStop = False
        Me.gb_Settings.Text = "Password Settings:"
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.lbl_password.Location = New System.Drawing.Point(14, 104)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(123, 14)
        Me.lbl_password.TabIndex = 11
        Me.lbl_password.Text = "Generated Password:"
        '
        'lbl_header
        '
        Me.lbl_header.AutoSize = True
        Me.lbl_header.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_header.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.lbl_header.Location = New System.Drawing.Point(22, 37)
        Me.lbl_header.Name = "lbl_header"
        Me.lbl_header.Size = New System.Drawing.Size(395, 26)
        Me.lbl_header.TabIndex = 12
        Me.lbl_header.Text = "Welcome to my simple password generator!"
        Me.lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_secondHeader
        '
        Me.lbl_secondHeader.AutoSize = True
        Me.lbl_secondHeader.Font = New System.Drawing.Font("Calibri Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_secondHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.lbl_secondHeader.Location = New System.Drawing.Point(156, 63)
        Me.lbl_secondHeader.Name = "lbl_secondHeader"
        Me.lbl_secondHeader.Size = New System.Drawing.Size(119, 26)
        Me.lbl_secondHeader.TabIndex = 13
        Me.lbl_secondHeader.Text = "Have FUN! ;)"
        '
        'gb_Length
        '
        Me.gb_Length.Controls.Add(Me.nud_PasswordLength)
        Me.gb_Length.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.gb_Length.Location = New System.Drawing.Point(188, 167)
        Me.gb_Length.Name = "gb_Length"
        Me.gb_Length.Size = New System.Drawing.Size(111, 105)
        Me.gb_Length.TabIndex = 11
        Me.gb_Length.TabStop = False
        Me.gb_Length.Text = "Password length:"
        '
        'pgb_Strongnes
        '
        Me.pgb_Strongnes.ForeColor = System.Drawing.Color.GreenYellow
        Me.pgb_Strongnes.Location = New System.Drawing.Point(17, 92)
        Me.pgb_Strongnes.Name = "pgb_Strongnes"
        Me.pgb_Strongnes.Size = New System.Drawing.Size(400, 10)
        Me.pgb_Strongnes.Step = 33
        Me.pgb_Strongnes.TabIndex = 14
        '
        'pb_Evaluate07
        '
        Me.pb_Evaluate07.Location = New System.Drawing.Point(367, 151)
        Me.pb_Evaluate07.Name = "pb_Evaluate07"
        Me.pb_Evaluate07.Size = New System.Drawing.Size(50, 10)
        Me.pb_Evaluate07.TabIndex = 15
        Me.pb_Evaluate07.TabStop = False
        '
        'pb_Evaluate06
        '
        Me.pb_Evaluate06.Location = New System.Drawing.Point(311, 151)
        Me.pb_Evaluate06.Name = "pb_Evaluate06"
        Me.pb_Evaluate06.Size = New System.Drawing.Size(50, 10)
        Me.pb_Evaluate06.TabIndex = 16
        Me.pb_Evaluate06.TabStop = False
        '
        'pb_Evaluate05
        '
        Me.pb_Evaluate05.Location = New System.Drawing.Point(255, 151)
        Me.pb_Evaluate05.Name = "pb_Evaluate05"
        Me.pb_Evaluate05.Size = New System.Drawing.Size(50, 10)
        Me.pb_Evaluate05.TabIndex = 17
        Me.pb_Evaluate05.TabStop = False
        '
        'pb_Evaluate02
        '
        Me.pb_Evaluate02.Location = New System.Drawing.Point(85, 151)
        Me.pb_Evaluate02.Name = "pb_Evaluate02"
        Me.pb_Evaluate02.Size = New System.Drawing.Size(50, 10)
        Me.pb_Evaluate02.TabIndex = 20
        Me.pb_Evaluate02.TabStop = False
        '
        'pb_Evaluate03
        '
        Me.pb_Evaluate03.Location = New System.Drawing.Point(141, 151)
        Me.pb_Evaluate03.Name = "pb_Evaluate03"
        Me.pb_Evaluate03.Size = New System.Drawing.Size(50, 10)
        Me.pb_Evaluate03.TabIndex = 19
        Me.pb_Evaluate03.TabStop = False
        '
        'pb_Evaluate04
        '
        Me.pb_Evaluate04.Location = New System.Drawing.Point(197, 151)
        Me.pb_Evaluate04.Name = "pb_Evaluate04"
        Me.pb_Evaluate04.Size = New System.Drawing.Size(50, 10)
        Me.pb_Evaluate04.TabIndex = 18
        Me.pb_Evaluate04.TabStop = False
        '
        'pb_Evaluate01
        '
        Me.pb_Evaluate01.Location = New System.Drawing.Point(29, 151)
        Me.pb_Evaluate01.Name = "pb_Evaluate01"
        Me.pb_Evaluate01.Size = New System.Drawing.Size(50, 10)
        Me.pb_Evaluate01.TabIndex = 21
        Me.pb_Evaluate01.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(438, 292)
        Me.Controls.Add(Me.pb_Evaluate01)
        Me.Controls.Add(Me.pb_Evaluate02)
        Me.Controls.Add(Me.pb_Evaluate03)
        Me.Controls.Add(Me.pb_Evaluate04)
        Me.Controls.Add(Me.pb_Evaluate05)
        Me.Controls.Add(Me.pb_Evaluate06)
        Me.Controls.Add(Me.pb_Evaluate07)
        Me.Controls.Add(Me.pgb_Strongnes)
        Me.Controls.Add(Me.gb_Length)
        Me.Controls.Add(Me.lbl_secondHeader)
        Me.Controls.Add(Me.lbl_header)
        Me.Controls.Add(Me.lbl_password)
        Me.Controls.Add(Me.gb_Settings)
        Me.Controls.Add(Me.btn_Close)
        Me.Controls.Add(Me.lbl_MainTitle)
        Me.Controls.Add(Me.TitleBar)
        Me.Controls.Add(Me.tb_Password)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PassGEN"
        CType(Me.TitleBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_PasswordLength, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_Settings.ResumeLayout(False)
        Me.gb_Settings.PerformLayout()
        Me.gb_Length.ResumeLayout(False)
        CType(Me.pb_Evaluate07, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_Evaluate06, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_Evaluate05, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_Evaluate02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_Evaluate03, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_Evaluate04, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_Evaluate01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents tb_Password As TextBox
    Friend WithEvents cb_Uppercase As CheckBox
    Friend WithEvents TitleBar As PictureBox
    Friend WithEvents lbl_MainTitle As Label
    Friend WithEvents btn_Close As Button
    Friend WithEvents cb_SpecialChars As CheckBox
    Friend WithEvents cb_Numbers As CheckBox
    Friend WithEvents nud_PasswordLength As NumericUpDown
    Friend WithEvents gb_Settings As GroupBox
    Friend WithEvents lbl_password As Label
    Friend WithEvents lbl_header As Label
    Friend WithEvents lbl_secondHeader As Label
    Friend WithEvents gb_Length As GroupBox
    Friend WithEvents pgb_Strongnes As ProgressBar
    Friend WithEvents pb_Evaluate07 As PictureBox
    Friend WithEvents pb_Evaluate06 As PictureBox
    Friend WithEvents pb_Evaluate05 As PictureBox
    Friend WithEvents pb_Evaluate02 As PictureBox
    Friend WithEvents pb_Evaluate03 As PictureBox
    Friend WithEvents pb_Evaluate04 As PictureBox
    Friend WithEvents pb_Evaluate01 As PictureBox
End Class
