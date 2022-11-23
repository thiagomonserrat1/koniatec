using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace KoniaTec
{
    public class User
    {
        public Guid Id { get; set; } = new Guid();
        public string? Nome { get; set; }
        public DateOnly CreateIn { get; set; } = DateOnly.FromDateTime(DateTime.Today);
    }
    public class AppDbContext : DbContext
    {
        public DbSet<User>? Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql($"Host=HOST;Port=PORT;Username=USER_NAME;Password=SUA_SENHA;Database=NOME_DB");
        }
        //PARA USAR O SQLSERVER, RESTAURE AS MIGRATIONS, DESCOMENTE AS PROXIMAS LINHAS E COMENTE AS DE CIMA DA 28 A 31 E GERE NOVAMENTE AS MIGRATIONS 
        //MAIS INFORMAÇÕES DE COMO FAZER ISSO NO README.md 

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //  optionsBuilder.UseSqlServer("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        // }
    }

    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AppDbContext())
            {
                SeedDataBase.SeedUser(db);

                var users = db.Users.ToList();
                foreach (var use in users)
                {
                    Console.WriteLine(use.Id + " - " + use.Nome + " - " + use.CreateIn);
                }
            }
        }
    }
}