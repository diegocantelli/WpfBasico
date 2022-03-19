using Reservations.Reservoom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations.Reservoom.Services.ReservationProviders
{
    public interface IReservationProviders
    {
        Task<IEnumerable<Reservation>> GetAllReservations();
    }
}
