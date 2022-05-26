using Microsoft.EntityFrameworkCore;
using NETCoreMVC6Test.Models;

namespace NETCoreMVC6Test.Data
{
    public class AppDBContext :DbContext
    {

        public AppDBContext(DbContextOptions<AppDBContext>dboptions): base(dboptions)
        {
           
        }
        public DbSet<Category>Categories{ get; set; }

    }   
}
