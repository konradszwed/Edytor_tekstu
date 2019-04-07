Public Class Form1

    Dim i As Integer
    REM tablica 5 sciezki
    Dim sciezka(4) As String



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nazwapliku As String
        Dim liczba_l As Integer
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True
        If openFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            nazwapliku = openFileDialog1.FileName()
            MsgBox(nazwapliku)
            RichTextBox1.LoadFile(nazwapliku, RichTextBoxStreamType.PlainText)
        End If
        liczba_l = RichTextBox1.Lines.Count()
        MsgBox(liczba_l)
        NumericUpDown1.Maximum = liczba_l - 1
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        Dim n As Integer
        n = NumericUpDown1.Value
        Label1.Text = RichTextBox1.Lines(n)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim nazwapliku As String
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.InitialDirectory = "c:\"
        saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        saveFileDialog1.FilterIndex = 1
        saveFileDialog1.RestoreDirectory = True
        If saveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            nazwapliku = saveFileDialog1.FileName()
            MsgBox(nazwapliku)
            RichTextBox1.SaveFile(nazwapliku, RichTextBoxStreamType.PlainText)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim nazwapliku As String
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = "png files (*.png)|*.png|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True
        If openFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            nazwapliku = openFileDialog1.FileName()
            MsgBox(nazwapliku)
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
            PictureBox1.Load(nazwapliku)
        End If
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Select Case i
            Case 0
                PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
            Case 1
                PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
            Case 2
                PictureBox1.SizeMode = PictureBoxSizeMode.Normal
            Case 3
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            Case 4
                PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        End Select
        i = i + 1
        If i = 5 Then i = 0
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        REM Timer1.Start() 
        Timer1.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Select i
            Case 0

                PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize

            Case 1

                PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage

            Case 2

                PictureBox1.SizeMode = PictureBoxSizeMode.Normal

            Case 3

                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

            Case 4

                PictureBox1.SizeMode = PictureBoxSizeMode.Zoom

        End Select
        i = i + 1
        If i = 5 Then i = 0
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Select Case i
            Case 0
                PictureBox1.Load(sciezka(0))
            Case 1
                PictureBox1.Load(sciezka(1))

            Case 2
                PictureBox1.Load(sciezka(2))

            Case 3
                PictureBox1.Load(sciezka(3))

            Case 4
                PictureBox1.Load(sciezka(4))

        End Select
        i = i + 1
        If i = 5 Then i = 0
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For i As Integer = 0 To 4

            Dim nazwapliku As String
            Dim openFileDialog1 As New OpenFileDialog()
            openFileDialog1.InitialDirectory = "c:\"
            openFileDialog1.Filter = "png files (*.png)|*.png|All files (*.*)|*.*"
            openFileDialog1.FilterIndex = 2
            openFileDialog1.RestoreDirectory = True
            If openFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                nazwapliku = openFileDialog1.FileName()
                MsgBox(nazwapliku)
                PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
                PictureBox1.Load(nazwapliku)
                sciezka(i) = openFileDialog1.FileName()


            End If
        Next
        Timer1.Enabled = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Timer1.Enabled = True Then
            Timer1.Enabled = False
        Else
            Timer1.Enabled = True
        End If


    End Sub
End Class
