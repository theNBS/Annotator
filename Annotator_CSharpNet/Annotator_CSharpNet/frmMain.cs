using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


/// A simple form demonstrating the principles of annotating from
/// an NBS specification document and then generating a report
/// on the status of these
/// 
/// This component and this code are for use by companies subscribing to NBS
/// products and may not be used for commercial applications.
/// For permissions to redistribute this component please contact NBS at:
/// support@theNBS.com


namespace Annotator_CSharpNet
{
    public partial class frmMain : Form
    {
        // The file path for the associated NBS specification
        private string m_strSpecificationFilePath;

        public frmMain()
        {
            InitializeComponent();
        }

        /// The model must be associated with a single specification, set of prelims
        /// or schedule of work
        /// The AnnotationManager object may be declared as a member variable and reused, but
        /// for simplicity it is used "as new" in each of the following methods.
        private void btnBrowseToSpecification_Click(object sender, EventArgs e)
        {
            // Create an Annotation Manager object
            NBSAnnotationManager.AnnotationManager objAnnMan = new NBSAnnotationManager.AnnotationManager();
            // Browse to a valid NBS document
            string strSpecificationFilePath = objAnnMan.SelectSpecification();
            if (!string.IsNullOrEmpty(strSpecificationFilePath))
            {
                // Set the label in the UI
                lblSpecification.Text = strSpecificationFilePath;
                // Store this as a member variable
                m_strSpecificationFilePath = strSpecificationFilePath;
                // Enable further actions
                EnableButtons(true);
                // Now the specification is set, disable this button
                btnBrowseToSpecification.Enabled = false;
            }
            else
            {
                // no valid specification has been set
                EnableButtons(false);
            }
        }


        /// The user may now browse to the specification and pick a clause for annotation
        private void btnAddAnnotation_Click(object sender, EventArgs e)
        {
            // Create an Annotation Manager object
            NBSAnnotationManager.AnnotationManager objAnnMan = new NBSAnnotationManager.AnnotationManager();
            // Create an Annotation object for returned annotation
            NBSAnnotationManager.Annotation objAnnotation = default(NBSAnnotationManager.Annotation);
            // Get the currently selected annotation
            NBSAnnotationManager.Annotation objSelectedAnnotation = ReturnSelectedAnnotation();

            // Show the Annotation Picker and wait until a valid annotation is returned
            objAnnotation = objAnnMan.SelectAnnotation(m_strSpecificationFilePath, objSelectedAnnotation);
            if (objAnnotation != null)
            {
                // Add annotation to list view
                AddAnnotationToListView(objAnnotation);
            }
        }


        /// The user may want to open a specification at the selected clause
        private void btnViewInSpecification_Click(object sender, EventArgs e)
        // Launch the document in its parent application, eg NBS Building. If annotation object is passed then open that clause in document.
        {
            // Create an Annotation Manager object
            NBSAnnotationManager.Annotation objAnnotation = default(NBSAnnotationManager.Annotation);
            objAnnotation = ReturnSelectedAnnotation();
            if (objAnnotation != null)
            {
                // If a valid item in the list view is selected then
                // we ask the Annotation Manager to display this in the relevant NBS Product
                NBSAnnotationManager.AnnotationManager objAnnMan = new NBSAnnotationManager.AnnotationManager();
                objAnnMan.LaunchSpecification(m_strSpecificationFilePath, objAnnotation);
            }
        }


        // View the guidance of the selected annotation. If no annotation object is passed, show root guidance file.
        private void btnViewGuidance_Click(object sender, EventArgs e)
        {
            // Create an Annotation Manager object
            NBSAnnotationManager.Annotation objAnnotation = default(NBSAnnotationManager.Annotation);
            objAnnotation = ReturnSelectedAnnotation();
            if (objAnnotation != null)
            {
                // If a valid item in the list view is selected then
                // we ask the Annotation Manager to display this in the relevant NBS Product
                NBSAnnotationManager.AnnotationManager objAnnMan = new NBSAnnotationManager.AnnotationManager();
                objAnnMan.ShowGuidance(m_strSpecificationFilePath, objAnnotation);
            }
        }


        // View the manufacture information of the selected annotation. If no annotation object is passed, show manufacture homepage.
        private void btnViewManufacturerInfo_Click(object sender, EventArgs e)
        {
            // Create an Annotation Manager object
            NBSAnnotationManager.Annotation objAnnotation = default(NBSAnnotationManager.Annotation);
            objAnnotation = ReturnSelectedAnnotation();
            if (objAnnotation != null)
            {
                // If a valid item in the list view is selected then
                // we ask the Annotation Manager to display this in the relevant NBS Product
                NBSAnnotationManager.AnnotationManager objAnnMan = new NBSAnnotationManager.AnnotationManager();
                objAnnMan.ShowManufacturersInfo(m_strSpecificationFilePath, objAnnotation);
            }
        }


