using DiaDemoServer.App.Models;
using Dapper;
using System.Data;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.Identity.Client;
using Microsoft.Data.SqlClient;

namespace DiaDemoServer.App.Data
{
  public class DataRepository : IDataRepository
    {
        private readonly IConfiguration _conf;
        public DataRepository(IConfiguration configuration) {
            _conf = configuration;
           
        }
        public   async Task<IEnumerable<CustomSvgNodeModel>> GetAllNodesAsync()
        {
            var _connectionString = _conf.GetConnectionString("DB");
            using (IDbConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    var sql = "SELECT * FROM Thing";
                var result =  await  connection.QueryAsync<CustomSvgNodeModel>(sql);
                connection.Close();
                return result;
                }
            
           
        }

        
    }
    

}


 
 
