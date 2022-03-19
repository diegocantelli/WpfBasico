using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations.Reservoom.DbContexts
{
    public class ReservRoomDesignTimeDbContextFactory : IDesignTimeDbContextFactory<ReservroomDbContext>
    {
        public ReservroomDbContext CreateDbContext(string[] args)
        {
            var dbContextOptions = new DbContextOptionsBuilder().UseSqlite("Data Source=reservroom.db").Options;

            return new ReservroomDbContext(dbContextOptions);
        }
    }
}
