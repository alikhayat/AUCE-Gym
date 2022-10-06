<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class subbadd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(subbadd))
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dd = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotherNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SchoolUniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EducationLevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RelativeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfBirthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BloodTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassDiscountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmergencyNbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApplicantsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Applicants1DataSet3 = New auce_gym.applicants1DataSet3()
        Me.ApplicantsTableAdapter = New auce_gym.applicants1DataSet3TableAdapters.applicantsTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicineUseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LongTermDiseaseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScareCausesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AllergiesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProblemStayingAloneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SocialzingProblemsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InsuredByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Applicants1DataSet4 = New auce_gym.applicants1DataSet4()
        Me.MedicalTableAdapter = New auce_gym.applicants1DataSet4TableAdapters.medicalTableAdapter()
        CType(Me.dd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApplicantsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Applicants1DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Applicants1DataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(67, 395)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 13
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(134, 349)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 12
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(94, 307)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 393)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "- ID :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 347)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "- Last Name :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 305)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "- Name :"
        '
        'dd
        '
        Me.dd.AllowUserToAddRows = False
        Me.dd.AllowUserToDeleteRows = False
        Me.dd.AutoGenerateColumns = False
        Me.dd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.MotherNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.SchoolUniDataGridViewTextBoxColumn, Me.EducationLevelDataGridViewTextBoxColumn, Me.RelativeDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.DateOfBirthDataGridViewTextBoxColumn, Me.PhoneNbDataGridViewTextBoxColumn, Me.BloodTypeDataGridViewTextBoxColumn, Me.ClassDiscountDataGridViewTextBoxColumn, Me.EmergencyNbDataGridViewTextBoxColumn})
        Me.dd.DataSource = Me.ApplicantsBindingSource
        Me.dd.Location = New System.Drawing.Point(12, 12)
        Me.dd.Name = "dd"
        Me.dd.ReadOnly = True
        Me.dd.Size = New System.Drawing.Size(1062, 270)
        Me.dd.TabIndex = 7
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MotherNameDataGridViewTextBoxColumn
        '
        Me.MotherNameDataGridViewTextBoxColumn.DataPropertyName = "MotherName"
        Me.MotherNameDataGridViewTextBoxColumn.HeaderText = "MotherName"
        Me.MotherNameDataGridViewTextBoxColumn.Name = "MotherNameDataGridViewTextBoxColumn"
        Me.MotherNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SchoolUniDataGridViewTextBoxColumn
        '
        Me.SchoolUniDataGridViewTextBoxColumn.DataPropertyName = "School/Uni"
        Me.SchoolUniDataGridViewTextBoxColumn.HeaderText = "School/Uni"
        Me.SchoolUniDataGridViewTextBoxColumn.Name = "SchoolUniDataGridViewTextBoxColumn"
        Me.SchoolUniDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EducationLevelDataGridViewTextBoxColumn
        '
        Me.EducationLevelDataGridViewTextBoxColumn.DataPropertyName = "EducationLevel"
        Me.EducationLevelDataGridViewTextBoxColumn.HeaderText = "EducationLevel"
        Me.EducationLevelDataGridViewTextBoxColumn.Name = "EducationLevelDataGridViewTextBoxColumn"
        Me.EducationLevelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RelativeDataGridViewTextBoxColumn
        '
        Me.RelativeDataGridViewTextBoxColumn.DataPropertyName = "Relative"
        Me.RelativeDataGridViewTextBoxColumn.HeaderText = "Relative"
        Me.RelativeDataGridViewTextBoxColumn.Name = "RelativeDataGridViewTextBoxColumn"
        Me.RelativeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        Me.GenderDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateOfBirthDataGridViewTextBoxColumn
        '
        Me.DateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth"
        Me.DateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth"
        Me.DateOfBirthDataGridViewTextBoxColumn.Name = "DateOfBirthDataGridViewTextBoxColumn"
        Me.DateOfBirthDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PhoneNbDataGridViewTextBoxColumn
        '
        Me.PhoneNbDataGridViewTextBoxColumn.DataPropertyName = "PhoneNb"
        Me.PhoneNbDataGridViewTextBoxColumn.HeaderText = "PhoneNb"
        Me.PhoneNbDataGridViewTextBoxColumn.Name = "PhoneNbDataGridViewTextBoxColumn"
        Me.PhoneNbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BloodTypeDataGridViewTextBoxColumn
        '
        Me.BloodTypeDataGridViewTextBoxColumn.DataPropertyName = "BloodType"
        Me.BloodTypeDataGridViewTextBoxColumn.HeaderText = "BloodType"
        Me.BloodTypeDataGridViewTextBoxColumn.Name = "BloodTypeDataGridViewTextBoxColumn"
        Me.BloodTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClassDiscountDataGridViewTextBoxColumn
        '
        Me.ClassDiscountDataGridViewTextBoxColumn.DataPropertyName = "Class/Discount"
        Me.ClassDiscountDataGridViewTextBoxColumn.HeaderText = "Class/Discount"
        Me.ClassDiscountDataGridViewTextBoxColumn.Name = "ClassDiscountDataGridViewTextBoxColumn"
        Me.ClassDiscountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmergencyNbDataGridViewTextBoxColumn
        '
        Me.EmergencyNbDataGridViewTextBoxColumn.DataPropertyName = "EmergencyNb"
        Me.EmergencyNbDataGridViewTextBoxColumn.HeaderText = "EmergencyNb"
        Me.EmergencyNbDataGridViewTextBoxColumn.Name = "EmergencyNbDataGridViewTextBoxColumn"
        Me.EmergencyNbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ApplicantsBindingSource
        '
        Me.ApplicantsBindingSource.DataMember = "applicants"
        Me.ApplicantsBindingSource.DataSource = Me.Applicants1DataSet3
        '
        'Applicants1DataSet3
        '
        Me.Applicants1DataSet3.DataSetName = "applicants1DataSet3"
        Me.Applicants1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ApplicantsTableAdapter
        '
        Me.ApplicantsTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.MedicineUseDataGridViewTextBoxColumn, Me.LongTermDiseaseDataGridViewTextBoxColumn, Me.ScareCausesDataGridViewTextBoxColumn, Me.AllergiesDataGridViewTextBoxColumn, Me.ProblemStayingAloneDataGridViewTextBoxColumn, Me.SocialzingProblemsDataGridViewTextBoxColumn, Me.InsuredByDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MedicalBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(450, 288)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 14
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        Me.IDDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'MedicineUseDataGridViewTextBoxColumn
        '
        Me.MedicineUseDataGridViewTextBoxColumn.DataPropertyName = "MedicineUse"
        Me.MedicineUseDataGridViewTextBoxColumn.HeaderText = "MedicineUse"
        Me.MedicineUseDataGridViewTextBoxColumn.Name = "MedicineUseDataGridViewTextBoxColumn"
        Me.MedicineUseDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LongTermDiseaseDataGridViewTextBoxColumn
        '
        Me.LongTermDiseaseDataGridViewTextBoxColumn.DataPropertyName = "LongTermDisease"
        Me.LongTermDiseaseDataGridViewTextBoxColumn.HeaderText = "LongTermDisease"
        Me.LongTermDiseaseDataGridViewTextBoxColumn.Name = "LongTermDiseaseDataGridViewTextBoxColumn"
        Me.LongTermDiseaseDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ScareCausesDataGridViewTextBoxColumn
        '
        Me.ScareCausesDataGridViewTextBoxColumn.DataPropertyName = "ScareCauses"
        Me.ScareCausesDataGridViewTextBoxColumn.HeaderText = "ScareCauses"
        Me.ScareCausesDataGridViewTextBoxColumn.Name = "ScareCausesDataGridViewTextBoxColumn"
        Me.ScareCausesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AllergiesDataGridViewTextBoxColumn
        '
        Me.AllergiesDataGridViewTextBoxColumn.DataPropertyName = "Allergies"
        Me.AllergiesDataGridViewTextBoxColumn.HeaderText = "Allergies"
        Me.AllergiesDataGridViewTextBoxColumn.Name = "AllergiesDataGridViewTextBoxColumn"
        Me.AllergiesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProblemStayingAloneDataGridViewTextBoxColumn
        '
        Me.ProblemStayingAloneDataGridViewTextBoxColumn.DataPropertyName = "ProblemStayingAlone"
        Me.ProblemStayingAloneDataGridViewTextBoxColumn.HeaderText = "ProblemStayingAlone"
        Me.ProblemStayingAloneDataGridViewTextBoxColumn.Name = "ProblemStayingAloneDataGridViewTextBoxColumn"
        Me.ProblemStayingAloneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SocialzingProblemsDataGridViewTextBoxColumn
        '
        Me.SocialzingProblemsDataGridViewTextBoxColumn.DataPropertyName = "SocialzingProblems"
        Me.SocialzingProblemsDataGridViewTextBoxColumn.HeaderText = "SocialzingProblems"
        Me.SocialzingProblemsDataGridViewTextBoxColumn.Name = "SocialzingProblemsDataGridViewTextBoxColumn"
        Me.SocialzingProblemsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InsuredByDataGridViewTextBoxColumn
        '
        Me.InsuredByDataGridViewTextBoxColumn.DataPropertyName = "InsuredBy"
        Me.InsuredByDataGridViewTextBoxColumn.HeaderText = "InsuredBy"
        Me.InsuredByDataGridViewTextBoxColumn.Name = "InsuredByDataGridViewTextBoxColumn"
        Me.InsuredByDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MedicalBindingSource
        '
        Me.MedicalBindingSource.DataMember = "medical"
        Me.MedicalBindingSource.DataSource = Me.Applicants1DataSet4
        '
        'Applicants1DataSet4
        '
        Me.Applicants1DataSet4.DataSetName = "applicants1DataSet4"
        Me.Applicants1DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MedicalTableAdapter
        '
        Me.MedicalTableAdapter.ClearBeforeFill = True
        '
        'subbadd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font

        Me.ClientSize = New System.Drawing.Size(1074, 437)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dd)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1090, 476)
        Me.MinimumSize = New System.Drawing.Size(1090, 476)
        Me.Name = "subbadd"
        Me.Text = "subbadd"
        CType(Me.dd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApplicantsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Applicants1DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Applicants1DataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dd As System.Windows.Forms.DataGridView
    Friend WithEvents Applicants1DataSet3 As auce_gym.applicants1DataSet3
    Friend WithEvents ApplicantsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ApplicantsTableAdapter As auce_gym.applicants1DataSet3TableAdapters.applicantsTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MotherNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SchoolUniDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EducationLevelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RelativeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateOfBirthDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneNbDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BloodTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClassDiscountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmergencyNbDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Applicants1DataSet4 As auce_gym.applicants1DataSet4
    Friend WithEvents MedicalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MedicalTableAdapter As auce_gym.applicants1DataSet4TableAdapters.medicalTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MedicineUseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LongTermDiseaseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ScareCausesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AllergiesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProblemStayingAloneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SocialzingProblemsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InsuredByDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