        // Returns latest NBS information to compare against annotations in the model.
        private void btnShowAnnotationInfo_Click(object sender, EventArgs e)
        {
            // Create an Annotation Manager object
            NBSAnnotationManager.AnnotationManager objAnnotationManager = new NBSAnnotationManager.AnnotationManager();
            NBSAnnotationManager.Annotations objAnnotations = default(NBSAnnotationManager.Annotations);
            objAnnotations = ReturnAnnotationsFromListView();

            objAnnotationManager.UpdateAnnotations(m_strSpecificationFilePath, ref objAnnotations);

            string strLatestTitles = "";
            strLatestTitles = "Latest titles from specification below." + "\r" + "\r" + "The calling program should check these against what is in the model" + "\r" + "if they have been modified in the spec: " + "\r" + "\r";

            NBSAnnotationManager.Annotation objAnn = default(NBSAnnotationManager.Annotation);
            int n = 0;
            for (n = 0; n <= objAnnotations.Count - 1; n++)
            {
                objAnn = objAnnotations.get_Item(n);
                strLatestTitles = strLatestTitles + objAnn.DisplayTitle + "\r";
            }


            MessageBox.Show(strLatestTitles);
        }


        /// Show report showing the status of the annotations against the latest
        /// version of the project spec
        /// Please note, that to test this properly you should exclude and modify
        /// some clauses
        private void btnShowReport_Click(object sender, EventArgs e)
        // Generate validity report based on annotations object or xml file
        {
            // There are two ways of doing this
            // and the method is overloaded
            // 1. Pass the annotation info as a collection of Annotations
            NBSAnnotationManager.AnnotationManager objAnnMan = new NBSAnnotationManager.AnnotationManager();
            NBSAnnotationManager.Annotations objAnnotations = default(NBSAnnotationManager.Annotations);
            // Internal method that loops through the list view
            objAnnotations = ReturnAnnotationsFromListView();
            // 2. Pass the annotation info in an XML format that verifies
            // against the schema
            // Test for XML version
            // objAnnMan.DisplayReport(m_strSpecificationFilePath, "c:\\doesnt really matter\\model.mdl", "C:\\NBS Documents\\destination specification.spec.nbsrpt");

            objAnnMan.DisplayReport(m_strSpecificationFilePath, "c:\\doesnt really matter\\model.mdl", objAnnotations);
        }


        /// <summary>
        /// Method that takes an Annotation object and adds its details to the list view
        /// </summary>
        /// <param name="objA">Annotation object</param>
        /// <remarks></remarks>
        private void AddAnnotationToListView(NBSAnnotationManager.Annotation objA)
        {
            ListViewItem objLV = new ListViewItem();
            // Add the basic values
            objLV.Text = objA.Group;
            objLV.SubItems.Add(objA.SectionKey);
            objLV.SubItems.Add(objA.Number);
            objLV.SubItems.Add(objA.NBSTitle);
            objLV.SubItems.Add(objA.DisplayTitle);
            objLV.SubItems.Add(objA.HiddenNumber);
            // And as the tag add the annotation object itself
            objLV.Tag = objA;
            // Now add to list view
            lvAnnotations.Items.Add(objLV);
        }


        /// <summary>
        /// Method to be used to enable the functional button
        /// </summary>
        /// <param name="bEnable">Boolean - specifying whether buttons should be enabled or disabled</param>
        /// <remarks></remarks>
        private void EnableButtons(bool bEnable)
        {
            btnAddAnnotation.Enabled = bEnable;
            btnShowReport.Enabled = bEnable;
            btnShowAnnotationInfo.Enabled = bEnable;
        }


        /// <summary>
        /// Method to return the currently selected annotation node if one is selected.
        /// </summary>
        /// <returns>Annotation object</returns>
        /// <remarks></remarks>
        private NBSAnnotationManager.Annotation ReturnSelectedAnnotation()
        {
            if (lvAnnotations.SelectedItems.Count == 1)
            {
                ListViewItem objSelectedItem = default(ListViewItem);
                objSelectedItem = lvAnnotations.SelectedItems[0];
                return (NBSAnnotationManager.Annotation)objSelectedItem.Tag;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Method to gather each annotation from the list view and place it into an annotations object
        /// </summary>
        /// <returns>Annotations object (collection of Annotation objects)</returns>
        /// <remarks></remarks>
        private NBSAnnotationManager.Annotations ReturnAnnotationsFromListView()
        {
            NBSAnnotationManager.Annotations objAnnotations = new NBSAnnotationManager.Annotations();
            foreach (ListViewItem objListViewItem in lvAnnotations.Items)
            {
                NBSAnnotationManager.Annotation objAnnotation = default(NBSAnnotationManager.Annotation);
                objAnnotation = (NBSAnnotationManager.Annotation)objListViewItem.Tag;
                objAnnotations.Add(objAnnotation);
            }
            return objAnnotations;
        }


        /// Only enable specific buttons based on if an annotation in the list view is selected
        private void lvAnnotations_SelectedIndexChanged(object sender, EventArgs e)
        {
            NBSAnnotationManager.Annotation objAnnotation = default(NBSAnnotationManager.Annotation);
            objAnnotation = ReturnSelectedAnnotation();
            if (objAnnotation != null)
            {
                btnViewInSpecification.Enabled = true;
                btnViewGuidance.Enabled = true;
                btnViewManufacturerInfo.Enabled = true;
            }
            else
            {
                btnViewInSpecification.Enabled = false;
                btnViewGuidance.Enabled = false;
                btnViewManufacturerInfo.Enabled = false;
            }
        }


        /// Close the form when button clicked
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
