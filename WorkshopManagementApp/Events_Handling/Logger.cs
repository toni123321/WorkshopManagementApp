using System;
using System.Collections.Generic;
using System.Text;
using LogicLayer;
using Models;
using WorkshopManagementApp;

namespace Events_Handling
{
    public class Logger
    {
        public AvailableWorkshopsForm AvailableWorkshopsForm
        {
            get;
            set;
        }

        public OrganisationControl Organisation
        {
            get;
            set;
        }

        public Logger(AvailableWorkshopsForm availableWorkshopsForm, OrganisationControl organisation)
        {
            AvailableWorkshopsForm = availableWorkshopsForm;
            Organisation = organisation;
        }

        public void StartLogging()
        {
            //subscribe
            foreach (Workshop w in Organisation.WorkshopManager.GetAllWorkshops())
            {
                w.ExceedAlmostFullCapacity += new Workshop.CapacityHandle(AvailableWorkshopsForm.ShowWorkshopCapacityWarning);
            }
        }

        public void StopLogging()
        {
            // unsubscribe 
            foreach (Workshop w in Organisation.WorkshopManager.GetAllWorkshops())
            {
                w.ExceedAlmostFullCapacity -= new Workshop.CapacityHandle(AvailableWorkshopsForm.ShowWorkshopCapacityWarning);
            }
        }
        
    }
}
