using Microsoft.EntityFrameworkCore;
using Reservations.Reservoom.DbContexts;
using Reservations.Reservoom.DTOs;
using Reservations.Reservoom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations.Reservoom.Services.ReservationProviders
{
    public class DatabaseReservationProvider : IReservationProviders
    {
        private readonly ReservrRoomDbContextFactory _dbContextFactory;

        public DatabaseReservationProvider(ReservrRoomDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }
        public async Task<IEnumerable<Reservation>> GetAllReservations()
        {
            using (ReservroomDbContext context = _dbContextFactory.CreateDbContext())
            {
                IEnumerable<ReservationDto> reservationDtos = await context.Reservations.ToListAsync();

                return reservationDtos.Select(x => ToReservation(x));
            }
        }

        private static Reservation ToReservation(ReservationDto x)
        {
            return new Reservation(
                                new RoomID(x.FloorNumber, x.RoomNumber), x.StartTime, x.EndTime, x.UserNumber);
        }
    }
}
