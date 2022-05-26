using Microsoft.EntityFrameworkCore;

namespace NETCoreMVC6Test.Data
{
    public class AppDBContext :DbContext
    {

        public AppDBContext(DbContextOptions<AppDBContext>dboptions): base(dboptions)
        {

        }


    }
}
