using Emp_BAL.Interfaces;
using Emp_BAL.Models;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using TextBox = System.Windows.Forms.TextBox;

namespace POC_Employee_Management
{
    public partial class Employee_Form : Form
    {
        private readonly IEmployee employee;
         Employee employees;
        public Employee_Form(IEmployee employee)
        {            
            InitializeComponent();
            this.employee = employee;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            if(tBoxEmail.Text.Length > 0 )
            {
                isValid = employee.ValidateEmail(tBoxEmail.Text);

            }

            if (isValid)
            {
                string result;
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    employees = new Employee();

                    employees.Id = Convert.ToInt32(tBoxEmpId.Text);
                    employees.Name = tBoxEmpName.Text;
                    employees.Email = tBoxEmail.Text;
                    employees.Gender = cBoxGender.SelectedItem.ToString();
                    employees.Status = cBoxStatus.SelectedItem.ToString();

                    result = this.employee.InsertEmployes(employees);

                    if (result != null)
                    {
                        if (result == "Created")
                        {
                            MessageBox.Show("added");
                            ResetFields();
                        }
                        else if (result == "UnprocessableEntity")
                            MessageBox.Show("Duplicate record, Pl use different Employe ID and email ID !!!");
                    }


                }
            }


          
        }
       

        private void btnGetEmp_Click(object sender, EventArgs e)
        {
            EmpGrid.DataSource=   this.employee.GetEmployes();
        }

        //private void tBoxEmpId_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(tBoxEmpId.Text))
        //    {
        //        e.Cancel = true;
        //        tBoxEmpId.Focus();
        //        errorPro.SetError(tBoxEmpId, "Employe Id should not be left blank!");
        //    }
        //    else
        //    {
        //        e.Cancel = false;
        //        errorPro.SetError(tBoxEmpId, "");
        //    }
        //}

        //private void tBoxEmpName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(tBoxEmpName.Text))
        //    {
        //        e.Cancel = true;
        //        tBoxEmpName.Focus();
        //        errorPro.SetError(tBoxEmpName, "Employe Name should not be left blank!");
        //    }
        //    else
        //    {
        //        e.Cancel = false;
        //        errorPro.SetError(tBoxEmpName, "");
        //    }
        //}

        //private void tBoxEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(tBoxEmail.Text))
        //    {
        //        e.Cancel = true;
        //        tBoxEmail.Focus();
        //        errorPro.SetError(tBoxEmail, "Email ID should not be left blank!");
        //    }
        //    else if (!string.IsNullOrWhiteSpace(tBoxEmail.Text))
        //    {                
        //            Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
        //            if (!reg.IsMatch(tBoxEmail.Text))
        //            {
        //                e.Cancel = true;
        //                errorPro.SetError(tBoxEmail, "Pl enter correct EMail id!");
        //            }
                
        //    }
        //    else
        //    {
        //        e.Cancel = false;
        //        errorPro.SetError(tBoxEmail, "");
        //    }
        //}

        //private void tBoxEmpId_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        //        (e.KeyChar != '.'))
        //    {
        //        e.Handled = true;
        //    }

        //    // only allow one decimal point
        //    if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
        //    {
        //        e.Handled = true;
        //    }

        //}

        //private void tBoxEmpName_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        //}


        private void cBoxGender_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (cBoxGender.SelectedIndex == -1)//Nothing selected
            {
                cBoxGender.Focus();
                errorPro.SetError(cBoxGender, "Employe gender should not be left blank!");

            }
            else if (cBoxGender.SelectedIndex != -1)
            {
                errorPro.SetError(cBoxGender, "");
            }
        }

        private void cBoxStaus_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (cBoxStatus.SelectedIndex == -1)//Nothing selected
            {
                cBoxStatus.Focus();
                errorPro.SetError(cBoxStatus, "Employe status should not be left blank!");

            }
            else if (cBoxStatus.SelectedIndex != -1)
            {
                errorPro.SetError(cBoxStatus, "");
            }

        }

        private void tBoxEmpId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {

                e.Handled = true;
            }
          
        }

        private void tBoxEmpName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

       

        private void tBoxEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tBoxEmail.Text))
            {
                e.Cancel = true;
                tBoxEmail.Focus();
                errorPro.SetError(tBoxEmail, "Email ID should not be left blank!");
            }
            else if (!string.IsNullOrWhiteSpace(tBoxEmail.Text))
            {
                Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                if (!reg.IsMatch(tBoxEmail.Text))
                {
                    e.Cancel = true;
                    errorPro.SetError(tBoxEmail, "Pl enter correct EMail id!");
                }
                else
                {
                    e.Cancel = false;
                    errorPro.SetError(tBoxEmail, "");
                }

            }
            else
            {
                e.Cancel = false;
                errorPro.SetError(tBoxEmail, "");
            }
        }

        private void tBoxEmpId_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tBoxEmpId.Text))
            {
                e.Cancel = true;
                tBoxEmpId.Focus();
                errorPro.SetError(tBoxEmpId, "Employe Id should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorPro.SetError(tBoxEmpId, "");
            }
        }

        private void tBoxEmpName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tBoxEmpName.Text))
            {
                e.Cancel = true;
                tBoxEmpName.Focus();
                errorPro.SetError(tBoxEmpName, "Employe Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorPro.SetError(tBoxEmpName, "");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetFields();
        }

        private void ResetFields()
        {
            tBoxEmpId.Text = string.Empty;
            tBoxEmail.Text = string.Empty;
            tBoxEmpName.Text = string.Empty;
            cBoxGender.SelectedIndex = -1;
            cBoxStatus.SelectedIndex = -1;
            errorPro.SetError(tBoxEmpName, "");
            errorPro.SetError(tBoxEmpId, "");
            errorPro.SetError(tBoxEmpId, "");
        }

       
    }
}
