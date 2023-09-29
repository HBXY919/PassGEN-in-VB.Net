Imports System.IO
Imports System.Text
Imports System.Management
Imports System.Diagnostics.Eventing.Reader
Imports System.Windows.Forms.VisualStyles
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    'Color Palette
    Dim EerieBlack As Color = Color.FromArgb(27, 30, 34) ' 27; 30; 34
    Dim RobinEggBlue As Color = Color.FromArgb(32, 197, 202) ' 32; 197; 202
    Dim DavysGray As Color = Color.FromArgb(77, 72, 71) ' 77; 72; 71
    Dim MintCream As Color = Color.FromArgb(244, 255, 248) ' 244; 255; 248
    Dim CadetGray As Color = Color.FromArgb(139, 170, 173)  ' 139; 170; 173
    Dim AmaranthPink As Color = Color.FromArgb(244, 159, 188) ' 244; 159; 188
    Dim AntiFlashWhite As Color = Color.FromArgb(240, 243, 247) ' 240; 243; 247
    'Charsets
    Dim CAP_Charset As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZÖÄÜß"
    Dim NO_Charset As String = "0123456789"
    Dim Special_charset As String = "&%$!?#@§"
    Dim Charsets As New List(Of String)
    Dim TMP As String = ""
    Dim Rnd As New Random

    Private Function GeneratePassword(uppercase As Boolean, numbers As Boolean, specialChars As Boolean)
        Charsets.Clear()

        If uppercase Then
            Charsets.Add(CAP_Charset)
        End If
        If numbers Then
            Charsets.Add(NO_Charset)
        End If
        If specialChars Then
            Charsets.Add(Special_charset)
        End If

        TMP = ""

        Dim PasswordLength As Integer = CInt(nud_PasswordLength.Value)

        For i As Integer = 1 To PasswordLength

            Dim charsetIndex As Integer = Rnd.Next(0, Charsets.Count)
            Dim SelectedCharset As String = Charsets(charsetIndex)
            Dim CharIndex As Integer = Rnd.Next(0, SelectedCharset.Length)
            TMP = TMP & SelectedCharset.Chars(CharIndex)
            If i Mod 6 = 0 AndAlso i < PasswordLength Then
                TMP = TMP & "-"
            End If
        Next
        tb_Password.Text = TMP

    End Function

    Private Sub EvaluatePassword(password As String)
        'Colors
        Dim LightGreen As Color = Color.FromArgb(163, 247, 181) ' 163; 247; 181
        Dim Citrine As Color = Color.FromArgb(243, 222, 44) ' 243; 222; 44
        Dim Poppy As Color = Color.FromArgb(214, 64, 69) ' 214; 64; 69

        Dim strength As Integer = 0

        ' Bewertungskriterien: Länge, Großbuchstaben, Zahlen, Sonderzeichen
        If password.Length >= 24 Then
            strength = 2 ' Stark
        ElseIf password.Length >= 12 Then
            If password.Any(Function(c) Char.IsDigit(c) Or Special_charset.Contains(c)) Then
                strength = 1 ' Mittel
            Else
                strength = 0 ' Schwach
            End If
        End If


        ' Passwortbewertung: 0 - schwach, 1 - mittel, 2 - stark
        Select Case strength
            Case 0
                pb_Evaluate01.BackColor = Poppy
                pb_Evaluate02.BackColor = Poppy
                pb_Evaluate03.BackColor = CadetGray
                pb_Evaluate04.BackColor = CadetGray
                pb_Evaluate05.BackColor = CadetGray
                pb_Evaluate06.BackColor = CadetGray
                pb_Evaluate07.BackColor = CadetGray
            Case 1
                pb_Evaluate01.BackColor = Citrine
                pb_Evaluate02.BackColor = Citrine
                pb_Evaluate03.BackColor = Citrine
                pb_Evaluate04.BackColor = Citrine
                pb_Evaluate05.BackColor = CadetGray
                pb_Evaluate06.BackColor = CadetGray
                pb_Evaluate07.BackColor = CadetGray
            Case 2
                pb_Evaluate01.BackColor = LightGreen
                pb_Evaluate02.BackColor = LightGreen
                pb_Evaluate03.BackColor = LightGreen
                pb_Evaluate04.BackColor = LightGreen
                pb_Evaluate05.BackColor = LightGreen
                pb_Evaluate06.BackColor = LightGreen
                pb_Evaluate07.BackColor = LightGreen
        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim uppercaseChecked As Boolean = cb_Uppercase.Checked
        Dim numbersChecked As Boolean = cb_Numbers.Checked
        Dim specialCharsChecked As Boolean = cb_SpecialChars.Checked

        tb_Password.Clear()
        GeneratePassword(uppercaseChecked, numbersChecked, specialCharsChecked)
        EvaluatePassword(tb_Password.Text)
        tb_Password.SelectAll()
        tb_Password.Copy()
    End Sub

    Private isDragging As Boolean = False
    Private clickOffset As Point

    Private Sub TitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles TitleBar.MouseDown
        If e.Button = MouseButtons.Left Then
            isDragging = True
            clickOffset = New Point(e.X, e.Y)
        End If
    End Sub

    Private Sub TitleBar_MouseMove(sender As Object, e As MouseEventArgs) Handles TitleBar.MouseMove
        If isDragging Then
            Dim newLocation As Point = Me.PointToScreen(New Point(e.X, e.Y))
            newLocation.Offset(-clickOffset.X, -clickOffset.Y)
            Me.Location = newLocation
        End If
    End Sub

    Private Sub TitleBar_MouseUp(sender As Object, e As MouseEventArgs) Handles TitleBar.MouseUp
        isDragging = False
    End Sub

    Private Sub cb_Uppercase_CheckedChanged(sender As Object, e As EventArgs) Handles cb_Uppercase.CheckedChanged
        Try
            If cb_Uppercase.Checked = False Then
                cb_Uppercase.Checked = True
            End If
        Catch ex As Exception
            MessageBox.Show("Fehler aufgetreten: " & ex.Message)
            cb_Uppercase.Checked = True
            cb_Uppercase.Enabled = False
        End Try
    End Sub

End Class
