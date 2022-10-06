Public Class Form1
    Public user As String = "admin"
    Public pass As String = My.Settings.pass1
    Public pass1 As String = My.Settings.pass2
    Public pass2 As String = My.Settings.pass3

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "admin" And TextBox2.Text = pass Then
            My.Settings.currentuser = TextBox1.Text
            main.Show()
            Me.Close()
        ElseIf TextBox1.Text = "finance" And TextBox2.Text = pass1 Then
            My.Settings.currentuser = TextBox1.Text
            main.Show()
            Me.Close()
        ElseIf TextBox1.Text = "manager" And TextBox2.Text = pass2 Then
            My.Settings.currentuser = TextBox1.Text
            main.Show()
            Me.Close()
        Else
            MsgBox("wrong username or password")
            TextBox1.Text = ""
            TextBox2.Text = ""

        End If
    End Sub
End Class
