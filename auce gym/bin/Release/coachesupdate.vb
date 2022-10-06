Imports System.Data.OleDb

Public Class coachesupdate

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or ComboBox1.SelectedIndex = -1 Or TextBox5.Text = "" Or _
           TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Or TextBox10.Text = "" Or TextBox11.Text = "" Or TextBox12.Text = "" Or TextBox13.Text = "" Or _
           TextBox14.Text = "" Or ComboBox2.SelectedIndex = -1 Or ComboBox3.SelectedIndex = -1 Or ComboBox4.SelectedIndex = -1 Then
            MsgBox("one or more fields are empty")
        Else
            Dim query As String = "UPDATE [coaches] SET [FullName]=?,[Address]=?,[PhoneNb]=?," +
       "[DateOfBirth]=?,[Nationality]=?,[MartialStatus]=?," +
       "[SpouseName]=?,[Occupation]=?,[DateOfBirthS]=?,[ChildrenDetails]=?,[AUCEfriends]=?,[EmergencyInfo]=?,[Insured]=?,[CompanyInsured]=?,[BloodType]=?,[Email]=?,[TypeOfSalary]=?,[AvailableWeeklyHours]=?,[PreviousWage]=?" +
       " WHERE [ID]=?"
            Using con = New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & main.path + "coaches.mdb")


                Using cmd = New OleDbCommand(query, con)
                    con.Open()
                    cmd.Parameters.AddWithValue("@p1", TextBox1.Text)
                    cmd.Parameters.AddWithValue("@p2", TextBox2.Text)
                    cmd.Parameters.AddWithValue("@p3", TextBox3.Text)
                    cmd.Parameters.AddWithValue("@p4", DateTimePicker1.Value.ToShortDateString)
                    cmd.Parameters.AddWithValue("@p5", TextBox4.Text)
                    cmd.Parameters.AddWithValue("@p6", ComboBox1.Text)
                    cmd.Parameters.AddWithValue("@p7", TextBox5.Text)
                    cmd.Parameters.AddWithValue("@p8", TextBox6.Text)
                    cmd.Parameters.AddWithValue("@p9", TextBox7.Text)
                    cmd.Parameters.AddWithValue("@p10", TextBox8.Text)
                    cmd.Parameters.AddWithValue("@p11", TextBox9.Text)
                    cmd.Parameters.AddWithValue("@p12", TextBox10.Text)
                    cmd.Parameters.AddWithValue("@p13", ComboBox2.Text)
                    cmd.Parameters.AddWithValue("@p14", TextBox11.Text)


                    cmd.Parameters.AddWithValue("@p15", ComboBox3.Text)
                    cmd.Parameters.AddWithValue("@p16", TextBox12.Text)
                    cmd.Parameters.AddWithValue("@p17", ComboBox4.Text)
                    cmd.Parameters.AddWithValue("@p18", TextBox13.Text)
                    cmd.Parameters.AddWithValue("@p19", TextBox14.Text)
                    cmd.Parameters.AddWithValue("@p20", Label25.Text)
                    cmd.ExecuteNonQuery()
                    con.Close()
                End Using
            End Using
            MsgBox("data updated")
            cochesedit.CoachesTableAdapter.Fill(cochesedit.CoachesDataSet.coaches)
            Me.Close()
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

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedIndex = 0 Then
            TextBox11.Text = "none"
        Else
            TextBox11.Text = ""
        End If
    End Sub

    Private Sub coachesupdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class