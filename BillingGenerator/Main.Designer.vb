<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.chkSchedule = New System.Windows.Forms.CheckedListBox()
        Me.dtpMonthYear = New System.Windows.Forms.DateTimePicker()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.txtPreparedBy = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtModeOfPayment = New System.Windows.Forms.TextBox()
        Me.dtpPaymentDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.dtpDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(108, 26)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(232, 31)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Billing Generator"
        '
        'chkSchedule
        '
        Me.chkSchedule.BackColor = System.Drawing.SystemColors.Control
        Me.chkSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.chkSchedule.CheckOnClick = True
        Me.chkSchedule.FormattingEnabled = True
        Me.chkSchedule.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})
        Me.chkSchedule.Location = New System.Drawing.Point(155, 171)
        Me.chkSchedule.Name = "chkSchedule"
        Me.chkSchedule.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSchedule.Size = New System.Drawing.Size(113, 126)
        Me.chkSchedule.TabIndex = 4
        '
        'dtpMonthYear
        '
        Me.dtpMonthYear.CustomFormat = "MMMM yyyy"
        Me.dtpMonthYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMonthYear.Location = New System.Drawing.Point(155, 75)
        Me.dtpMonthYear.Name = "dtpMonthYear"
        Me.dtpMonthYear.Size = New System.Drawing.Size(185, 26)
        Me.dtpMonthYear.TabIndex = 0
        Me.dtpMonthYear.Value = New Date(2020, 12, 1, 0, 0, 0, 0)
        '
        'txtStudentName
        '
        Me.txtStudentName.Location = New System.Drawing.Point(155, 107)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(270, 26)
        Me.txtStudentName.TabIndex = 1
        '
        'txtPreparedBy
        '
        Me.txtPreparedBy.Location = New System.Drawing.Point(155, 303)
        Me.txtPreparedBy.Name = "txtPreparedBy"
        Me.txtPreparedBy.Size = New System.Drawing.Size(270, 26)
        Me.txtPreparedBy.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Month:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Student's Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Schedule:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 306)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Prepared by:"
        '
        'txtModeOfPayment
        '
        Me.txtModeOfPayment.Location = New System.Drawing.Point(155, 335)
        Me.txtModeOfPayment.Name = "txtModeOfPayment"
        Me.txtModeOfPayment.Size = New System.Drawing.Size(270, 26)
        Me.txtModeOfPayment.TabIndex = 6
        '
        'dtpPaymentDate
        '
        Me.dtpPaymentDate.CustomFormat = "MMMM dd, yyyy"
        Me.dtpPaymentDate.Enabled = False
        Me.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPaymentDate.Location = New System.Drawing.Point(155, 367)
        Me.dtpPaymentDate.Name = "dtpPaymentDate"
        Me.dtpPaymentDate.Size = New System.Drawing.Size(185, 26)
        Me.dtpPaymentDate.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 338)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Paid Thru:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 372)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Date:"
        '
        'btnGenerate
        '
        Me.btnGenerate.AutoSize = True
        Me.btnGenerate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnGenerate.Location = New System.Drawing.Point(181, 411)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(87, 30)
        Me.btnGenerate.TabIndex = 8
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.CustomFormat = "MM/dd/yyyy"
        Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFrom.Location = New System.Drawing.Point(155, 139)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(120, 26)
        Me.dtpDateFrom.TabIndex = 2
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "MM/dd/yyyy"
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(305, 139)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(120, 26)
        Me.dtpDateTo.TabIndex = 3
        Me.dtpDateTo.Value = New Date(2020, 11, 30, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(281, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 20)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "~"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 454)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtpDateTo)
        Me.Controls.Add(Me.dtpDateFrom)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpPaymentDate)
        Me.Controls.Add(Me.txtModeOfPayment)
        Me.Controls.Add(Me.txtPreparedBy)
        Me.Controls.Add(Me.txtStudentName)
        Me.Controls.Add(Me.dtpMonthYear)
        Me.Controls.Add(Me.chkSchedule)
        Me.Controls.Add(Me.lblTitle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Billing Generator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents chkSchedule As CheckedListBox
    Friend WithEvents dtpMonthYear As DateTimePicker
    Friend WithEvents txtStudentName As TextBox
    Friend WithEvents txtPreparedBy As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtModeOfPayment As TextBox
    Friend WithEvents dtpPaymentDate As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnGenerate As Button
    Friend WithEvents dtpDateFrom As DateTimePicker
    Friend WithEvents dtpDateTo As DateTimePicker
    Friend WithEvents Label7 As Label
End Class
