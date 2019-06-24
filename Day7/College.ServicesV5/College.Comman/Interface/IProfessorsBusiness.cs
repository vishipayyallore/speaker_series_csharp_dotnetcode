using College.Comman.Entities;
using System;
using System.Collections.Generic;

namespace College.Comman.Interface
{

    public interface IProfessorsBusiness
    {
        Professor AddProfessor(Professor professor);

        bool DeleteProfessorById(Guid id);

        Professor GetProfessorById(Guid id);

        IEnumerable<Professor> GetProfessors();

        Professor UpdateProfessor(Guid id, Professor professor);
    }

}