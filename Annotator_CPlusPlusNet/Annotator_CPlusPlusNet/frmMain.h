

#pragma region Init


namespace Annotator_CPlusPlusNet {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for Form1
	///
	/// WARNING: If you change the name of this class, you will need to change the
	///          'Resource File Name' property for the managed resource compiler tool
	///          associated with all .resx files this class depends on.  Otherwise,
	///          the designers will not be able to interact properly with localized
	///          resources associated with this form.
	/// </summary>
	public ref class Form1 : public System::Windows::Forms::Form
	{
	public:
		Form1(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~Form1()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Button^  btnSelectSpecification;

	protected: 

	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;
	private: System::Windows::Forms::Button^  btnAddAnnotation;
	private: System::Windows::Forms::Label^  lblSelectedSpec;
	internal: System::Windows::Forms::ListView^  lvAnnotations;
	private: 
	internal: System::Windows::Forms::ColumnHeader^  colSectionCode;
	internal: System::Windows::Forms::ColumnHeader^  colSectionNumber;
	internal: System::Windows::Forms::ColumnHeader^  colClauseNumber;
	internal: System::Windows::Forms::ColumnHeader^  colClauseTitle;
	internal: System::Windows::Forms::ColumnHeader^  colAnnotationText;
	internal: System::Windows::Forms::ColumnHeader^  colHiddenNumber;
	private: System::Windows::Forms::Label^  lblStep1;
	private: System::Windows::Forms::Label^  lblStep2;
	internal: 


	private: System::Windows::Forms::Button^  btnViewInSpec;
	private: System::Windows::Forms::Button^  btnViewInGuidance;
	private: System::Windows::Forms::Button^  btnViewInManuf;
	private: System::Windows::Forms::Label^  lblStep3;




	private: System::Windows::Forms::Button^  btnShowReport;
	private: System::Windows::Forms::Button^  btnReturnNBSAnnotations;


	private: System::Windows::Forms::Button^  btnClose;
	internal: System::Windows::Forms::GroupBox^  Seperator2;
	private: 

	internal: System::Windows::Forms::GroupBox^  Seperator1;
	internal: System::Windows::Forms::GroupBox^  Seperator3;
	private: 


	internal: 

			 System::String^ m_strSpec;

#pragma endregion

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->btnSelectSpecification = (gcnew System::Windows::Forms::Button());
			this->btnAddAnnotation = (gcnew System::Windows::Forms::Button());
			this->lblSelectedSpec = (gcnew System::Windows::Forms::Label());
			this->lvAnnotations = (gcnew System::Windows::Forms::ListView());
			this->colSectionCode = (gcnew System::Windows::Forms::ColumnHeader());
			this->colSectionNumber = (gcnew System::Windows::Forms::ColumnHeader());
			this->colClauseNumber = (gcnew System::Windows::Forms::ColumnHeader());
			this->colClauseTitle = (gcnew System::Windows::Forms::ColumnHeader());
			this->colAnnotationText = (gcnew System::Windows::Forms::ColumnHeader());
			this->colHiddenNumber = (gcnew System::Windows::Forms::ColumnHeader());
			this->lblStep1 = (gcnew System::Windows::Forms::Label());
			this->lblStep2 = (gcnew System::Windows::Forms::Label());
			this->btnViewInSpec = (gcnew System::Windows::Forms::Button());
			this->btnViewInGuidance = (gcnew System::Windows::Forms::Button());
			this->btnViewInManuf = (gcnew System::Windows::Forms::Button());
			this->lblStep3 = (gcnew System::Windows::Forms::Label());
			this->btnShowReport = (gcnew System::Windows::Forms::Button());
			this->btnReturnNBSAnnotations = (gcnew System::Windows::Forms::Button());
			this->btnClose = (gcnew System::Windows::Forms::Button());
			this->Seperator2 = (gcnew System::Windows::Forms::GroupBox());
			this->Seperator1 = (gcnew System::Windows::Forms::GroupBox());
			this->Seperator3 = (gcnew System::Windows::Forms::GroupBox());
			this->SuspendLayout();
			// 
			// btnSelectSpecification
			// 
			this->btnSelectSpecification->Location = System::Drawing::Point(12, 29);
			this->btnSelectSpecification->Name = L"btnSelectSpecification";
			this->btnSelectSpecification->Size = System::Drawing::Size(131, 23);
			this->btnSelectSpecification->TabIndex = 1;
			this->btnSelectSpecification->Text = L"Select Specification";
			this->btnSelectSpecification->UseVisualStyleBackColor = true;
			this->btnSelectSpecification->Click += gcnew System::EventHandler(this, &Form1::btnSelectSpecification_Click);
			// 
			// btnAddAnnotation
			// 
			this->btnAddAnnotation->Enabled = false;
			this->btnAddAnnotation->Location = System::Drawing::Point(12, 115);
			this->btnAddAnnotation->Name = L"btnAddAnnotation";
			this->btnAddAnnotation->Size = System::Drawing::Size(131, 23);
			this->btnAddAnnotation->TabIndex = 4;
			this->btnAddAnnotation->Text = L"Add Annotation";
			this->btnAddAnnotation->UseVisualStyleBackColor = true;
			this->btnAddAnnotation->Click += gcnew System::EventHandler(this, &Form1::btnAddAnnotation_Click);
			// 
			// lblSelectedSpec
			// 
			this->lblSelectedSpec->AutoSize = true;
			this->lblSelectedSpec->Location = System::Drawing::Point(12, 60);
			this->lblSelectedSpec->Name = L"lblSelectedSpec";
			this->lblSelectedSpec->Size = System::Drawing::Size(136, 13);
			this->lblSelectedSpec->TabIndex = 2;
			this->lblSelectedSpec->Text = L"[ no specification selected ]";
			// 
			// lvAnnotations
			// 
			this->lvAnnotations->Columns->AddRange(gcnew cli::array< System::Windows::Forms::ColumnHeader^  >(6) {this->colSectionCode, 
				this->colSectionNumber, this->colClauseNumber, this->colClauseTitle, this->colAnnotationText, this->colHiddenNumber});
			this->lvAnnotations->FullRowSelect = true;
			this->lvAnnotations->HideSelection = false;
			this->lvAnnotations->Location = System::Drawing::Point(12, 150);
			this->lvAnnotations->Name = L"lvAnnotations";
			this->lvAnnotations->Size = System::Drawing::Size(595, 174);
			this->lvAnnotations->TabIndex = 5;
			this->lvAnnotations->UseCompatibleStateImageBehavior = false;
			this->lvAnnotations->View = System::Windows::Forms::View::Details;
			this->lvAnnotations->SelectedIndexChanged += gcnew System::EventHandler(this, &Form1::lvAnnotations_SelectedIndexChanged);
			// 
			// colSectionCode
			// 
			this->colSectionCode->Text = L"Group";
			// 
			// colSectionNumber
			// 
			this->colSectionNumber->Text = L"Section";
			this->colSectionNumber->Width = 62;
			// 
			// colClauseNumber
			// 
			this->colClauseNumber->Text = L"Clause";
			this->colClauseNumber->Width = 61;
			// 
			// colClauseTitle
			// 
			this->colClauseTitle->Text = L"Title";
			this->colClauseTitle->Width = 137;
			// 
			// colAnnotationText
			// 
			this->colAnnotationText->Text = L"Display";
			this->colAnnotationText->Width = 188;
			// 
			// colHiddenNumber
			// 
			this->colHiddenNumber->Text = L"ID";
			this->colHiddenNumber->Width = 68;
			// 
			// lblStep1
			// 
			this->lblStep1->AutoSize = true;
			this->lblStep1->Location = System::Drawing::Point(12, 7);
			this->lblStep1->Name = L"lblStep1";
			this->lblStep1->Size = System::Drawing::Size(152, 13);
			this->lblStep1->TabIndex = 0;
			this->lblStep1->Text = L"Step 1. Associate specification";
			// 
			// lblStep2
			// 
			this->lblStep2->AutoSize = true;
			this->lblStep2->Location = System::Drawing::Point(12, 90);
			this->lblStep2->Name = L"lblStep2";
			this->lblStep2->Size = System::Drawing::Size(168, 13);
			this->lblStep2->TabIndex = 3;
			this->lblStep2->Text = L"Step 2. Work with the annotations";
			// 
			// btnViewInSpec
			// 
			this->btnViewInSpec->Enabled = false;
			this->btnViewInSpec->Location = System::Drawing::Point(12, 358);
			this->btnViewInSpec->Name = L"btnViewInSpec";
			this->btnViewInSpec->Size = System::Drawing::Size(168, 23);
			this->btnViewInSpec->TabIndex = 6;
			this->btnViewInSpec->Text = L"View in specification";
			this->btnViewInSpec->UseVisualStyleBackColor = true;
			this->btnViewInSpec->Click += gcnew System::EventHandler(this, &Form1::btnViewInSpec_Click);
			// 
			// btnViewInGuidance
			// 
			this->btnViewInGuidance->Enabled = false;
			this->btnViewInGuidance->Location = System::Drawing::Point(186, 358);
			this->btnViewInGuidance->Name = L"btnViewInGuidance";
			this->btnViewInGuidance->Size = System::Drawing::Size(168, 23);
			this->btnViewInGuidance->TabIndex = 7;
			this->btnViewInGuidance->Text = L"View guidance";
			this->btnViewInGuidance->UseVisualStyleBackColor = true;
			this->btnViewInGuidance->Click += gcnew System::EventHandler(this, &Form1::btnViewInGuidance_Click);
			// 
			// btnViewInManuf
			// 
			this->btnViewInManuf->Enabled = false;
			this->btnViewInManuf->Location = System::Drawing::Point(360, 358);
			this->btnViewInManuf->Name = L"btnViewInManuf";
			this->btnViewInManuf->Size = System::Drawing::Size(168, 23);
			this->btnViewInManuf->TabIndex = 8;
			this->btnViewInManuf->Text = L"View manufacturer info";
			this->btnViewInManuf->UseVisualStyleBackColor = true;
			this->btnViewInManuf->Click += gcnew System::EventHandler(this, &Form1::btnViewInManuf_Click);
			// 
			// lblStep3
			// 
			this->lblStep3->AutoSize = true;
			this->lblStep3->Location = System::Drawing::Point(12, 404);
			this->lblStep3->Name = L"lblStep3";
			this->lblStep3->Size = System::Drawing::Size(121, 13);
			this->lblStep3->TabIndex = 9;
			this->lblStep3->Text = L"Step 3. Status checking";
			// 
			// btnShowReport
			// 
			this->btnShowReport->Enabled = false;
			this->btnShowReport->Location = System::Drawing::Point(12, 437);
			this->btnShowReport->Name = L"btnShowReport";
			this->btnShowReport->Size = System::Drawing::Size(168, 23);
			this->btnShowReport->TabIndex = 10;
			this->btnShowReport->Text = L"Show NBS Annotator report";
			this->btnShowReport->UseVisualStyleBackColor = true;
			this->btnShowReport->Click += gcnew System::EventHandler(this, &Form1::btnShowReport_Click);
			// 
			// btnReturnNBSAnnotations
			// 
			this->btnReturnNBSAnnotations->Enabled = false;
			this->btnReturnNBSAnnotations->Location = System::Drawing::Point(186, 437);
			this->btnReturnNBSAnnotations->Name = L"btnReturnNBSAnnotations";
			this->btnReturnNBSAnnotations->Size = System::Drawing::Size(168, 23);
			this->btnReturnNBSAnnotations->TabIndex = 11;
			this->btnReturnNBSAnnotations->Text = L"Return annotation info";
			this->btnReturnNBSAnnotations->UseVisualStyleBackColor = true;
			this->btnReturnNBSAnnotations->Click += gcnew System::EventHandler(this, &Form1::btnReturnNBSAnnotations_Click);
			// 
			// btnClose
			// 
			this->btnClose->Location = System::Drawing::Point(532, 479);
			this->btnClose->Name = L"btnClose";
			this->btnClose->Size = System::Drawing::Size(75, 23);
			this->btnClose->TabIndex = 12;
			this->btnClose->Text = L"Close";
			this->btnClose->UseVisualStyleBackColor = true;
			this->btnClose->Click += gcnew System::EventHandler(this, &Form1::btnClose_Click);
			// 
			// Seperator2
			// 
			this->Seperator2->BackColor = System::Drawing::Color::Black;
			this->Seperator2->Location = System::Drawing::Point(12, 398);
			this->Seperator2->Name = L"Seperator2";
			this->Seperator2->Size = System::Drawing::Size(595, 1);
			this->Seperator2->TabIndex = 17;
			this->Seperator2->TabStop = false;
			this->Seperator2->Text = L"GroupBox1";
			// 
			// Seperator1
			// 
			this->Seperator1->BackColor = System::Drawing::Color::Black;
			this->Seperator1->Location = System::Drawing::Point(12, 82);
			this->Seperator1->Name = L"Seperator1";
			this->Seperator1->Size = System::Drawing::Size(595, 1);
			this->Seperator1->TabIndex = 18;
			this->Seperator1->TabStop = false;
			this->Seperator1->Text = L"GroupBox1";
			// 
			// Seperator3
			// 
			this->Seperator3->BackColor = System::Drawing::Color::Black;
			this->Seperator3->Location = System::Drawing::Point(12, 473);
			this->Seperator3->Name = L"Seperator3";
			this->Seperator3->Size = System::Drawing::Size(595, 1);
			this->Seperator3->TabIndex = 19;
			this->Seperator3->TabStop = false;
			this->Seperator3->Text = L"GroupBox1";
			// 
			// Form1
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(643, 516);
			this->Controls->Add(this->Seperator3);
			this->Controls->Add(this->Seperator1);
			this->Controls->Add(this->Seperator2);
			this->Controls->Add(this->btnClose);
			this->Controls->Add(this->btnReturnNBSAnnotations);
			this->Controls->Add(this->btnShowReport);
			this->Controls->Add(this->lblStep3);
			this->Controls->Add(this->btnViewInManuf);
			this->Controls->Add(this->btnViewInGuidance);
			this->Controls->Add(this->btnViewInSpec);
			this->Controls->Add(this->lblStep2);
			this->Controls->Add(this->lblStep1);
			this->Controls->Add(this->lvAnnotations);
			this->Controls->Add(this->lblSelectedSpec);
			this->Controls->Add(this->btnAddAnnotation);
			this->Controls->Add(this->btnSelectSpecification);
			this->FormBorderStyle = System::Windows::Forms::FormBorderStyle::FixedSingle;
			this->MaximizeBox = false;
			this->MaximumSize = System::Drawing::Size(649, 548);
			this->MinimumSize = System::Drawing::Size(649, 548);
			this->Name = L"Form1";
			this->SizeGripStyle = System::Windows::Forms::SizeGripStyle::Hide;
			this->Text = L"Annotator_CPlusPlusNet";
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion

#pragma region Main Annotator Events and Methods

    // The model must be associated with a single specification, set of prelims
    // or schedule of work
    // The AnnotationManager object may be declared as a member variable and reused, but
    // for simplicity it is used "as new" in each of the following methods.
	//
	private: System::Void btnSelectSpecification_Click(System::Object^  sender, System::EventArgs^  e) {
				// Create an Annotation Manager object
				NBSAnnotationManager::AnnotationManager^ objAnnMan = gcnew NBSAnnotationManager::AnnotationManager;
				// Browse to a valid NBS document
				System::String^ strSpecificationFilePath = objAnnMan->SelectSpecification();
				if(m_strSpec != "")
					{
						// Set the label in the UI
						lblSelectedSpec->Text = strSpecificationFilePath;
						// Store this as a member variable
						m_strSpec = strSpecificationFilePath;
						// Enable further actions
						EnableButtons(true);
						// Now the specification is set, disable this button
						btnSelectSpecification->Enabled = false;						
					}
					else
					{
						// no valid specification has been set
						EnableButtons(false);
					}
				}


    //
    // The user may now browse to the specification and pick a clause for annotation
	//
	private: System::Void btnAddAnnotation_Click(System::Object^  sender, System::EventArgs^  e) {
				// Create an Annotation Manager object
				NBSAnnotationManager::AnnotationManager^ objAnnMan = gcnew NBSAnnotationManager::AnnotationManager;
				// Create an Annotation object
				NBSAnnotationManager::Annotation^ objAnnotation = gcnew NBSAnnotationManager::Annotation;
				// Show the Annotation Picker and wait until a valid annotation is returned
				objAnnotation = objAnnMan->SelectAnnotation(m_strSpec);
				if(objAnnotation)
					{
						// Add annotation to list view
						AddAnnotationToListView(objAnnotation);
					}
				}


    // 
    // The user may want to open a specification at the selected clause
	//
	private: System::Void btnViewInSpec_Click(System::Object^  sender, System::EventArgs^  e) {
				// Create an Annotation Manager object
				NBSAnnotationManager::Annotation^ objAnnotation = gcnew NBSAnnotationManager::Annotation;
				objAnnotation = ReturnSelectedAnnotation();
				if(objAnnotation)
					{
						// If a valid item in the list view is selected then
						// we ask the Annotation Manager to display this in the relevant NBS Product
						NBSAnnotationManager::AnnotationManager^ objAnnMan = gcnew NBSAnnotationManager::AnnotationManager;
						objAnnMan->LaunchSpecification(m_strSpec,objAnnotation);
					}				
				}
	
	//
	// View the guidance of the selected annotation. If no annotation object is passed, show root guidance file.
	//
	private: System::Void btnViewInGuidance_Click(System::Object^  sender, System::EventArgs^  e) {
				// Create an Annotation Manager object
				NBSAnnotationManager::Annotation^ objAnnotation = gcnew NBSAnnotationManager::Annotation;
				objAnnotation = ReturnSelectedAnnotation();
				if(objAnnotation)
					{
						// If a valid item in the list view is selected then
						// we ask the Annotation Manager to display this in the relevant NBS Product
						NBSAnnotationManager::AnnotationManager^ objAnnMan = gcnew NBSAnnotationManager::AnnotationManager;
						objAnnMan->ShowGuidance(m_strSpec,objAnnotation);
					}

				}


	//
	// View the manufacture information of the selected annotation. If no annotation object is passed, show manufacture homepage.
	//
	private: System::Void btnViewInManuf_Click(System::Object^  sender, System::EventArgs^  e) {
				// Create an Annotation Manager object	
				NBSAnnotationManager::Annotation^ objA = gcnew NBSAnnotationManager::Annotation;
				objA = ReturnSelectedAnnotation();
				if(objA)
					{
						// If a valid item in the list view is selected then
						// we ask the Annotation Manager to display this in the relevant NBS Product
						NBSAnnotationManager::AnnotationManager^ objAnnMan = gcnew NBSAnnotationManager::AnnotationManager;
						objAnnMan->ShowManufacturersInfo(m_strSpec,objA);
					}					
				}


	//
	// Returns latest NBS information to compare against annotations in the model.
	//
	private: System::Void btnReturnNBSAnnotations_Click(System::Object^  sender, System::EventArgs^  e) {
				// Create an Annotation Manager object
	 			NBSAnnotationManager::AnnotationManager^ objAnnotationManager = gcnew NBSAnnotationManager::AnnotationManager;
				NBSAnnotationManager::Annotations^ objAnnotations = gcnew NBSAnnotationManager::Annotations;
				// Place annotation objects from listview into annotations object
				objAnnotations = ReturnAnnotationsFromListView();

				
				if(objAnnotations->Count == 0)
				{
					// If we have no annotations...
					MessageBox::Show("No annotations in model");
				}
				
				else
				{
					// If we do, build up string of latest titles
					objAnnotationManager->UpdateAnnotations(m_strSpec, objAnnotations);
					System::String^ strLatestTitles = "The calling program should check these against what is in the model" + "\n" + "if they have been modified in the spec: " + "\n \n";
			 		NBSAnnotationManager::Annotation^ objAnn = gcnew NBSAnnotationManager::Annotation;
					int n;
					for(n=0; n<= objAnnotations->Count-1; n++)
						{							
							// Create annotation object from Nth item in annotations object
							objAnn = objAnnotations->Item[n];
							// And append its display title to the string
							strLatestTitles = strLatestTitles + objAnn->DisplayTitle + "\n";
						}
					// Display string in message box
					MessageBox::Show(strLatestTitles);
					}
				}


	//
    // Show report showing the status of the annotations against the latest
    // version of the project spec
    // Please note, that to test this properly you should exclude and modify
    // some clauses
	//
	private: System::Void btnShowReport_Click(System::Object^  sender, System::EventArgs^  e) {
				// Generate validity report based on annotations object or xml file
				// There are two ways of doing this
				// and the method is overloaded
				// 1. Pass the annotation info as a collection of Annotations
				NBSAnnotationManager::AnnotationManager^ objAnnMan = gcnew NBSAnnotationManager::AnnotationManager;
				NBSAnnotationManager::Annotations^ objAnnotations = gcnew NBSAnnotationManager::Annotations;
				// Internal method that loops through the list view
				objAnnotations = ReturnAnnotationsFromListView();
				objAnnMan->DisplayReport(m_strSpec,"doesntreallymatter", objAnnotations);

				
				// 2. Pass the annotation info in an XML format that verifies
				//    against the schema
				// Test for XML version
				//objAnnMan->DisplayReport("C:\\NBS Documents\\destination specification.spec", 
				//                        "c:\\Bills of Quants\\Bill505.xls", 
				//                        "C:\\NBS Documents\\destination specification.spec.nbsrpt");

				}


    /// <summary>
    /// Method that takes an Annotation object and adds its details to the list view
    /// </summary>
    /// <param name="objA">Annotation object</param>
    /// <remarks></remarks>
	private: System::Void AddAnnotationToListView(NBSAnnotationManager::Annotation^ objA) {
			 	ListViewItem^ objLV = gcnew ListViewItem;
				// Add the basic values
				objLV->Text = objA->Group;
				objLV->SubItems->Add(objA->SectionKey);
				objLV->SubItems->Add(objA->Number);
				objLV->SubItems->Add(objA->NBSTitle);
				objLV->SubItems->Add(objA->DisplayTitle);
				objLV->SubItems->Add(objA->HiddenNumber);
				// And as the tag add the annotation object itself
				objLV->Tag = objA;
				// Now add to list view
				lvAnnotations->Items->Add(objLV);
				}


    /// <summary>
    /// Method to be used to enable the functional button
    /// </summary>
    /// <param name="bEnable">Boolean - specifying whether buttons should be enabled or disabled</param>
    /// <remarks></remarks>
	private: System::Void EnableButtons(bool bEnable){
						btnAddAnnotation->Enabled = bEnable;
						btnShowReport->Enabled = bEnable;
						btnReturnNBSAnnotations->Enabled = bEnable;
				}


    /// <summary>
    /// Method to return the currently selected annotation node if one is selected.
    /// </summary>
    /// <returns>Annotation object</returns>
    /// <remarks></remarks>
	private: NBSAnnotationManager::Annotation^ ReturnSelectedAnnotation(){
				 if (lvAnnotations->SelectedItems->Count == 1)
				 {
					NBSAnnotationManager::Annotation^ objA = gcnew NBSAnnotationManager::Annotation;
					ListViewItem^ objLV = gcnew ListViewItem;
					objLV = lvAnnotations->SelectedItems[0];
					objA = (NBSAnnotationManager::Annotation^) objLV->Tag;
					return objA;
					}
				}


	 /// <summary>
	 /// Method to gather each annotation from the list view and place it into an annotations object
	 /// </summary>
	 /// <returns>Annotations object (collection of Annotation objects)</returns>
	 /// <remarks></remarks>
	 private: NBSAnnotationManager::Annotations^ ReturnAnnotationsFromListView(){
				ListViewItem^ objLV = gcnew ListViewItem;				
				NBSAnnotationManager::Annotations^ objAs = gcnew NBSAnnotationManager::Annotations;				

				int i;
				for(i=0; i<=lvAnnotations->Items->Count-1; i++)
					{
						NBSAnnotationManager::Annotation^ objA = gcnew NBSAnnotationManager::Annotation;
						objA = (NBSAnnotationManager::Annotation^) lvAnnotations->Items[i]->Tag;
						objAs->Add(objA);
					}
				return objAs;
				}
	

    /// 
    /// Only enable specific buttons based on if an annotation in the list view is selected
    /// 
	private: System::Void lvAnnotations_SelectedIndexChanged(System::Object^  sender, System::EventArgs^  e) {
				NBSAnnotationManager::Annotation^ objA = gcnew NBSAnnotationManager::Annotation;
				objA = ReturnSelectedAnnotation();
				if(objA)
				{
						btnViewInSpec->Enabled = true;
						btnViewInGuidance->Enabled = true;
						btnViewInManuf->Enabled = true;				
				}
				else
					{
						btnViewInSpec->Enabled = false;
						btnViewInGuidance->Enabled = false;
						btnViewInManuf->Enabled = false;
					}
				}

	
    /// 
    /// Close the form when button clicked
    /// 
 	private: System::Void btnClose_Click(System::Object^  sender, System::EventArgs^  e) {
				 Application::Exit();
				}
	};


#pragma endregion

}
