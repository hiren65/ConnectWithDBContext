using Microsoft.EntityFrameworkCore;

namespace ConnectWithDBContext.Models
{
    public class DBCtx:DbContext
    {

        public DBCtx(DbContextOptions<DBCtx>options):base(options)
        {

        }

        public DbSet<Received> tblReceived { get; set; }
        public DbSet<CFSPlanningReports> CFSPlanningReports { get; set; }
    }
}
