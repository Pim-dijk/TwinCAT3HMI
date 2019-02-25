Imports KremerControlsWin32

Public Class Sequence

    Private Sub InitControls()
        For Each IoCtl As Control In Me.Controls
            If TypeOf IoCtl Is KremerIoField Then CType(IoCtl, KremerIoField).UserInfo = HmiUserInfo
            If TypeOf IoCtl Is KremerTextField Then CType(IoCtl, KremerTextField).UserInfo = HmiUserInfo
            If TypeOf IoCtl Is KremerButton Then CType(IoCtl, KremerButton).UserInfo = HmiUserInfo
        Next

        tvInline.ExpandAll()

        AddHandler tvInline.BeforeCollapse, AddressOf InlineTree
    End Sub

    Private Sub Service_ParentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ParentChanged
        If Not Me.Parent Is Nothing Then
            GetControlLabel(Me.Controls)
            InitControls()

            krConnector.PLC = frmMain.CX1020
            krConnector.VarCollector = Me.krVarCollector
            krConnector.Connect()
        Else
            krConnector.Disconnect()

            RemoveHandler tvInline.BeforeCollapse, AddressOf InlineTree
        End If
    End Sub

    Private Sub InlineTree(ByVal sender As Object, ByVal e As TreeViewCancelEventArgs)
        If HasCheckedChildNodes(e.Node) Then
            e.Cancel = True
        End If
    End Sub 'CheckForCheckedChildren

    Private Sub StackingTree(ByVal sender As Object, ByVal e As TreeViewCancelEventArgs)
        If HasCheckedChildNodes(e.Node) Then
            e.Cancel = True
        End If
    End Sub 'CheckForCheckedChildren

    Private Function HasCheckedChildNodes(ByVal node As TreeNode) As Boolean
        If node.Nodes.Count = 0 Then
            Return False
        End If
        Dim childNode As TreeNode
        For Each childNode In node.Nodes
            If childNode.Checked Then
                Return True
            End If
            ' Recursively check the children of the current child node.
            If HasCheckedChildNodes(childNode) Then
                Return True
            End If
        Next childNode
        Return False
    End Function 'HasCheckedChildNodes

End Class
