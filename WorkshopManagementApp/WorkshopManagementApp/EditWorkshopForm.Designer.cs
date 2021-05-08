
namespace WorkshopManagementApp
{
    partial class EditWorkshopForm
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
            this.tabControlWorkshopMenu = new System.Windows.Forms.TabControl();
            this.tabPageEditWorkshop = new System.Windows.Forms.TabPage();
            this.gbxEditWorkshop = new System.Windows.Forms.GroupBox();
            this.tbxWorkshopType = new System.Windows.Forms.TextBox();
            this.lbWorkshopType = new System.Windows.Forms.Label();
            this.tbxUrl = new System.Windows.Forms.TextBox();
            this.lbUrl = new System.Windows.Forms.Label();
            this.tbxRoomNum = new System.Windows.Forms.TextBox();
            this.lbRoomNum = new System.Windows.Forms.Label();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.btnEditWorkshop = new System.Windows.Forms.Button();
            this.tbxCapacity = new System.Windows.Forms.TextBox();
            this.lbCapacity = new System.Windows.Forms.Label();
            this.tbxShortDescription = new System.Windows.Forms.TextBox();
            this.lbShortDescription = new System.Windows.Forms.Label();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.tabPageAssignPeople = new System.Windows.Forms.TabPage();
            this.btnAssignAsStudent = new System.Windows.Forms.Button();
            this.btnAssignAsTeacher = new System.Windows.Forms.Button();
            this.lbxPeople = new System.Windows.Forms.ListBox();
            this.tabPageManageParticipants = new System.Windows.Forms.TabPage();
            this.btnRemoveParticipant = new System.Windows.Forms.Button();
            this.lbxParticipants = new System.Windows.Forms.ListBox();
            this.tbxIdWP = new System.Windows.Forms.TextBox();
            this.btnViewEnrollmentDetails = new System.Windows.Forms.Button();
            this.tabControlWorkshopMenu.SuspendLayout();
            this.tabPageEditWorkshop.SuspendLayout();
            this.gbxEditWorkshop.SuspendLayout();
            this.tabPageAssignPeople.SuspendLayout();
            this.tabPageManageParticipants.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlWorkshopMenu
            // 
            this.tabControlWorkshopMenu.Controls.Add(this.tabPageEditWorkshop);
            this.tabControlWorkshopMenu.Controls.Add(this.tabPageAssignPeople);
            this.tabControlWorkshopMenu.Controls.Add(this.tabPageManageParticipants);
            this.tabControlWorkshopMenu.Location = new System.Drawing.Point(15, 12);
            this.tabControlWorkshopMenu.Name = "tabControlWorkshopMenu";
            this.tabControlWorkshopMenu.SelectedIndex = 0;
            this.tabControlWorkshopMenu.Size = new System.Drawing.Size(949, 511);
            this.tabControlWorkshopMenu.TabIndex = 0;
            this.tabControlWorkshopMenu.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlWorkshopMenu_Selected);
            // 
            // tabPageEditWorkshop
            // 
            this.tabPageEditWorkshop.Controls.Add(this.gbxEditWorkshop);
            this.tabPageEditWorkshop.Location = new System.Drawing.Point(4, 29);
            this.tabPageEditWorkshop.Name = "tabPageEditWorkshop";
            this.tabPageEditWorkshop.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEditWorkshop.Size = new System.Drawing.Size(941, 478);
            this.tabPageEditWorkshop.TabIndex = 0;
            this.tabPageEditWorkshop.Text = "Edit workshop";
            this.tabPageEditWorkshop.UseVisualStyleBackColor = true;
            // 
            // gbxEditWorkshop
            // 
            this.gbxEditWorkshop.Controls.Add(this.tbxWorkshopType);
            this.gbxEditWorkshop.Controls.Add(this.lbWorkshopType);
            this.gbxEditWorkshop.Controls.Add(this.tbxUrl);
            this.gbxEditWorkshop.Controls.Add(this.lbUrl);
            this.gbxEditWorkshop.Controls.Add(this.tbxRoomNum);
            this.gbxEditWorkshop.Controls.Add(this.lbRoomNum);
            this.gbxEditWorkshop.Controls.Add(this.tbxAddress);
            this.gbxEditWorkshop.Controls.Add(this.lbAddress);
            this.gbxEditWorkshop.Controls.Add(this.btnEditWorkshop);
            this.gbxEditWorkshop.Controls.Add(this.tbxCapacity);
            this.gbxEditWorkshop.Controls.Add(this.lbCapacity);
            this.gbxEditWorkshop.Controls.Add(this.tbxShortDescription);
            this.gbxEditWorkshop.Controls.Add(this.lbShortDescription);
            this.gbxEditWorkshop.Controls.Add(this.tbxTitle);
            this.gbxEditWorkshop.Controls.Add(this.lbTitle);
            this.gbxEditWorkshop.Controls.Add(this.tbxId);
            this.gbxEditWorkshop.Controls.Add(this.lbId);
            this.gbxEditWorkshop.Location = new System.Drawing.Point(64, 32);
            this.gbxEditWorkshop.Name = "gbxEditWorkshop";
            this.gbxEditWorkshop.Size = new System.Drawing.Size(812, 395);
            this.gbxEditWorkshop.TabIndex = 1;
            this.gbxEditWorkshop.TabStop = false;
            this.gbxEditWorkshop.Text = "Edit workshop";
            // 
            // tbxWorkshopType
            // 
            this.tbxWorkshopType.Location = new System.Drawing.Point(498, 82);
            this.tbxWorkshopType.Name = "tbxWorkshopType";
            this.tbxWorkshopType.ReadOnly = true;
            this.tbxWorkshopType.Size = new System.Drawing.Size(202, 26);
            this.tbxWorkshopType.TabIndex = 16;
            // 
            // lbWorkshopType
            // 
            this.lbWorkshopType.AutoSize = true;
            this.lbWorkshopType.Location = new System.Drawing.Point(541, 50);
            this.lbWorkshopType.Name = "lbWorkshopType";
            this.lbWorkshopType.Size = new System.Drawing.Size(119, 20);
            this.lbWorkshopType.TabIndex = 15;
            this.lbWorkshopType.Text = "Workshop type:";
            // 
            // tbxUrl
            // 
            this.tbxUrl.Location = new System.Drawing.Point(165, 269);
            this.tbxUrl.Name = "tbxUrl";
            this.tbxUrl.Size = new System.Drawing.Size(202, 26);
            this.tbxUrl.TabIndex = 14;
            // 
            // lbUrl
            // 
            this.lbUrl.AutoSize = true;
            this.lbUrl.Location = new System.Drawing.Point(97, 272);
            this.lbUrl.Name = "lbUrl";
            this.lbUrl.Size = new System.Drawing.Size(46, 20);
            this.lbUrl.TabIndex = 13;
            this.lbUrl.Text = "URL:";
            // 
            // tbxRoomNum
            // 
            this.tbxRoomNum.Location = new System.Drawing.Point(165, 224);
            this.tbxRoomNum.Name = "tbxRoomNum";
            this.tbxRoomNum.Size = new System.Drawing.Size(202, 26);
            this.tbxRoomNum.TabIndex = 12;
            // 
            // lbRoomNum
            // 
            this.lbRoomNum.AutoSize = true;
            this.lbRoomNum.Location = new System.Drawing.Point(38, 230);
            this.lbRoomNum.Name = "lbRoomNum";
            this.lbRoomNum.Size = new System.Drawing.Size(105, 20);
            this.lbRoomNum.TabIndex = 11;
            this.lbRoomNum.Text = "roomNumber:";
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(165, 180);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(202, 26);
            this.tbxAddress.TabIndex = 10;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(71, 186);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(72, 20);
            this.lbAddress.TabIndex = 9;
            this.lbAddress.Text = "Address:";
            // 
            // btnEditWorkshop
            // 
            this.btnEditWorkshop.Location = new System.Drawing.Point(328, 336);
            this.btnEditWorkshop.Name = "btnEditWorkshop";
            this.btnEditWorkshop.Size = new System.Drawing.Size(147, 38);
            this.btnEditWorkshop.TabIndex = 8;
            this.btnEditWorkshop.Text = "Apply changes";
            this.btnEditWorkshop.UseVisualStyleBackColor = true;
            this.btnEditWorkshop.Click += new System.EventHandler(this.btnEditWorkshop_Click);
            // 
            // tbxCapacity
            // 
            this.tbxCapacity.Location = new System.Drawing.Point(165, 135);
            this.tbxCapacity.Name = "tbxCapacity";
            this.tbxCapacity.Size = new System.Drawing.Size(202, 26);
            this.tbxCapacity.TabIndex = 7;
            // 
            // lbCapacity
            // 
            this.lbCapacity.AutoSize = true;
            this.lbCapacity.Location = new System.Drawing.Point(71, 138);
            this.lbCapacity.Name = "lbCapacity";
            this.lbCapacity.Size = new System.Drawing.Size(74, 20);
            this.lbCapacity.TabIndex = 6;
            this.lbCapacity.Text = "Capacity:";
            // 
            // tbxShortDescription
            // 
            this.tbxShortDescription.Location = new System.Drawing.Point(446, 171);
            this.tbxShortDescription.Multiline = true;
            this.tbxShortDescription.Name = "tbxShortDescription";
            this.tbxShortDescription.Size = new System.Drawing.Size(310, 121);
            this.tbxShortDescription.TabIndex = 5;
            // 
            // lbShortDescription
            // 
            this.lbShortDescription.AutoSize = true;
            this.lbShortDescription.Location = new System.Drawing.Point(541, 138);
            this.lbShortDescription.Name = "lbShortDescription";
            this.lbShortDescription.Size = new System.Drawing.Size(133, 20);
            this.lbShortDescription.TabIndex = 4;
            this.lbShortDescription.Text = "Short description:";
            // 
            // tbxTitle
            // 
            this.tbxTitle.Location = new System.Drawing.Point(165, 90);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(202, 26);
            this.tbxTitle.TabIndex = 3;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(103, 93);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(42, 20);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Title:";
            // 
            // tbxId
            // 
            this.tbxId.Location = new System.Drawing.Point(165, 46);
            this.tbxId.Name = "tbxId";
            this.tbxId.ReadOnly = true;
            this.tbxId.Size = new System.Drawing.Size(202, 26);
            this.tbxId.TabIndex = 1;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(118, 49);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(27, 20);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "Id:";
            // 
            // tabPageAssignPeople
            // 
            this.tabPageAssignPeople.Controls.Add(this.tbxIdWP);
            this.tabPageAssignPeople.Controls.Add(this.btnAssignAsStudent);
            this.tabPageAssignPeople.Controls.Add(this.btnAssignAsTeacher);
            this.tabPageAssignPeople.Controls.Add(this.lbxPeople);
            this.tabPageAssignPeople.Location = new System.Drawing.Point(4, 29);
            this.tabPageAssignPeople.Name = "tabPageAssignPeople";
            this.tabPageAssignPeople.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAssignPeople.Size = new System.Drawing.Size(941, 478);
            this.tabPageAssignPeople.TabIndex = 1;
            this.tabPageAssignPeople.Text = "Assign people";
            this.tabPageAssignPeople.UseVisualStyleBackColor = true;
            // 
            // btnAssignAsStudent
            // 
            this.btnAssignAsStudent.Location = new System.Drawing.Point(484, 387);
            this.btnAssignAsStudent.Name = "btnAssignAsStudent";
            this.btnAssignAsStudent.Size = new System.Drawing.Size(172, 36);
            this.btnAssignAsStudent.TabIndex = 11;
            this.btnAssignAsStudent.Text = "Assign as Student";
            this.btnAssignAsStudent.UseVisualStyleBackColor = true;
            this.btnAssignAsStudent.Click += new System.EventHandler(this.btnAssignAsStudent_Click);
            // 
            // btnAssignAsTeacher
            // 
            this.btnAssignAsTeacher.Location = new System.Drawing.Point(217, 387);
            this.btnAssignAsTeacher.Name = "btnAssignAsTeacher";
            this.btnAssignAsTeacher.Size = new System.Drawing.Size(172, 36);
            this.btnAssignAsTeacher.TabIndex = 10;
            this.btnAssignAsTeacher.Text = "Assign as Teacher";
            this.btnAssignAsTeacher.UseVisualStyleBackColor = true;
            this.btnAssignAsTeacher.Click += new System.EventHandler(this.btnAssignAsTeacher_Click);
            // 
            // lbxPeople
            // 
            this.lbxPeople.FormattingEnabled = true;
            this.lbxPeople.ItemHeight = 20;
            this.lbxPeople.Location = new System.Drawing.Point(87, 83);
            this.lbxPeople.Name = "lbxPeople";
            this.lbxPeople.Size = new System.Drawing.Size(712, 284);
            this.lbxPeople.TabIndex = 9;
            // 
            // tabPageManageParticipants
            // 
            this.tabPageManageParticipants.Controls.Add(this.btnViewEnrollmentDetails);
            this.tabPageManageParticipants.Controls.Add(this.btnRemoveParticipant);
            this.tabPageManageParticipants.Controls.Add(this.lbxParticipants);
            this.tabPageManageParticipants.Location = new System.Drawing.Point(4, 29);
            this.tabPageManageParticipants.Name = "tabPageManageParticipants";
            this.tabPageManageParticipants.Size = new System.Drawing.Size(941, 478);
            this.tabPageManageParticipants.TabIndex = 2;
            this.tabPageManageParticipants.Text = "Manage participants";
            this.tabPageManageParticipants.UseVisualStyleBackColor = true;
            // 
            // btnRemoveParticipant
            // 
            this.btnRemoveParticipant.Location = new System.Drawing.Point(137, 362);
            this.btnRemoveParticipant.Name = "btnRemoveParticipant";
            this.btnRemoveParticipant.Size = new System.Drawing.Size(172, 36);
            this.btnRemoveParticipant.TabIndex = 13;
            this.btnRemoveParticipant.Text = "Remove participant";
            this.btnRemoveParticipant.UseVisualStyleBackColor = true;
            this.btnRemoveParticipant.Click += new System.EventHandler(this.btnRemoveParticipant_Click);
            // 
            // lbxParticipants
            // 
            this.lbxParticipants.FormattingEnabled = true;
            this.lbxParticipants.ItemHeight = 20;
            this.lbxParticipants.Location = new System.Drawing.Point(137, 58);
            this.lbxParticipants.Name = "lbxParticipants";
            this.lbxParticipants.Size = new System.Drawing.Size(622, 284);
            this.lbxParticipants.TabIndex = 12;
            // 
            // tbxIdWP
            // 
            this.tbxIdWP.Location = new System.Drawing.Point(87, 392);
            this.tbxIdWP.Name = "tbxIdWP";
            this.tbxIdWP.Size = new System.Drawing.Size(100, 26);
            this.tbxIdWP.TabIndex = 12;
            // 
            // btnViewEnrollmentDetails
            // 
            this.btnViewEnrollmentDetails.Location = new System.Drawing.Point(378, 362);
            this.btnViewEnrollmentDetails.Name = "btnViewEnrollmentDetails";
            this.btnViewEnrollmentDetails.Size = new System.Drawing.Size(204, 36);
            this.btnViewEnrollmentDetails.TabIndex = 14;
            this.btnViewEnrollmentDetails.Text = "View enrollment details";
            this.btnViewEnrollmentDetails.UseVisualStyleBackColor = true;
            this.btnViewEnrollmentDetails.Click += new System.EventHandler(this.btnViewEnrollmentDetails_Click);
            // 
            // EditWorkshopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 533);
            this.Controls.Add(this.tabControlWorkshopMenu);
            this.Name = "EditWorkshopForm";
            this.Text = "EditWorkshopForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditWorkshopForm_FormClosed);
            this.tabControlWorkshopMenu.ResumeLayout(false);
            this.tabPageEditWorkshop.ResumeLayout(false);
            this.gbxEditWorkshop.ResumeLayout(false);
            this.gbxEditWorkshop.PerformLayout();
            this.tabPageAssignPeople.ResumeLayout(false);
            this.tabPageAssignPeople.PerformLayout();
            this.tabPageManageParticipants.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlWorkshopMenu;
        private System.Windows.Forms.TabPage tabPageEditWorkshop;
        private System.Windows.Forms.TabPage tabPageAssignPeople;
        private System.Windows.Forms.TabPage tabPageManageParticipants;
        private System.Windows.Forms.GroupBox gbxEditWorkshop;
        private System.Windows.Forms.TextBox tbxWorkshopType;
        private System.Windows.Forms.Label lbWorkshopType;
        private System.Windows.Forms.TextBox tbxUrl;
        private System.Windows.Forms.Label lbUrl;
        private System.Windows.Forms.TextBox tbxRoomNum;
        private System.Windows.Forms.Label lbRoomNum;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Button btnEditWorkshop;
        private System.Windows.Forms.TextBox tbxCapacity;
        private System.Windows.Forms.Label lbCapacity;
        private System.Windows.Forms.TextBox tbxShortDescription;
        private System.Windows.Forms.Label lbShortDescription;
        private System.Windows.Forms.TextBox tbxTitle;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Button btnAssignAsStudent;
        private System.Windows.Forms.Button btnAssignAsTeacher;
        private System.Windows.Forms.ListBox lbxPeople;
        private System.Windows.Forms.Button btnRemoveParticipant;
        private System.Windows.Forms.ListBox lbxParticipants;
        private System.Windows.Forms.TextBox tbxIdWP;
        private System.Windows.Forms.Button btnViewEnrollmentDetails;
    }
}