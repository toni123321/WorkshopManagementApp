using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using CustomExceptions;
using DataAccessLayer;
using LogicLayer;
using Models;

namespace UnitTesting
{
    [TestClass]
    public class WorkshopUnitTesting
    {
        [TestMethod]
        [ExpectedException(typeof(InputFieldException))]
        public void CreateOnsiteWorkshop()
        {
            Workshop workshop =
                new OnsiteWorkshop("Scrum", "Here it is", 10,
                    "Sofia, Bulgaria 25 Bulgaria", "24B");
            workshop.Title = "m ";
            workshop.ShortDescription = "aaaa";
            workshop.Capacity = 0;
            (workshop as OnsiteWorkshop).Address = "Klc";
            (workshop as OnsiteWorkshop).RoomNumber = "23AAA";
            /*Workshop workshop2 =
                new OnsiteWorkshop(14, "Scrum", "Here it is", 0,
                    0, true, false, null,
                    "Sofia, Bulgaria 25 Bulgaria Bul.", "24B");*/

        }

        [TestMethod]
        public void AddOnsiteWorkshop()
        {
            Workshop workshop = 
                new OnsiteWorkshop("Scrum", "Here it is", 10, 
                    "Sofia, Bulgaria 25 Bulgaria Bul.", "24B");
            WorkshopManager workshopManager = new WorkshopManager();
            Assert.AreEqual(true, workshopManager.AddWorkshop(workshop));
        }

        /*[TestMethod]
        public void AddOnsiteWorkshopUsingConstructorForStorage()
        {
            Workshop workshop =
                new OnsiteWorkshop(14, "Scrum", "Here it is", 10, 
                    0, true, false, null,
                    "Sofia, Bulgaria 25 Bulgaria Bul.", "24B");
            WorkshopManager workshopManager = new WorkshopManager();
            Assert.AreEqual(false, workshopManager.AddWorkshop(workshop));
        }*/

        [TestMethod]
        [ExpectedException(typeof(InputFieldException))]
        public void CreateOnlineWorkshop()
        {
            Workshop workshop =
                new OnlineWorkshop("Scrum", "Here it is", 0,
                    "here");
        }

        [TestMethod]
        public void CheckLoadFromStorage()
        {
            
            IStorage storage = new WorkshopDbManager("Server=localhost;Uid=root;Database=workshop_management;Pwd=");
            
            List<Workshop> workshopsInStorage = storage.ReadAll() as List<Workshop>;
            WorkshopManager workshopManager = new WorkshopManager();
            CollectionAssert.Equals(workshopsInStorage, workshopManager.GetAllWorkshops());
        }


        





    }
}
