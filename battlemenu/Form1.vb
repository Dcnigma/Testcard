Imports System.Windows.Forms.SendKeys
Public Class Form1

    Private Property PictureBox1_BackgroundImage As Bitmap

    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
 

    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
     
        'End

   
    End Sub

    ''' <summary>
    ''' LOAD PAGE
    ''' </summary>
    ''' <remarks>FINSHED I THINK</remarks>

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        NameLabel1.Parent = PictureBox1

        NameLabel2.Parent = PictureBox1
        TextToolStripMenuItem.CheckState = CheckState.Checked
        NameLabel1.Visible = True
        NameLabel2.Visible = True
        NameLabel1.Text = My.Settings.naamlabel1
        NameLabel2.Text = My.Settings.naamlabel2
        My.Settings.marqueetoggle = "0"
        If My.Settings.marqueetoggle = "1" Then CheckBox1.CheckState = CheckState.Checked Else If My.Settings.marqueetoggle = "0" Then CheckBox1.CheckState = CheckState.Unchecked
    End Sub

 

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        'Label3.Text = Label1.Text

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' My.Computer.Keyboard.SendKeys("{F2}")
        ' SendKeys.Send("{up}")
        ' SendKeys.Send("{F2}")
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            Form2.Show()
            Me.Focus()
            My.Settings.marqueetoggle = "1"
        End If
        If CheckBox1.CheckState = CheckState.Unchecked Then
            Form2.Close()
            Me.Focus()
            My.Settings.marqueetoggle = "0"
        End If
    End Sub
    Private Sub PictureBox1_BackgroundImageChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Form2.BackgroundImage = PictureBox1.Image
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Shell(My.Settings.hl2folder + "\hl2.exe -sw -game hl2mp -heapsize 512000 -width 1360 -height 768 -ac -english", AppWinStyle.MaximizedFocus)
        ''Shell(My.Settings.hl2folder + "/HL2Survivor.bat", AppWinStyle.MaximizedFocus)
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub WelcomeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WelcomeToolStripMenuItem.Click
        welcome.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ToolbarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolbarToolStripMenuItem.Click
        If Toolbar.Visible = False Then
            Toolbar.Visible = True
        ElseIf Toolbar.Visible = True Then
            Toolbar.Visible = False
        End If
        If ToolbarToolStripMenuItem.CheckState = CheckState.Checked Then
            ToolbarToolStripMenuItem.CheckState = CheckState.Unchecked = True
        ElseIf ToolbarToolStripMenuItem.CheckState = CheckState.Unchecked Then
            ToolbarToolStripMenuItem.CheckState = CheckState.Checked
        End If
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatusBarToolStripMenuItem.Click
        If StatusStrip1.Visible = False Then
            StatusStrip1.Visible = True
        ElseIf StatusStrip1.Visible = True Then
            StatusStrip1.Visible = False
        End If
        If StatusBarToolStripMenuItem.CheckState = CheckState.Checked Then
            StatusBarToolStripMenuItem.CheckState = CheckState.Unchecked = True
        ElseIf StatusBarToolStripMenuItem.CheckState = CheckState.Unchecked Then
            StatusBarToolStripMenuItem.CheckState = CheckState.Checked
        End If
    End Sub

    Private Sub SetFullscreenViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetFullscreenViewToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub FullscreenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FullscreenToolStripMenuItem.Click


        If FullscreenToolStripMenuItem.CheckState = CheckState.Checked And My.Settings.marqueetoggle = "1" Then
            FullscreenToolStripMenuItem.CheckState = CheckState.Unchecked = True
            CheckBox1.Checked = False

        ElseIf FullscreenToolStripMenuItem.CheckState = CheckState.Unchecked And My.Settings.marqueetoggle = "0" Then
            FullscreenToolStripMenuItem.CheckState = CheckState.Checked
            CheckBox1.Checked = True
        End If



    End Sub



    Private Sub F1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F1ToolStripMenuItem.Click
        If TextToolStripMenuItem.CheckState = CheckState.Checked Then
            NameLabel1.Visible = True And NameLabel2.Visible = True
        End If
        If TextToolStripMenuItem.CheckState = CheckState.Unchecked Then
            NameLabel1.Visible = False And NameLabel2.Visible = False
        End If
        PictureBox1.Image = My.Resources.F1
        Form2.BackgroundImage = My.Resources.F1
        'F1ToolStripMenuItem.CheckState = CheckState.Unchecked
        F2ToolStripMenuItem.CheckState = CheckState.Unchecked
        F3ToolStripMenuItem.CheckState = CheckState.Unchecked
        F4ToolStripMenuItem.CheckState = CheckState.Unchecked
        F5ToolStripMenuItem.CheckState = CheckState.Unchecked
        F6ToolStripMenuItem.CheckState = CheckState.Unchecked
        F7ToolStripMenuItem.CheckState = CheckState.Unchecked
        F8ToolStripMenuItem.CheckState = CheckState.Unchecked
        F9ToolStripMenuItem.CheckState = CheckState.Unchecked
        If F1ToolStripMenuItem.CheckState = CheckState.Checked Then
            F1ToolStripMenuItem.CheckState = CheckState.Unchecked = True
        ElseIf F1ToolStripMenuItem.CheckState = CheckState.Unchecked Then
            F1ToolStripMenuItem.CheckState = CheckState.Checked
        End If



    End Sub

    Private Sub F2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F2ToolStripMenuItem.Click
        If TextToolStripMenuItem.CheckState = CheckState.Checked Then
            NameLabel1.Visible = True And NameLabel2.Visible = True
        End If
        If TextToolStripMenuItem.CheckState = CheckState.Unchecked Then
            NameLabel1.Visible = False And NameLabel2.Visible = False
        End If
        PictureBox1.Image = My.Resources.F2
        Form2.BackgroundImage = My.Resources.F2
        F1ToolStripMenuItem.CheckState = CheckState.Unchecked
        'F2ToolStripMenuItem.CheckState = CheckState.Unchecked
        F3ToolStripMenuItem.CheckState = CheckState.Unchecked
        F4ToolStripMenuItem.CheckState = CheckState.Unchecked
        F5ToolStripMenuItem.CheckState = CheckState.Unchecked
        F6ToolStripMenuItem.CheckState = CheckState.Unchecked
        F7ToolStripMenuItem.CheckState = CheckState.Unchecked
        F8ToolStripMenuItem.CheckState = CheckState.Unchecked
        F9ToolStripMenuItem.CheckState = CheckState.Unchecked
        If F2ToolStripMenuItem.CheckState = CheckState.Checked Then
            F2ToolStripMenuItem.CheckState = CheckState.Unchecked = True
        ElseIf F2ToolStripMenuItem.CheckState = CheckState.Unchecked Then
            F2ToolStripMenuItem.CheckState = CheckState.Checked
        End If



    End Sub

    Private Sub F3ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F3ToolStripMenuItem.Click
        If TextToolStripMenuItem.CheckState = CheckState.Checked Then
            NameLabel1.Visible = True And NameLabel2.Visible = True
        End If
        If TextToolStripMenuItem.CheckState = CheckState.Unchecked Then
            NameLabel1.Visible = False And NameLabel2.Visible = False
        End If
        PictureBox1.Image = My.Resources.f3
        Form2.BackgroundImage = My.Resources.f3
        F1ToolStripMenuItem.CheckState = CheckState.Unchecked
        F2ToolStripMenuItem.CheckState = CheckState.Unchecked
        ' F3ToolStripMenuItem.CheckState = CheckState.Unchecked
        F4ToolStripMenuItem.CheckState = CheckState.Unchecked
        F5ToolStripMenuItem.CheckState = CheckState.Unchecked
        F6ToolStripMenuItem.CheckState = CheckState.Unchecked
        F7ToolStripMenuItem.CheckState = CheckState.Unchecked
        F8ToolStripMenuItem.CheckState = CheckState.Unchecked
        F9ToolStripMenuItem.CheckState = CheckState.Unchecked
        If F3ToolStripMenuItem.CheckState = CheckState.Checked Then
            F3ToolStripMenuItem.CheckState = CheckState.Unchecked = True
        ElseIf F3ToolStripMenuItem.CheckState = CheckState.Unchecked Then
            F3ToolStripMenuItem.CheckState = CheckState.Checked
        End If

    End Sub

    Private Sub F4ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F4ToolStripMenuItem.Click
        PictureBox1.Image = My.Resources.f4
        Form2.BackgroundImage = My.Resources.f4
        F1ToolStripMenuItem.CheckState = CheckState.Unchecked
        F2ToolStripMenuItem.CheckState = CheckState.Unchecked
        F3ToolStripMenuItem.CheckState = CheckState.Unchecked
        ' F4ToolStripMenuItem.CheckState = CheckState.Unchecked
        F5ToolStripMenuItem.CheckState = CheckState.Unchecked
        F6ToolStripMenuItem.CheckState = CheckState.Unchecked
        F7ToolStripMenuItem.CheckState = CheckState.Unchecked
        F8ToolStripMenuItem.CheckState = CheckState.Unchecked
        F9ToolStripMenuItem.CheckState = CheckState.Unchecked
        If F4ToolStripMenuItem.CheckState = CheckState.Checked Then
            F4ToolStripMenuItem.CheckState = CheckState.Unchecked = True
        ElseIf F4ToolStripMenuItem.CheckState = CheckState.Unchecked Then
            F4ToolStripMenuItem.CheckState = CheckState.Checked
        End If

        If TextToolStripMenuItem.CheckState = CheckState.Checked Then
            NameLabel1.Visible = True And NameLabel2.Visible = True
        End If
        If TextToolStripMenuItem.CheckState = CheckState.Unchecked Then
            NameLabel1.Visible = False And NameLabel2.Visible = False
        End If

    End Sub

    Private Sub F5ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F5ToolStripMenuItem.Click
        PictureBox1.Image = My.Resources.f5
        Form2.BackgroundImage = My.Resources.f5
        F1ToolStripMenuItem.CheckState = CheckState.Unchecked
        F2ToolStripMenuItem.CheckState = CheckState.Unchecked
        F3ToolStripMenuItem.CheckState = CheckState.Unchecked
        F4ToolStripMenuItem.CheckState = CheckState.Unchecked
        ' F5ToolStripMenuItem.CheckState = CheckState.Unchecked
        F6ToolStripMenuItem.CheckState = CheckState.Unchecked
        F7ToolStripMenuItem.CheckState = CheckState.Unchecked
        F8ToolStripMenuItem.CheckState = CheckState.Unchecked
        F9ToolStripMenuItem.CheckState = CheckState.Unchecked
        If F5ToolStripMenuItem.CheckState = CheckState.Checked Then
            F5ToolStripMenuItem.CheckState = CheckState.Unchecked = True
        ElseIf F5ToolStripMenuItem.CheckState = CheckState.Unchecked Then
            F5ToolStripMenuItem.CheckState = CheckState.Checked
        End If

        If TextToolStripMenuItem.CheckState = CheckState.Checked Then
            NameLabel1.Visible = True And NameLabel2.Visible = True
        End If
        If TextToolStripMenuItem.CheckState = CheckState.Unchecked Then
            NameLabel1.Visible = False And NameLabel2.Visible = False
        End If


    End Sub

    Private Sub F6ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F6ToolStripMenuItem.Click
        PictureBox1.Image = My.Resources.f6
        Form2.BackgroundImage = My.Resources.f6
        F1ToolStripMenuItem.CheckState = CheckState.Unchecked
        F2ToolStripMenuItem.CheckState = CheckState.Unchecked
        F3ToolStripMenuItem.CheckState = CheckState.Unchecked
        F4ToolStripMenuItem.CheckState = CheckState.Unchecked
        F5ToolStripMenuItem.CheckState = CheckState.Unchecked
        ' F6ToolStripMenuItem.CheckState = CheckState.Unchecked
        F7ToolStripMenuItem.CheckState = CheckState.Unchecked
        F8ToolStripMenuItem.CheckState = CheckState.Unchecked
        F9ToolStripMenuItem.CheckState = CheckState.Unchecked
        If F6ToolStripMenuItem.CheckState = CheckState.Checked Then
            F6ToolStripMenuItem.CheckState = CheckState.Unchecked = True
        ElseIf F6ToolStripMenuItem.CheckState = CheckState.Unchecked Then
            F6ToolStripMenuItem.CheckState = CheckState.Checked
        End If

        If TextToolStripMenuItem.CheckState = CheckState.Checked Then
            NameLabel1.Visible = True And NameLabel2.Visible = True
        End If
        If TextToolStripMenuItem.CheckState = CheckState.Unchecked Then
            NameLabel1.Visible = False And NameLabel2.Visible = False
        End If

    End Sub

    Private Sub F7ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F7ToolStripMenuItem.Click
        PictureBox1.Image = My.Resources.f7
        Form2.BackgroundImage = My.Resources.f7
        F1ToolStripMenuItem.CheckState = CheckState.Unchecked
        F2ToolStripMenuItem.CheckState = CheckState.Unchecked
        F3ToolStripMenuItem.CheckState = CheckState.Unchecked
        F4ToolStripMenuItem.CheckState = CheckState.Unchecked
        F5ToolStripMenuItem.CheckState = CheckState.Unchecked
        F6ToolStripMenuItem.CheckState = CheckState.Unchecked
        ' F7ToolStripMenuItem.CheckState = CheckState.Unchecked
        F8ToolStripMenuItem.CheckState = CheckState.Unchecked
        F9ToolStripMenuItem.CheckState = CheckState.Unchecked
        If F7ToolStripMenuItem.CheckState = CheckState.Checked Then
            F7ToolStripMenuItem.CheckState = CheckState.Unchecked = True
        ElseIf F7ToolStripMenuItem.CheckState = CheckState.Unchecked Then
            F7ToolStripMenuItem.CheckState = CheckState.Checked
        End If
        If TextToolStripMenuItem.CheckState = CheckState.Checked Then
            NameLabel1.Visible = True And NameLabel2.Visible = True
        End If
        If TextToolStripMenuItem.CheckState = CheckState.Unchecked Then
            NameLabel1.Visible = False And NameLabel2.Visible = False
        End If
    End Sub

    Private Sub F8ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F8ToolStripMenuItem.Click
        PictureBox1.Image = My.Resources.f8
        Form2.BackgroundImage = My.Resources.f8
        F1ToolStripMenuItem.CheckState = CheckState.Unchecked
        F2ToolStripMenuItem.CheckState = CheckState.Unchecked
        F3ToolStripMenuItem.CheckState = CheckState.Unchecked
        F4ToolStripMenuItem.CheckState = CheckState.Unchecked
        F5ToolStripMenuItem.CheckState = CheckState.Unchecked
        F6ToolStripMenuItem.CheckState = CheckState.Unchecked
        F7ToolStripMenuItem.CheckState = CheckState.Unchecked
        '  F8ToolStripMenuItem.CheckState = CheckState.Unchecked
        F9ToolStripMenuItem.CheckState = CheckState.Unchecked
        If F8ToolStripMenuItem.CheckState = CheckState.Checked Then
            F8ToolStripMenuItem.CheckState = CheckState.Unchecked = True
        ElseIf F8ToolStripMenuItem.CheckState = CheckState.Unchecked Then
            F8ToolStripMenuItem.CheckState = CheckState.Checked
        End If
        If TextToolStripMenuItem.CheckState = CheckState.Checked Then
            NameLabel1.Visible = True And NameLabel2.Visible = True
        End If
        If TextToolStripMenuItem.CheckState = CheckState.Unchecked Then
            NameLabel1.Visible = False And NameLabel2.Visible = False
        End If
    End Sub

    Private Sub F9ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F9ToolStripMenuItem.Click
        PictureBox1.Image = My.Resources.f9
        Form2.BackgroundImage = My.Resources.f9
        F1ToolStripMenuItem.CheckState = CheckState.Unchecked
        F2ToolStripMenuItem.CheckState = CheckState.Unchecked
        F3ToolStripMenuItem.CheckState = CheckState.Unchecked
        F4ToolStripMenuItem.CheckState = CheckState.Unchecked
        F5ToolStripMenuItem.CheckState = CheckState.Unchecked
        F6ToolStripMenuItem.CheckState = CheckState.Unchecked
        F7ToolStripMenuItem.CheckState = CheckState.Unchecked
        F8ToolStripMenuItem.CheckState = CheckState.Unchecked
        'F9ToolStripMenuItem.CheckState = CheckState.Unchecked
        If F9ToolStripMenuItem.CheckState = CheckState.Checked Then
            F9ToolStripMenuItem.CheckState = CheckState.Unchecked = True
        ElseIf F9ToolStripMenuItem.CheckState = CheckState.Unchecked Then
            F9ToolStripMenuItem.CheckState = CheckState.Checked
        End If
        If TextToolStripMenuItem.CheckState = CheckState.Checked Then
            NameLabel1.Visible = True And NameLabel2.Visible = True
        End If
        If TextToolStripMenuItem.CheckState = CheckState.Unchecked Then
            NameLabel1.Visible = False And NameLabel2.Visible = False
        End If
    End Sub


    Private Sub TextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextToolStripMenuItem.Click


        If Form2.Label1.Visible = True Then
            Form2.Label1.Visible = False
        ElseIf Form2.Label1.Visible = False Then
            Form2.Label1.Visible = True
        End If

        If Form2.Label2.Visible = True Then
            Form2.Label2.Visible = False
        ElseIf Form2.Label2.Visible = False Then
            Form2.Label2.Visible = True
        End If

        If TextToolStripMenuItem.CheckState = CheckState.Checked Then
            NameLabel1.Visible = False
            NameLabel2.Visible = False
            TextToolStripMenuItem.CheckState = CheckState.Unchecked = True
        ElseIf TextToolStripMenuItem.CheckState = CheckState.Unchecked Then
            NameLabel1.Visible = True
            NameLabel2.Visible = True
            TextToolStripMenuItem.CheckState = CheckState.Checked
        End If


    End Sub

    Private Sub NameLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NameLabel1.Click
        'If NameLabel1.Visible = False And NameLabel2.Visible = False Then
        'NameLabel1.Visible = True And NameLabel2.Visible = True
        'ElseIf NameLabel1.Visible = True And NameLabel2.Visible = True Then
        'NameLabel1.Visible = False And NameLabel2.Visible = False
        'End If
    End Sub

    Private Sub NameLabel1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles NameLabel1.TextChanged
   

    End Sub

    Private Sub NameLabel1_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles NameLabel1.VisibleChanged

    End Sub

    Private Sub ChangeTextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeTextToolStripMenuItem.Click
        changetekst.Show()
    End Sub

    Private Sub LineThicknessToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LineThicknessToolStripMenuItem.Click
        If LineThicknessToolStripMenuItem.CheckState = CheckState.Checked Then

            LineThicknessToolStripMenuItem.CheckState = CheckState.Unchecked = True
        ElseIf LineThicknessToolStripMenuItem.CheckState = CheckState.Unchecked Then

            LineThicknessToolStripMenuItem.CheckState = CheckState.Checked
        End If
        line.Show()

    End Sub

    Private Sub AboutTestbeeldToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutTestbeeldToolStripMenuItem.Click
        about.Show()
    End Sub



    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If TextToolStripMenuItem.CheckState = CheckState.Checked Then
            NameLabel1.Visible = True And NameLabel2.Visible = True
        End If
        If TextToolStripMenuItem.CheckState = CheckState.Unchecked Then
            NameLabel1.Visible = False And NameLabel2.Visible = False
        End If

        PictureBox1.Image = My.Resources.F1
        Form2.BackgroundImage = My.Resources.F1
        'F1ToolStripMenuItem.CheckState = CheckState.Unchecked
        F2ToolStripMenuItem.CheckState = CheckState.Unchecked
        F3ToolStripMenuItem.CheckState = CheckState.Unchecked
        F4ToolStripMenuItem.CheckState = CheckState.Unchecked
        F5ToolStripMenuItem.CheckState = CheckState.Unchecked
        F6ToolStripMenuItem.CheckState = CheckState.Unchecked
        F7ToolStripMenuItem.CheckState = CheckState.Unchecked
        F8ToolStripMenuItem.CheckState = CheckState.Unchecked
        F9ToolStripMenuItem.CheckState = CheckState.Unchecked
        If F1ToolStripMenuItem.CheckState = CheckState.Checked Then
            F1ToolStripMenuItem.CheckState = CheckState.Unchecked = True
        ElseIf F1ToolStripMenuItem.CheckState = CheckState.Unchecked Then
            F1ToolStripMenuItem.CheckState = CheckState.Checked
        End If
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        If TextToolStripMenuItem.CheckState = CheckState.Checked Then
            NameLabel1.Visible = True And NameLabel2.Visible = True
        End If
        If TextToolStripMenuItem.CheckState = CheckState.Unchecked Then
            NameLabel1.Visible = False And NameLabel2.Visible = False
        End If
        PictureBox1.Image = My.Resources.F2
        Form2.BackgroundImage = My.Resources.F2
        F1ToolStripMenuItem.CheckState = CheckState.Unchecked
        'F2ToolStripMenuItem.CheckState = CheckState.Unchecked
        F3ToolStripMenuItem.CheckState = CheckState.Unchecked
        F4ToolStripMenuItem.CheckState = CheckState.Unchecked
        F5ToolStripMenuItem.CheckState = CheckState.Unchecked
        F6ToolStripMenuItem.CheckState = CheckState.Unchecked
        F7ToolStripMenuItem.CheckState = CheckState.Unchecked
        F8ToolStripMenuItem.CheckState = CheckState.Unchecked
        F9ToolStripMenuItem.CheckState = CheckState.Unchecked
        If F2ToolStripMenuItem.CheckState = CheckState.Checked Then
            F2ToolStripMenuItem.CheckState = CheckState.Unchecked = True
        ElseIf F2ToolStripMenuItem.CheckState = CheckState.Unchecked Then
            F2ToolStripMenuItem.CheckState = CheckState.Checked
        End If
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click

        PictureBox1.Image = My.Resources.f3
        Form2.BackgroundImage = My.Resources.f3
        F1ToolStripMenuItem.CheckState = CheckState.Unchecked
        F2ToolStripMenuItem.CheckState = CheckState.Unchecked
        ' F3ToolStripMenuItem.CheckState = CheckState.Unchecked
        F4ToolStripMenuItem.CheckState = CheckState.Unchecked
        F5ToolStripMenuItem.CheckState = CheckState.Unchecked
        F6ToolStripMenuItem.CheckState = CheckState.Unchecked
        F7ToolStripMenuItem.CheckState = CheckState.Unchecked
        F8ToolStripMenuItem.CheckState = CheckState.Unchecked
        F9ToolStripMenuItem.CheckState = CheckState.Unchecked
        If F3ToolStripMenuItem.CheckState = CheckState.Checked Then
            F3ToolStripMenuItem.CheckState = CheckState.Unchecked = True
        ElseIf F3ToolStripMenuItem.CheckState = CheckState.Unchecked Then
            F3ToolStripMenuItem.CheckState = CheckState.Checked
        End If
        If TextToolStripMenuItem.CheckState = CheckState.Checked Then
            NameLabel1.Visible = True And NameLabel2.Visible = True
        End If
        If TextToolStripMenuItem.CheckState = CheckState.Unchecked Then
            NameLabel1.Visible = False And NameLabel2.Visible = False
        End If

    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        PictureBox1.Image = My.Resources.f4
        Form2.BackgroundImage = My.Resources.f4
        F1ToolStripMenuItem.CheckState = CheckState.Unchecked
        F2ToolStripMenuItem.CheckState = CheckState.Unchecked
        F3ToolStripMenuItem.CheckState = CheckState.Unchecked
        ' F4ToolStripMenuItem.CheckState = CheckState.Unchecked
        F5ToolStripMenuItem.CheckState = CheckState.Unchecked
        F6ToolStripMenuItem.CheckState = CheckState.Unchecked
        F7ToolStripMenuItem.CheckState = CheckState.Unchecked
        F8ToolStripMenuItem.CheckState = CheckState.Unchecked
        F9ToolStripMenuItem.CheckState = CheckState.Unchecked
        If F4ToolStripMenuItem.CheckState = CheckState.Checked Then
            F4ToolStripMenuItem.CheckState = CheckState.Unchecked = True
        ElseIf F4ToolStripMenuItem.CheckState = CheckState.Unchecked Then
            F4ToolStripMenuItem.CheckState = CheckState.Checked
        End If
        If TextToolStripMenuItem.CheckState = CheckState.Checked Then
            NameLabel1.Visible = True And NameLabel2.Visible = True
        End If
        If TextToolStripMenuItem.CheckState = CheckState.Unchecked Then
            NameLabel1.Visible = False And NameLabel2.Visible = False
        End If

    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        PictureBox1.Image = My.Resources.f5
        Form2.BackgroundImage = My.Resources.f5
        F1ToolStripMenuItem.CheckState = CheckState.Unchecked
        F2ToolStripMenuItem.CheckState = CheckState.Unchecked
        F3ToolStripMenuItem.CheckState = CheckState.Unchecked
        F4ToolStripMenuItem.CheckState = CheckState.Unchecked
        ' F5ToolStripMenuItem.CheckState = CheckState.Unchecked
        F6ToolStripMenuItem.CheckState = CheckState.Unchecked
        F7ToolStripMenuItem.CheckState = CheckState.Unchecked
        F8ToolStripMenuItem.CheckState = CheckState.Unchecked
        F9ToolStripMenuItem.CheckState = CheckState.Unchecked
        If F5ToolStripMenuItem.CheckState = CheckState.Checked Then
            F5ToolStripMenuItem.CheckState = CheckState.Unchecked = True
        ElseIf F5ToolStripMenuItem.CheckState = CheckState.Unchecked Then
            F5ToolStripMenuItem.CheckState = CheckState.Checked
        End If

        If TextToolStripMenuItem.CheckState = CheckState.Checked Then
            NameLabel1.Visible = True And NameLabel2.Visible = True
        End If
        If TextToolStripMenuItem.CheckState = CheckState.Unchecked Then
            NameLabel1.Visible = False And NameLabel2.Visible = False
        End If



    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        PictureBox1.Image = My.Resources.f6
        Form2.BackgroundImage = My.Resources.f6
        F1ToolStripMenuItem.CheckState = CheckState.Unchecked
        F2ToolStripMenuItem.CheckState = CheckState.Unchecked
        F3ToolStripMenuItem.CheckState = CheckState.Unchecked
        F4ToolStripMenuItem.CheckState = CheckState.Unchecked
        F5ToolStripMenuItem.CheckState = CheckState.Unchecked
        ' F6ToolStripMenuItem.CheckState = CheckState.Unchecked
        F7ToolStripMenuItem.CheckState = CheckState.Unchecked
        F8ToolStripMenuItem.CheckState = CheckState.Unchecked
        F9ToolStripMenuItem.CheckState = CheckState.Unchecked
        If F6ToolStripMenuItem.CheckState = CheckState.Checked Then
            F6ToolStripMenuItem.CheckState = CheckState.Unchecked = True
        ElseIf F6ToolStripMenuItem.CheckState = CheckState.Unchecked Then
            F6ToolStripMenuItem.CheckState = CheckState.Checked
        End If
        If TextToolStripMenuItem.CheckState = CheckState.Checked Then
            NameLabel1.Visible = True And NameLabel2.Visible = True
        End If
        If TextToolStripMenuItem.CheckState = CheckState.Unchecked Then
            NameLabel1.Visible = False And NameLabel2.Visible = False
        End If
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        PictureBox1.Image = My.Resources.f7
        Form2.BackgroundImage = My.Resources.f7
        F1ToolStripMenuItem.CheckState = CheckState.Unchecked
        F2ToolStripMenuItem.CheckState = CheckState.Unchecked
        F3ToolStripMenuItem.CheckState = CheckState.Unchecked
        F4ToolStripMenuItem.CheckState = CheckState.Unchecked
        F5ToolStripMenuItem.CheckState = CheckState.Unchecked
        F6ToolStripMenuItem.CheckState = CheckState.Unchecked
        ' F7ToolStripMenuItem.CheckState = CheckState.Unchecked
        F8ToolStripMenuItem.CheckState = CheckState.Unchecked
        F9ToolStripMenuItem.CheckState = CheckState.Unchecked
        If F7ToolStripMenuItem.CheckState = CheckState.Checked Then
            F7ToolStripMenuItem.CheckState = CheckState.Unchecked = True
        ElseIf F7ToolStripMenuItem.CheckState = CheckState.Unchecked Then
            F7ToolStripMenuItem.CheckState = CheckState.Checked
        End If
        If TextToolStripMenuItem.CheckState = CheckState.Checked Then
            NameLabel1.Visible = True And NameLabel2.Visible = True
        End If
        If TextToolStripMenuItem.CheckState = CheckState.Unchecked Then
            NameLabel1.Visible = False And NameLabel2.Visible = False
        End If
    End Sub

    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton8.Click
        PictureBox1.Image = My.Resources.f8
        Form2.BackgroundImage = My.Resources.f8
        F1ToolStripMenuItem.CheckState = CheckState.Unchecked
        F2ToolStripMenuItem.CheckState = CheckState.Unchecked
        F3ToolStripMenuItem.CheckState = CheckState.Unchecked
        F4ToolStripMenuItem.CheckState = CheckState.Unchecked
        F5ToolStripMenuItem.CheckState = CheckState.Unchecked
        F6ToolStripMenuItem.CheckState = CheckState.Unchecked
        F7ToolStripMenuItem.CheckState = CheckState.Unchecked
        '  F8ToolStripMenuItem.CheckState = CheckState.Unchecked
        F9ToolStripMenuItem.CheckState = CheckState.Unchecked
        If F8ToolStripMenuItem.CheckState = CheckState.Checked Then
            F8ToolStripMenuItem.CheckState = CheckState.Unchecked = True
        ElseIf F8ToolStripMenuItem.CheckState = CheckState.Unchecked Then
            F8ToolStripMenuItem.CheckState = CheckState.Checked
        End If
        If TextToolStripMenuItem.CheckState = CheckState.Checked Then
            NameLabel1.Visible = True And NameLabel2.Visible = True
        End If
        If TextToolStripMenuItem.CheckState = CheckState.Unchecked Then
            NameLabel1.Visible = False And NameLabel2.Visible = False
        End If
    End Sub

    Private Sub ToolStripButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton9.Click
        PictureBox1.Image = My.Resources.f9
        Form2.BackgroundImage = My.Resources.f9
        F1ToolStripMenuItem.CheckState = CheckState.Unchecked
        F2ToolStripMenuItem.CheckState = CheckState.Unchecked
        F3ToolStripMenuItem.CheckState = CheckState.Unchecked
        F4ToolStripMenuItem.CheckState = CheckState.Unchecked
        F5ToolStripMenuItem.CheckState = CheckState.Unchecked
        F6ToolStripMenuItem.CheckState = CheckState.Unchecked
        F7ToolStripMenuItem.CheckState = CheckState.Unchecked
        F8ToolStripMenuItem.CheckState = CheckState.Unchecked
        'F9ToolStripMenuItem.CheckState = CheckState.Unchecked
        If F9ToolStripMenuItem.CheckState = CheckState.Checked Then
            F9ToolStripMenuItem.CheckState = CheckState.Unchecked = True
        ElseIf F9ToolStripMenuItem.CheckState = CheckState.Unchecked Then
            F9ToolStripMenuItem.CheckState = CheckState.Checked
        End If
        If TextToolStripMenuItem.CheckState = CheckState.Checked Then
            NameLabel1.Visible = True And NameLabel2.Visible = True
        End If
        If TextToolStripMenuItem.CheckState = CheckState.Unchecked Then
            NameLabel1.Visible = False And NameLabel2.Visible = False
        End If
    End Sub

    Private Sub ToolStripButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton10.Click

        If FullscreenToolStripMenuItem.CheckState = CheckState.Checked And My.Settings.marqueetoggle = "1" Then
            FullscreenToolStripMenuItem.CheckState = CheckState.Unchecked = True
            CheckBox1.Checked = False

        ElseIf FullscreenToolStripMenuItem.CheckState = CheckState.Unchecked And My.Settings.marqueetoggle = "0" Then
            FullscreenToolStripMenuItem.CheckState = CheckState.Checked
            CheckBox1.Checked = True
        End If

    End Sub

    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click

    End Sub

    Private Sub ToolStripButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton11.Click

        If Form2.Label1.Visible = True Then
            Form2.Label1.Visible = False
        ElseIf Form2.Label1.Visible = False Then
            Form2.Label1.Visible = True
        End If

        If Form2.Label2.Visible = True Then
            Form2.Label2.Visible = False
        ElseIf Form2.Label2.Visible = False Then
            Form2.Label2.Visible = True
        End If

        If TextToolStripMenuItem.CheckState = CheckState.Checked Then
            NameLabel1.Visible = False
            NameLabel2.Visible = False
            TextToolStripMenuItem.CheckState = CheckState.Unchecked = True
        ElseIf TextToolStripMenuItem.CheckState = CheckState.Unchecked Then
            NameLabel1.Visible = True
            NameLabel2.Visible = True
            TextToolStripMenuItem.CheckState = CheckState.Checked
        End If

    End Sub

    Private Sub ToolStripButton15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton15.Click
        about.Show()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class
