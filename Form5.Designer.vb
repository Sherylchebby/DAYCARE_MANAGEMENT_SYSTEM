<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblchildname = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.lblreason = New System.Windows.Forms.Label()
        Me.MedicalAdministrationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DaycareDBDataSet = New DAYCARE_MANAGEMENT_SYSTEM.DaycareDBDataSet()
        Me.lblsymptoms = New System.Windows.Forms.Label()
        Me.lbltemperature = New System.Windows.Forms.Label()
        Me.lblmedication = New System.Windows.Forms.Label()
        Me.lblallergy = New System.Windows.Forms.Label()
        Me.txtchildname = New System.Windows.Forms.TextBox()
        Me.txtreason = New System.Windows.Forms.TextBox()
        Me.txtsymptoms = New System.Windows.Forms.TextBox()
        Me.txttemperature = New System.Windows.Forms.TextBox()
        Me.txtallergy = New System.Windows.Forms.TextBox()
        Me.dtpdate = New System.Windows.Forms.DateTimePicker()
        Me.cbomedication = New System.Windows.Forms.ComboBox()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnhome = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChildsFullNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfVisitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReasonForVisitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SymptomsDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TemperatureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicationAdministeredDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AllergiesReactionsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Medical_AdministrationTableAdapter = New DAYCARE_MANAGEMENT_SYSTEM.DaycareDBDataSetTableAdapters.Medical_AdministrationTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnadd = New System.Windows.Forms.Button()
        CType(Me.MedicalAdministrationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DaycareDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblchildname
        '
        Me.lblchildname.AutoSize = True
        Me.lblchildname.BackColor = System.Drawing.Color.PapayaWhip
        Me.lblchildname.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblchildname.Location = New System.Drawing.Point(92, 137)
        Me.lblchildname.Name = "lblchildname"
        Me.lblchildname.Size = New System.Drawing.Size(111, 15)
        Me.lblchildname.TabIndex = 0
        Me.lblchildname.Text = "Child's Full Name"
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbldate.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(92, 174)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(85, 15)
        Me.lbldate.TabIndex = 1
        Me.lbldate.Text = "Date of Visit"
        '
        'lblreason
        '
        Me.lblreason.AutoSize = True
        Me.lblreason.BackColor = System.Drawing.Color.PapayaWhip
        Me.lblreason.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblreason.Location = New System.Drawing.Point(90, 217)
        Me.lblreason.Name = "lblreason"
        Me.lblreason.Size = New System.Drawing.Size(108, 15)
        Me.lblreason.TabIndex = 2
        Me.lblreason.Text = "Reason for Visit"
        '
        'MedicalAdministrationBindingSource
        '
        Me.MedicalAdministrationBindingSource.DataMember = "Medical_Administration"
        Me.MedicalAdministrationBindingSource.DataSource = Me.DaycareDBDataSet
        '
        'DaycareDBDataSet
        '
        Me.DaycareDBDataSet.DataSetName = "DaycareDBDataSet"
        Me.DaycareDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblsymptoms
        '
        Me.lblsymptoms.AutoSize = True
        Me.lblsymptoms.BackColor = System.Drawing.Color.PapayaWhip
        Me.lblsymptoms.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsymptoms.Location = New System.Drawing.Point(90, 256)
        Me.lblsymptoms.Name = "lblsymptoms"
        Me.lblsymptoms.Size = New System.Drawing.Size(150, 15)
        Me.lblsymptoms.TabIndex = 3
        Me.lblsymptoms.Text = "Symptoms Description"
        '
        'lbltemperature
        '
        Me.lbltemperature.AutoSize = True
        Me.lbltemperature.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbltemperature.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltemperature.Location = New System.Drawing.Point(90, 293)
        Me.lbltemperature.Name = "lbltemperature"
        Me.lbltemperature.Size = New System.Drawing.Size(87, 15)
        Me.lbltemperature.TabIndex = 4
        Me.lbltemperature.Text = "Temperature"
        '
        'lblmedication
        '
        Me.lblmedication.AutoSize = True
        Me.lblmedication.BackColor = System.Drawing.Color.PapayaWhip
        Me.lblmedication.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmedication.Location = New System.Drawing.Point(90, 329)
        Me.lblmedication.Name = "lblmedication"
        Me.lblmedication.Size = New System.Drawing.Size(163, 15)
        Me.lblmedication.TabIndex = 5
        Me.lblmedication.Text = "Medication Administered"
        '
        'lblallergy
        '
        Me.lblallergy.AutoSize = True
        Me.lblallergy.BackColor = System.Drawing.Color.PapayaWhip
        Me.lblallergy.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblallergy.Location = New System.Drawing.Point(90, 368)
        Me.lblallergy.Name = "lblallergy"
        Me.lblallergy.Size = New System.Drawing.Size(123, 15)
        Me.lblallergy.TabIndex = 6
        Me.lblallergy.Text = "Allergies/Reaction"
        '
        'txtchildname
        '
        Me.txtchildname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicalAdministrationBindingSource, "Child's Full Name", True))
        Me.txtchildname.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchildname.Location = New System.Drawing.Point(303, 129)
        Me.txtchildname.Name = "txtchildname"
        Me.txtchildname.Size = New System.Drawing.Size(200, 23)
        Me.txtchildname.TabIndex = 7
        '
        'txtreason
        '
        Me.txtreason.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicalAdministrationBindingSource, "Reason for Visit", True))
        Me.txtreason.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtreason.Location = New System.Drawing.Point(303, 209)
        Me.txtreason.Name = "txtreason"
        Me.txtreason.Size = New System.Drawing.Size(200, 23)
        Me.txtreason.TabIndex = 8
        '
        'txtsymptoms
        '
        Me.txtsymptoms.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicalAdministrationBindingSource, "Symptoms Description", True))
        Me.txtsymptoms.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsymptoms.Location = New System.Drawing.Point(303, 248)
        Me.txtsymptoms.Name = "txtsymptoms"
        Me.txtsymptoms.Size = New System.Drawing.Size(200, 23)
        Me.txtsymptoms.TabIndex = 9
        '
        'txttemperature
        '
        Me.txttemperature.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicalAdministrationBindingSource, "Temperature", True))
        Me.txttemperature.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttemperature.Location = New System.Drawing.Point(303, 283)
        Me.txttemperature.Name = "txttemperature"
        Me.txttemperature.Size = New System.Drawing.Size(200, 23)
        Me.txttemperature.TabIndex = 10
        '
        'txtallergy
        '
        Me.txtallergy.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicalAdministrationBindingSource, "Allergies/Reactions", True))
        Me.txtallergy.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtallergy.Location = New System.Drawing.Point(303, 360)
        Me.txtallergy.Name = "txtallergy"
        Me.txtallergy.Size = New System.Drawing.Size(200, 23)
        Me.txtallergy.TabIndex = 11
        '
        'dtpdate
        '
        Me.dtpdate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicalAdministrationBindingSource, "Date of Visit", True))
        Me.dtpdate.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpdate.Location = New System.Drawing.Point(303, 166)
        Me.dtpdate.Name = "dtpdate"
        Me.dtpdate.Size = New System.Drawing.Size(200, 23)
        Me.dtpdate.TabIndex = 12
        '
        'cbomedication
        '
        Me.cbomedication.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicalAdministrationBindingSource, "Medication Administered", True))
        Me.cbomedication.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbomedication.FormattingEnabled = True
        Me.cbomedication.Location = New System.Drawing.Point(303, 318)
        Me.cbomedication.Name = "cbomedication"
        Me.cbomedication.Size = New System.Drawing.Size(200, 23)
        Me.cbomedication.TabIndex = 13
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnsave.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Location = New System.Drawing.Point(639, 289)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 14
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnhome
        '
        Me.btnhome.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnhome.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhome.ForeColor = System.Drawing.Color.White
        Me.btnhome.Location = New System.Drawing.Point(639, 329)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Size = New System.Drawing.Size(75, 23)
        Me.btnhome.TabIndex = 16
        Me.btnhome.Text = "Home"
        Me.btnhome.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.ChildsFullNameDataGridViewTextBoxColumn, Me.DateOfVisitDataGridViewTextBoxColumn, Me.ReasonForVisitDataGridViewTextBoxColumn, Me.SymptomsDescriptionDataGridViewTextBoxColumn, Me.TemperatureDataGridViewTextBoxColumn, Me.MedicationAdministeredDataGridViewTextBoxColumn, Me.AllergiesReactionsDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MedicalAdministrationBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 386)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(702, 61)
        Me.DataGridView1.TabIndex = 17
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'ChildsFullNameDataGridViewTextBoxColumn
        '
        Me.ChildsFullNameDataGridViewTextBoxColumn.DataPropertyName = "Child's Full Name"
        Me.ChildsFullNameDataGridViewTextBoxColumn.HeaderText = "Child's Full Name"
        Me.ChildsFullNameDataGridViewTextBoxColumn.Name = "ChildsFullNameDataGridViewTextBoxColumn"
        '
        'DateOfVisitDataGridViewTextBoxColumn
        '
        Me.DateOfVisitDataGridViewTextBoxColumn.DataPropertyName = "Date of Visit"
        Me.DateOfVisitDataGridViewTextBoxColumn.HeaderText = "Date of Visit"
        Me.DateOfVisitDataGridViewTextBoxColumn.Name = "DateOfVisitDataGridViewTextBoxColumn"
        '
        'ReasonForVisitDataGridViewTextBoxColumn
        '
        Me.ReasonForVisitDataGridViewTextBoxColumn.DataPropertyName = "Reason for Visit"
        Me.ReasonForVisitDataGridViewTextBoxColumn.HeaderText = "Reason for Visit"
        Me.ReasonForVisitDataGridViewTextBoxColumn.Name = "ReasonForVisitDataGridViewTextBoxColumn"
        '
        'SymptomsDescriptionDataGridViewTextBoxColumn
        '
        Me.SymptomsDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Symptoms Description"
        Me.SymptomsDescriptionDataGridViewTextBoxColumn.HeaderText = "Symptoms Description"
        Me.SymptomsDescriptionDataGridViewTextBoxColumn.Name = "SymptomsDescriptionDataGridViewTextBoxColumn"
        '
        'TemperatureDataGridViewTextBoxColumn
        '
        Me.TemperatureDataGridViewTextBoxColumn.DataPropertyName = "Temperature"
        Me.TemperatureDataGridViewTextBoxColumn.HeaderText = "Temperature"
        Me.TemperatureDataGridViewTextBoxColumn.Name = "TemperatureDataGridViewTextBoxColumn"
        '
        'MedicationAdministeredDataGridViewTextBoxColumn
        '
        Me.MedicationAdministeredDataGridViewTextBoxColumn.DataPropertyName = "Medication Administered"
        Me.MedicationAdministeredDataGridViewTextBoxColumn.HeaderText = "Medication Administered"
        Me.MedicationAdministeredDataGridViewTextBoxColumn.Name = "MedicationAdministeredDataGridViewTextBoxColumn"
        '
        'AllergiesReactionsDataGridViewTextBoxColumn
        '
        Me.AllergiesReactionsDataGridViewTextBoxColumn.DataPropertyName = "Allergies/Reactions"
        Me.AllergiesReactionsDataGridViewTextBoxColumn.HeaderText = "Allergies/Reactions"
        Me.AllergiesReactionsDataGridViewTextBoxColumn.Name = "AllergiesReactionsDataGridViewTextBoxColumn"
        '
        'Medical_AdministrationTableAdapter
        '
        Me.Medical_AdministrationTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbltitle)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(801, 70)
        Me.Panel1.TabIndex = 30
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbltitle.Font = New System.Drawing.Font("Jokerman", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.Location = New System.Drawing.Point(290, -3)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(263, 70)
        Me.lbltitle.TabIndex = 28
        Me.lbltitle.Text = "WeeCare"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(300, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 18)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "MEDICAL ADMINISTRATION"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnadd.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.ForeColor = System.Drawing.Color.White
        Me.btnadd.Location = New System.Drawing.Point(639, 247)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 23)
        Me.btnadd.TabIndex = 32
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnhome)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.cbomedication)
        Me.Controls.Add(Me.dtpdate)
        Me.Controls.Add(Me.txtallergy)
        Me.Controls.Add(Me.txttemperature)
        Me.Controls.Add(Me.txtsymptoms)
        Me.Controls.Add(Me.txtreason)
        Me.Controls.Add(Me.txtchildname)
        Me.Controls.Add(Me.lblallergy)
        Me.Controls.Add(Me.lblmedication)
        Me.Controls.Add(Me.lbltemperature)
        Me.Controls.Add(Me.lblsymptoms)
        Me.Controls.Add(Me.lblreason)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.lblchildname)
        Me.Name = "Form5"
        Me.Text = "Medical_Administration"
        CType(Me.MedicalAdministrationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DaycareDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblchildname As Label
    Friend WithEvents lbldate As Label
    Friend WithEvents lblreason As Label
    Friend WithEvents lblsymptoms As Label
    Friend WithEvents lbltemperature As Label
    Friend WithEvents lblmedication As Label
    Friend WithEvents lblallergy As Label
    Friend WithEvents txtchildname As TextBox
    Friend WithEvents txtreason As TextBox
    Friend WithEvents txtsymptoms As TextBox
    Friend WithEvents txttemperature As TextBox
    Friend WithEvents txtallergy As TextBox
    Friend WithEvents dtpdate As DateTimePicker
    Friend WithEvents cbomedication As ComboBox
    Friend WithEvents btnsave As Button
    Friend WithEvents btnhome As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DaycareDBDataSet As DaycareDBDataSet
    Friend WithEvents MedicalAdministrationBindingSource As BindingSource
    Friend WithEvents Medical_AdministrationTableAdapter As DaycareDBDataSetTableAdapters.Medical_AdministrationTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ChildsFullNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateOfVisitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReasonForVisitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SymptomsDescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TemperatureDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedicationAdministeredDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AllergiesReactionsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbltitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnadd As Button
End Class
