<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUpdate
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Private Modules As New Collection

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdate))
        Me.progUpdate = New System.Windows.Forms.ProgressBar()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.grpUpdate = New System.Windows.Forms.GroupBox()
        Me.gridModules = New System.Windows.Forms.DataGridView()
        Me.Mark = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ModuleName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.editFile = New System.Windows.Forms.TextBox()
        Me.btnFile = New System.Windows.Forms.Button()
        Me.btnPersonal = New System.Windows.Forms.Button()
        Me.btnFinish = New System.Windows.Forms.Button()
        Me.Process1 = New System.Diagnostics.Process()
        Me.grpUpdate.SuspendLayout()
        CType(Me.gridModules, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'progUpdate
        '
        Me.progUpdate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.progUpdate.Location = New System.Drawing.Point(12, 279)
        Me.progUpdate.Name = "progUpdate"
        Me.progUpdate.Size = New System.Drawing.Size(570, 23)
        Me.progUpdate.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.progUpdate.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(669, 279)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Tag = "Cancel"
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdate.Location = New System.Drawing.Point(588, 279)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'grpUpdate
        '
        Me.grpUpdate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpUpdate.Controls.Add(Me.gridModules)
        Me.grpUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpUpdate.Location = New System.Drawing.Point(12, 29)
        Me.grpUpdate.Name = "grpUpdate"
        Me.grpUpdate.Size = New System.Drawing.Size(732, 218)
        Me.grpUpdate.TabIndex = 5
        Me.grpUpdate.TabStop = False
        '
        'gridModules
        '
        Me.gridModules.AllowUserToAddRows = False
        Me.gridModules.AllowUserToDeleteRows = False
        Me.gridModules.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridModules.BackgroundColor = System.Drawing.Color.White
        Me.gridModules.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gridModules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridModules.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Mark, Me.ModuleName, Me.Description, Me.Type})
        Me.gridModules.Location = New System.Drawing.Point(6, 19)
        Me.gridModules.Name = "gridModules"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridModules.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gridModules.ShowEditingIcon = False
        Me.gridModules.Size = New System.Drawing.Size(720, 193)
        Me.gridModules.TabIndex = 6
        '
        'Mark
        '
        Me.Mark.FalseValue = "N"
        Me.Mark.HeaderText = "Update"
        Me.Mark.Name = "Mark"
        Me.Mark.ToolTipText = "Mark for update"
        Me.Mark.TrueValue = "Y"
        '
        'ModuleName
        '
        Me.ModuleName.HeaderText = "Name"
        Me.ModuleName.Name = "ModuleName"
        Me.ModuleName.ReadOnly = True
        Me.ModuleName.Width = 200
        '
        'Description
        '
        Me.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        '
        'Type
        '
        Me.Type.HeaderText = "Type"
        Me.Type.Name = "Type"
        Me.Type.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Please select the files to install/update."
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.Filter = "Excel|*.xls,*.xlsx|Excel Macro-Enabled|*.xlsm|Excel Binary|*.xlsb"
        '
        'editFile
        '
        Me.editFile.Location = New System.Drawing.Point(12, 253)
        Me.editFile.Name = "editFile"
        Me.editFile.Size = New System.Drawing.Size(538, 20)
        Me.editFile.TabIndex = 8
        '
        'btnFile
        '
        Me.btnFile.Location = New System.Drawing.Point(556, 253)
        Me.btnFile.Name = "btnFile"
        Me.btnFile.Size = New System.Drawing.Size(26, 21)
        Me.btnFile.TabIndex = 9
        Me.btnFile.Text = "..."
        Me.btnFile.UseVisualStyleBackColor = True
        '
        'btnPersonal
        '
        Me.btnPersonal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPersonal.Location = New System.Drawing.Point(588, 253)
        Me.btnPersonal.Name = "btnPersonal"
        Me.btnPersonal.Size = New System.Drawing.Size(156, 20)
        Me.btnPersonal.TabIndex = 10
        Me.btnPersonal.Text = "PERSONAL.XLSB"
        Me.btnPersonal.UseVisualStyleBackColor = True
        '
        'btnFinish
        '
        Me.btnFinish.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFinish.Location = New System.Drawing.Point(588, 279)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(75, 23)
        Me.btnFinish.TabIndex = 11
        Me.btnFinish.Text = "Finish"
        Me.btnFinish.UseVisualStyleBackColor = True
        Me.btnFinish.Visible = False
        '
        'Process1
        '
        Me.Process1.StartInfo.Domain = ""
        Me.Process1.StartInfo.LoadUserProfile = False
        Me.Process1.StartInfo.Password = Nothing
        Me.Process1.StartInfo.StandardErrorEncoding = Nothing
        Me.Process1.StartInfo.StandardOutputEncoding = Nothing
        Me.Process1.StartInfo.UserName = ""
        Me.Process1.SynchronizingObject = Me
        '
        'frmUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 310)
        Me.Controls.Add(Me.btnFinish)
        Me.Controls.Add(Me.btnPersonal)
        Me.Controls.Add(Me.btnFile)
        Me.Controls.Add(Me.editFile)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpUpdate)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.progUpdate)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(772, 349)
        Me.Name = "frmUpdate"
        Me.Text = "Update Modules"
        Me.grpUpdate.ResumeLayout(False)
        CType(Me.gridModules, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents progUpdate As ProgressBar
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents grpUpdate As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Private ModuleCount As Integer

    Sub addItemsFromJSON()
        Dim ModuleItem As VBModule
        Dim ModuleName As String
        Dim ModuleDesc As String
        Dim ModuleLoc As String
        Dim file As String
        Dim fileCount As Integer
        '
        file = Dir(My.Application.Info.DirectoryPath & "\*")
        While (file <> "")
            If StringUtils.Contains(Piece(file, ".", 2, -1), "bas,cls,frm", ",") Then
                ModuleItem = New VBModule
                ModuleName = Piece(file, ".", 1, 1)
                ModuleDesc = "N/A"
                If fileCount < GeneralSettings.Default.Descriptions.Count Then
                    ModuleDesc = GeneralSettings.Default.Descriptions.Item(fileCount)
                End If
                ModuleLoc = My.Application.Info.DirectoryPath & "\" & file
                ModuleItem = ModuleItem.Create(ModuleName, ModuleDesc, ModuleLoc)
                If RequiredModule(ModuleName) Then
                    ModuleItem.Checked = "Y"
                End If
                addGridRow(ModuleItem, Piece(file, ".", 2, -1))
                Modules.Add(ModuleItem)
                fileCount = fileCount + 1
            End If
            file = Dir()
        End While
    End Sub

    Function RequiredModule(ModuleName As String) As Boolean
        RequiredModule = False
        If StringUtils.Contains(ModuleName, GeneralSettings.Default.RequiredModules, ",") Then RequiredModule = True
    End Function

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim Excel As Microsoft.Office.Interop.Excel.Application
        Dim Item As VBModule
        Dim VBComp As Microsoft.Vbe.Interop.VBComponent
        Dim Incr As Integer
        '
        ' Validation
        If editFile.Text = "" Then
            MsgBox("A file must be specified to update.", vbCritical, "Validation Error")
            Exit Sub
        End If
        '
        If ModuleCount = 0 Then
            MsgBox("A least one module must be specified to update.", vbCritical, "Validation Error")
            Exit Sub
        End If
        '
        ' Processing
        btnUpdate.Enabled = False
        Excel = CreateObject("Excel.Application")
        setRegKeyDWord("HKEY_CURRENT_USER\SOFTWARE\Microsoft\Office\" & Excel.Application.Version & "\Excel\Security\AccessVBOM", 1)
        Excel.Visible = False
        With Excel.Application.Workbooks.Open(editFile.Text)
            If .ReadOnly = True Then
                .Close(False)
                GoTo readOnlyFile
            End If
            For Each Item In Modules
                If Item.Checked = "Y" Then
                    For Each VBComp In .VBProject.VBComponents
                        If VBComp.Name = Item.Name Then
                            .VBProject.VBComponents.Remove(VBComp)
                            Exit For
                        End If
                    Next
                    .VBProject.VBComponents.Import(Item.Loc)
                    Incr = Incr + (Math.Round((100 / ModuleCount) + 0.49))
                    progUpdate.Increment(Incr)
                End If
            Next
            .Save()
            .Close()
        End With
        btnFinish.Visible = True
        btnCancel.Enabled = False
        Exit Sub
readOnlyFile:
        MsgBox("'" & editFile.Text & "' is already open, please close the file to update it." & Chr(13) & Chr(13) & "Note : PERSONAL.XLSB wil requre closing Microsoft Excel.")
        btnUpdate.Enabled = True
        Exit Sub
    End Sub

    Public Sub addGridRow(Item As VBModule, Type As String)
        Select Case (Type)
            Case "bas"
                Type = "Module"
            Case "cls"
                Type = "Class"
            Case "frm"
                Type = "Form"
            Case Else
                Type = Type
        End Select
        '
        gridModules.Rows.Add(Item.Checked, Item.Name, Item.Desc, Type)
        If Item.Checked = "Y" Then
            gridModules.Rows.Item((gridModules.Rows.Count - 1)).ReadOnly = True
            gridModules.Rows.Item((gridModules.Rows.Count - 1)).DefaultCellStyle.BackColor = Color.LightGray
            ModuleCount = ModuleCount + 1
        End If
    End Sub

    Private Sub frmUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        addItemsFromJSON()
    End Sub

    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents btnPersonal As Button
    Friend WithEvents btnFile As Button
    Friend WithEvents editFile As TextBox

    Private Sub btnFile_Click(sender As Object, e As EventArgs) Handles btnFile.Click
        With OpenFileDialog
            .ShowDialog()
            editFile.Text = .FileName
        End With
    End Sub

    Private Sub btnPersonal_Click(sender As Object, e As EventArgs) Handles btnPersonal.Click
        editFile.Text = Environ("APPDATA") & "\Microsoft\Excel\XLSTART\PERSONAL.XLSB"
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Friend WithEvents gridModules As DataGridView

    Private Sub gridModules_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles gridModules.CellEndEdit
        Dim ModuleItem As VBModule
        ModuleItem = Modules.Item(e.RowIndex + 1)
        ModuleItem.Checked = gridModules.Rows.Item(e.RowIndex).Cells().Item("Mark").Value
        If ModuleItem.Checked = "Y" Then ModuleCount = ModuleCount + 1
    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        Me.Close()
    End Sub

    Friend WithEvents Mark As DataGridViewCheckBoxColumn
    Friend WithEvents ModuleName As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents Type As DataGridViewTextBoxColumn
    Friend WithEvents btnFinish As Button
    Friend WithEvents Process1 As Process
End Class
