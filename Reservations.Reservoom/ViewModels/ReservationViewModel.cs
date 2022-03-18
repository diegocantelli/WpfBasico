using Reservations.Reservoom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations.Reservoom.ViewModels
{
    //Esta classe foi criar para que possa ser feito o property bind entre a view de listagem de reservas e as reservas
    //não podemos realizar o binding diretamente na classe Reservation, pois ela não implementa a interva INotifyPropertyChanged
    //e tbm não é uma boa prática usar essa interface em classes que pertencem à model
    public class ReservationViewModel : ViewModelBase
    {
        private readonly Reservation _reservation;

        public string RoomID => _reservation.RoomID.ToString();
        public string UserName => _reservation.UserName;
        public string StartDate => _reservation.StartTime.ToString("dd/MM/yyyy");
        public string EndDate => _reservation.EndTime.ToString("dd/MM/yyyy");

        public ReservationViewModel(Reservation reservation)
        {
            _reservation = reservation;
        }
    }
}
