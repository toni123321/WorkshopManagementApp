
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
            this.tabPageManageWorkshops = new System.Windows.Forms.TabPage();
            this.btnGeneratePrintableFileAvailableWorkshops = new System.Windows.Forms.Button();
            this.btnFinishWorkshop = new System.Windows.Forms.Button();
            this.gbxFilterWorkshops = new System.Windows.Forms.GroupBox();
            this.cbFilterWorkshops = new System.Windows.Forms.ComboBox();
            this.btnStartWorkshop = new System.Windows.Forms.Button();
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
            this.tabControlMainMenu.Location = new System.Drawing.Point(15, 13);
            this.tabControlMainMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControlMainMenu.Name = "tabControlMainMenu";
            this.tabControlMainMenu.SelectedIndex = 0;
            this.tabControlMainMenu.Size = new System.Drawing.Size(1265, 672);
            this.tabControlMainMenu.TabIndex = 0;
            // 
            // tabPageWorkshops
            // 
            this.tabPageWorkshops.Controls.Add(this.tabControlWorkshopMenu);
            this.tabPageWorkshops.Location = new System.Drawing.Point(4, 31);
            this.tabPageWorkshops.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageWorkshops.Name = "tabPageWorkshops";
            this.tabPageWorkshops.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageWorkshops.Size = new System.Drawing.Size(1257, 637);
            this.tabPageWorkshops.TabIndex = 0;
            this.tabPageWorkshops.Text = "Workshops";
            this.tabPageWorkshops.UseVisualStyleBackColor = true;
            // 
            // tabControlWorkshopMenu
            // 
            this.tabControlWorkshopMenu.Controls.Add(this.tabPageCreateWorkshop);
            this.tabControlWorkshopMenu.Controls.Add(this.tabPageManageWorkshops);
            this.tabControlWorkshopMenu.Location = new System.Drawing.Point(7, 20);
            this.tabControlWorkshopMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControlWorkshopMenu.Name = "tabControlWorkshopMenu";
            this.tabControlWorkshopMenu.SelectedIndex = 0;
            this.tabControlWorkshopMenu.Size = new System.Drawing.Size(1241, 609);
            this.tabControlWorkshopMenu.TabIndex = 0;
            this.tabControlWorkshopMenu.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlWorkshopMenu_Selected);
            // 
            // tabPageCreateWorkshop
            // 
            this.tabPageCreateWorkshop.Controls.Add(this.gbxChooseWorkshop);
            this.tabPageCreateWorkshop.Controls.Add(this.gbxCreateWorkshop);
            this.tabPageCreateWorkshop.Location = new System.Drawing.Point(4, 31);
            this.tabPageCreateWorkshop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageCreateWorkshop.Name = "tabPageCreateWorkshop";
            this.tabPageCreateWorkshop.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageCreateWorkshop.Size = new System.Drawing.Size(1233, 574);
            this.tabPageCreateWorkshop.TabIndex = 0;
            this.tabPageCreateWorkshop.Text = "Create workshop";
            this.tabPageCreateWorkshop.UseVisualStyleBackColor = true;
            // 
            // gbxChooseWorkshop
            // 
            this.gbxChooseWorkshop.Controls.Add(this.cbChooseWorkshop);
            this.gbxChooseWorkshop.Location = new System.Drawing.Point(181, 31);
            this.gbxChooseWorkshop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxChooseWorkshop.Name = "gbxChooseWorkshop";
            this.gbxChooseWorkshop.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxChooseWorkshop.Size = new System.Drawing.Size(870, 101);
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
            this.cbChooseWorkshop.Location = new System.Drawing.Point(269, 44);
            this.cbChooseWorkshop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbChooseWorkshop.Name = "cbChooseWorkshop";
            this.cbChooseWorkshop.Size = new System.Drawing.Size(300, 30);
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
            this.gbxCreateWorkshop.Location = new System.Drawing.Point(114, 139);
            this.gbxCreateWorkshop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxCreateWorkshop.Name = "gbxCreateWorkshop";
            this.gbxCreateWorkshop.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxCreateWorkshop.Size = new System.Drawing.Size(992, 413);
            this.gbxCreateWorkshop.TabIndex = 1;
            this.gbxCreateWorkshop.TabStop = false;
            this.gbxCreateWorkshop.Text = "Create workshop";
            // 
            // tbxUrl
            // 
            this.tbxUrl.Location = new System.Drawing.Point(213, 274);
            this.tbxUrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxUrl.Name = "tbxUrl";
            this.tbxUrl.Size = new System.Drawing.Size(246, 28);
            this.tbxUrl.TabIndex = 6;
            // 
            // lbUrl
            // 
            this.lbUrl.AutoSize = true;
            this.lbUrl.Location = new System.Drawing.Point(130, 277);
            this.lbUrl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUrl.Name = "lbUrl";
            this.lbUrl.Size = new System.Drawing.Size(55, 22);
            this.lbUrl.TabIndex = 6;
            this.lbUrl.Text = "URL:";
            // 
            // tbxRoomNum
            // 
            this.tbxRoomNum.Location = new System.Drawing.Point(213, 224);
            this.tbxRoomNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxRoomNum.Name = "tbxRoomNum";
            this.tbxRoomNum.Size = new System.Drawing.Size(246, 28);
            this.tbxRoomNum.TabIndex = 5;
            // 
            // lbRoomNum
            // 
            this.lbRoomNum.AutoSize = true;
            this.lbRoomNum.Location = new System.Drawing.Point(57, 231);
            this.lbRoomNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRoomNum.Name = "lbRoomNum";
            this.lbRoomNum.Size = new System.Drawing.Size(129, 22);
            this.lbRoomNum.TabIndex = 5;
            this.lbRoomNum.Text = "roomNumber:";
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(213, 176);
            this.tbxAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(246, 28);
            this.tbxAddress.TabIndex = 4;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(98, 183);
            this.lbAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(89, 22);
            this.lbAddress.TabIndex = 4;
            this.lbAddress.Text = "Address:";
            // 
            // btnCreateWorkshop
            // 
            this.btnCreateWorkshop.Location = new System.Drawing.Point(401, 348);
            this.btnCreateWorkshop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCreateWorkshop.Name = "btnCreateWorkshop";
            this.btnCreateWorkshop.Size = new System.Drawing.Size(180, 42);
            this.btnCreateWorkshop.TabIndex = 8;
            this.btnCreateWorkshop.Text = "Create workshop";
            this.btnCreateWorkshop.UseVisualStyleBackColor = true;
            this.btnCreateWorkshop.Click += new System.EventHandler(this.btnCreateWorkshop_Click);
            // 
            // tbxCapacity
            // 
            this.tbxCapacity.Location = new System.Drawing.Point(213, 127);
            this.tbxCapacity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxCapacity.Name = "tbxCapacity";
            this.tbxCapacity.Size = new System.Drawing.Size(246, 28);
            this.tbxCapacity.TabIndex = 3;
            // 
            // lbCapacity
            // 
            this.lbCapacity.AutoSize = true;
            this.lbCapacity.Location = new System.Drawing.Point(98, 130);
            this.lbCapacity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCapacity.Name = "lbCapacity";
            this.lbCapacity.Size = new System.Drawing.Size(94, 22);
            this.lbCapacity.TabIndex = 3;
            this.lbCapacity.Text = "Capacity:";
            // 
            // tbxShortDescription
            // 
            this.tbxShortDescription.Location = new System.Drawing.Point(533, 132);
            this.tbxShortDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxShortDescription.Multiline = true;
            this.tbxShortDescription.Name = "tbxShortDescription";
            this.tbxShortDescription.Size = new System.Drawing.Size(378, 133);
            this.tbxShortDescription.TabIndex = 7;
            // 
            // lbShortDescription
            // 
            this.lbShortDescription.AutoSize = true;
            this.lbShortDescription.Location = new System.Drawing.Point(649, 96);
            this.lbShortDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbShortDescription.Name = "lbShortDescription";
            this.lbShortDescription.Size = new System.Drawing.Size(168, 22);
            this.lbShortDescription.TabIndex = 7;
            this.lbShortDescription.Text = "Short description:";
            // 
            // tbxTitle
            // 
            this.tbxTitle.Location = new System.Drawing.Point(213, 77);
            this.tbxTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(246, 28);
            this.tbxTitle.TabIndex = 2;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(137, 80);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(56, 22);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Title:";
            // 
            // tabPageManageWorkshops
            // 
            this.tabPageManageWorkshops.Controls.Add(this.btnGeneratePrintableFileAvailableWorkshops);
            this.tabPageManageWorkshops.Controls.Add(this.btnFinishWorkshop);
            this.tabPageManageWorkshops.Controls.Add(this.gbxFilterWorkshops);
            this.tabPageManageWorkshops.Controls.Add(this.btnStartWorkshop);
            this.tabPageManageWorkshops.Controls.Add(this.btnAssignPeople);
            this.tabPageManageWorkshops.Controls.Add(this.btnRemoveWorkshop);
            this.tabPageManageWorkshops.Controls.Add(this.btnEditWorkshop);
            this.tabPageManageWorkshops.Controls.Add(this.lbxWorkshops);
            this.tabPageManageWorkshops.Location = new System.Drawing.Point(4, 31);
            this.tabPageManageWorkshops.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageManageWorkshops.Name = "tabPageManageWorkshops";
            this.tabPageManageWorkshops.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageManageWorkshops.Size = new System.Drawing.Size(1233, 574);
            this.tabPageManageWorkshops.TabIndex = 1;
            this.tabPageManageWorkshops.Text = "Manage workshops";
            this.tabPageManageWorkshops.UseVisualStyleBackColor = true;
            // 
            // btnGeneratePrintableFileAvailableWorkshops
            // 
            this.btnGeneratePrintableFileAvailableWorkshops.BackColor = System.Drawing.Color.Coral;
            this.btnGeneratePrintableFileAvailableWorkshops.Location = new System.Drawing.Point(952, 47);
            this.btnGeneratePrintableFileAvailableWorkshops.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGeneratePrintableFileAvailableWorkshops.Name = "btnGeneratePrintableFileAvailableWorkshops";
            this.btnGeneratePrintableFileAvailableWorkshops.Size = new System.Drawing.Size(257, 72);
            this.btnGeneratePrintableFileAvailableWorkshops.TabIndex = 17;
            this.btnGeneratePrintableFileAvailableWorkshops.Text = "Generate printable file with available workshops";
            this.btnGeneratePrintableFileAvailableWorkshops.UseVisualStyleBackColor = false;
            this.btnGeneratePrintableFileAvailableWorkshops.Click += new System.EventHandler(this.btnGeneratePrintableFileAvailableWorkshops_Click);
            // 
            // btnFinishWorkshop
            // 
            this.btnFinishWorkshop.Location = new System.Drawing.Point(519, 501);
            this.btnFinishWorkshop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFinishWorkshop.Name = "btnFinishWorkshop";
            this.btnFinishWorkshop.Size = new System.Drawing.Size(238, 47);
            this.btnFinishWorkshop.TabIndex = 16;
            this.btnFinishWorkshop.Text = "Finish workshop";
            this.btnFinishWorkshop.UseVisualStyleBackColor = true;
            this.btnFinishWorkshop.Click += new System.EventHandler(this.btnFinishWorkshop_Click);
            // 
            // gbxFilterWorkshops
            // 
            this.gbxFilterWorkshops.Controls.Add(this.cbFilterWorkshops);
            this.gbxFilterWorkshops.Location = new System.Drawing.Point(57, 24);
            this.gbxFilterWorkshops.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxFilterWorkshops.Name = "gbxFilterWorkshops";
            this.gbxFilterWorkshops.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxFilterWorkshops.Size = new System.Drawing.Size(870, 101);
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
            this.cbFilterWorkshops.Location = new System.Drawing.Point(269, 44);
            this.cbFilterWorkshops.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbFilterWorkshops.Name = "cbFilterWorkshops";
            this.cbFilterWorkshops.Size = new System.Drawing.Size(300, 30);
            this.cbFilterWorkshops.TabIndex = 13;
            this.cbFilterWorkshops.Text = "Choose workshop type";
            this.cbFilterWorkshops.SelectedIndexChanged += new System.EventHandler(this.cbFilterWorkshops_SelectedIndexChanged);
            // 
            // btnStartWorkshop
            // 
            this.btnStartWorkshop.Location = new System.Drawing.Point(203, 501);
            this.btnStartWorkshop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStartWorkshop.Name = "btnStartWorkshop";
            this.btnStartWorkshop.Size = new System.Drawing.Size(238, 47);
            this.btnStartWorkshop.TabIndex = 6;
            this.btnStartWorkshop.Text = "Start workshop";
            this.btnStartWorkshop.UseVisualStyleBackColor = true;
            this.btnStartWorkshop.Click += new System.EventHandler(this.btnStartWorkshop_Click);
            // 
            // btnAssignPeople
            // 
            this.btnAssignPeople.Location = new System.Drawing.Point(952, 222);
            this.btnAssignPeople.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAssignPeople.Name = "btnAssignPeople";
            this.btnAssignPeople.Size = new System.Drawing.Size(257, 47);
            this.btnAssignPeople.TabIndex = 4;
            this.btnAssignPeople.Text = "Add people to workshop";
            this.btnAssignPeople.UseVisualStyleBackColor = true;
            this.btnAssignPeople.Click += new System.EventHandler(this.btnAssignPeople_Click);
            // 
            // btnRemoveWorkshop
            // 
            this.btnRemoveWorkshop.Location = new System.Drawing.Point(952, 362);
            this.btnRemoveWorkshop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRemoveWorkshop.Name = "btnRemoveWorkshop";
            this.btnRemoveWorkshop.Size = new System.Drawing.Size(257, 47);
            this.btnRemoveWorkshop.TabIndex = 3;
            this.btnRemoveWorkshop.Text = "Remove";
            this.btnRemoveWorkshop.UseVisualStyleBackColor = true;
            this.btnRemoveWorkshop.Click += new System.EventHandler(this.btnRemoveWorkshop_Click);
            // 
            // btnEditWorkshop
            // 
            this.btnEditWorkshop.Location = new System.Drawing.Point(952, 295);
            this.btnEditWorkshop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditWorkshop.Name = "btnEditWorkshop";
            this.btnEditWorkshop.Size = new System.Drawing.Size(257, 47);
            this.btnEditWorkshop.TabIndex = 2;
            this.btnEditWorkshop.Text = "Edit / View details";
            this.btnEditWorkshop.UseVisualStyleBackColor = true;
            this.btnEditWorkshop.Click += new System.EventHandler(this.btnEditWorkshop_Click);
            // 
            // lbxWorkshops
            // 
            this.lbxWorkshops.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxWorkshops.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbxWorkshops.FormattingEnabled = true;
            this.lbxWorkshops.ItemHeight = 25;
            this.lbxWorkshops.Location = new System.Drawing.Point(57, 144);
            this.lbxWorkshops.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbxWorkshops.Name = "lbxWorkshops";
            this.lbxWorkshops.Size = new System.Drawing.Size(869, 329);
            this.lbxWorkshops.TabIndex = 0;
            // 
            // tabPagePeople
            // 
            this.tabPagePeople.Controls.Add(this.tabControlPeopleMenu);
            this.tabPagePeople.Location = new System.Drawing.Point(4, 31);
            this.tabPagePeople.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPagePeople.Name = "tabPagePeople";
            this.tabPagePeople.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPagePeople.Size = new System.Drawing.Size(1257, 637);
            this.tabPagePeople.TabIndex = 1;
            this.tabPagePeople.Text = "People";
            this.tabPagePeople.UseVisualStyleBackColor = true;
            // 
            // tabControlPeopleMenu
            // 
            this.tabControlPeopleMenu.Controls.Add(this.tabPageRegisterPerson);
            this.tabControlPeopleMenu.Controls.Add(this.tabPageManagePeople);
            this.tabControlPeopleMenu.Location = new System.Drawing.Point(7, 18);
            this.tabControlPeopleMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControlPeopleMenu.Name = "tabControlPeopleMenu";
            this.tabControlPeopleMenu.SelectedIndex = 0;
            this.tabControlPeopleMenu.Size = new System.Drawing.Size(1232, 612);
            this.tabControlPeopleMenu.TabIndex = 0;
            this.tabControlPeopleMenu.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlPeopleMenu_Selected);
            // 
            // tabPageRegisterPerson
            // 
            this.tabPageRegisterPerson.Controls.Add(this.gbxRegisterPerson);
            this.tabPageRegisterPerson.Location = new System.Drawing.Point(4, 31);
            this.tabPageRegisterPerson.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageRegisterPerson.Name = "tabPageRegisterPerson";
            this.tabPageRegisterPerson.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageRegisterPerson.Size = new System.Drawing.Size(1224, 577);
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
            this.gbxRegisterPerson.Location = new System.Drawing.Point(325, 100);
            this.gbxRegisterPerson.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxRegisterPerson.Name = "gbxRegisterPerson";
            this.gbxRegisterPerson.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxRegisterPerson.Size = new System.Drawing.Size(538, 405);
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
            this.cbUserType.Location = new System.Drawing.Point(221, 265);
            this.cbUserType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbUserType.Name = "cbUserType";
            this.cbUserType.Size = new System.Drawing.Size(245, 30);
            this.cbUserType.TabIndex = 5;
            this.cbUserType.Text = "Student/teacher";
            // 
            // lbUserType
            // 
            this.lbUserType.AutoSize = true;
            this.lbUserType.Location = new System.Drawing.Point(91, 268);
            this.lbUserType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUserType.Name = "lbUserType";
            this.lbUserType.Size = new System.Drawing.Size(102, 22);
            this.lbUserType.TabIndex = 5;
            this.lbUserType.Text = "User type:";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(220, 211);
            this.tbxEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(246, 28);
            this.tbxEmail.TabIndex = 4;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(128, 217);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(65, 22);
            this.lbEmail.TabIndex = 4;
            this.lbEmail.Text = "Email:";
            // 
            // btnRegisterPerson
            // 
            this.btnRegisterPerson.Location = new System.Drawing.Point(220, 325);
            this.btnRegisterPerson.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRegisterPerson.Name = "btnRegisterPerson";
            this.btnRegisterPerson.Size = new System.Drawing.Size(247, 42);
            this.btnRegisterPerson.TabIndex = 6;
            this.btnRegisterPerson.Text = "Register person";
            this.btnRegisterPerson.UseVisualStyleBackColor = true;
            this.btnRegisterPerson.Click += new System.EventHandler(this.btnRegisterPerson_Click);
            // 
            // tbxLName
            // 
            this.tbxLName.Location = new System.Drawing.Point(220, 161);
            this.tbxLName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxLName.Name = "tbxLName";
            this.tbxLName.Size = new System.Drawing.Size(246, 28);
            this.tbxLName.TabIndex = 3;
            // 
            // lbLName
            // 
            this.lbLName.AutoSize = true;
            this.lbLName.Location = new System.Drawing.Point(85, 167);
            this.lbLName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLName.Name = "lbLName";
            this.lbLName.Size = new System.Drawing.Size(108, 22);
            this.lbLName.TabIndex = 3;
            this.lbLName.Text = "Last name:";
            // 
            // tbxFName
            // 
            this.tbxFName.Location = new System.Drawing.Point(220, 111);
            this.tbxFName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxFName.Name = "tbxFName";
            this.tbxFName.Size = new System.Drawing.Size(246, 28);
            this.tbxFName.TabIndex = 2;
            // 
            // lbFName
            // 
            this.lbFName.AutoSize = true;
            this.lbFName.Location = new System.Drawing.Point(83, 117);
            this.lbFName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFName.Name = "lbFName";
            this.lbFName.Size = new System.Drawing.Size(110, 22);
            this.lbFName.TabIndex = 2;
            this.lbFName.Text = "First name:";
            // 
            // tbxPcn
            // 
            this.tbxPcn.Location = new System.Drawing.Point(220, 63);
            this.tbxPcn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxPcn.Name = "tbxPcn";
            this.tbxPcn.Size = new System.Drawing.Size(246, 28);
            this.tbxPcn.TabIndex = 1;
            // 
            // lbPcn
            // 
            this.lbPcn.AutoSize = true;
            this.lbPcn.Location = new System.Drawing.Point(136, 66);
            this.lbPcn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPcn.Name = "lbPcn";
            this.lbPcn.Size = new System.Drawing.Size(57, 22);
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
            this.tabPageManagePeople.Location = new System.Drawing.Point(4, 31);
            this.tabPageManagePeople.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageManagePeople.Name = "tabPageManagePeople";
            this.tabPageManagePeople.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageManagePeople.Size = new System.Drawing.Size(1224, 577);
            this.tabPageManagePeople.TabIndex = 1;
            this.tabPageManagePeople.Text = "Manage people";
            this.tabPageManagePeople.UseVisualStyleBackColor = true;
            // 
            // gbxFilterPeople
            // 
            this.gbxFilterPeople.Controls.Add(this.cbFilterPeople);
            this.gbxFilterPeople.Location = new System.Drawing.Point(60, 83);
            this.gbxFilterPeople.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxFilterPeople.Name = "gbxFilterPeople";
            this.gbxFilterPeople.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbxFilterPeople.Size = new System.Drawing.Size(870, 101);
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
            this.cbFilterPeople.Location = new System.Drawing.Point(269, 44);
            this.cbFilterPeople.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbFilterPeople.Name = "cbFilterPeople";
            this.cbFilterPeople.Size = new System.Drawing.Size(300, 30);
            this.cbFilterPeople.TabIndex = 13;
            this.cbFilterPeople.Text = "Choose students/teachers...";
            this.cbFilterPeople.SelectedIndexChanged += new System.EventHandler(this.cbFilterPeople_SelectedIndexChanged);
            // 
            // btnViewEnrollmentsPerson
            // 
            this.btnViewEnrollmentsPerson.Location = new System.Drawing.Point(959, 432);
            this.btnViewEnrollmentsPerson.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnViewEnrollmentsPerson.Name = "btnViewEnrollmentsPerson";
            this.btnViewEnrollmentsPerson.Size = new System.Drawing.Size(192, 47);
            this.btnViewEnrollmentsPerson.TabIndex = 12;
            this.btnViewEnrollmentsPerson.Text = "View enrollments";
            this.btnViewEnrollmentsPerson.UseVisualStyleBackColor = true;
            // 
            // btnRemovePerson
            // 
            this.btnRemovePerson.Location = new System.Drawing.Point(959, 347);
            this.btnRemovePerson.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRemovePerson.Name = "btnRemovePerson";
            this.btnRemovePerson.Size = new System.Drawing.Size(192, 47);
            this.btnRemovePerson.TabIndex = 10;
            this.btnRemovePerson.Text = "Remove";
            this.btnRemovePerson.UseVisualStyleBackColor = true;
            this.btnRemovePerson.Click += new System.EventHandler(this.btnRemovePerson_Click);
            // 
            // btnEditPerson
            // 
            this.btnEditPerson.Location = new System.Drawing.Point(959, 254);
            this.btnEditPerson.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditPerson.Name = "btnEditPerson";
            this.btnEditPerson.Size = new System.Drawing.Size(192, 47);
            this.btnEditPerson.TabIndex = 9;
            this.btnEditPerson.Text = "Edit";
            this.btnEditPerson.UseVisualStyleBackColor = true;
            this.btnEditPerson.Click += new System.EventHandler(this.btnEditPerson_Click);
            // 
            // lbxPeople
            // 
            this.lbxPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxPeople.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbxPeople.FormattingEnabled = true;
            this.lbxPeople.ItemHeight = 25;
            this.lbxPeople.Location = new System.Drawing.Point(60, 204);
            this.lbxPeople.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbxPeople.Name = "lbxPeople";
            this.lbxPeople.Size = new System.Drawing.Size(869, 329);
            this.lbxPeople.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1283, 690);
            this.Controls.Add(this.tabControlMainMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "WorkshopManagement App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.Button btnEditWorkshop;
        private System.Windows.Forms.ListBox lbxWorkshops;
        private System.Windows.Forms.Button btnStartWorkshop;
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
        private System.Windows.Forms.Button btnFinishWorkshop;
        private System.Windows.Forms.Button btnGeneratePrintableFileAvailableWorkshops;
    }
}

