Option Explicit On
Imports SolidWorks.Interop.sldworks
Imports SolidWorks.Interop.swconst
Imports System.Text
Imports System.IO
Imports System.Math


Public Class frmMain
    Dim swApp As SldWorks
    Dim boolStatus As Boolean
    Dim settingData As String()

#Region "API Functions"

    Private Declare Unicode Function GetPrivateProfileString Lib "kernel32" _
    Alias "GetPrivateProfileStringW" (ByVal lpAppName As String, _
            ByVal lpKeyName As String, _
            ByVal lpDefault As String, _
            ByVal lpReturnedString As StringBuilder, _
            ByVal nSize As Integer, _
            ByVal lpFileName As String) As Integer

    Private Declare Unicode Function WritePrivateProfileString Lib "kernel32" _
        Alias "WritePrivateProfileStringW" (ByVal lpApplicationName As String, _
                ByVal lpKeyName As String, ByVal lpString As String, _
                ByVal lpFileName As String) As Int32

    Public Function GetProfileString(ByVal pvsFileName As String, ByVal psAppName As String, ByVal psKeyName As String, Optional ByVal pvsDefault As String = "") As String
        Dim sb As StringBuilder
        sb = New StringBuilder(500)

        Dim res As String = pvsDefault
        res = GetPrivateProfileString(psAppName, psKeyName, pvsDefault, sb, sb.Capacity, pvsFileName)

        Return sb.ToString()

    End Function

    Public Function WriteProfileString(ByVal pvsFileName As String, ByVal psAppName As String, ByVal psKeyName As String, ByVal pvsValue As String) As Long
        Dim res As Long = 0
        res = WritePrivateProfileString(psAppName, psKeyName, pvsValue, pvsFileName)

        Return res

    End Function

