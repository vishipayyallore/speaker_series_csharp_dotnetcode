using College.Common.Entities;
using College.Common.Interface;
using System;
using System.Collections.Generic;

namespace College.Business
{

    public class StudentsBusiness : IStudentsBusiness
    {
        readonly IStudentsData _studentsData;

        public StudentsBusiness(IStudentsData studentsData)
        {
            _studentsData = studentsData;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _studentsData.GetAllStudents();
        }

        public object GetStudentById(Guid id)
        {
            return _studentsData.GetStudentById(id);
        }
    }

}
