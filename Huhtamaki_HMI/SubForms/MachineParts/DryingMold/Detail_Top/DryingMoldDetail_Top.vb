Imports KremerControlsWin32

Public Class DryingMoldDetail_Top

    Private _IsASide
    Public Property IsASide As Boolean
        Get
            Return _IsASide
        End Get
        Set(ByVal value As Boolean)
            _IsASide = value
        End Set
    End Property

    Private _IsTopSide
    Public Property IsTopSide As Boolean
        Get
            Return _IsTopSide
        End Get
        Set(ByVal value As Boolean)
            _IsTopSide = value
        End Set
    End Property

    Private strMoldSide As String

    Private Sub InitControls()

        If IsASide Then
            strMoldSide = "MoldA"
            frmMain.lblTitle.Text = GetSingleLabel(126)
        Else
            strMoldSide = "MoldB"
            frmMain.lblTitle.Text = GetSingleLabel(128)
        End If

        For Each krVar As KremerVariable In VarCollector.Variables
            krVar.VariableName = krVar.VariableName.Replace("[Position1]", strMoldSide)
        Next

        'User level check
        For Each IoCtl As Control In Me.Controls
            If TypeOf IoCtl Is KremerIoField Then CType(IoCtl, KremerIoField).UserInfo = HmiUserInfo
            If TypeOf IoCtl Is KremerTextField Then CType(IoCtl, KremerTextField).UserInfo = HmiUserInfo
        Next

    End Sub

    'Connecting the kremer connector
    Private Sub DryingMoldTop_ParentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ParentChanged
        If Not Me.Parent Is Nothing Then

            InitControls()

            GetControlLabel(Me.Controls)
            ' GetControlLabel(Me.Panel1.Controls)

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


    Private Sub BtnOverview_Click(sender As Object, e As EventArgs) Handles BtnOverview.Click
        frmMain.SubFormChange(frmMain.SubDryingMold_Overview, True)
    End Sub


    Private Sub Btn_PIDSettingsTop_Click(sender As Object, e As EventArgs) Handles Btn_PIDSettings1.Click, Btn_PIDSettings2.Click, _
        Btn_PIDSettings3.Click, Btn_PIDSettings4.Click, Btn_PIDSettings5.Click, Btn_PIDSettings6.Click

        ' Get info from button.
        Dim tmp As String = Microsoft.VisualBasic.Right(DirectCast(sender, Button).Name, 1)
        'MsgBox(tmp)

        'Pass arguments to next screen.
        frmMain.SubDryingMoldDetail_Top_Settings.SetNumber = tmp
        frmMain.SubDryingMoldDetail_Top_Settings.IsASide = IsASide
        frmMain.SubDryingMoldDetail_Top_Settings.IsTopSide = IsTopSide
        frmMain.SubFormChange(frmMain.SubDryingMoldDetail_Top_Settings, True)
    End Sub


    Private Sub Btn_PIDBotSettings1_Click(sender As Object, e As EventArgs)
        ' Get info from button.
        Dim tmp As String = Microsoft.VisualBasic.Right(DirectCast(sender, Button).Name, 1)
        'MsgBox(tmp)

        'Pass arguments to next screen.
        frmMain.SubDryingMoldDetail_Top_Settings.SetNumber = tmp
        frmMain.SubDryingMoldDetail_Top_Settings.IsASide = IsASide
        frmMain.SubDryingMoldDetail_Top_Settings.IsTopSide = IsTopSide
        frmMain.SubFormChange(frmMain.SubDryingMoldDetail_Top_Settings, True)
    End Sub

End Class
