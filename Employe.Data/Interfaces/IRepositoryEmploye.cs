using Employe.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employe.Data.Interfaces
{
    public interface IRepositoryEmploye
    {
        Task CreateEmployeAsync(EmployeTable employe);
        Task<IEnumerable<EmployeTable>> ListEmployeAsyc();
    }
}
