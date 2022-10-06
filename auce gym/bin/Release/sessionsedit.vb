Imports System.Data.OleDb

Public Class sessionsedit
    Dim coachsalary As String = ""
    
    Private Sub sessionsedit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CoachesDataSet3.coachesSalaries' table. You can move, or remove it, as needed.
        Me.CoachesSalariesTableAdapter.Fill(Me.CoachesDataSet3.coachesSalaries)
       
        'TODO: This line of code loads data into the 'CoachesDataSet2.coaches' table. You can move, or remove it, as needed.
        Me.CoachesTableAdapter.Fill(Me.CoachesDataSet2.coaches)
        DataGridView2.Visible = False
        Button1.Visible = False
        DataGridView1.Visible = False
        Label12.Text = Today.ToShortDateString
        valida()

        Try
            Dim myConnToAccess = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + main.path + "coaches.mdb")
            myConnToAccess.Open()
            Dim ds = New DataSet
            Dim tables = ds.Tables
            Dim da = New OleDbDataAdapter("SELECT FullName from coaches'", myConnToAccess)
            da.Fill(ds, "coaches")
            Dim view1 As New DataView(tables(0))
            With ComboBox4
                .DataSource = ds.Tables("coaches")
                .DisplayMember = "FullName"
                .ValueMember = "FullName"

                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.ListItems

            End With
           
        Catch

        End Try
        Try
            Dim myConnToAccess = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + main.path + "coaches.mdb")
            myConnToAccess.Open()
            Dim ds = New DataSet
            Dim tables = ds.Tables
            Dim da = New OleDbDataAdapter("SELECT FullName from coaches'", myConnToAccess)
            da.Fill(ds, "coaches")
            Dim view1 As New DataView(tables(0))
            With ComboBox2
                .DataSource = ds.Tables("coaches")
                .DisplayMember = "FullName"
                .ValueMember = "FullName"

                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.ListItems

            End With
        Catch
        End Try
        ComboBox4.Text = sessadd.DataGridView1.SelectedRows(0).Cells(7).Value.ToString
        ComboBox2.Text = sessadd.DataGridView1.SelectedRows(0).Cells(8).Value.ToString
    End Sub
   
    Public Sub valida()
        Try
            If Label17.Text = "No" Then
                Button2.Visible = True
                Button3.Visible = True
            Else
                Button3.Visible = False
                Button2.Visible = False
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim checkeditems As String = ""
        If CheckedListBox1.SelectedIndex <> -1 Then

            For Each itemchecked In CheckedListBox1.CheckedItems
                checkeditems += itemchecked + vbCrLf
            Next
        End If
        
        If TextBox1.Text = "" Or TextBox2.Text = "" Or ComboBox1.SelectedIndex = -1 Or ComboBox2.SelectedIndex = -1 Or ComboBox6.SelectedIndex = -1 Or ComboBox4.SelectedIndex = -1 Or CheckedListBox1.SelectedIndex = -1 Then
            MsgBox("one or more fields are empty")
        Else
            Dim query As String = "UPDATE [classes] SET [Name]=?,[Gender]=?,[Days]=?," +
           "[startTime]=?,[endTime]=?,[Coach]=?," +
           "[Substitute]=?, [room]=?, [price]=?,[DateAdded]=? WHERE [ID]=?"

            Using con = New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & main.path + "classes.mdb")


                Using cmd = New OleDbCommand(query, con)
                    con.Open()
                    cmd.Parameters.AddWithValue("@p1", TextBox1.Text)
                    cmd.Parameters.AddWithValue("@p2", ComboBox1.Text)
                    cmd.Parameters.AddWithValue("@p3", checkeditems)
                    cmd.Parameters.AddWithValue("@p4", DateTimePicker1.Value.ToShortTimeString)
                    cmd.Parameters.AddWithValue("@p5", DateTimePicker2.Value.ToShortTimeString)


                    cmd.Parameters.AddWithValue("@p6", ComboBox4.Text)
                    cmd.Parameters.AddWithValue("@p7", ComboBox2.Text)
                    cmd.Parameters.AddWithValue("@p8", ComboBox6.Text)
                    cmd.Parameters.AddWithValue("@p9", TextBox2.Text)
                    cmd.Parameters.AddWithValue("@p10", Label12.Text)
                    cmd.Parameters.AddWithValue("@p11", Label9.Text)

                    cmd.ExecuteNonQuery()
                    con.Close()
                End Using
            End Using
            sessadd.ClassesTableAdapter.Fill(sessadd.ClassesDataSet.classes)
            main.ClassesTableAdapter.Fill(main.ClassesDataSet2.classes)
            salaryupdate()
            MsgBox("Data updated")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label12.Text = Now
        If sessadd.DataGridView1.SelectedRows(0).Cells(7).Value.ToString = "none" Then
            MsgBox("Please assign a coach then activate")
        Else
            Dim query As String = "UPDATE [Classes] SET [Active]=?,[DateActivated]=? WHERE [ID]=?"

            Using con = New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & main.path + "classes.mdb")


                Using cmd = New OleDbCommand(query, con)
                    con.Open()
                    cmd.Parameters.AddWithValue("@p1", "Yes")
                    cmd.Parameters.AddWithValue("@p2", Label12.Text)
                    cmd.Parameters.AddWithValue("@p3", Label9.Text)


                    cmd.ExecuteNonQuery()
                    con.Close()
                End Using
            End Using
            sessadd.ClassesTableAdapter.Fill(sessadd.ClassesDataSet.classes)
            main.ClassesTableAdapter.Fill(main.ClassesDataSet2.classes)
            main.CoachesSalariesTableAdapter.Fill(main.CoachesDataSet4.coachesSalaries)
            activatesalary()
            MsgBox("Class is Active")
            Label17.Text = "Active"
            valida()
            main.upcoming()
        End If
        
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim query As String = "DELETE from [classes] WHERE [ID]=? "

        Using con = New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & main.path + "classes.mdb")


            Using cmd = New OleDbCommand(query, con)
                con.Open()
                cmd.Parameters.AddWithValue("@p1", Label9.Text)

                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
        sessadd.ClassesTableAdapter.Fill(sessadd.ClassesDataSet.classes)
        MsgBox("class deleted")
        Me.Close()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Button1.Visible = True
    End Sub
    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Button1.Visible = True
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        Button1.Visible = True
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox6.SelectedIndexChanged
        Button1.Visible = True
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Button1.Visible = True
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Button1.Visible = True
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Button1.Visible = True
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        Button1.Visible = True
        For Each row As DataGridViewRow In DataGridView2.Rows
            If ComboBox4.Text = row.Cells(1).Value.ToString Then
                Label16.Text = row.Cells(17).Value.ToString
            End If
        Next
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Button1.Visible = True
    End Sub
   
    Public Sub salaryupdate()
        Try
            For Each row As DataGridViewRow In DataGridView1.Rows


                If row.Cells(9).Value.ToString = Label9.Text And row.Cells(6).Value.ToString = "No" Then
                    Dim id As String = row.Cells(0).Value.ToString
                    Dim query As String = "UPDATE [coachesSalaries] SET [FullName]=?,[TypeOfSalary]=?,[Salary]=?,[Class]=? WHERE [ID]=? "

                    Using con = New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & main.path + "coaches.mdb")


                        Using cmd = New OleDbCommand(query, con)
                            con.Open()
                            cmd.Parameters.AddWithValue("@p1", ComboBox4.Text)
                            cmd.Parameters.AddWithValue("@p2", Label16.Text)
                            cmd.Parameters.AddWithValue("@p3", TextBox4.Text)
                            cmd.Parameters.AddWithValue("@p4", TextBox1.Text)
                            cmd.Parameters.AddWithValue("@p5", id)

                            cmd.ExecuteNonQuery()
                            con.Close()
                        End Using
                    End Using
                    Exit For
                End If

            Next
        Catch ex As Exception

        End Try
        

    End Sub
    Public Sub activatesalary()
        Dim tday As Date = Convert.ToDateTime(Today.ToShortDateString)
        Try
            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Cells(9).Value.ToString = Label9.Text And row.Cells(1).Value.ToString = ComboBox4.Text And row.Cells(5).Value.ToString = "No" Then
                    Dim query As String = "UPDATE [coachesSalaries] SET [Active]=?,[DateActivated]=? WHERE [ID]=? "

                    Using con = New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & main.path + "coaches.mdb")


                        Using cmd = New OleDbCommand(query, con)
                            con.Open()
                            cmd.Parameters.AddWithValue("@p1", "Yes")
                            cmd.Parameters.AddWithValue("@p2", tday)
                            cmd.Parameters.AddWithValue("@p3", row.Cells(0).Value.ToString)

                            cmd.ExecuteNonQuery()
                            con.Close()
                        End Using
                    End Using
                    Exit For
                End If
            Next
        Catch ex As Exception
            MsgBox(Convert.ToString(ex))
        End Try

    End Sub
    Public Sub active()
        For Each row As DataGridViewRow In DataGridView2.Rows
            If row.Cells(0).Value.ToString = Label9.Text And row.Cells(13).Value.ToString = "No" Then
                Button2.Visible = True
            Else
                Button2.Visible = False
            End If
        Next
    End Sub
    Public Sub delete()
        For Each row As DataGridViewRow In DataGridView2.Rows
            If row.Cells(0).Value.ToString = Label9.Text And row.Cells(13).Value.ToString = "Yes" Then
                Button3.Visible = False
            Else
                Button3.Visible = True
            End If
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim ds = New DataSet
            Dim tables = ds.Tables

            Dim da As OleDb.OleDbDataAdapter = New OleDbDataAdapter()
            Dim con = New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & main.path + "activereg.mdb")
            con.Open()
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand("Select Name , LastName , DateOfBirth , PhoneNb from ActiveReg WHERE Valid=? and  Class=? ", con)

            cmd.Parameters.AddWithValue("@p1", "Yes")
            cmd.Parameters.AddWithValue("@p2", TextBox1.Text)


            con.Close()
            

            da.SelectCommand = cmd
            da.Fill(ds)
            reports.datagridview1.DataSource = ds.Tables(0)


            reports.ShowDialog()
        Catch ex As Exception
            MsgBox(Convert.ToString(ex))
        End Try
    End Sub
End Class