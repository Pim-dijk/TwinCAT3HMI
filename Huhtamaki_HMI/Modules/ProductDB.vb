Imports System.Data.SqlServerCe
Module ProductDB
    Private ProdCnn As SqlCeConnection

    Dim LoadProductID As Integer

    Public CurrentProduct As String = "Product Name"
    Public ProductDataLoaded As Boolean

    Public Sub SetProductID(ByVal ProdID As Integer)
        LoadProductID = ProdID
    End Sub

    Public Function GetProductID() As Integer
        GetProductID = LoadProductID
    End Function

    Public Sub OpenProductsDB()

        ProdCnn = New SqlCeConnection("Data Source= " & GetAppDir() & "\Database\Product_DB.sdf")
        ProdCnn.Open()

    End Sub

    Public Sub CloseProductsDB()

        ProdCnn.Close()
        ProdCnn.Dispose()

    End Sub

    Public Sub ReadAllProducts(ByVal pLstVw As ListView)

        Dim cmd As SqlCeCommand = Nothing
        Dim rdr As SqlCeDataReader = Nothing
        Dim lItem As ListViewItem

        pLstVw.Columns(1).Text = GetSingleLabel(41)

        pLstVw.Items.Clear()
        Try
            OpenProductsDB()

            cmd = New SqlCeCommand("select ProductID, ProductName from tblProducts order by ProductID;", ProdCnn)
            rdr = cmd.ExecuteReader
            ' Iterate through the results
            '
            While rdr.Read()
                Dim ProdID As Integer = rdr.GetInt32(0)
                Dim ProdName As String = rdr.GetString(1)
                lItem = pLstVw.Items.Add(New ListViewItem(CStr(ProdID)))
                lItem.SubItems.Add(ProdName)
            End While
        Finally
            ' Always call Close when done reading
            rdr.Close()
            rdr.Dispose()
            cmd.Dispose()
            CloseProductsDB()
        End Try

    End Sub
    Public Function LoadProduct(ByRef frmTwincatVar As Product, ByVal ProdID As Integer) As Boolean

        Dim cmd As SqlCeCommand = Nothing
        Dim rdr As SqlCeDataReader = Nothing

        LoadProduct = False
        Try
            OpenProductsDB()

            cmd = New SqlCeCommand("select * from tblProducts where ProductID=" & ProdID, ProdCnn)
            rdr = cmd.ExecuteReader()

            While rdr.Read()
                frmTwincatVar.ioProductId.Data = rdr.GetValue(0)
                frmTwincatVar.ioProductName.Data = rdr.GetString(1)
                frmTwincatVar.IO_TMDownStop.Data = rdr.GetValue(2)
                frmTwincatVar.IO_TMDownOpen.Data = rdr.GetValue(3)
                frmTwincatVar.IO_TMOpen.Data = rdr.GetValue(4)
                frmTwincatVar.IO_TMTransferStopA.Data = rdr.GetValue(5)
                frmTwincatVar.IO_TMTransferStopB.Data = rdr.GetValue(6)
                frmTwincatVar.IO_ReleaseToBMA.Data = rdr.GetValue(7)
                frmTwincatVar.IO_ReleaseToBMB.Data = rdr.GetValue(8)
                frmTwincatVar.IO_TopADownStop.Data = rdr.GetValue(9)
                frmTwincatVar.IO_TopBDownStop.Data = rdr.GetValue(10)
                frmTwincatVar.IO_TopAOpen.Data = rdr.GetValue(11)
                frmTwincatVar.IO_TopBOpen.Data = rdr.GetValue(12)
                frmTwincatVar.IO_GYAVerticalPickup.Data = rdr.GetValue(13)
                frmTwincatVar.IO_GYAVerticalDropOff.Data = rdr.GetValue(14)
                frmTwincatVar.IO_GYBVerticalDropOff.Data = rdr.GetValue(15)
                frmTwincatVar.IO_GYBVerticalPickup.Data = rdr.GetValue(16)
                frmTwincatVar.IO_GYABlowOff.Data = rdr.GetValue(17)
                frmTwincatVar.IO_GYBBlowOff.Data = rdr.GetValue(18)
            End While

            LoadProduct = True
        Finally
            rdr.Close()
            rdr.Dispose()
            cmd.Dispose()
            CloseProductsDB()
        End Try

    End Function

    Public Sub SaveProduct(ByRef frmTwincatVar As Product, ByVal ProdID As Integer)
        Dim cmd As SqlCeCommand = Nothing

        Try
            OpenProductsDB()

            cmd = New SqlCeCommand("update tblProducts set " & _
            "TMDownStop=CONVERT(real," & Replace(frmTwincatVar.IO_TMDownStop.Data.ToString, ",", ".") & ",0), " & _
            "TMDownOpen=CONVERT(real," & Replace(frmTwincatVar.IO_TMDownOpen.Data.ToString, ",", ".") & ",0), " & _
            "TMTransferOpen=CONVERT(real," & Replace(frmTwincatVar.IO_TMOpen.Data.ToString, ",", ".") & ",0), " & _
            "TMTransferA=CONVERT(real," & Replace(frmTwincatVar.IO_TMTransferStopA.Data.ToString, ",", ".") & ",0), " & _
            "TMTransferB=CONVERT(real," & Replace(frmTwincatVar.IO_TMTransferStopB.Data.ToString, ",", ".") & ",0), " & _
            "TMReleaseBottomMoldA=CONVERT(real," & Replace(frmTwincatVar.IO_ReleaseToBMA.Data.ToString, ",", ".") & ",0), " & _
            "TMReleaseBottomMoldB=CONVERT(real," & Replace(frmTwincatVar.IO_ReleaseToBMB.Data.ToString, ",", ".") & ",0), " & _
            "TopADownStop=CONVERT(real," & Replace(frmTwincatVar.IO_TopADownStop.Data.ToString, ",", ".") & ",0), " & _
            "TopBDownStop=CONVERT(real," & Replace(frmTwincatVar.IO_TopBDownStop.Data.ToString, ",", ".") & ",0) ," & _
            "TopAOpen=CONVERT(real," & Replace(frmTwincatVar.IO_TopAOpen.Data.ToString, ",", ".") & ",0), " & _
            "TopBOpen=CONVERT(real," & Replace(frmTwincatVar.IO_TopBOpen.Data.ToString, ",", ".") & ",0) ," & _
            "GantryAVertPickup=CONVERT(real," & Replace(frmTwincatVar.IO_GYAVerticalPickup.Data.ToString, ",", ".") & ",0) ," & _
            "GantryAVertDropOff=CONVERT(real," & Replace(frmTwincatVar.IO_GYAVerticalDropOff.Data.ToString, ",", ".") & ",0) ," & _
            "GantryBVertDropOff=CONVERT(real," & Replace(frmTwincatVar.IO_GYBVerticalDropOff.Data.ToString, ",", ".") & ",0) ," & _
            "GantryBVertPickUp=CONVERT(real," & Replace(frmTwincatVar.IO_GYBVerticalPickup.Data.ToString, ",", ".") & ",0) ," & _
            "GantryAPickUpBlowOff=CONVERT(real," & Replace(frmTwincatVar.IO_GYABlowOff.Data.ToString, ",", ".") & ",0) ," & _
            "GantryBPickUpBlowOff=CONVERT(real," & Replace(frmTwincatVar.IO_GYBBlowOff.Data.ToString, ",", ".") & ",0)" & _
            " where ProductID=" & ProdID, ProdCnn)

            cmd.ExecuteNonQuery()
        Finally
            cmd.Dispose()
            CloseProductsDB()

        End Try

    End Sub

    Public Sub SaveAsNewProduct(ByRef frmTwincatVar As Product)
        Dim cmd As SqlCeCommand = Nothing

        Try
            OpenProductsDB()

            cmd = New SqlCeCommand("insert into tblProducts (" & _
                "ProductName, TMDownStop, TMDownOpen, TMTransferOpen, " & _
                "TMTransferA, TMTransferB, TMReleaseBottomMoldA, TMReleaseBottomMoldB, " & _
                "TopADownStop, TopBDownStop, TopAOpen, TopBOpen, " & _
                "GantryAVertPickup, GantryAVertDropOff, GantryBVertDropOff, GantryBVertPickUp, " & _
                "GantryAPickUpBlowOff, GantryBPickUpBlowOff) values(" & _
                "'" & frmTwincatVar.ioProductName.Data & "', " & _
                "CONVERT(real," & Replace(frmTwincatVar.IO_TMDownStop.Data.ToString, ",", ".") & ",0), " & _
                "CONVERT(real," & Replace(frmTwincatVar.IO_TMDownOpen.Data.ToString, ",", ".") & ",0) ," & _
                   "CONVERT(real," & Replace(frmTwincatVar.IO_TMOpen.Data.ToString, ",", ".") & ",0) ," & _
                "CONVERT(real," & Replace(frmTwincatVar.IO_TMTransferStopA.Data.ToString, ",", ".") & ",0) ," & _
                "CONVERT(real," & Replace(frmTwincatVar.IO_TMTransferStopB.Data.ToString, ",", ".") & ",0) ," & _
                "CONVERT(real," & Replace(frmTwincatVar.IO_ReleaseToBMA.Data.ToString, ",", ".") & ",0) ," & _
                "CONVERT(real," & Replace(frmTwincatVar.IO_ReleaseToBMB.Data.ToString, ",", ".") & ",0) ," & _
                "CONVERT(real," & Replace(frmTwincatVar.IO_TopADownStop.Data.ToString, ",", ".") & ",0) ," & _
                "CONVERT(real," & Replace(frmTwincatVar.IO_TopBDownStop.Data.ToString, ",", ".") & ",0) ," & _
                "CONVERT(real," & Replace(frmTwincatVar.IO_TopAOpen.Data.ToString, ",", ".") & ",0) ," & _
                "CONVERT(real," & Replace(frmTwincatVar.IO_TopBOpen.Data.ToString, ",", ".") & ",0) ," & _
                "CONVERT(real," & Replace(frmTwincatVar.IO_GYAVerticalPickup.Data.ToString, ",", ".") & ",0) ," & _
                "CONVERT(real," & Replace(frmTwincatVar.IO_GYAVerticalDropOff.Data.ToString, ",", ".") & ",0) ," & _
                "CONVERT(real," & Replace(frmTwincatVar.IO_GYBVerticalDropOff.Data.ToString, ",", ".") & ",0) ," & _
                "CONVERT(real," & Replace(frmTwincatVar.IO_GYBVerticalPickup.Data.ToString, ",", ".") & ",0) ," & _
                "CONVERT(real," & Replace(frmTwincatVar.IO_GYABlowOff.Data.ToString, ",", ".") & ",0) ," & _
                "CONVERT(real," & Replace(frmTwincatVar.IO_GYBBlowOff.Data.ToString, ",", ".") & ",0))", ProdCnn)

            cmd.ExecuteNonQuery()

            cmd.CommandText = "select max(ProductID) from tblProducts"
            frmTwincatVar.ioProductId.Data = CInt(cmd.ExecuteScalar())

        Catch ex As Exception
            MsgBox(ex.Message.ToString)

        Finally
            cmd.Dispose()
            CloseProductsDB()

        End Try

    End Sub

    Public Sub DeleteProduct(ByVal ProdId As Integer)
        Dim cmd As SqlCeCommand = Nothing

        Try
            OpenProductsDB()

            cmd = New SqlCeCommand("delete from tblProducts where ProductID=" & ProdId, ProdCnn)

            cmd.ExecuteNonQuery()

        Finally
            cmd.Dispose()
            CloseProductsDB()

        End Try

    End Sub
End Module
