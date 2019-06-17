using College.Comman.Entities;
using College.Data;
using College.Data.Persistence;
using System;
using System.Collections.Generic;

namespace College.Business
{

    public class ProfessorsBusiness
    {
        readonly ProfessorsData _professorsData;

        public ProfessorsBusiness(CollegeDbContext collegeDbContext)
        {
            _professorsData = new ProfessorsData(collegeDbContext);
        }

        public IEnumerable<Professor> GetProfessors()
        {
            return _professorsData.GetProfessors();
        }

        public Professor GetProfessorById(Guid id)
        {
            return _professorsData.GetProfessorById(id);
        }


        public Professor AddProfessor(Professor professor)
        {
            return _professorsData.AddProfessor(professor);
        }

        public Professor UpdateProfessor(Professor professor)
        {
            return _professorsData.UpdateProfessor(professor);
        }

        public bool DeleteProfessorById(Guid id)
        {
            return _professorsData.DeleteProfessorById(id);
        }

    }

}
