using College.Common.Entities;
using System;
using System.Collections.Generic;

namespace College.Common.Interface
{

    public interface IProfessorsData
    {
        Professor AddProfessor(Professor professor);

        bool DeleteProfessorById(Guid id);

        Professor GetProfessorById(Guid id);

        IEnumerable<Professor> GetProfessors();

        Professor UpdateProfessor(Guid id, Professor professor);
    }

}