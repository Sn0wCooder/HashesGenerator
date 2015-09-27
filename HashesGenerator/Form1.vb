Imports System
Imports System.Security.Cryptography
Imports System.Text
Imports System.IO

Public Class Form1
#Region "Raccourcis pour la fonction principale hash_generator"
    Function md5_hash(ByVal file_name As String)
        Return hash_generator("md5", file_name)
    End Function

    Function sha_1(ByVal file_name As String)
        Return hash_generator("sha1", file_name)
    End Function

    Function sha_256(ByVal file_name As String)
        Return hash_generator("sha256", file_name)
    End Function

    Function sha_384(ByVal file_name As String)
        Return hash_generator("sha384", file_name)
    End Function

    Function sha_512(ByVal file_name As String)
        Return hash_generator("sha512", file_name)
    End Function
#End Region

    Function hash_generator(ByVal hash_type As String, ByVal file_name As String)
        Dim hash
        If hash_type.ToLower = "md5" Then
            hash = MD5.Create
        ElseIf hash_type.ToLower = "sha1" Then
            hash = SHA1.Create()
        ElseIf hash_type.ToLower = "sha256" Then
            hash = SHA256.Create()
        ElseIf hash_type.ToLower = "sha384" Then
            hash = SHA384.Create
        ElseIf hash_type.ToLower = "sha512" Then
            hash = SHA512.Create
        Else
            MsgBox("Type de hash inconnu : " & hash_type, MsgBoxStyle.Critical)
            Return False
        End If
        Dim hashValue() As Byte
        Dim fileStream As FileStream = File.OpenRead(file_name)
        fileStream.Position = 0
        hashValue = hash.ComputeHash(fileStream)
        Dim hash_hex = PrintByteArray(hashValue)
        fileStream.Close()
        Return hash_hex
    End Function

    Public Function PrintByteArray(ByVal array() As Byte)
        Dim hex_value As String = ""
        Dim i As Integer
        For i = 0 To array.Length - 1
            hex_value += array(i).ToString("X2")
        Next i
        Return hex_value.ToLower
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            FileTextBox.Text = OpenFileDialog1.FileName
            MD5TextBox.Text = md5_hash(OpenFileDialog1.FileName)
            SHA1TextBox.Text = sha_1(OpenFileDialog1.FileName)
            SHA256TextBox.Text = sha_256(OpenFileDialog1.FileName)
            SHA384TextBox.Text = sha_384(OpenFileDialog1.FileName)
            SHA512TextBox.Text = sha_512(OpenFileDialog1.FileName)
            Label1.Text = "File size: " & My.Computer.FileSystem.GetFileInfo(OpenFileDialog1.FileName).Length & " bytes"
            ClearButton.Enabled = True
            SaveButton.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        MD5TextBox.Clear()
        SHA1TextBox.Clear()
        SHA256TextBox.Clear()
        FileTextBox.Clear()
        SHA512TextBox.Clear()
        SHA384TextBox.Clear()
        Label1.Text = "File size:"
        SaveButton.Enabled = False
        ClearButton.Enabled = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            If System.IO.File.Exists(SaveFileDialog1.FileName) Then
                System.IO.File.Delete(SaveFileDialog1.FileName)
            End If
            Dim FileName As String = System.IO.Path.GetFileName(FileTextBox.Text)
            Dim Text As String = "File name: " & FileName & vbCrLf & vbCrLf & "MD5: " & MD5TextBox.Text & vbCrLf & "SHA-1: " & SHA1TextBox.Text & vbCrLf & "SHA-256: " & SHA256TextBox.Text & vbCrLf & _
               "SHA-384: " & SHA384TextBox.Text & vbCrLf & "SHA-512: " & SHA512TextBox.Text & vbCrLf & Label1.Text
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, Text, True)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        If System.IO.File.Exists(FileTextBox.Text) Then
            MD5TextBox.Text = md5_hash(FileTextBox.Text)
            SHA1TextBox.Text = sha_1(FileTextBox.Text)
            SHA256TextBox.Text = sha_256(FileTextBox.Text)
            SHA384TextBox.Text = sha_384(FileTextBox.Text)
            SHA512TextBox.Text = sha_512(FileTextBox.Text)
            Label1.Text = "File size: " & My.Computer.FileSystem.GetFileInfo(FileTextBox.Text).Length & " bytes"
            SaveButton.Enabled = True
            ClearButton.Enabled = True
        Else
            MsgBox("File not found!", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub FileTextBox_TextChanged(sender As Object, e As EventArgs) Handles FileTextBox.TextChanged
        If Not FileTextBox.Text = Nothing Then
            ClearButton.Enabled = True
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://leoalfred.altervista.org/twitter.html")
    End Sub
End Class
