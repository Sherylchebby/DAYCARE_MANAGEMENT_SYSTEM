<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btncontinue = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.cborelationship = New System.Windows.Forms.ComboBox()
        Me.EnrollmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DaycareDB1DataSet = New DAYCARE_MANAGEMENT_SYSTEM.DaycareDB1DataSet()
        Me.lblactivities = New System.Windows.Forms.Label()
        Me.chkactivities = New System.Windows.Forms.CheckedListBox()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.btnpreviious = New System.Windows.Forms.Button()
        Me.txtemergency = New System.Windows.Forms.TextBox()
        Me.txtcontact = New System.Windows.Forms.TextBox()
        Me.txtguardian = New System.Windows.Forms.TextBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txtchild = New System.Windows.Forms.TextBox()
        Me.cbogender = New System.Windows.Forms.ComboBox()
        Me.cbooption = New System.Windows.Forms.ComboBox()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.lblemergency = New System.Windows.Forms.Label()
        Me.lbloption = New System.Windows.Forms.Label()
        Me.lblcontact = New System.Windows.Forms.Label()
        Me.lblrelationship = New System.Windows.Forms.Label()
        Me.lblguardian = New System.Windows.Forms.Label()
        Me.lbladdress = New System.Windows.Forms.Label()
        Me.lblgender = New System.Windows.Forms.Label()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.lblchild = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.EnrollmentTableAdapter = New DAYCARE_MANAGEMENT_SYSTEM.DaycareDB1DataSetTableAdapters.EnrollmentTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChildsFullNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GuardianNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GuardianRelationshipDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GuardianContactDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnrollmentOptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmergencyContactDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.EnrollmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DaycareDB1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(229, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 18)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "ENROLLMENT FORM"
        '
        'btncontinue
        '
        Me.btncontinue.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btncontinue.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncontinue.ForeColor = System.Drawing.Color.White
        Me.btncontinue.Location = New System.Drawing.Point(672, 342)
        Me.btncontinue.Name = "btncontinue"
        Me.btncontinue.Size = New System.Drawing.Size(88, 23)
        Me.btncontinue.TabIndex = 58
        Me.btncontinue.Text = "Continue"
        Me.btncontinue.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btndelete.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.Color.White
        Me.btndelete.Location = New System.Drawing.Point(672, 300)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 23)
        Me.btndelete.TabIndex = 57
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'cborelationship
        '
        Me.cborelationship.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentBindingSource, "Guardian Relationship", True))
        Me.cborelationship.FormattingEnabled = True
        Me.cborelationship.Items.AddRange(New Object() {"Father", "Mother", "Guardian"})
        Me.cborelationship.Location = New System.Drawing.Point(222, 300)
        Me.cborelationship.Name = "cborelationship"
        Me.cborelationship.Size = New System.Drawing.Size(200, 21)
        Me.cborelationship.TabIndex = 56
        '
        'EnrollmentBindingSource
        '
        Me.EnrollmentBindingSource.DataMember = "Enrollment"
        Me.EnrollmentBindingSource.DataSource = Me.DaycareDB1DataSet
        '
        'DaycareDB1DataSet
        '
        Me.DaycareDB1DataSet.DataSetName = "DaycareDB1DataSet"
        Me.DaycareDB1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblactivities
        '
        Me.lblactivities.AutoSize = True
        Me.lblactivities.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblactivities.Location = New System.Drawing.Point(539, 117)
        Me.lblactivities.Name = "lblactivities"
        Me.lblactivities.Size = New System.Drawing.Size(64, 15)
        Me.lblactivities.TabIndex = 55
        Me.lblactivities.Text = "Activities"
        '
        'chkactivities
        '
        Me.chkactivities.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkactivities.FormattingEnabled = True
        Me.chkactivities.Items.AddRange(New Object() {"Swimming", "Dancing", "Ball Games", "Building Blocks", "Matching games", "Texture playing"})
        Me.chkactivities.Location = New System.Drawing.Point(516, 144)
        Me.chkactivities.Name = "chkactivities"
        Me.chkactivities.Size = New System.Drawing.Size(150, 94)
        Me.chkactivities.TabIndex = 54
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnsave.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Location = New System.Drawing.Point(672, 252)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 53
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnadd.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.ForeColor = System.Drawing.Color.White
        Me.btnadd.Location = New System.Drawing.Point(672, 202)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 23)
        Me.btnadd.TabIndex = 52
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'btnnext
        '
        Me.btnnext.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnnext.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnext.ForeColor = System.Drawing.Color.White
        Me.btnnext.Location = New System.Drawing.Point(672, 159)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(75, 23)
        Me.btnnext.TabIndex = 51
        Me.btnnext.Text = "Next"
        Me.btnnext.UseVisualStyleBackColor = False
        '
        'btnpreviious
        '
        Me.btnpreviious.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnpreviious.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpreviious.ForeColor = System.Drawing.Color.White
        Me.btnpreviious.Location = New System.Drawing.Point(672, 109)
        Me.btnpreviious.Name = "btnpreviious"
        Me.btnpreviious.Size = New System.Drawing.Size(75, 23)
        Me.btnpreviious.TabIndex = 50
        Me.btnpreviious.Text = "Previous"
        Me.btnpreviious.UseVisualStyleBackColor = False
        '
        'txtemergency
        '
        Me.txtemergency.BackColor = System.Drawing.Color.White
        Me.txtemergency.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentBindingSource, "Enrollment Option", True))
        Me.txtemergency.Location = New System.Drawing.Point(222, 397)
        Me.txtemergency.Name = "txtemergency"
        Me.txtemergency.Size = New System.Drawing.Size(200, 20)
        Me.txtemergency.TabIndex = 49
        '
        'txtcontact
        '
        Me.txtcontact.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentBindingSource, "Guardian Contact", True))
        Me.txtcontact.Location = New System.Drawing.Point(222, 330)
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Size = New System.Drawing.Size(200, 20)
        Me.txtcontact.TabIndex = 48
        '
        'txtguardian
        '
        Me.txtguardian.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentBindingSource, "Guardian Name", True))
        Me.txtguardian.Location = New System.Drawing.Point(222, 267)
        Me.txtguardian.Name = "txtguardian"
        Me.txtguardian.Size = New System.Drawing.Size(200, 20)
        Me.txtguardian.TabIndex = 47
        '
        'txtaddress
        '
        Me.txtaddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentBindingSource, "Gender", True))
        Me.txtaddress.Location = New System.Drawing.Point(222, 235)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(200, 20)
        Me.txtaddress.TabIndex = 46
        '
        'txtchild
        '
        Me.txtchild.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentBindingSource, "Child's Full Name", True))
        Me.txtchild.Location = New System.Drawing.Point(222, 134)
        Me.txtchild.Name = "txtchild"
        Me.txtchild.Size = New System.Drawing.Size(200, 20)
        Me.txtchild.TabIndex = 45
        '
        'cbogender
        '
        Me.cbogender.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentBindingSource, "Gender", True))
        Me.cbogender.FormattingEnabled = True
        Me.cbogender.Items.AddRange(New Object() {"Female", "Male"})
        Me.cbogender.Location = New System.Drawing.Point(222, 201)
        Me.cbogender.Name = "cbogender"
        Me.cbogender.Size = New System.Drawing.Size(200, 21)
        Me.cbogender.TabIndex = 44
        '
        'cbooption
        '
        Me.cbooption.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentBindingSource, "Enrollment Option", True))
        Me.cbooption.FormattingEnabled = True
        Me.cbooption.Items.AddRange(New Object() {"Full-time", "Part-time"})
        Me.cbooption.Location = New System.Drawing.Point(222, 362)
        Me.cbooption.Name = "cbooption"
        Me.cbooption.Size = New System.Drawing.Size(200, 21)
        Me.cbooption.TabIndex = 43
        '
        'dtpDOB
        '
        Me.dtpDOB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnrollmentBindingSource, "DOB", True))
        Me.dtpDOB.Location = New System.Drawing.Point(222, 171)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(200, 20)
        Me.dtpDOB.TabIndex = 42
        '
        'lblemergency
        '
        Me.lblemergency.AutoSize = True
        Me.lblemergency.BackColor = System.Drawing.Color.PapayaWhip
        Me.lblemergency.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemergency.Location = New System.Drawing.Point(40, 397)
        Me.lblemergency.Name = "lblemergency"
        Me.lblemergency.Size = New System.Drawing.Size(130, 15)
        Me.lblemergency.TabIndex = 41
        Me.lblemergency.Text = "Emergency Contact"
        '
        'lbloption
        '
        Me.lbloption.AutoSize = True
        Me.lbloption.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbloption.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbloption.Location = New System.Drawing.Point(40, 362)
        Me.lbloption.Name = "lbloption"
        Me.lbloption.Size = New System.Drawing.Size(121, 15)
        Me.lbloption.TabIndex = 40
        Me.lbloption.Text = "Enrollment Option"
        '
        'lblcontact
        '
        Me.lblcontact.AutoSize = True
        Me.lblcontact.BackColor = System.Drawing.Color.PapayaWhip
        Me.lblcontact.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcontact.Location = New System.Drawing.Point(40, 330)
        Me.lblcontact.Name = "lblcontact"
        Me.lblcontact.Size = New System.Drawing.Size(116, 15)
        Me.lblcontact.TabIndex = 39
        Me.lblcontact.Text = "Guardian Contact"
        '
        'lblrelationship
        '
        Me.lblrelationship.AutoSize = True
        Me.lblrelationship.BackColor = System.Drawing.Color.PapayaWhip
        Me.lblrelationship.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrelationship.Location = New System.Drawing.Point(40, 300)
        Me.lblrelationship.Name = "lblrelationship"
        Me.lblrelationship.Size = New System.Drawing.Size(144, 15)
        Me.lblrelationship.TabIndex = 38
        Me.lblrelationship.Text = "Guardian Relationship"
        '
        'lblguardian
        '
        Me.lblguardian.AutoSize = True
        Me.lblguardian.BackColor = System.Drawing.Color.PapayaWhip
        Me.lblguardian.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblguardian.Location = New System.Drawing.Point(40, 267)
        Me.lblguardian.Name = "lblguardian"
        Me.lblguardian.Size = New System.Drawing.Size(101, 15)
        Me.lblguardian.TabIndex = 37
        Me.lblguardian.Text = "Guardian Name"
        '
        'lbladdress
        '
        Me.lbladdress.AutoSize = True
        Me.lbladdress.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbladdress.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladdress.Location = New System.Drawing.Point(40, 235)
        Me.lbladdress.Name = "lbladdress"
        Me.lbladdress.Size = New System.Drawing.Size(63, 15)
        Me.lbladdress.TabIndex = 36
        Me.lbladdress.Text = "Address "
        '
        'lblgender
        '
        Me.lblgender.AutoSize = True
        Me.lblgender.BackColor = System.Drawing.Color.PapayaWhip
        Me.lblgender.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgender.Location = New System.Drawing.Point(40, 201)
        Me.lblgender.Name = "lblgender"
        Me.lblgender.Size = New System.Drawing.Size(53, 15)
        Me.lblgender.TabIndex = 35
        Me.lblgender.Text = "Gender"
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.BackColor = System.Drawing.Color.PapayaWhip
        Me.lblDOB.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDOB.Location = New System.Drawing.Point(40, 171)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(35, 15)
        Me.lblDOB.TabIndex = 34
        Me.lblDOB.Text = "DOB"
        '
        'lblchild
        '
        Me.lblchild.AutoSize = True
        Me.lblchild.BackColor = System.Drawing.Color.PapayaWhip
        Me.lblchild.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblchild.Location = New System.Drawing.Point(40, 134)
        Me.lblchild.Name = "lblchild"
        Me.lblchild.Size = New System.Drawing.Size(111, 15)
        Me.lblchild.TabIndex = 33
        Me.lblchild.Text = "Child's Full Name"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbltitle)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(811, 72)
        Me.Panel1.TabIndex = 60
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbltitle.Font = New System.Drawing.Font("Jokerman", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.Location = New System.Drawing.Point(236, 3)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(263, 70)
        Me.lbltitle.TabIndex = 28
        Me.lbltitle.Text = "WeeCare"
        '
        'EnrollmentTableAdapter
        '
        Me.EnrollmentTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.ChildsFullNameDataGridViewTextBoxColumn, Me.DOBDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.GuardianNameDataGridViewTextBoxColumn, Me.GuardianRelationshipDataGridViewTextBoxColumn, Me.GuardianContactDataGridViewTextBoxColumn, Me.EnrollmentOptionDataGridViewTextBoxColumn, Me.EmergencyContactDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EnrollmentBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(29, 342)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(759, 118)
        Me.DataGridView1.TabIndex = 61
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
        'DOBDataGridViewTextBoxColumn
        '
        Me.DOBDataGridViewTextBoxColumn.DataPropertyName = "DOB"
        Me.DOBDataGridViewTextBoxColumn.HeaderText = "DOB"
        Me.DOBDataGridViewTextBoxColumn.Name = "DOBDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'GuardianNameDataGridViewTextBoxColumn
        '
        Me.GuardianNameDataGridViewTextBoxColumn.DataPropertyName = "Guardian Name"
        Me.GuardianNameDataGridViewTextBoxColumn.HeaderText = "Guardian Name"
        Me.GuardianNameDataGridViewTextBoxColumn.Name = "GuardianNameDataGridViewTextBoxColumn"
        '
        'GuardianRelationshipDataGridViewTextBoxColumn
        '
        Me.GuardianRelationshipDataGridViewTextBoxColumn.DataPropertyName = "Guardian Relationship"
        Me.GuardianRelationshipDataGridViewTextBoxColumn.HeaderText = "Guardian Relationship"
        Me.GuardianRelationshipDataGridViewTextBoxColumn.Name = "GuardianRelationshipDataGridViewTextBoxColumn"
        '
        'GuardianContactDataGridViewTextBoxColumn
        '
        Me.GuardianContactDataGridViewTextBoxColumn.DataPropertyName = "Guardian Contact"
        Me.GuardianContactDataGridViewTextBoxColumn.HeaderText = "Guardian Contact"
        Me.GuardianContactDataGridViewTextBoxColumn.Name = "GuardianContactDataGridViewTextBoxColumn"
        '
        'EnrollmentOptionDataGridViewTextBoxColumn
        '
        Me.EnrollmentOptionDataGridViewTextBoxColumn.DataPropertyName = "Enrollment Option"
        Me.EnrollmentOptionDataGridViewTextBoxColumn.HeaderText = "Enrollment Option"
        Me.EnrollmentOptionDataGridViewTextBoxColumn.Name = "EnrollmentOptionDataGridViewTextBoxColumn"
        '
        'EmergencyContactDataGridViewTextBoxColumn
        '
        Me.EmergencyContactDataGridViewTextBoxColumn.DataPropertyName = "Emergency Contact"
        Me.EmergencyContactDataGridViewTextBoxColumn.HeaderText = "Emergency Contact"
        Me.EmergencyContactDataGridViewTextBoxColumn.Name = "EmergencyContactDataGridViewTextBoxColumn"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btncontinue)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.cborelationship)
        Me.Controls.Add(Me.lblactivities)
        Me.Controls.Add(Me.chkactivities)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.btnpreviious)
        Me.Controls.Add(Me.txtemergency)
        Me.Controls.Add(Me.txtcontact)
        Me.Controls.Add(Me.txtguardian)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.txtchild)
        Me.Controls.Add(Me.cbogender)
        Me.Controls.Add(Me.cbooption)
        Me.Controls.Add(Me.dtpDOB)
        Me.Controls.Add(Me.lblemergency)
        Me.Controls.Add(Me.lbloption)
        Me.Controls.Add(Me.lblcontact)
        Me.Controls.Add(Me.lblrelationship)
        Me.Controls.Add(Me.lblguardian)
        Me.Controls.Add(Me.lbladdress)
        Me.Controls.Add(Me.lblgender)
        Me.Controls.Add(Me.lblDOB)
        Me.Controls.Add(Me.lblchild)
        Me.Name = "Form3"
        Me.Text = "Enrollment"
        CType(Me.EnrollmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DaycareDB1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btncontinue As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents cborelationship As ComboBox
    Friend WithEvents lblactivities As Label
    Friend WithEvents chkactivities As CheckedListBox
    Friend WithEvents btnsave As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents btnnext As Button
    Friend WithEvents btnpreviious As Button
    Friend WithEvents txtemergency As TextBox
    Friend WithEvents txtcontact As TextBox
    Friend WithEvents txtguardian As TextBox
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents txtchild As TextBox
    Friend WithEvents cbogender As ComboBox
    Friend WithEvents cbooption As ComboBox
    Friend WithEvents dtpDOB As DateTimePicker
    Friend WithEvents lblemergency As Label
    Friend WithEvents lbloption As Label
    Friend WithEvents lblcontact As Label
    Friend WithEvents lblrelationship As Label
    Friend WithEvents lblguardian As Label
    Friend WithEvents lbladdress As Label
    Friend WithEvents lblgender As Label
    Friend WithEvents lblDOB As Label
    Friend WithEvents lblchild As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbltitle As Label
    Friend WithEvents DaycareDB1DataSet As DaycareDB1DataSet
    Friend WithEvents EnrollmentBindingSource As BindingSource
    Friend WithEvents EnrollmentTableAdapter As DaycareDB1DataSetTableAdapters.EnrollmentTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ChildsFullNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DOBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GuardianNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GuardianRelationshipDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GuardianContactDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EnrollmentOptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmergencyContactDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
