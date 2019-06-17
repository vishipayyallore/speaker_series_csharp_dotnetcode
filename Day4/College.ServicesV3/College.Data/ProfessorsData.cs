using College.Data.Entities;
using College.Data.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace College.Data
{
    public class ProfessorsData
    {
        readonly CollegeDbContext _collegeDbContext;

        public ProfessorsData(CollegeDbContext collegeDbContext)
        {
            _collegeDbContext = collegeDbContext;
        }

        public IEnumerable<Professor> GetProfessors()
        {
            return _collegeDbContext.Professors.ToList();
        }


        public Professor GetProfessorById(Guid id)
        {
            if (!_collegeDbContext.Professors.Any(record => record.Id == id))
            {
                return null;
            }

            return _collegeDbContext.Professors.Where(record => record.Id == id).FirstOrDefault();
        }

        public Professor AddProfessor(Professor professor)
        {
            _collegeDbContext.Professors.Add(professor);

            _collegeDbContext.SaveChanges();

            return professor;
        }


        public Professor UpdateProfessor(Professor professor)
        {
            if (!_collegeDbContext.Professors.Any(record => record.Id == professor.Id))
            {
                return null;
            }


            var retrievedProfessor = _collegeDbContext.Professors.Where(record => record.Id == professor.Id).FirstOrDefault();

            // Modifying the data
            retrievedProfessor.Salary = professor.Salary;
            retrievedProfessor.IsPhd = professor.IsPhd;

            _collegeDbContext.SaveChanges();

            return professor;
        }


        public bool DeleteProfessorById(Guid id)
        {
            if (!_collegeDbContext.Professors.Any(record => record.Id == id))
            {
                return false;
            }

            var retrievedProfessor = _collegeDbContext.Professors.Where(record => record.Id == id).FirstOrDefault();

            _collegeDbContext.Professors.Remove(retrievedProfessor);

            _collegeDbContext.SaveChanges();

            return true;
        }

    }

}
