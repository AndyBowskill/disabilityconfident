using DisabledConfidentWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisabledConfidentWebsite.Repositories
{
    public interface IEmployerRepository
    {
        List<Employer> GetAll();
    }
}
