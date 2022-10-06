Imports System.Data.OleDb

Public Class cochadd
    Dim id As Integer
    Private Sub cochadd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        clear()
        id = My.Settings.coachid
    End Sub
    Public Sub clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        TextBox13.Clear()
        TextBox14.Clear()
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        ComboBox3.SelectedIndex = -1
        ComboBox4.SelectedIndex = -1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or ComboBox1.SelectedIndex = -1 Or TextBox5.Text = "" Or _
            TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Or TextBox10.Text = "" Or TextBox11.Text = "" Or TextBox12.Text = "" Or TextBox13.Text = "" Or _
            TextBox14.Text = "" Or ComboBox2.SelectedIndex = -1 Or ComboBox3.SelectedIndex = -1 Or ComboBox4.SelectedIndex = -1 Then
            MsgBox("one or more fields are empty")
        Else
            Dim objcmd As New System.Data.OleDb.OleDbCommand
            Dim con As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & main.path + "coaches.mdb")
            My.Settings.coachid += 1
            con.Open()
            Dim strSql = ("insert into coaches values ('" + My.Settings.coachid.ToString + "', '" + TextBox1.Text + "', '" + TextBox2.Text + "', '" + TextBox3.Text + "', '" + DateTimePicker1.Value.ToShortDateString + "', '" + TextBox4.Text + "', '" + ComboBox1.Text + "', '" + TextBox5.Text + "', '" + TextBox6.Text + "', '" + _
               TextBox7.Text + "', '" + TextBox8.Text + "', '" + TextBox9.Text + "', '" + TextBox10.Text + "', '" + ComboBox2.Text + "', '" + TextBox11.Text + "', '" + ComboBox3.Text + "', '" + TextBox12.Text + "', '" + ComboBox4.Text + "', '" + TextBox13.Text + "', '" + TextBox14.Text + "', '" + "No" + "')")
            objcmd = New OleDbCommand(strSql, con)


            objcmd.ExecuteNonQuery()

            con.Close()
            MsgBox("coache added")

            clear()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex <> 1 Then
            Label8.Visible = False
            Label9.Visible = False
            Label10.Visible = False
            TextBox5.Visible = False
            TextBox5.Text = "none"
            TextBox6.Visible = False
            TextBox6.Text = "none"
            TextBox7.Visible = False
            TextBox7.Text = "none"
        Else
            Label8.Visible = True
            Label9.Visible = True
            Label10.Visible = True
            TextBox5.Visible = True
            TextBox5.Text = ""
            TextBox6.Visible = True
            TextBox6.Text = ""
            TextBox7.Visible = True
            TextBox7.Text = ""

        End If
    End Sub

    Private Sub ComboBox2_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox2.SelectionChangeCommitted
        If ComboBox2.SelectedIndex = 0 Then
            TextBox11.Text = "none"
        Else
            TextBox11.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            cochesedit.ShowDialog()

        Catch ex As Exception
            Dim s As String = Convert.ToString(ex)
            MsgBox(s)
        End Try
    End Sub
End Class