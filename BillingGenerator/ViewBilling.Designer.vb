<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewBilling
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewBilling))
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.txtMonthYear = New System.Windows.Forms.Label()
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.lblReadingFee = New System.Windows.Forms.Label()
        Me.txtHours = New System.Windows.Forms.Label()
        Me.lblPreparedBy = New System.Windows.Forms.Label()
        Me.txtPreparedBy = New System.Windows.Forms.Label()
        Me.lblPaymentMode = New System.Windows.Forms.Label()
        Me.lblPaymentDate = New System.Windows.Forms.Label()
        Me.txtPaymentMode = New System.Windows.Forms.Label()
        Me.txtPaymentDate = New System.Windows.Forms.Label()
        Me.txtScheduleDates = New System.Windows.Forms.Label()
        Me.txtStudentName = New System.Windows.Forms.Label()
        Me.stripToolbar = New System.Windows.Forms.ToolStrip()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.firstSeperator = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.btnNext = New System.Windows.Forms.ToolStripButton()
        Me.picBilling = New System.Windows.Forms.PictureBox()
        Me.stripToolbar.SuspendLayout()
        CType(Me.picBilling, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.BackColor = System.Drawing.Color.Transparent
        Me.lblMonth.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.lblMonth.Location = New System.Drawing.Point(81, 276)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(86, 27)
        Me.lblMonth.TabIndex = 1
        Me.lblMonth.Text = "Month:"
        '
        'txtMonthYear
        '
        Me.txtMonthYear.AutoSize = True
        Me.txtMonthYear.BackColor = System.Drawing.Color.Transparent
        Me.txtMonthYear.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonthYear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.txtMonthYear.Location = New System.Drawing.Point(162, 275)
        Me.txtMonthYear.Name = "txtMonthYear"
        Me.txtMonthYear.Size = New System.Drawing.Size(184, 27)
        Me.txtMonthYear.TabIndex = 2
        Me.txtMonthYear.Text = "November 2020"
        '
        'lblStudentName
        '
        Me.lblStudentName.AutoSize = True
        Me.lblStudentName.BackColor = System.Drawing.Color.Transparent
        Me.lblStudentName.Font = New System.Drawing.Font("Britannic Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.lblStudentName.Location = New System.Drawing.Point(81, 314)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(219, 36)
        Me.lblStudentName.TabIndex = 3
        Me.lblStudentName.Text = "Student Name:"
        '
        'lblReadingFee
        '
        Me.lblReadingFee.AutoSize = True
        Me.lblReadingFee.BackColor = System.Drawing.Color.Transparent
        Me.lblReadingFee.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReadingFee.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.lblReadingFee.Location = New System.Drawing.Point(81, 362)
        Me.lblReadingFee.Name = "lblReadingFee"
        Me.lblReadingFee.Size = New System.Drawing.Size(149, 27)
        Me.lblReadingFee.TabIndex = 5
        Me.lblReadingFee.Text = "Reading Fee:"
        '
        'txtHours
        '
        Me.txtHours.AutoSize = True
        Me.txtHours.BackColor = System.Drawing.Color.Transparent
        Me.txtHours.Font = New System.Drawing.Font("Britannic Bold", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHours.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.txtHours.Location = New System.Drawing.Point(81, 419)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(196, 25)
        Me.txtHours.TabIndex = 7
        Me.txtHours.Text = "8hrs x 500 = 4000"
        '
        'lblPreparedBy
        '
        Me.lblPreparedBy.AutoSize = True
        Me.lblPreparedBy.BackColor = System.Drawing.Color.Transparent
        Me.lblPreparedBy.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreparedBy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.lblPreparedBy.Location = New System.Drawing.Point(47, 532)
        Me.lblPreparedBy.Name = "lblPreparedBy"
        Me.lblPreparedBy.Size = New System.Drawing.Size(147, 27)
        Me.lblPreparedBy.TabIndex = 8
        Me.lblPreparedBy.Text = "Prepared by:"
        '
        'txtPreparedBy
        '
        Me.txtPreparedBy.AutoSize = True
        Me.txtPreparedBy.BackColor = System.Drawing.Color.Transparent
        Me.txtPreparedBy.Font = New System.Drawing.Font("Britannic Bold", 16.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPreparedBy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.txtPreparedBy.Location = New System.Drawing.Point(190, 534)
        Me.txtPreparedBy.Name = "txtPreparedBy"
        Me.txtPreparedBy.Size = New System.Drawing.Size(145, 25)
        Me.txtPreparedBy.TabIndex = 9
        Me.txtPreparedBy.Text = "Teacher Heidi"
        '
        'lblPaymentMode
        '
        Me.lblPaymentMode.AutoSize = True
        Me.lblPaymentMode.BackColor = System.Drawing.Color.Transparent
        Me.lblPaymentMode.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentMode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.lblPaymentMode.Location = New System.Drawing.Point(428, 533)
        Me.lblPaymentMode.Name = "lblPaymentMode"
        Me.lblPaymentMode.Size = New System.Drawing.Size(123, 27)
        Me.lblPaymentMode.TabIndex = 10
        Me.lblPaymentMode.Text = "Paid Thru:"
        '
        'lblPaymentDate
        '
        Me.lblPaymentDate.AutoSize = True
        Me.lblPaymentDate.BackColor = System.Drawing.Color.Transparent
        Me.lblPaymentDate.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.lblPaymentDate.Location = New System.Drawing.Point(483, 497)
        Me.lblPaymentDate.Name = "lblPaymentDate"
        Me.lblPaymentDate.Size = New System.Drawing.Size(68, 27)
        Me.lblPaymentDate.TabIndex = 11
        Me.lblPaymentDate.Text = "Date:"
        '
        'txtPaymentMode
        '
        Me.txtPaymentMode.AutoSize = True
        Me.txtPaymentMode.BackColor = System.Drawing.Color.Transparent
        Me.txtPaymentMode.Font = New System.Drawing.Font("Britannic Bold", 16.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaymentMode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.txtPaymentMode.Location = New System.Drawing.Point(550, 534)
        Me.txtPaymentMode.Name = "txtPaymentMode"
        Me.txtPaymentMode.Size = New System.Drawing.Size(138, 25)
        Me.txtPaymentMode.TabIndex = 12
        Me.txtPaymentMode.Text = "                  "
        '
        'txtPaymentDate
        '
        Me.txtPaymentDate.AutoSize = True
        Me.txtPaymentDate.BackColor = System.Drawing.Color.Transparent
        Me.txtPaymentDate.Font = New System.Drawing.Font("Britannic Bold", 16.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaymentDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.txtPaymentDate.Location = New System.Drawing.Point(550, 498)
        Me.txtPaymentDate.Name = "txtPaymentDate"
        Me.txtPaymentDate.Size = New System.Drawing.Size(134, 25)
        Me.txtPaymentDate.TabIndex = 13
        Me.txtPaymentDate.Text = "11/01/2020"
        '
        'txtScheduleDates
        '
        Me.txtScheduleDates.AutoSize = True
        Me.txtScheduleDates.BackColor = System.Drawing.Color.Transparent
        Me.txtScheduleDates.Font = New System.Drawing.Font("Britannic Bold", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScheduleDates.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.txtScheduleDates.Location = New System.Drawing.Point(81, 394)
        Me.txtScheduleDates.Name = "txtScheduleDates"
        Me.txtScheduleDates.Size = New System.Drawing.Size(583, 25)
        Me.txtScheduleDates.TabIndex = 16
        Me.txtScheduleDates.Text = "November 3, 5, 10, 12, 17, 19, 20, 24, 26, 27, 28, 29, 30"
        '
        'txtStudentName
        '
        Me.txtStudentName.AutoSize = True
        Me.txtStudentName.BackColor = System.Drawing.Color.Transparent
        Me.txtStudentName.Font = New System.Drawing.Font("Britannic Bold", 22.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentName.ForeColor = System.Drawing.Color.Black
        Me.txtStudentName.Location = New System.Drawing.Point(298, 314)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(283, 33)
        Me.txtStudentName.TabIndex = 15
        Me.txtStudentName.Text = "Christopher Timario"
        '
        'stripToolbar
        '
        Me.stripToolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSave, Me.firstSeperator, Me.ToolStripButton2, Me.btnNext})
        Me.stripToolbar.Location = New System.Drawing.Point(0, 0)
        Me.stripToolbar.Name = "stripToolbar"
        Me.stripToolbar.Size = New System.Drawing.Size(733, 25)
        Me.stripToolbar.TabIndex = 17
        Me.stripToolbar.Text = "Toolbar"
        '
        'btnSave
        '
        Me.btnSave.Image = Global.BillingGenerator.My.Resources.Resources.save
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(51, 22)
        Me.btnSave.Text = "Save"
        '
        'firstSeperator
        '
        Me.firstSeperator.Name = "firstSeperator"
        Me.firstSeperator.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Enabled = False
        Me.ToolStripButton2.Image = Global.BillingGenerator.My.Resources.Resources.previous
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(72, 22)
        Me.ToolStripButton2.Text = "Previous"
        '
        'btnNext
        '
        Me.btnNext.Enabled = False
        Me.btnNext.Image = Global.BillingGenerator.My.Resources.Resources._next
        Me.btnNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(52, 22)
        Me.btnNext.Text = "Next"
        '
        'picBilling
        '
        Me.picBilling.Image = CType(resources.GetObject("picBilling.Image"), System.Drawing.Image)
        Me.picBilling.Location = New System.Drawing.Point(12, 46)
        Me.picBilling.Name = "picBilling"
        Me.picBilling.Size = New System.Drawing.Size(708, 552)
        Me.picBilling.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBilling.TabIndex = 0
        Me.picBilling.TabStop = False
        '
        'ViewBilling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 609)
        Me.Controls.Add(Me.stripToolbar)
        Me.Controls.Add(Me.txtStudentName)
        Me.Controls.Add(Me.txtScheduleDates)
        Me.Controls.Add(Me.txtPaymentDate)
        Me.Controls.Add(Me.txtPaymentMode)
        Me.Controls.Add(Me.lblPaymentDate)
        Me.Controls.Add(Me.lblPaymentMode)
        Me.Controls.Add(Me.txtPreparedBy)
        Me.Controls.Add(Me.lblPreparedBy)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.lblReadingFee)
        Me.Controls.Add(Me.lblStudentName)
        Me.Controls.Add(Me.txtMonthYear)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.picBilling)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ViewBilling"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Billing"
        Me.stripToolbar.ResumeLayout(False)
        Me.stripToolbar.PerformLayout()
        CType(Me.picBilling, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBilling As PictureBox
    Friend WithEvents lblMonth As Label
    Friend WithEvents txtMonthYear As Label
    Friend WithEvents lblStudentName As Label
    Friend WithEvents lblReadingFee As Label
    Friend WithEvents txtHours As Label
    Friend WithEvents lblPreparedBy As Label
    Friend WithEvents txtPreparedBy As Label
    Friend WithEvents lblPaymentMode As Label
    Friend WithEvents lblPaymentDate As Label
    Friend WithEvents txtPaymentMode As Label
    Friend WithEvents txtPaymentDate As Label
    Friend WithEvents txtScheduleDates As Label
    Friend WithEvents txtStudentName As Label
    Friend WithEvents stripToolbar As ToolStrip
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents firstSeperator As ToolStripSeparator
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents btnNext As ToolStripButton
End Class
