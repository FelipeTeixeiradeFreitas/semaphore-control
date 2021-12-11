
Public Class Form1
    Dim but2 As Boolean = False
    Dim but3 As Boolean = False
    Dim but4 As Boolean = False
    Dim but5 As Boolean = False
    Dim but6 As Boolean = False
    Dim but7 As Boolean = False
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick



        TextBox1.Text = TextBox1.Text + 1
        OvalShape2.Left += 2
        OvalShape2.Top -= 3
        If OvalShape2.Location.X = 900 And OvalShape9.BackColor = Color.Red Then
            OvalShape2.Left -= 2
            OvalShape2.Top += 3
        End If
        If OvalShape2.Location.Y < 175 Then
            OvalShape2.Location = New Point(900, 601)
            TextBox1.Text = 0
        End If


        TextBox2.Text = TextBox2.Text + 1
        OvalShape1.Left -= 2
        OvalShape1.Top += 3
        If OvalShape1.Location.X = 328 And OvalShape10.BackColor = Color.Red Then
            OvalShape1.Left += 2
            OvalShape1.Top -= 3
        End If
        If OvalShape1.Location.X < 175 Then
            OvalShape1.Location = New Point(482, 99)
            TextBox2.Text = 0
        End If



        OvalShape3.Left -= 2
        OvalShape3.Top -= 2

        If OvalShape3.Location.X < 1334 Then
            OvalShape3.Top += 2
        End If

        If OvalShape3.Location.X = 1159 And OvalShape6.BackColor = Color.Red Then
            OvalShape3.Left += 2
        End If
        If OvalShape3.Location.X = 776 And OvalShape7.BackColor = Color.Red Then
            OvalShape3.Left += 2
        End If
        If OvalShape3.Location.X = 400 And OvalShape8.BackColor = Color.Red Then
            OvalShape3.Left += 2
        End If
        If OvalShape3.Location.X < 262 Then
            OvalShape3.Top -= 2
        End If


        TextBox3.Text = TextBox3.Text + 1
        TextBox4.Text = TextBox4.Text + 1
        TextBox5.Text = TextBox5.Text + 1
        TextBox6.Text = TextBox6.Text + 1


        If TextBox4.Text = 600 Then
            OvalShape6.BackColor = Color.Green
            OvalShape9.BackColor = Color.Red
        End If
        If TextBox4.Text = 750 Then
            OvalShape6.BackColor = Color.Yellow
            OvalShape5.BackColor = Color.Yellow
        End If
        If TextBox4.Text = 800 Then
            OvalShape6.BackColor = Color.Red
            OvalShape9.BackColor = Color.Green
            OvalShape5.BackColor = Color.Red
            TextBox4.Text = 401
        End If
        If TextBox4.Text = 550 Then
            OvalShape9.BackColor = Color.Yellow
        End If
        If TextBox4.Text = 700 Then
            OvalShape5.BackColor = Color.Green
        End If



        If TextBox6.Text = 1400 Then
            OvalShape8.BackColor = Color.Green
            OvalShape10.BackColor = Color.Red
        End If
        If TextBox6.Text = 1550 Then
            OvalShape8.BackColor = Color.Yellow
        End If
        If TextBox6.Text = 1600 Then
            OvalShape8.BackColor = Color.Red
            OvalShape10.BackColor = Color.Green
            TextBox6.Text = 1200
        End If
        If TextBox6.Text = 1350 Then
            OvalShape10.BackColor = Color.Yellow
        End If


        TextBox3.Text = TextBox3.Text + 1

        If OvalShape5.BackColor = Color.Red Then
            LineShape1.BorderColor = Color.Green
        Else
            LineShape1.BorderColor = Color.Red
        End If
        If OvalShape6.BackColor = Color.Red Then
            LineShape2.BorderColor = Color.Green
        Else
            LineShape2.BorderColor = Color.Red
        End If
        If OvalShape7.BackColor = Color.Red Then
            LineShape3.BorderColor = Color.Green
        Else
            LineShape3.BorderColor = Color.Red
        End If
        If OvalShape8.BackColor = Color.Red Then
            LineShape4.BorderColor = Color.Green
        Else
            LineShape4.BorderColor = Color.Red
        End If
        If OvalShape9.BackColor = Color.Red Then
            LineShape5.BorderColor = Color.Green
        Else
            LineShape5.BorderColor = Color.Red
        End If
        If OvalShape10.BackColor = Color.Red Then
            LineShape6.BorderColor = Color.Green
        Else
            LineShape6.BorderColor = Color.Red
        End If



        If OvalShape3.Location.X < 31 Then
            OvalShape3.Location = New Point(1466, 541)
        End If






        OvalShape4.Left -= 2
        OvalShape4.Top -= 2
        If OvalShape4.Location.Y < 280 And OvalShape5.BackColor = Color.Red Then
            OvalShape4.Left += 2
            OvalShape4.Top += 2
        End If
        If OvalShape4.Location.X < 1200 Then
            OvalShape4.Left += 2
        End If
        If OvalShape4.Location.Y < 210 Then
            OvalShape4.Left += 4
        End If
        If OvalShape4.Location.Y < 170 Then
            OvalShape4.Location = New Point(1424, 491)
        End If


        TextBox9.Text = TextBox9.Text + 1
        OvalShape11.Left += 2.2
        OvalShape11.Top -= 3
        ''If OvalShape11.Location.Y < 696 Then
        ''OvalShape7.BackColor = Color.Red
        ''End If
        ''If OvalShape11.Location.Y < 170 Then
        ''OvalShape7.BackColor = Color.Green
        ''End If
        OvalShape12.Left -= 2.2
        OvalShape12.Top += 3
        If OvalShape12.Location.Y > 706 And TextBox9.Text = 1000 And Location.Y < 174 Then
            OvalShape11.Location = New Point(505, 602)
            OvalShape12.Location = New Point(800, 136)

        End If
        If OvalShape12.Location.Y = 300 Then
            OvalShape7.BackColor = Color.Red
            TextBox9.Text = 0
        End If
        ''If OvalShape12.Location.Y = 690 Then
        ''OvalShape7.BackColor = Color.Green
        ''End If
        ''If OvalShape12.Location.Y = 178 Then
        ''OvalShape7.BackColor = Color.Yellow
        ''End If
        If TextBox9.Text = 950 Then
            OvalShape7.BackColor = Color.Yellow
        End If
        If TextBox9.Text = 1000 Then
            OvalShape7.BackColor = Color.Red
            TextBox9.Text = 0
        End If
        If TextBox9.Text = 200 Then
            OvalShape7.BackColor = Color.Green
        End If

        If but7 = True Then
            TextBox4.Text = 100
            If TextBox4.Text = 120 Then
                OvalShape5.BackColor = Color.Yellow
            End If
            If TextBox4.Text = 220 Then
                OvalShape5.BackColor = Color.White
                TextBox4.Text = 100
            End If
        End If


        If but2 = True And TextBox9.Text = 1000 Then
            TextBox4.Text = 401
            TextBox6.Text = 1200
            but2 = False
        End If
        If but3 = True And TextBox9.Text = 1000 Then
            TextBox4.Text = 401
            TextBox6.Text = 1200
            but3 = False
        End If
        If but4 = True And TextBox9.Text = 1000 Then
            TextBox4.Text = 401
            TextBox6.Text = 1200
            but4 = False
        End If
        If but5 = True And TextBox9.Text = 1000 Then
            TextBox4.Text = 401
            TextBox6.Text = 1200
            but5 = False
        End If
        If but6 = True And TextBox9.Text = 1000 Then
            TextBox4.Text = 401
            TextBox6.Text = 1200
            but6 = False
        End If

    End Sub

    Private Sub Form1_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        Label1.Text = "x= " & e.X & " ; y= " & e.Y
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CenterToScreen()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Normal


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox6.Text = 1330
        but2 = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox4.Text = 730
        but5 = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox4.Text = 730
        but6 = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox6.Text = 1530
        but4 = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox4.Text = 530
        but3 = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        but7 = True
    End Sub

End Class
