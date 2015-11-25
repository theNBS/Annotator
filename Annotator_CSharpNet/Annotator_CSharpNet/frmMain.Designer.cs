namespace Annotator_CSharpNet
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnBrowseToSpecification = new System.Windows.Forms.Button();
            this.lblSpecification = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddAnnotation = new System.Windows.Forms.Button();
            this.btnViewInSpecification = new System.Windows.Forms.Button();
            this.btnViewGuidance = new System.Windows.Forms.Button();
            this.btnViewManufacturerInfo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShowReport = new System.Windows.Forms.Button();
            this.btnShowAnnotationInfo = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lvAnnotations = new System.Windows.Forms.ListView();
            this.colSectionCode = new System.Windows.Forms.ColumnHeader();
            this.colSectionNumber = new System.Windows.Forms.ColumnHeader();
            this.colClauseNumber = new System.Windows.Forms.ColumnHeader();
            this.colClauseTitle = new System.Windows.Forms.ColumnHeader();
            this.colAnnotationText = new System.Windows.Forms.ColumnHeader();
            this.colHiddenNumber = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBrowseToSpecification
            // 
            resources.ApplyResources(this.btnBrowseToSpecification, "btnBrowseToSpecification");
            this.btnBrowseToSpecification.Name = "btnBrowseToSpecification";
            this.btnBrowseToSpecification.UseVisualStyleBackColor = true;
            this.btnBrowseToSpecification.Click += new System.EventHandler(this.btnBrowseToSpecification_Click);
            // 
            // lblSpecification
            // 
            resources.ApplyResources(this.lblSpecification, "lblSpecification");
            this.lblSpecification.Name = "lblSpecification";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnAddAnnotation
            // 
            resources.ApplyResources(this.btnAddAnnotation, "btnAddAnnotation");
            this.btnAddAnnotation.Name = "btnAddAnnotation";
            this.btnAddAnnotation.UseVisualStyleBackColor = true;
            this.btnAddAnnotation.Click += new System.EventHandler(this.btnAddAnnotation_Click);
            // 
            // btnViewInSpecification
            // 
            resources.ApplyResources(this.btnViewInSpecification, "btnViewInSpecification");
            this.btnViewInSpecification.Name = "btnViewInSpecification";
            this.btnViewInSpecification.UseVisualStyleBackColor = true;
            this.btnViewInSpecification.Click += new System.EventHandler(this.btnViewInSpecification_Click);
            // 
            // btnViewGuidance
            // 
            resources.ApplyResources(this.btnViewGuidance, "btnViewGuidance");
            this.btnViewGuidance.Name = "btnViewGuidance";
            this.btnViewGuidance.UseVisualStyleBackColor = true;
            this.btnViewGuidance.Click += new System.EventHandler(this.btnViewGuidance_Click);
            // 
            // btnViewManufacturerInfo
            // 
            resources.ApplyResources(this.btnViewManufacturerInfo, "btnViewManufacturerInfo");
            this.btnViewManufacturerInfo.Name = "btnViewManufacturerInfo";
            this.btnViewManufacturerInfo.UseVisualStyleBackColor = true;
            this.btnViewManufacturerInfo.Click += new System.EventHandler(this.btnViewManufacturerInfo_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnShowReport
            // 
            resources.ApplyResources(this.btnShowReport, "btnShowReport");
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.UseVisualStyleBackColor = true;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // btnShowAnnotationInfo
            // 
            resources.ApplyResources(this.btnShowAnnotationInfo, "btnShowAnnotationInfo");
            this.btnShowAnnotationInfo.Name = "btnShowAnnotationInfo";
            this.btnShowAnnotationInfo.UseVisualStyleBackColor = true;
            this.btnShowAnnotationInfo.Click += new System.EventHandler(this.btnShowAnnotationInfo_Click);
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lvAnnotations
            // 
            this.lvAnnotations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSectionCode,
            this.colSectionNumber,
            this.colClauseNumber,
            this.colClauseTitle,
            this.colAnnotationText,
            this.colHiddenNumber});
            this.lvAnnotations.FullRowSelect = true;
            resources.ApplyResources(this.lvAnnotations, "lvAnnotations");
            this.lvAnnotations.MultiSelect = false;
            this.lvAnnotations.Name = "lvAnnotations";
            this.lvAnnotations.UseCompatibleStateImageBehavior = false;
            this.lvAnnotations.View = System.Windows.Forms.View.Details;
            this.lvAnnotations.SelectedIndexChanged += new System.EventHandler(this.lvAnnotations_SelectedIndexChanged);
            // 
            // colSectionCode
            // 
            resources.ApplyResources(this.colSectionCode, "colSectionCode");
            // 
            // colSectionNumber
            // 
            resources.ApplyResources(this.colSectionNumber, "colSectionNumber");
            // 
            // colClauseNumber
            // 
            resources.ApplyResources(this.colClauseNumber, "colClauseNumber");
            // 
            // colClauseTitle
            // 
            resources.ApplyResources(this.colClauseTitle, "colClauseTitle");
            // 
            // colAnnotationText
            // 
            resources.ApplyResources(this.colAnnotationText, "colAnnotationText");
            // 
            // colHiddenNumber
            // 
            resources.ApplyResources(this.colHiddenNumber, "colHiddenNumber");
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvAnnotations);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnShowAnnotationInfo);
            this.Controls.Add(this.btnShowReport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnViewManufacturerInfo);
            this.Controls.Add(this.btnViewGuidance);
            this.Controls.Add(this.btnViewInSpecification);
            this.Controls.Add(this.btnAddAnnotation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSpecification);
            this.Controls.Add(this.btnBrowseToSpecification);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowseToSpecification;
        private System.Windows.Forms.Label lblSpecification;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddAnnotation;
        private System.Windows.Forms.Button btnViewInSpecification;
        private System.Windows.Forms.Button btnViewGuidance;
        private System.Windows.Forms.Button btnViewManufacturerInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShowReport;
        private System.Windows.Forms.Button btnShowAnnotationInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListView lvAnnotations;
        private System.Windows.Forms.ColumnHeader colSectionCode;
        private System.Windows.Forms.ColumnHeader colSectionNumber;
        private System.Windows.Forms.ColumnHeader colClauseNumber;
        private System.Windows.Forms.ColumnHeader colClauseTitle;
        private System.Windows.Forms.ColumnHeader colAnnotationText;
        private System.Windows.Forms.ColumnHeader colHiddenNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
    }
}

