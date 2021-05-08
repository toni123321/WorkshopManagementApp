
namespace WorkshopManagementApp
{
    partial class AvailableWorkshopsForm
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
            this.lbxWorkshops = new System.Windows.Forms.ListBox();
            this.lbxWarnings = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbxWorkshops
            // 
            this.lbxWorkshops.FormattingEnabled = true;
            this.lbxWorkshops.ItemHeight = 20;
            this.lbxWorkshops.Location = new System.Drawing.Point(12, 53);
            this.lbxWorkshops.Name = "lbxWorkshops";
            this.lbxWorkshops.Size = new System.Drawing.Size(687, 384);
            this.lbxWorkshops.TabIndex = 0;
            // 
            // lbxWarnings
            // 
            this.lbxWarnings.FormattingEnabled = true;
            this.lbxWarnings.ItemHeight = 20;
            this.lbxWarnings.Location = new System.Drawing.Point(722, 54);
            this.lbxWarnings.Name = "lbxWarnings";
            this.lbxWarnings.Size = new System.Drawing.Size(300, 384);
            this.lbxWarnings.TabIndex = 1;
            // 
            // AvailableWorkshopsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 450);
            this.Controls.Add(this.lbxWarnings);
            this.Controls.Add(this.lbxWorkshops);
            this.Name = "AvailableWorkshopsForm";
            this.Text = "AvailableWorkshopsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AvailableWorkshopsForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxWorkshops;
        private System.Windows.Forms.ListBox lbxWarnings;
    }
}