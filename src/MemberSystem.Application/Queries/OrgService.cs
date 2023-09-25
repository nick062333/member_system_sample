using Dapper;
using MemberSystem.Application.DTOs;
using MemberSystem.Infrastructure.Config;
using Microsoft.Extensions.Options;
using System.Data.SqlClient;

namespace MemberSystem.Application.Queries
{
    public class OrgService : IOrgService
    {

        private readonly ConnectionSettings _connectionSettings;

        public OrgService(IOptions<ConnectionSettings> connectionSettings)
        {
            _connectionSettings = connectionSettings.Value;
        }

        public async Task<IEnumerable<OrgDTO>> GetAllOrgListAsync()
        {
            using var connection = new SqlConnection(_connectionSettings.MemberContext);
            connection.Open();

            var result = await connection.QueryAsync<OrgDTO>(
                @"SELECT id, title, org_no FROM orgs"
            );

            return result.AsList();
        }
    }
}
