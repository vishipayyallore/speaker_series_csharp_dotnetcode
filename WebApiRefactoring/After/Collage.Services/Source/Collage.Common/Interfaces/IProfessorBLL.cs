using Collage.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Collage.Common.Interfaces
{

    public interface IProfessorBLL
    {
        IEnumerable<Professor> GetProfessors();
    }

}
