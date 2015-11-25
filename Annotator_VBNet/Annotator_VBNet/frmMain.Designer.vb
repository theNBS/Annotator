<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnBrowseToSpecification = New System.Windows.Forms.Button
        Me.lblSpecification = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lvAnnotations = New System.Windows.Forms.ListView
        Me.colSectionCode = New System.Windows.Forms.ColumnHeader
        Me.colSectionNumber = New System.Windows.Forms.ColumnHeader
        Me.colClauseNumber = New System.Windows.Forms.ColumnHeader
        Me.colClauseTitle = New System.Windows.Forms.ColumnHeader
        Me.colAnnotationText = New System.Windows.Forms.ColumnHeader
        Me.colHiddenNumber = New System.Windows.Forms.ColumnHeader
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnShowReport = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnAddAnnotation = New System.Windows.Forms.Button
        Me.btnViewInSpecification = New System.Windows.Forms.Button
        Me.btnViewGuidance = New System.Windows.Forms.Button
        Me.btnViewManufacturerInfo = New System.Windows.Forms.Button
        Me.btnShowAnnotationInfo = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Step 1. Associate specification"
        '
        'btnBrowseToSpecification
        '
        Me.btnBrowseToSpecification.Location = New System.Drawing.Point(16, 40)
        Me.btnBrowseToSpecification.Name = "btnBrowseToSpecification"
        Me.btnBrowseToSpecification.Size = New System.Drawing.Size(149, 23)
        Me.btnBrowseToSpecification.TabIndex = 1
        Me.btnBrowseToSpecification.Text = "Browse to specification"
        Me.btnBrowseToSpecification.UseVisualStyleBackColor = True
        '
        'lblSpecification
        '
        Me.lblSpecification.AutoSize = True
        Me.lblSpecification.Location = New System.Drawing.Point(13, 75)
        Me.lblSpecification.Name = "lblSpecification"
        Me.lblSpecification.Size = New System.Drawing.Size(130, 13)
        Me.lblSpecification.TabIndex = 2
        Me.lblSpecification.Text = "[no specification selected]"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Step 2. Work with the annotations"
        '
        'lvAnnotations
        '
        Me.lvAnnotations.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colSectionCode, Me.colSectionNumber, Me.colClauseNumber, Me.colClauseTitle, Me.colAnnotationText, Me.colHiddenNumber})
        Me.lvAnnotations.FullRowSelect = True
        Me.lvAnnotations.HideSelection = False
        Me.lvAnnotations.Location = New System.Drawing.Point(16, 173)
        Me.lvAnnotations.Name = "lvAnnotations"
        Me.lvAnnotations.Size = New System.Drawing.Size(595, 174)
        Me.lvAnnotations.TabIndex = 6
        Me.lvAnnotations.UseCompatibleStateImageBehavior = False
        Me.lvAnnotations.View = System.Windows.Forms.View.Details
        '
        'colSectionCode
        '
        Me.colSectionCode.Text = "Group"
        '
        'colSectionNumber
        '
        Me.colSectionNumber.Text = "Section"
        Me.colSectionNumber.Width = 62
        '
        'colClauseNumber
        '
        Me.colClauseNumber.Text = "Clause"
        Me.colClauseNumber.Width = 61
        '
        'colClauseTitle
        '
        Me.colClauseTitle.Text = "Title"
        Me.colClauseTitle.Width = 137
        '
        'colAnnotationText
        '
        Me.colAnnotationText.Text = "Display"
        Me.colAnnotationText.Width = 188
        '
        'colHiddenNumber
        '
        Me.colHiddenNumber.Text = "ID"
        Me.colHiddenNumber.Width = 68
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 407)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Step 3. Status checking"
        '
        'btnShowReport
        '
        Me.btnShowReport.Enabled = False
        Me.btnShowReport.Location = New System.Drawing.Point(16, 435)
        Me.btnShowReport.Name = "btnShowReport"
        Me.btnShowReport.Size = New System.Drawing.Size(149, 23)
        Me.btnShowReport.TabIndex = 13
        Me.btnShowReport.Text = "Show NBS Annotator report"
        Me.btnShowReport.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(536, 492)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 16
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(16, 473)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(595, 1)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(16, 394)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(595, 1)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox1"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(16, 106)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(595, 1)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox1"
        '
        'btnAddAnnotation
        '
        Me.btnAddAnnotation.Enabled = False
        Me.btnAddAnnotation.Location = New System.Drawing.Point(16, 141)
        Me.btnAddAnnotation.Name = "btnAddAnnotation"
        Me.btnAddAnnotation.Size = New System.Drawing.Size(149, 23)
        Me.btnAddAnnotation.TabIndex = 5
        Me.btnAddAnnotation.Text = "Add annotation"
        Me.btnAddAnnotation.UseVisualStyleBackColor = True
        '
        'btnViewInSpecification
        '
        Me.btnViewInSpecification.Enabled = False
        Me.btnViewInSpecification.Location = New System.Drawing.Point(16, 358)
        Me.btnViewInSpecification.Name = "btnViewInSpecification"
        Me.btnViewInSpecification.Size = New System.Drawing.Size(149, 23)
        Me.btnViewInSpecification.TabIndex = 8
        Me.btnViewInSpecification.Text = "View in specification"
        Me.btnViewInSpecification.UseVisualStyleBackColor = True
        '
        'btnViewGuidance
        '
        Me.btnViewGuidance.Enabled = False
        Me.btnViewGuidance.Location = New System.Drawing.Point(171, 359)
        Me.btnViewGuidance.Name = "btnViewGuidance"
        Me.btnViewGuidance.Size = New System.Drawing.Size(149, 23)
        Me.btnViewGuidance.TabIndex = 9
        Me.btnViewGuidance.Text = "View guidance"
        Me.btnViewGuidance.UseVisualStyleBackColor = True
        '
        'btnViewManufacturerInfo
        '
        Me.btnViewManufacturerInfo.Enabled = False
        Me.btnViewManufacturerInfo.Location = New System.Drawing.Point(326, 359)
        Me.btnViewManufacturerInfo.Name = "btnViewManufacturerInfo"
        Me.btnViewManufacturerInfo.Size = New System.Drawing.Size(149, 23)
        Me.btnViewManufacturerInfo.TabIndex = 10
        Me.btnViewManufacturerInfo.Text = "View manufacturer info"
        Me.btnViewManufacturerInfo.UseVisualStyleBackColor = True
        '
        'btnShowAnnotationInfo
        '
        Me.btnShowAnnotationInfo.Enabled = False
        Me.btnShowAnnotationInfo.Location = New System.Drawing.Point(171, 435)
        Me.btnShowAnnotationInfo.Name = "btnShowAnnotationInfo"
        Me.btnShowAnnotationInfo.Size = New System.Drawing.Size(136, 23)
        Me.btnShowAnnotationInfo.TabIndex = 14
        Me.btnShowAnnotationInfo.Text = "Return annotation info"
        Me.btnShowAnnotationInfo.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 537)
        Me.Controls.Add(Me.btnShowAnnotationInfo)
        Me.Controls.Add(Me.btnViewManufacturerInfo)
        Me.Controls.Add(Me.btnViewGuidance)
        Me.Controls.Add(Me.btnViewInSpecification)
        Me.Controls.Add(Me.btnAddAnnotation)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnShowReport)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lvAnnotations)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblSpecification)
        Me.Controls.Add(Me.btnBrowseToSpecification)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Annotator_VBNet"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBrowseToSpecification As System.Windows.Forms.Button
    Friend WithEvents lblSpecification As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lvAnnotations As System.Windows.Forms.ListView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnShowReport As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAddAnnotation As System.Windows.Forms.Button
    Friend WithEvents btnViewInSpecification As System.Windows.Forms.Button
    Friend WithEvents colSectionCode As System.Windows.Forms.ColumnHeader
    Friend WithEvents colSectionNumber As System.Windows.Forms.ColumnHeader
    Friend WithEvents colClauseNumber As System.Windows.Forms.ColumnHeader
    Friend WithEvents colClauseTitle As System.Windows.Forms.ColumnHeader
    Friend WithEvents colAnnotationText As System.Windows.Forms.ColumnHeader
    Friend WithEvents colHiddenNumber As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnViewGuidance As System.Windows.Forms.Button
    Friend WithEvents btnViewManufacturerInfo As System.Windows.Forms.Button
    Friend WithEvents btnShowAnnotationInfo As System.Windows.Forms.Button

End Class
