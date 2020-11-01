Public Class Main
    Public Billing As Billing
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setInitialDatePickerValues()
    End Sub

    Private Sub setInitialDatePickerValues()
        Dim nextMonth As Date = Date.Today.AddMonths(1)
        Dim numberOfDays As Integer = Date.DaysInMonth(nextMonth.Year, nextMonth.Month)
        dtpMonthYear.Value = nextMonth
        dtpDateFrom.Value = New Date(nextMonth.Year, nextMonth.Month, 1)
        dtpDateTo.Value = New Date(nextMonth.Year, nextMonth.Month, numberOfDays)
        dtpPaymentDate.Value = Date.Today
    End Sub

    Private Sub txtModeOfPayment_TextChanged(sender As Object, e As EventArgs) Handles txtModeOfPayment.TextChanged
        dtpPaymentDate.Enabled = Not String.IsNullOrWhiteSpace(txtModeOfPayment.Text)
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Try
            validateInputs()
            displayGeneratedBilling()
        Catch ex As Exception
            displayError(ex.Message)
        End Try
    End Sub

    Private Sub validateInputs()
        If String.IsNullOrWhiteSpace(txtStudentName.Text) Then
            txtStudentName.Focus()
            Throw New ArgumentException("Please input student name.")
        ElseIf chkSchedule.CheckedItems.Count = 0 Then
            chkSchedule.Focus()
            Throw New ArgumentException("Please select schedule.")
        ElseIf String.IsNullOrWhiteSpace(txtPreparedBy.Text) Then
            txtPreparedBy.Focus()
            Throw New ArgumentException("Please input prepared by.")
        End If
    End Sub

    Private Sub displayGeneratedBilling()
        Dim billing = generateBilling()
        Dim viewBilling As New ViewBilling(billing)
        viewBilling.Show()
    End Sub

    Private Function generateBilling() As Billing
        Dim billing As New Billing
        billing.MonthYear = dtpMonthYear.Value
        billing.StudentsName = txtStudentName.Text.Trim()
        billing.PreparedBy = txtPreparedBy.Text.Trim()
        For Each schedule As Date In DateRange(dtpDateFrom.Value, dtpDateTo.Value)
            Dim dayOfWeek As String = schedule.ToString("dddd")
            If chkSchedule.CheckedItems.Contains(dayOfWeek) Then
                billing.ScheduleDates.Add(schedule.Day)
            End If
        Next
        If Not String.IsNullOrWhiteSpace(txtModeOfPayment.Text) Then
            billing.PaymentMode = txtModeOfPayment.Text.Trim()
            billing.PaymentDate = dtpPaymentDate.Value
        End If
        Return billing
    End Function

    Private Function DateRange(dateStart As Date, dateEnd As Date) As IEnumerable(Of Date)
        Return Enumerable.Range(0, (dateEnd - dateStart).Days + 1).Select(Function(i) dateStart.AddDays(i))
    End Function
End Class