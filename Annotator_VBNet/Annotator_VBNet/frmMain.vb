''' <summary>
''' A simple form demonstrating the principles of annotating from
''' an NBS specification document and then generating a report
''' on the status of these
''' 
''' This component and this code are for use by companies subscribing to NBS
''' products and may not be used for commercial applications.
''' For permissions to redistribute this component please contact NBS at:
''' support@theNBS.com
''' </summary>
''' <remarks></remarks>


Public Class frmMain

    ' the file path for the associated NBS specification
    Private m_strSpecificationFilePath As String


    ''' <summary>
    ''' The model must be associated with a single specification, set of prelims
    ''' or schedule of work
    ''' The AnnotationManager object may be declared as a member variable and reused, but
    ''' for simplicity it is used "as new" in each of the following methods.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnBrowseToSpecification_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseToSpecification.Click
        ' Create an Annotation Manager object
        Dim objAnnMan As New NBSAnnotationManager.AnnotationManager

        ' Browse to a valid NBS document
        Dim strSpecificationFilePath As String = ""
        strSpecificationFilePath = objAnnMan.SelectSpecification()
        If strSpecificationFilePath <> "" Then
            ' Set the label in the UI
            lblSpecification.Text = strSpecificationFilePath
            ' Store this as a member variable
            m_strSpecificationFilePath = strSpecificationFilePath
            ' Enable further actions
            EnableButtons(True)
            ' Now the specification is set, disable this button
            btnBrowseToSpecification.Enabled = False
        Else
            ' no valid specification has been set
            EnableButtons(False)
        End If
    End Sub


    ''' <summary>
    ''' The user may now browse to the specification and pick a clause for annotation
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnAddAnnotation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddAnnotation.Click
        ' Create an Annotation Manager object
        Dim objAnnMan As New NBSAnnotationManager.AnnotationManager
        ' Create an Annotation object
        Dim objAnnotation As NBSAnnotationManager.Annotation
        ' Show the Annotation Picker and wait until a valid annotation is returned
        objAnnotation = objAnnMan.SelectAnnotation(m_strSpecificationFilePath)
        If objAnnotation IsNot Nothing Then
            ' Add annotation to list view
            AddAnnotationToListView(objAnnotation)
        End If
    End Sub


    ''' <summary>
    ''' The user may want to open a specification at the selected clause
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnViewInSpecification_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewInSpecification.Click
        ' Create an Annotation Manager object
        Dim objAnnotation As NBSAnnotationManager.Annotation
        objAnnotation = ReturnSelectedAnnotation()
        If objAnnotation IsNot Nothing Then
            ' If a valid item in the list view is selected then
            ' we ask the Annotation Manager to display this in the relevant NBS Product
            Dim objAnnMan As New NBSAnnotationManager.AnnotationManager
            objAnnMan.LaunchSpecification(m_strSpecificationFilePath, objAnnotation)
        End If
    End Sub


    ' View the guidance of the selected annotation. If no annotation object is passed, show root guidance file.
    Private Sub btnViewGuidance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewGuidance.Click
        ' Create an Annotation Manager object
        Dim objAnnotation As NBSAnnotationManager.Annotation
        objAnnotation = ReturnSelectedAnnotation()
        If objAnnotation IsNot Nothing Then
            ' If a valid item in the list view is selected then
            ' we ask the Annotation Manager to display this in the relevant NBS Product
            Dim objAnnMan As New NBSAnnotationManager.AnnotationManager
            objAnnMan.ShowGuidance(m_strSpecificationFilePath, objAnnotation)
        End If
    End Sub


    ' View the manufacture information of the selected annotation. If no annotation object is passed, show manufacture homepage.
    Private Sub btnViewManufacturerInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewManufacturerInfo.Click
        ' Create an Annotation Manager object
        Dim objAnnotation As NBSAnnotationManager.Annotation
        objAnnotation = ReturnSelectedAnnotation()
        If objAnnotation IsNot Nothing Then
            ' If a valid item in the list view is selected then
            ' we ask the Annotation Manager to display this in the relevant NBS Product
            Dim objAnnMan As New NBSAnnotationManager.AnnotationManager
            objAnnMan.ShowManufacturersInfo(m_strSpecificationFilePath, objAnnotation)
        End If
    End Sub


    ' Returns latest NBS information to compare against annotations in the model.
    Private Sub btnShowAnnotationInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowAnnotationInfo.Click
        ' Create an Annotation Manager object
        Dim objAnnotationManager As New NBSAnnotationManager.AnnotationManager
        Dim objAnnotations As NBSAnnotationManager.Annotations
        objAnnotations = ReturnAnnotationsFromListView()

        objAnnotationManager.UpdateAnnotations(m_strSpecificationFilePath, objAnnotations)

        Dim strLatestTitles As String = ""
        strLatestTitles = "Latest titles from specification below." & vbCrLf & vbCrLf & _
                            "The calling program should check these against what is in the model" & vbCrLf & _
                            "if they have been modified in the spec: " & vbCrLf & vbCrLf

        Dim objAnn As NBSAnnotationManager.Annotation
        Dim n As Integer
        For n = 0 To objAnnotations.Count - 1
            objAnn = objAnnotations.Item(n)
            strLatestTitles = strLatestTitles & objAnn.DisplayTitle & vbCrLf
        Next

        MsgBox(strLatestTitles)

    End Sub


    ''' <summary>
    ''' Show report showing the status of the annotations against the latest
    ''' version of the project spec
    ''' Please note, that to test this properly you should exclude and modify
    ''' some clauses
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnShowReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowReport.Click
        ' Generate validity report based on annotations object or xml file
        ' There are two ways of doing this
        ' and the method is overloaded
        ' 1. Pass the annotation info as a collection of Annotations
        Dim objAnnMan As New NBSAnnotationManager.AnnotationManager
        Dim objAnnotations As NBSAnnotationManager.Annotations
        ' Internal method that loops through the list view
        objAnnotations = ReturnAnnotationsFromListView()
        objAnnMan.DisplayReport(m_strSpecificationFilePath, "c:\doesnt really matter\model.mdl", _
                                            objAnnotations)
        ' 2. Pass the annotation info in an XML format that verifies
        '    against the schema
        ' Test for XML version
        'objAnnMan.DisplayReport("C:\NBS Documents\destination specification.spec", _
        '                        "c:\Bills of Quants\Bill505.xls", _
        '                        "C:\NBS Documents\destination specification.spec.nbsrpt")

    End Sub


    ''' <summary>
    ''' Method that takes an Annotation object and adds its details to the list view
    ''' </summary>
    ''' <param name="objA">Annotation object</param>
    ''' <remarks></remarks>
    Private Sub AddAnnotationToListView(ByVal objA As NBSAnnotationManager.Annotation)
        Dim objLV As New ListViewItem
        ' Add the basic values
        objLV.Text = objA.Group
        objLV.SubItems.Add(objA.SectionKey)
        objLV.SubItems.Add(objA.Number)
        objLV.SubItems.Add(objA.NBSTitle)
        objLV.SubItems.Add(objA.DisplayTitle)
        objLV.SubItems.Add(objA.HiddenNumber)
        ' And as the tag add the annotation object itself
        objLV.Tag = objA
        ' Now add to list view
        lvAnnotations.Items.Add(objLV)
    End Sub


    ''' <summary>
    ''' Method to be used to enable the functional button
    ''' </summary>
    ''' <param name="bEnable">Boolean - specifying whether buttons should be enabled or disabled</param>
    ''' <remarks></remarks>
    Private Sub EnableButtons(ByVal bEnable As Boolean)
        btnAddAnnotation.Enabled = bEnable
        btnShowReport.Enabled = bEnable
        btnShowAnnotationInfo.Enabled = bEnable
    End Sub


    ''' <summary>
    ''' Method to return the currently selected annotation node if one is selected.
    ''' </summary>
    ''' <returns>Annotation object</returns>
    ''' <remarks></remarks>
    Private Function ReturnSelectedAnnotation() As NBSAnnotationManager.Annotation
        If lvAnnotations.SelectedItems.Count = 1 Then
            Dim objSelectedItem As ListViewItem
            objSelectedItem = lvAnnotations.SelectedItems(0)
            Return CType(objSelectedItem.Tag, NBSAnnotationManager.Annotation)
        Else
            Return Nothing
        End If
    End Function


    ''' <summary>
    ''' Method to gather each annotation from the list view and place it into an annotations object
    ''' </summary>
    ''' <returns>Annotations object (collection of Annotation objects)</returns>
    ''' <remarks></remarks>
    Private Function ReturnAnnotationsFromListView() As NBSAnnotationManager.Annotations
        Dim objListViewItem As ListViewItem
        Dim objAnnotations As New NBSAnnotationManager.Annotations
        For Each objListViewItem In lvAnnotations.Items
            Dim objAnnotation As NBSAnnotationManager.Annotation
            objAnnotation = CType(objListViewItem.Tag, NBSAnnotationManager.Annotation)
            objAnnotations.Add(objAnnotation)
        Next
        Return objAnnotations
    End Function


    ''' <summary>
    ''' Only enable specific buttons based on if an annotation in the list view is selected
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub lvAnnotations_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvAnnotations.SelectedIndexChanged
        Dim objAnnotation As NBSAnnotationManager.Annotation
        objAnnotation = ReturnSelectedAnnotation()
        If objAnnotation IsNot Nothing Then
            Debug.Print(objAnnotation.HiddenNumber)
            btnViewInSpecification.Enabled = True
            btnViewGuidance.Enabled = True
            btnViewManufacturerInfo.Enabled = True
        Else
            btnViewInSpecification.Enabled = False
            btnViewGuidance.Enabled = False
            btnViewManufacturerInfo.Enabled = False
        End If
    End Sub


    ''' <summary>
    ''' Close the form when button clicked
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

End Class
