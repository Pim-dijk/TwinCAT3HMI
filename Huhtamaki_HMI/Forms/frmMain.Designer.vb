<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.txtHeader = New System.Windows.Forms.TextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.tmrWatch = New System.Windows.Forms.Timer(Me.components)
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.pnlSub = New System.Windows.Forms.Panel()
        Me.krConnector = New TwincatControlWin32.KremerConnector(Me.components)
        Me.CX1020 = New TwincatControlWin32.KremerPLC(Me.components)
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.btnGeneral = New KremerControlsWin32.KremerButton()
        Me.Btn_Service = New KremerControlsWin32.KremerButton()
        Me.btnInit = New KremerControlsWin32.KremerButton()
        Me.Btn_Reset = New KremerControlsWin32.KremerButton()
        Me.BtnSettings = New KremerControlsWin32.KremerButton()
        Me.btnProduct = New KremerControlsWin32.KremerButton()
        Me.krAlarmView = New KremerControlsWin32.KremerAlarmViewer()
        Me.krAlarmData = New KremerControlsWin32.KremerAlarmDataCollector()
        Me.grpMain = New KremerControlsWin32.KremerAlarmGroup()
        Me.grpZipper = New KremerControlsWin32.KremerAlarmGroup()
        Me.grpBBT = New KremerControlsWin32.KremerAlarmGroup()
        Me.grpDenester = New KremerControlsWin32.KremerAlarmGroup()
        Me.grpOutfeed = New KremerControlsWin32.KremerAlarmGroup()
        Me.grpGeneral = New KremerControlsWin32.KremerAlarmGroup()
        Me.grpPress = New KremerControlsWin32.KremerAlarmGroup()
        Me.grpPrinter = New KremerControlsWin32.KremerAlarmGroup()
        Me.grpBTU = New KremerControlsWin32.KremerAlarmGroup()
        Me.grpSafetyIO = New KremerControlsWin32.KremerAlarmGroup()
        Me.ReasonForStop = New KremerControlsWin32.KremerAlarmType(Me.components)
        Me.SafetyMessage = New KremerControlsWin32.KremerAlarmType(Me.components)
        Me.DriveError = New KremerControlsWin32.KremerAlarmType(Me.components)
        Me.OtherMessages = New KremerControlsWin32.KremerAlarmType(Me.components)
        Me.Mechanical = New KremerControlsWin32.KremerAlarmType(Me.components)
        Me.KremerAlarmWord1 = New KremerControlsWin32.KremerAlarmWord()
        Me.KremerAlarmWord2 = New KremerControlsWin32.KremerAlarmWord()
        Me.KremerAlarmWord3 = New KremerControlsWin32.KremerAlarmWord()
        Me.KremerAlarmWord4 = New KremerControlsWin32.KremerAlarmWord()
        Me.KremerAlarmWord5 = New KremerControlsWin32.KremerAlarmWord()
        Me.KremerAlarmWord6 = New KremerControlsWin32.KremerAlarmWord()
        Me.KremerAlarmWord7 = New KremerControlsWin32.KremerAlarmWord()
        Me.KremerAlarmWord8 = New KremerControlsWin32.KremerAlarmWord()
        Me.KremerAlarmWord9 = New KremerControlsWin32.KremerAlarmWord()
        Me.KremerAlarmWord10 = New KremerControlsWin32.KremerAlarmWord()
        Me.KremerAlarmWord11 = New KremerControlsWin32.KremerAlarmWord()
        Me.KremerAlarmWord12 = New KremerControlsWin32.KremerAlarmWord()
        Me.KremerAlarmWord13 = New KremerControlsWin32.KremerAlarmWord()
        Me.KremerAlarmWord14 = New KremerControlsWin32.KremerAlarmWord()
        Me.KremerAlarmWord15 = New KremerControlsWin32.KremerAlarmWord()
        Me.KremerAlarmWord16 = New KremerControlsWin32.KremerAlarmWord()
        Me.KremerAlarmWord17 = New KremerControlsWin32.KremerAlarmWord()
        Me.KremerAlarmWord18 = New KremerControlsWin32.KremerAlarmWord()
        Me.KremerAlarmWord19 = New KremerControlsWin32.KremerAlarmWord()
        Me.KremerAlarmWord20 = New KremerControlsWin32.KremerAlarmWord()
        Me.btnAlarms = New KremerControlsWin32.KremerButton()
        Me.BtnOverview = New KremerControlsWin32.KremerButton()
        Me.krVarCollector = New KremerControlsWin32.KremerVariableCollector(Me.components)
        Me.sUserName = New KremerControlsWin32.KremerVariable(Me.components)
        Me.miUserLevel = New KremerControlsWin32.KremerVariable(Me.components)
        Me.mxManualAutomode = New KremerControlsWin32.KremerVariable(Me.components)
        Me.mxProduktDataLoaded = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AlarmWord1 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AlarmWord2 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AlarmWord3 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AlarmWord4 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AlarmWord5 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AlarmWord6 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AlarmWord7 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AlarmWord8 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AlarmWord9 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AlarmWord10 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AlarmWord11 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AlarmWord12 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AlarmWord13 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AlarmWord14 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AlarmWord15 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AlarmWord16 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AlarmWord17 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AlarmWord18 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AlarmWord19 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AlarmWord20 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.hmiReset = New KremerControlsWin32.KremerVariable(Me.components)
        Me.GodMode = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Channel1 = New KremerControlsWin32.KremerLogItem()
        Me.Channel2 = New KremerControlsWin32.KremerLogItem()
        Me.KremerAlarmLogDB = New KremerControlsWin32.KremerAlarmLogDB(Me.components)
        Me.TxtGodMode = New System.Windows.Forms.TextBox()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtHeader
        '
        Me.txtHeader.AcceptsTab = True
        Me.txtHeader.BackColor = System.Drawing.Color.White
        Me.txtHeader.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHeader.Location = New System.Drawing.Point(0, 53)
        Me.txtHeader.Multiline = True
        Me.txtHeader.Name = "txtHeader"
        Me.txtHeader.ReadOnly = True
        Me.txtHeader.Size = New System.Drawing.Size(800, 60)
        Me.txtHeader.TabIndex = 16
        Me.txtHeader.TabStop = False
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.White
        Me.lblDate.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblDate.Location = New System.Drawing.Point(4, 88)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(135, 18)
        Me.lblDate.TabIndex = 0
        Me.lblDate.Text = "1-1-2016"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tmrWatch
        '
        Me.tmrWatch.Enabled = True
        Me.tmrWatch.Interval = 115
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.White
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(302, 67)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(362, 30)
        Me.lblTitle.TabIndex = 30
        Me.lblTitle.Text = "Screen Title"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(151, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 18)
        Me.Label1.TabIndex = 28
        Me.Label1.Tag = "10"
        Me.Label1.Text = "Access level:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(151, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 18)
        Me.Label2.TabIndex = 29
        Me.Label2.Tag = "9"
        Me.Label2.Text = "Logged in:"
        '
        'lblLevel
        '
        Me.lblLevel.BackColor = System.Drawing.Color.White
        Me.lblLevel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblLevel.Location = New System.Drawing.Point(230, 85)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(85, 18)
        Me.lblLevel.TabIndex = 26
        Me.lblLevel.Text = "0"
        '
        'lblUser
        '
        Me.lblUser.BackColor = System.Drawing.Color.White
        Me.lblUser.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblUser.Location = New System.Drawing.Point(230, 66)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(85, 18)
        Me.lblUser.TabIndex = 27
        Me.lblUser.Text = "NONE"
        '
        'pnlSub
        '
        Me.pnlSub.BackColor = System.Drawing.SystemColors.Control
        Me.pnlSub.Location = New System.Drawing.Point(0, 114)
        Me.pnlSub.Name = "pnlSub"
        Me.pnlSub.Size = New System.Drawing.Size(800, 435)
        Me.pnlSub.TabIndex = 25
        '
        'krConnector
        '
        Me.krConnector.VarCollector = Nothing
        '
        'CX1020
        '
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.White
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(2, 59)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(137, 28)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picLogo.TabIndex = 24
        Me.picLogo.TabStop = False
        '
        'btnGeneral
        '
        Me.btnGeneral.Audit = Nothing
        Me.btnGeneral.AuditEnabled = False
        Me.btnGeneral.AuditMessage = "KremerPushButton pressed!"
        Me.btnGeneral.AuditSource = "KremerPushButton"
        Me.btnGeneral.BackColor = System.Drawing.SystemColors.Control
        Me.btnGeneral.BackColorOn = System.Drawing.Color.Empty
        Me.btnGeneral.BackGroundImageOn = Nothing
        Me.btnGeneral.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.btnGeneral.Data = False
        Me.btnGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGeneral.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnGeneral.ForeColorOn = System.Drawing.Color.Empty
        Me.btnGeneral.Location = New System.Drawing.Point(685, 550)
        Me.btnGeneral.Name = "btnGeneral"
        Me.btnGeneral.Size = New System.Drawing.Size(114, 50)
        Me.btnGeneral.State = False
        Me.btnGeneral.StateIsData = True
        Me.btnGeneral.StateText = New String() {Nothing, Nothing}
        Me.btnGeneral.TabIndex = 14
        Me.btnGeneral.Tag = "6"
        Me.btnGeneral.Text = " GENERAL"
        Me.btnGeneral.UserInfo = Nothing
        Me.btnGeneral.UserLevel = 0
        Me.btnGeneral.UseStateText = False
        Me.btnGeneral.UseVisualStyleBackColor = False
        '
        'Btn_Service
        '
        Me.Btn_Service.Audit = Nothing
        Me.Btn_Service.AuditEnabled = False
        Me.Btn_Service.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_Service.AuditSource = "KremerPushButton"
        Me.Btn_Service.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_Service.BackColorOn = System.Drawing.SystemColors.Control
        Me.Btn_Service.BackGroundImageOn = Nothing
        Me.Btn_Service.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.Btn_Service.Data = False
        Me.Btn_Service.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Service.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Service.ForeColorOn = System.Drawing.SystemColors.ControlText
        Me.Btn_Service.Location = New System.Drawing.Point(343, 550)
        Me.Btn_Service.Name = "Btn_Service"
        Me.Btn_Service.Size = New System.Drawing.Size(114, 50)
        Me.Btn_Service.State = False
        Me.Btn_Service.StateIsData = True
        Me.Btn_Service.StateText = New String() {Nothing, Nothing}
        Me.Btn_Service.TabIndex = 32
        Me.Btn_Service.Tag = "51"
        Me.Btn_Service.Text = "SERVICE"
        Me.Btn_Service.UserInfo = Nothing
        Me.Btn_Service.UserLevel = 500
        Me.Btn_Service.UseStateText = False
        Me.Btn_Service.UseVisualStyleBackColor = False
        '
        'btnInit
        '
        Me.btnInit.Audit = Nothing
        Me.btnInit.AuditEnabled = False
        Me.btnInit.AuditMessage = "KremerPushButton pressed!"
        Me.btnInit.AuditSource = "KremerPushButton"
        Me.btnInit.BackColor = System.Drawing.SystemColors.Control
        Me.btnInit.BackColorOn = System.Drawing.Color.White
        Me.btnInit.BackGroundImageOn = Nothing
        Me.btnInit.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.btnInit.Data = False
        Me.btnInit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInit.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnInit.ForeColorOn = System.Drawing.Color.Black
        Me.btnInit.Location = New System.Drawing.Point(115, 550)
        Me.btnInit.Name = "btnInit"
        Me.btnInit.Size = New System.Drawing.Size(114, 50)
        Me.btnInit.State = False
        Me.btnInit.StateIsData = False
        Me.btnInit.StateText = New String() {Nothing, Nothing}
        Me.btnInit.TabIndex = 283
        Me.btnInit.Tag = "3"
        Me.btnInit.Text = "INIT"
        Me.btnInit.UserInfo = Nothing
        Me.btnInit.UserLevel = 0
        Me.btnInit.UseStateText = False
        Me.btnInit.UseVisualStyleBackColor = False
        '
        'Btn_Reset
        '
        Me.Btn_Reset.Audit = Nothing
        Me.Btn_Reset.AuditEnabled = False
        Me.Btn_Reset.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_Reset.AuditSource = "KremerPushButton"
        Me.Btn_Reset.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_Reset.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Reset.BackGroundImageOn = Nothing
        Me.Btn_Reset.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.Btn_Reset.Data = False
        Me.Btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Reset.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Reset.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Btn_Reset.ForeColorOn = System.Drawing.Color.Yellow
        Me.Btn_Reset.Location = New System.Drawing.Point(666, 69)
        Me.Btn_Reset.Name = "Btn_Reset"
        Me.Btn_Reset.Size = New System.Drawing.Size(125, 37)
        Me.Btn_Reset.State = False
        Me.Btn_Reset.StateIsData = False
        Me.Btn_Reset.StateText = New String() {Nothing, Nothing}
        Me.Btn_Reset.TabIndex = 31
        Me.Btn_Reset.Tag = "12"
        Me.Btn_Reset.Text = "RESET"
        Me.Btn_Reset.UserInfo = Nothing
        Me.Btn_Reset.UserLevel = 0
        Me.Btn_Reset.UseStateText = False
        Me.Btn_Reset.UseVisualStyleBackColor = False
        '
        'BtnSettings
        '
        Me.BtnSettings.Audit = Nothing
        Me.BtnSettings.AuditEnabled = False
        Me.BtnSettings.AuditMessage = "KremerPushButton pressed!"
        Me.BtnSettings.AuditSource = "KremerPushButton"
        Me.BtnSettings.BackColor = System.Drawing.SystemColors.Control
        Me.BtnSettings.BackColorOn = System.Drawing.Color.Empty
        Me.BtnSettings.BackGroundImageOn = Nothing
        Me.BtnSettings.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.BtnSettings.Data = False
        Me.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSettings.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSettings.ForeColorOn = System.Drawing.Color.Empty
        Me.BtnSettings.Location = New System.Drawing.Point(571, 550)
        Me.BtnSettings.Name = "BtnSettings"
        Me.BtnSettings.Size = New System.Drawing.Size(114, 50)
        Me.BtnSettings.State = False
        Me.BtnSettings.StateIsData = True
        Me.BtnSettings.StateText = New String() {Nothing, Nothing}
        Me.BtnSettings.TabIndex = 33
        Me.BtnSettings.Tag = "4"
        Me.BtnSettings.Text = "SETTINGS"
        Me.BtnSettings.UserInfo = Nothing
        Me.BtnSettings.UserLevel = 0
        Me.BtnSettings.UseStateText = False
        Me.BtnSettings.UseVisualStyleBackColor = False
        '
        'btnProduct
        '
        Me.btnProduct.Audit = Nothing
        Me.btnProduct.AuditEnabled = False
        Me.btnProduct.AuditMessage = "KremerPushButton pressed!"
        Me.btnProduct.AuditSource = "KremerPushButton"
        Me.btnProduct.BackColor = System.Drawing.SystemColors.Control
        Me.btnProduct.BackColorOn = System.Drawing.Color.Empty
        Me.btnProduct.BackGroundImageOn = Nothing
        Me.btnProduct.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.btnProduct.Data = False
        Me.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProduct.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnProduct.ForeColorOn = System.Drawing.Color.Empty
        Me.btnProduct.Location = New System.Drawing.Point(457, 550)
        Me.btnProduct.Name = "btnProduct"
        Me.btnProduct.Size = New System.Drawing.Size(114, 50)
        Me.btnProduct.State = False
        Me.btnProduct.StateIsData = True
        Me.btnProduct.StateText = New String() {Nothing, Nothing}
        Me.btnProduct.TabIndex = 13
        Me.btnProduct.Tag = "5"
        Me.btnProduct.Text = "PRODUCT"
        Me.btnProduct.UserInfo = Nothing
        Me.btnProduct.UserLevel = 0
        Me.btnProduct.UseStateText = False
        Me.btnProduct.UseVisualStyleBackColor = False
        '
        'krAlarmView
        '
        Me.krAlarmView.AlarmData = Me.krAlarmData
        Me.krAlarmView.ColumnGroupWidth = 100
        Me.krAlarmView.ColumnIdWidth = 40
        Me.krAlarmView.ColumnTimestampWidth = 160
        Me.krAlarmView.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.krAlarmView.GroupFilter = Nothing
        Me.krAlarmView.GroupVisible = True
        Me.krAlarmView.Location = New System.Drawing.Point(0, 0)
        Me.krAlarmView.Name = "krAlarmView"
        Me.krAlarmView.SelectRow = False
        Me.krAlarmView.Size = New System.Drawing.Size(800, 62)
        Me.krAlarmView.SortOrderString = "KremerAlarmTypes, TimeStamp DESC"
        Me.krAlarmView.TabIndex = 0
        '
        'krAlarmData
        '
        Me.krAlarmData.AlarmGroups.Add(Me.grpMain)
        Me.krAlarmData.AlarmGroups.Add(Me.grpZipper)
        Me.krAlarmData.AlarmGroups.Add(Me.grpBBT)
        Me.krAlarmData.AlarmGroups.Add(Me.grpDenester)
        Me.krAlarmData.AlarmGroups.Add(Me.grpOutfeed)
        Me.krAlarmData.AlarmGroups.Add(Me.grpGeneral)
        Me.krAlarmData.AlarmGroups.Add(Me.grpPress)
        Me.krAlarmData.AlarmGroups.Add(Me.grpPrinter)
        Me.krAlarmData.AlarmGroups.Add(Me.grpBTU)
        Me.krAlarmData.AlarmGroups.Add(Me.grpSafetyIO)
        Me.krAlarmData.AlarmTypes.Add(Me.ReasonForStop)
        Me.krAlarmData.AlarmTypes.Add(Me.SafetyMessage)
        Me.krAlarmData.AlarmTypes.Add(Me.DriveError)
        Me.krAlarmData.AlarmTypes.Add(Me.OtherMessages)
        Me.krAlarmData.AlarmTypes.Add(Me.Mechanical)
        Me.krAlarmData.AlarmWords.Add(Me.KremerAlarmWord1)
        Me.krAlarmData.AlarmWords.Add(Me.KremerAlarmWord2)
        Me.krAlarmData.AlarmWords.Add(Me.KremerAlarmWord3)
        Me.krAlarmData.AlarmWords.Add(Me.KremerAlarmWord4)
        Me.krAlarmData.AlarmWords.Add(Me.KremerAlarmWord5)
        Me.krAlarmData.AlarmWords.Add(Me.KremerAlarmWord6)
        Me.krAlarmData.AlarmWords.Add(Me.KremerAlarmWord7)
        Me.krAlarmData.AlarmWords.Add(Me.KremerAlarmWord8)
        Me.krAlarmData.AlarmWords.Add(Me.KremerAlarmWord9)
        Me.krAlarmData.AlarmWords.Add(Me.KremerAlarmWord10)
        Me.krAlarmData.AlarmWords.Add(Me.KremerAlarmWord11)
        Me.krAlarmData.AlarmWords.Add(Me.KremerAlarmWord12)
        Me.krAlarmData.AlarmWords.Add(Me.KremerAlarmWord13)
        Me.krAlarmData.AlarmWords.Add(Me.KremerAlarmWord14)
        Me.krAlarmData.AlarmWords.Add(Me.KremerAlarmWord15)
        Me.krAlarmData.AlarmWords.Add(Me.KremerAlarmWord16)
        Me.krAlarmData.AlarmWords.Add(Me.KremerAlarmWord17)
        Me.krAlarmData.AlarmWords.Add(Me.KremerAlarmWord18)
        Me.krAlarmData.AlarmWords.Add(Me.KremerAlarmWord19)
        Me.krAlarmData.AlarmWords.Add(Me.KremerAlarmWord20)
        '
        'grpMain
        '
        Me.grpMain.Tag = 84
        Me.grpMain.Text = "Main"
        '
        'grpZipper
        '
        Me.grpZipper.Tag = 85
        Me.grpZipper.Text = "Zipper"
        '
        'grpBBT
        '
        Me.grpBBT.Tag = 86
        Me.grpBBT.Text = "BBT"
        '
        'grpDenester
        '
        Me.grpDenester.Tag = 87
        Me.grpDenester.Text = "Denester"
        '
        'grpOutfeed
        '
        Me.grpOutfeed.Tag = 88
        Me.grpOutfeed.Text = "Outfeed"
        '
        'grpGeneral
        '
        Me.grpGeneral.Tag = 89
        Me.grpGeneral.Text = "General"
        '
        'grpPress
        '
        Me.grpPress.Tag = 98
        Me.grpPress.Text = "Press"
        '
        'grpPrinter
        '
        Me.grpPrinter.Tag = 99
        Me.grpPrinter.Text = "Printer"
        '
        'grpBTU
        '
        Me.grpBTU.Tag = 184
        Me.grpBTU.Text = "BTU"
        '
        'grpSafetyIO
        '
        Me.grpSafetyIO.Tag = 349
        Me.grpSafetyIO.Text = "SafetyIO"
        '
        'ReasonForStop
        '
        Me.ReasonForStop.BackColor = System.Drawing.Color.Yellow
        Me.ReasonForStop.ForeColor = System.Drawing.Color.Red
        Me.ReasonForStop.TypeNr = 0
        '
        'SafetyMessage
        '
        Me.SafetyMessage.BackColor = System.Drawing.Color.White
        Me.SafetyMessage.ForeColor = System.Drawing.Color.Red
        Me.SafetyMessage.TypeNr = 1
        '
        'DriveError
        '
        Me.DriveError.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DriveError.ForeColor = System.Drawing.Color.Black
        Me.DriveError.TypeNr = 2
        '
        'OtherMessages
        '
        Me.OtherMessages.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.OtherMessages.ForeColor = System.Drawing.Color.Black
        Me.OtherMessages.TypeNr = 3
        '
        'Mechanical
        '
        Me.Mechanical.BackColor = System.Drawing.Color.LightGray
        Me.Mechanical.ForeColor = System.Drawing.Color.Black
        Me.Mechanical.TypeNr = 4
        '
        'KremerAlarmWord1
        '
        Me.KremerAlarmWord1.AlarmBeginNr = 1
        Me.KremerAlarmWord1.Data = 0
        Me.KremerAlarmWord1.Group = Me.grpMain
        Me.KremerAlarmWord1.KremerAlarmTypes = New KremerControlsWin32.KremerAlarmType() {Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage}
        '
        'KremerAlarmWord2
        '
        Me.KremerAlarmWord2.AlarmBeginNr = 33
        Me.KremerAlarmWord2.Data = 0
        Me.KremerAlarmWord2.Group = Me.grpMain
        Me.KremerAlarmWord2.KremerAlarmTypes = New KremerControlsWin32.KremerAlarmType() {Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage}
        '
        'KremerAlarmWord3
        '
        Me.KremerAlarmWord3.AlarmBeginNr = 65
        Me.KremerAlarmWord3.Data = 0
        Me.KremerAlarmWord3.Group = Me.grpMain
        Me.KremerAlarmWord3.KremerAlarmTypes = New KremerControlsWin32.KremerAlarmType() {Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage}
        '
        'KremerAlarmWord4
        '
        Me.KremerAlarmWord4.AlarmBeginNr = 97
        Me.KremerAlarmWord4.Data = 0
        Me.KremerAlarmWord4.Group = Me.grpMain
        Me.KremerAlarmWord4.KremerAlarmTypes = New KremerControlsWin32.KremerAlarmType() {Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage}
        '
        'KremerAlarmWord5
        '
        Me.KremerAlarmWord5.AlarmBeginNr = 129
        Me.KremerAlarmWord5.Data = 0
        Me.KremerAlarmWord5.Group = Me.grpMain
        Me.KremerAlarmWord5.KremerAlarmTypes = New KremerControlsWin32.KremerAlarmType() {Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage}
        '
        'KremerAlarmWord6
        '
        Me.KremerAlarmWord6.AlarmBeginNr = 161
        Me.KremerAlarmWord6.Data = 0
        Me.KremerAlarmWord6.Group = Me.grpMain
        Me.KremerAlarmWord6.KremerAlarmTypes = New KremerControlsWin32.KremerAlarmType() {Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage}
        '
        'KremerAlarmWord7
        '
        Me.KremerAlarmWord7.AlarmBeginNr = 193
        Me.KremerAlarmWord7.Data = 0
        Me.KremerAlarmWord7.Group = Me.grpMain
        Me.KremerAlarmWord7.KremerAlarmTypes = New KremerControlsWin32.KremerAlarmType() {Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage}
        '
        'KremerAlarmWord8
        '
        Me.KremerAlarmWord8.AlarmBeginNr = 225
        Me.KremerAlarmWord8.Data = 0
        Me.KremerAlarmWord8.Group = Me.grpMain
        Me.KremerAlarmWord8.KremerAlarmTypes = New KremerControlsWin32.KremerAlarmType() {Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage}
        '
        'KremerAlarmWord9
        '
        Me.KremerAlarmWord9.AlarmBeginNr = 257
        Me.KremerAlarmWord9.Data = 0
        Me.KremerAlarmWord9.Group = Me.grpMain
        Me.KremerAlarmWord9.KremerAlarmTypes = New KremerControlsWin32.KremerAlarmType() {Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage}
        '
        'KremerAlarmWord10
        '
        Me.KremerAlarmWord10.AlarmBeginNr = 289
        Me.KremerAlarmWord10.Data = 0
        Me.KremerAlarmWord10.Group = Me.grpMain
        Me.KremerAlarmWord10.KremerAlarmTypes = New KremerControlsWin32.KremerAlarmType() {Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage}
        '
        'KremerAlarmWord11
        '
        Me.KremerAlarmWord11.AlarmBeginNr = 321
        Me.KremerAlarmWord11.Data = 0
        Me.KremerAlarmWord11.Group = Me.grpMain
        Me.KremerAlarmWord11.KremerAlarmTypes = New KremerControlsWin32.KremerAlarmType() {Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage}
        '
        'KremerAlarmWord12
        '
        Me.KremerAlarmWord12.AlarmBeginNr = 353
        Me.KremerAlarmWord12.Data = 0
        Me.KremerAlarmWord12.Group = Me.grpMain
        Me.KremerAlarmWord12.KremerAlarmTypes = New KremerControlsWin32.KremerAlarmType() {Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage}
        '
        'KremerAlarmWord13
        '
        Me.KremerAlarmWord13.AlarmBeginNr = 385
        Me.KremerAlarmWord13.Data = 0
        Me.KremerAlarmWord13.Group = Me.grpMain
        Me.KremerAlarmWord13.KremerAlarmTypes = New KremerControlsWin32.KremerAlarmType() {Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage}
        '
        'KremerAlarmWord14
        '
        Me.KremerAlarmWord14.AlarmBeginNr = 417
        Me.KremerAlarmWord14.Data = 0
        Me.KremerAlarmWord14.Group = Me.grpMain
        Me.KremerAlarmWord14.KremerAlarmTypes = New KremerControlsWin32.KremerAlarmType() {Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage}
        '
        'KremerAlarmWord15
        '
        Me.KremerAlarmWord15.AlarmBeginNr = 449
        Me.KremerAlarmWord15.Data = 0
        Me.KremerAlarmWord15.Group = Me.grpMain
        Me.KremerAlarmWord15.KremerAlarmTypes = New KremerControlsWin32.KremerAlarmType() {Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage}
        '
        'KremerAlarmWord16
        '
        Me.KremerAlarmWord16.AlarmBeginNr = 481
        Me.KremerAlarmWord16.Data = 0
        Me.KremerAlarmWord16.Group = Me.grpMain
        Me.KremerAlarmWord16.KremerAlarmTypes = New KremerControlsWin32.KremerAlarmType() {Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage}
        '
        'KremerAlarmWord17
        '
        Me.KremerAlarmWord17.AlarmBeginNr = 513
        Me.KremerAlarmWord17.Data = 0
        Me.KremerAlarmWord17.Group = Me.grpMain
        Me.KremerAlarmWord17.KremerAlarmTypes = New KremerControlsWin32.KremerAlarmType() {Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage}
        '
        'KremerAlarmWord18
        '
        Me.KremerAlarmWord18.AlarmBeginNr = 545
        Me.KremerAlarmWord18.Data = 0
        Me.KremerAlarmWord18.Group = Me.grpMain
        Me.KremerAlarmWord18.KremerAlarmTypes = New KremerControlsWin32.KremerAlarmType() {Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage}
        '
        'KremerAlarmWord19
        '
        Me.KremerAlarmWord19.AlarmBeginNr = 577
        Me.KremerAlarmWord19.Data = 0
        Me.KremerAlarmWord19.Group = Me.grpMain
        Me.KremerAlarmWord19.KremerAlarmTypes = New KremerControlsWin32.KremerAlarmType() {Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage}
        '
        'KremerAlarmWord20
        '
        Me.KremerAlarmWord20.AlarmBeginNr = 609
        Me.KremerAlarmWord20.Data = 0
        Me.KremerAlarmWord20.Group = Me.grpMain
        Me.KremerAlarmWord20.KremerAlarmTypes = New KremerControlsWin32.KremerAlarmType() {Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage, Me.SafetyMessage}
        '
        'btnAlarms
        '
        Me.btnAlarms.Audit = Nothing
        Me.btnAlarms.AuditEnabled = False
        Me.btnAlarms.AuditMessage = "KremerPushButton pressed!"
        Me.btnAlarms.AuditSource = "KremerPushButton"
        Me.btnAlarms.BackColor = System.Drawing.SystemColors.Control
        Me.btnAlarms.BackColorOn = System.Drawing.Color.Empty
        Me.btnAlarms.BackGroundImageOn = Nothing
        Me.btnAlarms.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.btnAlarms.Data = False
        Me.btnAlarms.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlarms.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAlarms.ForeColorOn = System.Drawing.Color.Empty
        Me.btnAlarms.Location = New System.Drawing.Point(229, 550)
        Me.btnAlarms.Name = "btnAlarms"
        Me.btnAlarms.Size = New System.Drawing.Size(114, 50)
        Me.btnAlarms.State = False
        Me.btnAlarms.StateIsData = True
        Me.btnAlarms.StateText = New String() {Nothing, Nothing}
        Me.btnAlarms.TabIndex = 23
        Me.btnAlarms.Tag = "66"
        Me.btnAlarms.Text = "ALARMS"
        Me.btnAlarms.UserInfo = Nothing
        Me.btnAlarms.UserLevel = 0
        Me.btnAlarms.UseStateText = False
        Me.btnAlarms.UseVisualStyleBackColor = False
        '
        'BtnOverview
        '
        Me.BtnOverview.Audit = Nothing
        Me.BtnOverview.AuditEnabled = False
        Me.BtnOverview.AuditMessage = "KremerPushButton pressed!"
        Me.BtnOverview.AuditSource = "KremerPushButton"
        Me.BtnOverview.BackColor = System.Drawing.SystemColors.Control
        Me.BtnOverview.BackColorOn = System.Drawing.SystemColors.Control
        Me.BtnOverview.BackGroundImageOn = Nothing
        Me.BtnOverview.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.BtnOverview.Data = False
        Me.BtnOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOverview.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnOverview.ForeColorOn = System.Drawing.SystemColors.ControlText
        Me.BtnOverview.Location = New System.Drawing.Point(1, 550)
        Me.BtnOverview.Name = "BtnOverview"
        Me.BtnOverview.Size = New System.Drawing.Size(114, 50)
        Me.BtnOverview.State = False
        Me.BtnOverview.StateIsData = True
        Me.BtnOverview.StateText = New String() {Nothing, Nothing}
        Me.BtnOverview.TabIndex = 14
        Me.BtnOverview.Tag = ""
        Me.BtnOverview.Text = "OVERVIEW"
        Me.BtnOverview.UserInfo = Nothing
        Me.BtnOverview.UserLevel = 0
        Me.BtnOverview.UseStateText = False
        Me.BtnOverview.UseVisualStyleBackColor = False
        '
        'krVarCollector
        '
        Me.krVarCollector.Variables.Add(Me.sUserName)
        Me.krVarCollector.Variables.Add(Me.miUserLevel)
        Me.krVarCollector.Variables.Add(Me.mxManualAutomode)
        Me.krVarCollector.Variables.Add(Me.mxProduktDataLoaded)
        Me.krVarCollector.Variables.Add(Me.AlarmWord1)
        Me.krVarCollector.Variables.Add(Me.AlarmWord2)
        Me.krVarCollector.Variables.Add(Me.AlarmWord3)
        Me.krVarCollector.Variables.Add(Me.AlarmWord4)
        Me.krVarCollector.Variables.Add(Me.AlarmWord5)
        Me.krVarCollector.Variables.Add(Me.AlarmWord6)
        Me.krVarCollector.Variables.Add(Me.AlarmWord7)
        Me.krVarCollector.Variables.Add(Me.AlarmWord8)
        Me.krVarCollector.Variables.Add(Me.AlarmWord9)
        Me.krVarCollector.Variables.Add(Me.AlarmWord10)
        Me.krVarCollector.Variables.Add(Me.AlarmWord11)
        Me.krVarCollector.Variables.Add(Me.AlarmWord12)
        Me.krVarCollector.Variables.Add(Me.AlarmWord13)
        Me.krVarCollector.Variables.Add(Me.AlarmWord14)
        Me.krVarCollector.Variables.Add(Me.AlarmWord15)
        Me.krVarCollector.Variables.Add(Me.AlarmWord16)
        Me.krVarCollector.Variables.Add(Me.AlarmWord17)
        Me.krVarCollector.Variables.Add(Me.AlarmWord18)
        Me.krVarCollector.Variables.Add(Me.AlarmWord19)
        Me.krVarCollector.Variables.Add(Me.AlarmWord20)
        Me.krVarCollector.Variables.Add(Me.hmiReset)
        Me.krVarCollector.Variables.Add(Me.GodMode)
        '
        'sUserName
        '
        Me.sUserName.BindControl = Me.lblUser
        Me.sUserName.BindProperty = "Text"
        Me.sUserName.Data = Nothing
        Me.sUserName.DataType = KremerControlsWin32.KremerVariable.VarDataType.TEXT
        Me.sUserName.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.sUserName.VariableName = "HMI.sUserName"
        '
        'miUserLevel
        '
        Me.miUserLevel.BindControl = Me.lblLevel
        Me.miUserLevel.BindProperty = "Text"
        Me.miUserLevel.Data = Nothing
        Me.miUserLevel.DataType = KremerControlsWin32.KremerVariable.VarDataType.INT
        Me.miUserLevel.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.miUserLevel.VariableName = "HMI.miUserLevel"
        '
        'mxManualAutomode
        '
        Me.mxManualAutomode.BindControl = Nothing
        Me.mxManualAutomode.BindProperty = "Data"
        Me.mxManualAutomode.Data = Nothing
        Me.mxManualAutomode.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.mxManualAutomode.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.mxManualAutomode.VariableName = "MAIN.mxAutoMode"
        '
        'mxProduktDataLoaded
        '
        Me.mxProduktDataLoaded.BindControl = Nothing
        Me.mxProduktDataLoaded.BindProperty = Nothing
        Me.mxProduktDataLoaded.Data = Nothing
        Me.mxProduktDataLoaded.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.mxProduktDataLoaded.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.mxProduktDataLoaded.VariableName = "MAIN.mxProductLoaded"
        '
        'AlarmWord1
        '
        Me.AlarmWord1.BindControl = Nothing
        Me.AlarmWord1.BindProperty = "Data"
        Me.AlarmWord1.Data = Nothing
        Me.AlarmWord1.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.AlarmWord1.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.AlarmWord1.VariableName = "HMI.AlarmWord1"
        '
        'AlarmWord2
        '
        Me.AlarmWord2.BindControl = Nothing
        Me.AlarmWord2.BindProperty = "Data"
        Me.AlarmWord2.Data = Nothing
        Me.AlarmWord2.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.AlarmWord2.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.AlarmWord2.VariableName = "HMI.AlarmWord2"
        '
        'AlarmWord3
        '
        Me.AlarmWord3.BindControl = Nothing
        Me.AlarmWord3.BindProperty = "Data"
        Me.AlarmWord3.Data = Nothing
        Me.AlarmWord3.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.AlarmWord3.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.AlarmWord3.VariableName = "HMI.AlarmWord3"
        '
        'AlarmWord4
        '
        Me.AlarmWord4.BindControl = Nothing
        Me.AlarmWord4.BindProperty = "Data"
        Me.AlarmWord4.Data = Nothing
        Me.AlarmWord4.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.AlarmWord4.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.AlarmWord4.VariableName = "HMI.AlarmWord4"
        '
        'AlarmWord5
        '
        Me.AlarmWord5.BindControl = Nothing
        Me.AlarmWord5.BindProperty = "Data"
        Me.AlarmWord5.Data = Nothing
        Me.AlarmWord5.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.AlarmWord5.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.AlarmWord5.VariableName = "HMI.AlarmWord5"
        '
        'AlarmWord6
        '
        Me.AlarmWord6.BindControl = Nothing
        Me.AlarmWord6.BindProperty = "Data"
        Me.AlarmWord6.Data = Nothing
        Me.AlarmWord6.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.AlarmWord6.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.AlarmWord6.VariableName = "HMI.AlarmWord6"
        '
        'AlarmWord7
        '
        Me.AlarmWord7.BindControl = Nothing
        Me.AlarmWord7.BindProperty = "Data"
        Me.AlarmWord7.Data = Nothing
        Me.AlarmWord7.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.AlarmWord7.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.AlarmWord7.VariableName = "HMI.AlarmWord7"
        '
        'AlarmWord8
        '
        Me.AlarmWord8.BindControl = Nothing
        Me.AlarmWord8.BindProperty = "Data"
        Me.AlarmWord8.Data = Nothing
        Me.AlarmWord8.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.AlarmWord8.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.AlarmWord8.VariableName = "HMI.AlarmWord8"
        '
        'AlarmWord9
        '
        Me.AlarmWord9.BindControl = Nothing
        Me.AlarmWord9.BindProperty = "Data"
        Me.AlarmWord9.Data = Nothing
        Me.AlarmWord9.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.AlarmWord9.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.AlarmWord9.VariableName = "HMI.AlarmWord9"
        '
        'AlarmWord10
        '
        Me.AlarmWord10.BindControl = Nothing
        Me.AlarmWord10.BindProperty = "Data"
        Me.AlarmWord10.Data = Nothing
        Me.AlarmWord10.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.AlarmWord10.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.AlarmWord10.VariableName = "HMI.AlarmWord10"
        '
        'AlarmWord11
        '
        Me.AlarmWord11.BindControl = Nothing
        Me.AlarmWord11.BindProperty = "Data"
        Me.AlarmWord11.Data = Nothing
        Me.AlarmWord11.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.AlarmWord11.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.AlarmWord11.VariableName = "HMI.AlarmWord11"
        '
        'AlarmWord12
        '
        Me.AlarmWord12.BindControl = Nothing
        Me.AlarmWord12.BindProperty = "Data"
        Me.AlarmWord12.Data = Nothing
        Me.AlarmWord12.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.AlarmWord12.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.AlarmWord12.VariableName = "HMI.AlarmWord12"
        '
        'AlarmWord13
        '
        Me.AlarmWord13.BindControl = Nothing
        Me.AlarmWord13.BindProperty = "Data"
        Me.AlarmWord13.Data = Nothing
        Me.AlarmWord13.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.AlarmWord13.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.AlarmWord13.VariableName = "HMI.AlarmWord13"
        '
        'AlarmWord14
        '
        Me.AlarmWord14.BindControl = Nothing
        Me.AlarmWord14.BindProperty = "Data"
        Me.AlarmWord14.Data = Nothing
        Me.AlarmWord14.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.AlarmWord14.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.AlarmWord14.VariableName = "HMI.AlarmWord14"
        '
        'AlarmWord15
        '
        Me.AlarmWord15.BindControl = Nothing
        Me.AlarmWord15.BindProperty = "Data"
        Me.AlarmWord15.Data = Nothing
        Me.AlarmWord15.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.AlarmWord15.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.AlarmWord15.VariableName = "HMI.AlarmWord15"
        '
        'AlarmWord16
        '
        Me.AlarmWord16.BindControl = Nothing
        Me.AlarmWord16.BindProperty = "Data"
        Me.AlarmWord16.Data = Nothing
        Me.AlarmWord16.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.AlarmWord16.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.AlarmWord16.VariableName = "HMI.AlarmWord16"
        '
        'AlarmWord17
        '
        Me.AlarmWord17.BindControl = Nothing
        Me.AlarmWord17.BindProperty = "Data"
        Me.AlarmWord17.Data = Nothing
        Me.AlarmWord17.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.AlarmWord17.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.AlarmWord17.VariableName = "HMI.AlarmWord17"
        '
        'AlarmWord18
        '
        Me.AlarmWord18.BindControl = Nothing
        Me.AlarmWord18.BindProperty = "Data"
        Me.AlarmWord18.Data = Nothing
        Me.AlarmWord18.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.AlarmWord18.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.AlarmWord18.VariableName = "HMI.AlarmWord18"
        '
        'AlarmWord19
        '
        Me.AlarmWord19.BindControl = Nothing
        Me.AlarmWord19.BindProperty = "Data"
        Me.AlarmWord19.Data = Nothing
        Me.AlarmWord19.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.AlarmWord19.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.AlarmWord19.VariableName = "HMI.AlarmWord19"
        '
        'AlarmWord20
        '
        Me.AlarmWord20.BindControl = Nothing
        Me.AlarmWord20.BindProperty = "Data"
        Me.AlarmWord20.Data = Nothing
        Me.AlarmWord20.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.AlarmWord20.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.AlarmWord20.VariableName = "HMI.AlarmWord20"
        '
        'hmiReset
        '
        Me.hmiReset.BindControl = Me.Btn_Reset
        Me.hmiReset.BindProperty = "Data"
        Me.hmiReset.Data = Nothing
        Me.hmiReset.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.hmiReset.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.hmiReset.VariableName = "MAIN.mxHMI_Reset"
        '
        'GodMode
        '
        Me.GodMode.BindControl = Nothing
        Me.GodMode.BindProperty = "Data"
        Me.GodMode.Data = Nothing
        Me.GodMode.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.GodMode.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GodMode.VariableName = "MAIN.InMoldDrying.MachParameters.CommisioningMode"
        '
        'Channel1
        '
        Me.Channel1.MaxSamples = 100
        Me.Channel1.Tag = 0
        Me.Channel1.Text = "Channel1"
        Me.Channel1.Variable = Nothing
        '
        'Channel2
        '
        Me.Channel2.MaxSamples = 100
        Me.Channel2.Tag = 0
        Me.Channel2.Text = "Channel2"
        Me.Channel2.Variable = Nothing
        '
        'KremerAlarmLogDB
        '
        Me.KremerAlarmLogDB.AlarmData = Me.krAlarmData
        Me.KremerAlarmLogDB.BufferLength = 1024
        Me.KremerAlarmLogDB.DaysBeforeArchiving = 7
        Me.KremerAlarmLogDB.DaysBeforeDelRowFromArchive = 365
        Me.KremerAlarmLogDB.MaximumNrOfRowsArchived = 15
        '
        '
        '
        Me.KremerAlarmLogDB.SqlServerConnection.Database = "ALZP"
        Me.KremerAlarmLogDB.SqlServerConnection.MachineName = "ZP71"
        Me.KremerAlarmLogDB.SqlServerConnection.Password = "#ALZP01"
        Me.KremerAlarmLogDB.SqlServerConnection.Server = "GBLUR-LUNA"
        Me.KremerAlarmLogDB.SqlServerConnection.Tablename = "AL_ZP71"
        Me.KremerAlarmLogDB.SqlServerConnection.Username = "ALZP"
        '
        'TxtGodMode
        '
        Me.TxtGodMode.AcceptsTab = True
        Me.TxtGodMode.BackColor = System.Drawing.Color.Gold
        Me.TxtGodMode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtGodMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGodMode.ForeColor = System.Drawing.Color.Maroon
        Me.TxtGodMode.Location = New System.Drawing.Point(274, 94)
        Me.TxtGodMode.Multiline = True
        Me.TxtGodMode.Name = "TxtGodMode"
        Me.TxtGodMode.ReadOnly = True
        Me.TxtGodMode.Size = New System.Drawing.Size(386, 20)
        Me.TxtGodMode.TabIndex = 284
        Me.TxtGodMode.TabStop = False
        Me.TxtGodMode.Text = "GodMode / commisioningMode active"
        Me.TxtGodMode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.TxtGodMode)
        Me.Controls.Add(Me.btnGeneral)
        Me.Controls.Add(Me.Btn_Service)
        Me.Controls.Add(Me.btnInit)
        Me.Controls.Add(Me.Btn_Reset)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.BtnSettings)
        Me.Controls.Add(Me.btnProduct)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.krAlarmView)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.pnlSub)
        Me.Controls.Add(Me.lblLevel)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtHeader)
        Me.Controls.Add(Me.btnAlarms)
        Me.Controls.Add(Me.BtnOverview)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KREMER HMI"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnProduct As KremerControlsWin32.KremerButton
    Friend WithEvents btnGeneral As KremerControlsWin32.KremerButton
    Friend WithEvents txtHeader As System.Windows.Forms.TextBox
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents tmrWatch As System.Windows.Forms.Timer
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblLevel As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents pnlSub As System.Windows.Forms.Panel
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents btnAlarms As KremerControlsWin32.KremerButton
    Friend WithEvents krAlarmData As KremerControlsWin32.KremerAlarmDataCollector
    Friend WithEvents krAlarmView As KremerControlsWin32.KremerAlarmViewer
    Friend WithEvents krVarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents krConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents sUserName As KremerControlsWin32.KremerVariable
    Friend WithEvents miUserLevel As KremerControlsWin32.KremerVariable
    Friend WithEvents mxProduktDataLoaded As KremerControlsWin32.KremerVariable
    Friend WithEvents KremerAlarmWord1 As KremerControlsWin32.KremerAlarmWord
    Friend WithEvents KremerAlarmWord2 As KremerControlsWin32.KremerAlarmWord
    Friend WithEvents KremerAlarmWord3 As KremerControlsWin32.KremerAlarmWord
    Friend WithEvents CX1020 As TwincatControlWin32.KremerPLC
    Friend WithEvents AlarmWord1 As KremerControlsWin32.KremerVariable
    Friend WithEvents AlarmWord2 As KremerControlsWin32.KremerVariable
    Friend WithEvents grpMain As KremerControlsWin32.KremerAlarmGroup
    Friend WithEvents Channel1 As KremerControlsWin32.KremerLogItem
    Friend WithEvents Channel2 As KremerControlsWin32.KremerLogItem
    Friend WithEvents BtnOverview As KremerControlsWin32.KremerButton
    Friend WithEvents Btn_Reset As KremerControlsWin32.KremerButton
    Friend WithEvents Btn_Service As KremerControlsWin32.KremerButton
    Friend WithEvents BtnSettings As KremerControlsWin32.KremerButton
    Friend WithEvents grpZipper As KremerControlsWin32.KremerAlarmGroup
    Friend WithEvents grpBBT As KremerControlsWin32.KremerAlarmGroup
    Friend WithEvents grpDenester As KremerControlsWin32.KremerAlarmGroup
    Friend WithEvents grpOutfeed As KremerControlsWin32.KremerAlarmGroup
    Friend WithEvents grpGeneral As KremerControlsWin32.KremerAlarmGroup
    Friend WithEvents KremerAlarmWord4 As KremerControlsWin32.KremerAlarmWord
    Friend WithEvents KremerAlarmWord5 As KremerControlsWin32.KremerAlarmWord
    Friend WithEvents KremerAlarmWord6 As KremerControlsWin32.KremerAlarmWord
    Friend WithEvents KremerAlarmWord7 As KremerControlsWin32.KremerAlarmWord
    Friend WithEvents KremerAlarmWord8 As KremerControlsWin32.KremerAlarmWord
    Friend WithEvents hmiReset As KremerControlsWin32.KremerVariable
    Friend WithEvents grpPress As KremerControlsWin32.KremerAlarmGroup
    Friend WithEvents grpPrinter As KremerControlsWin32.KremerAlarmGroup
    Friend WithEvents KremerAlarmWord9 As KremerControlsWin32.KremerAlarmWord
    Friend WithEvents KremerAlarmWord10 As KremerControlsWin32.KremerAlarmWord
    Friend WithEvents KremerAlarmWord11 As KremerControlsWin32.KremerAlarmWord
    Friend WithEvents KremerAlarmWord12 As KremerControlsWin32.KremerAlarmWord

    Friend WithEvents grpBTU As KremerControlsWin32.KremerAlarmGroup
    Friend WithEvents KremerAlarmWord13 As KremerControlsWin32.KremerAlarmWord
    Friend WithEvents KremerAlarmLogDB As KremerControlsWin32.KremerAlarmLogDB
    Friend WithEvents KremerAlarmWord14 As KremerControlsWin32.KremerAlarmWord
    Friend WithEvents KremerAlarmWord15 As KremerControlsWin32.KremerAlarmWord
    Friend WithEvents KremerAlarmWord16 As KremerControlsWin32.KremerAlarmWord
    Friend WithEvents grpSafetyIO As KremerControlsWin32.KremerAlarmGroup
    Friend WithEvents KremerAlarmWord17 As KremerControlsWin32.KremerAlarmWord
    Friend WithEvents btnInit As KremerControlsWin32.KremerButton
    Friend WithEvents ReasonForStop As KremerControlsWin32.KremerAlarmType
    Friend WithEvents SafetyMessage As KremerControlsWin32.KremerAlarmType
    Friend WithEvents DriveError As KremerControlsWin32.KremerAlarmType
    Friend WithEvents OtherMessages As KremerControlsWin32.KremerAlarmType
    Friend WithEvents mxManualAutomode As KremerControlsWin32.KremerVariable
    Friend WithEvents Mechanical As KremerControlsWin32.KremerAlarmType
    Friend WithEvents KremerAlarmWord18 As KremerControlsWin32.KremerAlarmWord
    Friend WithEvents KremerAlarmWord19 As KremerControlsWin32.KremerAlarmWord
    Friend WithEvents KremerAlarmWord20 As KremerControlsWin32.KremerAlarmWord
    Friend WithEvents AlarmWord3 As KremerControlsWin32.KremerVariable
    Friend WithEvents AlarmWord4 As KremerControlsWin32.KremerVariable
    Friend WithEvents AlarmWord5 As KremerControlsWin32.KremerVariable
    Friend WithEvents AlarmWord6 As KremerControlsWin32.KremerVariable
    Friend WithEvents AlarmWord7 As KremerControlsWin32.KremerVariable
    Friend WithEvents AlarmWord8 As KremerControlsWin32.KremerVariable
    Friend WithEvents AlarmWord9 As KremerControlsWin32.KremerVariable
    Friend WithEvents AlarmWord10 As KremerControlsWin32.KremerVariable
    Friend WithEvents AlarmWord11 As KremerControlsWin32.KremerVariable
    Friend WithEvents AlarmWord12 As KremerControlsWin32.KremerVariable
    Friend WithEvents AlarmWord13 As KremerControlsWin32.KremerVariable
    Friend WithEvents AlarmWord14 As KremerControlsWin32.KremerVariable
    Friend WithEvents AlarmWord15 As KremerControlsWin32.KremerVariable
    Friend WithEvents AlarmWord16 As KremerControlsWin32.KremerVariable
    Friend WithEvents AlarmWord17 As KremerControlsWin32.KremerVariable
    Friend WithEvents AlarmWord18 As KremerControlsWin32.KremerVariable
    Friend WithEvents AlarmWord19 As KremerControlsWin32.KremerVariable
    Friend WithEvents AlarmWord20 As KremerControlsWin32.KremerVariable
    Friend WithEvents GodMode As KremerControlsWin32.KremerVariable
    Friend WithEvents TxtGodMode As System.Windows.Forms.TextBox

End Class
