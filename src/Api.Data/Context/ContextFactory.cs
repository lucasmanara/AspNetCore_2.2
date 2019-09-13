using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {            
            // string de conexao do mysql   
            // var connectionString = "Server=localhost;Port=3306;Database=dbAPI;Uid=root;Pwd=root";
            var connectionString = "Server=.;Database=CursoApiNETCore;Integrated Security=true;MultipleActiveResultSets=true";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            
            //builder mysql
            // optionsBuilder.UseMySql(connectionString);
            optionsBuilder.UseSqlServer(connectionString);
            return new MyContext(optionsBuilder.Options);
        }
    }
}
