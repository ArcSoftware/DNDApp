using Microsoft.EntityFrameworkCore;

namespace DNDApp.Data
{
    class AppContext : DbContext
    {
        public AppContext(DbContextOptions options) : base(options)
        {
        }

        //Register DB Models here
    }
}