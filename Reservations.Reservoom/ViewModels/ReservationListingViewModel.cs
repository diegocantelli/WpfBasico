using Reservations.Reservoom.Commands;
using Reservations.Reservoom.Models;
using Reservations.Reservoom.Services;
using Reservations.Reservoom.Stores;
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
        private readonly Hotel _hotel;
        private readonly NavigationService _navigationService;
        private readonly ObservableCollection<ReservationViewModel> _reservationViewModel;

        public IEnumerable<ReservationViewModel> Reservations => _reservationViewModel;
        public ICommand MakeReservationCommand { get; }

        public ReservationListingViewModel(
            Hotel hotel,
            NavigationService navigationService)
        {
            _hotel = hotel;
            _navigationService = navigationService;
            _reservationViewModel = new ObservableCollection<ReservationViewModel>();

            MakeReservationCommand = new NavigateCommand(_navigationService);
        }

        private void UpdateReservations()
        {
            _reservationViewModel.Clear();

            foreach (var reservation in _hotel.GetAllReservations())
            {
                ReservationViewModel reservationViewModel = new ReservationViewModel(reservation);
                _reservationViewModel.Add(reservationViewModel);
            }
        }
    }
}
