Imports KremerControlsWin32

Public Class Gantry_Settings

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
            frmMain.lblTitle.Text = GetSingleLabel(604)
            strSide = "GantryA"
        Else
            'Get right title
            frmMain.lblTitle.Text = GetSingleLabel(605)
            strSide = "GantryB"
        End If

        ' Get the right variables
        For Each Krvar As KremerVariable In VarCollector.Variables
            Krvar.VariableName = Krvar.VariableName.Replace("[Position1]", strSide)
        Next

        For Each IoCtl As Control In Me.Controls
            If TypeOf IoCtl Is KremerIoField Then CType(IoCtl, KremerIoField).UserInfo = HmiUserInfo
            If TypeOf IoCtl Is KremerTextField Then CType(IoCtl, KremerTextField).UserInfo = HmiUserInfo
            If TypeOf IoCtl Is KremerButton Then CType(IoCtl, KremerButton).UserInfo = HmiUserInfo
        Next
    End Sub

    Private Sub Gantry_Settings_ParentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.ParentChanged
        If Not Me.Parent Is Nothing Then

            InitControls()

            GetControlLabel(Me.Controls)

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


    Private Sub Btn_Overview_Click(sender As Object, e As EventArgs) Handles Btn_Overview.Click
        frmMain.SubGantry_Overview.IsASide = IsASide
        frmMain.SubFormChange(frmMain.SubGantry_Overview, True)
    End Sub

    Private Sub Btn_Manual_Click(sender As Object, e As EventArgs) Handles Btn_Manual.Click
        frmMain.SubGantry_Manual.IsASide = IsASide
        frmMain.SubFormChange(frmMain.SubGantry_Manual, True)
    End Sub

    Private Sub mxAutomode_DataChanged(sender As Object, e As EventArgs) Handles mxAutomode.DataChanged
        Btn_Manual.Enabled = Not mxAutomode.Data
    End Sub

End Class
