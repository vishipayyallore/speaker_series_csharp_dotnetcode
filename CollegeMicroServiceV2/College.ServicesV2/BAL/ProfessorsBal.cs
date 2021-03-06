﻿using College.ServicesV2.Entities;
using College.ServicesV2.Persistence;
using System;
using System.Collections.Generic;

namespace College.ServicesV2.BAL
{
    public class ProfessorsBal
    {
        private readonly ProfessorsDal _professorsData;

        public ProfessorsBal(ProfessorsDal professorsData)
        {
            _professorsData = professorsData;
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
