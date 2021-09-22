Public Class frmMain
#Region "Global Variables"
    Private arrRadDevice(2) As RadioButton 'array of 3 RadioButton objects
    Private arrRadPlan(3) As RadioButton

    Private strDevice As String 'to hold the Device choice
    Private strPlan As String 'to hold the Plan choice
    Private strFee As String 'to hold the Fee choice
    Private strImage As String

    Private strCostDevice As String 'holding the number as a string 
    Private strCostPlan As String
    Private strCostFee As String

    Private Const TAX_PERCENT As Single = 7.5

    Private totalCost As Double
    Private deviceCost As Double
    Private planCost As Double
    Private feeCost As Double

    Private Summary As frmSummary 'whenever we need to communicate with the form, we will use the object reference variable 
#End Region
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Load the control arrays
        arrRadDevice(0) = radModel1
        arrRadDevice(1) = radModel2
        arrRadDevice(2) = radModel3
        arrRadPlan(0) = radLevel1
        arrRadPlan(1) = radLevel2
        arrRadPlan(2) = radLevel3
        arrRadPlan(3) = radLevel4
    End Sub
    Private Sub radDevices_CheckedChanged(sender As Object, e As EventArgs) Handles radModel1.CheckedChanged, radModel2.CheckedChanged, radModel3.CheckedChanged
        'Dim strImage As String
        'this happens when the radioButton is turned on or off
        'when the checked state changes
        'we have wired all 3 Device to a single event procedure
        Dim rad As RadioButton
        rad = DirectCast(sender, RadioButton)
        If rad.Checked Then 'only do this when a RadioButton is being turned on
            strDevice = rad.Text
            strImage = rad.Text & ".jpg"
            picDevice.Load(Application.StartupPath & "\Resources\" & strImage)
        End If
        If radModel1.Checked Then
            deviceCost = 45.0
            lblCostDevice.Text = FormatCurrency(deviceCost)
            strCostDevice = FormatCurrency(deviceCost)

        End If
        If radModel2.Checked Then
            deviceCost = 55.0
            lblCostDevice.Text = FormatCurrency(deviceCost)
            strCostDevice = FormatCurrency(deviceCost)
        End If
        If radModel3.Checked Then
            deviceCost = 65.0
            lblCostDevice.Text = FormatCurrency(deviceCost)
            strCostDevice = FormatCurrency(deviceCost)
        End If
    End Sub
    Private Sub radPlans_CheckedChanged(sender As Object, e As EventArgs) Handles radLevel1.CheckedChanged, radLevel2.CheckedChanged, radLevel3.CheckedChanged, radLevel4.CheckedChanged
        'this happens when the radioButton is turned on or off
        'when the checked state changes
        'we have wired all 3 Plan to a single event procedure
        Dim rad As RadioButton
        rad = DirectCast(sender, RadioButton)
        If rad.Checked Then
            strPlan = rad.Text
        End If

        If radLevel1.Checked Then
            planCost = 19.95
            lblCostPlan.Text = FormatCurrency(planCost)
            lblDescription.Text = "Text messages to relatives only"
            strCostPlan = FormatCurrency(planCost)
        End If
        If radLevel2.Checked Then
            planCost = 24.95
            lblCostPlan.Text = FormatCurrency(planCost)
            lblDescription.Text = "Text messages and phone calls to relatives only"
            strCostPlan = FormatCurrency(planCost)
        End If
        If radLevel3.Checked Then
            planCost = 34.95
            lblCostPlan.Text = FormatCurrency(planCost)
            lblDescription.Text = "Text messages and phone calls to relatives, phone checkup with company nurse"
            strCostPlan = FormatCurrency(planCost)
        End If
        If radLevel4.Checked Then
            planCost = 44.95
            lblCostPlan.Text = FormatCurrency(planCost)
            lblDescription.Text = "Text messages and phone calls to relatives, phone checkup with company nurse, includes coverage outside the home"
            strCostPlan = FormatCurrency(planCost)
        End If
    End Sub
    Private Sub chkFee_CheckStateChanged(sender As Object, e As EventArgs) Handles chkFee.CheckStateChanged
        Dim chk As CheckBox
        chk = DirectCast(sender, CheckBox)
        If chk.Checked Then
            feeCost = 25.0
            strFee = "Yes, I agree to installation fee "
            lblCostFee.Text = FormatCurrency(feeCost)
            strCostFee = FormatCurrency(feeCost)
        Else
            feeCost = 0.0
            strFee = "No, I do not agree to installation fee "
            lblCostFee.Text = ""
            strCostFee = FormatCurrency(0)
        End If
    End Sub
    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        'this is to pass to Summary form 
        Dim strDeviceResult As String
        Dim strPlanResult As String
        Dim strFeeResult As String
        Dim strImageResult As String
        Dim strTotalCostResult As String

        Dim blnErrors As Boolean
        Dim strTotal As String
        Dim tempTaxCost As Double

        errP.Clear() 'Clear any previous error messages 

        'validate that the user made selections in radiobuttons
        If strDevice = "" Then 'no Device was selected
            errP.SetError(grpDevice, "You must select a monitoring device model!")
            blnErrors = True
        End If
        If strPlan = "" Then 'no Plan was selected
            errP.SetError(grpPlan, "You must select a monitoring device plan!")
            blnErrors = True
        End If

        'we want to accept the data but we must check if the user passed all the validation checks
        If blnErrors Then 'can't go foward. some of the data is missing or bad
            Exit Sub 'early jump out of this procedure
        End If

        Const MONTHS As Integer = 3

        totalCost = planCost * MONTHS
        totalCost += deviceCost
        totalCost += feeCost
        tempTaxCost = totalCost * 0.075
        totalCost += tempTaxCost

        strTotal = FormatCurrency(totalCost).ToString()

        'need this to fix a bug
        If strFee = "" Then
            feeCost = 0.0
            strFee = "No, I do not agree to installation fee "
            lblCostFee.Text = ""
            strCostFee = FormatCurrency(0)
        End If

        'instantiating form 
        Summary = New frmSummary

        'if we get this far, all of the data is good
        strDeviceResult &= strDevice & ": " & strCostDevice & vbCrLf
        strImageResult &= strImage

        strPlanResult &= strPlan & ": " & strCostPlan & vbCrLf
        strFeeResult &= strFee & strCostFee & vbCrLf
        strTotalCostResult &= strTotal & vbCrLf

        Summary.lblDeviceResult.Text = strDeviceResult ' pushing data we collected to the child form
        Summary.picDeviceResult.Load(Application.StartupPath & "\Resources\" & strImage)
        Summary.lblPlanResult.Text = strPlanResult
        Summary.lblFeeResult.Text = strFeeResult
        Summary.lblTotalCost.Text = strTotalCostResult
        Summary.ShowDialog() 'now we show the results
        'frmChoices stops until frmSummary is closed
        'once user is done, we can assume they might want to complete another one
        'therefore, we will clear the main form for them by simulating the clear button
        btnClear.PerformClick() 'simulate the clicking of this button 

        'Remember we need to totally kill the New frmSummary otherwise multiple objects will be created
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim i As Integer
        For i = 0 To arrRadDevice.Length - 1
            arrRadDevice(i).Checked = False
        Next
        For i = 0 To arrRadPlan.Length - 1
            arrRadPlan(i).Checked = False
        Next
        chkFee.Checked = False
        lblCostDevice.Text = ""
        lblCostPlan.Text = ""
        lblDescription.Text = ""
        lblCostFee.Text = ""
        strDevice = ""
        strPlan = ""
        strFee = ""
        picDevice.Image = Nothing
        errP.Clear()
    End Sub
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit() 'end the program
    End Sub
    Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown 'to fix bug - would load and be checked
        If radModel2.Checked Then
            radModel2.Checked = False
            lblCostDevice.Text = ""
            picDevice.Image = Nothing
        End If
    End Sub
End Class
