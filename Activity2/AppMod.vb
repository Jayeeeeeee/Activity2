Module AppMod
    Function Encrypt(ByVal InputText As String, ByVal SecretKey As String) As String
        Dim Result As String = ""
        Dim keyLength As Integer = SecretKey.Length
        Dim keyIndex As Integer = 0

        ' Loop through each character in the input text
        For Each ch As Char In InputText
            ' Get the shift value from the SecretKey character
            Dim shift As Integer = AscW(SecretKey(keyIndex Mod keyLength)) - 32

            ' Shift the character within the printable ASCII range (32 to 126)
            Dim shiftedChar As Char = ChrW(32 + ((AscW(ch) - 32 + shift) Mod 95))
            Result &= shiftedChar

            ' Move to next character in the SecretKey (looping)
            keyIndex += 1
        Next

        Return Result
    End Function

    Function Decrypt(ByVal Text As String, ByVal SecretKey As String) As String
        Dim Result As String = ""
        Dim keyLength As Integer = SecretKey.Length
        Dim keyIndex As Integer = 0

        ' Loop through each character in the input text (ciphertext)
        For Each ch As Char In Text
            ' Get the shift value from the SecretKey character
            Dim shift As Integer = AscW(SecretKey(keyIndex Mod keyLength)) - 32

            ' Reverse the shift (same logic but subtract the shift instead of adding)
            Dim shiftedChar As Char = ChrW(32 + ((AscW(ch) - 32 - shift + 95) Mod 95))
            Result &= shiftedChar

            ' Move to next character in the SecretKey (looping)
            keyIndex += 1
        Next

        Return Result
    End Function
    Function dgvWrite(ByVal InputText As String, Action As String, ProcessedText As String)
        Return Form1.dgv_Results.Rows.Add(InputText, Action, ProcessedText)
    End Function

    Function FileWrite(ByVal Action As String, InputText As String, ProcessedText As String)
        Dim FilePath As String = "C:\Users\xstop\source\repos\CipherApp\CipherApp\ProcessedText.txt"
        Try
            Using Writer As New System.IO.StreamWriter(FilePath, True)
                Writer.WriteLine($"Action: {Action}")
                Writer.WriteLine($"Input Text: {InputText}")
                Writer.WriteLine($"Processed Text: {ProcessedText}")
                Writer.WriteLine("-------------------------------------")
            End Using
            'MessageBox.Show($"Processed text saved to {FilePath}.")
            Return True
        Catch ex As Exception
            MessageBox.Show("An error occurred while writing to the file: " & ex.Message)
            Return False
        End Try
    End Function
End Module

'Using the AES functions
'Function Encrypt(ByVal InputText As String, ByVal SecretKey As String) As String
'    Using aes As Aes = Aes.Create()
'        aes.Key = Encoding.UTF8.GetBytes(SecretKey.Substring(0, 16))
'        aes.IV = New Byte(15) {} ' Zero initialization vector for simplicity

'        Using encryptor = aes.CreateEncryptor()
'            Dim plainBytes = Encoding.UTF8.GetBytes(InputText)
'            Dim encryptedBytes = encryptor.TransformFinalBlock(plainBytes, 0, plainBytes.Length)
'            Return Convert.ToBase64String(encryptedBytes)
'        End Using
'    End Using
'End Function

'Function Decrypt(ByVal InputText As String, ByVal SecretKey As String) As String
'    Using aes As Aes = Aes.Create()
'        aes.Key = Encoding.UTF8.GetBytes(SecretKey.Substring(0, 16))
'        aes.IV = New Byte(15) {} ' Zero initialization vector for simplicity

'        Using decryptor = aes.CreateDecryptor()
'            Dim encryptedBytes = Convert.FromBase64String(InputText)
'            Dim decryptedBytes = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length)
'            Return Encoding.UTF8.GetString(decryptedBytes)
'        End Using
'    End Using
'End Function
