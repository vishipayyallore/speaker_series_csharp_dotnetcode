using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EmployeeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        EmployeesData GetAllEmployees();

    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class EmployeesData
    {

        public EmployeesData()
        {
            EmployeesTable = new DataTable("EmployeesData");
        }

        [DataMember]
        public DataTable EmployeesTable { get; set; }

    }

}
