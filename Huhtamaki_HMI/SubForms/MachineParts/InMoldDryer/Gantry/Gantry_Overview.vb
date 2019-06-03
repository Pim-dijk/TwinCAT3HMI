Imports KremerControlsWin32

Public Class Gantry_Overview

    Private _IsASide
    Public Property IsASide As Boolean
        Get
            Return _IsASide
        End Get
        Set(ByVal value As Boolean)
            _IsASide = value
        End Set
    End Property

    Private strSide As String

    Private Sub InitControls()


        'Check wich mold is selected and show accordingly (Top/Bot).
        If IsASide Then
            ' Get right title
            frmMain.lblTitle.Text = GetSingleLabel(600)
            Image.Image = My.Resources.Gantry___A_side_side
            strSide = "MoldA"
        Else
            'Get right title
            frmMain.lblTitle.Text = GetSingleLabel(601)
            Image.Image = My.Resources.Gantry___B_side_side
            strSide = "MoldB"
        End If

        ' Get the right variables
        For Each Krvar As KremerVariable In VarCollector.Variables
            Krvar.VariableName = Krvar.VariableName.Replace("[Position1]", strSide)
        Next



        For Each IoCtl As Control In Me.Controls
            If TypeOf IoCtl Is KremerIoField Then CType(IoCtl, KremerIoField).UserInfo = HmiUserInfo
            If TypeOf IoCtl Is KremerTextField Then CType(IoCtl, KremerTextField).UserInfo = HmiUserInfo
        Next

    End Sub


    Private Sub Gantry_Overview_ParentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ParentChanged
        If Not Me.Parent Is Nothing Then

            'init the language for the labels
            InitControls()

            GetControlLabel(Me.Controls)

            'connect the PLC to the mainfrom plc
            KrConnector.PLC = frmMain.CX1020
            KrConnector.VarCollector = Me.VarCollector
            KrConnector.Connect()

        Else
            KrConnector.Disconnect()

            For Each krVar As KremerVariable In VarCollector.Variables
                krVar.VariableName = krVar.VariableName.Replace(strSide, "[Position1]")
            Next
        End If
    End Sub

    Private Sub Btn_Settings_Click(sender As Object, e As EventArgs) Handles Btn_Settings.Click
        frmMain.SubGantry_Settings.IsASide = IsASide
        frmMain.SubFormChange(frmMain.SubGantry_Settings, True)
    End Sub

    Private Sub Btn_Manual_Click(sender As Object, e As EventArgs) Handles Btn_Manual.Click
        frmMain.SubGantry_Manual.IsASide = IsASide
        frmMain.SubFormChange(frmMain.SubGantry_Manual, True)
    End Sub

    Private Sub mxAutomode_DataChanged(sender As Object, e As EventArgs) Handles mxAutomode.DataChanged
        Btn_Manual.Enabled = Not mxAutomode.Data
    End Sub
End Class
