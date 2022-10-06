<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editapplicants
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(editapplicants))
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
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
        Me.Applicants1DataSet1 = New auce_gym.applicants1DataSet1()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicineUseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LongTermDiseaseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScareCausesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AllergiesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProblemStayingAloneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SocialzingProblemsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InsuredByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Applicants1DataSet2 = New auce_gym.applicants1DataSet2()
        Me.ApplicantsTableAdapter = New auce_gym.applicants1DataSet1TableAdapters.applicantsTableAdapter()
        Me.MedicalTableAdapter = New auce_gym.applicants1DataSet2TableAdapters.medicalTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApplicantsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Applicants1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Applicants1DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(67, 433)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(100, 20)
        Me.TextBox9.TabIndex = 33
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(126, 404)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(100, 20)
        Me.TextBox8.TabIndex = 32
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(94, 375)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 31
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 431)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 20)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "- ID :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 402)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(108, 20)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "- last name :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 373)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 20)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "- Name :"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.MotherNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.SchoolUniDataGridViewTextBoxColumn, Me.EducationLevelDataGridViewTextBoxColumn, Me.RelativeDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.DateOfBirthDataGridViewTextBoxColumn, Me.PhoneNbDataGridViewTextBoxColumn, Me.BloodTypeDataGridViewTextBoxColumn, Me.ClassDiscountDataGridViewTextBoxColumn, Me.EmergencyNbDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ApplicantsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1063, 353)
        Me.DataGridView1.TabIndex = 34
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
        Me.ApplicantsBindingSource.DataSource = Me.Applicants1DataSet1
        '
        'Applicants1DataSet1
        '
        Me.Applicants1DataSet1.DataSetName = "applicants1DataSet1"
        Me.Applicants1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.MedicineUseDataGridViewTextBoxColumn, Me.LongTermDiseaseDataGridViewTextBoxColumn, Me.ScareCausesDataGridViewTextBoxColumn, Me.AllergiesDataGridViewTextBoxColumn, Me.ProblemStayingAloneDataGridViewTextBoxColumn, Me.SocialzingProblemsDataGridViewTextBoxColumn, Me.InsuredByDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.MedicalBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(440, 362)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(326, 150)
        Me.DataGridView2.TabIndex = 38
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
        Me.MedicalBindingSource.DataSource = Me.Applicants1DataSet2
        '
        'Applicants1DataSet2
        '
        Me.Applicants1DataSet2.DataSetName = "applicants1DataSet2"
        Me.Applicants1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ApplicantsTableAdapter
        '
        Me.ApplicantsTableAdapter.ClearBeforeFill = True
        '
        'MedicalTableAdapter
        '
        Me.MedicalTableAdapter.ClearBeforeFill = True
        '
        'editapplicants
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font

        Me.ClientSize = New System.Drawing.Size(1087, 461)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1103, 500)
        Me.MinimumSize = New System.Drawing.Size(1103, 500)
        Me.Name = "editapplicants"
        Me.Text = "editapplicants"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApplicantsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Applicants1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Applicants1DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Applicants1DataSet1 As auce_gym.applicants1DataSet1
    Friend WithEvents ApplicantsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ApplicantsTableAdapter As auce_gym.applicants1DataSet1TableAdapters.applicantsTableAdapter
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
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Applicants1DataSet2 As auce_gym.applicants1DataSet2
    Friend WithEvents MedicalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MedicalTableAdapter As auce_gym.applicants1DataSet2TableAdapters.medicalTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MedicineUseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LongTermDiseaseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ScareCausesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AllergiesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProblemStayingAloneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SocialzingProblemsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InsuredByDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
