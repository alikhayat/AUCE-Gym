Imports System.Data.OleDb

Public Class salaries

    Private Sub salaries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClassesDataSet4.classes' table. You can move, or remove it, as needed.
        Me.ClassesTableAdapter.Fill(Me.ClassesDataSet4.classes)
        DataGridView2.Visible = False
        Try
            Dim tday As Date = Convert.ToDateTime(Today.AddDays(-30))
            Dim tdayy As Date = Convert.ToDateTime(Today.AddDays(-45))
            Dim con As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & main.path + "coaches.mdb")
            con.Open()
            Dim myadapter As New OleDb.OleDbDataAdapter("select * from coachesSalaries where DateActivated <#" & _
                                            tday & "# and DateActivated >#" & tdayy & "# and Paid like'" + "No" + "%' and Active like'" + "Yes" + "%'", con)

            Dim ds As New DataSet
            myadapter.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)

            con.Close()
        Catch ex As Exception
            MsgBox(Convert.ToString(ex))
        End Try
        Label13.Visible = False
        TextBox2.Visible = False


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            Dim con As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & main.path + "coaches.mdb")
            con.Open()
            Dim myadapter As New OleDb.OleDbDataAdapter("select * coachesSalaries where FullName like'" & _
                                        TextBox1.Text & "%'", con)
            Dim ds As New DataSet
            myadapter.Fill(ds)
            reports.datagridview1.DataSource = ds.Tables(0)

            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Label13.Visible = True
        TextBox2.Visible = True
        CheckBox2.Checked = False
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        Label13.Visible = False
        TextBox2.Visible = False
        CheckBox1.Checked = False
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        Try
            Label2.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString
            Label4.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString
            Label6.Text = DataGridView1.SelectedRows(0).Cells(3).Value.ToString
            Label8.Text = DataGridView1.SelectedRows(0).Cells(8).Value.ToString
            If Label4.Text = "Static salary" Then
                Label10.Text = Label6.Text
            Else
                Dim per As Decimal = Convert.ToDecimal(Label6.Text)
                Dim classs As String = DataGridView1.SelectedRows(0).Cells(4).Value.ToString

                Dim quan As Integer = 0
                Dim totalpaid As Decimal = 0
                Dim totatopay As Decimal = 0
                Dim temp As Decimal = 0
                For Each row As DataGridViewRow In main.DataGridView3.Rows
                    If row.Cells(17).Value.ToString = classs And row.Cells(16).Value.ToString < Today.AddDays(-30).ToShortDateString And row.Cells(16).Value.ToString > Today.AddDays(-40) Then
                        quan += 1
                        totalpaid += Convert.ToDecimal(row.Cells(19).Value.ToString)
                    End If
                Next
                temp = totalpaid
                temp -= (per / 100) * temp
                totatopay = totalpaid - temp
                Label10.Text = totatopay.ToString
                main.salariess()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked = False And CheckBox2.Checked = False Then
            MsgBox("please specify payment method")
        ElseIf CheckBox1.Checked = True And TextBox2.Text = "" Then
            MsgBox("specify check date")
        Else
            Dim payment As String = ""
            If CheckBox1.Checked = True Then
                payment = "Check"
            ElseIf CheckBox2.Checked = True Then
                payment = "Cash"
                TextBox2.Text = Today.ToShortDateString
            End If
            Try
                Dim tday As Date = Convert.ToDateTime(Today.ToShortDateString)
                Dim objcmdd As New System.Data.OleDb.OleDbCommand
                Dim cn As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & main.path + "coaches.mdb")
                cn.Open()
                My.Settings.paidid += 1
                Dim strSqll = ("insert into SalariesPaid values ('" + My.Settings.paidid.ToString + "', '" + Label2.Text + "', '" + Label4.Text + "', '" + Label10.Text + "', '" + tday + "', '" + payment + "', '" + TextBox2.Text + "')")
                objcmdd = New OleDbCommand(strSqll, cn)


                objcmdd.ExecuteNonQuery()

                cn.Close()
                Dim i As String = DataGridView1.SelectedRows(0).Cells(0).Value.ToString
                Dim query As String = "UPDATE [coachesSalaries] SET [Paid]=? WHERE [ID]=?"

                Using con = New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & main.path + "coaches.mdb")


                    Using cmd = New OleDbCommand(query, con)
                        con.Open()
                        cmd.Parameters.AddWithValue("@p1", "Yes")
                        cmd.Parameters.AddWithValue("@p2", i)


                        cmd.ExecuteNonQuery()
                        con.Close()
                    End Using
                End Using
                Dim expense As Decimal = Convert.ToDecimal(Label10.Text)
                My.Settings.salaryex += expense
                main.Label40.Text = My.Settings.salaryex.ToString + " L.L"
                My.Settings.totalexpense += expense
                main.daily()
                MsgBox("paid and and to records")
            Catch ex As Exception
                MsgBox(Convert.ToString(ex))
            End Try
           
        End If
    End Sub
End Class