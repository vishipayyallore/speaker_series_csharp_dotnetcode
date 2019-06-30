using College.Services.Entities;
using College.Services.Persistence;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;

namespace College.Services.BAL
{
    public class ProfessorsBal
    {
        readonly ProfessorsDal _professorsData;

        public ProfessorsBal(IConfiguration configuration)
        {
            _professorsData = new ProfessorsDal(configuration);
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
