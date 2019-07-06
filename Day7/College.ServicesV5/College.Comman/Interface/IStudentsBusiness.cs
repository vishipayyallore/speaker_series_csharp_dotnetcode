using College.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace College.Common.Interface
{
    public interface IStudentsBusiness
    {

        IEnumerable<Student> GetAllStudents();

    }

}
