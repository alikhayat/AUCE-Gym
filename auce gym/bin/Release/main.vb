Imports System.Data.OleDb

Public Class main
    Public totalsubs As Integer
    Public totals As Decimal
    Public classest As Integer = 0
    Dim dayy As DayOfWeek
    Public path As String = My.Settings.path
    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        

        lod()

    End Sub
    Public Sub lod()
        'TODO: This line of code loads data into the 'DailyDataSet.Daily' table. You can move, or remove it, as needed.
        Me.DailyTableAdapter.Fill(Me.DailyDataSet.Daily)
        'TODO: This line of code loads data into the 'ClassesDataSet3.Days' table. You can move, or remove it, as needed.
        Me.DaysTableAdapter.Fill(Me.ClassesDataSet3.Days)

        'TODO: This line of code loads data into the 'ClassesDataSet2.classes' table. You can move, or remove it, as needed.
        Me.ClassesTableAdapter.Fill(Me.ClassesDataSet2.classes)
        'TODO: This line of code loads data into the 'ActiveregDataSet.ActiveReg' table. You can move, or remove it, as needed.
        Me.ActiveRegTableAdapter.Fill(Me.ActiveregDataSet.ActiveReg)
        validatee()
        Me.ActiveRegTableAdapter.Fill(Me.ActiveregDataSet.ActiveReg)
        'TODO: This line of code loads data into the 'StockDataSet.stock' table. You can move, or remove it, as needed.
        Me.StockTableAdapter.Fill(Me.StockDataSet.stock)
        'TODO: This line of code loads data into the 'CoachesDataSet4.coachesSalaries' table. You can move, or remove it, as needed.
        Me.CoachesSalariesTableAdapter.Fill(Me.CoachesDataSet4.coachesSalaries)
        'TODO: This line of code loads data into the 'StockDataSet.stock' table. You can move, or remove it, as needed.
        Me.StockTableAdapter.Fill(Me.StockDataSet.stock)

        subbadd.ApplicantsTableAdapter.Fill(subbadd.Applicants1DataSet3.applicants)
        editapplicants.MedicalTableAdapter.Fill(editapplicants.Applicants1DataSet2.medical)
        upcoming()
        DataGridView6.Visible = False
        DataGridView7.Visible = False
        DataGridView8.Visible = False
        DataGridView9.Visible = False
        depliting()
        ComboBox1.Visible = False
        If My.Settings.a = 0 Then
            My.Settings.lastdate = Now
            My.Settings.a += 1
        End If

        Label11.Text = Decimal.Round(My.Settings.totalrevenue - My.Settings.expenses, 1, MidpointRounding.AwayFromZero).ToString
        Label16.Text = My.Settings.currentuser


        Label20.Text = My.Settings.totalsubs.ToString
        Label21.Text = My.Settings.substoday.ToString
        Label22.Text = DataGridView3.RowCount.ToString
        Dim t As Decimal = My.Settings.totalrevenue - My.Settings.totalexpense
        Label46.Text = t.ToString + " L.L"
        Dim res As Boolean = chkdate()
        If res = True Then
            Try

                For Each item In My.Settings.listbox3
                    ListBox3.Items.Add(item)
                Next

            Catch ex As Exception

            End Try
        ElseIf res = False Then
            dateadvance()
            Try
                ListBox3.Items.Clear()
                My.Settings.listbox3.Clear()
            Catch ex As Exception

            End Try

            My.Settings.substoday = 0
            Label21.Text = My.Settings.substoday.ToString
        End If
        daily()
        subex()
        salariess()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        changepass.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim form1 As New Form1



        form1.Show()
        form1.TextBox1.Clear()
        form1.TextBox2.Clear()
        Me.Close()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        applicant.ShowDialog()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        sessadd.ShowDialog()
    End Sub



    Private Sub main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        My.Settings.totals = totals
    End Sub
    Public Sub listb()
        If My.Settings.listbox3 Is Nothing Then
            My.Settings.listbox3 = New System.Collections.Specialized.StringCollection()
        End If

        My.Settings.listbox3.Clear()
        For Each item In ListBox3.Items
            My.Settings.listbox3.Add(item)
        Next

    End Sub
    Public Sub subex()

        Dim con As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "activereg.mdb")
        con.Open()

        Dim myadapter As New OleDb.OleDbDataAdapter("select Name,lastName from ActiveReg where DateSubscribed <# " + Today.AddDays(-30) + "#", con)
        Dim da As New DataSet
        myadapter.Fill(da)
        DataGridView4.DataSource = da.Tables(0)
        Label23.Text = DataGridView4.RowCount.ToString

    End Sub



    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged, TextBox2.TextChanged
        Dim con As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "activereg.mdb")
        con.Open()
        Dim myadapter As New OleDb.OleDbDataAdapter("select * from ActiveReg where Name like'" + TextBox2.Text + "%' and lastName like'" + TextBox3.Text + "%'", con)
        Dim ds As New DataSet
        myadapter.Fill(ds)
        DataGridView3.DataSource = ds.Tables(0)
        Label22.Text = DataGridView3.RowCount.ToString

        con.Close()
    End Sub
    Public Sub dateadvance()
        Dim a As Integer = (Now - My.Settings.lastdate).Days
        If My.Settings.lastdate.Day.Equals(Today.Date) Then
            My.Settings.lastdate = Now
        Else
            My.Settings.lastdate = Now
        End If

    End Sub
    Public Function chkdate() As Boolean
        If My.Settings.lastdate.Date.Equals(Today.Date) Then
            Return True
        Else : Return False
        End If

    End Function


    




    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        cochadd.ShowDialog()
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        
        
    End Sub

    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        Try
            Dim datee As String = TryCast(sender, String)
            Dim day As Date = Convert.ToDateTime(datee)
            dayy = day.DayOfWeek
            Dim tt As String = ""
            Select Case dayy
                Case 1
                    tt = "Monday"
                Case 2
                    tt = "Tuesday"
                Case 3
                    tt = "Wednesday"
                Case 4
                    tt = "Thursday"
                Case 5
                    tt = "Friday"
                Case 6
                    tt = "Saturday"
                Case 7
                    tt = "Sunday"
            End Select
            Dim y As String = "Yes"
            Dim myConnToAccess = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + "classes.mdb")
            myConnToAccess.Open()
            Dim ds = New DataSet
            Dim tables = ds.Tables

            Dim da As OleDb.OleDbDataAdapter = New OleDbDataAdapter()
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand("SELECT Name FROM Classes WHERE Active=?,DateAdded=?,Days=? ", myConnToAccess)
            cmd.Parameters.AddWithValue("@p1", y)
            cmd.Parameters.AddWithValue("@p2", -datee <= -30)

            da.SelectCommand = cmd
            da.Fill(ds, "classes")
            Dim view1 As New DataView(tables(0))
            myConnToAccess.Close()
            With ComboBox1
                .DataSource = ds.Tables("classes")
                .DisplayMember = "Name"
                .ValueMember = "Name"
                .SelectedIndex = 0
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With
            ComboBox1.Visible = True
        Catch ex As Exception
            MsgBox(Convert.ToString(ex))
        End Try
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        subbadd.ShowDialog()
    End Sub

    
    Private Sub TabPage5_Click(sender As Object, e As EventArgs) Handles TabPage5.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        stockadd.ShowDialog()
        stockadd.Button1.Visible = True
        stockadd.Button2.Visible = False
    End Sub

    Private Sub DataGridView2_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView2.SelectionChanged
        Try
            stockadd.TextBox1.Text = DataGridView2.SelectedRows(0).Cells(1).Value.ToString
            stockadd.TextBox2.Text = DataGridView2.SelectedRows(0).Cells(3).Value.ToString
            stockadd.TextBox3.Text = DataGridView2.SelectedRows(0).Cells(4).Value.ToString
            stockadd.TextBox4.Text = DataGridView2.SelectedRows(0).Cells(2).Value.ToString
            stockadd.Label8.Text = DataGridView2.SelectedRows(0).Cells(0).Value.ToString
            stockadd.Button2.Visible = True
            stockadd.Button1.Visible = False
            stockadd.ShowDialog()
        Catch ex As Exception

        End Try
        

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged, TextBox4.TextChanged
        Try
            Dim con As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "stock.mdb")
            con.Open()
            Dim myadapter As New OleDb.OleDbDataAdapter("select * from stock where Name like'" + TextBox4.Text + "%' and ID like'" + TextBox5.Text + "%'", con)
            Dim ds As New DataSet
            myadapter.Fill(ds)
            DataGridView2.DataSource = ds.Tables(0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox1.Clear()
        TextBox6.Clear()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If TextBox1.Text.TrimEnd = "" Then
            MsgBox("Please fill Id")
        ElseIf TextBox6.Text.TrimEnd = "" Then
            MsgBox("Please specify quantity")
        Else
            Dim id As String = TextBox1.Text
            Dim quantity As Integer = 0
            quantity = Convert.ToInt32(TextBox6.Text)
            For Each row As DataGridViewRow In DataGridView2.Rows
                If row.Cells(0).Value.ToString = id Then
                    Dim name As String = row.Cells(1).Value.ToString
                    Dim retail As Decimal = 0
                    retail = Convert.ToDecimal(row.Cells(4).Value.ToString)
                    Dim quan As Integer = 0
                    quan = Convert.ToInt32(row.Cells(2).Value.ToString)
                    If quan - quantity < 0 Then
                        MsgBox("not enought quantity")
                    Else
                        Dim total As Decimal = 0
                        total = retail * quantity
                        My.Settings.revenue += total
                        My.Settings.totalrevenue += total
                        Label38.Text = My.Settings.revenue.ToString + " L.L"
                        Label39.Text = My.Settings.totalrevenue.ToString + " L.L"
                        MsgBox(row.Cells(1).Value.ToString + " Quantity= " + quantity.ToString + " SubTotal= " + total.ToString + " L.L")
                        Label11.Text = Decimal.Round(My.Settings.totalrevenue, 1, MidpointRounding.AwayFromZero).ToString
                        Dim quantityleft As Integer = quan - quantity
                        Dim q As String = Convert.ToString(quantityleft)
                        Dim i As String = row.Cells(0).Value.ToString
                        Dim query As String = "UPDATE [stock] SET [Quantity]=? WHERE [ID]=? "


                        Using con = New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "stock.mdb")

                            Using cmd = New OleDbCommand(query, con)
                                con.Open()
                                cmd.Parameters.AddWithValue("@p1", q)
                                cmd.Parameters.AddWithValue("@p2", i)

                                cmd.ExecuteNonQuery()
                                con.Close()
                            End Using
                        End Using
                        Dim item As String = row.Cells(1).Value.ToString
                        Dim baseP As String = row.Cells(3).Value.ToString
                        Dim retaill As String = row.Cells(4).Value.ToString
                        Dim revenue As Decimal = (retail * quantity) - (Convert.ToDecimal(row.Cells(3).Value.ToString) * quantity)
                        Dim rev As String = Convert.ToString(revenue)
                        Dim objcmdd As New System.Data.OleDb.OleDbCommand
                        Dim cn As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "stock.mdb")
                        Dim tday As Date = Convert.ToDateTime(Today.ToShortDateString)
                        cn.Open()
                        My.Settings.srevenue += 1
                        Dim strSqll = ("insert into sold values ('" + My.Settings.srevenue.ToString + "', '" + item + "', '" + baseP + "', '" + retaill + "', '" + TextBox6.Text + "', '" + tday + "', '" + rev + "')")
                        objcmdd = New OleDbCommand(strSqll, cn)


                        objcmdd.ExecuteNonQuery()

                        cn.Close()
                        Me.StockTableAdapter.Fill(Me.StockDataSet.stock)
                        lod()
                    End If
                End If
            Next


        End If
        depliting()
    End Sub

    
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim id As String = TextBox1.Text
        Try
            For Each row As DataGridViewRow In DataGridView2.Rows
                If id = row.Cells(0).Value.ToString Then
                    Label31.Text = row.Cells(1).Value.ToString
                Else
                    Label31.Text = ""
                End If
            Next
        Catch ex As Exception

        End Try
        
    End Sub
    Public Sub depliting()
        Try
            Dim ds = New DataSet
            Dim tables = ds.Tables

            Dim da As OleDb.OleDbDataAdapter = New OleDbDataAdapter()
            Dim con = New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "stock.mdb")
            con.Open()
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand("Select ID , Name , Quantity  from Stock WHERE Quantity<? ", con)

            cmd.Parameters.AddWithValue("@p1", 5)



            con.Close()


            da.SelectCommand = cmd
            da.Fill(ds)
            DataGridView5.DataSource = ds.Tables(0)

        Catch ex As Exception
            MsgBox(Convert.ToString(ex))
        End Try
       
    End Sub
    Public Sub upcoming()
        Dim todayy As DayOfWeek = Now.DayOfWeek
        Dim tt As String = ""
        classesdetails.ListBox1.Items.Clear()
        Select Case todayy
            Case 1
                tt = "Monday"
            Case 2
                tt = "Tuesday"
            Case 3
                tt = "Wednesday"
            Case 4
                tt = "Thursday"
            Case 5
                tt = "Friday"
            Case 6
                tt = "Saturday"
            Case 7
                tt = "Sunday"
        End Select
        classest = 0

        For i As Integer = 0 To DataGridView6.Rows.Count - 1
            Dim count As Integer = 0
            If DataGridView6.Rows(i).Cells(11).Value.ToString = "Yes" Then
                If DataGridView6.Rows(i).Cells(3).Value.ToString.Contains(tt) Then
                    Dim du As Date = DataGridView6.Rows(i).Cells(4).Value.ToString
                    If du > Today.ToShortTimeString Then
                        classest += 1

                        Dim con As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "activereg.mdb")
                        con.Open()
                        Dim c As String = DataGridView6.Rows(i).Cells(1).Value.ToString
                        Dim myadapter As OleDb.OleDbDataAdapter = New OleDbDataAdapter()
                        Dim cmd As OleDbCommand
                        cmd = New OleDbCommand("SELECT Name FROM ActiveReg WHERE Class = ? ", con)
                        cmd.Parameters.Add("Class", c)
                        myadapter.SelectCommand = cmd
                        Dim da As New DataSet
                        myadapter.Fill(da)
                        con.Close()
                        For Each table As DataTable In da.Tables
                            count += table.Rows.Count
                            classesdetails.ListBox1.Items.Add("- " + DataGridView6.Rows(i).Cells(1).Value.ToString + "    Nb of subscribers= " + count.ToString)
                        Next

                    End If
                End If
            End If
        Next
        Label17.Text = classest.ToString
        

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        classesdetails.ShowDialog()
    End Sub

    Public Sub daily()
        Label39.Text = My.Settings.totalrevenue.ToString + " L.L"
        Label36.Text = My.Settings.subrev.ToString + " L.L"
        Label37.Text = My.Settings.inrevenue.ToString + " L.L"
        Label38.Text = My.Settings.revenue.ToString + " L.L"
        Label41.Text = My.Settings.expenses.ToString + " L.L"
        Label42.Text = My.Settings.totalexpense.ToString + " L.L"
        Label40.Text = My.Settings.salaryex.ToString + " L.L"
        Label11.Text = Decimal.Round(My.Settings.totalrevenue - My.Settings.expenses, 1, MidpointRounding.AwayFromZero).ToString
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim result As Integer = MessageBox.Show("Are you sure ?", "confirmation", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then

        ElseIf result = DialogResult.No Then
            MessageBox.Show("No pressed")
        ElseIf result = DialogResult.Yes Then
            If My.Settings.did <> 0 Then
                Dim cn As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "daily.mdb")
                Dim c As Integer = DataGridView8.RowCount
                Dim query As String = "UPDATE [Daily] SET [Confirmed]=? WHERE [ID]=?"

                Using con = New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "daily.mdb")


                    Using cmd = New OleDbCommand(query, con)
                        con.Open()
                        cmd.Parameters.AddWithValue("@p1", "Yes")
                        cmd.Parameters.AddWithValue("@p2", c)

                        cmd.ExecuteNonQuery()
                        con.Close()
                    End Using
                End Using

                My.Settings.did += 1
                Dim objcmdd As New System.Data.OleDb.OleDbCommand

                cn.Open()

                Dim strSqll = ("insert into Daily values ('" + My.Settings.did.ToString + "', '" + Today.ToShortDateString + "', '" + Label36.Text + "', '" + Label37.Text + "', '" + Label38.Text + "', '" + Label39.Text + "', '" + Label41.Text + "', '" + Label40.Text + "', '" + Label42.Text + "', '" + "yes" + "')")
                objcmdd = New OleDbCommand(strSqll, cn)


                objcmdd.ExecuteNonQuery()

                cn.Close()
                My.Settings.totalrevenue = 0
                My.Settings.revenue = 0
                My.Settings.subrev = 0
                My.Settings.inrevenue = 0
                My.Settings.expenses = 0
                My.Settings.totalexpense = 0
                Me.DailyTableAdapter.Fill(Me.DailyDataSet.Daily)
                MsgBox("Confirmed")
                lod()
            ElseIf My.Settings.did = 0 Then
                Dim cn As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "daily.mdb")
                Dim objcmdd As New System.Data.OleDb.OleDbCommand

                cn.Open()
                My.Settings.did += 1
                Dim strSqll = ("insert into Daily values ('" + My.Settings.did.ToString + "', '" + Today.ToShortDateString + "', '" + Label36.Text + "', '" + Label37.Text + "', '" + Label38.Text + "', '" + Label39.Text + "', '" + Label41.Text + "', '" + Label40.Text + "', '" + Label42.Text + "', '" + "Yes" + "')")
                objcmdd = New OleDbCommand(strSqll, cn)


                objcmdd.ExecuteNonQuery()

                cn.Close()
                My.Settings.totalrevenue = 0
                My.Settings.revenue = 0
                My.Settings.subrev = 0
                My.Settings.inrevenue = 0
                My.Settings.expenses = 0
                My.Settings.totalexpense = 0
                Me.DailyTableAdapter.Fill(Me.DailyDataSet.Daily)
                MsgBox("Confirmed")
                lod()
            End If
           
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
       
    End Sub

    
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If CheckBox1.Checked = True And CheckBox2.Checked = False And CheckBox3.Checked = False Then
            Try
                Dim con As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "ActiveReg.mdb")
                con.Open()
                Dim myadapter As New OleDb.OleDbDataAdapter("select  Name , LastName , Class_Discount , DateSubscribed , Class , RecieptNb , AmountPaid from ActiveReg where DateSubscribed Between #" & _
                                            DateTimePicker1.Value.ToShortDateString & "# And #" & _
                                            DateTimePicker2.Value.ToShortDateString & "#", con)
                Dim ds As New DataSet
                myadapter.Fill(ds)
                reports.datagridview1.DataSource = ds.Tables(0)
                con.Close()
                reports.ShowDialog()
            Catch ex As Exception
                MsgBox(Convert.ToString(ex))
            End Try
        ElseIf CheckBox1.Checked = False And CheckBox2.Checked = True And CheckBox3.Checked = False Then
            Try
                Dim con As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "activereg.mdb")
                con.Open()
                Dim myadapter As New OleDb.OleDbDataAdapter("select * from insurance where DateInsured Between #" & _
                                            DateTimePicker1.Value.ToShortDateString & "# And #" & _
                                            DateTimePicker2.Value.ToShortDateString & "#", con)
                Dim ds As New DataSet
                myadapter.Fill(ds)
                reports.datagridview1.DataSource = ds.Tables(0)

                con.Close()
                reports.ShowDialog()
            Catch ex As Exception
                MsgBox(Convert.ToString(ex))
            End Try
        ElseIf CheckBox1.Checked = False And CheckBox2.Checked = False And CheckBox3.Checked = True Then
            Try
                Dim con As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "Stock.mdb")
                con.Open()
                Dim myadapter As New OleDb.OleDbDataAdapter("select * from sold where DateSold Between #" & _
                                            DateTimePicker1.Value.ToShortDateString & "# And #" & _
                                            DateTimePicker2.Value.ToShortDateString & "#", con)
                Dim ds As New DataSet
                myadapter.Fill(ds)
                reports.datagridview1.DataSource = ds.Tables(0)
                con.Close()
                reports.ShowDialog()
            Catch ex As Exception
                MsgBox(Convert.ToString(ex))
            End Try
        ElseIf CheckBox7.Checked = True Then
            Try
                Dim con As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "daily.mdb")
                con.Open()
                Dim myadapter As New OleDb.OleDbDataAdapter("select Subrev , Inrev , Strev , Totrev from Daily where Date Between #" & _
                                            DateTimePicker1.Value.ToShortDateString & "# And #" & _
                                            DateTimePicker2.Value.ToShortDateString & "#", con)
                Dim ds As New DataSet
                myadapter.Fill(ds)
                reports.datagridview1.DataSource = ds.Tables(0)
                con.Close()
                reports.ShowDialog()
            Catch ex As Exception
                MsgBox(Convert.ToString(ex))
            End Try

        Else
            MsgBox("Please select a category first")
        End If

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False


        CheckBox7.Checked = False
        CheckBox8.Checked = False
        CheckBox4.Checked = False
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        CheckBox1.Checked = False
        CheckBox3.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False


        CheckBox7.Checked = False
        CheckBox8.Checked = False
        CheckBox4.Checked = False
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox5.Checked = True Then
            CheckBox5.Checked = False
            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox7.Checked = False
            CheckBox8.Checked = False
            CheckBox4.Checked = False
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox6.Checked = True Then
            CheckBox6.Checked = False
            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
            CheckBox7.Checked = False
            CheckBox8.Checked = False
            CheckBox4.Checked = False
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If CheckBox6.Checked = True And CheckBox5.Checked = False Then
            Try
                Dim con As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "stock.mdb")
                con.Open()
                Dim myadapter As New OleDb.OleDbDataAdapter("select * from expenses where DateAdded Between #" & _
                                            DateTimePicker1.Value.ToShortDateString & "# And #" & _
                                            DateTimePicker2.Value.ToShortDateString & "#", con)
                Dim ds As New DataSet
                myadapter.Fill(ds)
                reports.datagridview1.DataSource = ds.Tables(0)

                con.Close()
                reports.ShowDialog()
            Catch ex As Exception
                MsgBox(Convert.ToString(ex))
            End Try
        ElseIf CheckBox6.Checked = False And CheckBox5.Checked = True Then
            Try
                Dim con As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "coaches.mdb")
                con.Open()
                Dim myadapter As New OleDb.OleDbDataAdapter("select * from SalariesPaid where Date Between #" & _
                                            DateTimePicker1.Value.ToShortDateString & "# And #" & _
                                            DateTimePicker2.Value.ToShortDateString & "#", con)
                Dim ds As New DataSet
                myadapter.Fill(ds)
                reports.datagridview1.DataSource = ds.Tables(0)

                con.Close()
                reports.ShowDialog()
            Catch ex As Exception
                MsgBox(Convert.ToString(ex))
            End Try
        ElseIf CheckBox8.Checked = True Then
            Try
                Dim con As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "daily.mdb")
                con.Open()
                Dim myadapter As New OleDb.OleDbDataAdapter("select Stexp , Salexp , Totexp from Daily where Date Between #" & _
                                            DateTimePicker1.Value.ToShortDateString & "# And #" & _
                                            DateTimePicker2.Value.ToShortDateString & "#", con)
                Dim ds As New DataSet
                myadapter.Fill(ds)
                reports.datagridview1.DataSource = ds.Tables(0)

                con.Close()
                reports.ShowDialog()
            Catch ex As Exception
                MsgBox(Convert.ToString(ex))
            End Try
        End If
    End Sub
    Private Sub validatee()
        Try
            For Each row As DataGridViewRow In DataGridView3.Rows
                Dim d As Date = Convert.ToDateTime(row.Cells(16).Value.ToString)
                If (Now - d).Days > 31 Then
                    Dim cn As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "activereg.mdb")
                    Dim id As Integer = Convert.ToInt32(row.Cells(0).Value.ToString)
                    Dim query As String = "UPDATE [ActiveReg] SET [valid]=? WHERE [ID]=?"

                    Using con = New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "activereg.mdb")


                        Using cmd = New OleDbCommand(query, con)
                            con.Open()
                            cmd.Parameters.AddWithValue("@p1", "No")
                            cmd.Parameters.AddWithValue("@p2", id)

                            cmd.ExecuteNonQuery()
                            con.Close()
                        End Using
                    End Using
                End If
            Next
        Catch ex As Exception
            MsgBox(Convert.ToString(ex))
        End Try
        
    End Sub

    
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        reciept.Show()
    End Sub
    Public Sub salariess()
        Dim unpaid As Integer = 0
        For Each row As DataGridViewRow In DataGridView9.Rows
            Dim da As Date = Convert.ToDateTime(row.Cells(8).Value.ToString)

            If row.Cells(6).Value.ToString = "No" And (Now - da).Days > 30 And (Now - da).Days < 40 Then
                unpaid += 1
                Label58.Text = unpaid.ToString
                Coaches.Items.Add(row.Cells(1).Value.ToString)

            End If
        Next
    End Sub
    

    Private Sub TabControl1_MouseClick(sender As Object, e As MouseEventArgs) Handles TabControl1.MouseClick
        If Label16.Text = "manager" Then
            GroupBox7.Visible = False
            GroupBox8.Visible = False
            GroupBox8.Visible = False
            GroupBox9.Visible = False
            GroupBox10.Visible = False
            GroupBox11.Visible = False
            Button8.Visible = False
            Label45.Visible = False
            Label46.Visible = False
        ElseIf Label16.Text = "finance" Then
            GroupBox4.Visible = False
            GroupBox5.Visible = False
            GroupBox6.Visible = False
        End If
    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        salaries.ShowDialog()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        CheckBox1.Checked = False
        CheckBox3.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False


        CheckBox2.Checked = False
        CheckBox8.Checked = False
        CheckBox4.Checked = False
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        CheckBox1.Checked = False
        CheckBox3.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False


        CheckBox7.Checked = False
        CheckBox2.Checked = False
        CheckBox4.Checked = False
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        MsgBox(My.Settings.totalsubs.ToString)
    End Sub

  
    
   
End Class