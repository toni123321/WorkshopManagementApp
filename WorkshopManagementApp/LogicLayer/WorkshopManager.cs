using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer;
using Models;

namespace LogicLayer
{
    public class WorkshopManager
    {
        private List<Workshop> workshops;
        private IStorageAccess storage;

        public WorkshopManager()
        {
            this.workshops = new List<Workshop>();
            this.storage = new WorkshopDbManager(
                "Server=localhost;Uid=root;Database=workshop_management;Pwd=");
            LoadDataFromStorage();
        }

        public void LoadDataFromStorage()
        {
            workshops = storage.ReadAll() as List<Workshop>;
        }

        public bool AddWorkshop(Workshop workshop)
        {
            if (GetWorkshop(workshop.Id) != null)
            {
                return false;
            }
            storage.Create(workshop);
            LoadDataFromStorage();
            //workshops.Add(workshop);
            return true;
        }

        public bool RemoveWorkshop(int id)
        {
            if (GetWorkshop(id) != null)
            {
                Workshop currWorkshop = GetWorkshop(id);
                storage.Delete(id);
                LoadDataFromStorage();
                //workshops.Remove(currWorkshop);
                return true;
            }

            return false;
        }

        public bool UpdateWorkshop(Workshop workshop)
        {
            //Workshop currWorkshop;
            if (GetWorkshop(workshop.Id) != null)
            {
                /*currWorkshop = GetWorkshop(workshop.Id);
                int index = workshops.IndexOf(currWorkshop);
                workshops.Remove(currWorkshop);
                workshops.Insert(index, workshop);*/
                storage.Update(workshop);
                LoadDataFromStorage();
                return true;
            }

            return false;
        }

        public Workshop GetWorkshop(int id)
        {
            foreach (Workshop w in workshops)
            {
                if(w.Id == id)
                {
                    return w;
                }
            }
            return null;
        }

        public List<Workshop> GetAllWorkshops()
        {
            return this.workshops;
        }

        
        private List<Workshop> GetSpecificWorkshops(string filter)
        {
            List<Workshop> specificWorkshops = new List<Workshop>();
            foreach (Workshop w in this.workshops)
            {
                if ((filter == "started" && w.IsStarted) || 
                    (filter == "available" && w.IsAvailable) ||
                    (filter == "past" && !w.IsAvailable) ||
                    (filter == "onsite" && w is OnsiteWorkshop) || 
                    (filter == "online" && w is OnlineWorkshop))

                {
                    specificWorkshops.Add(w);
                }
            }
            return specificWorkshops;
        }

        public List<Workshop> GetStartedWorkshops()
        {
            return GetSpecificWorkshops("started");
        }

        public List<Workshop> GetAvailableWorkshops()
        {
            return GetSpecificWorkshops("available");
        }

        public List<Workshop> GetPastWorkshops()
        {
            return GetSpecificWorkshops("past");
        }

        public List<Workshop> GetOnsiteWorkshops()
        {
            return GetSpecificWorkshops("onsite");
        }

        public List<Workshop> GetOnlineWorkshops()
        {
            return GetSpecificWorkshops("online");
        }

        public void GeneratePrintableFileForAvailableWorkshops(string filename)
        {

        }
    }
}
