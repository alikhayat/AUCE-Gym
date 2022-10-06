Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.OleDb

Public Class inrecp





    Private Sub inrecp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        main.VarrTableAdapter.Fill(main.VarrDataSet.varr)
        'My.Settings.recid2 += 1
        Try
            Dim recid22 As Integer = Convert.ToInt32(main.DataGridView11.Rows(0).Cells(30).Value.ToString) + 1

            Dim queryyy As String = "UPDATE [varr] SET [recid2]=? WHERE [ID]=? "
            Using conn = New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & main.path + "varr.mdb;Jet OLEDB:Database Password=janitani2;")

                Using cmd = New OleDbCommand(queryyy, conn)
                    conn.Open()
                    cmd.Parameters.AddWithValue("@p1", recid22.ToString)
                    cmd.Parameters.AddWithValue("@p2", "1")
                    cmd.ExecuteNonQuery()
                    conn.Close()
                    conn.Dispose()
                    main.VarrTableAdapter.Fill(main.VarrDataSet.varr)
                End Using
            End Using
        Catch ex As Exception
            MsgBox(Convert.ToString(ex))
        End Try
       
        Dim recid As TextObject
        recid = CrystalReport21.ReportDefinition.ReportObjects("text3")
        ' display the value for the report
        recid.Text = main.DataGridView11.Rows(0).Cells(30).Value.ToString
        Dim recid2 As TextObject
        recid2 = CrystalReport21.ReportDefinition.ReportObjects("text14")
        ' display the value for the report
        recid2.Text = main.DataGridView11.Rows(0).Cells(30).Value.ToString
        Dim fees As TextObject
        fees = CrystalReport21.ReportDefinition.ReportObjects("text5")
        ' display the value for the report
        fees.Text = "37500 L.L"
        Dim fees2 As TextObject
        fees2 = CrystalReport21.ReportDefinition.ReportObjects("text16")
        ' display the value for the report
        fees2.Text = "37500 L.L"
        Dim from As TextObject
        from = CrystalReport21.ReportDefinition.ReportObjects("text7")
        ' display the value for the report
        from.Text = Today.ToShortDateString
        Dim from2 As TextObject
        from2 = CrystalReport21.ReportDefinition.ReportObjects("text18")
        ' display the value for the report
        from2.Text = Today.ToShortDateString
        Dim till As TextObject
        till = CrystalReport21.ReportDefinition.ReportObjects("text9")
        ' display the value for the report
        till.Text = Today.AddDays(365).ToShortDateString
        Dim till2 As TextObject
        till2 = CrystalReport21.ReportDefinition.ReportObjects("text20")
        ' display the value for the report
        till2.Text = Today.AddDays(365).ToShortDateString
    End Sub
End Class