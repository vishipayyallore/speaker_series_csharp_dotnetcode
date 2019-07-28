using College.DAL.Entities;
using College.DAL.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace College.DAL
{
    public class ProfessorsData
    {
        readonly CollegeDbContext _collegeDbContext;

        public ProfessorsData(IConfiguration configuration)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CollegeDbContext>();

            var connectionString = configuration["ConnectionStrings:CollegeDBConnectionString"];
            optionsBuilder.UseSqlServer(connectionString);

            _collegeDbContext = new CollegeDbContext(optionsBuilder.Options);
        }

        public IEnumerable<Professor> GetProfessors()
        {
            return _collegeDbContext
                        .Professors
                        .Include(row => row.Students)
                        .ToList();
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
