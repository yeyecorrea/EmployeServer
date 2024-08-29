using Employe.Business.Interfaces;
using Employe.Data.Interfaces;
using Employe.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employe.Business.Services
{
    public class EmployeService : IEmployeService
    {
        private readonly IRepositoryEmploye _repositoryEmploye;

        public EmployeService(IRepositoryEmploye repositoryEmploye)
        {
            _repositoryEmploye = repositoryEmploye;
        }

        /// <summary>
        /// Metodo que invoca al repositorio para crear a un Empleado
        /// </summary>
        /// <param name="employe"></param>
        /// <returns></returns>
        public async Task CreateEmploye(EmployeTable employe)
        {
           await _repositoryEmploye.CreateEmployeAsync(employe);
        }


        /// <summary>
        /// Metodo que invoca al repositorio para lsitar todos los empleados
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<EmployeTable>> ListEmploye()
        {
            return await _repositoryEmploye.ListEmployeAsyc();
        }
    }
}
