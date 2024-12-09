using DiaDemoServer.App.Models;
using Dapper;
using System.Data;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.Identity.Client;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Components;

namespace DiaDemoServer.App.Data
{
    public class DataRepository :  IDataRepository 
    {
        [Inject]
        IConfiguration _db
        {
            get; set;
        }
       
        public DataRepository(IConfiguration config)
        {
           _db = config  ;
        }
        public async Task<IEnumerable<DiagramNodeModel>> GetAllNodesAsync()
        {
            var _connectionString = _db.GetConnectionString("DB");
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
                var result = await connection.QueryAsync<DiagramNodeModel>(sql);
                connection.Close();
                return result;
            }
        }
        public async Task<IEnumerable<DiagramPortModel>> GetAllPortsAsync()
        {
            var _connectionString = _db.GetConnectionString("DB");
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
                var result = await connection.QueryAsync<DiagramPortModel>(sql);
                connection.Close();
                return result;
            }

        }
        public async Task<IEnumerable<DiagramProcessModel>> GetAllProcessAsync()
        {
            var _connectionString = _db.GetConnectionString("DB");
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
                var result = await connection.QueryAsync<DiagramProcessModel>(sql);
                connection.Close();
                return result;
            }

        }
        public async Task<IEnumerable<DiagramProcessLinkModel>> GetAllProcessLinksAsync()
        {
            var _connectionString = _db.GetConnectionString("DB");
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
                var result = await connection.QueryAsync<DiagramProcessLinkModel>(sql);
                connection.Close();
                return result;
            }

        }
    }


}




