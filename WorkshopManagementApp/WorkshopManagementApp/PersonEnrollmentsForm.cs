using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayer;
using Models;

namespace WorkshopManagementApp
{
    public partial class PersonEnrollmentsForm : Form
    {
        private OrganisationControl organisation;
        private MainForm mainForm;
        private Person selectedPerson;
        public PersonEnrollmentsForm(MainForm mainForm, Person selectedPerson)
        {
            InitializeComponent();
            this.organisation = mainForm.Organisation;
            this.selectedPerson = selectedPerson;
            UpdateLbxPersonEnrollments();
        }

        public void UpdateLbxPersonEnrollments()
        {
            lbxPersonEnrollments.Items.Clear();
            foreach (WorkshopPerson wp in 
                organisation.WorkshopPersonManager.GetPersonEnrollments(selectedPerson))
            {
                lbxPersonEnrollments.Items.Add(wp);
            }
        }
    }
}
