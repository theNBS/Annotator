VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form frmMain 
   Caption         =   "Annotator_VB6"
   ClientHeight    =   8130
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   9480
   LinkTopic       =   "Form1"
   ScaleHeight     =   8130
   ScaleWidth      =   9480
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton btnReturnAnnotations 
      Caption         =   "Return annotation info"
      Enabled         =   0   'False
      Height          =   375
      Left            =   2880
      TabIndex        =   11
      Top             =   6480
      Width           =   2175
   End
   Begin VB.CommandButton btnViewManufacturerInfo 
      Caption         =   "View manufacturer info"
      Enabled         =   0   'False
      Height          =   375
      Left            =   4680
      TabIndex        =   8
      Top             =   5400
      Width           =   2175
   End
   Begin VB.CommandButton btnViewGuidance 
      Caption         =   "View guidance"
      Enabled         =   0   'False
      Height          =   375
      Left            =   2640
      TabIndex        =   7
      Top             =   5400
      Width           =   1815
   End
   Begin VB.CommandButton btnClose 
      Caption         =   "Close"
      Height          =   375
      Left            =   7680
      TabIndex        =   12
      Top             =   7320
      Width           =   1455
   End
   Begin VB.CommandButton btnShowReport 
      Caption         =   "Show NBS Annotator report"
      Enabled         =   0   'False
      Height          =   375
      Left            =   360
      TabIndex        =   10
      Top             =   6480
      Width           =   2295
   End
   Begin VB.CommandButton btnViewInSpecification 
      Caption         =   "View in specification"
      Enabled         =   0   'False
      Height          =   375
      Left            =   360
      TabIndex        =   6
      Top             =   5400
      Width           =   2055
   End
   Begin VB.CommandButton btnAddAnnotation 
      Caption         =   "Add annotation"
      Enabled         =   0   'False
      Height          =   375
      Left            =   360
      TabIndex        =   4
      Top             =   2160
      Width           =   2295
   End
   Begin MSComctlLib.ListView lvAnnotations 
      Height          =   2655
      Left            =   360
      TabIndex        =   5
      Top             =   2640
      Width           =   8775
      _ExtentX        =   15478
      _ExtentY        =   4683
      View            =   3
      LabelEdit       =   1
      LabelWrap       =   -1  'True
      HideSelection   =   -1  'True
      FullRowSelect   =   -1  'True
      _Version        =   393217
      ForeColor       =   -2147483640
      BackColor       =   -2147483643
      BorderStyle     =   1
      Appearance      =   1
      NumItems        =   6
      BeginProperty ColumnHeader(1) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         Text            =   "Group"
         Object.Width           =   2540
      EndProperty
      BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   1
         Text            =   "Section"
         Object.Width           =   2540
      EndProperty
      BeginProperty ColumnHeader(3) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   2
         Text            =   "Clause"
         Object.Width           =   2540
      EndProperty
      BeginProperty ColumnHeader(4) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   3
         Text            =   "Title"
         Object.Width           =   2540
      EndProperty
      BeginProperty ColumnHeader(5) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   4
         Text            =   "Display Title"
         Object.Width           =   2540
      EndProperty
      BeginProperty ColumnHeader(6) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   5
         Text            =   "ID"
         Object.Width           =   2540
      EndProperty
   End
   Begin VB.CommandButton btnBrowseToSpecification 
      Caption         =   "Browse to specification"
      Height          =   375
      Left            =   360
      TabIndex        =   1
      Top             =   720
      Width           =   2415
   End
   Begin VB.Line Line3 
      X1              =   360
      X2              =   9120
      Y1              =   7080
      Y2              =   7080
   End
   Begin VB.Label Label3 
      Caption         =   "Step 3. Generate annotations report"
      Height          =   255
      Left            =   360
      TabIndex        =   9
      Top             =   6120
      Width           =   3135
   End
   Begin VB.Line Line2 
      X1              =   360
      X2              =   9120
      Y1              =   6000
      Y2              =   6000
   End
   Begin VB.Label Label2 
      Caption         =   "Step 2. Work with the annotations"
      Height          =   375
      Left            =   360
      TabIndex        =   3
      Top             =   1800
      Width           =   4815
   End
   Begin VB.Line Line1 
      X1              =   360
      X2              =   9120
      Y1              =   1680
      Y2              =   1680
   End
   Begin VB.Label lblSpecification 
      Caption         =   "[no specification selected]"
      Height          =   255
      Left            =   360
      TabIndex        =   2
      Top             =   1320
      Width           =   8775
   End
   Begin VB.Label Label1 
      Caption         =   "Step 1. Associate specification"
      Height          =   255
      Left            =   360
      TabIndex        =   0
      Top             =   240
      Width           =   2295
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
' A simple form demonstrating the principles of annotating from
' an NBS specification document and then generating a report
' on the status of these
'
' This component and this code are for use by companies subscribing to NBS
' products and may not be used for commercial applications.
' For permissions to redistribute this component please contact NBS at:
' support@theNBS.com

