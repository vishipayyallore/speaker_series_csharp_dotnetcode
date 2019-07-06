using College.Common.Entities;
using System.Collections.Generic;

namespace College.Common.Interface
{
    public interface IStudentsData
    {
        IEnumerable<Student> GetAllStudents();
    }

}
