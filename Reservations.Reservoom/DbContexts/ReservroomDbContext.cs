using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Reservations.Reservoom.DTOs;

namespace Reservations.Reservoom.DbContexts
{
    public class ReservroomDbContext : DbContext
    {
        public DbSet<ReservationDto> Reservations { get; set; }

        public ReservroomDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
