﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations.Reservoom.Models
{
    public class Hotel
    {
        private readonly ReservationBook _reservationBook;
        public string Name { get; }

        public Hotel(string name)
        {
            Name = name;
            _reservationBook = new ReservationBook();
        }

        public IEnumerable<Reservation> GetReservationsForUsers(string userName)
        {
            return _reservationBook.GetReservationsForUser(userName);
        }

        public void MakeReservation(Reservation reservation)
        {
            _reservationBook.AddReservation(reservation);
        }
    }
}
