using Emp_BAL.Interfaces;
using Emp_BAL.Models;
using System;
using System.Windows;
using System.Windows.Controls;

namespace POC_Employe_Management_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IEmployee employe;
        Employee employees;
        public MainWindow(IEmployee employe)
        {
            InitializeComponent();
            this.employe = employe;
        }

       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            if (tBoxEmail.Text.Length > 0)
            {
                isValid = employe.ValidateEmail(tBoxEmail.Text);

            }

            if (isValid)
            {
                string result;
                employees = new Employee();

                employees.Id = Convert.ToInt32(tBoxId.Text);
                employees.Name = tBoxName.Text;
                employees.Email = tBoxEmail.Text;

                ComboBoxItem gender = (ComboBoxItem)cBoxGender.SelectedItem;
              
                ComboBoxItem status = (ComboBoxItem)cBoxStatus.SelectedItem;              

                employees.Gender = gender.Content.ToString();
                employees.Status = status.Content.ToString();

                result = this.employe.InsertEmployes(employees);

                if (result != null)
                {
                    if (result == "Created")
                    {
                        MessageBox.Show("added");
                    }
                    else if (result == "UnprocessableEntity")
                        MessageBox.Show("Duplicate record, Pl use different Employe ID and email ID !!!");
                }


            }
        }


        private void btnGetEmp_Click(object sender, EventArgs e)
        {
            DataGridEmploye.ItemsSource = this.employe.GetEmployes();
        }

    }
}
