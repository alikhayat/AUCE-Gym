<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cochesedit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cochesedit))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfBirthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NationalityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MartialStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpouseNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OccupationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfBirthSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChildrenDetailsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AUCEfriendsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmergencyInfoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InsuredDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompanyInsuredDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BloodTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeOfSalaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AvailableWeeklyHoursDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreviousWageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActiveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CoachesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CoachesDataSet = New auce_gym.coachesDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CoachesTableAdapter = New auce_gym.coachesDataSetTableAdapters.coachesTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CoachesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CoachesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FullNameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.PhoneNbDataGridViewTextBoxColumn, Me.DateOfBirthDataGridViewTextBoxColumn, Me.NationalityDataGridViewTextBoxColumn, Me.MartialStatusDataGridViewTextBoxColumn, Me.SpouseNameDataGridViewTextBoxColumn, Me.OccupationDataGridViewTextBoxColumn, Me.DateOfBirthSDataGridViewTextBoxColumn, Me.ChildrenDetailsDataGridViewTextBoxColumn, Me.AUCEfriendsDataGridViewTextBoxColumn, Me.EmergencyInfoDataGridViewTextBoxColumn, Me.InsuredDataGridViewTextBoxColumn, Me.CompanyInsuredDataGridViewTextBoxColumn, Me.BloodTypeDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.TypeOfSalaryDataGridViewTextBoxColumn, Me.AvailableWeeklyHoursDataGridViewTextBoxColumn, Me.PreviousWageDataGridViewTextBoxColumn, Me.ActiveDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CoachesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1066, 290)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FullNameDataGridViewTextBoxColumn
        '
        Me.FullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName"
        Me.FullNameDataGridViewTextBoxColumn.HeaderText = "FullName"
        Me.FullNameDataGridViewTextBoxColumn.Name = "FullNameDataGridViewTextBoxColumn"
        Me.FullNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PhoneNbDataGridViewTextBoxColumn
        '
        Me.PhoneNbDataGridViewTextBoxColumn.DataPropertyName = "PhoneNb"
        Me.PhoneNbDataGridViewTextBoxColumn.HeaderText = "PhoneNb"
        Me.PhoneNbDataGridViewTextBoxColumn.Name = "PhoneNbDataGridViewTextBoxColumn"
        Me.PhoneNbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateOfBirthDataGridViewTextBoxColumn
        '
        Me.DateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth"
        Me.DateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth"
        Me.DateOfBirthDataGridViewTextBoxColumn.Name = "DateOfBirthDataGridViewTextBoxColumn"
        Me.DateOfBirthDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NationalityDataGridViewTextBoxColumn
        '
        Me.NationalityDataGridViewTextBoxColumn.DataPropertyName = "Nationality"
        Me.NationalityDataGridViewTextBoxColumn.HeaderText = "Nationality"
        Me.NationalityDataGridViewTextBoxColumn.Name = "NationalityDataGridViewTextBoxColumn"
        Me.NationalityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MartialStatusDataGridViewTextBoxColumn
        '
        Me.MartialStatusDataGridViewTextBoxColumn.DataPropertyName = "MartialStatus"
        Me.MartialStatusDataGridViewTextBoxColumn.HeaderText = "MartialStatus"
        Me.MartialStatusDataGridViewTextBoxColumn.Name = "MartialStatusDataGridViewTextBoxColumn"
        Me.MartialStatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SpouseNameDataGridViewTextBoxColumn
        '
        Me.SpouseNameDataGridViewTextBoxColumn.DataPropertyName = "SpouseName"
        Me.SpouseNameDataGridViewTextBoxColumn.HeaderText = "SpouseName"
        Me.SpouseNameDataGridViewTextBoxColumn.Name = "SpouseNameDataGridViewTextBoxColumn"
        Me.SpouseNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OccupationDataGridViewTextBoxColumn
        '
        Me.OccupationDataGridViewTextBoxColumn.DataPropertyName = "Occupation"
        Me.OccupationDataGridViewTextBoxColumn.HeaderText = "Occupation"
        Me.OccupationDataGridViewTextBoxColumn.Name = "OccupationDataGridViewTextBoxColumn"
        Me.OccupationDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateOfBirthSDataGridViewTextBoxColumn
        '
        Me.DateOfBirthSDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirthS"
        Me.DateOfBirthSDataGridViewTextBoxColumn.HeaderText = "DateOfBirthS"
        Me.DateOfBirthSDataGridViewTextBoxColumn.Name = "DateOfBirthSDataGridViewTextBoxColumn"
        Me.DateOfBirthSDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ChildrenDetailsDataGridViewTextBoxColumn
        '
        Me.ChildrenDetailsDataGridViewTextBoxColumn.DataPropertyName = "ChildrenDetails"
        Me.ChildrenDetailsDataGridViewTextBoxColumn.HeaderText = "ChildrenDetails"
        Me.ChildrenDetailsDataGridViewTextBoxColumn.Name = "ChildrenDetailsDataGridViewTextBoxColumn"
        Me.ChildrenDetailsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AUCEfriendsDataGridViewTextBoxColumn
        '
        Me.AUCEfriendsDataGridViewTextBoxColumn.DataPropertyName = "AUCEfriends"
        Me.AUCEfriendsDataGridViewTextBoxColumn.HeaderText = "AUCEfriends"
        Me.AUCEfriendsDataGridViewTextBoxColumn.Name = "AUCEfriendsDataGridViewTextBoxColumn"
        Me.AUCEfriendsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmergencyInfoDataGridViewTextBoxColumn
        '
        Me.EmergencyInfoDataGridViewTextBoxColumn.DataPropertyName = "EmergencyInfo"
        Me.EmergencyInfoDataGridViewTextBoxColumn.HeaderText = "EmergencyInfo"
        Me.EmergencyInfoDataGridViewTextBoxColumn.Name = "EmergencyInfoDataGridViewTextBoxColumn"
        Me.EmergencyInfoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InsuredDataGridViewTextBoxColumn
        '
        Me.InsuredDataGridViewTextBoxColumn.DataPropertyName = "Insured"
        Me.InsuredDataGridViewTextBoxColumn.HeaderText = "Insured"
        Me.InsuredDataGridViewTextBoxColumn.Name = "InsuredDataGridViewTextBoxColumn"
        Me.InsuredDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CompanyInsuredDataGridViewTextBoxColumn
        '
        Me.CompanyInsuredDataGridViewTextBoxColumn.DataPropertyName = "CompanyInsured"
        Me.CompanyInsuredDataGridViewTextBoxColumn.HeaderText = "CompanyInsured"
        Me.CompanyInsuredDataGridViewTextBoxColumn.Name = "CompanyInsuredDataGridViewTextBoxColumn"
        Me.CompanyInsuredDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BloodTypeDataGridViewTextBoxColumn
        '
        Me.BloodTypeDataGridViewTextBoxColumn.DataPropertyName = "BloodType"
        Me.BloodTypeDataGridViewTextBoxColumn.HeaderText = "BloodType"
        Me.BloodTypeDataGridViewTextBoxColumn.Name = "BloodTypeDataGridViewTextBoxColumn"
        Me.BloodTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TypeOfSalaryDataGridViewTextBoxColumn
        '
        Me.TypeOfSalaryDataGridViewTextBoxColumn.DataPropertyName = "TypeOfSalary"
        Me.TypeOfSalaryDataGridViewTextBoxColumn.HeaderText = "TypeOfSalary"
        Me.TypeOfSalaryDataGridViewTextBoxColumn.Name = "TypeOfSalaryDataGridViewTextBoxColumn"
        Me.TypeOfSalaryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AvailableWeeklyHoursDataGridViewTextBoxColumn
        '
        Me.AvailableWeeklyHoursDataGridViewTextBoxColumn.DataPropertyName = "AvailableWeeklyHours"
        Me.AvailableWeeklyHoursDataGridViewTextBoxColumn.HeaderText = "AvailableWeeklyHours"
        Me.AvailableWeeklyHoursDataGridViewTextBoxColumn.Name = "AvailableWeeklyHoursDataGridViewTextBoxColumn"
        Me.AvailableWeeklyHoursDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PreviousWageDataGridViewTextBoxColumn
        '
        Me.PreviousWageDataGridViewTextBoxColumn.DataPropertyName = "PreviousWage"
        Me.PreviousWageDataGridViewTextBoxColumn.HeaderText = "PreviousWage"
        Me.PreviousWageDataGridViewTextBoxColumn.Name = "PreviousWageDataGridViewTextBoxColumn"
        Me.PreviousWageDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ActiveDataGridViewTextBoxColumn
        '
        Me.ActiveDataGridViewTextBoxColumn.DataPropertyName = "Active"
        Me.ActiveDataGridViewTextBoxColumn.HeaderText = "Active"
        Me.ActiveDataGridViewTextBoxColumn.Name = "ActiveDataGridViewTextBoxColumn"
        Me.ActiveDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CoachesBindingSource
        '
        Me.CoachesBindingSource.DataMember = "coaches"
        Me.CoachesBindingSource.DataSource = Me.CoachesDataSet
        '
        'CoachesDataSet
        '
        Me.CoachesDataSet.DataSetName = "coachesDataSet"
        Me.CoachesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 352)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "- Name :"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(94, 354)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(141, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(252, 354)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "- Phone Number :"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(406, 356)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(141, 20)
        Me.TextBox2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(553, 356)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "- Active :"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"No", "Yes"})
        Me.ComboBox1.Location = New System.Drawing.Point(638, 356)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(85, 21)
        Me.ComboBox1.TabIndex = 6
        Me.ComboBox1.Text = "No"
        '
        'CoachesTableAdapter
        '
        Me.CoachesTableAdapter.ClearBeforeFill = True
        '
        'cochesedit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font

        Me.ClientSize = New System.Drawing.Size(1090, 447)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1106, 486)
        Me.MinimumSize = New System.Drawing.Size(1106, 486)
        Me.Name = "cochesedit"
        Me.Text = "Coches info edit"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CoachesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CoachesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents CoachesDataSet As auce_gym.coachesDataSet
    Friend WithEvents CoachesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CoachesTableAdapter As auce_gym.coachesDataSetTableAdapters.coachesTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FullNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneNbDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateOfBirthDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NationalityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MartialStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SpouseNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OccupationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateOfBirthSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChildrenDetailsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AUCEfriendsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmergencyInfoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InsuredDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompanyInsuredDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BloodTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeOfSalaryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AvailableWeeklyHoursDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PreviousWageDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActiveDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
