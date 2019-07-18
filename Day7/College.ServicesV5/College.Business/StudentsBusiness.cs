using College.Common.Dtos;
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

        public Student AddStudent(StudentForAddOrUpdate studentForAdd)
        {
            return _studentsData.AddStudent(studentForAdd);
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _studentsData.GetAllStudents();
        }

        public Student GetStudentById(Guid id)
        {
            return _studentsData.GetStudentById(id);
        }
    }

}
