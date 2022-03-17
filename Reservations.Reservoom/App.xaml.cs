using Reservations.Reservoom.Exceptions;
using Reservations.Reservoom.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Reservations.Reservoom
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var hotel = new Hotel("Diego Suites");

            try
            {
                hotel.MakeReservation(new Reservation(
                    new RoomID(1, 3),
                    new DateTime(2000, 1, 1),
                    new DateTime(2000, 1, 2),
                    "Diego Cantelli"));

                hotel.MakeReservation(new Reservation(
                    new RoomID(1, 3),
                    new DateTime(2000, 1, 3),
                    new DateTime(2000, 1, 4),
                    "Diego Cantelli"));
            }
            catch (ReservationConflictException ex)
            {
                throw ex;
            }

            var reservations = hotel.GetReservationsForUsers("Diego Cantelli");

            base.OnStartup(e);
        }
    }
}
