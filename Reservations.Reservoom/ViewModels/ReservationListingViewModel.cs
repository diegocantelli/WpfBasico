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
        }
    }
}
