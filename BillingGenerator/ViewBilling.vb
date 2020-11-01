Imports System.Drawing.Imaging
Imports Ookii.Dialogs.WinForms

Public Class ViewBilling
    Public Sub New(ByVal billing As Billing)
        InitializeComponent()
        setLabelParentControl()
        setBillingValues(billing)
    End Sub

    Private Sub setLabelParentControl()
        Dim labelList As List(Of Label) = getLabelControls()
        For Each label As Label In labelList
            Dim location As Point = Me.PointToScreen(label.Location)
            location = picBilling.PointToClient(location)
            label.Parent = picBilling
            label.Location = location
        Next
    End Sub

    Private Function getLabelControls() As List(Of Label)
        Dim labelList As New List(Of Label)
        For Each control As Control In Controls
            If TypeOf control Is Label Then
                labelList.Add(control)
            End If
        Next
        Return labelList
    End Function

    Private Sub setBillingValues(ByVal billing As Billing)
        Dim numberOfHours As String = "{0}hrs x 500 = {1}"
        Dim fee As Integer = billing.ScheduleDates.Count * 500
        Dim scheduleDates As String = billing.MonthYear.ToString("MMMM")
        txtMonthYear.Text = billing.MonthYear.ToString("MMMM yyyy")
        txtStudentName.Text = billing.StudentsName
        txtPreparedBy.Text = billing.PreparedBy
        scheduleDates += " " + (String.Join(", ", billing.ScheduleDates))
        txtScheduleDates.Text = scheduleDates
        txtHours.Text = String.Format(numberOfHours, billing.ScheduleDates.Count, fee)
        If String.IsNullOrWhiteSpace(billing.PaymentMode) Then
            txtPaymentDate.Text = String.Empty
            txtPaymentMode.Text = String.Empty
        Else
            txtPaymentDate.Text = billing.PaymentDate.ToString("MM/dd/yyyy")
            txtPaymentMode.Text = billing.PaymentMode
        End If
    End Sub

    Private Sub txtScheduleDates_SizeChanged(sender As Object, e As EventArgs) Handles txtScheduleDates.SizeChanged
        If txtScheduleDates.Width > 580 Then
            Dim fontSize As Integer = txtScheduleDates.Font.Size - 1
            txtScheduleDates.Font = New Font("Britannic Bold", fontSize)
            txtHours.Font = txtScheduleDates.Font
        End If
    End Sub

    Private Sub txtScheduleDates_FontChanged(sender As Object, e As EventArgs) Handles txtScheduleDates.FontChanged
        If txtScheduleDates.Font.Size = 14 Then
            txtScheduleDates.AutoSize = False
            txtScheduleDates.Size = New Size(580, txtScheduleDates.Size.Height + 25)
            txtHours.Location = New Point(txtHours.Location.X, txtHours.Location.Y + 25)
        End If
    End Sub

    Private Sub label_SizeChanged(sender As Object, e As EventArgs) Handles txtPreparedBy.SizeChanged, txtPaymentMode.SizeChanged, txtPaymentDate.SizeChanged
        Dim label As Label = sender
        Dim minimumWidth As Integer = 135
        If label.Width < minimumWidth Then
            label.Text = " " + label.Text + " "
        End If
    End Sub

    Private Sub txtStudentName_SizeChanged(sender As Object, e As EventArgs) Handles txtStudentName.SizeChanged
        Dim minimumWidth As Integer = 285
        If txtStudentName.Width < minimumWidth Then
            txtStudentName.Text = " " + txtStudentName.Text + " "
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim saveFolderDialog As New VistaFolderBrowserDialog
        If saveFolderDialog.ShowDialog = DialogResult.OK Then
            saveBilling(saveFolderDialog.SelectedPath)
            displayInformation("Save", "Image successfully saved.")
        End If
    End Sub

    Private Sub saveBilling(ByVal path As String)
        Dim filePath As String = path + "/" + txtStudentName.Text + ".png"
        Dim billingImage As New Bitmap(picBilling.Image, picBilling.Size)
        Dim graphic As Graphics = Graphics.FromImage(billingImage)
        For Each control As Control In picBilling.Controls
            Dim labelImage As New Bitmap(control.Width, control.Height)
            control.DrawToBitmap(labelImage, control.ClientRectangle)
            graphic.DrawImage(labelImage, control.Location)
            labelImage.Dispose()
        Next
        billingImage.Save(filePath, ImageFormat.Png)
        graphic.Dispose()
        billingImage.Dispose()
    End Sub
End Class