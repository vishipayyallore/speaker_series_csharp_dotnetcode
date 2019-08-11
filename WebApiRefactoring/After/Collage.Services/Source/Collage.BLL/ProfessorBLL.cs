using Collage.Common.Entities;
using Collage.Common.Interfaces;
using System.Collections.Generic;

namespace Collage.BLL
{
    public class ProfessorBLL : IProfessorBLL
    {
        private readonly IProfessorDAL _professorDAL;

        public ProfessorBLL(IProfessorDAL professorDAL)
        {
            _professorDAL = professorDAL;
        }

        public IEnumerable<Professor> GetProfessors()
        {
            return _professorDAL.GetProfessors();
        }
    }
}
