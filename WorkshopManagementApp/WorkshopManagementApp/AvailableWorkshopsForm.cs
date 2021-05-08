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
    public partial class AvailableWorkshopsForm : Form
    {
        private OrganisationControl organisation;
        public AvailableWorkshopsForm(OrganisationControl organisation)
        {
            InitializeComponent();
            this.organisation = organisation;
            UpdateLbxWorkshops();
            /*StartLogging();*/
        }

        public void UpdateLbxWorkshops()
        {
            lbxWorkshops.Items.Clear();
            foreach (Workshop w in organisation.WorkshopManager.GetAvailableWorkshops())
            {
                lbxWorkshops.Items.Add(w);
            }
            StartLogging();
        }
        public void StartLogging()
        {
            //subscribe
            foreach (Workshop w in organisation.WorkshopManager.GetAvailableWorkshops())
            {
                w.ExceedAlmostFullCapacity += new Workshop.CapacityHandle(this.ShowWorkshopCapacityWarning);
            }
        }

        public void StopLogging()
        {
            // unsubscribe 
            foreach (Workshop w in organisation.WorkshopManager.GetAvailableWorkshops())
            {
                w.ExceedAlmostFullCapacity -= new Workshop.CapacityHandle(this.ShowWorkshopCapacityWarning);
            }
        }
        public void ShowWorkshopCapacityWarning(string message)
        {
            lbxWarnings.Items.Add(message);
        }

        private void AvailableWorkshopsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            StopLogging();
        }
    }
}
