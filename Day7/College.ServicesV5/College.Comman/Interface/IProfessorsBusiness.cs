using College.Common.Dtos;
using College.Common.Entities;
using System;
using System.Collections.Generic;

namespace College.Common.Interface
{

    public interface IProfessorsBusiness
    {
        Professor AddProfessor(ProfessorForAddOrUpdate professor);

        bool DeleteProfessorById(Guid id);

        Professor GetProfessorById(Guid id);

        IEnumerable<Professor> GetProfessors();

        Professor UpdateProfessor(Guid id, ProfessorForAddOrUpdate professor);
    }

}