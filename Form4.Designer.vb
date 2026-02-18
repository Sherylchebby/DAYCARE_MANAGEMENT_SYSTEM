<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Me.lblamount = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.lblmethod = New System.Windows.Forms.Label()
        Me.txtchildname = New System.Windows.Forms.TextBox()
        Me.PaymentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DaycareDBDataSet = New DAYCARE_MANAGEMENT_SYSTEM.DaycareDBDataSet()
        Me.txtparent = New System.Windows.Forms.TextBox()
        Me.cbomethod = New System.Windows.Forms.ComboBox()
        Me.dtpdate = New System.Windows.Forms.DateTimePicker()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.lblpayment = New System.Windows.Forms.Label()
        Me.txtamount = New System.Windows.Forms.TextBox()
        Me.PaymentTableAdapter = New DAYCARE_MANAGEMENT_SYSTEM.DaycareDBDataSetTableAdapters.PaymentTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChildsNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ParentsNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentMethodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btncontinue = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.Pick_upTableAdapter1 = New DAYCARE_MANAGEMENT_SYSTEM.DaycareDataSetTableAdapters.Pick_upTableAdapter()
        Me.btnprevious = New System.Windows.Forms.Button()
        CType(Me.PaymentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblchildname.Location = New System.Drawing.Point(120, 176)
        Me.lblchildname.Name = "lblchildname"
        Me.lblchildname.Size = New System.Drawing.Size(86, 15)
        Me.lblchildname.TabIndex = 0
        Me.lblchildname.Text = "Child's Name"
        '
        'lblparent
        '
        Me.lblparent.AutoSize = True
        Me.lblparent.BackColor = System.Drawing.Color.PapayaWhip
        Me.lblparent.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblparent.Location = New System.Drawing.Point(122, 218)
        Me.lblparent.Name = "lblparent"
        Me.lblparent.Size = New System.Drawing.Size(95, 15)
        Me.lblparent.TabIndex = 1
        Me.lblparent.Text = "Parent's Name"
        '
        'lblamount
        '
        Me.lblamount.AutoSize = True
        Me.lblamount.BackColor = System.Drawing.Color.PapayaWhip
        Me.lblamount.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblamount.Location = New System.Drawing.Point(122, 261)
        Me.lblamount.Name = "lblamount"
        Me.lblamount.Size = New System.Drawing.Size(57, 15)
        Me.lblamount.TabIndex = 2
        Me.lblamount.Text = "Amount"
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbldate.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(122, 300)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(94, 15)
        Me.lbldate.TabIndex = 3
        Me.lbldate.Text = "Payment Date"
        '
        'lblmethod
        '
        Me.lblmethod.AutoSize = True
        Me.lblmethod.BackColor = System.Drawing.Color.PapayaWhip
        Me.lblmethod.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmethod.Location = New System.Drawing.Point(120, 340)
        Me.lblmethod.Name = "lblmethod"
        Me.lblmethod.Size = New System.Drawing.Size(113, 15)
        Me.lblmethod.TabIndex = 4
        Me.lblmethod.Text = "Payment Method"
        '
        'txtchildname
        '
        Me.txtchildname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentBindingSource, "Child's Name", True))
        Me.txtchildname.Location = New System.Drawing.Point(295, 171)
        Me.txtchildname.Name = "txtchildname"
        Me.txtchildname.Size = New System.Drawing.Size(241, 20)
        Me.txtchildname.TabIndex = 5
        '
        'PaymentBindingSource
        '
        Me.PaymentBindingSource.DataMember = "Payment"
        Me.PaymentBindingSource.DataSource = Me.DaycareDBDataSet
        '
        'DaycareDBDataSet
        '
        Me.DaycareDBDataSet.DataSetName = "DaycareDBDataSet"
        Me.DaycareDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtparent
        '
        Me.txtparent.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentBindingSource, "Parents Name", True))
        Me.txtparent.Location = New System.Drawing.Point(295, 213)
        Me.txtparent.Name = "txtparent"
        Me.txtparent.Size = New System.Drawing.Size(241, 20)
        Me.txtparent.TabIndex = 6
        '
        'cbomethod
        '
        Me.cbomethod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentBindingSource, "Payment Method", True))
        Me.cbomethod.FormattingEnabled = True
        Me.cbomethod.Items.AddRange(New Object() {"Mpesa", "Cash"})
        Me.cbomethod.Location = New System.Drawing.Point(295, 334)
        Me.cbomethod.Name = "cbomethod"
        Me.cbomethod.Size = New System.Drawing.Size(133, 21)
        Me.cbomethod.TabIndex = 8
        '
        'dtpdate
        '
        Me.dtpdate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentBindingSource, "Payment Date", True))
        Me.dtpdate.Location = New System.Drawing.Point(295, 295)
        Me.dtpdate.Name = "dtpdate"
        Me.dtpdate.Size = New System.Drawing.Size(213, 20)
        Me.dtpdate.TabIndex = 9
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnsave.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Location = New System.Drawing.Point(692, 315)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(96, 23)
        Me.btnsave.TabIndex = 10
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'lblpayment
        '
        Me.lblpayment.AutoSize = True
        Me.lblpayment.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblpayment.Location = New System.Drawing.Point(271, 119)
        Me.lblpayment.Name = "lblpayment"
        Me.lblpayment.Size = New System.Drawing.Size(145, 18)
        Me.lblpayment.TabIndex = 14
        Me.lblpayment.Text = "PAYMENT FORM"
        '
        'txtamount
        '
        Me.txtamount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentBindingSource, "Amount", True))
        Me.txtamount.Location = New System.Drawing.Point(295, 256)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(241, 20)
        Me.txtamount.TabIndex = 15
        '
        'PaymentTableAdapter
        '
        Me.PaymentTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.ChildsNameDataGridViewTextBoxColumn, Me.ParentsNameDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn, Me.PaymentDateDataGridViewTextBoxColumn, Me.PaymentMethodDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PaymentBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(22, 400)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(694, 50)
        Me.DataGridView1.TabIndex = 16
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'ChildsNameDataGridViewTextBoxColumn
        '
        Me.ChildsNameDataGridViewTextBoxColumn.DataPropertyName = "Child's Name"
        Me.ChildsNameDataGridViewTextBoxColumn.HeaderText = "Child's Name"
        Me.ChildsNameDataGridViewTextBoxColumn.Name = "ChildsNameDataGridViewTextBoxColumn"
        '
        'ParentsNameDataGridViewTextBoxColumn
        '
        Me.ParentsNameDataGridViewTextBoxColumn.DataPropertyName = "Parents Name"
        Me.ParentsNameDataGridViewTextBoxColumn.HeaderText = "Parents Name"
        Me.ParentsNameDataGridViewTextBoxColumn.Name = "ParentsNameDataGridViewTextBoxColumn"
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "Amount"
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        '
        'PaymentDateDataGridViewTextBoxColumn
        '
        Me.PaymentDateDataGridViewTextBoxColumn.DataPropertyName = "Payment Date"
        Me.PaymentDateDataGridViewTextBoxColumn.HeaderText = "Payment Date"
        Me.PaymentDateDataGridViewTextBoxColumn.Name = "PaymentDateDataGridViewTextBoxColumn"
        '
        'PaymentMethodDataGridViewTextBoxColumn
        '
        Me.PaymentMethodDataGridViewTextBoxColumn.DataPropertyName = "Payment Method"
        Me.PaymentMethodDataGridViewTextBoxColumn.HeaderText = "Payment Method"
        Me.PaymentMethodDataGridViewTextBoxColumn.Name = "PaymentMethodDataGridViewTextBoxColumn"
        '
        'btncontinue
        '
        Me.btncontinue.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btncontinue.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncontinue.ForeColor = System.Drawing.Color.White
        Me.btncontinue.Location = New System.Drawing.Point(692, 361)
        Me.btncontinue.Name = "btncontinue"
        Me.btncontinue.Size = New System.Drawing.Size(96, 23)
        Me.btncontinue.TabIndex = 17
        Me.btncontinue.Text = "Continue"
        Me.btncontinue.UseVisualStyleBackColor = False
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnadd.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.ForeColor = System.Drawing.Color.White
        Me.btnadd.Location = New System.Drawing.Point(692, 271)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(96, 23)
        Me.btnadd.TabIndex = 19
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbltitle)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(804, 81)
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
        'btnnext
        '
        Me.btnnext.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnnext.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnext.ForeColor = System.Drawing.Color.White
        Me.btnnext.Location = New System.Drawing.Point(692, 218)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(75, 23)
        Me.btnnext.TabIndex = 31
        Me.btnnext.Text = "Next"
        Me.btnnext.UseVisualStyleBackColor = False
        '
        'Pick_upTableAdapter1
        '
        Me.Pick_upTableAdapter1.ClearBeforeFill = True
        '
        'btnprevious
        '
        Me.btnprevious.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnprevious.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprevious.ForeColor = System.Drawing.Color.White
        Me.btnprevious.Location = New System.Drawing.Point(692, 168)
        Me.btnprevious.Name = "btnprevious"
        Me.btnprevious.Size = New System.Drawing.Size(75, 23)
        Me.btnprevious.TabIndex = 32
        Me.btnprevious.Text = "Previous"
        Me.btnprevious.UseVisualStyleBackColor = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnprevious)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.btncontinue)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtamount)
        Me.Controls.Add(Me.lblpayment)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.dtpdate)
        Me.Controls.Add(Me.cbomethod)
        Me.Controls.Add(Me.txtparent)
        Me.Controls.Add(Me.txtchildname)
        Me.Controls.Add(Me.lblmethod)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.lblamount)
        Me.Controls.Add(Me.lblparent)
        Me.Controls.Add(Me.lblchildname)
        Me.Name = "Form4"
        Me.Text = "Payment"
        CType(Me.PaymentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DaycareDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblchildname As Label
    Friend WithEvents lblparent As Label
    Friend WithEvents lblamount As Label
    Friend WithEvents lbldate As Label
    Friend WithEvents lblmethod As Label
    Friend WithEvents txtchildname As TextBox
    Friend WithEvents txtparent As TextBox
    Friend WithEvents cbomethod As ComboBox
    Friend WithEvents dtpdate As DateTimePicker
    Friend WithEvents btnsave As Button
    Friend WithEvents lblpayment As Label
    Friend WithEvents txtamount As TextBox
    Friend WithEvents DaycareDBDataSet As DaycareDBDataSet
    Friend WithEvents PaymentBindingSource As BindingSource
    Friend WithEvents PaymentTableAdapter As DaycareDBDataSetTableAdapters.PaymentTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ChildsNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ParentsNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentMethodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btncontinue As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbltitle As Label
    Friend WithEvents btnnext As Button
    Friend WithEvents Pick_upTableAdapter1 As DaycareDataSetTableAdapters.Pick_upTableAdapter
    Friend WithEvents btnprevious As Button
End Class
