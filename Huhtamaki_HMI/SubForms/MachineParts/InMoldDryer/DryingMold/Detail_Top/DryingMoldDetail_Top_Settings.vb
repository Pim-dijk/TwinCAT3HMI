Imports KremerControlsWin32

Public Class DryingMoldDetail_Top_Settings

#Region "Properties"
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

    Private _SetNumber
    Public Property SetNumber As String
        Get
            Return _SetNumber
        End Get
        Set(ByVal value As String)
            _SetNumber = value
        End Set
    End Property

#End Region

    Private MoldSide As String

    Private Sub InitControls()

        If IsASide Then
            'Check wich mold is selected and show accordingly (Top/Bot).
            If IsTopSide Then                                                               ' Aside TOP
                frmMain.lblTitle.Text = GetSingleLabel(135) + " (" + SetNumber + ")"
                MoldSide = "TopMoldA"
            Else                                                                            'ASide BOT
                frmMain.lblTitle.Text = GetSingleLabel(137) + " (" + SetNumber + ")"
                MoldSide = "BottomMoldA"
            End If
        Else                                                                                'BSide TOP
            'Check wich mold is selected and show accordingly (Top/Bot).
            If IsTopSide Then
                frmMain.lblTitle.Text = GetSingleLabel(136) + " (" + SetNumber + ")"
                MoldSide = "TopMoldB"
            Else                                                                            'BSide Bot
                frmMain.lblTitle.Text = GetSingleLabel(138) + " (" + SetNumber + ")"
                MoldSide = "BottomMoldB"
            End If
        End If

        LblTitle.Text = GetSingleLabel(200) + " " + SetNumber

        ' Get the right variables
        For Each Krvar As KremerVariable In VarCollector.Variables
            Krvar.VariableName = Krvar.VariableName.Replace("[Position1]", MoldSide)
            Krvar.VariableName = Krvar.VariableName.Replace("[Position2]", SetNumber)
        Next

        'User level check
        For Each IoCtl As Control In Me.Controls
            If TypeOf IoCtl Is KremerIoField Then CType(IoCtl, KremerIoField).UserInfo = HmiUserInfo
            If TypeOf IoCtl Is KremerTextField Then CType(IoCtl, KremerTextField).UserInfo = HmiUserInfo
        Next

        ScalePIDbars()

    End Sub

    'Connecting the kremer connector
    Private Sub DryingMoldDetail_Settings_ParentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ParentChanged
        If Not Me.Parent Is Nothing Then

            InitControls()

            GetControlLabel(Me.Controls)

            KrConnector.PLC = frmMain.CX1020
            KrConnector.VarCollector = Me.VarCollector
            KrConnector.Connect()
        Else
            KrConnector.Disconnect()

            'Put placeholders back
            For Each Krvar As KremerVariable In VarCollector.Variables
                Krvar.VariableName = Krvar.VariableName.Replace(MoldSide, "[Position1]")
                Krvar.VariableName = Krvar.VariableName.Replace("Zone[" + SetNumber + "]", "Zone[[Position2]]")
            Next
        End If
    End Sub

    Private Sub Btn_Overview_Click(sender As Object, e As EventArgs) Handles Btn_Overview.Click
        frmMain.SubFormChange(frmMain.SubDryingMoldDetail_Top, True)
    End Sub

    Private Sub SP_MAX_DataChanged(sender As Object, e As EventArgs) Handles SP_MAX.DataChanged, SP_MIN.DataChanged
        ScalePIDbars()
    End Sub


    Sub ScalePIDbars()
        BAR_SP.FillMaximum = SP_MAX.Data
        BAR_SP.FillMinimum = SP_MIN.Data
        BAR_PV.FillMaximum = SP_MAX.Data
        BAR_PV.FillMaximum = SP_MIN.Data

        SPBarIO_MAX.Data = SP_MAX.Data
        PVBarIO_MAX.Data = SP_MAX.Data
        OutBarIO_MAX.Data = OUT_MAX.Data

        BAR_CV.FillMinimum = OUT_MIN.Data
        BAR_CV.FillMaximum = OUT_MAX.Data
    End Sub

End Class
