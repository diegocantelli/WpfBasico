using Reservations.Reservoom.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations.Reservoom.Models
{
    public class ReservationBook
    {
        private readonly List<Reservation> _reservations;
        public ReservationBook()
        {
            _reservations = new List<Reservation>();
        }

        public IEnumerable<Reservation> GetReservationsForUser(string userName)
        {
            return _reservations.Where(x => x.UserName == userName);
        }

        public void AddReservation(Reservation reservation)
        {
            foreach (var existingReservation in _reservations)
            {
                if (existingReservation.Conflict(reservation))
                {
                    throw new ReservationConflictException(existingReservation, reservation);
                }
            }
            _reservations.Add(reservation);
        }
    }
}
