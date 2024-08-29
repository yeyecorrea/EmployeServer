using Employe.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employe.Business.Interfaces
{
    public interface IEmployeService
    {
        Task CreateEmploye(EmployeTable employe);
        Task<IEnumerable<EmployeTable>> ListEmploye();
    }
}
