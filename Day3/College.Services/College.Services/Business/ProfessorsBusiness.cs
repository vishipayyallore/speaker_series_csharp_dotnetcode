using College.Services.Data;
using College.Services.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;

namespace College.Services.Business
{
    public class ProfessorsBusiness
    {
        readonly ProfessorsData _professorsData;

        public ProfessorsBusiness(IConfiguration configuration)
        {
            _professorsData = new ProfessorsData(configuration);
        }

        public IEnumerable<Professor> GetProfessors()
        {
            return _professorsData.GetProfessors();
        }

        public Professor GetProfessorById(Guid id)
        {
            return _professorsData.GetProfessorById(id);
        }

    }

}
