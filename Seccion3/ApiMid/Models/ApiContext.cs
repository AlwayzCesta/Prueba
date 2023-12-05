using Microsoft.EntityFrameworkCore;

namespace ApiMid.Models
{
    public class ApiContext : DbContext
    {
        //Se utiliza EF Core para la conexion de la base de datos
        public DbSet<Midle> Midle { get; set; }

        public ApiContext(DbContextOptions<ApiContext> options) : base(options) {}

        //Incorporamos Fluent Api junto a migraciones para facilitar la construccion de la base de datos
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Definimos una data inicial 
            var midleInit = new List<Midle>
            {
                new Midle { MidleID = Guid.NewGuid(), Usuario = "Oscar Mejia" , Request = "/programa/algoritmo/solucion/n3urcaVsw4r7,Oscar%20Mejia" , FechaRequest = DateTime.Now , Response = "{ result = aV }" , FechaResponse = DateTime.Now},
                new Midle { MidleID = Guid.NewGuid(), Usuario = "Paola Gutierrez" , Request = "/programa/algoritmo/solucion/Qc1uoTgfd,Paola%Gutierrez", FechaRequest = DateTime.Now , Response = "{ result = o }" , FechaResponse = DateTime.Now},
                new Midle { MidleID = Guid.NewGuid(), Usuario = "Ara Escobedo" , Request = "/programa/algoritmo/solucion/jafgyA,Ara%20Escobedo" , FechaRequest = DateTime.Now , Response = "{ result = fg }" , FechaResponse = DateTime.Now}
            };
            //Construimos la tabla Midle e ingresamos la data inicial
            modelBuilder.Entity<Midle>(midle =>
            {
                midle.ToTable("Midle");
                midle.HasKey(m => m.MidleID);
                midle.Property(m => m.Usuario).HasMaxLength(50).IsRequired();
                midle.Property(m => m.Request).HasMaxLength(500).IsRequired();
                midle.Property(m => m.FechaRequest).IsRequired();
                midle.Property(m => m.Response).HasMaxLength(500).IsRequired();
                midle.Property(m => m.FechaResponse).IsRequired();
                midle.HasData(midleInit);
            });
        }
    }
    
}