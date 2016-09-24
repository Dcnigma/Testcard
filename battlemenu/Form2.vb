Public Class Form2
    Dim CW As Integer = Me.Width ' Current Width
    Dim CH As Integer = Me.Height ' Current Height
    Dim IW As Integer = Me.Width ' Initial Width
    Dim IH As Integer = Me.Height ' Initial Height

    'Dim CW As Integer = Me.Width ' Current Width
    'Dim CH As Integer = Me.Height ' Current Height
    'Dim IW As Integer = "800" ' Initial Width
    'Dim IH As Integer = "600" ' Initial Height

   


    Private Sub Form2_BackgroundImageChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.BackgroundImageChanged
        If Form1.TextToolStripMenuItem.CheckState = CheckState.Checked Then
            Label1.Visible = True
            Label2.Visible = True
        End If
        If Form1.TextToolStripMenuItem.CheckState = CheckState.Unchecked Then
            Label1.Visible = False
            Label2.Visible = False
        End If
    End Sub

    Private Sub Form2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        Dim RW As Double = (Me.Width - CW) / CW  ' Ratio change of width
        Dim RH As Double = (Me.Height - CH) / CH  ' Ratio change of height

        For Each Ctrl As Control In Controls
            Ctrl.Width += CInt(Ctrl.Width * RW)
            Ctrl.Height += CInt(Ctrl.Height * RH)
            Ctrl.Left += CInt(Ctrl.Left * RW)
            Ctrl.Top += CInt(Ctrl.Top * RH)
            ' Ctrl.Bottom += CInt(Ctrl.Bottom * RH)
        Next

        CW = Me.Width
        CH = Me.Height
    End Sub

    Private Sub Form2_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter


    End Sub


    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        IW = Me.Width + 5

        IH = Me.Height + 50

        Label1.Text = Form1.NameLabel1.Text
        Label2.Text = Form1.NameLabel2.Text
        Me.BackgroundImage = Form1.PictureBox1.Image

        Form3.Label1.Text = My.Settings.SetpossionX
        Form3.Label2.Text = My.Settings.SetpossionY

        Me.Height = My.Settings.SetSizeHight
        Me.Width = My.Settings.SetSizeWith
        Me.Location = New Point(CInt(Form3.Label1.Text), CInt(Form3.Label2.Text))
       
        If Form1.TextToolStripMenuItem.CheckState = CheckState.Checked Then
            Label1.Visible = True
            Label2.Visible = True
        End If
        If Form1.TextToolStripMenuItem.CheckState = CheckState.Unchecked Then
            Label1.Visible = False
            Label2.Visible = False
        End If
  


    End Sub




    Private Sub Form2_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Move
        Form3.Label1.Text = Me.Location.X.ToString
        Form3.Label2.Text = Me.Location.Y.ToString
    End Sub



    Private Sub Form2_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize


        Dim RW As Double = (Me.Width - CW) / CW  ' Ratio change of width
        Dim RH As Double = (Me.Height - CH) / CH  ' Ratio change of height

        For Each Ctrl As Control In Controls
            Ctrl.Width += CInt(Ctrl.Width * RW)
            Ctrl.Height += CInt(Ctrl.Height * RH)
            Ctrl.Left += CInt(Ctrl.Left * RW)
            Ctrl.Top += CInt(Ctrl.Top * RH)
            ' Ctrl.Bottom += CInt(Ctrl.Bottom * RH)
        Next

        CW = Me.Width
        CH = Me.Height
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        If Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None Then
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
        ElseIf Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable Then
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        End If
    End Sub

    
End Class