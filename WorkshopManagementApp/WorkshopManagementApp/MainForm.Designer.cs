
namespace WorkshopManagementApp
{
    partial class MainForm
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
            this.tabControlMainMenu = new System.Windows.Forms.TabControl();
            this.tabPageWorkshops = new System.Windows.Forms.TabPage();
            this.tabControlWorkshopMenu = new System.Windows.Forms.TabControl();
            this.tabPageCreateWorkshop = new System.Windows.Forms.TabPage();
            this.gbxChooseWorkshop = new System.Windows.Forms.GroupBox();
            this.cbChooseWorkshop = new System.Windows.Forms.ComboBox();
            this.gbxCreateWorkshop = new System.Windows.Forms.GroupBox();
            this.tbxUrl = new System.Windows.Forms.TextBox();
            this.lbUrl = new System.Windows.Forms.Label();
            this.tbxRoomNum = new System.Windows.Forms.TextBox();
            this.lbRoomNum = new System.Windows.Forms.Label();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.btnCreateWorkshop = new System.Windows.Forms.Button();
            this.tbxCapacity = new System.Windows.Forms.TextBox();
            this.lbCapacity = new System.Windows.Forms.Label();
            this.tbxShortDescription = new System.Windows.Forms.TextBox();
            this.lbShortDescription = new System.Windows.Forms.Label();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.tabPageManageWorkshops = new System.Windows.Forms.TabPage();
            this.gbxFilterWorkshops = new System.Windows.Forms.GroupBox();
            this.cbFilterWorkshops = new System.Windows.Forms.ComboBox();
            this.btnViewAvailableWorkshops = new System.Windows.Forms.Button();
            this.btnStartFinishWorkshop = new System.Windows.Forms.Button();
            this.btnSeeDetailsWorkshop = new System.Windows.Forms.Button();
            this.btnAssignPeople = new System.Windows.Forms.Button();
            this.btnRemoveWorkshop = new System.Windows.Forms.Button();
            this.btnEditWorkshop = new System.Windows.Forms.Button();
            this.lbxWorkshops = new System.Windows.Forms.ListBox();
            this.tabPagePeople = new System.Windows.Forms.TabPage();
            this.tabControlPeopleMenu = new System.Windows.Forms.TabControl();
            this.tabPageRegisterPerson = new System.Windows.Forms.TabPage();
            this.gbxRegisterPerson = new System.Windows.Forms.GroupBox();
            this.cbUserType = new System.Windows.Forms.ComboBox();
            this.lbUserType = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.btnRegisterPerson = new System.Windows.Forms.Button();
            this.tbxLName = new System.Windows.Forms.TextBox();
            this.lbLName = new System.Windows.Forms.Label();
            this.tbxFName = new System.Windows.Forms.TextBox();
            this.lbFName = new System.Windows.Forms.Label();
            this.tbxPcn = new System.Windows.Forms.TextBox();
            this.lbPcn = new System.Windows.Forms.Label();
            this.tabPageManagePeople = new System.Windows.Forms.TabPage();
            this.gbxFilterPeople = new System.Windows.Forms.GroupBox();
            this.cbFilterPeople = new System.Windows.Forms.ComboBox();
            this.btnViewEnrollmentsPerson = new System.Windows.Forms.Button();
            this.btnRemovePerson = new System.Windows.Forms.Button();
            this.btnEditPerson = new System.Windows.Forms.Button();
            this.lbxPeople = new System.Windows.Forms.ListBox();
            this.tabControlMainMenu.SuspendLayout();
            this.tabPageWorkshops.SuspendLayout();
            this.tabControlWorkshopMenu.SuspendLayout();
            this.tabPageCreateWorkshop.SuspendLayout();
            this.gbxChooseWorkshop.SuspendLayout();
            this.gbxCreateWorkshop.SuspendLayout();
            this.tabPageManageWorkshops.SuspendLayout();
            this.gbxFilterWorkshops.SuspendLayout();
            this.tabPagePeople.SuspendLayout();
            this.tabControlPeopleMenu.SuspendLayout();
            this.tabPageRegisterPerson.SuspendLayout();
            this.gbxRegisterPerson.SuspendLayout();
            this.tabPageManagePeople.SuspendLayout();
            this.gbxFilterPeople.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMainMenu
            // 
            this.tabControlMainMenu.Controls.Add(this.tabPageWorkshops);
            this.tabControlMainMenu.Controls.Add(this.tabPagePeople);
            this.tabControlMainMenu.Location = new System.Drawing.Point(12, 12);
            this.tabControlMainMenu.Name = "tabControlMainMenu";
            this.tabControlMainMenu.SelectedIndex = 0;
            this.tabControlMainMenu.Size = new System.Drawing.Size(1035, 611);
            this.tabControlMainMenu.TabIndex = 0;
            // 
            // tabPageWorkshops
            // 
            this.tabPageWorkshops.Controls.Add(this.tabControlWorkshopMenu);
            this.tabPageWorkshops.Location = new System.Drawing.Point(4, 29);
            this.tabPageWorkshops.Name = "tabPageWorkshops";
            this.tabPageWorkshops.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWorkshops.Size = new System.Drawing.Size(1027, 578);
            this.tabPageWorkshops.TabIndex = 0;
            this.tabPageWorkshops.Text = "Workshops";
            this.tabPageWorkshops.UseVisualStyleBackColor = true;
            // 
            // tabControlWorkshopMenu
            // 
            this.tabControlWorkshopMenu.Controls.Add(this.tabPageCreateWorkshop);
            this.tabControlWorkshopMenu.Controls.Add(this.tabPageManageWorkshops);
            this.tabControlWorkshopMenu.Location = new System.Drawing.Point(6, 18);
            this.tabControlWorkshopMenu.Name = "tabControlWorkshopMenu";
            this.tabControlWorkshopMenu.SelectedIndex = 0;
            this.tabControlWorkshopMenu.Size = new System.Drawing.Size(1015, 554);
            this.tabControlWorkshopMenu.TabIndex = 0;
            this.tabControlWorkshopMenu.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlWorkshopMenu_Selected);
            // 
            // tabPageCreateWorkshop
            // 
            this.tabPageCreateWorkshop.Controls.Add(this.gbxChooseWorkshop);
            this.tabPageCreateWorkshop.Controls.Add(this.gbxCreateWorkshop);
            this.tabPageCreateWorkshop.Location = new System.Drawing.Point(4, 29);
            this.tabPageCreateWorkshop.Name = "tabPageCreateWorkshop";
            this.tabPageCreateWorkshop.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCreateWorkshop.Size = new System.Drawing.Size(1007, 521);
            this.tabPageCreateWorkshop.TabIndex = 0;
            this.tabPageCreateWorkshop.Text = "Create workshop";
            this.tabPageCreateWorkshop.UseVisualStyleBackColor = true;
            // 
            // gbxChooseWorkshop
            // 
            this.gbxChooseWorkshop.Controls.Add(this.cbChooseWorkshop);
            this.gbxChooseWorkshop.Location = new System.Drawing.Point(148, 28);
            this.gbxChooseWorkshop.Name = "gbxChooseWorkshop";
            this.gbxChooseWorkshop.Size = new System.Drawing.Size(712, 92);
            this.gbxChooseWorkshop.TabIndex = 0;
            this.gbxChooseWorkshop.TabStop = false;
            this.gbxChooseWorkshop.Text = "Choose type of workshop you want to create";
            // 
            // cbChooseWorkshop
            // 
            this.cbChooseWorkshop.FormattingEnabled = true;
            this.cbChooseWorkshop.Items.AddRange(new object[] {
            "Onsite",
            "Online"});
            this.cbChooseWorkshop.Location = new System.Drawing.Point(220, 40);
            this.cbChooseWorkshop.Name = "cbChooseWorkshop";
            this.cbChooseWorkshop.Size = new System.Drawing.Size(246, 28);
            this.cbChooseWorkshop.TabIndex = 0;
            this.cbChooseWorkshop.Text = "Onsite/Online...";
            this.cbChooseWorkshop.SelectedIndexChanged += new System.EventHandler(this.cbChooseWorkshop_SelectedIndexChanged);
            // 
            // gbxCreateWorkshop
            // 
            this.gbxCreateWorkshop.Controls.Add(this.tbxUrl);
            this.gbxCreateWorkshop.Controls.Add(this.lbUrl);
            this.gbxCreateWorkshop.Controls.Add(this.tbxRoomNum);
            this.gbxCreateWorkshop.Controls.Add(this.lbRoomNum);
            this.gbxCreateWorkshop.Controls.Add(this.tbxAddress);
            this.gbxCreateWorkshop.Controls.Add(this.lbAddress);
            this.gbxCreateWorkshop.Controls.Add(this.btnCreateWorkshop);
            this.gbxCreateWorkshop.Controls.Add(this.tbxCapacity);
            this.gbxCreateWorkshop.Controls.Add(this.lbCapacity);
            this.gbxCreateWorkshop.Controls.Add(this.tbxShortDescription);
            this.gbxCreateWorkshop.Controls.Add(this.lbShortDescription);
            this.gbxCreateWorkshop.Controls.Add(this.tbxTitle);
            this.gbxCreateWorkshop.Controls.Add(this.lbTitle);
            this.gbxCreateWorkshop.Controls.Add(this.tbxId);
            this.gbxCreateWorkshop.Controls.Add(this.lbId);
            this.gbxCreateWorkshop.Location = new System.Drawing.Point(93, 126);
            this.gbxCreateWorkshop.Name = "gbxCreateWorkshop";
            this.gbxCreateWorkshop.Size = new System.Drawing.Size(812, 375);
            this.gbxCreateWorkshop.TabIndex = 1;
            this.gbxCreateWorkshop.TabStop = false;
            this.gbxCreateWorkshop.Text = "Create workshop";
            // 
            // tbxUrl
            // 
            this.tbxUrl.Location = new System.Drawing.Point(165, 269);
            this.tbxUrl.Name = "tbxUrl";
            this.tbxUrl.Size = new System.Drawing.Size(202, 26);
            this.tbxUrl.TabIndex = 6;
            // 
            // lbUrl
            // 
            this.lbUrl.AutoSize = true;
            this.lbUrl.Location = new System.Drawing.Point(97, 272);
            this.lbUrl.Name = "lbUrl";
            this.lbUrl.Size = new System.Drawing.Size(46, 20);
            this.lbUrl.TabIndex = 6;
            this.lbUrl.Text = "URL:";
            // 
            // tbxRoomNum
            // 
            this.tbxRoomNum.Location = new System.Drawing.Point(165, 224);
            this.tbxRoomNum.Name = "tbxRoomNum";
            this.tbxRoomNum.Size = new System.Drawing.Size(202, 26);
            this.tbxRoomNum.TabIndex = 5;
            // 
            // lbRoomNum
            // 
            this.lbRoomNum.AutoSize = true;
            this.lbRoomNum.Location = new System.Drawing.Point(38, 230);
            this.lbRoomNum.Name = "lbRoomNum";
            this.lbRoomNum.Size = new System.Drawing.Size(105, 20);
            this.lbRoomNum.TabIndex = 5;
            this.lbRoomNum.Text = "roomNumber:";
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(165, 180);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(202, 26);
            this.tbxAddress.TabIndex = 4;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(71, 186);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(72, 20);
            this.lbAddress.TabIndex = 4;
            this.lbAddress.Text = "Address:";
            // 
            // btnCreateWorkshop
            // 
            this.btnCreateWorkshop.Location = new System.Drawing.Point(328, 316);
            this.btnCreateWorkshop.Name = "btnCreateWorkshop";
            this.btnCreateWorkshop.Size = new System.Drawing.Size(147, 38);
            this.btnCreateWorkshop.TabIndex = 8;
            this.btnCreateWorkshop.Text = "Create workshop";
            this.btnCreateWorkshop.UseVisualStyleBackColor = true;
            this.btnCreateWorkshop.Click += new System.EventHandler(this.btnCreateWorkshop_Click);
            // 
            // tbxCapacity
            // 
            this.tbxCapacity.Location = new System.Drawing.Point(165, 135);
            this.tbxCapacity.Name = "tbxCapacity";
            this.tbxCapacity.Size = new System.Drawing.Size(202, 26);
            this.tbxCapacity.TabIndex = 3;
            // 
            // lbCapacity
            // 
            this.lbCapacity.AutoSize = true;
            this.lbCapacity.Location = new System.Drawing.Point(71, 138);
            this.lbCapacity.Name = "lbCapacity";
            this.lbCapacity.Size = new System.Drawing.Size(74, 20);
            this.lbCapacity.TabIndex = 3;
            this.lbCapacity.Text = "Capacity:";
            // 
            // tbxShortDescription
            // 
            this.tbxShortDescription.Location = new System.Drawing.Point(436, 120);
            this.tbxShortDescription.Multiline = true;
            this.tbxShortDescription.Name = "tbxShortDescription";
            this.tbxShortDescription.Size = new System.Drawing.Size(310, 121);
            this.tbxShortDescription.TabIndex = 7;
            // 
            // lbShortDescription
            // 
            this.lbShortDescription.AutoSize = true;
            this.lbShortDescription.Location = new System.Drawing.Point(531, 87);
            this.lbShortDescription.Name = "lbShortDescription";
            this.lbShortDescription.Size = new System.Drawing.Size(133, 20);
            this.lbShortDescription.TabIndex = 7;
            this.lbShortDescription.Text = "Short description:";
            // 
            // tbxTitle
            // 
            this.tbxTitle.Location = new System.Drawing.Point(165, 90);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(202, 26);
            this.tbxTitle.TabIndex = 2;
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
            this.tbxId.Size = new System.Drawing.Size(202, 26);
            this.tbxId.TabIndex = 1;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(118, 49);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(27, 20);
            this.lbId.TabIndex = 1;
            this.lbId.Text = "Id:";
            // 
            // tabPageManageWorkshops
            // 
            this.tabPageManageWorkshops.Controls.Add(this.gbxFilterWorkshops);
            this.tabPageManageWorkshops.Controls.Add(this.btnViewAvailableWorkshops);
            this.tabPageManageWorkshops.Controls.Add(this.btnStartFinishWorkshop);
            this.tabPageManageWorkshops.Controls.Add(this.btnSeeDetailsWorkshop);
            this.tabPageManageWorkshops.Controls.Add(this.btnAssignPeople);
            this.tabPageManageWorkshops.Controls.Add(this.btnRemoveWorkshop);
            this.tabPageManageWorkshops.Controls.Add(this.btnEditWorkshop);
            this.tabPageManageWorkshops.Controls.Add(this.lbxWorkshops);
            this.tabPageManageWorkshops.Location = new System.Drawing.Point(4, 29);
            this.tabPageManageWorkshops.Name = "tabPageManageWorkshops";
            this.tabPageManageWorkshops.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageManageWorkshops.Size = new System.Drawing.Size(1007, 521);
            this.tabPageManageWorkshops.TabIndex = 1;
            this.tabPageManageWorkshops.Text = "Manage workshops";
            this.tabPageManageWorkshops.UseVisualStyleBackColor = true;
            // 
            // gbxFilterWorkshops
            // 
            this.gbxFilterWorkshops.Controls.Add(this.cbFilterWorkshops);
            this.gbxFilterWorkshops.Location = new System.Drawing.Point(47, 22);
            this.gbxFilterWorkshops.Name = "gbxFilterWorkshops";
            this.gbxFilterWorkshops.Size = new System.Drawing.Size(712, 92);
            this.gbxFilterWorkshops.TabIndex = 15;
            this.gbxFilterWorkshops.TabStop = false;
            this.gbxFilterWorkshops.Text = "Show different types of workshops";
            // 
            // cbFilterWorkshops
            // 
            this.cbFilterWorkshops.AutoCompleteCustomSource.AddRange(new string[] {
            "All",
            "Online",
            "Onsite",
            "Started",
            "Available",
            "Past"});
            this.cbFilterWorkshops.FormattingEnabled = true;
            this.cbFilterWorkshops.Items.AddRange(new object[] {
            "All",
            "Onsite",
            "Online",
            "Available",
            "Started",
            "Past"});
            this.cbFilterWorkshops.Location = new System.Drawing.Point(220, 40);
            this.cbFilterWorkshops.Name = "cbFilterWorkshops";
            this.cbFilterWorkshops.Size = new System.Drawing.Size(246, 28);
            this.cbFilterWorkshops.TabIndex = 13;
            this.cbFilterWorkshops.Text = "Choose workshop type";
            this.cbFilterWorkshops.SelectedIndexChanged += new System.EventHandler(this.cbFilterWorkshops_SelectedIndexChanged);
            // 
            // btnViewAvailableWorkshops
            // 
            this.btnViewAvailableWorkshops.Location = new System.Drawing.Point(47, 453);
            this.btnViewAvailableWorkshops.Name = "btnViewAvailableWorkshops";
            this.btnViewAvailableWorkshops.Size = new System.Drawing.Size(210, 43);
            this.btnViewAvailableWorkshops.TabIndex = 7;
            this.btnViewAvailableWorkshops.Text = "View available workshops";
            this.btnViewAvailableWorkshops.UseVisualStyleBackColor = true;
            this.btnViewAvailableWorkshops.Click += new System.EventHandler(this.btnViewAvailableWorkshops_Click);
            // 
            // btnStartFinishWorkshop
            // 
            this.btnStartFinishWorkshop.Location = new System.Drawing.Point(564, 453);
            this.btnStartFinishWorkshop.Name = "btnStartFinishWorkshop";
            this.btnStartFinishWorkshop.Size = new System.Drawing.Size(195, 43);
            this.btnStartFinishWorkshop.TabIndex = 6;
            this.btnStartFinishWorkshop.Text = "Start/Finish workshop";
            this.btnStartFinishWorkshop.UseVisualStyleBackColor = true;
            // 
            // btnSeeDetailsWorkshop
            // 
            this.btnSeeDetailsWorkshop.Location = new System.Drawing.Point(780, 334);
            this.btnSeeDetailsWorkshop.Name = "btnSeeDetailsWorkshop";
            this.btnSeeDetailsWorkshop.Size = new System.Drawing.Size(157, 43);
            this.btnSeeDetailsWorkshop.TabIndex = 5;
            this.btnSeeDetailsWorkshop.Text = "See details";
            this.btnSeeDetailsWorkshop.UseVisualStyleBackColor = true;
            // 
            // btnAssignPeople
            // 
            this.btnAssignPeople.Location = new System.Drawing.Point(325, 453);
            this.btnAssignPeople.Name = "btnAssignPeople";
            this.btnAssignPeople.Size = new System.Drawing.Size(156, 43);
            this.btnAssignPeople.TabIndex = 4;
            this.btnAssignPeople.Text = "AssignPeople";
            this.btnAssignPeople.UseVisualStyleBackColor = true;
            // 
            // btnRemoveWorkshop
            // 
            this.btnRemoveWorkshop.Location = new System.Drawing.Point(780, 264);
            this.btnRemoveWorkshop.Name = "btnRemoveWorkshop";
            this.btnRemoveWorkshop.Size = new System.Drawing.Size(157, 43);
            this.btnRemoveWorkshop.TabIndex = 3;
            this.btnRemoveWorkshop.Text = "Remove";
            this.btnRemoveWorkshop.UseVisualStyleBackColor = true;
            this.btnRemoveWorkshop.Click += new System.EventHandler(this.btnRemoveWorkshop_Click);
            // 
            // btnEditWorkshop
            // 
            this.btnEditWorkshop.Location = new System.Drawing.Point(780, 196);
            this.btnEditWorkshop.Name = "btnEditWorkshop";
            this.btnEditWorkshop.Size = new System.Drawing.Size(157, 43);
            this.btnEditWorkshop.TabIndex = 2;
            this.btnEditWorkshop.Text = "Edit";
            this.btnEditWorkshop.UseVisualStyleBackColor = true;
            this.btnEditWorkshop.Click += new System.EventHandler(this.btnEditWorkshop_Click);
            // 
            // lbxWorkshops
            // 
            this.lbxWorkshops.FormattingEnabled = true;
            this.lbxWorkshops.ItemHeight = 20;
            this.lbxWorkshops.Location = new System.Drawing.Point(47, 131);
            this.lbxWorkshops.Name = "lbxWorkshops";
            this.lbxWorkshops.Size = new System.Drawing.Size(712, 304);
            this.lbxWorkshops.TabIndex = 0;
            // 
            // tabPagePeople
            // 
            this.tabPagePeople.Controls.Add(this.tabControlPeopleMenu);
            this.tabPagePeople.Location = new System.Drawing.Point(4, 29);
            this.tabPagePeople.Name = "tabPagePeople";
            this.tabPagePeople.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePeople.Size = new System.Drawing.Size(1027, 578);
            this.tabPagePeople.TabIndex = 1;
            this.tabPagePeople.Text = "People";
            this.tabPagePeople.UseVisualStyleBackColor = true;
            // 
            // tabControlPeopleMenu
            // 
            this.tabControlPeopleMenu.Controls.Add(this.tabPageRegisterPerson);
            this.tabControlPeopleMenu.Controls.Add(this.tabPageManagePeople);
            this.tabControlPeopleMenu.Location = new System.Drawing.Point(6, 16);
            this.tabControlPeopleMenu.Name = "tabControlPeopleMenu";
            this.tabControlPeopleMenu.SelectedIndex = 0;
            this.tabControlPeopleMenu.Size = new System.Drawing.Size(1008, 556);
            this.tabControlPeopleMenu.TabIndex = 0;
            this.tabControlPeopleMenu.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlPeopleMenu_Selected);
            // 
            // tabPageRegisterPerson
            // 
            this.tabPageRegisterPerson.Controls.Add(this.gbxRegisterPerson);
            this.tabPageRegisterPerson.Location = new System.Drawing.Point(4, 29);
            this.tabPageRegisterPerson.Name = "tabPageRegisterPerson";
            this.tabPageRegisterPerson.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRegisterPerson.Size = new System.Drawing.Size(1000, 523);
            this.tabPageRegisterPerson.TabIndex = 0;
            this.tabPageRegisterPerson.Text = "Register person";
            this.tabPageRegisterPerson.UseVisualStyleBackColor = true;
            // 
            // gbxRegisterPerson
            // 
            this.gbxRegisterPerson.Controls.Add(this.cbUserType);
            this.gbxRegisterPerson.Controls.Add(this.lbUserType);
            this.gbxRegisterPerson.Controls.Add(this.tbxEmail);
            this.gbxRegisterPerson.Controls.Add(this.lbEmail);
            this.gbxRegisterPerson.Controls.Add(this.btnRegisterPerson);
            this.gbxRegisterPerson.Controls.Add(this.tbxLName);
            this.gbxRegisterPerson.Controls.Add(this.lbLName);
            this.gbxRegisterPerson.Controls.Add(this.tbxFName);
            this.gbxRegisterPerson.Controls.Add(this.lbFName);
            this.gbxRegisterPerson.Controls.Add(this.tbxPcn);
            this.gbxRegisterPerson.Controls.Add(this.lbPcn);
            this.gbxRegisterPerson.Location = new System.Drawing.Point(266, 91);
            this.gbxRegisterPerson.Name = "gbxRegisterPerson";
            this.gbxRegisterPerson.Size = new System.Drawing.Size(440, 368);
            this.gbxRegisterPerson.TabIndex = 0;
            this.gbxRegisterPerson.TabStop = false;
            this.gbxRegisterPerson.Text = "Register person";
            // 
            // cbUserType
            // 
            this.cbUserType.FormattingEnabled = true;
            this.cbUserType.Items.AddRange(new object[] {
            "Student",
            "Teacher"});
            this.cbUserType.Location = new System.Drawing.Point(181, 241);
            this.cbUserType.Name = "cbUserType";
            this.cbUserType.Size = new System.Drawing.Size(201, 28);
            this.cbUserType.TabIndex = 5;
            this.cbUserType.Text = "Student/teacher";
            // 
            // lbUserType
            // 
            this.lbUserType.AutoSize = true;
            this.lbUserType.Location = new System.Drawing.Point(68, 244);
            this.lbUserType.Name = "lbUserType";
            this.lbUserType.Size = new System.Drawing.Size(81, 20);
            this.lbUserType.TabIndex = 5;
            this.lbUserType.Text = "User type:";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(180, 192);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(202, 26);
            this.tbxEmail.TabIndex = 4;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(94, 195);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(52, 20);
            this.lbEmail.TabIndex = 4;
            this.lbEmail.Text = "Email:";
            // 
            // btnRegisterPerson
            // 
            this.btnRegisterPerson.Location = new System.Drawing.Point(180, 295);
            this.btnRegisterPerson.Name = "btnRegisterPerson";
            this.btnRegisterPerson.Size = new System.Drawing.Size(202, 38);
            this.btnRegisterPerson.TabIndex = 6;
            this.btnRegisterPerson.Text = "Register person";
            this.btnRegisterPerson.UseVisualStyleBackColor = true;
            this.btnRegisterPerson.Click += new System.EventHandler(this.btnRegisterPerson_Click);
            // 
            // tbxLName
            // 
            this.tbxLName.Location = new System.Drawing.Point(180, 146);
            this.tbxLName.Name = "tbxLName";
            this.tbxLName.Size = new System.Drawing.Size(202, 26);
            this.tbxLName.TabIndex = 3;
            // 
            // lbLName
            // 
            this.lbLName.AutoSize = true;
            this.lbLName.Location = new System.Drawing.Point(68, 149);
            this.lbLName.Name = "lbLName";
            this.lbLName.Size = new System.Drawing.Size(88, 20);
            this.lbLName.TabIndex = 3;
            this.lbLName.Text = "Last name:";
            // 
            // tbxFName
            // 
            this.tbxFName.Location = new System.Drawing.Point(180, 101);
            this.tbxFName.Name = "tbxFName";
            this.tbxFName.Size = new System.Drawing.Size(202, 26);
            this.tbxFName.TabIndex = 2;
            // 
            // lbFName
            // 
            this.lbFName.AutoSize = true;
            this.lbFName.Location = new System.Drawing.Point(68, 107);
            this.lbFName.Name = "lbFName";
            this.lbFName.Size = new System.Drawing.Size(88, 20);
            this.lbFName.TabIndex = 2;
            this.lbFName.Text = "First name:";
            // 
            // tbxPcn
            // 
            this.tbxPcn.Location = new System.Drawing.Point(180, 57);
            this.tbxPcn.Name = "tbxPcn";
            this.tbxPcn.Size = new System.Drawing.Size(202, 26);
            this.tbxPcn.TabIndex = 1;
            // 
            // lbPcn
            // 
            this.lbPcn.AutoSize = true;
            this.lbPcn.Location = new System.Drawing.Point(111, 60);
            this.lbPcn.Name = "lbPcn";
            this.lbPcn.Size = new System.Drawing.Size(45, 20);
            this.lbPcn.TabIndex = 1;
            this.lbPcn.Text = "PCN:";
            // 
            // tabPageManagePeople
            // 
            this.tabPageManagePeople.Controls.Add(this.gbxFilterPeople);
            this.tabPageManagePeople.Controls.Add(this.btnViewEnrollmentsPerson);
            this.tabPageManagePeople.Controls.Add(this.btnRemovePerson);
            this.tabPageManagePeople.Controls.Add(this.btnEditPerson);
            this.tabPageManagePeople.Controls.Add(this.lbxPeople);
            this.tabPageManagePeople.Location = new System.Drawing.Point(4, 29);
            this.tabPageManagePeople.Name = "tabPageManagePeople";
            this.tabPageManagePeople.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageManagePeople.Size = new System.Drawing.Size(1000, 523);
            this.tabPageManagePeople.TabIndex = 1;
            this.tabPageManagePeople.Text = "Manage people";
            this.tabPageManagePeople.UseVisualStyleBackColor = true;
            // 
            // gbxFilterPeople
            // 
            this.gbxFilterPeople.Controls.Add(this.cbFilterPeople);
            this.gbxFilterPeople.Location = new System.Drawing.Point(49, 75);
            this.gbxFilterPeople.Name = "gbxFilterPeople";
            this.gbxFilterPeople.Size = new System.Drawing.Size(712, 92);
            this.gbxFilterPeople.TabIndex = 14;
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
            this.cbFilterPeople.Location = new System.Drawing.Point(220, 40);
            this.cbFilterPeople.Name = "cbFilterPeople";
            this.cbFilterPeople.Size = new System.Drawing.Size(246, 28);
            this.cbFilterPeople.TabIndex = 13;
            this.cbFilterPeople.Text = "Choose students/teachers...";
            this.cbFilterPeople.SelectedIndexChanged += new System.EventHandler(this.cbFilterPeople_SelectedIndexChanged);
            // 
            // btnViewEnrollmentsPerson
            // 
            this.btnViewEnrollmentsPerson.Location = new System.Drawing.Point(785, 393);
            this.btnViewEnrollmentsPerson.Name = "btnViewEnrollmentsPerson";
            this.btnViewEnrollmentsPerson.Size = new System.Drawing.Size(157, 43);
            this.btnViewEnrollmentsPerson.TabIndex = 12;
            this.btnViewEnrollmentsPerson.Text = "View enrollments";
            this.btnViewEnrollmentsPerson.UseVisualStyleBackColor = true;
            // 
            // btnRemovePerson
            // 
            this.btnRemovePerson.Location = new System.Drawing.Point(785, 315);
            this.btnRemovePerson.Name = "btnRemovePerson";
            this.btnRemovePerson.Size = new System.Drawing.Size(157, 43);
            this.btnRemovePerson.TabIndex = 10;
            this.btnRemovePerson.Text = "Remove";
            this.btnRemovePerson.UseVisualStyleBackColor = true;
            this.btnRemovePerson.Click += new System.EventHandler(this.btnRemovePerson_Click);
            // 
            // btnEditPerson
            // 
            this.btnEditPerson.Location = new System.Drawing.Point(785, 231);
            this.btnEditPerson.Name = "btnEditPerson";
            this.btnEditPerson.Size = new System.Drawing.Size(157, 43);
            this.btnEditPerson.TabIndex = 9;
            this.btnEditPerson.Text = "Edit";
            this.btnEditPerson.UseVisualStyleBackColor = true;
            this.btnEditPerson.Click += new System.EventHandler(this.btnEditPerson_Click);
            // 
            // lbxPeople
            // 
            this.lbxPeople.FormattingEnabled = true;
            this.lbxPeople.ItemHeight = 20;
            this.lbxPeople.Location = new System.Drawing.Point(49, 185);
            this.lbxPeople.Name = "lbxPeople";
            this.lbxPeople.Size = new System.Drawing.Size(712, 304);
            this.lbxPeople.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 627);
            this.Controls.Add(this.tabControlMainMenu);
            this.Name = "MainForm";
            this.Text = "WorkshopManagement App";
            this.tabControlMainMenu.ResumeLayout(false);
            this.tabPageWorkshops.ResumeLayout(false);
            this.tabControlWorkshopMenu.ResumeLayout(false);
            this.tabPageCreateWorkshop.ResumeLayout(false);
            this.gbxChooseWorkshop.ResumeLayout(false);
            this.gbxCreateWorkshop.ResumeLayout(false);
            this.gbxCreateWorkshop.PerformLayout();
            this.tabPageManageWorkshops.ResumeLayout(false);
            this.gbxFilterWorkshops.ResumeLayout(false);
            this.tabPagePeople.ResumeLayout(false);
            this.tabControlPeopleMenu.ResumeLayout(false);
            this.tabPageRegisterPerson.ResumeLayout(false);
            this.gbxRegisterPerson.ResumeLayout(false);
            this.gbxRegisterPerson.PerformLayout();
            this.tabPageManagePeople.ResumeLayout(false);
            this.gbxFilterPeople.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMainMenu;
        private System.Windows.Forms.TabPage tabPageWorkshops;
        private System.Windows.Forms.TabControl tabControlWorkshopMenu;
        private System.Windows.Forms.TabPage tabPageCreateWorkshop;
        private System.Windows.Forms.TabPage tabPageManageWorkshops;
        private System.Windows.Forms.TabPage tabPagePeople;
        private System.Windows.Forms.TabControl tabControlPeopleMenu;
        private System.Windows.Forms.TabPage tabPageRegisterPerson;
        private System.Windows.Forms.TabPage tabPageManagePeople;
        private System.Windows.Forms.GroupBox gbxCreateWorkshop;
        private System.Windows.Forms.Button btnCreateWorkshop;
        private System.Windows.Forms.TextBox tbxCapacity;
        private System.Windows.Forms.Label lbCapacity;
        private System.Windows.Forms.TextBox tbxShortDescription;
        private System.Windows.Forms.Label lbShortDescription;
        private System.Windows.Forms.TextBox tbxTitle;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Button btnEditWorkshop;
        private System.Windows.Forms.ListBox lbxWorkshops;
        private System.Windows.Forms.Button btnViewAvailableWorkshops;
        private System.Windows.Forms.Button btnStartFinishWorkshop;
        private System.Windows.Forms.Button btnSeeDetailsWorkshop;
        private System.Windows.Forms.Button btnAssignPeople;
        private System.Windows.Forms.Button btnRemoveWorkshop;
        private System.Windows.Forms.GroupBox gbxRegisterPerson;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Button btnRegisterPerson;
        private System.Windows.Forms.TextBox tbxLName;
        private System.Windows.Forms.Label lbLName;
        private System.Windows.Forms.TextBox tbxFName;
        private System.Windows.Forms.Label lbFName;
        private System.Windows.Forms.TextBox tbxPcn;
        private System.Windows.Forms.Label lbPcn;
        private System.Windows.Forms.GroupBox gbxFilterPeople;
        private System.Windows.Forms.ComboBox cbFilterPeople;
        private System.Windows.Forms.Button btnViewEnrollmentsPerson;
        private System.Windows.Forms.Button btnRemovePerson;
        private System.Windows.Forms.Button btnEditPerson;
        private System.Windows.Forms.ListBox lbxPeople;
        private System.Windows.Forms.ComboBox cbUserType;
        private System.Windows.Forms.Label lbUserType;
        private System.Windows.Forms.TextBox tbxUrl;
        private System.Windows.Forms.Label lbUrl;
        private System.Windows.Forms.TextBox tbxRoomNum;
        private System.Windows.Forms.Label lbRoomNum;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.GroupBox gbxChooseWorkshop;
        private System.Windows.Forms.ComboBox cbChooseWorkshop;
        private System.Windows.Forms.GroupBox gbxFilterWorkshops;
        private System.Windows.Forms.ComboBox cbFilterWorkshops;
    }
}

