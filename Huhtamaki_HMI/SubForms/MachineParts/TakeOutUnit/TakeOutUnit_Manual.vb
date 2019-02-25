Imports KremerControlsWin32

Public Class TakeOutUnit_Manual

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
            frmMain.lblTitle.Text = GetSingleLabel(102)
            strSide = "MoldA"
        Else
            'Get right title
            frmMain.lblTitle.Text = GetSingleLabel(105)
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

    'Connecting the kremer connector
    Private Sub TakeOutUnit_Manual_ParentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.ParentChanged
        If Not Me.Parent Is Nothing Then

            InitControls()

            GetControlLabel(Me.Controls)

            KrConnector.PLC = frmMain.CX1020
            KrConnector.VarCollector = Me.VarCollector
            KrConnector.Connect()
        Else
            For Each krVar As KremerVariable In VarCollector.Variables
                krVar.VariableName = krVar.VariableName.Replace(strSide, "[Position1]")
            Next

            KrConnector.Disconnect()
        End If
    End Sub

    Private Sub Btn_Settings_Click(sender As Object, e As EventArgs) Handles Btn_Settings.Click
        frmMain.SubTakeOutUnit_Settings.IsASide = IsASide
        frmMain.SubFormChange(frmMain.SubTakeOutUnit_Settings, True)
    End Sub

    Private Sub Btn_Overview_Click(sender As Object, e As EventArgs) Handles Btn_Overview.Click
        frmMain.SubTakeOutUnit_Overview.IsASide = IsASide
        frmMain.SubFormChange(frmMain.SubTakeOutUnit_Overview, True)
    End Sub
End Class
