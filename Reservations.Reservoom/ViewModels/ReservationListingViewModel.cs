using Reservations.Reservoom.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Reservations.Reservoom.ViewModels
{
    public class ReservationListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<ReservationViewModel> _reservationViewModel;

        public IEnumerable<ReservationViewModel> Reservations => _reservationViewModel;
        public ICommand MakeReservationCommand { get; }

        public ReservationListingViewModel()
        {
            _reservationViewModel = new ObservableCollection<ReservationViewModel>();
            _reservationViewModel.Add(new ReservationViewModel(new Reservation(new RoomID(1, 2), DateTime.Now, DateTime.Now, "Diego")));
            _reservationViewModel.Add(new ReservationViewModel(new Reservation(new RoomID(3, 2), DateTime.Now, DateTime.Now, "Teste")));
            _reservationViewModel.Add(new ReservationViewModel(new Reservation(new RoomID(2, 2), DateTime.Now, DateTime.Now, "Joao")));
        }
    }
}
