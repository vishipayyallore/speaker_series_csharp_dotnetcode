using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EmployeeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public EmployeesData GetAllEmployees()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["EmployeesDb"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SELECT Id, Name, Gender, Salary FROM Employee"))
                {
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter())
                    {
                        command.Connection = connection;
                        dataAdapter.SelectCommand = command;
                        using (DataTable dt = new DataTable())
                        {
                            EmployeesData customers = new EmployeesData();
                            dataAdapter.Fill(customers.EmployeesTable);
                            return customers;
                        }
                    }
                }
            }
        }
    }
}
