using EmployeesWebService.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;

namespace EmployeesWebService
{
    /// <summary>
    /// Summary description for ABCEmployees
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AbcEmployees : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }


        [WebMethod]
        public List<Employee> GetAllEmployees()
        {
            return GetEmployees();
        }

        [WebMethod]
        public string GetAllEmployeesV2()
        {
            var employees = GetEmployees();

            JavaScriptSerializer js = new JavaScriptSerializer();
            return js.Serialize(employees);
        }

        private List<Employee> GetEmployees()
        {
            List<Employee> listEmployees = new List<Employee>();

            string cs = ConfigurationManager.ConnectionStrings["EmployeesDb"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(cs))
            {
                SqlCommand command = new SqlCommand
                {
                    Connection = connection,
                    CommandType = System.Data.CommandType.StoredProcedure,
                    CommandText = "dbo.GetAllEmployees"
                };
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Employee employee = new Employee
                    {
                        Id = Guid.Parse(reader["Id"].ToString()),
                        Name = reader["Name"].ToString(),
                        Gender = reader["Gender"].ToString(),
                        Salary = Convert.ToInt32(reader["Salary"])
                    };
                    listEmployees.Add(employee);
                }
            }

            return listEmployees;
        }


    }

}