' the file path for the associated NBS specification
Private m_strSpecificationFilePath As String

' The model must be associated with a single specification, set of prelims
' or schedule of work
' The AnnotationManager object may be declared as a member variable and reused, but
' for simplicity it is used "as new" in each of the following methods.
Private Sub btnBrowseToSpecification_Click()
    ' Create an Annotation Manager object
    Dim objAnnMan As New NBSAnnotationManager.AnnotationManager
    ' Browse to a valid NBS document
    Dim strSpecificationFilePath As String
    strSpecificationFilePath = ""
    strSpecificationFilePath = objAnnMan.SelectSpecification
    If strSpecificationFilePath <> "" Then
        ' Set the label in the UI
        lblSpecification.Caption = strSpecificationFilePath
        ' Store this as a member variable
        m_strSpecificationFilePath = strSpecificationFilePath
        ' Enable further actions
        EnableButtons True
        ' Now the specification is set, disable this button
        btnBrowseToSpecification.Enabled = False
    Else
        ' no valid specification has been set
        EnableButtons False
    End If
End Sub

' The user may now browse to the specification and pick a clause for annotation
Private Sub btnAddAnnotation_Click()
    ' Create an Annotation Manager object
    Dim objAnnMan As New NBSAnnotationManager.AnnotationManager
    ' Create an Annotation object
    Dim objAnnotation As NBSAnnotationManager.Annotation
    ' Show the Annotation Picker and wait until a valid annotation is returned
    Set objAnnotation = objAnnMan.SelectAnnotation(m_strSpecificationFilePath)
    If Not objAnnotation Is Nothing Then
        ' Add annotation to list view
        AddAnnotationToListView objAnnotation
    End If
End Sub


' The user may want to open a specification at the selected clause
Private Sub btnViewInSpecification_Click()
    ' Create an Annotation Manager object
    Dim objAnnotation As NBSAnnotationManager.Annotation
    Set objAnnotation = ReturnSelectedAnnotation()
    If Not objAnnotation Is Nothing Then
        ' If a valid item in the list view is selected then
        ' we ask the Annotation Manager to display this in the relevant NBS Product
        Dim objAnnMan As New NBSAnnotationManager.AnnotationManager
        ' Note that the second method here takes in an annotation object
        objAnnMan.LaunchSpecification_2 m_strSpecificationFilePath, objAnnotation
    End If
End Sub

' View the guidance of the selected annotation. If no annotation object is passed, show root guidance file.
Private Sub btnViewGuidance_Click()
    ' Create an Annotation Manager object
    Dim objAnnotation As NBSAnnotationManager.Annotation
    Set objAnnotation = ReturnSelectedAnnotation()
    If Not objAnnotation Is Nothing Then
        ' If a valid item in the list view is selected then
        ' we ask the Annotation Manager to display this in the relevant NBS Product
        Dim objAnnMan As New NBSAnnotationManager.AnnotationManager
        ' Note that the second method here takes in an annotation object
        objAnnMan.ShowGuidance_2 m_strSpecificationFilePath, objAnnotation
    End If
End Sub

' View the manufacture information of the selected annotation. If no annotation object is passed, show manufacture homepage.
Private Sub btnViewManufacturerInfo_Click()
    ' Create an Annotation Manager object
    Dim objAnnotation As NBSAnnotationManager.Annotation
    Set objAnnotation = ReturnSelectedAnnotation()
    If Not objAnnotation Is Nothing Then
        ' If a valid item in the list view is selected then
        ' we ask the Annotation Manager to display this in the relevant NBS Product
        Dim objAnnMan As New NBSAnnotationManager.AnnotationManager
        ' Note that the second method here takes in an annotation object
        objAnnMan.ShowManufacturersInfo_2 m_strSpecificationFilePath, objAnnotation
    End If
End Sub

