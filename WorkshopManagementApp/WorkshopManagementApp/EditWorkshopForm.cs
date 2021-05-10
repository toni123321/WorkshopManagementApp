using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomExceptions;
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
            ManageAccess();
        }

        private void ManageAccess()
        {
            if (!selectedWorkshop.IsAvailable)
            {
                tbxTitle.ReadOnly = true;
                tbxCapacity.ReadOnly = true;
                tbxShortDescription.ReadOnly = true;

                if (selectedWorkshop is OnsiteWorkshop)
                {
                    tbxAddress.ReadOnly = true;
                    tbxRoomNum.ReadOnly = true;
                }
                else
                {
                    tbxUrl.ReadOnly = true;
                }

                btnEditWorkshop.Enabled = false;
                btnAssignAsTeacher.Enabled = false;
                btnAssignAsStudent.Enabled = false;
                btnRemoveParticipant.Enabled = false;

            }
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
                            selectedWorkshop.NrOfParticipants, selectedWorkshop.IsAvailable,
                            selectedWorkshop.IsStarted,
                            selectedWorkshop.Teacher, tbxAddress.Text, tbxRoomNum.Text);
                    }
                    else
                    {
                        newWorkshop = new OnlineWorkshop(Convert.ToInt32(tbxId.Text),
                            tbxTitle.Text, tbxShortDescription.Text, Convert.ToInt32(tbxCapacity.Text),
                            selectedWorkshop.NrOfParticipants, selectedWorkshop.IsAvailable, selectedWorkshop.IsStarted,
                            selectedWorkshop.Teacher, tbxUrl.Text);
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
                catch (InputFieldException ex)
                {
                    MessageBox.Show(ex.Message);
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

        private void UpdateLbxParticipants(List<Person> people)
        {
            lbxParticipants.Items.Clear();
            foreach (Person p in people)
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
                            MessageBox.Show($"You have successfully assigned person with pcn: {selectedPerson.Pcn} as a teacher of this workshop!");
                        }
                        else
                        {
                            MessageBox.Show($"This person is a participant in the workshop! Can't be both participant and teacher!");
                            
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
                
                
                if (organisation.WorkshopPersonManager.AssignPersonToWorkshop(-1, selectedWorkshop, selectedPerson))
                {
                    MessageBox.Show($"You have successfully assigned person with pcn: {selectedPerson.Pcn} to this workshop!");
                }
                else
                {
                    if (selectedWorkshop.Teacher.Pcn == selectedPerson.Pcn)
                    {
                        MessageBox.Show($"This person is already the teacher of this workshop!");
                    }
                    else if (organisation.WorkshopPersonManager.GetNrOfParticipantsPerWorkshop(selectedWorkshop) ==
                        selectedWorkshop.Capacity)
                    {
                        MessageBox.Show($"The participants' limit for this workshop is reached!");
                    }
                    else
                    {
                       MessageBox.Show($"This person is already participant in the workshop!");
                    }
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
                    UpdateLbxParticipants(organisation.WorkshopPersonManager.GetPeopleAssignToWorkshop(selectedWorkshop));
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

        private void UpdateSelectedWorkshop()
        {
            selectedWorkshop = organisation.WorkshopManager.GetWorkshop(selectedWorkshop.Id);
        }

        private void tabControlWorkshopMenu_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControlWorkshopMenu.SelectedTab.Name == "tabPageEditWorkshop")
            {
                FillInputs();
            }
            else if(tabControlWorkshopMenu.SelectedTab.Name == "tabPageAssignPeople")
            {
                cbFilterPeople.SelectedIndex = 0;
                UpdateLbxPeople(organisation.PersonManager.GetAllPeople());
            }
            else if (tabControlWorkshopMenu.SelectedTab.Name == "tabPageManageParticipants")
            {
                cbFilterParticipants.SelectedIndex = 0;
                UpdateLbxParticipants(organisation.WorkshopPersonManager.GetPeopleAssignToWorkshop(selectedWorkshop));
            }

            UpdateSelectedWorkshop();
        }

        public void ManageSelectedTab()
        {
            tabControlWorkshopMenu.SelectedIndex = 1;
            cbFilterPeople.SelectedIndex = 0;
            UpdateLbxPeople(organisation.PersonManager.GetAllPeople());
        }

        private void cbFilterPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterPeople.SelectedItem.ToString() == "All")
            {
                UpdateLbxPeople(organisation.PersonManager.GetAllPeople());
            }
            else if (cbFilterPeople.SelectedItem.ToString() == "Student")
            {
                UpdateLbxPeople(organisation.PersonManager.GetStudents());
            }
            else
            {
                UpdateLbxPeople(organisation.PersonManager.GetTeachers());
            }
        }

        private void cbFilterParticipants_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterParticipants.SelectedItem.ToString() == "All")
            {
                UpdateLbxParticipants(organisation.WorkshopPersonManager.GetPeopleAssignToWorkshop(selectedWorkshop));
            }
            else if (cbFilterParticipants.SelectedItem.ToString() == "Teacher")
            {
                lbxParticipants.Items.Clear();
                if (selectedWorkshop.Teacher == null)
                {
                    lbxParticipants.Items.Add("Not selected");
                }
                else
                {
                    lbxParticipants.Items.Add(selectedWorkshop.Teacher);
                }
            }
            else
            {
                UpdateLbxParticipants(organisation.WorkshopPersonManager.GetOnlyParticipants(selectedWorkshop));
            }
        }
    }
}
