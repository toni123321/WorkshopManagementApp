using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using LogicLayer;
using Models;

namespace UnitTesting
{
    [TestClass]
    public class WorkshopPersonManagerTesting
    {
        [TestMethod]
        public void AssignTeacherToWorkshop()
        {
            WorkshopPersonManager workshopPersonManager = new WorkshopPersonManager();
            WorkshopManager workshopManager = new WorkshopManager();
            PersonManager personManager = new PersonManager();
            Workshop onsiteWorkshop = workshopManager.GetOnsiteWorkshops()[0];
            Workshop onlineWorkshop = workshopManager.GetOnlineWorkshops()[0];
            Person person = personManager.GetTeachers()[0];


            Assert.AreEqual(true, workshopPersonManager.AssignTeacherToWorkshop(onlineWorkshop, person));

            Assert.AreEqual(true, workshopPersonManager.AssignTeacherToWorkshop(onsiteWorkshop, person));
            Assert.AreEqual(false, workshopPersonManager.AssignTeacherToWorkshop(onsiteWorkshop, person));
        }

        [TestMethod]
        public void AssignParticipantToWorkshop()
        {
            WorkshopPersonManager workshopPersonManager = new WorkshopPersonManager();
            WorkshopManager workshopManager = new WorkshopManager();
            PersonManager personManager = new PersonManager();
            Workshop onsiteWorkshop = workshopManager.GetOnsiteWorkshops()[0];
            Workshop onlineWorkshop = workshopManager.GetOnlineWorkshops()[0];
            Person person = personManager.GetStudents()[0];

            Assert.AreEqual(true, workshopPersonManager.AssignParticipantToWorkshop(onsiteWorkshop, person));

            Assert.AreEqual(true, workshopPersonManager.AssignParticipantToWorkshop(onlineWorkshop, person));
            Assert.AreEqual(false, workshopPersonManager.AssignParticipantToWorkshop(onlineWorkshop, person));
        }

        [TestMethod]
        public void GetPeopleAssignToWorkshop()
        {
            WorkshopPersonManager workshopPersonManager = new WorkshopPersonManager();
            List<WorkshopPerson> workshopPeople = workshopPersonManager.WorkshopPeople;
            WorkshopManager workshopManager = new WorkshopManager();
            PersonManager personManager = new PersonManager();
            Workshop workshop = workshopManager.GetAllWorkshops()[0];
            Person person = personManager.GetStudents()[1];
            List<Person> peopleAssignToCurrWorkshop = workshopPersonManager.GetPeopleAssignToWorkshop(workshop);
            List<Person> participantsAssignToCurrWorkshop = workshopPersonManager.GetOnlyParticipants(workshop);

            workshopPersonManager.AssignParticipantToWorkshop(workshop, person);
            peopleAssignToCurrWorkshop.Add(person);
            participantsAssignToCurrWorkshop.Add(person);

            CollectionAssert.Equals(participantsAssignToCurrWorkshop, workshopPersonManager.GetOnlyParticipants(workshop));
            CollectionAssert.Equals(peopleAssignToCurrWorkshop, workshopPersonManager.GetPeopleAssignToWorkshop(workshop));
        }

        [TestMethod]
        public void GetWorkshopPerson()
        {
            WorkshopPersonManager workshopPersonManager = new WorkshopPersonManager();
            Workshop w = workshopPersonManager.WorkshopPeople[0].Workshop;
            Person p = workshopPersonManager.WorkshopPeople[0].Person;
            Assert.AreEqual(workshopPersonManager.WorkshopPeople[0], workshopPersonManager.GetWorkshopPerson(w, p));
        }

        [TestMethod]
        public void RemovePersonAssignToWorkshop()
        {
            WorkshopPersonManager workshopPersonManager = new WorkshopPersonManager();
            Workshop w = workshopPersonManager.WorkshopPeople[0].Workshop;
            Person p = workshopPersonManager.WorkshopPeople[0].Person;
            Assert.AreEqual(true, workshopPersonManager.RemovePersonAssignToWorkshop(w, p));
            Assert.AreEqual(false, workshopPersonManager.RemovePersonAssignToWorkshop(w, p));
            PersonManager personManager = new PersonManager();
            Person teacher = personManager.GetTeachers()[0];
            workshopPersonManager.AssignParticipantToWorkshop(w, teacher);
            Assert.AreEqual(true, workshopPersonManager.RemovePersonAssignToWorkshop(w, teacher));
        }

        [TestMethod]
        public void GetPersonEnrollments()
        {
            WorkshopPersonManager workshopPersonManager = new WorkshopPersonManager();
            Workshop w = workshopPersonManager.WorkshopPeople[0].Workshop;
            Person p = workshopPersonManager.WorkshopPeople[0].Person;
            List<WorkshopPerson> enrollments = workshopPersonManager.GetPersonEnrollments(p);
            workshopPersonManager.RemovePersonAssignToWorkshop(w, p);
            WorkshopPerson enrollmentToRemove = enrollments.Find(wp => wp.Workshop.Id == w.Id);
            enrollments.Remove(enrollmentToRemove);
            CollectionAssert.Equals(enrollments, workshopPersonManager.GetPersonEnrollments(p));

        }
    }
}
