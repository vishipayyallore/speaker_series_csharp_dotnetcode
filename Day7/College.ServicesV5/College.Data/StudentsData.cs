using College.Common.Entities;
using College.Common.Interface;
using College.Data.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace College.Data
{

    public class StudentsData : IStudentsData
    {

        readonly CollegeDbContext _collegeDbContext;

        public StudentsData(CollegeDbContext collegeDbContext)
        {
            _collegeDbContext = collegeDbContext;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _collegeDbContext.Students.ToList();
        }

    }

}
