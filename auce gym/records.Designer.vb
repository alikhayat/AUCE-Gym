<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class records
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(records))
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
        Me.InsuranceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FromDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TillDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateSubscribedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecieptNbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountPaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApplicantIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActiveRegBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ActiveregDataSet1 = New auce_gym.activeregDataSet1()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ActiveRegTableAdapter = New auce_gym.activeregDataSet1TableAdapters.ActiveRegTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActiveRegBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActiveregDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.MotherNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.SchoolUniDataGridViewTextBoxColumn, Me.EducationLevelDataGridViewTextBoxColumn, Me.RelativeDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.DateOfBirthDataGridViewTextBoxColumn, Me.PhoneNbDataGridViewTextBoxColumn, Me.BloodTypeDataGridViewTextBoxColumn, Me.ClassDiscountDataGridViewTextBoxColumn, Me.EmergencyNbDataGridViewTextBoxColumn, Me.InsuranceDataGridViewTextBoxColumn, Me.FromDataGridViewTextBoxColumn, Me.TillDataGridViewTextBoxColumn, Me.DateSubscribedDataGridViewTextBoxColumn, Me.ClassDataGridViewTextBoxColumn, Me.RecieptNbDataGridViewTextBoxColumn, Me.AmountPaidDataGridViewTextBoxColumn, Me.ValidDataGridViewTextBoxColumn, Me.ApplicantIdDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ActiveRegBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1068, 336)
        Me.DataGridView1.TabIndex = 0
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
        'InsuranceDataGridViewTextBoxColumn
        '
        Me.InsuranceDataGridViewTextBoxColumn.DataPropertyName = "Insurance"
        Me.InsuranceDataGridViewTextBoxColumn.HeaderText = "Insurance"
        Me.InsuranceDataGridViewTextBoxColumn.Name = "InsuranceDataGridViewTextBoxColumn"
        Me.InsuranceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FromDataGridViewTextBoxColumn
        '
        Me.FromDataGridViewTextBoxColumn.DataPropertyName = "From"
        Me.FromDataGridViewTextBoxColumn.HeaderText = "From"
        Me.FromDataGridViewTextBoxColumn.Name = "FromDataGridViewTextBoxColumn"
        Me.FromDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TillDataGridViewTextBoxColumn
        '
        Me.TillDataGridViewTextBoxColumn.DataPropertyName = "Till"
        Me.TillDataGridViewTextBoxColumn.HeaderText = "Till"
        Me.TillDataGridViewTextBoxColumn.Name = "TillDataGridViewTextBoxColumn"
        Me.TillDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateSubscribedDataGridViewTextBoxColumn
        '
        Me.DateSubscribedDataGridViewTextBoxColumn.DataPropertyName = "DateSubscribed"
        Me.DateSubscribedDataGridViewTextBoxColumn.HeaderText = "DateSubscribed"
        Me.DateSubscribedDataGridViewTextBoxColumn.Name = "DateSubscribedDataGridViewTextBoxColumn"
        Me.DateSubscribedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClassDataGridViewTextBoxColumn
        '
        Me.ClassDataGridViewTextBoxColumn.DataPropertyName = "Class"
        Me.ClassDataGridViewTextBoxColumn.HeaderText = "Class"
        Me.ClassDataGridViewTextBoxColumn.Name = "ClassDataGridViewTextBoxColumn"
        Me.ClassDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RecieptNbDataGridViewTextBoxColumn
        '
        Me.RecieptNbDataGridViewTextBoxColumn.DataPropertyName = "RecieptNb"
        Me.RecieptNbDataGridViewTextBoxColumn.HeaderText = "RecieptNb"
        Me.RecieptNbDataGridViewTextBoxColumn.Name = "RecieptNbDataGridViewTextBoxColumn"
        Me.RecieptNbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AmountPaidDataGridViewTextBoxColumn
        '
        Me.AmountPaidDataGridViewTextBoxColumn.DataPropertyName = "AmountPaid"
        Me.AmountPaidDataGridViewTextBoxColumn.HeaderText = "AmountPaid"
        Me.AmountPaidDataGridViewTextBoxColumn.Name = "AmountPaidDataGridViewTextBoxColumn"
        Me.AmountPaidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ValidDataGridViewTextBoxColumn
        '
        Me.ValidDataGridViewTextBoxColumn.DataPropertyName = "Valid"
        Me.ValidDataGridViewTextBoxColumn.HeaderText = "Valid"
        Me.ValidDataGridViewTextBoxColumn.Name = "ValidDataGridViewTextBoxColumn"
        Me.ValidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ApplicantIdDataGridViewTextBoxColumn
        '
        Me.ApplicantIdDataGridViewTextBoxColumn.DataPropertyName = "ApplicantId"
        Me.ApplicantIdDataGridViewTextBoxColumn.HeaderText = "ApplicantId"
        Me.ApplicantIdDataGridViewTextBoxColumn.Name = "ApplicantIdDataGridViewTextBoxColumn"
        Me.ApplicantIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ActiveRegBindingSource
        '
        Me.ActiveRegBindingSource.DataMember = "ActiveReg"
        Me.ActiveRegBindingSource.DataSource = Me.ActiveregDataSet1
        '
        'ActiveregDataSet1
        '
        Me.ActiveregDataSet1.DataSetName = "activeregDataSet1"
        Me.ActiveregDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 382)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "- Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(195, 382)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "- Last name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(387, 382)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "- Class :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(554, 382)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "- Valid :"
        '
        'ActiveRegTableAdapter
        '
        Me.ActiveRegTableAdapter.ClearBeforeFill = True
        '
        'records
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font

        Me.ClientSize = New System.Drawing.Size(1068, 510)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1084, 549)
        Me.MinimumSize = New System.Drawing.Size(1084, 549)
        Me.Name = "records"
        Me.Text = "records"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActiveRegBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActiveregDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ActiveregDataSet1 As auce_gym.activeregDataSet1
    Friend WithEvents ActiveRegBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ActiveRegTableAdapter As auce_gym.activeregDataSet1TableAdapters.ActiveRegTableAdapter
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
    Friend WithEvents InsuranceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FromDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TillDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateSubscribedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClassDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RecieptNbDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountPaidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApplicantIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
