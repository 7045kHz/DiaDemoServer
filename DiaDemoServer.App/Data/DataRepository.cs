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
        public DataRepository(IConfiguration configuration)
        {
            _conf = configuration;

        }
        public async Task<IEnumerable<CustomNodeModel>> GetAllNodesAsync()
        {
            var _connectionString = _conf.GetConnectionString("DB");
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var sql = @"SELECT  [NodeId]
                              ,[Name]
                              ,[Title]
                              ,[Group]
                              ,[X]
                              ,[Y]
                              ,[L]
                              ,[FlowType]
                              ,[Label]
                              ,[Description]
                              ,[Action]
                              ,[IsActive]
                              ,[LastUpdated]
                              ,[LastUpdatedBy]
                          FROM [PROTO_DIA].[PA].[NODE_MODEL]";
                var result = await connection.QueryAsync<CustomNodeModel>(sql);
                connection.Close();
                return result;
            }
        }
        public async Task<IEnumerable<CustomPortModel>> GetAllPortsAsync()
        {
            var _connectionString = _conf.GetConnectionString("DB");
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var sql = @"SELECT  [PortId]
                      ,[NodeId]
                      ,[Name]
                      ,[PortAlignment]
                      ,[Label]
                      ,[IsActive]
                      ,[LastUpdated]
                      ,[LastUpdatedBy]
                  FROM [PROTO_DIA].[PA].[PORT_MODEL]";
                var result = await connection.QueryAsync<CustomPortModel>(sql);
                connection.Close();
                return result;
            }

        }
        public async Task<IEnumerable<CustomProcessModel>> GetAllProcessAsync()
        {
            var _connectionString = _conf.GetConnectionString("DB");
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var sql = @"SELECT  [ProcessId]
                      ,[Name]
                      ,[Title]
                      ,[Description]
                      ,[Action]
                      ,[Group]
                      ,[ProcessType]
                      ,[Label]
                      ,[IsActive]
                      ,[LastUpdated]
                      ,[LastUpdatedBy]
                  FROM [PROTO_DIA].[PA].[PROCESS_MODEL]";
                var result = await connection.QueryAsync<CustomProcessModel>(sql);
                connection.Close();
                return result;
            }

        }
        public async Task<IEnumerable<CustomProcessLinkModel>> GetAllProcessLinksAsync()
        {
            var _connectionString = _conf.GetConnectionString("DB");
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var sql = @"SELECT  [Id]
                      ,[ProcessId]
                      ,[Order]
                      ,[SourceNodeId]
                      ,[TargetNodeId]
                      ,[Name]
                      ,[PathGenerator]
                      ,[Router]
                      ,[SourceMarker]
                      ,[TargetMarker]
                      ,[Label]
                      ,[IsOnError]
                      ,[IsActive]
                      ,[LastUpdated]
                      ,[LastUpdatedBy]
                  FROM [PROTO_DIA].[PA].[PROCESS_LINK_MODEL]";
                var result = await connection.QueryAsync<CustomProcessLinkModel>(sql);
                connection.Close();
                return result;
            }

        }
    }


}




