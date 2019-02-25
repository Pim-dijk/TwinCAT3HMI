Imports KremerControlsWin32

Public Class DryingMold_Overview

    Dim strMoldSide As String

    Private _IsASide
    Public Property IsASide As Boolean
        Get
            Return _IsASide
        End Get
        Set(ByVal value As Boolean)
            _IsASide = value
        End Set
    End Property

    Private Sub InitControls()
        'Check wich mold is selected and show accordingly (Top/Bot).
        If IsASide Then
            ' Get right title
            frmMain.lblTitle.Text = GetSingleLabel(120)
            Me.BackgroundImage = My.Resources.Top_Dryingmold_A_side
            strMoldSide = "MoldA"
        Else
            'Get right title
            frmMain.lblTitle.Text = GetSingleLabel(121)
            Me.BackgroundImage = My.Resources.Top_Dryingmold_B_side
            strMoldSide = "MoldB"
        End If

        ' Get the right variables
        For Each Krvar As KremerVariable In VarCollector.Variables
            Krvar.VariableName = Krvar.VariableName.Replace("[Position1]", strMoldSide)
        Next

        'User level check
        For Each IoCtl As Control In Me.Controls
            If TypeOf IoCtl Is KremerIoField Then CType(IoCtl, KremerIoField).UserInfo = HmiUserInfo
            If TypeOf IoCtl Is KremerTextField Then CType(IoCtl, KremerTextField).UserInfo = HmiUserInfo
            If TypeOf IoCtl Is KremerButton Then CType(IoCtl, KremerButton).UserInfo = HmiUserInfo
        Next

    End Sub

    'Connecting the kremer connector
    Private Sub DryingMoldOverview_ParentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ParentChanged
        If Not Me.Parent Is Nothing Then

            'init the language for the labels
            InitControls()

            'connect the PLC to the mainfrom plc
            KrConnector.PLC = frmMain.CX1020
            KrConnector.VarCollector = Me.VarCollector
            KrConnector.Connect()
        Else
            KrConnector.Disconnect()

            For Each krVar As KremerVariable In VarCollector.Variables
                krVar.VariableName = krVar.VariableName.Replace(strMoldSide, "[Position1]")
            Next
        End If
    End Sub

    Private Sub PanelTop_Click(sender As Object, e As EventArgs) Handles PanelTopMold.Click
        'Pass arguments that tells the page if it is top or bottom and A or b side.
        frmMain.SubDryingMoldDetail_Top.IsTopSide = True
        frmMain.SubDryingMoldDetail_Top.IsASide = IsASide
        frmMain.SubFormChange(frmMain.SubDryingMoldDetail_Top, True)
    End Sub

    Private Sub PanelBottom_Click(sender As Object, e As EventArgs) Handles PnlBottomMold.Click
        'Pass arguments that tells the page if it is top or bottom and A or b side.
        frmMain.SubDryingMoldDetail_bot.IsTopSide = False
        frmMain.SubDryingMoldDetail_bot.IsASide = IsASide
        frmMain.SubFormChange(frmMain.SubDryingMoldDetail_bot, True)
    End Sub

    Private Sub Btn_BSettings_Click(sender As Object, e As EventArgs) Handles Btn_BSettings.Click
        frmMain.SubDryingMold_Settings.IsASide = IsASide
        frmMain.SubFormChange(frmMain.SubDryingMold_Settings, True)
    End Sub

    Private Sub Btn_Manual_Click(sender As Object, e As EventArgs) Handles Btn_Manual.Click
        frmMain.SubDryingMold_Manual.IsASide = IsASide
        frmMain.SubFormChange(frmMain.SubDryingMold_Manual, True)
    End Sub

    Private Sub mxAutomode_DataChanged(sender As Object, e As EventArgs) Handles mxAutomode.DataChanged
        Btn_Manual.Enabled = Not mxAutomode.Data
    End Sub

End Class
