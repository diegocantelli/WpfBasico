using Reservations.Reservoom.Exceptions;
using Reservations.Reservoom.Models;
using Reservations.Reservoom.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Reservations.Reservoom.Commands
{
    public class MakeReservationCommand : CommandBase
    {
        private readonly Hotel _hotel;
        private readonly MakeReservationViewModel _makeReservationViewModel;

        public MakeReservationCommand(MakeReservationViewModel makeReservationViewModel, Hotel hotel)
        {
            _hotel = hotel;
            _makeReservationViewModel = makeReservationViewModel;
            _makeReservationViewModel.PropertyChanged += OnViewModelPropertyChanged;
        }

        //Necessário este evento para poder alterar o estado do botão em tempo real conforme o conteúdo do campo UserName
        private void OnViewModelPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if(e.PropertyName == nameof(MakeReservationViewModel.UserName))
            {
                OnCanExecutedChanged();
            }
        }

        //Aqui é implementada a regra se o botão deve ser habilitado ou não
        public override bool CanExecute(object parameter)
        {
            return !string.IsNullOrEmpty(_makeReservationViewModel.UserName) && base.CanExecute(parameter);
        }
        public override void Execute(object parameter)
        {
            var reservation = new Reservation(
                new RoomID(_makeReservationViewModel.FloorNumber, _makeReservationViewModel.RoomNumber),
                _makeReservationViewModel.StartDate,
                _makeReservationViewModel.EndDate,
                _makeReservationViewModel.UserName
                );

            try
            {
                _hotel.MakeReservation(reservation);
                MessageBox.Show("Reserva efetuada com sucesso!", 
                    "Success",MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (ReservationConflictException ex)
            {
                MessageBox.Show("Não foi possível efetuar a reserva. Reserva já efetuada anteriormente.",
                    "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
