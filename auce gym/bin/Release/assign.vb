Imports System.Data.OleDb
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine

Public Class assign
    Dim total As Decimal = 0
    Dim checked As Boolean = False
    Dim checked2 As Boolean = False
    Dim price As Decimal = 0
    Public doubled As Boolean = False
    Public insured As Boolean = False

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        
        If Label10.Text <> "THIS USER IS INSURED" Then
            If ComboBox1.SelectedIndex = 0 And checked = False Then
                TextBox1.Text = Date.Today
                TextBox2.Text = Today.AddDays(365)
                total += 37500
                Label26.Text = total.ToString
                checked = True
            ElseIf ComboBox1.SelectedIndex = 1 And checked = True And checked2 = False Then
                TextBox1.ResetText()
                TextBox2.ResetText()
                total -= 37500
                Label26.Text = total.ToString
                checked2 = True
                checked = False
            ElseIf ComboBox1.SelectedIndex = 0 And checked2 = True Then
                TextBox1.Text = Date.Today
                TextBox2.Text = Today.AddDays(365)
                total += 37500
                Label26.Text = total.ToString
                checked = True
                checked2 = False
            ElseIf ComboBox1.SelectedIndex = 0 And checked2 = False And checked = False Then
                TextBox1.Text = Date.Today
                TextBox2.Text = Today.AddDays(365)
                total += 37500
                Label26.Text = total.ToString
                checked = True
            ElseIf ComboBox1.SelectedIndex = 1 And checked = False Then
                TextBox1.ResetText()
                TextBox2.ResetText()
                checked2 = True
            ElseIf ComboBox1.SelectedIndex = 0 And checked = True Then
                TextBox1.Text = Date.Today
                TextBox2.Text = Today.AddDays(365)
                Label26.Text = total.ToString
            ElseIf ComboBox1.SelectedIndex = 1 And checked2 = True Then
                TextBox1.ResetText()
                TextBox2.ResetText()
                checked2 = True
            ElseIf ComboBox1.SelectedIndex = 1 And checked = True And checked2 = True Then
                TextBox1.ResetText()
                TextBox2.ResetText()
                total -= 37500
                Label26.Text = total.ToString
                checked2 = True
                checked = False
            End If
        End If
       
    End Sub


    Private Sub assign_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ActiveregDataSet3.ActiveReg' table. You can move, or remove it, as needed.
        Me.ActiveRegTableAdapter.Fill(Me.ActiveregDataSet3.ActiveReg)
        'TODO: This line of code loads data into the 'ClassesDataSet1.classes' table. You can move, or remove it, as needed.
        Me.ClassesTableAdapter.Fill(Me.ClassesDataSet1.classes)
        labels()
        Label25.Text = Today.ToShortDateString
        total = 0
        TextBox1.Clear()
        TextBox2.Clear()
        price = 0
        DataGridView1.Visible = False
        DataGridView2.Visible = False
        My.Settings.changed = False
        My.Settings.temp = 0

        Try
            Dim myConnToAccess = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + main.path + "classes.mdb")
            myConnToAccess.Open()
            Dim ds = New DataSet
            Dim tables = ds.Tables
            Dim da = New OleDbDataAdapter("SELECT Name from classes where Active like'" + "Yes" + "%'", myConnToAccess)
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
        ComboBox1.SelectedIndex = -1
        Label26.Text = "0"
        insurance()
        If Label10.Text = "THIS USER IS INSURED" Then
            Label19.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex = -1 Or ComboBox2.SelectedIndex = -1 Or TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Please fill the needed info first")
        ElseIf Label10.Text = "THIS USER IS INSURED" And ComboBox2.SelectedIndex = -1 Then
            MsgBox("Please Select class")
        ElseIf Label10.Text = "THIS USER IS INSURED" And ComboBox2.SelectedIndex <> -1 Then
            submit.Label5.Text = Label1.Text
            submit.Label6.Text = Label3.Text
            submit.Label7.Text = ComboBox2.Text
            submit.Label8.Text = Label26.Text
            submit.ShowDialog()
        Else
            submit.Label5.Text = Label1.Text
            submit.Label6.Text = Label3.Text
            submit.Label7.Text = ComboBox2.Text
            submit.Label8.Text = Label26.Text
            submit.ShowDialog()

        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        price = 0
        If My.Settings.changed = True Then
            total -= My.Settings.temp
            Label26.Text = total.ToString
        End If


        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(1).Value = ComboBox2.Text And ComboBox2.SelectedIndex <> -1 Then
                price = Convert.ToDecimal(row.Cells(10).Value.ToString)
                If Label17.Text = "Relative" Then
                    price -= (10 / 100) * price
                    My.Settings.temp = price
                    total += price
                    Label26.Text = total.ToString
                    My.Settings.changed = True
                ElseIf Label17.Text = "Student" Or Label17.Text = "Teacher" Or Label17.Text = "Staff" Then
                    price -= (50 / 100) * price
                    My.Settings.temp = price
                    total += price
                    Label26.Text = total.ToString
                    My.Settings.changed = True
                ElseIf Label17.Text = "Regular" Then
                    My.Settings.temp = price
                    total += price
                    Label26.Text = total.ToString
                    My.Settings.changed = True

                End If
               
                Exit For
            End If

        Next
        For Each row As DataGridViewRow In DataGridView2.Rows
            If row.Cells(21).Value.ToString = Label45.Text And row.Cells(20).Value.ToString = "Yes" Then

                price -= (10 / 100) * price
                Label26.Text = price.ToString
                doubled = True
                Exit For
            End If
        Next
        
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        records.ShowDialog()
    End Sub
    Public Sub insurance()
        Try
            Dim insured As Boolean = False
            Dim valid As Boolean = True
            Dim insu As String = ""
            For Each row As DataGridViewRow In DataGridView2.Rows
                If row.Cells(21).Value = Label45.Text And row.Cells(1).Value = Label1.Text Then
                    Dim s As String = row.Cells(13).Value.ToString
                    insu = row.Cells(13).Value.ToString
                    If s = "" Then
                        insured = False


                    Else
                        insured = True

                    End If

                    If Today.ToShortDateString > Convert.ToDateTime(row.Cells(15).Value.ToString) Then
                        valid = False
                    Else
                        valid = True
                    End If
                    Exit For
                End If
            Next


           
            For Each row As DataGridViewRow In DataGridView2.Rows
                If row.Cells(21).Value = Label45.Text And row.Cells(1).Value = Label1.Text Then
                    Dim s As String = row.Cells(13).Value.ToString.Trim
                    If s = "in" Then
                        TextBox1.Text = row.Cells(14).Value.ToString
                        TextBox2.Text = row.Cells(15).Value.ToString
                        TextBox1.Visible = False
                        TextBox2.Visible = False
                        ComboBox1.SelectedIndex = 0
                    ElseIf s = "out" Then
                        ComboBox1.SelectedIndex = 1
                        TextBox1.Text = row.Cells(14).Value.ToString
                        TextBox2.Text = row.Cells(15).Value.ToString
                        TextBox1.Visible = False
                        TextBox2.Visible = False
                    End If
                 
                End If

            Next
            If insured = True And valid = True Then
                ComboBox1.Visible = False


                
                Label11.Visible = False
                Label12.Visible = False
                Label10.Text = "THIS USER IS INSURED"
                Label10.Font = New Font("Comic Sans MS", 15, _
                        FontStyle.Bold)
            ElseIf valid = False Then
                MsgBox("This user insurance has ended")
                TextBox1.Visible = True
                TextBox2.Visible = True
                TextBox1.Clear()
                TextBox2.Clear()
            End If
        Catch ex As Exception

        End Try
       

    End Sub
    Public Sub labels()
        Label10.Text = "- Insurance :"
        Label10.Font = New Font("Microsoft Sans Serif", 10, _
                    FontStyle.Bold)
        Label11.Visible = True
        Label12.Visible = True
        ComboBox1.Visible = True
        TextBox1.Visible = True
        TextBox2.Visible = True
    End Sub
    Public Sub assi()
        Try
            For Each row As DataGridViewRow In DataGridView2.Rows
                If row.Cells(21).Value.ToString = Label45.Text And row.Cells(20).Value.ToString = "Yes" And row.Cells(17).Value.ToString = ComboBox2.Text Then
                    MsgBox("This applicant is already registered to this class")
                    Exit Try
                    Exit For
                End If
            Next
            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Cells(1).Value.ToString = ComboBox2.Text Then
                    Dim gender = row.Cells(2).Value.ToString
                    If gender <> "Both" Then
                        If Label7.Text = "Male" And gender = "Females only" Then
                            MsgBox("This class is for Females only")
                            Exit Try
                        ElseIf gender = "Males only" And Label7.Text = "Female" Then
                            MsgBox("This class is for Males only")
                            Exit Try
                        End If
                    End If
                    Exit For
                End If
            Next
            
            Dim tday As Date = Convert.ToDateTime(Today.ToShortDateString)
            Dim objcmd As New System.Data.OleDb.OleDbCommand
            Dim con As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & main.path + "activereg.mdb")

            My.Settings.regid += 1
            con.Open()
            If Label10.Text <> "THIS USER IS INSURED" And ComboBox1.SelectedIndex = 0 Then
                Dim s As Decimal = Convert.ToDecimal(Label26.Text)
                s -= 37500
                Dim strSql = ("insert into ActiveReg values ('" + My.Settings.regid.ToString + "', '" + Label1.Text + "', '" + Label2.Text + "', '" + Label3.Text + "', '" + Label4.Text + "', '" + Label5.Text + "', '" + Label6.Text + "', '" + Label7.Text + "', '" + Label8.Text & "', '" & Label9.Text + "', '" + Label16.Text + "', '" + Label17.Text + "', '" + Label18.Text + "', '" + ComboBox1.Text + "', '" + TextBox1.Text + "', '" + TextBox2.Text + "', '" + tday + "', '" + ComboBox2.Text + "', '" + My.Settings.recnb.ToString + "', '" + s.ToString + "', '" + "Yes" + "', '" + Label45.Text + "')")
                objcmd = New OleDbCommand(strSql, con)


                objcmd.ExecuteNonQuery()

                con.Close()
            Else
                Dim strSql = ("insert into ActiveReg values ('" + My.Settings.regid.ToString + "', '" + Label1.Text + "', '" + Label2.Text + "', '" + Label3.Text + "', '" + Label4.Text + "', '" + Label5.Text + "', '" + Label6.Text + "', '" + Label7.Text + "', '" + Label8.Text & "', '" & Label9.Text + "', '" + Label16.Text + "', '" + Label17.Text + "', '" + Label18.Text + "', '" + ComboBox1.Text + "', '" + TextBox1.Text + "', '" + TextBox2.Text + "', '" + tday + "', '" + ComboBox2.Text + "', '" + My.Settings.recnb.ToString + "', '" + Label26.Text + "', '" + "Yes" + "', '" + Label45.Text + "')")
                objcmd = New OleDbCommand(strSql, con)


                objcmd.ExecuteNonQuery()

                con.Close()
            End If


            
            main.ListBox3.Items.Add("- " + Label1.Text + " " + Label3.Text)
            My.Settings.totalsubs += 1
            main.Label20.Text = My.Settings.totalsubs.ToString
            main.listb()
            My.Settings.substoday += 1
            main.Label21.Text = My.Settings.substoday.ToString
            MsgBox("subscribtion added and is active now ")


            reciept.ShowDialog()
            main.ActiveRegTableAdapter.Fill(main.ActiveregDataSet.ActiveReg)
            main.upcoming()
            If Label10.Text <> "THIS USER IS INSURED" And ComboBox1.SelectedIndex = 0 Then
                Dim s As Decimal = Convert.ToDecimal(Label26.Text)
                insuranceee()
                s -= 37500
                My.Settings.subrev += s
                My.Settings.inrevenue += 37500
                My.Settings.totalrevenue += 37500
                My.Settings.totalrevenue += s
                insured = True
                inrecp.ShowDialog()
            Else
                Dim s As Decimal = Convert.ToDecimal(Label26.Text)
                My.Settings.subrev += s
                My.Settings.totalrevenue += s
            End If
            Label11.Text = Decimal.Round(My.Settings.totalrevenue - My.Settings.expenses, 1, MidpointRounding.AwayFromZero).ToString
            main.daily()
        Catch ex As Exception
            MsgBox(Convert.ToString(ex))
        End Try
        reciept.Visible = False
        reciept.Close()

    End Sub
    
    
    Public Sub insuranceee()
        Dim tday As Date = Convert.ToDateTime(Today.ToShortDateString)
        Dim objcmd As New System.Data.OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & main.path + "activereg.mdb")

        Dim fullname As String = Label1.Text + " " + Label3.Text
        con.Open()
        Dim strSql = ("insert into insurance values ('" + My.Settings.recid2.ToString + "', '" + fullname + "', '" + tday + "', '" + TextBox1.Text + "', '" + TextBox2.Text + "')")
        objcmd = New OleDbCommand(strSql, con)


        objcmd.ExecuteNonQuery()

        con.Close()

    End Sub
    
   
End Class