Imports KremerControlsWin32

Public Class DryingMoldSettings3

    Private _IsASide
    Public Property IsASide As Boolean
        Get
            Return _IsASide
        End Get
        Set(ByVal value As Boolean)
            _IsASide = value
        End Set
    End Property

    Dim strMoldSide As String

    Private Sub InitControls()
        'Check wich mold is selected and show accordingly (Top/Bot).
        If IsASide Then                                                         ' Aside.
            ' Get right title
            frmMain.lblTitle.Text = GetSingleLabel(122) + " (2/2)"
            strMoldSide = "MoldA"

        Else                                                                    ' Bside.
            'Get right title
            frmMain.lblTitle.Text = GetSingleLabel(123) + " (2/2)"
            strMoldSide = "MoldB"
        End If

        For Each krVar As KremerVariable In VarCollector.Variables
            krVar.VariableName = krVar.VariableName.Replace("[Position1]", strMoldSide)
        Next

        'User level check
        For Each IoCtl As Control In Me.Controls
            If TypeOf IoCtl Is KremerIoField Then CType(IoCtl, KremerIoField).UserInfo = HmiUserInfo
            If TypeOf IoCtl Is KremerTextField Then CType(IoCtl, KremerTextField).UserInfo = HmiUserInfo
            If TypeOf IoCtl Is KremerButton Then CType(IoCtl, KremerButton).UserInfo = HmiUserInfo
        Next

    End Sub

    'Connecting the kremer connector
    Private Sub DryingMoldSettings_ParentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ParentChanged
        If Not Me.Parent Is Nothing Then

            'init the language for the labels
            InitControls()

            'Get language for labels
            GetControlLabel(Me.Controls)

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


    Private Sub Btn_Overview_Click(sender As Object, e As EventArgs) Handles Btn_Overview.Click
        frmMain.SubFormChange(frmMain.SubDryingMold_Overview, True)
    End Sub

    Private Sub Btn_Settings_Click(sender As Object, e As EventArgs) Handles Btn_Settings.Click
        frmMain.SubDryingMold_Settings2.IsASide = IsASide
        frmMain.SubFormChange(frmMain.SubDryingMold_Settings2, True)
    End Sub

    Private Sub Btn_Manual_Click(sender As Object, e As EventArgs) Handles Btn_Manual.Click
        frmMain.SubDryingMold_Manual.IsASide = IsASide
        frmMain.SubFormChange(frmMain.SubDryingMold_Manual, True)
    End Sub

    Private Sub mxAutomode_DataChanged(sender As Object, e As EventArgs) Handles mxAutomode.DataChanged
        Btn_Manual.Enabled = Not mxAutomode.Data
    End Sub
End Class