' Show report showing the status of the annotations against the latest
' version of the project spec
' Please note, that to test this properly you should exclude and modify
Private Sub btnShowReport_Click()
    ' Create an Annotation Manager object
    Dim objAnnMan As New NBSAnnotationManager.AnnotationManager
    Dim objAnnotations As NBSAnnotationManager.Annotations
    ' Internal method that loops through the list view
    Set objAnnotations = ReturnAnnotationsFromListView()
    objAnnMan.DisplayReport m_strSpecificationFilePath, "c:\doesnt really matter\model.mdl", _
                                           objAnnotations

End Sub

' Returns latest NBS information to compare against annotations in the model.
Private Sub btnReturnAnnotations_Click()
    ' Create an Annotation Manager object
    Dim objAnnotationManager As New NBSAnnotationManager.AnnotationManager
    Dim objAnnotations As NBSAnnotationManager.Annotations
    Set objAnnotations = ReturnAnnotationsFromListView()
    
    objAnnotationManager.UpdateAnnotations m_strSpecificationFilePath, objAnnotations
    
    Dim strLatestTitles As String
    strLatestTitles = "Latest titles from specification below." & vbCrLf & vbCrLf & _
                        "The calling program should check these against what is in the model" & vbCrLf & _
                        "in they have been modified in the spec: " & vbCrLf & vbCrLf
    
    Dim objAnn As NBSAnnotationManager.Annotation
    Dim n As Integer
    For n = 0 To objAnnotations.Count - 1
        Set objAnn = objAnnotations.Item(n)
        strLatestTitles = strLatestTitles & objAnn.DisplayTitle & vbCrLf
    Next
    
    MsgBox (strLatestTitles)

End Sub

' Method that takes an Annotation object and adds its details to the list view
Private Sub AddAnnotationToListView(objAnn As NBSAnnotationManager.Annotation)
    Dim objLV As ListItem
    Set objLV = lvAnnotations.ListItems.Add()
    ' Add the basic values
    objLV.Text = objAnn.Group
    objLV.SubItems(1) = objAnn.SectionKey
    objLV.SubItems(2) = objAnn.Number
    objLV.SubItems(3) = objAnn.NBSTitle
    objLV.SubItems(4) = objAnn.DisplayTitle
    objLV.SubItems(5) = objAnn.HiddenNumber
End Sub

' Method to return the currently selected annotation node if one is selected.
Private Function ReturnSelectedAnnotation() As NBSAnnotationManager.Annotation
    If Not lvAnnotations.SelectedItem Is Nothing Then
        Dim objSelectedItem As ListItem
        Set objSelectedItem = lvAnnotations.SelectedItem
        Dim objAnn As New Annotation
        
        With objSelectedItem
            objAnn.Group = .Text
            objAnn.SectionKey = .SubItems(1)
            objAnn.Number = .SubItems(2)
            objAnn.NBSTitle = .SubItems(3)
            objAnn.DisplayTitle = .SubItems(4)
            objAnn.HiddenNumber = .SubItems(5)
        End With
        
        Set ReturnSelectedAnnotation = objAnn
    Else
        Set ReturnSelectedAnnotation = Nothing
    End If
End Function

' Method to gather each annotation from the list view and place it into an annotations object
Private Function ReturnAnnotationsFromListView() As NBSAnnotationManager.Annotations
    Dim objListViewItem As ListItem
    Dim objAnnotations As New NBSAnnotationManager.Annotations
    For Each objListViewItem In lvAnnotations.ListItems
        Dim objAnnotation As New NBSAnnotationManager.Annotation
        
        With objListViewItem
            objAnnotation.Group = .Text
            objAnnotation.SectionKey = .SubItems(1)
            objAnnotation.Number = .SubItems(2)
            objAnnotation.NBSTitle = .SubItems(3)
            objAnnotation.DisplayTitle = .SubItems(4)
            objAnnotation.HiddenNumber = .SubItems(5)
        End With
        
        objAnnotations.Add objAnnotation
        Set objAnnotation = Nothing
    Next
    Set ReturnAnnotationsFromListView = objAnnotations
End Function

' Method to be used to enable the functional button
Private Function EnableButtons(enable As Boolean)
    btnAddAnnotation.Enabled = enable
    btnViewInSpecification.Enabled = enable
    btnViewGuidance.Enabled = enable
    btnViewManufacturerInfo.Enabled = enable
    btnShowReport.Enabled = enable
    btnReturnAnnotations.Enabled = enable
End Function

' Close the application
Private Sub btnClose_Click()
    End
End Sub

