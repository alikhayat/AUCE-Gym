Imports Microsoft.VisualBasic.PowerPacks.Printing
Imports System.Drawing.Printing
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.OleDb

Public Class reciept

    Private Sub reciept_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        main.VarrTableAdapter.Fill(main.VarrDataSet.varr)
        Dim total As Decimal = Convert.ToDecimal(assign.Label26.Text)
        'My.Settings.recnb += 1
        Try
            Dim recnbb As Integer = Convert.ToInt32(main.DataGridView11.Rows(0).Cells(11).Value.ToString) + 1

            Dim queryyy As String = "UPDATE [varr] SET [recnb]=? WHERE [ID]=? "
            Using conn = New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & main.path + "varr.mdb;Jet OLEDB:Database Password=janitani2;")

                Using cmd = New OleDbCommand(queryyy, conn)
                    conn.Open()
                    cmd.Parameters.AddWithValue("@p1", recnbb.ToString)
                    cmd.Parameters.AddWithValue("@p2", "1")
                    cmd.ExecuteNonQuery()
                    conn.Close()
                    main.VarrTableAdapter.Fill(main.VarrDataSet.varr)
                End Using
            End Using
        Catch ex As Exception
            MsgBox(Convert.ToString(ex))
        End Try
        
        Dim recnb As TextObject
        recnb = CrystalReport11.ReportDefinition.ReportObjects("text4")
        ' display the value for the report
        recnb.Text = main.DataGridView11.Rows(0).Cells(11).Value.ToString
        Dim recnb2 As TextObject
        recnb2 = CrystalReport11.ReportDefinition.ReportObjects("text21")
        ' display the value for the report
        recnb2.Text = main.DataGridView11.Rows(0).Cells(11).Value.ToString
        Dim fname As TextObject
        fname = CrystalReport11.ReportDefinition.ReportObjects("text6")
        ' display the value for the report
        fname.Text = assign.Label1.Text + " " + assign.Label3.Text
        Dim fname2 As TextObject
        fname2 = CrystalReport11.ReportDefinition.ReportObjects("text23")
        ' display the value for the report
        fname2.Text = assign.Label1.Text + " " + assign.Label3.Text
        Dim dis As Integer = 0
        Dim price As Decimal = Convert.ToDecimal(assign.Label26.Text)

        If assign.Label17.Text = "Relative" Then
            price += (10 / 100) * price
            dis = 10
        ElseIf assign.Label17.Text = "Student" Or assign.Label17.Text = "Teacher" Or assign.Label17.Text = "Staff" Then
            price += (50 / 100) * price
            dis = 50
        ElseIf assign.Label17.Text = "Regular" Then

            dis = 0
        End If
        If assign.doubled = True Then
            dis += 10
            price += (10 / 100) * price
        End If
        If assign.Label10.Text <> "THIS USER IS INSURED" And assign.ComboBox1.SelectedIndex = 0 Then
            price -= 37500
            total -= 37500
        End If
        Dim disc As TextObject
        disc = CrystalReport11.ReportDefinition.ReportObjects("text10")
        ' display the value for the report
        disc.Text = dis.ToString + " %"
        Dim disc2 As TextObject
        disc2 = CrystalReport11.ReportDefinition.ReportObjects("text27")
        ' display the value for the report
        disc2.Text = dis.ToString + " %"


        Dim tot As TextObject
        tot = CrystalReport11.ReportDefinition.ReportObjects("text12")
        ' display the value for the report
        tot.Text = total.ToString + " L.L"
        Dim tot2 As TextObject
        tot2 = CrystalReport11.ReportDefinition.ReportObjects("text29")
        ' display the value for the report
        tot2.Text = total.ToString + " L.L"
        Dim till As TextObject
        till = CrystalReport11.ReportDefinition.ReportObjects("text14")
        ' display the value for the report
        till.Text = Today.AddDays(31).ToShortDateString
        Dim till2 As TextObject
        till2 = CrystalReport11.ReportDefinition.ReportObjects("text31")
        ' display the value for the report
        till2.Text = Today.AddDays(31).ToShortDateString
        Dim clas As TextObject
        clas = CrystalReport11.ReportDefinition.ReportObjects("text16")
        ' display the value for the report
        clas.Text = assign.ComboBox2.Text
        Dim clas1 As TextObject
        clas1 = CrystalReport11.ReportDefinition.ReportObjects("text33")
        ' display the value for the report
        clas1.Text = assign.ComboBox2.Text

    End Sub
    Public Sub print()

    End Sub


End Class