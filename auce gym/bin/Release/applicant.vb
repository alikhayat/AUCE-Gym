Imports System.Data.OleDb

Public Class applicant
    Dim id As Integer

    Private Sub subadd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       

       
        DateTimePicker1.Value = "1/1/1990"
        clear()
        id = My.Settings.id
    End Sub
    Public Sub clear()
        TextBox1.Clear()
        TextBox2.Clear()
        DateTimePicker1.ResetText()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()

        TextBox10.Clear()
        TextBox11.Clear()
        TextBox9.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox12.Clear()
        TextBox13.Clear()
        TextBox14.Clear()
        TextBox15.Clear()

        TextBox3.Clear()
        ComboBox4.SelectedIndex = -1
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox4.Text = "" Or TextBox6.Text = "" Or ComboBox1.SelectedIndex = -1 Or ComboBox2.SelectedIndex = -1 Or ComboBox4.SelectedIndex = -1 Or TextBox10.Text = "" Or TextBox11.Text = "" Or TextBox3.Text = "" Or TextBox5.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Or TextBox12.Text = "" Or TextBox13.Text = "" Or TextBox14.Text = "" Or TextBox15.Text = "" Then
                MsgBox("one or more fields are empty")
            Else
                Dim phone As String = "961" + TextBox4.Text
                Dim emer As String = "961" + TextBox6.Text
                Dim objcmd As New System.Data.OleDb.OleDbCommand
                Dim con As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & main.path + "applicants1.mdb")
                con.Open()
                My.Settings.id += 1

                Dim strSql = ("insert into applicants values ('" + My.Settings.id.ToString + "', '" + TextBox1.Text + "', '" + TextBox3.Text + "', '" + TextBox2.Text + "', '" + TextBox5.Text + "', '" + TextBox10.Text + "', '" + TextBox11.Text + "', '" + ComboBox1.Text + "', '" + DateTimePicker1.Value.ToShortDateString + "', '" + phone + "', '" + ComboBox4.Text + "', '" + ComboBox2.Text + "', '" + emer + "')")
                objcmd = New OleDbCommand(strSql, con)


                objcmd.ExecuteNonQuery()

                con.Close()
                medical()
                MsgBox("saved")
                clear()
                editapplicants.ApplicantsTableAdapter.Fill(editapplicants.Applicants1DataSet1.applicants)
                editapplicants.MedicalTableAdapter.Fill(editapplicants.Applicants1DataSet2.medical)
                subbadd.ApplicantsTableAdapter.Fill(subbadd.Applicants1DataSet3.applicants)
            End If
        Catch ex As Exception
            MsgBox("Error ocurred")
        End Try
        


    End Sub

   

   

    
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        editapplicants.ShowDialog()
    End Sub
    Public Sub medical()
        Try
            Dim objcmd As New System.Data.OleDb.OleDbCommand
            Dim con As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & main.path + "applicants1.mdb")
            con.Open()
            My.Settings.medid += 1

            Dim strSql = ("insert into medical values ('" + My.Settings.medid.ToString + "', '" + TextBox7.Text + "', '" + TextBox8.Text + "', '" + TextBox9.Text + "', '" + TextBox12.Text + "', '" + TextBox13.Text + "', '" + TextBox14.Text + "', '" + TextBox15.Text + "')")
            objcmd = New OleDbCommand(strSql, con)


            objcmd.ExecuteNonQuery()

            con.Close()
        Catch ex As Exception
            MsgBox("Error occured")
        End Try
       
    End Sub

End Class