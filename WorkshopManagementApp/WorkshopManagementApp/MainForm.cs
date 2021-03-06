using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using CustomExceptions;
using LogicLayer;
using Models;

namespace WorkshopManagementApp
{
    public partial class MainForm : Form
    {
        public OrganisationControl Organisation
        {
            set;
            get;
        }

        public AvailableWorkshopsForm AvailableWorkshops
        {
            set;
            get;
        }

        public MainForm()
        {
            InitializeComponent();
            this.Organisation = new OrganisationControl("Fontys");
            HideCreateWorkshopWindow();
            AvailableWorkshops = new AvailableWorkshopsForm(this.Organisation);
            AvailableWorkshops.Show();
        }
        

        // ----------- Workshop ---------------------------------
        public void UpdateLbxWorkshops(List<Workshop> workshops)
        {
            lbxWorkshops.Items.Clear();
            foreach (Workshop w in workshops)
            {
                lbxWorkshops.Items.Add(w);
            }
        }

        private void HideCreateWorkshopWindow()
        {
            cbChooseWorkshop.SelectedIndex = -1;
            cbChooseWorkshop.Text = "Onsite/Online...";
            gbxCreateWorkshop.Hide();
        }

        private void ManageCreateWorkshopWindow()
        {
            if (cbChooseWorkshop.SelectedIndex == -1)
            {
                ClearInputsForCreateWorkshop();
                gbxCreateWorkshop.Hide();
            }
            else if (cbChooseWorkshop.SelectedItem.ToString() == "Onsite")
            {
                tbxAddress.Enabled = true;
                tbxRoomNum.Enabled = true;
                tbxUrl.Enabled = false;
                ClearInputsForCreateWorkshop();
                gbxCreateWorkshop.Show();
            }
            else
            {
                tbxAddress.Enabled = false;
                tbxRoomNum.Enabled = false;
                tbxUrl.Enabled = true;
                ClearInputsForCreateWorkshop();
                gbxCreateWorkshop.Show();
            }
        }

        private void ClearInputsForCreateWorkshop()
        {
            tbxTitle.Clear();
            tbxCapacity.Clear();
            tbxShortDescription.Clear();
            tbxAddress.Clear();
            tbxRoomNum.Clear();
            tbxUrl.Clear();
        }

        private bool CheckWorkshopInputs()
        {
            bool isWorkshopSpecificInputsFilled;
            if (cbChooseWorkshop.SelectedItem.ToString() == "Onsite")
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

        private void cbChooseWorkshop_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManageCreateWorkshopWindow();
        }

        private void btnCreateWorkshop_Click(object sender, EventArgs e)
        {
            if (CheckWorkshopInputs())
            {
                try
                {
                    Workshop newWorkshop;
                    if (cbChooseWorkshop.SelectedItem.ToString() == "Onsite")
                    {
                        newWorkshop = new OnsiteWorkshop(tbxTitle.Text, tbxShortDescription.Text, Convert.ToInt32(tbxCapacity.Text),
                            tbxAddress.Text, tbxRoomNum.Text);
                    }
                    else
                    {
                        newWorkshop = new OnlineWorkshop(tbxTitle.Text, tbxShortDescription.Text, Convert.ToInt32(tbxCapacity.Text),
                            tbxUrl.Text);
                    }

                    Organisation.WorkshopManager.AddWorkshop(newWorkshop);
                    MessageBox.Show("You have successfully created new workshop!");
                    ClearInputsForCreateWorkshop();
                    AvailableWorkshops.UpdateLbxWorkshops();


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
                MessageBox.Show("Please, fill all the text boxes to create workshop!");
            }
        }

        public void UpdateManageWorkshops()
        {
            cbFilterWorkshops.SelectedIndex = 0;
            UpdateLbxWorkshops(Organisation.WorkshopManager.GetAllWorkshops());
        }

        private void tabControlWorkshopMenu_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControlWorkshopMenu.SelectedTab.Name == "tabPageManageWorkshops")
            {
                UpdateManageWorkshops();
            }
            else if (tabControlWorkshopMenu.SelectedTab.Name == "tabPageCreateWorkshop")
            {
                HideCreateWorkshopWindow();
            }
        }


