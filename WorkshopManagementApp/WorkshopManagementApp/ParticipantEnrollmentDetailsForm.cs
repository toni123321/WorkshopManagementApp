using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace WorkshopManagementApp
{
    public partial class ParticipantEnrollmentDetailsForm : Form
    {
        private WorkshopPerson workshopPerson;
        public ParticipantEnrollmentDetailsForm(WorkshopPerson workshopPerson)
        {
            InitializeComponent();
            this.workshopPerson = workshopPerson;
            FillInputs();
        }

        private void FillInputs()
        {
            if (workshopPerson is OnlineWorkshopPerson)
            {
                tbxLoginCode.Enabled = true;
                tbxSeatNr.Enabled = false;
                tbxLoginCode.Text = (workshopPerson as OnlineWorkshopPerson).LoginCode;
            }
            else
            {
                tbxLoginCode.Enabled = false;
                tbxSeatNr.Enabled = true;
                tbxSeatNr.Text = (workshopPerson as OnsiteWorkshopPerson).SeatNr.ToString();
            }
        }
    }
}
