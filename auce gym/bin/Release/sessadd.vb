Imports System.Data.OleDb

Public Class sessadd
    Dim id As Integer
    Dim con As Boolean = False
    Dim d As String = ""


    Private Sub sessadd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CoachesDataSet1.coaches' table. You can move, or remove it, as needed.
        Me.CoachesTableAdapter.Fill(Me.CoachesDataSet1.coaches)

        'TODO: This line of code loads data into the 'ClassesDataSet.classes' table. You can move, or remove it, as needed.
        Me.ClassesTableAdapter.Fill(Me.ClassesDataSet.classes)
        DataGridView2.Visible = False
        Label12.Text = Now.ToShortDateString
        clear()
        id = My.Settings.sesid
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

    End Sub
    Public Sub clear()
        TextBox1.Clear()
        TextBox2.Clear()
        ComboBox1.SelectedIndex = -1
        ComboBox6.SelectedIndex = -1
        ComboBox4.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        TextBox3.Clear()
        TextBox4.Clear()
        Dim i As Integer

        For i = 0 To (CheckedListBox1.Items.Count - 1) 'Listbox is the listbox's name

            CheckedListBox1.SetItemChecked(i, False)

        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        rese()
        check()
        conflict()
        Dim checkeditems As String = ""
        If CheckedListBox1.SelectedIndex <> -1 Then

            For Each itemchecked In CheckedListBox1.CheckedItems
                checkeditems += itemchecked + vbCrLf
            Next
        End If
        If CheckedListBox1.SelectedIndex <> -1 Then
            Select Case CheckedListBox1.SelectedIndex
                Case 0
                    d += " 0"
                Case 1
                    d += " 1"
                Case 2
                    d += " 2"
                Case 3
                    d += " 3"
                Case 4
                    d += " 4"
                Case 5
                    d += " 5"
                Case 6
                    d += " 6"
            End Select
        End If

        If TextBox1.Text = "" Or TextBox2.Text = "" Or ComboBox1.SelectedIndex = -1 Or ComboBox4.SelectedIndex = -1 Or ComboBox2.SelectedIndex = -1 Or CheckedListBox1.SelectedIndex = -1 Then
            MsgBox("one or more fields are empty")
        ElseIf TextBox4.Text = "" Then
            MsgBox("please fill in the salary")

        ElseIf con = True Then
            MsgBox("this class conflicts with another class")
            Stop
        Else
            Try
                Dim objcmd As New System.Data.OleDb.OleDbCommand
                Dim con As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & main.path + "classes.mdb")
                My.Settings.sesid += 1
                con.Open()
                Dim strSql = ("insert into classes values ('" + My.Settings.sesid.ToString + "', '" + TextBox1.Text + "', '" + ComboBox1.Text + "', '" + checkeditems + "', '" + DateTimePicker1.Value.ToShortTimeString + "', '" + DateTimePicker2.Value.ToShortTimeString + "', '" + Label12.Text + "', '" + ComboBox4.Text + "', '" + ComboBox2.Text + "', '" + ComboBox6.Text + "', '" + TextBox2.Text + "', '" + "No" + "', '" + "to be detemined" + "')")
                objcmd = New OleDbCommand(strSql, con)


                objcmd.ExecuteNonQuery()

                con.Close()
                MsgBox("class added")
                salary()
                Me.ClassesTableAdapter.Fill(Me.ClassesDataSet.classes)
                main.ClassesTableAdapter.Fill(main.ClassesDataSet2.classes)
                clear()
            Catch ex As Exception
                MsgBox(Convert.ToString(ex))
            End Try

        End If
    End Sub

   

    

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Dim con As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & main.path + "classes.mdb")
        con.Open()
        Dim myadapter As New OleDb.OleDbDataAdapter("select * from sessions where Name like'" + TextBox3.Text + "%'", con)
        Dim ds As New DataSet
        myadapter.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        Label10.Text = DataGridView1.RowCount.ToString

        con.Close()
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        Try
            sessionsedit.Label9.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString
            sessionsedit.TextBox1.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString
            sessionsedit.ComboBox1.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString
            sessionsedit.ComboBox2.Text = DataGridView1.SelectedRows(0).Cells(3).Value.ToString
            sessionsedit.DateTimePicker1.Text = DataGridView1.SelectedRows(0).Cells(4).Value.ToString
            sessionsedit.DateTimePicker2.Text = DataGridView1.SelectedRows(0).Cells(5).Value.ToString
            sessionsedit.Label12.Text = DataGridView1.SelectedRows(0).Cells(6).Value.ToString
            sessionsedit.ComboBox6.Text = DataGridView1.SelectedRows(0).Cells(9).Value.ToString
            sessionsedit.ComboBox4.Text = DataGridView1.SelectedRows(0).Cells(7).Value.ToString
            sessionsedit.ComboBox2.Text = DataGridView1.SelectedRows(0).Cells(8).Value.ToString
            sessionsedit.TextBox2.Text = DataGridView1.SelectedRows(0).Cells(10).Value.ToString
            sessionsedit.Label17.Text = DataGridView1.SelectedRows(0).Cells(11).Value.ToString
            sessionsedit.ShowDialog()
        Catch ex As Exception

        End Try
        
    End Sub

    Public Sub conflict()

        Dim used As String = ""
        If My.Settings.mon = True Then
            used += "Monday "
        ElseIf My.Settings.tue = True Then
            used += "Tuesday "
        ElseIf My.Settings.wed = True Then
            used += "Wednesday "
        ElseIf My.Settings.thu = True Then
            used += "Thursday "
        ElseIf My.Settings.fri = True Then
            used += "Friday "
        ElseIf My.Settings.sat = True Then
            used += "Saturday "
        ElseIf My.Settings.sun = True Then
            used += "Sunday "
        End If
        Try
            If used.Contains(CheckedListBox1.CheckedItems.ToString) Or CheckedListBox1.CheckedItems.ToString.Contains(used) Then
                For i As Integer = 0 To DataGridView1.Rows.Count

                    If DataGridView1.Rows(i).Cells(4).Value.ToString = DateTimePicker1.Text Then
                        If DataGridView1.Rows(i).Cells(9).Value.ToString = ComboBox6.Text Then
                            con = True

                        End If

                    End If

                Next
            End If

        Catch ex As Exception

        End Try


    End Sub
    Public Sub check()

        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(i).Cells(3).Value.ToString.Contains("Monday") Then
                My.Settings.mon = True

            ElseIf DataGridView1.Rows(i).Cells(3).Value.ToString.Contains("Tuesday") Then
                My.Settings.tue = True
            ElseIf DataGridView1.Rows(i).Cells(3).Value.ToString.Contains("Thursday") Then
                My.Settings.thu = True
            ElseIf DataGridView1.Rows(i).Cells(3).Value.ToString.Contains("Wednesday") Then
                My.Settings.wed = True
            ElseIf DataGridView1.Rows(i).Cells(3).Value.ToString.Contains("Friday") Then
                My.Settings.fri = True
            ElseIf DataGridView1.Rows(i).Cells(3).Value.ToString.Contains("Saturday") Then
                My.Settings.sat = True
            ElseIf DataGridView1.Rows(i).Cells(3).Value.ToString.Contains("Sunday") Then
                My.Settings.sun = True
            End If

        Next
    End Sub
    Public Sub rese()
        My.Settings.mon = False
        My.Settings.tue = False
        My.Settings.wed = False
        My.Settings.thu = False
        My.Settings.fri = False
        My.Settings.sat = False
        My.Settings.sun = False

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        For Each row As DataGridViewRow In DataGridView2.Rows
            If ComboBox4.Text = row.Cells(1).Value.ToString Then
                Label16.Text = row.Cells(17).Value.ToString
            End If
        Next
    End Sub
    Public Sub salary()
        Dim tday As Date = Convert.ToDateTime(Today.ToShortDateString)
            Dim objcmd As New System.Data.OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & main.path + "coaches.mdb")
            My.Settings.salaryid += 1
            con.Open()
        Dim strSql = ("insert into coachesSalaries values ('" + My.Settings.salaryid.ToString + "', '" + ComboBox4.Text + "', '" + Label16.Text + "', '" + TextBox4.Text + "', '" + TextBox1.Text + "', '" + "No" + "', '" + "No" + "', '" + "to be determined" + "', '" + tday + "', '" + My.Settings.sesid.ToString + "')")
            objcmd = New OleDbCommand(strSql, con)

            objcmd.ExecuteNonQuery()

            con.Close()

    End Sub
    Public Sub days()
        Dim objcmd As New System.Data.OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & main.path + "classes.mdb")
        My.Settings.sesid += 1
        con.Open()
        Dim strSql = ("insert into Days values ('" + My.Settings.sesid.ToString + "', '" + d + "')")
        objcmd = New OleDbCommand(strSql, con)


        objcmd.ExecuteNonQuery()

        con.Close()
        main.DaysTableAdapter.Fill(main.ClassesDataSet3.Days)
    End Sub
End Class