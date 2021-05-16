using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLayer;
using LogicLayer;
using Models;

namespace UnitTesting
{
    [TestClass]
    public class WorkshopManageTesting
    {

        [TestMethod]
        public void CheckLoadFromStorage()
        {
            WorkshopManager workshopManager = new WorkshopManager();

            IStorage storage = new WorkshopDbManager("Server=localhost;Uid=root;Database=workshop_management;Pwd=");

            List<Workshop> workshopsInStorageBeforeUpdate = storage.ReadAll() as List<Workshop>;
            Workshop currWorkshop = workshopsInStorageBeforeUpdate[workshopsInStorageBeforeUpdate.Count - 1];
            currWorkshop.Title = "Here";
            storage.Update(currWorkshop);
            workshopManager.LoadDataFromStorage();
            List<Workshop> workshopsInStorageAfterUpdate = storage.ReadAll() as List<Workshop>;

            CollectionAssert.Equals(workshopsInStorageAfterUpdate, workshopManager.GetAllWorkshops());
        }

        [TestMethod]
        public void AddOnsiteWorkshop()
        {
            Workshop newWorkshop =
                new OnsiteWorkshop("Scrum", "Here it is", 10,
                    "Sofia, Bulgaria 25 Bulgaria Bul.", "24B");
            WorkshopManager workshopManager = new WorkshopManager();
            Assert.AreEqual(true, workshopManager.AddWorkshop(newWorkshop));

            Workshop existingWorkshop = workshopManager.GetOnsiteWorkshops()[0]; ;
            Assert.AreEqual(false, workshopManager.AddWorkshop(existingWorkshop));
        }

        [TestMethod]
        public void AddOnsiteWorkshopUsingConstructorForStorage()
        {
            Workshop workshop =
                new OnsiteWorkshop("141312", "A random topic", "Here it is", 10,
                    0, true, false, null,
                    "Sofia, Bulgaria 25 Bulgaria Bul.", "24B");
            WorkshopManager workshopManager = new WorkshopManager();
            Assert.AreEqual(true, workshopManager.AddWorkshop(workshop));
        }

        [TestMethod]
        public void AddOnlineWorkshop()
        {
            Workshop newWorkshop =
                new OnlineWorkshop("GIT", "snkldn", 50,
                    "workshop.com");
            WorkshopManager workshopManager = new WorkshopManager();
            Assert.AreEqual(true, workshopManager.AddWorkshop(newWorkshop));

            Workshop existingWorkshop = workshopManager.GetOnlineWorkshops()[0];
            Assert.AreEqual(false, workshopManager.AddWorkshop(existingWorkshop));

        }

        [TestMethod]
        public void AddOnlineWorkshopUsingConstructorForStorage()
        {
            Workshop workshop =
                new OnlineWorkshop("151515", "Scrum", "Here it is", 10,
                    0, true, false, null, "echo.bg");
            WorkshopManager workshopManager = new WorkshopManager();
            Assert.AreEqual(true, workshopManager.AddWorkshop(workshop));
        }

        [TestMethod]
        public void RemoveWorkshop()
        {
            WorkshopManager workshopManager = new WorkshopManager();
            Workshop currWorkshop = workshopManager.GetWorkshop("151515");
            Assert.AreEqual(true, workshopManager.RemoveWorkshop(currWorkshop.Id));
            Assert.AreEqual(false, workshopManager.RemoveWorkshop("000000"));
        }

        [TestMethod]
        public void UpdateWorkshop()
        {
            WorkshopManager workshopManager = new WorkshopManager();
            Workshop currWorkshop = workshopManager.GetWorkshop("141312");
            currWorkshop.Title = "GIT";
            workshopManager.UpdateWorkshop(currWorkshop);
            Assert.AreEqual(currWorkshop.Title, workshopManager.GetWorkshop(currWorkshop.Id).Title);
            workshopManager.RemoveWorkshop(currWorkshop.Id);
            currWorkshop.Title = "Smth";
            Assert.AreEqual(false, workshopManager.UpdateWorkshop(currWorkshop));
        }

        [TestMethod]
        public void GetAvailableWorkshops()
        {
            WorkshopManager workshopManager = new WorkshopManager();
            // Trying LINQ in C#
            List<Workshop> availableWorkshops = workshopManager.GetAllWorkshops().
                Where(w => w.IsAvailable && !w.IsStarted).ToList();
            CollectionAssert.Equals(availableWorkshops, workshopManager.GetAvailableWorkshops());
        }

        [TestMethod]
        public void GetStartedWorkshops()
        {
            WorkshopManager workshopManager = new WorkshopManager();
            // Trying LINQ in C#
            List<Workshop> startedWorkshops = workshopManager.GetStartedWorkshops().
                Where(w => !w.IsAvailable && w.IsStarted).ToList();
            CollectionAssert.Equals(startedWorkshops, workshopManager.GetStartedWorkshops());
        }

        [TestMethod]
        public void GetPastWorkshops()
        {
            WorkshopManager workshopManager = new WorkshopManager();
            // Trying LINQ in C#
            List<Workshop> pastWorkshops = workshopManager.GetPastWorkshops().
                Where(w => !w.IsAvailable && !w.IsStarted).ToList();
            CollectionAssert.Equals(pastWorkshops, workshopManager.GetPastWorkshops());
        }

        [TestMethod]
        public void GetOnsiteWorkshops()
        {
            WorkshopManager workshopManager = new WorkshopManager();
            // Trying LINQ in C#
            List<Workshop> onsiteWorkshops = workshopManager.GetOnsiteWorkshops().
                Where(w => w is OnsiteWorkshop).ToList();
            CollectionAssert.Equals(onsiteWorkshops, workshopManager.GetOnsiteWorkshops());
        }

        [TestMethod]
        public void GetOnlineWorkshops()
        {
            WorkshopManager workshopManager = new WorkshopManager();
            // Trying LINQ in C#
            List<Workshop> onlineWorkshops = workshopManager.GetOnlineWorkshops().
                Where(w => w is OnlineWorkshop).ToList();
            CollectionAssert.Equals(onlineWorkshops, workshopManager.GetOnlineWorkshops());
        }

    }
}
