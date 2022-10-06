Public Class changepass

    Private Sub changepass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "finance" And TextBox2.Text = Form1.pass1 And TextBox3.Text <> " " Then
            My.Settings.pass2 = TextBox3.Text
            MsgBox("password changed")
            Me.Close()
        ElseIf TextBox1.Text = "admin" And TextBox2.Text = Form1.pass And TextBox3.Text <> " " Then
            My.Settings.pass1 = TextBox3.Text
            MsgBox("password changed")
            Me.Close()
        ElseIf TextBox1.Text = "manager" And TextBox2.Text = Form1.pass2 And TextBox3.Text <> " " Then
            My.Settings.pass3 = TextBox3.Text
            MsgBox("password changed")
            Me.Close()
        Else
            MsgBox("user or password doesn't match please try again")
        End If
    End Sub
End Class