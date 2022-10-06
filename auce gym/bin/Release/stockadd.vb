Imports System.Data.OleDb

Public Class stockadd
    Dim old As Integer = 0
    Private Sub stockadd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label6.Text = Today.ToShortDateString


        Try
            old = Convert.ToInt32(TextBox4.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
                MsgBox("Please fill empty fields")
            Else
                Dim objcmd As New System.Data.OleDb.OleDbCommand
                Dim con As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & main.path + "stock.mdb")
                My.Settings.itemid += 1
                Dim quan As Decimal = Convert.ToDecimal(TextBox4.Text)
                con.Open()
                Dim strSql = ("insert into stock values ('" + My.Settings.itemid.ToString + "', '" + TextBox1.Text + "', '" + TextBox4.Text + "', '" + TextBox2.Text + "', '" + TextBox3.Text + "', '" + Label6.Text + "')")
                objcmd = New OleDbCommand(strSql, con)


                objcmd.ExecuteNonQuery()

                con.Close()

                MsgBox("Item added")

                Try
                    Dim expense As Decimal = Convert.ToDecimal(TextBox2.Text)
                    Dim q As Integer = Convert.ToInt32(TextBox4.Text)
                    Dim total As Decimal = q * expense
                    My.Settings.totalexpense += total
                    My.Settings.expenses += total
                    main.Label41.Text = My.Settings.expenses.ToString + " L.L"
                    main.Label42.Text = My.Settings.totalexpense.ToString + " L.L"
                    Dim objcmdd As New System.Data.OleDb.OleDbCommand
                    Dim cn As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & main.path + "stock.mdb")
                    Dim tday As Date = Convert.ToDateTime(Today.ToShortDateString)
                    cn.Open()
                    My.Settings.sexpense += 1
                    Dim strSqll = ("insert into expenses values ('" + My.Settings.sexpense.ToString + "', '" + TextBox1.Text + "', '" + TextBox2.Text + "', '" + TextBox3.Text + "', '" + TextBox4.Text + "', '" + tday + "', '" + total.ToString + "')")
                    objcmdd = New OleDbCommand(strSqll, cn)


                    objcmdd.ExecuteNonQuery()

                    cn.Close()
                    clear()
                Catch ex As Exception

                End Try
                
                main.StockTableAdapter.Fill(main.StockDataSet.stock)
                Me.Close()
            End If
            
        Catch ex As Exception
            MsgBox(Convert.ToString(ex))
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim t As Integer = Convert.ToInt32(TextBox4.Text)
        Try
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
                MsgBox("Please fill empty fields")
            ElseIf t - old < 0 Then
                MsgBox("quantity decreased")
            Else

                Dim query As String = "UPDATE [stock] SET [Name]=?,[BasePrice]=?,[RetailPrice]=?," +
           "[Quantity]=?,[DateAdded]=? WHERE [ID]=?"

                Using con = New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & main.path + "stock.mdb")

                    Dim quan As Decimal = Convert.ToInt64(TextBox4.Text)
                    Using cmd = New OleDbCommand(query, con)
                        con.Open()
                        cmd.Parameters.AddWithValue("@p1", TextBox1.Text)
                        cmd.Parameters.AddWithValue("@p2", TextBox2.Text)
                        cmd.Parameters.AddWithValue("@p3", TextBox3.Text)
                        cmd.Parameters.AddWithValue("@p4", TextBox4.Text)
                        cmd.Parameters.AddWithValue("@p5", Label6.Text)


                        cmd.Parameters.AddWithValue("@p6", Label8.Text)


                        cmd.ExecuteNonQuery()
                        con.Close()
                        MsgBox("Item updated")
                    End Using
                End Using


                Dim s As String = main.DataGridView2.SelectedRows(0).Cells(2).Value.ToString
                Dim o As Integer = Convert.ToInt32(s)
                Dim q As Integer = Convert.ToInt32(TextBox4.Text.Trim) - o
                Dim expense As Decimal = Convert.ToDecimal(TextBox2.Text)
                Dim total As Decimal = 0
                total = q * expense
                My.Settings.expenses += expense * q
                main.Label41.Text = My.Settings.expenses.ToString + " L.L"
                My.Settings.totalexpense += total
                main.Label42.Text = My.Settings.totalexpense.ToString + " L.L"
                My.Settings.sexpense += 1
                If t - old <= 0 Then
                    Stop
                Else
                    Dim tday As Date = Convert.ToDateTime(Today.ToShortDateString)
                    Dim objcmdd As New System.Data.OleDb.OleDbCommand
                    Dim cn As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & main.path + "stock.mdb")

                    cn.Open()
                    Dim strSqll = ("insert into expenses values ('" + My.Settings.sexpense.ToString + "', '" + TextBox1.Text + "', '" + TextBox2.Text + "', '" + TextBox3.Text + "', '" + q.ToString + "', '" + tday + "', '" + total.ToString + "')")
                    objcmdd = New OleDbCommand(strSqll, cn)


                    objcmdd.ExecuteNonQuery()

                    cn.Close()
                    main.StockTableAdapter.Fill(main.StockDataSet.stock)
                    clear()
                End If
                

            End If
        Catch ex As Exception
            MsgBox(Convert.ToString(ex))
        End Try

    End Sub
    Public Sub clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()

    End Sub
End Class