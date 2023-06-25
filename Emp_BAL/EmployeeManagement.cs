using Emp_BAL.Interfaces;
using Emp_BAL.Models;
using System.Net.Http;
using System;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text;
using System.Text.RegularExpressions;

namespace Emp_BAL
{
    public class EmployeeManagement : IEmployee
    {        
        public List<Employee> GetEmployes()
        {
            List<Employee> empList = new List<Employee>();
            try
            {

                HttpClient client = new HttpClient();

                client.BaseAddress = new Uri("https://gorest.co.in/public/v2/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetAsync("users");

                var result = response.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadFromJsonAsync<Employee[]>();

                    var employees = readTask.Result;

                    foreach (var emp in employees)
                    {
                        Employee employe = new()
                        {
                            Id = emp.Id,
                            Name = emp.Name,
                            Email = emp.Email,
                            Gender = emp.Gender,
                            Status = emp.Status
                        };
                        empList.Add(employe);

                    }


                }
                return empList;


            }
            catch (Exception ex)
            {
                return null;
                //MessageBox.Show(ex.Message);
            }
        }

        public string InsertEmployes(Employee employe)
        {
            string result=string.Empty;
            try
            {
                if(employe!=null)
                {
                string strJson = JsonSerializer.Serialize<Employee>(employe);
                var data = new StringContent(strJson, Encoding.UTF8, "application/json");
                HttpClient client = new HttpClient();

                client.BaseAddress = new Uri("https://gorest.co.in/public/v2/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization =  new AuthenticationHeaderValue("Bearer",
                    "0bf7fb56e6a27cbcadc402fc2fce8e3aa9ac2b40d4190698eb4e8df9284e2023");
                    var response = client.PostAsync("users", data);                  

                 result = response.Result.StatusCode.ToString();
                    
                   
                }

                return result;

            }
            catch (Exception ex)
            {
               return ex.Message;
                
            }
        }

        public bool ValidateEmail(string email)
        {
           bool isValid = true;
            if (!string.IsNullOrWhiteSpace(email))
            {
                Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                if (!reg.IsMatch(email))
                {
                   isValid = false;
                }
            }
            return isValid;
        }
    }
}