<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SesidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CochidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubstdayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrentuserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pass1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pass2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pass3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecnbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TempDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChangedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalaryidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RevenueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpensesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexpenseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SrevenueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubrevenueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InrevenueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalrevenueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalexpenseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CexpenseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubrevDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Recid2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaididDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalaryexDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalsubsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastdayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VarrBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VarrDataSet1 = New auce_gym.varrDataSet1()
        Me.VarrTableAdapter = New auce_gym.varrDataSet1TableAdapters.varrTableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VarrBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VarrDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "- Username :"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 244)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "- Password :"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(126, 203)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(131, 23)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(126, 244)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(131, 20)
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.Tag = "******"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(182, 289)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.GidDataGridViewTextBoxColumn, Me.SesidDataGridViewTextBoxColumn, Me.CochidDataGridViewTextBoxColumn, Me.SubstdayDataGridViewTextBoxColumn, Me.TotalsDataGridViewTextBoxColumn, Me.ADataGridViewTextBoxColumn, Me.CurrentuserDataGridViewTextBoxColumn, Me.Pass1DataGridViewTextBoxColumn, Me.Pass2DataGridViewTextBoxColumn, Me.Pass3DataGridViewTextBoxColumn, Me.RecnbDataGridViewTextBoxColumn, Me.TempDataGridViewTextBoxColumn, Me.ChangedDataGridViewTextBoxColumn, Me.RegidDataGridViewTextBoxColumn, Me.MedidDataGridViewTextBoxColumn, Me.SalaryidDataGridViewTextBoxColumn, Me.ItemidDataGridViewTextBoxColumn, Me.RevenueDataGridViewTextBoxColumn, Me.ExpensesDataGridViewTextBoxColumn, Me.SexpenseDataGridViewTextBoxColumn, Me.SrevenueDataGridViewTextBoxColumn, Me.VDataGridViewTextBoxColumn, Me.SubrevenueDataGridViewTextBoxColumn, Me.InrevenueDataGridViewTextBoxColumn, Me.TotalrevenueDataGridViewTextBoxColumn, Me.TotalexpenseDataGridViewTextBoxColumn, Me.CexpenseDataGridViewTextBoxColumn, Me.SubrevDataGridViewTextBoxColumn, Me.DidDataGridViewTextBoxColumn, Me.Recid2DataGridViewTextBoxColumn, Me.PaididDataGridViewTextBoxColumn, Me.SalaryexDataGridViewTextBoxColumn, Me.TotalsubsDataGridViewTextBoxColumn, Me.LastdayDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.VarrBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(247, 117)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(168, 150)
        Me.DataGridView1.TabIndex = 6
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GidDataGridViewTextBoxColumn
        '
        Me.GidDataGridViewTextBoxColumn.DataPropertyName = "gid"
        Me.GidDataGridViewTextBoxColumn.HeaderText = "gid"
        Me.GidDataGridViewTextBoxColumn.Name = "GidDataGridViewTextBoxColumn"
        Me.GidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SesidDataGridViewTextBoxColumn
        '
        Me.SesidDataGridViewTextBoxColumn.DataPropertyName = "sesid"
        Me.SesidDataGridViewTextBoxColumn.HeaderText = "sesid"
        Me.SesidDataGridViewTextBoxColumn.Name = "SesidDataGridViewTextBoxColumn"
        Me.SesidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CochidDataGridViewTextBoxColumn
        '
        Me.CochidDataGridViewTextBoxColumn.DataPropertyName = "cochid"
        Me.CochidDataGridViewTextBoxColumn.HeaderText = "cochid"
        Me.CochidDataGridViewTextBoxColumn.Name = "CochidDataGridViewTextBoxColumn"
        Me.CochidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SubstdayDataGridViewTextBoxColumn
        '
        Me.SubstdayDataGridViewTextBoxColumn.DataPropertyName = "substday"
        Me.SubstdayDataGridViewTextBoxColumn.HeaderText = "substday"
        Me.SubstdayDataGridViewTextBoxColumn.Name = "SubstdayDataGridViewTextBoxColumn"
        Me.SubstdayDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalsDataGridViewTextBoxColumn
        '
        Me.TotalsDataGridViewTextBoxColumn.DataPropertyName = "totals"
        Me.TotalsDataGridViewTextBoxColumn.HeaderText = "totals"
        Me.TotalsDataGridViewTextBoxColumn.Name = "TotalsDataGridViewTextBoxColumn"
        Me.TotalsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ADataGridViewTextBoxColumn
        '
        Me.ADataGridViewTextBoxColumn.DataPropertyName = "a"
        Me.ADataGridViewTextBoxColumn.HeaderText = "a"
        Me.ADataGridViewTextBoxColumn.Name = "ADataGridViewTextBoxColumn"
        Me.ADataGridViewTextBoxColumn.ReadOnly = True
        '
        'CurrentuserDataGridViewTextBoxColumn
        '
        Me.CurrentuserDataGridViewTextBoxColumn.DataPropertyName = "currentuser"
        Me.CurrentuserDataGridViewTextBoxColumn.HeaderText = "currentuser"
        Me.CurrentuserDataGridViewTextBoxColumn.Name = "CurrentuserDataGridViewTextBoxColumn"
        Me.CurrentuserDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Pass1DataGridViewTextBoxColumn
        '
        Me.Pass1DataGridViewTextBoxColumn.DataPropertyName = "pass1"
        Me.Pass1DataGridViewTextBoxColumn.HeaderText = "pass1"
        Me.Pass1DataGridViewTextBoxColumn.Name = "Pass1DataGridViewTextBoxColumn"
        Me.Pass1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Pass2DataGridViewTextBoxColumn
        '
        Me.Pass2DataGridViewTextBoxColumn.DataPropertyName = "pass2"
        Me.Pass2DataGridViewTextBoxColumn.HeaderText = "pass2"
        Me.Pass2DataGridViewTextBoxColumn.Name = "Pass2DataGridViewTextBoxColumn"
        Me.Pass2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Pass3DataGridViewTextBoxColumn
        '
        Me.Pass3DataGridViewTextBoxColumn.DataPropertyName = "pass3"
        Me.Pass3DataGridViewTextBoxColumn.HeaderText = "pass3"
        Me.Pass3DataGridViewTextBoxColumn.Name = "Pass3DataGridViewTextBoxColumn"
        Me.Pass3DataGridViewTextBoxColumn.ReadOnly = True
        '
        'RecnbDataGridViewTextBoxColumn
        '
        Me.RecnbDataGridViewTextBoxColumn.DataPropertyName = "recnb"
        Me.RecnbDataGridViewTextBoxColumn.HeaderText = "recnb"
        Me.RecnbDataGridViewTextBoxColumn.Name = "RecnbDataGridViewTextBoxColumn"
        Me.RecnbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TempDataGridViewTextBoxColumn
        '
        Me.TempDataGridViewTextBoxColumn.DataPropertyName = "temp"
        Me.TempDataGridViewTextBoxColumn.HeaderText = "temp"
        Me.TempDataGridViewTextBoxColumn.Name = "TempDataGridViewTextBoxColumn"
        Me.TempDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ChangedDataGridViewTextBoxColumn
        '
        Me.ChangedDataGridViewTextBoxColumn.DataPropertyName = "changed"
        Me.ChangedDataGridViewTextBoxColumn.HeaderText = "changed"
        Me.ChangedDataGridViewTextBoxColumn.Name = "ChangedDataGridViewTextBoxColumn"
        Me.ChangedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RegidDataGridViewTextBoxColumn
        '
        Me.RegidDataGridViewTextBoxColumn.DataPropertyName = "regid"
        Me.RegidDataGridViewTextBoxColumn.HeaderText = "regid"
        Me.RegidDataGridViewTextBoxColumn.Name = "RegidDataGridViewTextBoxColumn"
        Me.RegidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MedidDataGridViewTextBoxColumn
        '
        Me.MedidDataGridViewTextBoxColumn.DataPropertyName = "medid"
        Me.MedidDataGridViewTextBoxColumn.HeaderText = "medid"
        Me.MedidDataGridViewTextBoxColumn.Name = "MedidDataGridViewTextBoxColumn"
        Me.MedidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SalaryidDataGridViewTextBoxColumn
        '
        Me.SalaryidDataGridViewTextBoxColumn.DataPropertyName = "salaryid"
        Me.SalaryidDataGridViewTextBoxColumn.HeaderText = "salaryid"
        Me.SalaryidDataGridViewTextBoxColumn.Name = "SalaryidDataGridViewTextBoxColumn"
        Me.SalaryidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemidDataGridViewTextBoxColumn
        '
        Me.ItemidDataGridViewTextBoxColumn.DataPropertyName = "itemid"
        Me.ItemidDataGridViewTextBoxColumn.HeaderText = "itemid"
        Me.ItemidDataGridViewTextBoxColumn.Name = "ItemidDataGridViewTextBoxColumn"
        Me.ItemidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RevenueDataGridViewTextBoxColumn
        '
        Me.RevenueDataGridViewTextBoxColumn.DataPropertyName = "revenue"
        Me.RevenueDataGridViewTextBoxColumn.HeaderText = "revenue"
        Me.RevenueDataGridViewTextBoxColumn.Name = "RevenueDataGridViewTextBoxColumn"
        Me.RevenueDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ExpensesDataGridViewTextBoxColumn
        '
        Me.ExpensesDataGridViewTextBoxColumn.DataPropertyName = "expenses"
        Me.ExpensesDataGridViewTextBoxColumn.HeaderText = "expenses"
        Me.ExpensesDataGridViewTextBoxColumn.Name = "ExpensesDataGridViewTextBoxColumn"
        Me.ExpensesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SexpenseDataGridViewTextBoxColumn
        '
        Me.SexpenseDataGridViewTextBoxColumn.DataPropertyName = "sexpense"
        Me.SexpenseDataGridViewTextBoxColumn.HeaderText = "sexpense"
        Me.SexpenseDataGridViewTextBoxColumn.Name = "SexpenseDataGridViewTextBoxColumn"
        Me.SexpenseDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SrevenueDataGridViewTextBoxColumn
        '
        Me.SrevenueDataGridViewTextBoxColumn.DataPropertyName = "srevenue"
        Me.SrevenueDataGridViewTextBoxColumn.HeaderText = "srevenue"
        Me.SrevenueDataGridViewTextBoxColumn.Name = "SrevenueDataGridViewTextBoxColumn"
        Me.SrevenueDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VDataGridViewTextBoxColumn
        '
        Me.VDataGridViewTextBoxColumn.DataPropertyName = "v"
        Me.VDataGridViewTextBoxColumn.HeaderText = "v"
        Me.VDataGridViewTextBoxColumn.Name = "VDataGridViewTextBoxColumn"
        Me.VDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SubrevenueDataGridViewTextBoxColumn
        '
        Me.SubrevenueDataGridViewTextBoxColumn.DataPropertyName = "subrevenue"
        Me.SubrevenueDataGridViewTextBoxColumn.HeaderText = "subrevenue"
        Me.SubrevenueDataGridViewTextBoxColumn.Name = "SubrevenueDataGridViewTextBoxColumn"
        Me.SubrevenueDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InrevenueDataGridViewTextBoxColumn
        '
        Me.InrevenueDataGridViewTextBoxColumn.DataPropertyName = "inrevenue"
        Me.InrevenueDataGridViewTextBoxColumn.HeaderText = "inrevenue"
        Me.InrevenueDataGridViewTextBoxColumn.Name = "InrevenueDataGridViewTextBoxColumn"
        Me.InrevenueDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalrevenueDataGridViewTextBoxColumn
        '
        Me.TotalrevenueDataGridViewTextBoxColumn.DataPropertyName = "totalrevenue"
        Me.TotalrevenueDataGridViewTextBoxColumn.HeaderText = "totalrevenue"
        Me.TotalrevenueDataGridViewTextBoxColumn.Name = "TotalrevenueDataGridViewTextBoxColumn"
        Me.TotalrevenueDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalexpenseDataGridViewTextBoxColumn
        '
        Me.TotalexpenseDataGridViewTextBoxColumn.DataPropertyName = "totalexpense"
        Me.TotalexpenseDataGridViewTextBoxColumn.HeaderText = "totalexpense"
        Me.TotalexpenseDataGridViewTextBoxColumn.Name = "TotalexpenseDataGridViewTextBoxColumn"
        Me.TotalexpenseDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CexpenseDataGridViewTextBoxColumn
        '
        Me.CexpenseDataGridViewTextBoxColumn.DataPropertyName = "cexpense"
        Me.CexpenseDataGridViewTextBoxColumn.HeaderText = "cexpense"
        Me.CexpenseDataGridViewTextBoxColumn.Name = "CexpenseDataGridViewTextBoxColumn"
        Me.CexpenseDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SubrevDataGridViewTextBoxColumn
        '
        Me.SubrevDataGridViewTextBoxColumn.DataPropertyName = "subrev"
        Me.SubrevDataGridViewTextBoxColumn.HeaderText = "subrev"
        Me.SubrevDataGridViewTextBoxColumn.Name = "SubrevDataGridViewTextBoxColumn"
        Me.SubrevDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DidDataGridViewTextBoxColumn
        '
        Me.DidDataGridViewTextBoxColumn.DataPropertyName = "did"
        Me.DidDataGridViewTextBoxColumn.HeaderText = "did"
        Me.DidDataGridViewTextBoxColumn.Name = "DidDataGridViewTextBoxColumn"
        Me.DidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Recid2DataGridViewTextBoxColumn
        '
        Me.Recid2DataGridViewTextBoxColumn.DataPropertyName = "recid2"
        Me.Recid2DataGridViewTextBoxColumn.HeaderText = "recid2"
        Me.Recid2DataGridViewTextBoxColumn.Name = "Recid2DataGridViewTextBoxColumn"
        Me.Recid2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'PaididDataGridViewTextBoxColumn
        '
        Me.PaididDataGridViewTextBoxColumn.DataPropertyName = "paidid"
        Me.PaididDataGridViewTextBoxColumn.HeaderText = "paidid"
        Me.PaididDataGridViewTextBoxColumn.Name = "PaididDataGridViewTextBoxColumn"
        Me.PaididDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SalaryexDataGridViewTextBoxColumn
        '
        Me.SalaryexDataGridViewTextBoxColumn.DataPropertyName = "salaryex"
        Me.SalaryexDataGridViewTextBoxColumn.HeaderText = "salaryex"
        Me.SalaryexDataGridViewTextBoxColumn.Name = "SalaryexDataGridViewTextBoxColumn"
        Me.SalaryexDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalsubsDataGridViewTextBoxColumn
        '
        Me.TotalsubsDataGridViewTextBoxColumn.DataPropertyName = "totalsubs"
        Me.TotalsubsDataGridViewTextBoxColumn.HeaderText = "totalsubs"
        Me.TotalsubsDataGridViewTextBoxColumn.Name = "TotalsubsDataGridViewTextBoxColumn"
        Me.TotalsubsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastdayDataGridViewTextBoxColumn
        '
        Me.LastdayDataGridViewTextBoxColumn.DataPropertyName = "lastday"
        Me.LastdayDataGridViewTextBoxColumn.HeaderText = "lastday"
        Me.LastdayDataGridViewTextBoxColumn.Name = "LastdayDataGridViewTextBoxColumn"
        Me.LastdayDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VarrBindingSource
        '
        Me.VarrBindingSource.DataMember = "varr"
        Me.VarrBindingSource.DataSource = Me.VarrDataSet1
        '
        'VarrDataSet1
        '
        Me.VarrDataSet1.DataSetName = "varrDataSet1"
        Me.VarrDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VarrTableAdapter
        '
        Me.VarrTableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = Global.auce_gym.My.Resources.Resources.auce_logo
        Me.PictureBox1.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(534, 170)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 324)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(553, 363)
        Me.MinimumSize = New System.Drawing.Size(553, 363)
        Me.Name = "Form1"
        Me.Text = "Login"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VarrBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VarrDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents VarrDataSet1 As auce_gym.varrDataSet1
    Friend WithEvents VarrBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VarrTableAdapter As auce_gym.varrDataSet1TableAdapters.varrTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SesidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CochidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubstdayDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrentuserDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pass1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pass2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pass3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RecnbDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TempDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChangedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RegidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MedidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SalaryidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RevenueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExpensesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SexpenseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SrevenueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubrevenueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InrevenueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalrevenueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalexpenseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CexpenseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubrevDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Recid2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaididDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SalaryexDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalsubsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastdayDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
