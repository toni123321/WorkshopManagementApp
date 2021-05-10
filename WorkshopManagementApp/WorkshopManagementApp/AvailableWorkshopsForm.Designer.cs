
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
            this.lbxWorkshops.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxWorkshops.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbxWorkshops.FormattingEnabled = true;
            this.lbxWorkshops.HorizontalScrollbar = true;
            this.lbxWorkshops.ItemHeight = 25;
            this.lbxWorkshops.Location = new System.Drawing.Point(15, 58);
            this.lbxWorkshops.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbxWorkshops.Name = "lbxWorkshops";
            this.lbxWorkshops.Size = new System.Drawing.Size(682, 404);
            this.lbxWorkshops.TabIndex = 0;
            // 
            // lbxWarnings
            // 
            this.lbxWarnings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxWarnings.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbxWarnings.FormattingEnabled = true;
            this.lbxWarnings.HorizontalScrollbar = true;
            this.lbxWarnings.ItemHeight = 25;
            this.lbxWarnings.Location = new System.Drawing.Point(717, 58);
            this.lbxWarnings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbxWarnings.Name = "lbxWarnings";
            this.lbxWarnings.Size = new System.Drawing.Size(519, 404);
            this.lbxWarnings.TabIndex = 1;
            // 
            // AvailableWorkshopsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1270, 495);
            this.Controls.Add(this.lbxWarnings);
            this.Controls.Add(this.lbxWorkshops);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AvailableWorkshopsForm";
            this.Text = "AvailableWorkshopsForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AvailableWorkshopsForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxWorkshops;
        private System.Windows.Forms.ListBox lbxWarnings;
    }
}