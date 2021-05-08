
namespace WorkshopManagementApp
{
    partial class ParticipantEnrollmentDetailsForm
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
            this.gbxEnrollmentDetails = new System.Windows.Forms.GroupBox();
            this.tbxSeatNr = new System.Windows.Forms.TextBox();
            this.tbxLoginCode = new System.Windows.Forms.TextBox();
            this.lbSeatNr = new System.Windows.Forms.Label();
            this.lbLoginCode = new System.Windows.Forms.Label();
            this.gbxEnrollmentDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxEnrollmentDetails
            // 
            this.gbxEnrollmentDetails.BackColor = System.Drawing.Color.White;
            this.gbxEnrollmentDetails.Controls.Add(this.lbLoginCode);
            this.gbxEnrollmentDetails.Controls.Add(this.lbSeatNr);
            this.gbxEnrollmentDetails.Controls.Add(this.tbxLoginCode);
            this.gbxEnrollmentDetails.Controls.Add(this.tbxSeatNr);
            this.gbxEnrollmentDetails.Location = new System.Drawing.Point(149, 52);
            this.gbxEnrollmentDetails.Name = "gbxEnrollmentDetails";
            this.gbxEnrollmentDetails.Size = new System.Drawing.Size(380, 227);
            this.gbxEnrollmentDetails.TabIndex = 0;
            this.gbxEnrollmentDetails.TabStop = false;
            this.gbxEnrollmentDetails.Text = "EnrollmentDetails";
            // 
            // tbxSeatNr
            // 
            this.tbxSeatNr.Location = new System.Drawing.Point(133, 76);
            this.tbxSeatNr.Name = "tbxSeatNr";
            this.tbxSeatNr.ReadOnly = true;
            this.tbxSeatNr.Size = new System.Drawing.Size(178, 26);
            this.tbxSeatNr.TabIndex = 0;
            // 
            // tbxLoginCode
            // 
            this.tbxLoginCode.Location = new System.Drawing.Point(133, 137);
            this.tbxLoginCode.Name = "tbxLoginCode";
            this.tbxLoginCode.ReadOnly = true;
            this.tbxLoginCode.Size = new System.Drawing.Size(178, 26);
            this.tbxLoginCode.TabIndex = 1;
            // 
            // lbSeatNr
            // 
            this.lbSeatNr.AutoSize = true;
            this.lbSeatNr.Location = new System.Drawing.Point(52, 79);
            this.lbSeatNr.Name = "lbSeatNr";
            this.lbSeatNr.Size = new System.Drawing.Size(67, 20);
            this.lbSeatNr.TabIndex = 2;
            this.lbSeatNr.Text = "Seat Nr:";
            // 
            // lbLoginCode
            // 
            this.lbLoginCode.AutoSize = true;
            this.lbLoginCode.Location = new System.Drawing.Point(29, 140);
            this.lbLoginCode.Name = "lbLoginCode";
            this.lbLoginCode.Size = new System.Drawing.Size(90, 20);
            this.lbLoginCode.TabIndex = 3;
            this.lbLoginCode.Text = "LoginCode:";
            // 
            // ParticipantEnrollmentDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 338);
            this.Controls.Add(this.gbxEnrollmentDetails);
            this.Name = "ParticipantEnrollmentDetailsForm";
            this.Text = "ParticipantEnrollmentDetailsForm";
            this.gbxEnrollmentDetails.ResumeLayout(false);
            this.gbxEnrollmentDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxEnrollmentDetails;
        private System.Windows.Forms.Label lbLoginCode;
        private System.Windows.Forms.Label lbSeatNr;
        private System.Windows.Forms.TextBox tbxLoginCode;
        private System.Windows.Forms.TextBox tbxSeatNr;
    }
}