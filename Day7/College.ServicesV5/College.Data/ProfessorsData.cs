using College.Common.Dtos;
using College.Common.Entities;
using College.Common.Interface;
using College.Data.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace College.Data
{
    public class ProfessorsData : IProfessorsData
    {
        readonly CollegeDbContext _collegeDbContext;

        public ProfessorsData(CollegeDbContext collegeDbContext)
        {
            _collegeDbContext = collegeDbContext;
        }

        public IEnumerable<Professor> GetProfessors()
        {
            return _collegeDbContext
                        .Professors
                        .Include(student => student.Students)
                        .ToList();
        }


        public Professor GetProfessorById(Guid id)
        {
            if (!_collegeDbContext.Professors.Any(record => record.ProfessorId == id))
            {
                return null;
            }

            return _collegeDbContext.Professors
                .Where(record => record.ProfessorId == id)
                .Include(student => student.Students)
                .FirstOrDefault();
        }

        public Professor AddProfessor(ProfessorForAddOrUpdate professor)
        {
            var newProfessor = new Professor
            {
                Name = professor.Name,
                Doj = professor.Doj,
                Salary = professor.Salary,
                IsPhd = professor.IsPhd,
                Teaches = professor.Teaches
            };

            _collegeDbContext.Professors.Add(newProfessor);

            _collegeDbContext.SaveChanges();

            return newProfessor;
        }


        public Professor UpdateProfessor(Guid id, ProfessorForAddOrUpdate professor)
        {
            if (!_collegeDbContext.Professors.Any(record => record.ProfessorId == id))
            {
                return null;
            }

            var retrievedProfessor = _collegeDbContext.Professors.Where(record => record.ProfessorId == id).FirstOrDefault();

            // Modifying the data
            retrievedProfessor.Name = professor.Name;
            retrievedProfessor.Doj = professor.Doj;
            retrievedProfessor.Salary = professor.Salary;
            retrievedProfessor.Teaches = professor.Teaches;
            retrievedProfessor.IsPhd = professor.IsPhd;

            _collegeDbContext.SaveChanges();

            return retrievedProfessor;
        }


        public bool DeleteProfessorById(Guid id)
        {
            if (!_collegeDbContext.Professors.Any(record => record.ProfessorId == id))
            {
                return false;
            }

            var retrievedProfessor = _collegeDbContext.Professors.Where(record => record.ProfessorId == id).FirstOrDefault();

            _collegeDbContext.Professors.Remove(retrievedProfessor);

            _collegeDbContext.SaveChanges();

            return true;
        }

    }

}
