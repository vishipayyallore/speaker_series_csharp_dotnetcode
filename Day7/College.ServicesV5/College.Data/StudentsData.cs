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

        public Student GetStudentById(Guid id)
        {
            if (!_collegeDbContext.Students.Any(record => record.StudentId == id))
            {
                return null;
            }

            return _collegeDbContext.Students
                .Where(record => record.StudentId == id)
                .FirstOrDefault();
        }
    }

}
