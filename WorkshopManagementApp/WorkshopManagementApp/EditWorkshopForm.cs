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
    public partial class EditWorkshopForm : Form
    {
        private MainForm mainForm;
        private OrganisationControl organisation;
        private Workshop selectedWorkshop;
        public EditWorkshopForm(MainForm mainForm, Workshop selectedWorkshop)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.organisation = mainForm.Organisation;
            this.selectedWorkshop = selectedWorkshop;
            FillInputs();
            UpdateLbxPeople(organisation.PersonManager.GetAllPeople());
        }


        private void UpdateLbxPeople(List<Person> people)
        {
            lbxPeople.Items.Clear();
            foreach (Person p in people)
            {
                lbxPeople.Items.Add(p);
            }
        }

        private void FillInputs()
        {
            tbxId.Text = selectedWorkshop.Id.ToString();
            tbxTitle.Text = selectedWorkshop.Title;
            tbxCapacity.Text = selectedWorkshop.Capacity.ToString();
            tbxShortDescription.Text = selectedWorkshop.ShortDescription;

            if (selectedWorkshop is OnsiteWorkshop)
            {
                tbxAddress.Enabled = true;
                tbxRoomNum.Enabled = true;
                tbxUrl.Enabled = false;

                tbxAddress.Text = ((OnsiteWorkshop) selectedWorkshop).Address;
                tbxRoomNum.Text = ((OnsiteWorkshop) selectedWorkshop).RoomNumber;
                tbxWorkshopType.Text = "Onsite";
            }
            else
            {
                tbxAddress.Enabled = false;
                tbxRoomNum.Enabled = false;
                tbxUrl.Enabled = true;

                tbxUrl.Text = ((OnlineWorkshop) selectedWorkshop).Url;
                tbxWorkshopType.Text = "Online";
            }
        }

        private bool CheckInputs()
        {
            bool isWorkshopSpecificInputsFilled;
            if (selectedWorkshop is OnsiteWorkshop)
            {
                isWorkshopSpecificInputsFilled = !String.IsNullOrEmpty(tbxAddress.Text) &&
                                                 !String.IsNullOrEmpty(tbxRoomNum.Text);
            }
            else
            {
                isWorkshopSpecificInputsFilled = !String.IsNullOrEmpty(tbxUrl.Text);
            }

            bool isInputFilled = !String.IsNullOrEmpty(tbxTitle.Text) &&
                                 !String.IsNullOrEmpty(tbxShortDescription.Text) &&
                                 !String.IsNullOrEmpty(tbxCapacity.Text) &&
                                 isWorkshopSpecificInputsFilled;
            return isInputFilled;
        }

        private void btnEditWorkshop_Click(object sender, EventArgs e)
        {
            if (CheckInputs())
            {
                try
                {
                    Workshop newWorkshop;
                    if (selectedWorkshop is OnsiteWorkshop)
                    {
                        newWorkshop = new OnsiteWorkshop(Convert.ToInt32(tbxId.Text),
                            tbxTitle.Text, tbxShortDescription.Text, Convert.ToInt32(tbxCapacity.Text),
                            tbxAddress.Text, tbxRoomNum.Text);
                    }
                    else
                    {
                        newWorkshop = new OnlineWorkshop(Convert.ToInt32(tbxId.Text),
                            tbxTitle.Text, tbxShortDescription.Text, Convert.ToInt32(tbxCapacity.Text),
                            tbxUrl.Text);
                    }

                    if (organisation.WorkshopManager.UpdateWorkshop(newWorkshop))
                    {
                        MessageBox.Show("You have successfully applied the new changes for this workshop!");
                        mainForm.AvailableWorkshops.UpdateLbxWorkshops();
                    }
                    else
                    {
                        MessageBox.Show($"Workshop with such id: {newWorkshop.Id} doesn't exist!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Please, fill all the possible text boxes to apply changes!");
            }
        }

        private void EditWorkshopForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.UpdateManageWorkshops();
        }

        private void UpdateLbxParticipants()
        {
            lbxParticipants.Items.Clear();
            foreach (Person p in organisation.WorkshopPersonManager.GetPeopleAssignToWorkshop(selectedWorkshop))
            {
                lbxParticipants.Items.Add(p);
            }
        }

        private void btnAssignAsTeacher_Click(object sender, EventArgs e)
        {
            if (lbxPeople.SelectedIndex != -1)
            {
                Person selectedPerson = (Person)lbxPeople.SelectedItem;
                if(selectedPerson is Teacher)
                {
                    if (selectedWorkshop.Teacher == null)
                    {
                        if (organisation.WorkshopPersonManager.AssignPersonToWorkshop(-1, selectedWorkshop, selectedPerson))
                        {
                            MessageBox.Show($"You have successfully assigned person with pcn: {selectedPerson.Pcn} to this workshop!");
                        }
                        else
                        {
                            MessageBox.Show($"This person is already participant of the workshop!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("The workshop has already teacher");
                    }
                }
                else
                {
                    MessageBox.Show("This person is not a teacher. So can't be assigned as teacher of the workshop!");
                }
            }
            else
            {
                MessageBox.Show("Please, select person to assign it to workshop!");
            }
        }

        private void btnAssignAsStudent_Click(object sender, EventArgs e)
        {
            if (lbxPeople.SelectedIndex != -1)
            {
                Person selectedPerson = (Person)lbxPeople.SelectedItem;
                //TODO: decide if teacher can attend workshop as student
                if (selectedPerson is Student)
                {
                    if (organisation.WorkshopPersonManager.AssignPersonToWorkshop(-1, selectedWorkshop, selectedPerson))
                    {
                        MessageBox.Show($"You have successfully assigned person with pcn: {selectedPerson.Pcn} to this workshop!");
                    }
                    else
                    {
                        if (organisation.WorkshopPersonManager.GetNrOfParticipantsPerWorkshop(selectedWorkshop) ==
                            selectedWorkshop.Capacity)
                        {
                            MessageBox.Show($"The participants' limit for this workshop is reached!");
                        }
                        else
                        {
                            MessageBox.Show($"This person is already participant of the workshop!");
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("This person is not a student. So can't be assigned as student to the workshop!");
                }
            }
            else
            {
                MessageBox.Show("Please, select person to assign it to workshop!");
            }
        }


        private void btnRemoveParticipant_Click(object sender, EventArgs e)
        {
            if (lbxParticipants.SelectedIndex != -1)
            {
                Person selectedPerson = (Person) lbxParticipants.SelectedItem;
                if(organisation.WorkshopPersonManager.RemoveWorkshopParticipant(selectedWorkshop, selectedPerson))
                {
                    MessageBox.Show($"You have successfully removed participant with PCN:{selectedPerson.Pcn} from the workshop!");
                    UpdateLbxParticipants();
                }
                else
                {
                    MessageBox.Show("This participant is already not part of the workshop!");
                }
            }
            else
            {
                MessageBox.Show("Please, select participant to remove it from the workshops!");
            }
        }

        private void btnViewEnrollmentDetails_Click(object sender, EventArgs e)
        {
            if (lbxParticipants.SelectedIndex != -1)
            {
                Person selectedPerson = (Person) lbxParticipants.SelectedItem;
                WorkshopPerson currWorkshopPerson = organisation.WorkshopPersonManager.
                    GetWorkshopPerson(selectedWorkshop, selectedPerson);
                ParticipantEnrollmentDetailsForm participantEnrollmentDetailsForm =
                    new ParticipantEnrollmentDetailsForm(currWorkshopPerson);
                participantEnrollmentDetailsForm.Show();

            }
            else
            {
                MessageBox.Show("Please, select participant to view its enrollment details for this workshop!");
            }
        }

        private void tabControlWorkshopMenu_Selected(object sender, TabControlEventArgs e)
        {
            if(tabControlWorkshopMenu.SelectedTab.Name == "tabPageAssignPeople")
            {
                UpdateLbxPeople(organisation.PersonManager.GetAllPeople());
            }
            else if (tabControlWorkshopMenu.SelectedTab.Name == "tabPageManageParticipants")
            {
                UpdateLbxParticipants();
            }
        }

       
    }
}
