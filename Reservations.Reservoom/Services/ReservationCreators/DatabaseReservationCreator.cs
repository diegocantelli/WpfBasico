using Reservations.Reservoom.DbContexts;
using Reservations.Reservoom.DTOs;
using Reservations.Reservoom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations.Reservoom.Services.ReservationCreators
{
    
    public class DatabaseReservationCreator : IReservationCreator
    {
        private readonly ReservrRoomDbContextFactory _dbContextFactory;

        public DatabaseReservationCreator(ReservrRoomDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task CreateReservation(Reservation reservation)
        {
            using (ReservroomDbContext context = _dbContextFactory.CreateDbContext())
            {
                ReservationDto reservationDto = ToReservationDto(reservation);
                context.Reservations.Add(reservationDto);
                await context.SaveChangesAsync();
            }
        }

        private ReservationDto ToReservationDto(Reservation reservation)
        {
            return new ReservationDto
            {
                FloorNumber = reservation.RoomID?.FloorNumber ?? 0,
                RoomNumber = reservation.RoomID?.RoomNumber ?? 0,
                UserName = reservation.UserName,
                StartTime = reservation.StartTime,
                EndTime = reservation.EndTime
            };
        }
    }
}
