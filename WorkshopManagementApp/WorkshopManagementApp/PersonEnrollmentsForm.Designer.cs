
namespace WorkshopManagementApp
{
    partial class PersonEnrollmentsForm
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
            this.lbxPersonEnrollments = new System.Windows.Forms.ListBox();
            this.lbPersonEnrollments = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxPersonEnrollments
            // 
            this.lbxPersonEnrollments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxPersonEnrollments.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbxPersonEnrollments.FormattingEnabled = true;
            this.lbxPersonEnrollments.ItemHeight = 25;
            this.lbxPersonEnrollments.Location = new System.Drawing.Point(92, 109);
            this.lbxPersonEnrollments.Name = "lbxPersonEnrollments";
            this.lbxPersonEnrollments.Size = new System.Drawing.Size(711, 354);
            this.lbxPersonEnrollments.TabIndex = 0;
            // 
            // lbPersonEnrollments
            // 
            this.lbPersonEnrollments.AutoSize = true;
            this.lbPersonEnrollments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPersonEnrollments.Location = new System.Drawing.Point(339, 56);
            this.lbPersonEnrollments.Name = "lbPersonEnrollments";
            this.lbPersonEnrollments.Size = new System.Drawing.Size(197, 25);
            this.lbPersonEnrollments.TabIndex = 1;
            this.lbPersonEnrollments.Text = "Person enrollments";
            // 
            // PersonEnrollmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 505);
            this.Controls.Add(this.lbPersonEnrollments);
            this.Controls.Add(this.lbxPersonEnrollments);
            this.Name = "PersonEnrollmentsForm";
            this.Text = "PersonEnrollmentsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxPersonEnrollments;
        private System.Windows.Forms.Label lbPersonEnrollments;
    }
}