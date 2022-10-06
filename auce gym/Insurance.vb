Imports System.Data.OleDb

Public Class Insurance

    Private Sub Insurance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadd()
    End Sub
    Private Sub loadd()
        main.VarrTableAdapter.Fill(main.VarrDataSet.varr)
        Try
            Dim con As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & main.path + "activereg.mdb;Jet OLEDB:Database Password=janitani2;")
            con.Open()
            Dim myadapter As New OleDb.OleDbDataAdapter("select * from insurance where Submitted='" + "No" + "'", con)
            Dim ds As New DataSet
            myadapter.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            con.Close()

        Catch ex As Exception
            MsgBox(Convert.ToString(ex))
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DataGridView1.SelectedRows.Count <> 0 Then
            Try
                Dim id As Integer = DataGridView1.SelectedRows(0).Cells(0).Value
                Dim query As String = "UPDATE [insurance] SET [Submitted]=? WHERE [ID]=?"

                Using con = New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & main.path + "activereg.mdb;Jet OLEDB:Database Password=janitani2;")


                    Using cmd = New OleDbCommand(query, con)
                        con.Open()
                        cmd.Parameters.AddWithValue("@p1", "Yes")
                        cmd.Parameters.AddWithValue("@p2", id)

                        cmd.ExecuteNonQuery()
                        con.Close()
                        con.Dispose()
                    End Using
                End Using
                exclude()
                MsgBox("Submitted")
                loadd()

            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub exclude()
        Try
            Dim cexp As Decimal = Convert.ToDecimal(main.DataGridView11.Rows(0).Cells(27).Value.ToString) + 37500
            ' Dim totalrevenue As Decimal = Convert.ToDecimal(main.DataGridView11.Rows(0).Cells(25).Value.ToString) - 37500
            Dim totalexp As Decimal = Convert.ToDecimal(main.DataGridView11.Rows(0).Cells(26).Value.ToString) + 37500
            Dim queryy As String = "UPDATE [varr] SET [cexpense]=?, [totalexpense]=? WHERE [ID]=? "
            Using conn = New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & main.path + "varr.mdb;Jet OLEDB:Database Password=janitani2;")

                Using cmd = New OleDbCommand(queryy, conn)
                    conn.Open()
                    cmd.Parameters.AddWithValue("@p1", Convert.ToString(cexp))
                    ' cmd.Parameters.AddWithValue("@p2", Convert.ToString(totalrevenue))
                    cmd.Parameters.AddWithValue("@p2", Convert.ToString(totalexp))
                    cmd.Parameters.AddWithValue("@p3", "1")
                    cmd.ExecuteNonQuery()
                    conn.Close()
                    conn.Dispose()
                    main.VarrTableAdapter.Fill(main.VarrDataSet.varr)
                End Using
            End Using
            main.VarrTableAdapter.Fill(main.VarrDataSet.varr)
            main.daily()
        Catch ex As Exception
            MsgBox(Convert.ToString(ex))
        End Try


    End Sub

    Private Sub Insurance_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        main.lod()
    End Sub
End Class