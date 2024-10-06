Imports System.Security.Cryptography
Imports System.Text
Imports System.IO

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(TextBox4.Text) Then
            MessageBox.Show("Seleziona un file prima di calcolare il checksum", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        TextBox1.Text = CalcolaChecksum(TextBox4.Text, "MD5")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim label10 As String = TextBox7.Text.ToLower()
        Dim label6 As String = TextBox2.Text.ToLower()
        If label10 = label6 Then
            TextBox6.Text = "Corrispondono"
        Else
            TextBox6.Text = "Non corrispondono"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim openFileDialog1 As New OpenFileDialog
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openFileDialog1.FileName
            TextBox4.Text = filePath
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim label10 As String = TextBox7.Text
        Dim label6 As String = TextBox2.Text
        If label10 = label6 Then
            TextBox6.Text = "Corrispondono"
        Else
            TextBox6.Text = "Non corrispondono"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If String.IsNullOrEmpty(TextBox4.Text) Then
            MessageBox.Show("Seleziona un file prima di calcolare il checksum", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        TextBox3.Text = CalcolaChecksum(TextBox4.Text, "SHA256")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If String.IsNullOrEmpty(TextBox4.Text) Then
            MessageBox.Show("Seleziona un file prima di calcolare il checksum", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        TextBox5.Text = CalcolaChecksum(TextBox4.Text, "CRC32")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If String.IsNullOrEmpty(TextBox4.Text) Then
            MessageBox.Show("Seleziona un file prima di calcolare il checksum", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        TextBox1.Text = CalcolaChecksum(TextBox4.Text, "MD5")
        TextBox3.Text = CalcolaChecksum(TextBox4.Text, "SHA256")
        TextBox5.Text = CalcolaChecksum(TextBox4.Text, "CRC32")
    End Sub

    Private Function CalcolaChecksum(filePath As String, algoritmo As String) As String
        Using stream As FileStream = File.OpenRead(filePath)
            Select Case algoritmo
                Case "MD5"
                    Using md5 As MD5 = MD5.Create()
                        Return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", "").ToLowerInvariant()
                    End Using
                Case "SHA256"
                    Using sha256 As SHA256 = SHA256.Create()
                        Return BitConverter.ToString(sha256.ComputeHash(stream)).Replace("-", "").ToLowerInvariant()
                    End Using
                Case "CRC32"
                    ' Implementazione CRC32
                    Dim crc32 As New CRC32()
                    Return BitConverter.ToString(crc32.ComputeHash(stream)).Replace("-", "").ToLowerInvariant()
                Case Else
                    Return String.Empty
            End Select
        End Using
    End Function
End Class

Public Class CRC32
    Inherits HashAlgorithm

    Private crc32Table() As UInteger
    Private crcValue As UInteger

    Public Sub New()
        crc32Table = Enumerable.Range(0, 256).Select(Function(i)
                                                         Dim crc As UInteger = CUInt(i)
                                                         For j As Integer = 0 To 7
                                                             If (crc And 1) <> 0 Then
                                                                 crc = (crc >> 1) Xor &HEDB88320UI
                                                             Else
                                                                 crc >>= 1
                                                             End If
                                                         Next
                                                         Return crc
                                                     End Function).ToArray()
        Initialize()
    End Sub

    Public Overrides Sub Initialize()
        crcValue = &HFFFFFFFFUI
    End Sub

    Protected Overrides Sub HashCore(array() As Byte, ibStart As Integer, cbSize As Integer)
        For i As Integer = ibStart To ibStart + cbSize - 1
            crcValue = (crcValue >> 8) Xor crc32Table((crcValue And &HFF) Xor array(i))
        Next
    End Sub

    Protected Overrides Function HashFinal() As Byte()
        crcValue = Not crcValue
        Dim result As Byte() = BitConverter.GetBytes(crcValue)
        If BitConverter.IsLittleEndian Then
            Array.Reverse(result)
        End If
        Return result
    End Function

    Public Overrides ReadOnly Property HashSize As Integer
        Get
            Return 32
        End Get
    End Property
End Class
