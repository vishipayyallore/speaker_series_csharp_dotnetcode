﻿using College.Common.Dtos;
using College.Common.Entities;
using College.Common.Interface;
using System;
using System.Collections.Generic;

namespace College.Business
{

    public class ProfessorsBusiness : IProfessorsBusiness
    {
        readonly IProfessorsData _professorsData;

        public ProfessorsBusiness(IProfessorsData professorsData)
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

        public Professor AddProfessor(ProfessorForAddOrUpdate professor)
        {
            return _professorsData.AddProfessor(professor);
        }

        public Professor UpdateProfessor(Guid id, ProfessorForAddOrUpdate professor)
        {
            return _professorsData.UpdateProfessor(id, professor);
        }

        public bool DeleteProfessorById(Guid id)
        {
            return _professorsData.DeleteProfessorById(id);
        }

    }

}
