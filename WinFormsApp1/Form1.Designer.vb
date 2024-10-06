<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        OpenFileDialog1 = New OpenFileDialog()
        Button1 = New Button()
        Label3 = New Label()
        Label4 = New Label()
        Button2 = New Button()
        Button3 = New Button()
        TextBox3 = New TextBox()
        TextBox5 = New TextBox()
        TextBox7 = New TextBox()
        Label5 = New Label()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Button7 = New Button()
        TextBox2 = New TextBox()
        Label10 = New Label()
        Button8 = New Button()
        Label11 = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        TextBox4 = New TextBox()
        Label12 = New Label()
        TextBox6 = New TextBox()
        NotifyIcon1 = New NotifyIcon(components)
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F)
        Label1.Location = New Point(133, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(371, 25)
        Label1.TabIndex = 0
        Label1.Text = "File Checksum Tool MD5, SHA-256, CRC-32"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 12F)
        TextBox1.Location = New Point(85, 129)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(567, 29)
        TextBox1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13F)
        Label2.Location = New Point(5, 101)
        Label2.Name = "Label2"
        Label2.Size = New Size(141, 25)
        Label2.TabIndex = 2
        Label2.Text = "MD5 Checksum:"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(189, 104)
        Button1.Name = "Button1"
        Button1.Size = New Size(113, 23)
        Button1.TabIndex = 3
        Button1.Text = "Calcolo MD5"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13F)
        Label3.Location = New Point(5, 161)
        Label3.Name = "Label3"
        Label3.Size = New Size(174, 25)
        Label3.TabIndex = 4
        Label3.Text = "SHA-256 Checksum:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 13F)
        Label4.Location = New Point(5, 217)
        Label4.Name = "Label4"
        Label4.Size = New Size(162, 25)
        Label4.TabIndex = 5
        Label4.Text = "CRC-32 Checksum:"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(189, 163)
        Button2.Name = "Button2"
        Button2.Size = New Size(113, 23)
        Button2.TabIndex = 6
        Button2.Text = "Calcolo SHA-256"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(189, 220)
        Button3.Name = "Button3"
        Button3.Size = New Size(113, 23)
        Button3.TabIndex = 7
        Button3.Text = "Calcolo CRC-32"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 12F)
        TextBox3.Location = New Point(84, 189)
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(567, 29)
        TextBox3.TabIndex = 9
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Segoe UI", 12F)
        TextBox5.Location = New Point(85, 242)
        TextBox5.Name = "TextBox5"
        TextBox5.ReadOnly = True
        TextBox5.Size = New Size(567, 29)
        TextBox5.TabIndex = 11
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(149, 314)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(489, 23)
        TextBox7.TabIndex = 13
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 13F)
        Label5.Location = New Point(5, 286)
        Label5.Name = "Label5"
        Label5.Size = New Size(210, 25)
        Label5.TabIndex = 14
        Label5.Text = "Comparatore di stringhe:"
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(221, 288)
        Button4.Name = "Button4"
        Button4.Size = New Size(113, 23)
        Button4.TabIndex = 16
        Button4.Text = "Compara"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(473, 95)
        Button5.Name = "Button5"
        Button5.Size = New Size(179, 32)
        Button5.TabIndex = 17
        Button5.Text = "Calcolo con tutti gli algoritmi"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(549, 55)
        Button6.Name = "Button6"
        Button6.Size = New Size(103, 23)
        Button6.TabIndex = 18
        Button6.Text = "Seleziona il file"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 13F)
        Label6.Location = New Point(5, 336)
        Label6.Name = "Label6"
        Label6.Size = New Size(143, 25)
        Label6.TabIndex = 19
        Label6.Text = "Seconda stringa:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 13F)
        Label7.Location = New Point(5, 242)
        Label7.Name = "Label7"
        Label7.Size = New Size(73, 25)
        Label7.TabIndex = 20
        Label7.Text = "Output:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 13F)
        Label8.Location = New Point(6, 131)
        Label8.Name = "Label8"
        Label8.Size = New Size(73, 25)
        Label8.TabIndex = 21
        Label8.Text = "Output:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 13F)
        Label9.Location = New Point(5, 189)
        Label9.Name = "Label9"
        Label9.Size = New Size(73, 25)
        Label9.TabIndex = 22
        Label9.Text = "Output:"
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(558, 371)
        Button7.Name = "Button7"
        Button7.Size = New Size(99, 23)
        Button7.TabIndex = 23
        Button7.Text = "Esci"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(149, 338)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(489, 23)
        TextBox2.TabIndex = 24
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 13F)
        Label10.Location = New Point(28, 311)
        Label10.Name = "Label10"
        Label10.Size = New Size(120, 25)
        Label10.TabIndex = 25
        Label10.Text = "Prima stringa:"
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(342, 288)
        Button8.Name = "Button8"
        Button8.Size = New Size(228, 23)
        Button8.TabIndex = 26
        Button8.Text = "Compara senza distinzione di maiuscole"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 11F)
        Label11.Location = New Point(6, 31)
        Label11.Name = "Label11"
        Label11.Size = New Size(115, 20)
        Label11.TabIndex = 28
        Label11.Text = "File selezionato:"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI", 10F)
        TextBox4.Location = New Point(5, 54)
        TextBox4.Name = "TextBox4"
        TextBox4.ReadOnly = True
        TextBox4.Size = New Size(538, 25)
        TextBox4.TabIndex = 29
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 13F)
        Label12.Location = New Point(63, 363)
        Label12.Name = "Label12"
        Label12.Size = New Size(85, 25)
        Label12.TabIndex = 30
        Label12.Text = "Risultato:"
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Segoe UI", 11F)
        TextBox6.Location = New Point(149, 364)
        TextBox6.Name = "TextBox6"
        TextBox6.ReadOnly = True
        TextBox6.Size = New Size(136, 27)
        TextBox6.TabIndex = 31
        ' 
        ' NotifyIcon1
        ' 
        NotifyIcon1.Text = "NotifyIcon1"
        NotifyIcon1.Visible = True
        ' 
        ' Form1
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = SystemColors.Control
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(657, 398)
        Controls.Add(TextBox6)
        Controls.Add(Label12)
        Controls.Add(TextBox4)
        Controls.Add(Label11)
        Controls.Add(Button8)
        Controls.Add(Label10)
        Controls.Add(TextBox2)
        Controls.Add(Button7)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Label5)
        Controls.Add(TextBox7)
        Controls.Add(TextBox5)
        Controls.Add(TextBox3)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        DoubleBuffered = True
        Font = New Font("Segoe UI", 9F)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Form1"
        Text = "File Checksum Tool v1.0.0.1 by Francescoohh"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents NotifyIcon1 As NotifyIcon

End Class
