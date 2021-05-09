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
    public partial class EditPersonForm : Form
    {
        private MainForm mainForm;
        private OrganisationControl organisation;
        private Person selectedPerson;
        public EditPersonForm(MainForm mainForm, Person selectedPerson)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.organisation = mainForm.Organisation;
            this.selectedPerson = selectedPerson;
            FillInputs();
        }

        private void FillInputs()
        {
            tbxPcn.Text = selectedPerson.Pcn;
            tbxFName.Text = selectedPerson.Fname;
            tbxLName.Text = selectedPerson.Lname;
            tbxEmail.Text = selectedPerson.Email;
            tbxUserType.Text = selectedPerson is Teacher ? "Teacher" : "Student";
        }

        private bool CheckInputs()
        {
            bool isInputsFilled = !String.IsNullOrEmpty(tbxFName.Text) &&
                                  !String.IsNullOrEmpty(tbxLName.Text) &&
                                  !String.IsNullOrEmpty(tbxEmail.Text);
            return isInputsFilled;
        }


        private void btnEditPerson_Click(object sender, EventArgs e)
        {
            if (CheckInputs())
            {
                try
                {
                    Person newPerson;
                    if (tbxUserType.Text == "Teacher")
                    {
                        newPerson = new Teacher(tbxFName.Text, tbxLName.Text,
                            tbxPcn.Text, tbxEmail.Text, tbxUserType.Text);
                    }
                    else
                    {
                        newPerson = new Student(tbxFName.Text, tbxLName.Text,
                            tbxPcn.Text, tbxEmail.Text, tbxUserType.Text);
                    }

                    if (organisation.PersonManager.UpdatePerson(newPerson))
                    {
                        MessageBox.Show("You have successfully applied the new changes!");
                    }
                    else
                    {
                        MessageBox.Show($"Person with such Pcn: {newPerson.Pcn} doesn't exist!");
                    }
                }
                catch(InputFieldException ex)
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
                MessageBox.Show("Please, fill all the boxes to save the changes to this profile!");
            }

        }

        private void EditPersonForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.UpdateManagePeople();
        }
    }
}
