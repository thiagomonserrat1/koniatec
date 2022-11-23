namespace KoniaTec
{
    public class SeedDataBase
    {
        public static void SeedUser(AppDbContext context)
        {
            if (!context.Users.Any())
            {
                var users = new List<User>
                {
                new User{Nome = "Thiago Henrique Monserrat"},
                new User{Nome = "Jose Leandro"},
                new User{Nome = "João Rodrigo"},
                new User{Nome = "Ramon Ferreira"},
                new User{Nome = "Caio Guilherme"},
                new User{Nome = "Leandro Gonçalves"},
                new User{Nome = "Matheus Henrique"},
                new User{Nome = "Felipe Silva"},
                new User{Nome = "Jonathan Alencar"},
                new User{Nome = "Marcelo Rezende"}

            };

                context.AddRange(users);
                context.SaveChanges();
                Console.WriteLine("Novos usuarios inseridos!");

            }
            else
            {
                context.RemoveRange(context.Users);
                context.SaveChanges();
                var users = new List<User>
                {
                new User{Nome = "Thiago Henrique Monserrat"},
                new User{Nome = "Jose Leandro"},
                new User{Nome = "João Rodrigo"},
                new User{Nome = "Ramon Ferreira"},
                new User{Nome = "Caio Guilherme"},
                new User{Nome = "Leandro Gonçalves"},
                new User{Nome = "Matheus Henrique"},
                new User{Nome = "Felipe Silva"},
                new User{Nome = "Jonathan Alencar"},
                new User{Nome = "Marcelo Rezende"}

            };

                context.AddRange(users);
                context.SaveChanges();
                Console.WriteLine("Antigos usuarios apagados, novos usuarios inseridos!");

            }
        }
    }
}
