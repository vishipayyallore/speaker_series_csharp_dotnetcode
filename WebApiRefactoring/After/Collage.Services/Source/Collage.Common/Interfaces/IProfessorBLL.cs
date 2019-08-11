using Collage.Common.Entities;
using System.Collections.Generic;

namespace Collage.Common.Interfaces
{

    public interface IProfessorBLL
    {
        IEnumerable<Professor> GetProfessors();
    }

}
