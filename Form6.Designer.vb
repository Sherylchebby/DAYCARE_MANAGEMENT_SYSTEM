<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form6
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
        Me.lblparent = New System.Windows.Forms.Label()
        Me.lblpickupperson = New System.Windows.Forms.Label()
        Me.lblrelationship = New System.Windows.Forms.Label()
        Me.lblphone = New System.Windows.Forms.Label()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.txtchildname = New System.Windows.Forms.TextBox()
        Me.PickupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DaycareDBDataSet = New DAYCARE_MANAGEMENT_SYSTEM.DaycareDBDataSet()
        Me.txtparent = New System.Windows.Forms.TextBox()
        Me.txtpickupperson = New System.Windows.Forms.TextBox()
        Me.txtphone = New System.Windows.Forms.TextBox()
        Me.cborelationship = New System.Windows.Forms.ComboBox()
        Me.btnprevious = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnhome = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChildsFullNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ParentGuardianNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuthorizedPickupPersonNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RelationshipDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeOfPickupDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.lblpickupform = New System.Windows.Forms.Label()
        Me.Pick_upTableAdapter = New DAYCARE_MANAGEMENT_SYSTEM.DaycareDBDataSetTableAdapters.Pick_upTableAdapter()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.PickupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblchildname.Location = New System.Drawing.Point(106, 163)
        Me.lblchildname.Name = "lblchildname"
        Me.lblchildname.Size = New System.Drawing.Size(111, 15)
        Me.lblchildname.TabIndex = 0
        Me.lblchildname.Text = "Child's Full Name"
        '
        'lblparent
        '
        Me.lblparent.AutoSize = True
        Me.lblparent.BackColor = System.Drawing.Color.PapayaWhip
        Me.lblparent.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblparent.Location = New System.Drawing.Point(106, 206)
        Me.lblparent.Name = "lblparent"
        Me.lblparent.Size = New System.Drawing.Size(147, 15)
        Me.lblparent.TabIndex = 1
        Me.lblparent.Text = "Parent/Guardian Name"
        '
        'lblpickupperson
        '
        Me.lblpickupperson.AutoSize = True
        Me.lblpickupperson.BackColor = System.Drawing.Color.PapayaWhip
        Me.lblpickupperson.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpickupperson.Location = New System.Drawing.Point(106, 247)
        Me.lblpickupperson.Name = "lblpickupperson"
        Me.lblpickupperson.Size = New System.Drawing.Size(177, 15)
        Me.lblpickupperson.TabIndex = 2
        Me.lblpickupperson.Text = "Authorized pick-up person"
        '
        'lblrelationship
        '
        Me.lblrelationship.AutoSize = True
        Me.lblrelationship.BackColor = System.Drawing.Color.PapayaWhip
        Me.lblrelationship.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrelationship.Location = New System.Drawing.Point(106, 288)
        Me.lblrelationship.Name = "lblrelationship"
        Me.lblrelationship.Size = New System.Drawing.Size(85, 15)
        Me.lblrelationship.TabIndex = 3
        Me.lblrelationship.Text = "Relationship"
        '
        'lblphone
        '
        Me.lblphone.AutoSize = True
        Me.lblphone.BackColor = System.Drawing.Color.PapayaWhip
        Me.lblphone.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblphone.Location = New System.Drawing.Point(108, 327)
        Me.lblphone.Name = "lblphone"
        Me.lblphone.Size = New System.Drawing.Size(100, 15)
        Me.lblphone.TabIndex = 4
        Me.lblphone.Text = "Phone Number"
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbltime.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.Location = New System.Drawing.Point(106, 362)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(102, 15)
        Me.lbltime.TabIndex = 5
        Me.lbltime.Text = "Time of Pick-up"
        '
        'txtchildname
        '
        Me.txtchildname.BackColor = System.Drawing.Color.White
        Me.txtchildname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PickupBindingSource, "Child's Full Name", True))
        Me.txtchildname.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchildname.Location = New System.Drawing.Point(297, 163)
        Me.txtchildname.Name = "txtchildname"
        Me.txtchildname.Size = New System.Drawing.Size(200, 23)
        Me.txtchildname.TabIndex = 7
        '
        'PickupBindingSource
        '
        Me.PickupBindingSource.DataMember = "Pick-up"
        Me.PickupBindingSource.DataSource = Me.DaycareDBDataSet
        '
        'DaycareDBDataSet
        '
        Me.DaycareDBDataSet.DataSetName = "DaycareDBDataSet"
        Me.DaycareDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtparent
        '
        Me.txtparent.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PickupBindingSource, "Parent/Guardian Name", True))
        Me.txtparent.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtparent.Location = New System.Drawing.Point(297, 206)
        Me.txtparent.Name = "txtparent"
        Me.txtparent.Size = New System.Drawing.Size(200, 23)
        Me.txtparent.TabIndex = 8
        '
        'txtpickupperson
        '
        Me.txtpickupperson.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PickupBindingSource, "Authorized Pick-up person Name", True))
        Me.txtpickupperson.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpickupperson.Location = New System.Drawing.Point(297, 247)
        Me.txtpickupperson.Name = "txtpickupperson"
        Me.txtpickupperson.Size = New System.Drawing.Size(200, 23)
        Me.txtpickupperson.TabIndex = 9
        '
        'txtphone
        '
        Me.txtphone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PickupBindingSource, "Phone Number", True))
        Me.txtphone.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtphone.Location = New System.Drawing.Point(297, 327)
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Size = New System.Drawing.Size(200, 23)
        Me.txtphone.TabIndex = 10
        '
        'cborelationship
        '
        Me.cborelationship.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PickupBindingSource, "Relationship", True))
        Me.cborelationship.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cborelationship.FormattingEnabled = True
        Me.cborelationship.Items.AddRange(New Object() {"Father", "Mother", "Guardian"})
        Me.cborelationship.Location = New System.Drawing.Point(297, 288)
        Me.cborelationship.Name = "cborelationship"
        Me.cborelationship.Size = New System.Drawing.Size(200, 23)
        Me.cborelationship.TabIndex = 12
        '
        'btnprevious
        '
        Me.btnprevious.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnprevious.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprevious.ForeColor = System.Drawing.Color.White
        Me.btnprevious.Location = New System.Drawing.Point(622, 163)
        Me.btnprevious.Name = "btnprevious"
        Me.btnprevious.Size = New System.Drawing.Size(75, 23)
        Me.btnprevious.TabIndex = 13
        Me.btnprevious.Text = "Previous"
        Me.btnprevious.UseVisualStyleBackColor = False
        '
        'btnnext
        '
        Me.btnnext.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnnext.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnext.ForeColor = System.Drawing.Color.White
        Me.btnnext.Location = New System.Drawing.Point(622, 216)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(75, 23)
        Me.btnnext.TabIndex = 14
        Me.btnnext.Text = "Next"
        Me.btnnext.UseVisualStyleBackColor = False
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnadd.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.ForeColor = System.Drawing.Color.White
        Me.btnadd.Location = New System.Drawing.Point(622, 262)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 23)
        Me.btnadd.TabIndex = 15
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnsave.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Location = New System.Drawing.Point(622, 309)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 16
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnhome
        '
        Me.btnhome.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnhome.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhome.ForeColor = System.Drawing.Color.White
        Me.btnhome.Location = New System.Drawing.Point(622, 358)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Size = New System.Drawing.Size(75, 23)
        Me.btnhome.TabIndex = 17
        Me.btnhome.Text = "Home"
        Me.btnhome.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.ChildsFullNameDataGridViewTextBoxColumn, Me.ParentGuardianNameDataGridViewTextBoxColumn, Me.AuthorizedPickupPersonNameDataGridViewTextBoxColumn, Me.RelationshipDataGridViewTextBoxColumn, Me.PhoneNumberDataGridViewTextBoxColumn, Me.TimeOfPickupDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PickupBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(33, 388)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(673, 62)
        Me.DataGridView1.TabIndex = 18
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
        'ParentGuardianNameDataGridViewTextBoxColumn
        '
        Me.ParentGuardianNameDataGridViewTextBoxColumn.DataPropertyName = "Parent/Guardian Name"
        Me.ParentGuardianNameDataGridViewTextBoxColumn.HeaderText = "Parent/Guardian Name"
        Me.ParentGuardianNameDataGridViewTextBoxColumn.Name = "ParentGuardianNameDataGridViewTextBoxColumn"
        '
        'AuthorizedPickupPersonNameDataGridViewTextBoxColumn
        '
        Me.AuthorizedPickupPersonNameDataGridViewTextBoxColumn.DataPropertyName = "Authorized Pick-up person Name"
        Me.AuthorizedPickupPersonNameDataGridViewTextBoxColumn.HeaderText = "Authorized Pick-up person Name"
        Me.AuthorizedPickupPersonNameDataGridViewTextBoxColumn.Name = "AuthorizedPickupPersonNameDataGridViewTextBoxColumn"
        '
        'RelationshipDataGridViewTextBoxColumn
        '
        Me.RelationshipDataGridViewTextBoxColumn.DataPropertyName = "Relationship"
        Me.RelationshipDataGridViewTextBoxColumn.HeaderText = "Relationship"
        Me.RelationshipDataGridViewTextBoxColumn.Name = "RelationshipDataGridViewTextBoxColumn"
        '
        'PhoneNumberDataGridViewTextBoxColumn
        '
        Me.PhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Phone Number"
        Me.PhoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone Number"
        Me.PhoneNumberDataGridViewTextBoxColumn.Name = "PhoneNumberDataGridViewTextBoxColumn"
        '
        'TimeOfPickupDataGridViewTextBoxColumn
        '
        Me.TimeOfPickupDataGridViewTextBoxColumn.DataPropertyName = "Time of Pick-up"
        Me.TimeOfPickupDataGridViewTextBoxColumn.HeaderText = "Time of Pick-up"
        Me.TimeOfPickupDataGridViewTextBoxColumn.Name = "TimeOfPickupDataGridViewTextBoxColumn"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbltitle)
        Me.Panel1.Location = New System.Drawing.Point(-2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(805, 82)
        Me.Panel1.TabIndex = 30
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbltitle.Font = New System.Drawing.Font("Jokerman", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.Location = New System.Drawing.Point(300, 9)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(263, 70)
        Me.lbltitle.TabIndex = 28
        Me.lbltitle.Text = "WeeCare"
        '
        'lblpickupform
        '
        Me.lblpickupform.AutoSize = True
        Me.lblpickupform.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpickupform.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblpickupform.Location = New System.Drawing.Point(362, 109)
        Me.lblpickupform.Name = "lblpickupform"
        Me.lblpickupform.Size = New System.Drawing.Size(133, 18)
        Me.lblpickupform.TabIndex = 31
        Me.lblpickupform.Text = "PICK_UP FORM"
        '
        'Pick_upTableAdapter
        '
        Me.Pick_upTableAdapter.ClearBeforeFill = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PickupBindingSource, "Time of Pick-up", True))
        Me.DateTimePicker1.Location = New System.Drawing.Point(297, 362)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 32
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lblpickupform)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnhome)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.btnprevious)
        Me.Controls.Add(Me.cborelationship)
        Me.Controls.Add(Me.txtphone)
        Me.Controls.Add(Me.txtpickupperson)
        Me.Controls.Add(Me.txtparent)
        Me.Controls.Add(Me.txtchildname)
        Me.Controls.Add(Me.lbltime)
        Me.Controls.Add(Me.lblphone)
        Me.Controls.Add(Me.lblrelationship)
        Me.Controls.Add(Me.lblpickupperson)
        Me.Controls.Add(Me.lblparent)
        Me.Controls.Add(Me.lblchildname)
        Me.Name = "Form6"
        Me.Text = "Pick-up"
        CType(Me.PickupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DaycareDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblchildname As Label
    Friend WithEvents lblparent As Label
    Friend WithEvents lblpickupperson As Label
    Friend WithEvents lblrelationship As Label
    Friend WithEvents lblphone As Label
    Friend WithEvents lbltime As Label
    Friend WithEvents txtchildname As TextBox
    Friend WithEvents txtparent As TextBox
    Friend WithEvents txtpickupperson As TextBox
    Friend WithEvents txtphone As TextBox
    Friend WithEvents cborelationship As ComboBox
    Friend WithEvents btnprevious As Button
    Friend WithEvents btnnext As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents btnhome As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DaycareDBDataSet As DaycareDBDataSet
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbltitle As Label
    Friend WithEvents lblpickupform As Label
    Friend WithEvents PickupBindingSource As BindingSource
    Friend WithEvents Pick_upTableAdapter As DaycareDBDataSetTableAdapters.Pick_upTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ChildsFullNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ParentGuardianNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AuthorizedPickupPersonNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RelationshipDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimeOfPickupDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
