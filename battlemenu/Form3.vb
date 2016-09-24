
Public Class Form3

    Dim CW As Integer = Me.Width ' Current Width
    Dim CH As Integer = Me.Height ' Current Height
    Dim IW As Integer = Me.Width ' Initial Width
    Dim IH As Integer = Me.Height ' Initial Height
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Settings.SetSizeHight = Me.Size.Height
        My.Settings.SetSizeWith = Me.Size.Width

        Label1.Text = Me.Location.X
        Label2.Text = Me.Location.Y
        My.Settings.SetpossionX = Label1.Text
        My.Settings.SetpossionY = Label2.Text
        ' Me.StartPosition = My.Settings.SetpossionX
        Me.Location = New Point(CInt(Label1.Text), CInt(Label2.Text))
        Me.Close()
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Label1.Text = My.Settings.SetpossionX
        Label2.Text = My.Settings.SetpossionY
        Me.Height = My.Settings.SetSizeHight
        Me.Width = My.Settings.SetSizeWith
        IW = Me.Width
        IH = Me.Height
        '  Me.StartPosition = My.Settings.SetpossionX
        ' My.Settings.SetpossionX = Me.Location.X
        'My.Settings.SetpossionY = Me.Location.Y
        'Label1.Text = Me.Location.X
        'Label2.Text = Me.Location.Y
        Me.Location = New Point(CInt(Label1.Text), CInt(Label2.Text))

    End Sub

    Private Sub Form3_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Move
        Label1.Text = Me.Location.X.ToString
        Label2.Text = Me.Location.Y.ToString
    End Sub

    Private Sub Form3_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Dim RW As Double = (Me.Width - CW) / CW ' Ratio change of width
        Dim RH As Double = (Me.Height - CH) / CH ' Ratio change of height

        For Each Ctrl As Control In Controls
            Ctrl.Width += CInt(Ctrl.Width * RW)
            Ctrl.Height += CInt(Ctrl.Height * RH)
            Ctrl.Left += CInt(Ctrl.Left * RW)
            Ctrl.Top += CInt(Ctrl.Top * RH)
        Next

        CW = Me.Width
        CH = Me.Height

    End Sub

End Class