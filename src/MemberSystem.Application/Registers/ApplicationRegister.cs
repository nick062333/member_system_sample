using MemberSystem.Application.DTOs;
using MemberSystem.Application.Queries;
using MemberSystem.Infrastructure.Dapper.TypeMap;
using Microsoft.Extensions.DependencyInjection;

namespace MemberSystem.Application.Registers
{
    public static class ApplicationRegister
    {
        public static void RegisterDapperTypeMap() 
        {
            Dapper.SqlMapper.SetTypeMap(typeof(OrgDTO), new ColumnAttributeTypeMapper<OrgDTO>());
        }

        public static void RegisterQueriesServices(this IServiceCollection services) 
        {
            services.AddScoped<IOrgService, OrgService>();
        }
    }
}
