
namespace WorkshopManagementApp
{
    partial class EditPersonForm
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
            this.gbxEditPerson = new System.Windows.Forms.GroupBox();
            this.tbxUserType = new System.Windows.Forms.TextBox();
            this.lbUserType = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.btnEditPerson = new System.Windows.Forms.Button();
            this.tbxLName = new System.Windows.Forms.TextBox();
            this.lbLName = new System.Windows.Forms.Label();
            this.tbxFName = new System.Windows.Forms.TextBox();
            this.lbFName = new System.Windows.Forms.Label();
            this.tbxPcn = new System.Windows.Forms.TextBox();
            this.lbPcn = new System.Windows.Forms.Label();
            this.gbxEditPerson.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxEditPerson
            // 
            this.gbxEditPerson.Controls.Add(this.tbxUserType);
            this.gbxEditPerson.Controls.Add(this.lbUserType);
            this.gbxEditPerson.Controls.Add(this.tbxEmail);
            this.gbxEditPerson.Controls.Add(this.lbEmail);
            this.gbxEditPerson.Controls.Add(this.btnEditPerson);
            this.gbxEditPerson.Controls.Add(this.tbxLName);
            this.gbxEditPerson.Controls.Add(this.lbLName);
            this.gbxEditPerson.Controls.Add(this.tbxFName);
            this.gbxEditPerson.Controls.Add(this.lbFName);
            this.gbxEditPerson.Controls.Add(this.tbxPcn);
            this.gbxEditPerson.Controls.Add(this.lbPcn);
            this.gbxEditPerson.Location = new System.Drawing.Point(151, 67);
            this.gbxEditPerson.Name = "gbxEditPerson";
            this.gbxEditPerson.Size = new System.Drawing.Size(440, 368);
            this.gbxEditPerson.TabIndex = 2;
            this.gbxEditPerson.TabStop = false;
            this.gbxEditPerson.Text = "Edit person profile";
            // 
            // tbxUserType
            // 
            this.tbxUserType.Location = new System.Drawing.Point(180, 241);
            this.tbxUserType.Name = "tbxUserType";
            this.tbxUserType.ReadOnly = true;
            this.tbxUserType.Size = new System.Drawing.Size(202, 26);
            this.tbxUserType.TabIndex = 12;
            // 
            // lbUserType
            // 
            this.lbUserType.AutoSize = true;
            this.lbUserType.Location = new System.Drawing.Point(68, 244);
            this.lbUserType.Name = "lbUserType";
            this.lbUserType.Size = new System.Drawing.Size(81, 20);
            this.lbUserType.TabIndex = 11;
            this.lbUserType.Text = "User type:";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(180, 192);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(202, 26);
            this.tbxEmail.TabIndex = 10;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(94, 195);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(52, 20);
            this.lbEmail.TabIndex = 9;
            this.lbEmail.Text = "Email:";
            // 
            // btnEditPerson
            // 
            this.btnEditPerson.Location = new System.Drawing.Point(180, 295);
            this.btnEditPerson.Name = "btnEditPerson";
            this.btnEditPerson.Size = new System.Drawing.Size(202, 38);
            this.btnEditPerson.TabIndex = 8;
            this.btnEditPerson.Text = "Apply changes";
            this.btnEditPerson.UseVisualStyleBackColor = true;
            this.btnEditPerson.Click += new System.EventHandler(this.btnEditPerson_Click);
            // 
            // tbxLName
            // 
            this.tbxLName.Location = new System.Drawing.Point(180, 146);
            this.tbxLName.Name = "tbxLName";
            this.tbxLName.Size = new System.Drawing.Size(202, 26);
            this.tbxLName.TabIndex = 7;
            // 
            // lbLName
            // 
            this.lbLName.AutoSize = true;
            this.lbLName.Location = new System.Drawing.Point(68, 149);
            this.lbLName.Name = "lbLName";
            this.lbLName.Size = new System.Drawing.Size(88, 20);
            this.lbLName.TabIndex = 6;
            this.lbLName.Text = "Last name:";
            // 
            // tbxFName
            // 
            this.tbxFName.Location = new System.Drawing.Point(180, 101);
            this.tbxFName.Name = "tbxFName";
            this.tbxFName.Size = new System.Drawing.Size(202, 26);
            this.tbxFName.TabIndex = 3;
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
            this.tbxPcn.ReadOnly = true;
            this.tbxPcn.Size = new System.Drawing.Size(202, 26);
            this.tbxPcn.TabIndex = 1;
            // 
            // lbPcn
            // 
            this.lbPcn.AutoSize = true;
            this.lbPcn.Location = new System.Drawing.Point(111, 60);
            this.lbPcn.Name = "lbPcn";
            this.lbPcn.Size = new System.Drawing.Size(45, 20);
            this.lbPcn.TabIndex = 0;
            this.lbPcn.Text = "PCN:";
            // 
            // EditPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 500);
            this.Controls.Add(this.gbxEditPerson);
            this.Name = "EditPersonForm";
            this.Text = "EditPersonForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditPersonForm_FormClosed);
            this.gbxEditPerson.ResumeLayout(false);
            this.gbxEditPerson.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxEditPerson;
        private System.Windows.Forms.Label lbUserType;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Button btnEditPerson;
        private System.Windows.Forms.TextBox tbxLName;
        private System.Windows.Forms.Label lbLName;
        private System.Windows.Forms.TextBox tbxFName;
        private System.Windows.Forms.Label lbFName;
        private System.Windows.Forms.TextBox tbxPcn;
        private System.Windows.Forms.Label lbPcn;
        private System.Windows.Forms.TextBox tbxUserType;
    }
}