#End Region

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        readSettings()
    End Sub

    Sub readSettings()
        On Error Resume Next

        'inizio lettura impostazioni 
        Dim iniPath As String = My.Application.Info.DirectoryPath & "\Settings.ini"

        Me.WindowState = Convert.ToInt16(GetProfileString(iniPath, "Windows", "WindowState"))
        Me.Left = Convert.ToInt16(GetProfileString(iniPath, "Windows", "Left"))
        Me.Top = Convert.ToInt16(GetProfileString(iniPath, "Windows", "Top"))
        Me.Width = Convert.ToInt16(GetProfileString(iniPath, "Windows", "Width"))
        Me.Height = Convert.ToInt16(GetProfileString(iniPath, "Windows", "Height"))

        txtINx1.Text = Convert.ToDouble(GetProfileString(iniPath, "Grid", "xMin"))
        txtINx2.Text = Convert.ToDouble(GetProfileString(iniPath, "Grid", "xMax"))
        txtINx3.Text = Convert.ToDouble(GetProfileString(iniPath, "Grid", "xSteps"))
        txtINy1.Text = Convert.ToDouble(GetProfileString(iniPath, "Grid", "yMin"))
        txtINy2.Text = Convert.ToDouble(GetProfileString(iniPath, "Grid", "yMax"))
        txtINy3.Text = Convert.ToDouble(GetProfileString(iniPath, "Grid", "ySteps"))
        txtINz1.Text = Convert.ToDouble(GetProfileString(iniPath, "Grid", "zMin"))
        txtINz2.Text = Convert.ToDouble(GetProfileString(iniPath, "Grid", "zMax"))

    End Sub

    Sub writeSettings()
        On Error Resume Next

        'inizio scrittura impostazioni 
        Dim iniPath As String = My.Application.Info.DirectoryPath & "\Settings.ini"

        WriteProfileString(iniPath, "Windows", "WindowState", Me.WindowState)
        WriteProfileString(iniPath, "Windows", "Left", Me.Left)
        WriteProfileString(iniPath, "Windows", "Top", Me.Top)
        WriteProfileString(iniPath, "Windows", "Width", Me.Width)
        WriteProfileString(iniPath, "Windows", "Height", Me.Height)

        WriteProfileString(iniPath, "Grid", "xMin", txtINx1.Text)
        WriteProfileString(iniPath, "Grid", "xMax", txtINx2.Text)
        WriteProfileString(iniPath, "Grid", "xSteps", txtINx3.Text)
        WriteProfileString(iniPath, "Grid", "yMin", txtINy1.Text)
        WriteProfileString(iniPath, "Grid", "yMax", txtINy2.Text)
        WriteProfileString(iniPath, "Grid", "ySteps", txtINy3.Text)
        WriteProfileString(iniPath, "Grid", "zMin", txtINz1.Text)
        WriteProfileString(iniPath, "Grid", "zMax", txtINz2.Text)

    End Sub

    Sub initSW()

        Try
            swApp = GetObject(, "SldWorks.application")
        Catch
            MsgBox("Solidworks must be open and an empty part must be active!")
            End
        End Try

    End Sub

    Sub initGrid()

        Dim randGen As New Random

        dgvTable.ColumnCount = CInt(txtINx3.Text) + 1
        dgvTable.RowCount = CInt(txtINy3.Text) + 1

        For i = 0 To dgvTable.ColumnCount - 1
            dgvTable.Columns(i).HeaderCell.Value = (CDbl(txtINx1.Text) + (CDbl(txtINx2.Text) - CDbl(txtINx1.Text)) / CInt(txtINx3.Text) * i).ToString
        Next
        For ii = 0 To dgvTable.RowCount - 1
            dgvTable.Rows(ii).HeaderCell.Value = (CDbl(txtINy1.Text) + (CDbl(txtINy2.Text) - CDbl(txtINy1.Text)) / CInt(txtINy3.Text) * ii).ToString
        Next
        dgvTable.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders)

        progBar.Value = 0
        progBar.Maximum = dgvTable.ColumnCount - 1
        For i = 0 To dgvTable.ColumnCount - 1
            progBar.Value = i
            For ii = 0 To dgvTable.RowCount - 1
                dgvTable.Item(i, ii).Value = CDbl(txtINz1.Text) + (CDbl(txtINz2.Text) - CDbl(txtINz1.Text)) * randGen.NextDouble()
                My.Application.DoEvents()
            Next
        Next
        progBar.Value = 0
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If dgvTable.ColumnCount < 1 Or dgvTable.RowCount < 1 Then
            MsgBox("Acceptable data must be present in the grid!")
            Exit Sub
        End If

        initSW()

        Dim swPart As ModelDoc2 = swApp.ActiveDoc

        If IsNothing(swPart) Then
            MsgBox("Solidworks must be open and an empty part must be active!")
            Exit Sub
        End If

        If swPart.GetType <> 1 Then
            MsgBox("Solidworks must be open and an empty part must be active!")
            Exit Sub
        End If

        progBar.Value = 0
        progBar.Maximum = dgvTable.ColumnCount - 1

        For i = 0 To dgvTable.ColumnCount - 1
            progBar.Value = i
            swPart.InsertCurveFileBegin()
            For ii = 0 To dgvTable.RowCount - 1
                swPart.InsertCurveFilePoint(CDbl(dgvTable.Columns(i).HeaderCell.Value) / 1000, CDbl(dgvTable.Rows(ii).HeaderCell.Value) / 1000, CDbl(dgvTable.Item(i, ii).Value) / 1000)
                My.Application.DoEvents()
            Next
            boolStatus = swPart.InsertCurveFileEnd()

            If Not (boolStatus) Then
                Dim retval = MsgBox("Invalid curve point for x=" & dgvTable.Columns(i).HeaderCell.Value.ToString & " . Continue?", vbYesNo)
                If retval = vbNo Then
                    progBar.Value = 0
                    Exit Sub
                End If

            End If

            swPart.SelectedFeatureProperties(0, 0, 0, 0, 0, 0, 0, True, False, "curve_at_x=" & dgvTable.Columns(i).HeaderCell.Value)
            swPart.ClearSelection2(True)

        Next

        swPart.ClearSelection2(True)

        For i = 0 To dgvTable.ColumnCount - 1
            boolStatus = swPart.Extension.SelectByID2("curve_at_x=" & dgvTable.Columns(i).HeaderCell.Value, "REFERENCECURVES", 0, 0, 0, True, 1, Nothing, 0)
        Next
        swPart.BlankRefGeom()

        swPart.ClearSelection2(True)

        For i = 0 To dgvTable.ColumnCount - 1
            boolStatus = swPart.Extension.SelectByID2("curve_at_x=" & dgvTable.Columns(i).HeaderCell.Value, "REFERENCECURVES", 0, 0, 0, True, 1, Nothing, 0)
        Next

        Dim myFeature As Feature
        For i = 0 To dgvTable.ColumnCount - 1
            myFeature = swPart.FeatureManager.SetNetBlendCurveData(0, i, 0, 0, 1, True)
        Next
        myFeature = swPart.FeatureManager.SetNetBlendDirectionData(0, 32, 0, False, False)
        myFeature = swPart.FeatureManager.SetNetBlendDirectionData(1, 32, 0, False, False)
        myFeature = swPart.FeatureManager.InsertNetBlend(2, dgvTable.ColumnCount, 0, False, 0.0001, False, True, True, True, False, -1, -1, False, -1, False, False, -1, False, -1, True)

        progBar.Value = 0

        swPart.ClearSelection2(True)
        swPart.ViewZoomtofit2()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        writeSettings()
        End
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        initGrid()
    End Sub

    Private Sub DataGridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvTable.KeyDown
        On Error Resume Next
        Select Case e.KeyCode
            Case 67 'copia
                Clipboard.Clear()
                Clipboard.SetText(dgvTable.SelectedCells.Item(0).Value.ToString)

            Case 86 'incolla
                If Clipboard.ContainsText Then
                    If dgvTable.SelectedCells.Count = 1 Then
                        Dim str As String = Clipboard.GetText()
                        Dim Rows() As String = str.Split(vbNewLine)

                        For i = 0 To Rows.Count - 1
                            Dim RowArray() As String = Rows(i).Split(vbTab)
                            For j = 0 To RowArray.Count - 1
                                dgvTable.Rows(i + dgvTable.SelectedCells(0).RowIndex).Cells(j + dgvTable.SelectedCells(0).ColumnIndex).Value = RowArray(j).Trim
                            Next
                        Next
                    ElseIf dgvTable.SelectedCells.Count > 1 Then
                        For j = 0 To dgvTable.SelectedCells.Count - 1
                            dgvTable.SelectedCells.Item(j).Value = Clipboard.GetText
                        Next
                    End If
                End If
        End Select
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim ofd As New OpenFileDialog With { _
            .Title = "Select db file", _
            .Filter = "CSV (*.csv)|*.csv|TXT (*.txt)|*.txt|All Files (*.*)|*.*", _
            .FilterIndex = 0, _
            .InitialDirectory = My.Application.Info.DirectoryPath}

        If ofd.ShowDialog = DialogResult.OK Then
            readGridDataFromFile(ofd.FileName)
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim sfd As New SaveFileDialog With { _
            .Title = "Choose file to save to", _
            .Filter = "CSV (*.csv)|*.csv|TXT (*.txt)|*.txt|All Files (*.*)|*.*", _
            .FilterIndex = 0, _
            .InitialDirectory = My.Application.Info.DirectoryPath}

        If sfd.ShowDialog = DialogResult.OK Then
            saveGridDataToFile(sfd.FileName)
        End If

    End Sub

    Private Sub saveGridDataToFile(ByRef fName As String)
        On Error Resume Next

        Dim fw As New IO.StreamWriter(fName)
        fw.Write("0")

        For x As Short = 0 To dgvTable.Columns.Count - 1
            fw.Write(";" & dgvTable.Columns.Item(x).HeaderText)
        Next

        For x As Short = 0 To dgvTable.Rows.Count - 1
            fw.WriteLine()
            fw.Write(dgvTable.Rows.Item(x).HeaderCell.Value.ToString)
            For y As Short = 0 To dgvTable.Columns.Count - 1
                fw.Write(";" & dgvTable.Rows.Item(x).Cells(y).Value.ToString)
            Next
        Next

        fw.Close()

    End Sub

    Private Sub readGridDataFromFile(ByRef fname As String)
        On Error Resume Next

        Dim fileContents As String = My.Computer.FileSystem.ReadAllText(fname)

        Dim rowContents As String() = fileContents.Split(System.Environment.NewLine)
        dgvTable.RowCount = rowContents.Length - 1

        Dim cellContents As String() = rowContents(0).Split(";")
        dgvTable.ColumnCount = cellContents.Length - 1

        For x As Short = 0 To dgvTable.ColumnCount - 1
            dgvTable.Columns.Item(x).HeaderText = cellContents(x + 1)
        Next

        For x = 0 To dgvTable.RowCount - 1
            cellContents = rowContents(x + 1).Split(";")

            dgvTable.Rows.Item(x).HeaderCell.Value = cellContents(0).ToString
            For y As Short = 0 To dgvTable.ColumnCount - 1
                dgvTable.Rows.Item(x).Cells(y).Value = cellContents(y + 1)
            Next

        Next

        dgvTable.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders)


    End Sub

    Private Sub ToolStripStatusLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel2.Click
        Process.Start("mailto:gianni.castelli@outlook.it")

    End Sub

End Class
