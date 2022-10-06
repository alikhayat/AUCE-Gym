Imports System.Data.OleDb

Public Class ginfoupdate

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim phone As String = TextBox4.Text
        Dim emer As String = TextBox6.Text
        Dim query As String = "UPDATE [applicants] SET [Name]=?,[lastName]=?,[Gender]=?," +
       "[DateOfBirth]=?,[PhoneNb]=?,[Class/Discount]=?," +
       "[EmergencyNb]=?,[BloodType]=?,[MotherName]=?,[School/Uni]=?,[EducationLevel]=?,[Relative]=?" +
       " WHERE [ID]=?"
        Using con = New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & main.path + "applicants1.mdb;Jet OLEDB:Database Password=janitani2;")


            Using cmd = New OleDbCommand(query, con)
                con.Open()
                cmd.Parameters.AddWithValue("@p1", TextBox1.Text)
                cmd.Parameters.AddWithValue("@p2", TextBox2.Text)
                cmd.Parameters.AddWithValue("@p3", ComboBox1.Text)
                cmd.Parameters.AddWithValue("@p4", DateTimePicker1.Value.ToShortDateString)
                cmd.Parameters.AddWithValue("@p5", phone)

                cmd.Parameters.AddWithValue("@p6", ComboBox2.Text)

                cmd.Parameters.AddWithValue("@p7", emer)
                cmd.Parameters.AddWithValue("@p8", ComboBox4.Text)
                cmd.Parameters.AddWithValue("@p9", TextBox3.Text)
                cmd.Parameters.AddWithValue("@p10", TextBox5.Text)
                cmd.Parameters.AddWithValue("@p11", TextBox10.Text)
                cmd.Parameters.AddWithValue("@p12", TextBox11.Text)
                cmd.Parameters.AddWithValue("@p13", Label13.Text)
                cmd.ExecuteNonQuery()
                con.Close()
                con.Dispose()
            End Using
        End Using
        medup()
        MsgBox("data updated")
        editapplicants.ApplicantsTableAdapter.Fill(editapplicants.Applicants1DataSet1.applicants)
        editapplicants.MedicalTableAdapter.Fill(editapplicants.Applicants1DataSet2.medical)
        subbadd.ApplicantsTableAdapter.Fill(subbadd.Applicants1DataSet3.applicants)
        Me.Close()
    End Sub

    Private Sub ginfoupdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub medup()
        Dim query As String = "UPDATE [medical] SET [MedicineUse]=?,[LongTermDisease]=?,[ScareCauses]=?," +
       "[Allergies]=?,[ProblemStayingAlone]=?,[SocialzingProblems]=?," +
       "[InsuredBy]=?" +
       " WHERE [ID]=?"
        Using con = New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & main.path + "applicants1.mdb;Jet OLEDB:Database Password=janitani2;")


            Using cmd = New OleDbCommand(query, con)
                con.Open()
                cmd.Parameters.AddWithValue("@p1", TextBox7.Text)
                cmd.Parameters.AddWithValue("@p2", TextBox8.Text)
                cmd.Parameters.AddWithValue("@p3", TextBox9.Text)
                cmd.Parameters.AddWithValue("@p4", TextBox12.Text)
                cmd.Parameters.AddWithValue("@p5", TextBox13.Text)

                cmd.Parameters.AddWithValue("@p6", TextBox14.Text)

                cmd.Parameters.AddWithValue("@p7", TextBox15.Text)
                cmd.Parameters.AddWithValue("@p8", Label23.Text)

                cmd.ExecuteNonQuery()
                con.Close()
                con.Dispose()
            End Using
        End Using
    End Sub
End Class