using Reservations.Reservoom.Commands;
using Reservations.Reservoom.Models;
using Reservations.Reservoom.Services;
using Reservations.Reservoom.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Reservations.Reservoom.ViewModels
{
    public class MakeReservationViewModel : ViewModelBase
    {
        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set 
            { 
                _userName = value;
                OnPropertyChanged(nameof(UserName));
            }
        }

        private int _roomNumber;

        public int RoomNumber
        {
            get { return _roomNumber; }
            set
            {
                _roomNumber = value;
                OnPropertyChanged(nameof(RoomNumber));
            }
        }

        private int _floorNumber;

        public int FloorNumber
        {
            get { return _floorNumber; }
            set
            {
                _floorNumber = value;
                OnPropertyChanged(nameof(FloorNumber));
            }
        }

        private DateTime _startDate;

        public DateTime StartDate
        {
            get { return _startDate; }
            set
            {
                _startDate = value;
                OnPropertyChanged(nameof(StartDate));
            }
        }

        private DateTime _endDate;

        public DateTime EndDate
        {
            get { return _endDate; }
            set
            {
                _endDate = value;
                OnPropertyChanged(nameof(EndDate));
            }
        }

        private readonly NavigationService _navigationService;

        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }

        public MakeReservationViewModel(
            Hotel hotel, 
            NavigationService navigationService)
        {
            _navigationService = navigationService;
            SubmitCommand = new MakeReservationCommand(this, hotel, _navigationService);
            CancelCommand = new NavigateCommand(_navigationService);
        }

    }
}
