using Dapper;
using DisabledConfidentWebsite.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DisabledConfidentWebsite.Repositories
{
    public class EmployerRepository : IEmployerRepository
    {
        private readonly IConfiguration _configuration;

        public EmployerRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_configuration.GetConnectionString("MyConnectionString"));
            }
        }

        public List<Employer> GetAll()
        {
            using (IDbConnection connection = Connection)
            {
                string query = "SELECT Name FROM Employer";
                connection.Open();
                var result = connection.Query<Employer>(query);
                return result.ToList();
            }
        }
    }
}
