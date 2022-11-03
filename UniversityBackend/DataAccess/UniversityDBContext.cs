using Microsoft.EntityFrameworkCore;
using UniversityBackend.Models.DataModels;

namespace UniversityBackend.DataAccess
{
    public class UniversityDBContext:DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options): base(options)
        {

        }

        //TODO:ADD dbSets (Tables of our Data base)

        public DbSet<Users>? Users { get; set; }
    }
}
