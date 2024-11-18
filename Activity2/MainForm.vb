Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.AcceptButton = btn_Process
        btn_Process.Enabled = False
        dgv_Results.ColumnCount = 3
        dgv_Results.Columns(0).Name = " Original  Text"
        dgv_Results.Columns(1).Name = " Action"
        dgv_Results.Columns(2).Name = " Processed Text"
    End Sub

    Private Sub Secret_Changed(sender As Object, e As EventArgs) Handles txt_Secret.TextChanged
        Dim inputText As String = txt_Secret.Text

        ' Update the validation label based on the input length
        If inputText.Length < 16 Then
            lbl_Characters.Text = $"{16 - inputText.Length} more character(s) needed."
            lbl_Characters.ForeColor = Color.Red
            btn_Process.Enabled = False

        ElseIf inputText.Length > 16 Then
            lbl_Characters.Text = $" Reduce {inputText.Length - 16} character(s)."
            lbl_Characters.ForeColor = Color.Red
            btn_Process.Enabled = False

        Else
            lbl_Characters.Text = "Input length is valid."
            lbl_Characters.ForeColor = Color.Green
            btn_Process.Enabled = True
        End If
    End Sub

    Private Sub btn_Process_Click(sender As Object, e As EventArgs) Handles btn_Process.Click
        Dim InputText = txt_Text.Text
        Dim SecretKey = txt_Secret.Text
        Dim Action = cmb_Actions.SelectedItem?.ToString
        Dim ProcessedText = ""

        If String.IsNullOrEmpty(SecretKey) Then
            MessageBox.Show("Secret key cannot be empty.")

        ElseIf SecretKey.Length < 16 Then
            MessageBox.Show("Secret key must be at least 16 characters long.")

        ElseIf String.IsNullOrEmpty(Action) Then
            MessageBox.Show("Please select an action.")
            Return
        End If

        Select Case Action
            Case "Encrypt"
                ProcessedText = Encrypt(InputText, SecretKey)
            Case "Decrypt"
                ProcessedText = Decrypt(InputText, SecretKey)
            Case Else
                MessageBox.Show("Invalid action selected.")
                Return
        End Select

        dgvWrite(InputText, Action, ProcessedText)
        FileWrite(Action, InputText, ProcessedText)
    End Sub
End Class