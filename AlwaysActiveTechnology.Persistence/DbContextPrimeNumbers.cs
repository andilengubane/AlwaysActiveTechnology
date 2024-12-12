using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using AlwaysActiveTechnology.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace AlwaysActiveTechnology.Persistence
{
    public class DbContextPrimeNumbers: DbContext
    {
        public DbContextPrimeNumbers(DbContextOptions<DbContextPrimeNumbers> options, IConfiguration configuration)
           : base(options)
        {
            Configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }


        public virtual DbSet<NumberDTO> MenuItems { get; set; }
        public IConfiguration Configuration { get; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MosEisleyCantinaOnTatooine;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}