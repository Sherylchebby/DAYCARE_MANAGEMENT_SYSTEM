<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.lblreport = New System.Windows.Forms.Label()
        Me.txthealth = New System.Windows.Forms.TextBox()
        Me.DailyReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DaycareDB1DataSet = New DAYCARE_MANAGEMENT_SYSTEM.DaycareDB1DataSet()
        Me.lblhealth = New System.Windows.Forms.Label()
        Me.chkabsent = New System.Windows.Forms.CheckBox()
        Me.chkpresent = New System.Windows.Forms.CheckBox()
        Me.txtchild = New System.Windows.Forms.TextBox()
        Me.txtmood = New System.Windows.Forms.TextBox()
        Me.txtactivity = New System.Windows.Forms.TextBox()
        Me.txtteacher = New System.Windows.Forms.TextBox()
        Me.dtbdate = New System.Windows.Forms.DateTimePicker()
        Me.lblmood = New System.Windows.Forms.Label()
        Me.lblactivities = New System.Windows.Forms.Label()
        Me.lblattendance = New System.Windows.Forms.Label()
        Me.lblchild = New System.Windows.Forms.Label()
        Me.lblteacher = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.btnprevious = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.btnhome = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.Daily_ReportTableAdapter = New DAYCARE_MANAGEMENT_SYSTEM.DaycareDB1DataSetTableAdapters.Daily_ReportTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateAndDayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeacherCarerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChildsNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttendanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActivitiesParticipatedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MoodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HealthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DailyReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DaycareDB1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbltitle)
        Me.Panel1.Location = New System.Drawing.Point(-135, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1071, 82)
        Me.Panel1.TabIndex = 36
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
        'lblreport
        '
        Me.lblreport.AutoSize = True
        Me.lblreport.BackColor = System.Drawing.Color.PapayaWhip
        Me.lblreport.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblreport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblreport.Location = New System.Drawing.Point(331, 85)
        Me.lblreport.Name = "lblreport"
        Me.lblreport.Size = New System.Drawing.Size(132, 18)
        Me.lblreport.TabIndex = 53
        Me.lblreport.Text = "DAILY REPORT"
        '
        'txthealth
        '
        Me.txthealth.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DailyReportBindingSource, "Health", True))
        Me.txthealth.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthealth.Location = New System.Drawing.Point(304, 383)
        Me.txthealth.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txthealth.Multiline = True
        Me.txthealth.Name = "txthealth"
        Me.txthealth.Size = New System.Drawing.Size(265, 22)
        Me.txthealth.TabIndex = 51
        '
        'DailyReportBindingSource
        '
        Me.DailyReportBindingSource.DataMember = "Daily Report"
        Me.DailyReportBindingSource.DataSource = Me.DaycareDB1DataSet
        '
        'DaycareDB1DataSet
        '
        Me.DaycareDB1DataSet.DataSetName = "DaycareDB1DataSet"
        Me.DaycareDB1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblhealth
        '
        Me.lblhealth.AutoSize = True
        Me.lblhealth.BackColor = System.Drawing.Color.PapayaWhip
        Me.lblhealth.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhealth.Location = New System.Drawing.Point(61, 386)
        Me.lblhealth.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblhealth.Name = "lblhealth"
        Me.lblhealth.Size = New System.Drawing.Size(47, 15)
        Me.lblhealth.TabIndex = 50
        Me.lblhealth.Text = "Health"
        '
        'chkabsent
        '
        Me.chkabsent.AutoSize = True
        Me.chkabsent.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkabsent.Location = New System.Drawing.Point(463, 238)
        Me.chkabsent.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chkabsent.Name = "chkabsent"
        Me.chkabsent.Size = New System.Drawing.Size(71, 19)
        Me.chkabsent.TabIndex = 49
        Me.chkabsent.Text = "Absent"
        Me.chkabsent.UseVisualStyleBackColor = True
        '
        'chkpresent
        '
        Me.chkpresent.AutoSize = True
        Me.chkpresent.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkpresent.Location = New System.Drawing.Point(304, 238)
        Me.chkpresent.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chkpresent.Name = "chkpresent"
        Me.chkpresent.Size = New System.Drawing.Size(74, 19)
        Me.chkpresent.TabIndex = 48
        Me.chkpresent.Text = "Present"
        Me.chkpresent.UseVisualStyleBackColor = True
        '
        'txtchild
        '
        Me.txtchild.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DailyReportBindingSource, "Child's Name", True))
        Me.txtchild.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchild.Location = New System.Drawing.Point(304, 205)
        Me.txtchild.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtchild.Name = "txtchild"
        Me.txtchild.Size = New System.Drawing.Size(265, 23)
        Me.txtchild.TabIndex = 47
        '
        'txtmood
        '
        Me.txtmood.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DailyReportBindingSource, "Mood", True))
        Me.txtmood.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmood.Location = New System.Drawing.Point(304, 337)
        Me.txtmood.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtmood.Name = "txtmood"
        Me.txtmood.Size = New System.Drawing.Size(265, 23)
        Me.txtmood.TabIndex = 46
        '
        'txtactivity
        '
        Me.txtactivity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DailyReportBindingSource, "Activities Participated", True))
        Me.txtactivity.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtactivity.Location = New System.Drawing.Point(304, 288)
        Me.txtactivity.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtactivity.Name = "txtactivity"
        Me.txtactivity.Size = New System.Drawing.Size(265, 23)
        Me.txtactivity.TabIndex = 45
        '
        'txtteacher
        '
        Me.txtteacher.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DailyReportBindingSource, "Teacher/Carer Name", True))
        Me.txtteacher.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtteacher.Location = New System.Drawing.Point(304, 172)
        Me.txtteacher.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtteacher.Name = "txtteacher"
        Me.txtteacher.Size = New System.Drawing.Size(265, 23)
        Me.txtteacher.TabIndex = 44
        Me.txtteacher.Text = "j"
        '
        'dtbdate
        '
        Me.dtbdate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DailyReportBindingSource, "Date and Day", True))
        Me.dtbdate.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtbdate.Location = New System.Drawing.Point(304, 129)
        Me.dtbdate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dtbdate.Name = "dtbdate"
        Me.dtbdate.Size = New System.Drawing.Size(265, 23)
        Me.dtbdate.TabIndex = 43
        '
        'lblmood
        '
        Me.lblmood.AutoSize = True
        Me.lblmood.BackColor = System.Drawing.Color.PapayaWhip
        Me.lblmood.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmood.Location = New System.Drawing.Point(64, 340)
        Me.lblmood.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblmood.Name = "lblmood"
        Me.lblmood.Size = New System.Drawing.Size(44, 15)
        Me.lblmood.TabIndex = 42
        Me.lblmood.Text = "Mood"
        '
        'lblactivities
        '
        Me.lblactivities.AutoSize = True
        Me.lblactivities.BackColor = System.Drawing.Color.PapayaWhip
        Me.lblactivities.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblactivities.Location = New System.Drawing.Point(62, 296)
        Me.lblactivities.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblactivities.Name = "lblactivities"
        Me.lblactivities.Size = New System.Drawing.Size(141, 15)
        Me.lblactivities.TabIndex = 41
        Me.lblactivities.Text = "Activities Participated"
        '
        'lblattendance
        '
        Me.lblattendance.AutoSize = True
        Me.lblattendance.BackColor = System.Drawing.Color.PapayaWhip
        Me.lblattendance.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblattendance.Location = New System.Drawing.Point(61, 250)
        Me.lblattendance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblattendance.Name = "lblattendance"
        Me.lblattendance.Size = New System.Drawing.Size(80, 15)
        Me.lblattendance.TabIndex = 40
        Me.lblattendance.Text = "Attendance"
        '
        'lblchild
        '
        Me.lblchild.AutoSize = True
        Me.lblchild.BackColor = System.Drawing.Color.PapayaWhip
        Me.lblchild.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblchild.Location = New System.Drawing.Point(62, 213)
        Me.lblchild.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblchild.Name = "lblchild"
        Me.lblchild.Size = New System.Drawing.Size(79, 15)
        Me.lblchild.TabIndex = 39
        Me.lblchild.Text = "Child' Name"
        '
        'lblteacher
        '
        Me.lblteacher.AutoSize = True
        Me.lblteacher.BackColor = System.Drawing.Color.PapayaWhip
        Me.lblteacher.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblteacher.Location = New System.Drawing.Point(61, 180)
        Me.lblteacher.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblteacher.Name = "lblteacher"
        Me.lblteacher.Size = New System.Drawing.Size(134, 15)
        Me.lblteacher.TabIndex = 38
        Me.lblteacher.Text = "Teacher/carer Name"
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbldate.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(62, 137)
        Me.lbldate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(37, 15)
        Me.lbldate.TabIndex = 37
        Me.lbldate.Text = "Date"
        '
        'btnprevious
        '
        Me.btnprevious.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnprevious.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprevious.ForeColor = System.Drawing.Color.White
        Me.btnprevious.Location = New System.Drawing.Point(687, 137)
        Me.btnprevious.Name = "btnprevious"
        Me.btnprevious.Size = New System.Drawing.Size(86, 23)
        Me.btnprevious.TabIndex = 58
        Me.btnprevious.Text = "Previous"
        Me.btnprevious.UseVisualStyleBackColor = False
        '
        'btnnext
        '
        Me.btnnext.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnnext.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnext.ForeColor = System.Drawing.Color.White
        Me.btnnext.Location = New System.Drawing.Point(687, 193)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(86, 23)
        Me.btnnext.TabIndex = 57
        Me.btnnext.Text = "Next"
        Me.btnnext.UseVisualStyleBackColor = False
        '
        'btnnew
        '
        Me.btnnew.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnnew.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.ForeColor = System.Drawing.Color.White
        Me.btnnew.Location = New System.Drawing.Point(687, 309)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(86, 23)
        Me.btnnew.TabIndex = 56
        Me.btnnew.Text = "Add "
        Me.btnnew.UseVisualStyleBackColor = False
        '
        'btnhome
        '
        Me.btnhome.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnhome.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhome.ForeColor = System.Drawing.Color.White
        Me.btnhome.Location = New System.Drawing.Point(687, 364)
        Me.btnhome.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Size = New System.Drawing.Size(111, 27)
        Me.btnhome.TabIndex = 55
        Me.btnhome.Text = "Home"
        Me.btnhome.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnsave.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Location = New System.Drawing.Point(687, 244)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(111, 27)
        Me.btnsave.TabIndex = 54
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'Daily_ReportTableAdapter
        '
        Me.Daily_ReportTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.DateAndDayDataGridViewTextBoxColumn, Me.TeacherCarerNameDataGridViewTextBoxColumn, Me.ChildsNameDataGridViewTextBoxColumn, Me.AttendanceDataGridViewTextBoxColumn, Me.ActivitiesParticipatedDataGridViewTextBoxColumn, Me.MoodDataGridViewTextBoxColumn, Me.HealthDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DailyReportBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 421)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(786, 50)
        Me.DataGridView1.TabIndex = 59
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'DateAndDayDataGridViewTextBoxColumn
        '
        Me.DateAndDayDataGridViewTextBoxColumn.DataPropertyName = "Date and Day"
        Me.DateAndDayDataGridViewTextBoxColumn.HeaderText = "Date and Day"
        Me.DateAndDayDataGridViewTextBoxColumn.Name = "DateAndDayDataGridViewTextBoxColumn"
        '
        'TeacherCarerNameDataGridViewTextBoxColumn
        '
        Me.TeacherCarerNameDataGridViewTextBoxColumn.DataPropertyName = "Teacher/Carer Name"
        Me.TeacherCarerNameDataGridViewTextBoxColumn.HeaderText = "Teacher/Carer Name"
        Me.TeacherCarerNameDataGridViewTextBoxColumn.Name = "TeacherCarerNameDataGridViewTextBoxColumn"
        '
        'ChildsNameDataGridViewTextBoxColumn
        '
        Me.ChildsNameDataGridViewTextBoxColumn.DataPropertyName = "Child's Name"
        Me.ChildsNameDataGridViewTextBoxColumn.HeaderText = "Child's Name"
        Me.ChildsNameDataGridViewTextBoxColumn.Name = "ChildsNameDataGridViewTextBoxColumn"
        '
        'AttendanceDataGridViewTextBoxColumn
        '
        Me.AttendanceDataGridViewTextBoxColumn.DataPropertyName = "Attendance"
        Me.AttendanceDataGridViewTextBoxColumn.HeaderText = "Attendance"
        Me.AttendanceDataGridViewTextBoxColumn.Name = "AttendanceDataGridViewTextBoxColumn"
        '
        'ActivitiesParticipatedDataGridViewTextBoxColumn
        '
        Me.ActivitiesParticipatedDataGridViewTextBoxColumn.DataPropertyName = "Activities Participated"
        Me.ActivitiesParticipatedDataGridViewTextBoxColumn.HeaderText = "Activities Participated"
        Me.ActivitiesParticipatedDataGridViewTextBoxColumn.Name = "ActivitiesParticipatedDataGridViewTextBoxColumn"
        '
        'MoodDataGridViewTextBoxColumn
        '
        Me.MoodDataGridViewTextBoxColumn.DataPropertyName = "Mood"
        Me.MoodDataGridViewTextBoxColumn.HeaderText = "Mood"
        Me.MoodDataGridViewTextBoxColumn.Name = "MoodDataGridViewTextBoxColumn"
        '
        'HealthDataGridViewTextBoxColumn
        '
        Me.HealthDataGridViewTextBoxColumn.DataPropertyName = "Health"
        Me.HealthDataGridViewTextBoxColumn.HeaderText = "Health"
        Me.HealthDataGridViewTextBoxColumn.Name = "HealthDataGridViewTextBoxColumn"
        '
        'Form11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnprevious)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.btnhome)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.lblreport)
        Me.Controls.Add(Me.txthealth)
        Me.Controls.Add(Me.lblhealth)
        Me.Controls.Add(Me.chkabsent)
        Me.Controls.Add(Me.chkpresent)
        Me.Controls.Add(Me.txtchild)
        Me.Controls.Add(Me.txtmood)
        Me.Controls.Add(Me.txtactivity)
        Me.Controls.Add(Me.txtteacher)
        Me.Controls.Add(Me.dtbdate)
        Me.Controls.Add(Me.lblmood)
        Me.Controls.Add(Me.lblactivities)
        Me.Controls.Add(Me.lblattendance)
        Me.Controls.Add(Me.lblchild)
        Me.Controls.Add(Me.lblteacher)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form11"
        Me.Text = "Report"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DailyReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DaycareDB1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbltitle As Label
    Friend WithEvents lblreport As Label
    Friend WithEvents txthealth As TextBox
    Friend WithEvents lblhealth As Label
    Friend WithEvents chkabsent As CheckBox
    Friend WithEvents chkpresent As CheckBox
    Friend WithEvents txtchild As TextBox
    Friend WithEvents txtmood As TextBox
    Friend WithEvents txtactivity As TextBox
    Friend WithEvents txtteacher As TextBox
    Friend WithEvents dtbdate As DateTimePicker
    Friend WithEvents lblmood As Label
    Friend WithEvents lblactivities As Label
    Friend WithEvents lblattendance As Label
    Friend WithEvents lblchild As Label
    Friend WithEvents lblteacher As Label
    Friend WithEvents lbldate As Label
    Friend WithEvents btnprevious As Button
    Friend WithEvents btnnext As Button
    Friend WithEvents btnnew As Button
    Friend WithEvents btnhome As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents DaycareDB1DataSet As DaycareDB1DataSet
    Friend WithEvents DailyReportBindingSource As BindingSource
    Friend WithEvents Daily_ReportTableAdapter As DaycareDB1DataSetTableAdapters.Daily_ReportTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateAndDayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TeacherCarerNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ChildsNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AttendanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ActivitiesParticipatedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MoodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HealthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
