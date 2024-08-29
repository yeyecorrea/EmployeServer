using Dapper;
using Employe.Data.Interfaces;
using Employe.Domain.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Employe.Data.Repositories
{
    public class RepositoryEmploye : IRepositoryEmploye
    {
        private readonly string _connectionString;

        public RepositoryEmploye(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        /// <summary>
        /// Metodo que crea un empleado en la base de datos
        /// </summary>
        /// <param name="employe"></param>
        /// <returns></returns>
        public async Task CreateEmployeAsync(EmployeTable employe)
        {
            using var connection = new SqlConnection(_connectionString);
            int employeId = await connection.QuerySingleAsync<int>(@"INSERT INTO EMPLOYE (NAME, EMAIL, SALARY) VALUES (@Name, @Email, @Salary);" +
                "SELECT SCOPE_IDENTITY();", employe);

            employe.EmployeId = employeId;
        }

        /// <summary>
        /// Metodo que retorna la lista de empleados
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<EmployeTable>> ListEmployeAsyc()
        {
            using var connection = new SqlConnection(_connectionString);
            return await connection.QueryAsync<EmployeTable>(@"SELECT  * FROM EMPLOYE");
        }

    }
}