        private void cbFilterWorkshops_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterWorkshops.SelectedItem.ToString() == "All")
            {
                UpdateLbxWorkshops(Organisation.WorkshopManager.GetAllWorkshops());
            }
            else if (cbFilterWorkshops.SelectedItem.ToString() == "Onsite")
            {
                UpdateLbxWorkshops(Organisation.WorkshopManager.GetOnsiteWorkshops());
            }
            else if(cbFilterWorkshops.SelectedItem.ToString() == "Online")
            {
                UpdateLbxWorkshops(Organisation.WorkshopManager.GetOnlineWorkshops());
            }
            else if (cbFilterWorkshops.SelectedItem.ToString() == "Started")
            {
                UpdateLbxWorkshops(Organisation.WorkshopManager.GetStartedWorkshops());
                // TODO: Enable ->false for all buttons
            }
            else if (cbFilterWorkshops.SelectedItem.ToString() == "Available")
            {
                UpdateLbxWorkshops(Organisation.WorkshopManager.GetAvailableWorkshops());
            }
            else
            {
                UpdateLbxWorkshops(Organisation.WorkshopManager.GetPastWorkshops());
                // TODO: Enable ->false for all buttons
            }
        }

        private void btnRemoveWorkshop_Click(object sender, EventArgs e)
        {
            if (lbxWorkshops.SelectedIndex != -1)
            {
                
                Workshop selectedWorkshop = (Workshop) lbxWorkshops.SelectedItem;
                if (!selectedWorkshop.IsStarted)
                {
                    if (Organisation.WorkshopManager.RemoveWorkshop(selectedWorkshop.Id))
                    {
                        MessageBox.Show(
                            $"You have successfully removed workshop with Title: {selectedWorkshop.Title}!");
                        UpdateManageWorkshops();
                        AvailableWorkshops.UpdateLbxWorkshops();
                    }
                    else
                    {
                        MessageBox.Show("The selected workshop is already removed! Please refresh!");
                    }
                }
                else
                {
                    MessageBox.Show("You can't remove this workshop while it hasn't finished yet!");
                }
            }
            else
            {
                MessageBox.Show("Please, select workshop to remove it!");
            }
        }

        private void btnEditWorkshop_Click(object sender, EventArgs e)
        {
            if (lbxWorkshops.SelectedIndex != -1)
            {
                Workshop selectedWorkshop = (Workshop)lbxWorkshops.SelectedItem;
                EditWorkshopForm editWorkshopForm = new EditWorkshopForm(this, selectedWorkshop);
                editWorkshopForm.Show();
            }
            else
            {
                MessageBox.Show("Please, select workshop to edit it or view its details!");
            }
        }
        private void btnAssignPeople_Click(object sender, EventArgs e)
        {
            if (lbxWorkshops.SelectedIndex != -1)
            {
                Workshop selectedWorkshop = (Workshop)lbxWorkshops.SelectedItem;
                if (selectedWorkshop.IsAvailable)
                {
                    EditWorkshopForm editWorkshopForm = new EditWorkshopForm(this, selectedWorkshop);
                    editWorkshopForm.Show();
                    editWorkshopForm.ManageSelectedTab();
                }
                else
                {
                    if(selectedWorkshop.IsStarted)
                    {
                        MessageBox.Show("This workshop has already started! It's not possible to assign people!");
                    }
                    else
                    {
                        MessageBox.Show("This workshop has already finished! It's not possible to assign people!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please, select workshop to assign people to it!");
            }
        }

        private void btnStartWorkshop_Click(object sender, EventArgs e)
        {
            if (lbxWorkshops.SelectedIndex != -1)
            {
                Workshop selectedWorkshop = (Workshop)lbxWorkshops.SelectedItem;
                if (!selectedWorkshop.IsStarted && selectedWorkshop.Teacher != null)
                {
                    if (selectedWorkshop.IsAvailable)
                    {
                        // started - false, available - true 
                        selectedWorkshop.IsStarted = true;
                        selectedWorkshop.IsAvailable = false;
                        Organisation.WorkshopManager.UpdateWorkshop(selectedWorkshop);
                        UpdateManageWorkshops();
                        MessageBox.Show($"Workshop with Title: {selectedWorkshop.Title} is started!");
                    }
                    else
                    {
                        // started - false, available - false
                        MessageBox.Show("This workshop has already finished. It's a past one.");
                    }
                }
                else
                {
                    if (selectedWorkshop.Teacher == null)
                    {
                        MessageBox.Show("Teacher is not selected! Workshop can't start!");
                    }
                    else
                    {
                        MessageBox.Show("This workshop has already started!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please, select workshop to start it!");
            }
        }

        private void btnFinishWorkshop_Click(object sender, EventArgs e)
        {
            if (lbxWorkshops.SelectedIndex != -1)
            {
                Workshop selectedWorkshop = (Workshop)lbxWorkshops.SelectedItem;
                if (selectedWorkshop.IsStarted)
                {
                    selectedWorkshop.IsStarted = false;
                    Organisation.WorkshopManager.UpdateWorkshop(selectedWorkshop);
                    UpdateManageWorkshops();
                    MessageBox.Show($"Workshop with Title: {selectedWorkshop.Title} finished!");
                }
                else
                {
                    if (selectedWorkshop.IsAvailable)
                    {
                        MessageBox.Show("This workshop hasn't started yet!");
                    }
                    else
                    {
                        MessageBox.Show("This workshop has already finished. It's a past one!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please, select workshop to start it!");
            }
        }


        // ----------- Person ---------------------------------

        private void UpdateLbxPeople(List<Person> people)
        {
            lbxPeople.Items.Clear();
            foreach (Person p in people)
            {
                lbxPeople.Items.Add(p);
            }
        }

        private void ClearInputsForCreatePerson()
        {
            tbxPcn.Clear();
            tbxFName.Clear();
            tbxLName.Clear();
            tbxEmail.Clear();
            cbUserType.SelectedIndex = -1;
            cbUserType.Text = "Student/teacher";
        }

        private bool CheckPersonInputs()
        {
            bool isUserTypeSelected = cbUserType.SelectedIndex != -1;
            bool isInputsFilled = !String.IsNullOrEmpty(tbxPcn.Text) &&
                                  !String.IsNullOrEmpty(tbxFName.Text) &&
                                  !String.IsNullOrEmpty(tbxLName.Text) &&
                                  !String.IsNullOrEmpty(tbxEmail.Text) &&
                                  isUserTypeSelected;
            return isInputsFilled;
        }
        private void btnRegisterPerson_Click(object sender, EventArgs e)
        {
            if (CheckPersonInputs())
            {
                try
                {
                    Person newPerson;
                    if (cbUserType.SelectedItem.ToString() == "Teacher")
                    {
                        newPerson = new Teacher(tbxFName.Text, tbxLName.Text, 
                            tbxPcn.Text, tbxEmail.Text, cbUserType.SelectedItem.ToString());
                    }
                    else
                    {
                        newPerson = new Student(tbxFName.Text, tbxLName.Text,
                            tbxPcn.Text, tbxEmail.Text, cbUserType.SelectedItem.ToString());
                    }

                    if (Organisation.PersonManager.AddPerson(newPerson))
                    {

                        MessageBox.Show("You have successfully registered new person!");
                        ClearInputsForCreatePerson();
                    }
                    else
                    {
                        MessageBox.Show($"Person with such Pcn: {newPerson.Pcn} already exists!");
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
                if (cbUserType.Text != "")
                {
                    MessageBox.Show("Please, choose user type from the dropdown instead of writing in the input field!");
                }
                else
                {
                    MessageBox.Show("Please, fill all the boxes to register person to the system!");
                }
            }
        }

        public void UpdateManagePeople()
        {
            cbFilterPeople.SelectedIndex = 0;
            UpdateLbxPeople(Organisation.PersonManager.GetAllPeople());
        }

        private void tabControlPeopleMenu_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControlPeopleMenu.SelectedTab.Name == "tabPageManagePeople")
            {
                UpdateManagePeople();
            }
        }

        private void cbFilterPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilterPeople.SelectedItem.ToString() == "All")
            {
                UpdateLbxPeople(Organisation.PersonManager.GetAllPeople());
            }
            else if(cbFilterPeople.SelectedItem.ToString() == "Student")
            {
                UpdateLbxPeople(Organisation.PersonManager.GetStudents());
            }
            else
            {
                UpdateLbxPeople(Organisation.PersonManager.GetTeachers());
            }
        }

        private void btnRemovePerson_Click(object sender, EventArgs e)
        {
            if (lbxPeople.SelectedIndex != -1)
            {
                Person selectedPerson = (Person)lbxPeople.SelectedItem; 
                if (Organisation.PersonManager.RemovePerson(selectedPerson.Pcn))
                {
                    MessageBox.Show($"You have successfully removed person with PCN: {selectedPerson.Pcn}!");
                    UpdateManagePeople();
                }
                else
                {
                    MessageBox.Show("The selected person is already removed! Please refresh!");
                }
            }
            else
            {
                MessageBox.Show("Please, select person to remove it!");
            }
        }

        private void btnEditPerson_Click(object sender, EventArgs e)
        {
            if (lbxPeople.SelectedIndex != -1)
            {
                Person selectedPerson = (Person)lbxPeople.SelectedItem;
                EditPersonForm editPersonForm = new EditPersonForm(this, selectedPerson);
                editPersonForm.Show();

            }
            else
            {
                MessageBox.Show("Please, select person to edit their profile!");
            }
        }


        private void btnViewEnrollmentsPerson_Click(object sender, EventArgs e)
        {
            if (lbxPeople.SelectedIndex != -1)
            {
                Person selectedPerson = (Person)lbxPeople.SelectedItem;
                PersonEnrollmentsForm personEnrollmentsForm = new PersonEnrollmentsForm(this, selectedPerson);
                personEnrollmentsForm.Show();

            }
            else
            {
                MessageBox.Show("Please, select person to view their workshop enrollments!");
            }
        }


        private void btnViewAvailableWorkshops_Click(object sender, EventArgs e)
        {
            AvailableWorkshopsForm availableWorkshops = new AvailableWorkshopsForm(this.Organisation);
            availableWorkshops.Show();
        }

        private void btnGeneratePrintableFileAvailableWorkshops_Click(object sender, EventArgs e)
        {
            // Get the file path - open file dialog
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "txt";
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                Organisation.WorkshopManager.GeneratePrintableFileForAvailableWorkshops(path);
                MessageBox.Show("You have successfully generate printable file with available workshops!");
            }
            else
            {
                MessageBox.Show("You choose cancel!");
            }
        }

    }
}
