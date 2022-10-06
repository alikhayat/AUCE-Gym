Imports System.Data.OleDb

Public Class main
    Public totalsubs As Integer
    Public totals As Decimal
    Public classest As Integer = 0
    Dim dayy As DayOfWeek
    Public path As String = "T:\"

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        lod()

    End Sub
    Public Sub lod()

        'TODO: This line of code loads data into the 'VarrDataSet.varr' table. You can move, or remove it, as needed.
        Me.VarrTableAdapter.Fill(Me.VarrDataSet.varr)

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
        'TODO: This line of code loads data into the 'ActiveregDataSet4.insurance' table. You can move, or remove it, as needed.
        Me.InsuranceTableAdapter.Fill(Me.ActiveregDataSet4.insurance)
        subbadd.ApplicantsTableAdapter.Fill(subbadd.Applicants1DataSet3.applicants)
        editapplicants.MedicalTableAdapter.Fill(editapplicants.Applicants1DataSet2.medical)
        upcoming()
        DataGridView6.Visible = False
        DataGridView7.Visible = False
        DataGridView8.Visible = False
        DataGridView9.Visible = False
        DataGridView11.Visible = False
        DataGridView10.Visible = False
        depliting()
        ComboBox1.Visible = False
        'If My.Settings.a = 0 Then
        '    My.Settings.lastdate = Now
        '    My.Settings.a += 1
        'End If
        If DataGridView11.Rows(0).Cells(6).Value.ToString = "0" Then
            Try
                Dim query As String = "UPDATE [varr] SET [lastday]=?, [a]=? WHERE [ID]=? "
                Using con = New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "varr.mdb;Jet OLEDB:Database Password=janitani2;")

                    Using cmd = New OleDbCommand(query, con)
                        con.Open()
                        cmd.Parameters.AddWithValue("@p1", Convert.ToString(Today.ToShortDateString))
                        cmd.Parameters.AddWithValue("@p2", "1")
                        cmd.Parameters.AddWithValue("@p3", "1")

                        cmd.ExecuteNonQuery()
                        con.Close()
                        con.Dispose()
                    End Using
                End Using
                Me.VarrTableAdapter.Fill(Me.VarrDataSet.varr)
            Catch ex As Exception
                MsgBox(Convert.ToString(ex))

            End Try


        End If
        'Label11.Text = Decimal.Round(My.Settings.totalrevenue - My.Settings.expenses, 1, MidpointRounding.AwayFromZero).ToString
        Dim t As Decimal = Decimal.Round(Convert.ToDecimal(DataGridView11.Rows(0).Cells(25).Value.ToString) - Convert.ToDecimal(DataGridView11.Rows(0).Cells(26).Value.ToString), 1, MidpointRounding.AwayFromZero)
        Label11.Text = t.ToString
        Label16.Text = DataGridView11.Rows(0).Cells(7).Value.ToString


        Label20.Text = DataGridView11.Rows(0).Cells(33).Value.ToString
        Label21.Text = DataGridView11.Rows(0).Cells(4).Value.ToString
        Label22.Text = DataGridView3.RowCount.ToString

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

            Try
                Dim query As String = "UPDATE [varr] SET [substday]=? WHERE [ID]=? "
                Using con = New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "varr.mdb;Jet OLEDB:Database Password=janitani2;")

                    Using cmd = New OleDbCommand(query, con)
                        con.Open()
                        cmd.Parameters.AddWithValue("@p1", "0")
                        cmd.Parameters.AddWithValue("@p2", "1")


                        cmd.ExecuteNonQuery()
                        con.Close()
                        con.Dispose()
                    End Using
                End Using
                Me.VarrTableAdapter.Fill(Me.VarrDataSet.varr)
            Catch ex As Exception
                MsgBox(Convert.ToString(ex))

            End Try
            Label21.Text = DataGridView11.Rows(0).Cells(4).Value.ToString
        End If
        Try
            Dim myConnToAccess = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + "classes.mdb;Jet OLEDB:Database Password=janitani2;")
            myConnToAccess.Open()
            Dim ds = New DataSet
            Dim tables = ds.Tables
            Dim da = New OleDbDataAdapter("SELECT Name from classes", myConnToAccess)
            da.Fill(ds, "classes")
            Dim view1 As New DataView(tables(0))
            With ComboBox2
                .DataSource = ds.Tables("classes")
                .DisplayMember = "Name"
                .ValueMember = "Name"

                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With
        Catch

        End Try
        ComboBox2.Visible = False
        daily()
        listb()

        classv()

        policies()
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

        ' My.Settings.totals = totals
        Try
            Dim query As String = "UPDATE [varr] SET [totals]=? WHERE [ID]=? "
            Using con = New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "varr.mdb;Jet OLEDB:Database Password=janitani2;")

                Using cmd = New OleDbCommand(query, con)
                    con.Open()
                    cmd.Parameters.AddWithValue("@p1", Convert.ToString(totals))
                    cmd.Parameters.AddWithValue("@p2", "1")


                    cmd.ExecuteNonQuery()
                    con.Close()
                    con.Dispose()
                End Using
            End Using
            Me.VarrTableAdapter.Fill(Me.VarrDataSet.varr)
        Catch ex As Exception
            MsgBox(Convert.ToString(ex))

        End Try
    End Sub
    Public Sub listb()
        ListBox3.Items.Clear()
        Try
            For Each row As DataGridViewRow In DataGridView3.Rows
                If row.Cells(16).Value = Today.ToShortDateString Then
                    ListBox3.Items.Add(row.Cells(1).Value.ToString)
                End If
            Next
        Catch ex As Exception

        End Try

    End Sub
    Public Sub subex()
        Dim n As String = "No"

        Try
            Dim con As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "classes.mdb;Jet OLEDB:Database Password=janitani2;")
            con.Open()

            Dim myadapter As New OleDb.OleDbDataAdapter("select Name, DateActivated from classes where DateActivated <#" + Today.AddDays(-30) + "#", con)
            Dim da As New DataSet
            myadapter.Fill(da)
            DataGridView4.DataSource = da.Tables(0)
            Label23.Text = DataGridView4.RowCount.ToString
            con.Close()
            con.Dispose()
        Catch ex As Exception

        End Try


    End Sub



    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged, TextBox2.TextChanged
        Dim con As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "activereg.mdb;Jet OLEDB:Database Password=janitani2;")
        con.Open()
        Dim myadapter As New OleDb.OleDbDataAdapter("select * from ActiveReg where Name like'" + TextBox2.Text + "%' and lastName like'" + TextBox3.Text + "%'", con)
        Dim ds As New DataSet
        myadapter.Fill(ds)
        DataGridView3.DataSource = ds.Tables(0)
        Label22.Text = DataGridView3.RowCount.ToString

        con.Close()
    End Sub
    Public Sub dateadvance()
        Dim lst As Date = Convert.ToDateTime(DataGridView11.Rows(0).Cells(34).Value.ToString)
        Dim a As Integer = (Now - lst).Days
        If lst.Day.Equals(Today.Date) Then
            Try
                Dim query As String = "UPDATE [varr] SET [lastday]=? WHERE [ID]=? "
                Using con = New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "varr.mdb;Jet OLEDB:Database Password=janitani2;")

                    Using cmd = New OleDbCommand(query, con)
                        con.Open()
                        cmd.Parameters.AddWithValue("@p1", Now)
                        cmd.Parameters.AddWithValue("@p2", "1")
                        cmd.ExecuteNonQuery()
                        con.Close()
                        con.Dispose()
                    End Using
                End Using
                Me.VarrTableAdapter.Fill(Me.VarrDataSet.varr)
            Catch ex As Exception
                MsgBox(Convert.ToString(ex))

            End Try
        Else
            Try
                Dim query As String = "UPDATE [varr] SET [lastday]=? WHERE [ID]=? "
                Using con = New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "varr.mdb;Jet OLEDB:Database Password=janitani2;")

                    Using cmd = New OleDbCommand(query, con)
                        con.Open()
                        cmd.Parameters.AddWithValue("@p1", Now)
                        cmd.Parameters.AddWithValue("@p2", "1")
                        cmd.ExecuteNonQuery()
                        con.Close()
                        con.Dispose()
                    End Using
                End Using
                Me.VarrTableAdapter.Fill(Me.VarrDataSet.varr)
            Catch ex As Exception
                MsgBox(Convert.ToString(ex))

            End Try
        End If

    End Sub
    Public Function chkdate() As Boolean
        Dim d As String = DataGridView11.Rows(0).Cells(34).Value.ToString
        Dim lst As Date = Convert.ToDateTime(d)
        If lst.Date.Equals(Today.Date) Then
            Return True
        Else : Return False
        End If

    End Function


    




    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        cochadd.ShowDialog()
    End Sub

    

    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        Try
            ComboBox1.ResetText()
            Dim selected As Date = MonthCalendar1.SelectionStart.ToShortDateString
            Dim selectedday = selected.DayOfWeek
            Dim d As String = ""
            Select Case selectedday
                Case 1
                    d = "Monday"
                Case 2
                    d = "Tuesday"
                Case 3
                    d = "Wednesday"
                Case 4
                    d = "Thursday"
                Case 5
                    d = "Friday"
                Case 6
                    d = "Saturday"
                Case 7
                    d = "Sunday"
            End Select



            Dim y As String = "Yes"
            Dim con = New OleDbConnection("provider=microsoft.ace.oledb.12.0;data source=" + path + "classes.mdb;jet oledb:database password=janitani2;")
            con.Open()
            Dim ds As New DataSet
            Dim table = ds.Tables
            Dim da = New OleDbDataAdapter("SELECT Name FROM classes WHERE Active = '" + y + "' and DateActivated >=# " + selected + " # and Days like'" + d + "%'", con)
            da.Fill(ds, "classes")


            Dim view1 As New DataView(table(0))


            con.Close()
            With ComboBox1
                .DataSource = ds.Tables("classes")
                .DisplayMember = "name"
                .ValueMember = "name"
                .SelectedIndex = -1
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
            Dim con As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "stock.mdb;Jet OLEDB:Database Password=janitani2;")
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
                        'My.Settings.revenue += total
                        'My.Settings.totalrevenue += total
                       
                        Try
                            Dim r As Decimal = (Convert.ToDecimal(DataGridView11.Rows(0).Cells(18).Value.ToString) + total)
                            Dim tr As Decimal = (Convert.ToDecimal(DataGridView11.Rows(0).Cells(25).Value.ToString) + total)
                            Dim queryy As String = "UPDATE [varr] SET [revenue]=?, [totalrevenue]=? WHERE [ID]=? "
                            Using con = New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "varr.mdb;Jet OLEDB:Database Password=janitani2;")

                                Using cmd = New OleDbCommand(queryy, con)
                                    con.Open()
                                    cmd.Parameters.AddWithValue("@p1", Convert.ToString(r))
                                    cmd.Parameters.AddWithValue("@p2", Convert.ToString(tr))
                                    cmd.Parameters.AddWithValue("@p3", "1")
                                    cmd.ExecuteNonQuery()
                                    con.Close()
                                End Using
                            End Using
                            Me.VarrTableAdapter.Fill(Me.VarrDataSet.varr)
                        Catch ex As Exception
                            MsgBox(Convert.ToString(ex))

                        End Try
                        Label38.Text = DataGridView11.Rows(0).Cells(18).Value.ToString + " L.L"
                        Label39.Text = DataGridView11.Rows(0).Cells(25).Value.ToString + " L.L"
                        MsgBox(row.Cells(1).Value.ToString + " Quantity= " + quantity.ToString + " SubTotal= " + total.ToString + " L.L")
                        Label11.Text = Decimal.Round(Convert.ToDecimal(DataGridView11.Rows(0).Cells(25).Value.ToString), 1, MidpointRounding.AwayFromZero).ToString
                        Dim quantityleft As Integer = quan - quantity
                        Dim q As String = Convert.ToString(quantityleft)
                        Dim i As String = row.Cells(0).Value.ToString
                        Dim query As String = "UPDATE [stock] SET [Quantity]=? WHERE [ID]=? "


                        Using con = New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "stock.mdb;Jet OLEDB:Database Password=janitani2;")

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
                        Dim cn As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "stock.mdb;Jet OLEDB:Database Password=janitani2;")
                        Dim tday As Date = Convert.ToDateTime(Today.ToShortDateString)
                        cn.Open()
                        'My.Settings.srevenue += 1
                        Try
                            Dim srev As Integer = Convert.ToInt32(DataGridView11.Rows(0).Cells(21).Value.ToString) + 1
                            Dim queryyy As String = "UPDATE [varr] SET [srevenue]=? WHERE [ID]=? "
                            Using con = New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "varr.mdb;Jet OLEDB:Database Password=janitani2;")

                                Using cmd = New OleDbCommand(queryyy, con)
                                    con.Open()
                                    cmd.Parameters.AddWithValue("@p1", Convert.ToString(srev))
                                    cmd.Parameters.AddWithValue("@p2", "1")
                                    cmd.ExecuteNonQuery()
                                    con.Close()
                                End Using
                            End Using
                            Me.VarrTableAdapter.Fill(Me.VarrDataSet.varr)
                            Dim strSqll = ("insert into sold values ('" + srev.ToString + "', '" + item + "', '" + baseP + "', '" + retaill + "', '" + TextBox6.Text + "', '" + tday + "', '" + rev + "')")
                            objcmdd = New OleDbCommand(strSqll, cn)


                            objcmdd.ExecuteNonQuery()

                            cn.Close()

                            Me.StockTableAdapter.Fill(Me.StockDataSet.stock)
                            TextBox1.Clear()
                            TextBox6.Clear()
                            Label31.Text = ""
                        Catch ex As Exception
                            MsgBox(Convert.ToString(ex))
                        End Try
                       
                       
                        lod()
                    End If
                End If
            Next


        End If

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
            Dim con = New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "stock.mdb;Jet OLEDB:Database Password=janitani2;")
            con.Open()
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand("Select ID , Name , Quantity  from stock WHERE Quantity=? or Quantity=? or Quantity=? or Quantity=? or Quantity=? or Quantity=?  ", con)

            cmd.Parameters.AddWithValue("@p1", "4")
            cmd.Parameters.AddWithValue("@p2", "5")
            cmd.Parameters.AddWithValue("@p3", "3")
            cmd.Parameters.AddWithValue("@p4", "2")
            cmd.Parameters.AddWithValue("@p5", "1")
            cmd.Parameters.AddWithValue("@p6", "0")

           
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

                        Dim con As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "activereg.mdb;Jet OLEDB:Database Password=janitani2;")
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
        'Label39.Text = My.Settings.totalrevenue.ToString + " L.L"
        'Label36.Text = My.Settings.subrev.ToString + " L.L"
        'Label37.Text = My.Settings.inrevenue.ToString + " L.L"
        'Label38.Text = My.Settings.revenue.ToString + " L.L"
        'Label41.Text = My.Settings.expenses.ToString + " L.L"
        'Label42.Text = My.Settings.totalexpense.ToString + " L.L"
        'Label40.Text = My.Settings.salaryex.ToString + " L.L"
        'Label11.Text = Decimal.Round(My.Settings.totalrevenue - My.Settings.expenses, 1, MidpointRounding.AwayFromZero).ToString
        'Label46.Text = Decimal.Round(My.Settings.totalrevenue - My.Settings.expenses - My.Settings.salaryex, 1, MidpointRounding.AwayFromZero).ToString
        Me.VarrTableAdapter.Fill(Me.VarrDataSet.varr)
        Dim t As Decimal = Decimal.Round(Convert.ToDecimal(DataGridView11.Rows(0).Cells(25).Value.ToString) - Convert.ToDecimal(DataGridView11.Rows(0).Cells(26).Value.ToString), 1, MidpointRounding.AwayFromZero)
        Dim tt As Decimal = Decimal.Round(Convert.ToDecimal(DataGridView11.Rows(0).Cells(25).Value.ToString) - Convert.ToDecimal(DataGridView11.Rows(0).Cells(26).Value.ToString), 1, MidpointRounding.AwayFromZero)
        Label39.Text = DataGridView11.Rows(0).Cells(25).Value.ToString + " L.L"
        Label36.Text = DataGridView11.Rows(0).Cells(28).Value.ToString + " L.L"
        Label37.Text = DataGridView11.Rows(0).Cells(24).Value.ToString + " L.L"
        Label38.Text = DataGridView11.Rows(0).Cells(18).Value.ToString + " L.L"
        Label41.Text = DataGridView11.Rows(0).Cells(19).Value.ToString + " L.L"
        Label42.Text = DataGridView11.Rows(0).Cells(26).Value.ToString + " L.L"
        Label40.Text = DataGridView11.Rows(0).Cells(32).Value.ToString + " L.L"
        Label54.Text = DataGridView11.Rows(0).Cells(27).Value.ToString + " L.L"
        Label11.Text = t.ToString
        Label46.Text = tt.ToString + " L.L"

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            Dim result As Integer = MessageBox.Show("Are you sure ?", "confirmation", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then

            ElseIf result = DialogResult.No Then
                MessageBox.Show("No pressed")
            ElseIf result = DialogResult.Yes Then
                If DataGridView11.Rows(0).Cells(29).Value.ToString <> "0" Then
                    Dim cn As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "daily.mdb;Jet OLEDB:Database Password=janitani2;")
                    Dim c As Integer = DataGridView8.RowCount
                    Dim query As String = "UPDATE [Daily] SET [Confirmed]=? WHERE [ID]=?"

                    Using con = New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "daily.mdb;Jet OLEDB:Database Password=janitani2;")


                        Using cmd = New OleDbCommand(query, con)
                            con.Open()
                            cmd.Parameters.AddWithValue("@p1", "Yes")
                            cmd.Parameters.AddWithValue("@p2", c)

                            cmd.ExecuteNonQuery()
                            con.Close()
                            con.Dispose()
                        End Using
                    End Using

                    'My.Settings.did += 1

                    Dim did As Integer = Convert.ToInt32(DataGridView11.Rows(0).Cells(29).Value.ToString) + 1
                    Dim objcmdd As New System.Data.OleDb.OleDbCommand

                    Dim queryy As String = "UPDATE [varr] SET [did]=? WHERE [ID]=? "
                    Using con = New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "varr.mdb;Jet OLEDB:Database Password=janitani2;")

                        Using cmd = New OleDbCommand(queryy, con)
                            con.Open()
                            cmd.Parameters.AddWithValue("@p1", did.ToString)
                            cmd.Parameters.AddWithValue("@p2", "1")
                            cmd.ExecuteNonQuery()
                            con.Close()
                            con.Dispose()
                        End Using
                    End Using
                    cn.Open()

                    Dim strSqll = ("insert into Daily values ('" + did.ToString + "', '" + Today.ToShortDateString + "', '" + Label36.Text + "', '" + Label37.Text + "', '" + Label38.Text + "', '" + Label39.Text + "', '" + Label41.Text + "', '" + Label40.Text + "', '" + Label42.Text + "', '" + "yes" + "')")
                    objcmdd = New OleDbCommand(strSqll, cn)


                    objcmdd.ExecuteNonQuery()

                    cn.Close()
                    'My.Settings.totalrevenue = 0
                    'My.Settings.revenue = 0
                    'My.Settings.subrev = 0
                    'My.Settings.inrevenue = 0
                    'My.Settings.expenses = 0
                    'My.Settings.totalexpense = 0
                    'My.Settings.salaryex = 0

                    Dim queryyy As String = "UPDATE [varr] SET [totalrevenue]=?, [revenue]=?, [subrev]=?, [inrevenue]=?, [expenses]=?, [totalexpense]=?, [salaryex]=? WHERE [ID]=? "
                    Using con = New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "varr.mdb;Jet OLEDB:Database Password=janitani2;")

                        Using cmd = New OleDbCommand(queryyy, con)
                            con.Open()
                            cmd.Parameters.AddWithValue("@p1", "0")
                            cmd.Parameters.AddWithValue("@p2", "0")
                            cmd.Parameters.AddWithValue("@p3", "0")
                            cmd.Parameters.AddWithValue("@p4", "0")
                            cmd.Parameters.AddWithValue("@p5", "0")
                            cmd.Parameters.AddWithValue("@p6", "0")
                            cmd.Parameters.AddWithValue("@p7", "0")
                            cmd.Parameters.AddWithValue("@p8", "1")
                            cmd.ExecuteNonQuery()
                            con.Close()
                        End Using
                    End Using
                    Me.VarrTableAdapter.Fill(Me.VarrDataSet.varr)
                   

        Me.DailyTableAdapter.Fill(Me.DailyDataSet.Daily)
        MsgBox("Confirmed")
        lod()
                ElseIf Convert.ToInt32(DataGridView11.Rows(0).Cells(29).Value) = 0 Then
                    Dim cn As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "daily.mdb;Jet OLEDB:Database Password=janitani2;")
                    Dim objcmdd As New System.Data.OleDb.OleDbCommand

                    cn.Open()
                    Dim did As Integer = Convert.ToInt32(DataGridView11.Rows(0).Cells(29).Value.ToString) + 1
                    'My.Settings.did += 1
                    Dim strSqll = ("insert into Daily values ('" + did.ToString + "', '" + Today.ToShortDateString + "', '" + Label36.Text + "', '" + Label37.Text + "', '" + Label38.Text + "', '" + Label39.Text + "', '" + Label41.Text + "', '" + Label40.Text + "', '" + Label42.Text + "', '" + "Yes" + "')")
                    objcmdd = New OleDbCommand(strSqll, cn)


                    objcmdd.ExecuteNonQuery()

                    cn.Close()
                    'My.Settings.totalrevenue = 0
                    'My.Settings.revenue = 0
                    'My.Settings.subrev = 0
                    'My.Settings.inrevenue = 0
                    'My.Settings.expenses = 0
                    'My.Settings.totalexpense = 0
                    'My.Settings.salaryex = 0

                    Dim queryyy As String = "UPDATE [varr] SET [totalrevenue]=?, [revenue]=?, [subrev]=?, [inrevenue]=?, [expenses]=?, [totalexpense]=?, [salaryex]=?, [did]=? WHERE [ID]=? "
                    Using con = New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "varr.mdb;Jet OLEDB:Database Password=janitani2;")

                        Using cmd = New OleDbCommand(queryyy, con)
                            con.Open()
                            cmd.Parameters.AddWithValue("@p1", "0")
                            cmd.Parameters.AddWithValue("@p2", "0")
                            cmd.Parameters.AddWithValue("@p3", "0")
                            cmd.Parameters.AddWithValue("@p4", "0")
                            cmd.Parameters.AddWithValue("@p5", "0")
                            cmd.Parameters.AddWithValue("@p6", "0")
                            cmd.Parameters.AddWithValue("@p7", "0")
                            cmd.Parameters.AddWithValue("@p8", did.ToString)
                            cmd.Parameters.AddWithValue("@p9", "1")
                            cmd.ExecuteNonQuery()
                            con.Close()
                        End Using
                    End Using

                    MsgBox("Confirmed")
                    lod()
                End If

            End If
        Catch ex As Exception
            MsgBox(Convert.ToString(ex))
        End Try
       
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
       
    End Sub

    
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If CheckBox1.Checked = True And CheckBox2.Checked = False And CheckBox3.Checked = False And ComboBox2.SelectedIndex = -1 Then
            Try
                Dim con As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "ActiveReg.mdb;Jet OLEDB:Database Password=janitani2;")
                con.Open()
                Dim myadapter As New OleDb.OleDbDataAdapter("select  Name , LastName , Class_Discount , DateSubscribed , Class , RecieptNb , AmountPaid from ActiveReg where DateSubscribed Between #" & _
                                            DateTimePicker1.Value.ToShortDateString & "# And #" & _
                                            DateTimePicker2.Value.ToShortDateString & "#", con)
                Dim ds As New DataSet
                myadapter.Fill(ds)
                reports.datagridview1.DataSource = ds.Tables(0)
                con.Close()
                reports.Show()
                reports.datagridview1.ClearSelection()
            Catch ex As Exception
                MsgBox(Convert.ToString(ex))
            End Try
        ElseIf CheckBox1.Checked = True And CheckBox2.Checked = False And CheckBox3.Checked = False And ComboBox2.SelectedIndex <> -1 Then
            Try
                Dim con As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "ActiveReg.mdb;Jet OLEDB:Database Password=janitani2;")
                con.Open()
                Dim myadapter As New OleDb.OleDbDataAdapter("select  Name , LastName , Class_Discount , DateSubscribed , Class , RecieptNb , AmountPaid from ActiveReg where DateSubscribed Between #" & _
                                            DateTimePicker1.Value.ToShortDateString & "# And #" & _
                                            DateTimePicker2.Value.ToShortDateString & "# And Class='" + ComboBox2.Text + "'", con)
                Dim ds As New DataSet
                myadapter.Fill(ds)
                reports.datagridview1.DataSource = ds.Tables(0)
                con.Close()
                reports.Show()
                reports.datagridview1.ClearSelection()
            Catch ex As Exception
                MsgBox(Convert.ToString(ex))
            End Try



        ElseIf CheckBox1.Checked = False And CheckBox2.Checked = True And CheckBox3.Checked = False Then
            Try
                Dim con As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "activereg.mdb;Jet OLEDB:Database Password=janitani2;")
                con.Open()
                Dim myadapter As New OleDb.OleDbDataAdapter("select * from insurance where DateInsured Between #" & _
                                            DateTimePicker1.Value.ToShortDateString & "# And #" & _
                                            DateTimePicker2.Value.ToShortDateString & "#", con)
                Dim ds As New DataSet
                myadapter.Fill(ds)
                reports.datagridview1.DataSource = ds.Tables(0)

                con.Close()
                reports.ShowDialog()
                reports.datagridview1.ClearSelection()
            Catch ex As Exception
                MsgBox(Convert.ToString(ex))
            End Try
        ElseIf CheckBox1.Checked = False And CheckBox2.Checked = False And CheckBox3.Checked = True Then
            Try
                Dim con As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "Stock.mdb;Jet OLEDB:Database Password=janitani2;")
                con.Open()
                Dim myadapter As New OleDb.OleDbDataAdapter("select * from sold where DateSold Between #" & _
                                            DateTimePicker1.Value.ToShortDateString & "# And #" & _
                                            DateTimePicker2.Value.ToShortDateString & "#", con)
                Dim ds As New DataSet
                myadapter.Fill(ds)
                reports.datagridview1.DataSource = ds.Tables(0)
                con.Close()
                reports.ShowDialog()
                reports.datagridview1.ClearSelection()
            Catch ex As Exception
                MsgBox(Convert.ToString(ex))
            End Try
        ElseIf CheckBox7.Checked = True Then
            Try
                Dim con As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "daily.mdb;Jet OLEDB:Database Password=janitani2;")
                con.Open()
                Dim myadapter As New OleDb.OleDbDataAdapter("select Subrev , Inrev , Strev , Totrev from Daily where Date Between #" & _
                                            DateTimePicker1.Value.ToShortDateString & "# And #" & _
                                            DateTimePicker2.Value.ToShortDateString & "#", con)
                Dim ds As New DataSet
                myadapter.Fill(ds)
                reports.datagridview1.DataSource = ds.Tables(0)
                con.Close()
                reports.ShowDialog()
                reports.datagridview1.ClearSelection()
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
        ComboBox2.Visible = True

        CheckBox7.Checked = False
        CheckBox8.Checked = False
        CheckBox4.Checked = False
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        CheckBox1.Checked = False
        CheckBox3.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        ComboBox2.Visible = False

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
            ComboBox2.Visible = False
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
            ComboBox2.Visible = False
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If CheckBox6.Checked = True And CheckBox5.Checked = False Then
            Try
                Dim con As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "stock.mdb;Jet OLEDB:Database Password=janitani2;")
                con.Open()
                Dim myadapter As New OleDb.OleDbDataAdapter("select * from expenses where DateAdded Between #" & _
                                            DateTimePicker1.Value.ToShortDateString & "# And #" & _
                                            DateTimePicker2.Value.ToShortDateString & "#", con)
                Dim ds As New DataSet
                myadapter.Fill(ds)
                reports.datagridview1.DataSource = ds.Tables(0)

                con.Close()
                reports.ShowDialog()
                reports.datagridview1.ClearSelection()
            Catch ex As Exception
                MsgBox(Convert.ToString(ex))
            End Try
        ElseIf CheckBox6.Checked = False And CheckBox5.Checked = True Then
            Try
                Dim con As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "coaches.mdb;Jet OLEDB:Database Password=janitani2;")
                con.Open()
                Dim myadapter As New OleDb.OleDbDataAdapter("select * from SalariesPaid where Date Between #" & _
                                            DateTimePicker1.Value.ToShortDateString & "# And #" & _
                                            DateTimePicker2.Value.ToShortDateString & "#", con)
                Dim ds As New DataSet
                myadapter.Fill(ds)
                reports.datagridview1.DataSource = ds.Tables(0)

                con.Close()
                reports.ShowDialog()
                reports.datagridview1.ClearSelection()
            Catch ex As Exception
                MsgBox(Convert.ToString(ex))
            End Try
        ElseIf CheckBox8.Checked = True Then
            Try
                Dim con As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "daily.mdb;Jet OLEDB:Database Password=janitani2;")
                con.Open()
                Dim myadapter As New OleDb.OleDbDataAdapter("select Stexp , Salexp , Totexp from Daily where Date Between #" & _
                                            DateTimePicker1.Value.ToShortDateString & "# And #" & _
                                            DateTimePicker2.Value.ToShortDateString & "#", con)
                Dim ds As New DataSet
                myadapter.Fill(ds)
                reports.datagridview1.DataSource = ds.Tables(0)

                con.Close()
                reports.ShowDialog()
                reports.datagridview1.ClearSelection()
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
                    Dim cn As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "activereg.mdb;Jet OLEDB:Database Password=janitani2;")
                    Dim id As Integer = Convert.ToInt32(row.Cells(0).Value.ToString)
                    Dim query As String = "UPDATE [ActiveReg] SET [valid]=? WHERE [ID]=?"

                    Using con = New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "activereg.mdb;Jet OLEDB:Database Password=janitani2;")


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
       

        Dim query As String = "UPDATE [coachesSalaries] SET [Active]=? WHERE [DateActivated]<?"

        Using con = New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "coaches.mdb;Jet OLEDB:Database Password=janitani2;")


            Using cmd = New OleDbCommand(query, con)
                con.Open()
                cmd.Parameters.AddWithValue("@p1", "No")
                cmd.Parameters.AddWithValue("@p2", Today.AddDays(-30))

                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
       

        Dim unpaid As Integer = 0
        Coaches.Items.Clear()
        Me.CoachesSalariesTableAdapter.Fill(Me.CoachesDataSet4.coachesSalaries)
        For Each row As DataGridViewRow In DataGridView9.Rows


            If row.Cells(5).Value.ToString = "No" And row.Cells(6).Value.ToString = "No" Then
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
            GroupBox12.Visible = False
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
        MsgBox(DataGridView11.Rows(0).Cells(33).Value.ToString)
    End Sub
    Public Sub classv()
        Try
            Dim query As String = "UPDATE [classes] SET [Active]=? WHERE [DateActivated]<? "


            Using con = New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" + path + "classes.mdb;Jet OLEDB:Database Password=janitani2;")

                Using cmd = New OleDbCommand(query, con)
                    con.Open()
                    cmd.Parameters.AddWithValue("@p1", "No")
                    cmd.Parameters.AddWithValue("@p2", Today.AddDays(-30))

                    cmd.ExecuteNonQuery()
                    con.Close()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(Convert.ToString(ex))
        End Try
        
    End Sub
  
    
   
   
    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        Dim s As String = InputBox("are you sure?", "confirm")
        If s = "janitani" Then
            My.Settings.Reset()
        Else
            MsgBox("it looks like your not sure")
        End If
    End Sub
    Public Sub policies()
        Dim unsubmitted As Integer = 0
        For Each row As DataGridViewRow In DataGridView10.Rows


            If row.Cells(5).Value.ToString = "No" Then
                unsubmitted += 1

            End If
        Next
        Label60.Text = unsubmitted.ToString
    End Sub
    
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Insurance.ShowDialog()
    End Sub

    
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        

        

    End Sub

    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        Try
            If ComboBox1.SelectedIndex <> -1 Then
                Dim selected As String = ""
                selected = ComboBox1.SelectedValue.ToString

                Dim nb As Integer = 0
                For Each row As DataGridViewRow In DataGridView6.Rows
                    If row.Cells(1).Value.ToString = selected Then
                        Label24.Text = row.Cells(4).Value.ToString
                        Label25.Text = row.Cells(5).Value.ToString
                        Label26.Text = row.Cells(7).Value.ToString
                        Label63.Text = row.Cells(9).Value.ToString
                        For Each roww As DataGridViewRow In DataGridView3.Rows
                            If roww.Cells(17).Value.ToString = selected Then
                                nb += 1
                                Dim ds = New DataSet
                                Dim tables = ds.Tables

                                Dim da As OleDb.OleDbDataAdapter = New OleDbDataAdapter()
                                Dim con = New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & path + "activereg.mdb;Jet OLEDB:Database Password=janitani2;")
                                con.Open()
                                Dim cmd As OleDbCommand
                                cmd = New OleDbCommand("Select Name , LastName , Gender , PhoneNb  from ActiveReg WHERE Class=?  ", con)

                                cmd.Parameters.AddWithValue("@p1", selected)

                                con.Close()

                                da.SelectCommand = cmd
                                da.Fill(ds)
                                DataGridView1.DataSource = ds.Tables(0)
                            End If
                        Next
                    End If
                Next
                Label27.Text = nb.ToString
            End If
        Catch ex As Exception

        End Try
        
    End Sub
End Class
