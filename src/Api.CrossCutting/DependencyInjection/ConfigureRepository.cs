using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependencyRepository (IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof (IRepository<>), typeof (BaseRepository<>));

            // conexao mysql
            // var connectionString = "Server=localhost;Port=3306;Database=dbAPI;Uid=root;Pwd=root";
            // serviceCollection.AddDbContext<MyContext> (
            //     options => options.UseMySql(connectionString)
            // );

            var connectionString = "Server=.;Database=CursoApiNETCore;Integrated Security=true;MultipleActiveResultSets=true";
            serviceCollection.AddDbContext<MyContext> (
                options => options.UseSqlServer(connectionString)
            );
        }
    }
}
