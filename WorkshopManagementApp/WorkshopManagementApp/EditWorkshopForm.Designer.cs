
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
            this.components = new System.ComponentModel.Container();
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
            this.lbTeacher = new System.Windows.Forms.Label();
            this.gbxFilterPeople = new System.Windows.Forms.GroupBox();
            this.cbFilterPeople = new System.Windows.Forms.ComboBox();
            this.btnAddParticipant = new System.Windows.Forms.Button();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.lbxPeople = new System.Windows.Forms.ListBox();
            this.tabPageManageParticipants = new System.Windows.Forms.TabPage();
            this.gbxFilterParticipants = new System.Windows.Forms.GroupBox();
            this.cbFilterParticipants = new System.Windows.Forms.ComboBox();
            this.btnViewEnrollmentDetails = new System.Windows.Forms.Button();
            this.btnRemoveParticipant = new System.Windows.Forms.Button();
            this.lbxParticipants = new System.Windows.Forms.ListBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControlWorkshopMenu.SuspendLayout();
            this.tabPageEditWorkshop.SuspendLayout();
            this.gbxEditWorkshop.SuspendLayout();
            this.tabPageAssignPeople.SuspendLayout();
            this.gbxFilterPeople.SuspendLayout();
            this.tabPageManageParticipants.SuspendLayout();
            this.gbxFilterParticipants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlWorkshopMenu
            // 
            this.tabControlWorkshopMenu.Controls.Add(this.tabPageEditWorkshop);
            this.tabControlWorkshopMenu.Controls.Add(this.tabPageAssignPeople);
            this.tabControlWorkshopMenu.Controls.Add(this.tabPageManageParticipants);
            this.tabControlWorkshopMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlWorkshopMenu.Location = new System.Drawing.Point(18, 13);
            this.tabControlWorkshopMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControlWorkshopMenu.Name = "tabControlWorkshopMenu";
            this.tabControlWorkshopMenu.SelectedIndex = 0;
            this.tabControlWorkshopMenu.Size = new System.Drawing.Size(1160, 607);
            this.tabControlWorkshopMenu.TabIndex = 0;
            this.tabControlWorkshopMenu.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlWorkshopMenu_Selected);
            // 
            // tabPageEditWorkshop
            // 
            this.tabPageEditWorkshop.Controls.Add(this.gbxEditWorkshop);
            this.tabPageEditWorkshop.Location = new System.Drawing.Point(4, 31);
            this.tabPageEditWorkshop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageEditWorkshop.Name = "tabPageEditWorkshop";
            this.tabPageEditWorkshop.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageEditWorkshop.Size = new System.Drawing.Size(1152, 572);
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
            this.gbxEditWorkshop.Location = new System.Drawing.Point(39, 35);
            this.gbxEditWorkshop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxEditWorkshop.Name = "gbxEditWorkshop";
            this.gbxEditWorkshop.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxEditWorkshop.Size = new System.Drawing.Size(1079, 516);
            this.gbxEditWorkshop.TabIndex = 1;
            this.gbxEditWorkshop.TabStop = false;
            this.gbxEditWorkshop.Text = "Edit workshop";
            // 
            // tbxWorkshopType
            // 
            this.tbxWorkshopType.Location = new System.Drawing.Point(182, 354);
            this.tbxWorkshopType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxWorkshopType.Name = "tbxWorkshopType";
            this.tbxWorkshopType.ReadOnly = true;
            this.tbxWorkshopType.Size = new System.Drawing.Size(246, 28);
            this.tbxWorkshopType.TabIndex = 16;
            // 
            // lbWorkshopType
            // 
            this.lbWorkshopType.AutoSize = true;
            this.lbWorkshopType.Location = new System.Drawing.Point(13, 357);
            this.lbWorkshopType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWorkshopType.Name = "lbWorkshopType";
            this.lbWorkshopType.Size = new System.Drawing.Size(149, 22);
            this.lbWorkshopType.TabIndex = 15;
            this.lbWorkshopType.Text = "Workshop type:";
            // 
            // tbxUrl
            // 
            this.tbxUrl.Location = new System.Drawing.Point(182, 303);
            this.tbxUrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxUrl.Name = "tbxUrl";
            this.tbxUrl.Size = new System.Drawing.Size(246, 28);
            this.tbxUrl.TabIndex = 14;
            // 
            // lbUrl
            // 
            this.lbUrl.AutoSize = true;
            this.lbUrl.Location = new System.Drawing.Point(107, 306);
            this.lbUrl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUrl.Name = "lbUrl";
            this.lbUrl.Size = new System.Drawing.Size(55, 22);
            this.lbUrl.TabIndex = 13;
            this.lbUrl.Text = "URL:";
            // 
            // tbxRoomNum
            // 
            this.tbxRoomNum.Location = new System.Drawing.Point(182, 253);
            this.tbxRoomNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxRoomNum.Name = "tbxRoomNum";
            this.tbxRoomNum.Size = new System.Drawing.Size(246, 28);
            this.tbxRoomNum.TabIndex = 12;
            // 
            // lbRoomNum
            // 
            this.lbRoomNum.AutoSize = true;
            this.lbRoomNum.Location = new System.Drawing.Point(34, 259);
            this.lbRoomNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRoomNum.Name = "lbRoomNum";
            this.lbRoomNum.Size = new System.Drawing.Size(129, 22);
            this.lbRoomNum.TabIndex = 11;
            this.lbRoomNum.Text = "roomNumber:";
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(182, 205);
            this.tbxAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(246, 28);
            this.tbxAddress.TabIndex = 10;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(74, 208);
            this.lbAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(89, 22);
            this.lbAddress.TabIndex = 9;
            this.lbAddress.Text = "Address:";
            // 
            // btnEditWorkshop
            // 
            this.btnEditWorkshop.Location = new System.Drawing.Point(332, 424);
            this.btnEditWorkshop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditWorkshop.Name = "btnEditWorkshop";
            this.btnEditWorkshop.Size = new System.Drawing.Size(433, 42);
            this.btnEditWorkshop.TabIndex = 8;
            this.btnEditWorkshop.Text = "Apply changes";
            this.btnEditWorkshop.UseVisualStyleBackColor = true;
            this.btnEditWorkshop.Click += new System.EventHandler(this.btnEditWorkshop_Click);
            // 
            // tbxCapacity
            // 
            this.tbxCapacity.Location = new System.Drawing.Point(182, 155);
            this.tbxCapacity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxCapacity.Name = "tbxCapacity";
            this.tbxCapacity.Size = new System.Drawing.Size(246, 28);
            this.tbxCapacity.TabIndex = 7;
            // 
            // lbCapacity
            // 
            this.lbCapacity.AutoSize = true;
            this.lbCapacity.Location = new System.Drawing.Point(68, 159);
            this.lbCapacity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCapacity.Name = "lbCapacity";
            this.lbCapacity.Size = new System.Drawing.Size(94, 22);
            this.lbCapacity.TabIndex = 6;
            this.lbCapacity.Text = "Capacity:";
            // 
            // tbxShortDescription
            // 
            this.tbxShortDescription.Location = new System.Drawing.Point(501, 129);
            this.tbxShortDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxShortDescription.Multiline = true;
            this.tbxShortDescription.Name = "tbxShortDescription";
            this.tbxShortDescription.Size = new System.Drawing.Size(533, 202);
            this.tbxShortDescription.TabIndex = 5;
            // 
            // lbShortDescription
            // 
            this.lbShortDescription.AutoSize = true;
            this.lbShortDescription.Location = new System.Drawing.Point(678, 89);
            this.lbShortDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbShortDescription.Name = "lbShortDescription";
            this.lbShortDescription.Size = new System.Drawing.Size(168, 22);
            this.lbShortDescription.TabIndex = 4;
            this.lbShortDescription.Text = "Short description:";
            // 
            // tbxTitle
            // 
            this.tbxTitle.Location = new System.Drawing.Point(182, 106);
            this.tbxTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(246, 28);
            this.tbxTitle.TabIndex = 3;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(107, 109);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(56, 22);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Title:";
            // 
            // tbxId
            // 
            this.tbxId.Location = new System.Drawing.Point(182, 57);
            this.tbxId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxId.Name = "tbxId";
            this.tbxId.ReadOnly = true;
            this.tbxId.Size = new System.Drawing.Size(246, 28);
            this.tbxId.TabIndex = 1;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(125, 61);
            this.lbId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(32, 22);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "Id:";
            // 
            // tabPageAssignPeople
            // 
            this.tabPageAssignPeople.AutoScroll = true;
            this.tabPageAssignPeople.Controls.Add(this.lbTeacher);
            this.tabPageAssignPeople.Controls.Add(this.gbxFilterPeople);
            this.tabPageAssignPeople.Controls.Add(this.btnAddParticipant);
            this.tabPageAssignPeople.Controls.Add(this.btnAddTeacher);
            this.tabPageAssignPeople.Controls.Add(this.lbxPeople);
            this.tabPageAssignPeople.Location = new System.Drawing.Point(4, 31);
            this.tabPageAssignPeople.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageAssignPeople.Name = "tabPageAssignPeople";
            this.tabPageAssignPeople.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageAssignPeople.Size = new System.Drawing.Size(1152, 572);
            this.tabPageAssignPeople.TabIndex = 1;
            this.tabPageAssignPeople.Text = "Add people to workshop";
            this.tabPageAssignPeople.UseVisualStyleBackColor = true;
            // 
            // lbTeacher
            // 
            this.lbTeacher.AutoSize = true;
            this.lbTeacher.Location = new System.Drawing.Point(25, 24);
            this.lbTeacher.Name = "lbTeacher";
            this.lbTeacher.Size = new System.Drawing.Size(0, 22);
            this.lbTeacher.TabIndex = 17;
            // 
            // gbxFilterPeople
            // 
            this.gbxFilterPeople.Controls.Add(this.cbFilterPeople);
            this.gbxFilterPeople.Location = new System.Drawing.Point(215, 68);
            this.gbxFilterPeople.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxFilterPeople.Name = "gbxFilterPeople";
            this.gbxFilterPeople.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxFilterPeople.Size = new System.Drawing.Size(744, 101);
            this.gbxFilterPeople.TabIndex = 15;
            this.gbxFilterPeople.TabStop = false;
            this.gbxFilterPeople.Text = "Show students/teachers";
            // 
            // cbFilterPeople
            // 
            this.cbFilterPeople.FormattingEnabled = true;
            this.cbFilterPeople.Items.AddRange(new object[] {
            "All",
            "Student",
            "Teacher"});
            this.cbFilterPeople.Location = new System.Drawing.Point(219, 47);
            this.cbFilterPeople.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbFilterPeople.Name = "cbFilterPeople";
            this.cbFilterPeople.Size = new System.Drawing.Size(300, 30);
            this.cbFilterPeople.TabIndex = 13;
            this.cbFilterPeople.Text = "Choose students/teachers...";
            this.cbFilterPeople.SelectedIndexChanged += new System.EventHandler(this.cbFilterPeople_SelectedIndexChanged);
            // 
            // btnAddParticipant
            // 
            this.btnAddParticipant.Location = new System.Drawing.Point(629, 468);
            this.btnAddParticipant.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddParticipant.Name = "btnAddParticipant";
            this.btnAddParticipant.Size = new System.Drawing.Size(330, 40);
            this.btnAddParticipant.TabIndex = 11;
            this.btnAddParticipant.Text = "Add Participant to workshop";
            this.btnAddParticipant.UseVisualStyleBackColor = true;
            this.btnAddParticipant.Click += new System.EventHandler(this.btnAddParticipant_Click);
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Location = new System.Drawing.Point(215, 468);
            this.btnAddTeacher.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(330, 40);
            this.btnAddTeacher.TabIndex = 10;
            this.btnAddTeacher.Text = "Add Teacher to workshop";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // lbxPeople
            // 
            this.lbxPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxPeople.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbxPeople.FormattingEnabled = true;
            this.lbxPeople.ItemHeight = 25;
            this.lbxPeople.Location = new System.Drawing.Point(215, 194);
            this.lbxPeople.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbxPeople.Name = "lbxPeople";
            this.lbxPeople.Size = new System.Drawing.Size(744, 254);
            this.lbxPeople.TabIndex = 9;
            // 
            // tabPageManageParticipants
            // 
            this.tabPageManageParticipants.Controls.Add(this.gbxFilterParticipants);
            this.tabPageManageParticipants.Controls.Add(this.btnViewEnrollmentDetails);
            this.tabPageManageParticipants.Controls.Add(this.btnRemoveParticipant);
            this.tabPageManageParticipants.Controls.Add(this.lbxParticipants);
            this.tabPageManageParticipants.Location = new System.Drawing.Point(4, 31);
            this.tabPageManageParticipants.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageManageParticipants.Name = "tabPageManageParticipants";
            this.tabPageManageParticipants.Size = new System.Drawing.Size(1152, 572);
            this.tabPageManageParticipants.TabIndex = 2;
            this.tabPageManageParticipants.Text = "Manage teacher/participants";
            this.tabPageManageParticipants.UseVisualStyleBackColor = true;
            // 
            // gbxFilterParticipants
            // 
            this.gbxFilterParticipants.Controls.Add(this.cbFilterParticipants);
            this.gbxFilterParticipants.Location = new System.Drawing.Point(196, 49);
            this.gbxFilterParticipants.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxFilterParticipants.Name = "gbxFilterParticipants";
            this.gbxFilterParticipants.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxFilterParticipants.Size = new System.Drawing.Size(759, 101);
            this.gbxFilterParticipants.TabIndex = 16;
            this.gbxFilterParticipants.TabStop = false;
            this.gbxFilterParticipants.Text = "Show teacher/participants";
            // 
            // cbFilterParticipants
            // 
            this.cbFilterParticipants.FormattingEnabled = true;
            this.cbFilterParticipants.Items.AddRange(new object[] {
            "All",
            "Teacher",
            "Participants"});
            this.cbFilterParticipants.Location = new System.Drawing.Point(219, 47);
            this.cbFilterParticipants.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbFilterParticipants.Name = "cbFilterParticipants";
            this.cbFilterParticipants.Size = new System.Drawing.Size(300, 30);
            this.cbFilterParticipants.TabIndex = 13;
            this.cbFilterParticipants.Text = "All";
            this.cbFilterParticipants.SelectedIndexChanged += new System.EventHandler(this.cbFilterParticipants_SelectedIndexChanged);
            // 
            // btnViewEnrollmentDetails
            // 
            this.btnViewEnrollmentDetails.Location = new System.Drawing.Point(630, 492);
            this.btnViewEnrollmentDetails.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnViewEnrollmentDetails.Name = "btnViewEnrollmentDetails";
            this.btnViewEnrollmentDetails.Size = new System.Drawing.Size(325, 45);
            this.btnViewEnrollmentDetails.TabIndex = 14;
            this.btnViewEnrollmentDetails.Text = "View enrollment details";
            this.btnViewEnrollmentDetails.UseVisualStyleBackColor = true;
            this.btnViewEnrollmentDetails.Click += new System.EventHandler(this.btnViewEnrollmentDetails_Click);
            // 
            // btnRemoveParticipant
            // 
            this.btnRemoveParticipant.Location = new System.Drawing.Point(196, 492);
            this.btnRemoveParticipant.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRemoveParticipant.Name = "btnRemoveParticipant";
            this.btnRemoveParticipant.Size = new System.Drawing.Size(390, 45);
            this.btnRemoveParticipant.TabIndex = 13;
            this.btnRemoveParticipant.Text = "Remove teacher/participant";
            this.btnRemoveParticipant.UseVisualStyleBackColor = true;
            this.btnRemoveParticipant.Click += new System.EventHandler(this.btnRemoveParticipant_Click);
            // 
            // lbxParticipants
            // 
            this.lbxParticipants.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxParticipants.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbxParticipants.FormattingEnabled = true;
            this.lbxParticipants.ItemHeight = 25;
            this.lbxParticipants.Location = new System.Drawing.Point(196, 171);
            this.lbxParticipants.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbxParticipants.Name = "lbxParticipants";
            this.lbxParticipants.Size = new System.Drawing.Size(759, 304);
            this.lbxParticipants.TabIndex = 12;
            // 
            // EditWorkshopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 632);
            this.Controls.Add(this.tabControlWorkshopMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "EditWorkshopForm";
            this.Text = "EditWorkshopForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditWorkshopForm_FormClosed);
            this.tabControlWorkshopMenu.ResumeLayout(false);
            this.tabPageEditWorkshop.ResumeLayout(false);
            this.gbxEditWorkshop.ResumeLayout(false);
            this.gbxEditWorkshop.PerformLayout();
            this.tabPageAssignPeople.ResumeLayout(false);
            this.tabPageAssignPeople.PerformLayout();
            this.gbxFilterPeople.ResumeLayout(false);
            this.tabPageManageParticipants.ResumeLayout(false);
            this.gbxFilterParticipants.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
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
        private System.Windows.Forms.Button btnAddParticipant;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.ListBox lbxPeople;
        private System.Windows.Forms.Button btnRemoveParticipant;
        private System.Windows.Forms.ListBox lbxParticipants;
        private System.Windows.Forms.Button btnViewEnrollmentDetails;
        private System.Windows.Forms.GroupBox gbxFilterPeople;
        private System.Windows.Forms.ComboBox cbFilterPeople;
        private System.Windows.Forms.Label lbTeacher;
        private System.Windows.Forms.GroupBox gbxFilterParticipants;
        private System.Windows.Forms.ComboBox cbFilterParticipants;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}