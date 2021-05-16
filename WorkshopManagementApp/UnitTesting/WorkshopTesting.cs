using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomExceptions;
using LogicLayer;
using Models;

namespace UnitTesting
{
    [TestClass]
    public class WorkshopTesting
    {

        [TestMethod]
        [ExpectedException(typeof(InputFieldException))]
        public void SetId()
        {
            WorkshopManager workshopManager = new WorkshopManager();
            Workshop workshop = workshopManager.GetOnsiteWorkshops()[0];

            workshop.Id = "-00000";
        }

        [TestMethod]
        [ExpectedException(typeof(InputFieldException))]
        public void SetCapacity()
        {
            WorkshopManager workshopManager = new WorkshopManager();
            Workshop workshop = workshopManager.GetOnsiteWorkshops()[0];

            workshop.Capacity = 0;
        }

        [TestMethod]
        [ExpectedException(typeof(InputFieldException))]
        public void SetTitle()
        {
            WorkshopManager workshopManager = new WorkshopManager();
            Workshop workshop = workshopManager.GetOnsiteWorkshops()[0];

            workshop.Title = "----";
        }

        [TestMethod]
        [ExpectedException(typeof(InputFieldException))]
        public void SetDescription()
        {
            WorkshopManager workshopManager = new WorkshopManager();
            Workshop workshop = workshopManager.GetAllWorkshops()[0];
            workshop.ShortDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text" +
                                        "Contrary to popular belief, Lorem Ipsum is not simply random text" +
                                        "Contrary to popular belief, Lorem Ipsum is not simply random text" +
                                        "Contrary to popular belief, Lorem Ipsum is not simply random text" +
                                        "Contrary to popular belief, Lorem Ipsum is not simply random text" +
                                        "Contrary to popular belief, Lorem Ipsum is not simply random text";
        }


        [TestMethod]
        [ExpectedException(typeof(InputFieldException))]
        public void SetAddress()
        {
            WorkshopManager workshopManager = new WorkshopManager();
            Workshop workshop = workshopManager.GetOnsiteWorkshops()[0];

            (workshop as OnsiteWorkshop).Address = "ee";
        }

        [TestMethod]
        [ExpectedException(typeof(InputFieldException))]
        public void SetRoomNr()
        {
            WorkshopManager workshopManager = new WorkshopManager();
            Workshop workshop = workshopManager.GetOnsiteWorkshops()[0];

            (workshop as OnsiteWorkshop).RoomNumber = "AA";
        }

        [TestMethod]
        [ExpectedException(typeof(InputFieldException))]
        public void SetUrl()
        {
            WorkshopManager workshopManager = new WorkshopManager();
            Workshop workshop = workshopManager.GetOnlineWorkshops()[0];
            (workshop as OnlineWorkshop).Url = "ss";
        }
    }
}
