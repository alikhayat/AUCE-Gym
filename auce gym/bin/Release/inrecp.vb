Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class inrecp





    Private Sub inrecp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.recid2 += 1
        Dim recid As TextObject
        recid = CrystalReport21.ReportDefinition.ReportObjects("text3")
        ' display the value for the report
        recid.Text = My.Settings.recid2.ToString
        Dim recid2 As TextObject
        recid2 = CrystalReport21.ReportDefinition.ReportObjects("text14")
        ' display the value for the report
        recid2.Text = My.Settings.recid2.ToString
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