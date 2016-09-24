Public Class changetekst

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = "Testbeeld"
        TextBox2.Text = "© Bart Hamblok"
        My.Settings.naamlabel1 = TextBox1.Text
        My.Settings.naamlabel2 = TextBox2.Text
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        My.Settings.naamlabel1 = TextBox1.Text
        My.Settings.naamlabel2 = TextBox2.Text
        TextBox1.Text = My.Settings.naamlabel1
        TextBox2.Text = My.Settings.naamlabel2

    End Sub

    Private Sub changetekst_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.naamlabel1
        TextBox2.Text = My.Settings.naamlabel2
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form1.NameLabel1.Text = My.Settings.naamlabel1
        Form1.NameLabel2.Text = My.Settings.naamlabel2
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        My.Settings.naamlabel1 = TextBox1.Text
        My.Settings.naamlabel2 = TextBox2.Text
        Form1.NameLabel1.Text = My.Settings.naamlabel1
        Form1.NameLabel2.Text = My.Settings.naamlabel2
        Form2.Label1.Text = My.Settings.naamlabel1
        Form2.Label2.Text = My.Settings.naamlabel2
        Me.Close()
    End Sub
End Class