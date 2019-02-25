Imports KremerControlsWin32

Public Class TakeOutUnit_Overview

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

        ' Create a default state by making both panels invisable.
        Pnl_ASide1.Visible = False
        Pnl_BSide1.Visible = False
        PnlVacA.Visible = False
        PnlVacB.Visible = False

        'Check wich mold is selected and show accordingly (Top/Bot).
        If IsASide Then
            ' Get right title
            frmMain.lblTitle.Text = GetSingleLabel(101)
            Image.Image = My.Resources.Take_out_Aside_side
            strSide = "MoldA"
            Pnl_ASide1.Visible = True
            PnlVacA.Visible = True
        Else
            'Get right title
            frmMain.lblTitle.Text = GetSingleLabel(104)
            Image.Image = My.Resources.Take_out_Bside_side
            strSide = "MoldB"
            Pnl_BSide1.Visible = True
            PnlVacB.Visible = True
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

    Private Sub checkVacuum()

        If IsASide Then
            AVac1.Visible = Vac1En.Data
            Avac2.Visible = Vac2En.Data
            AVac3.Visible = Vac3En.Data
            Avac4.Visible = Vac4En.Data
            Avac5.Visible = Vac5En.Data
            Avac6.Visible = Vac6En.Data

            ' binding to the a side controls.
            Vac1Ok.BindControl = AVac1
            Vac2Ok.BindControl = Avac2
            Vac3Ok.BindControl = AVac3
            Vac4Ok.BindControl = Avac4
            Vac5Ok.BindControl = Avac5
            Vac6Ok.BindControl = Avac6
        Else
            Bvac1.Visible = Vac1En.Data
            BVac2.Visible = Vac2En.Data
            Bvac3.Visible = Vac3En.Data
            BVac4.Visible = Vac4En.Data
            BVac5.Visible = Vac5En.Data
            BVac6.Visible = Vac6En.Data

            ' binding to the b side controls.
            Vac1Ok.BindControl = Bvac1
            Vac2Ok.BindControl = BVac2
            Vac3Ok.BindControl = Bvac3
            Vac4Ok.BindControl = BVac4
            Vac5Ok.BindControl = BVac5
            Vac6Ok.BindControl = BVac6
        End If


    End Sub

    Private Sub TakeOutUnitA_Overview_ParentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ParentChanged
        If Not Me.Parent Is Nothing Then

            'init the language for the labels
            InitControls()

            GetControlLabel(Me.Controls)

            'connect the PLC to the mainfrom plc
            KrConnector.PLC = frmMain.CX1020
            KrConnector.VarCollector = Me.VarCollector
            KrConnector.Connect()

            checkVacuum()
        Else
            KrConnector.Disconnect()

            For Each krVar As KremerVariable In VarCollector.Variables
                krVar.VariableName = krVar.VariableName.Replace(strSide, "[Position1]")
            Next
        End If
    End Sub

    Private Sub Btn_Settings_Click(sender As Object, e As EventArgs) Handles Btn_Settings.Click
        frmMain.SubTakeOutUnit_Settings.IsASide = IsASide
        frmMain.SubFormChange(frmMain.SubTakeOutUnit_Settings, True)
    End Sub

    Private Sub Btn_Manual_Click(sender As Object, e As EventArgs) Handles Btn_Manual.Click
        frmMain.SubTakeOutUnit_Manual.IsASide = IsASide
        frmMain.SubFormChange(frmMain.SubTakeOutUnit_Manual, True)
    End Sub

    Private Sub Va1Ok_DataChanged(sender As Object, e As EventArgs) Handles Vac1Ok.DataChanged, Vac2Ok.DataChanged, Vac3Ok.DataChanged, Vac4Ok.DataChanged, Vac5Ok.DataChanged, Vac6Ok.DataChanged
        checkVacuum()
    End Sub

    Private Sub mxAutomode_DataChanged(sender As Object, e As EventArgs) Handles mxAutomode.DataChanged
        Btn_Manual.Enabled = Not mxAutomode.Data
    End Sub

End Class
