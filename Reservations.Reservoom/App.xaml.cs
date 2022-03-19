using Microsoft.EntityFrameworkCore;
using Reservations.Reservoom.DbContexts;
using Reservations.Reservoom.Exceptions;
using Reservations.Reservoom.Models;
using Reservations.Reservoom.Stores;
using Reservations.Reservoom.ViewModels;
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
        private readonly Hotel _hotel;
        private readonly NavigationStore _navigationStore;
        private const string CONNECTION_STRING = "Data Source=reservoom.db";

        public App()
        {
            _hotel = new Hotel("Diego Suítes");
            _navigationStore = new NavigationStore();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlite(CONNECTION_STRING).Options;
            using (ReservroomDbContext dbContext = new ReservroomDbContext(options))
            {

                dbContext.Database.Migrate();
            }

            _navigationStore.CurrentViewModel = CreateMakeReservationViewModel();

            MainWindow = new MainWindow()
            {
                //Configura o DataContext da MainWindow para apontar para MainViewModel
                DataContext = new MainViewModel(_navigationStore)
            };

            MainWindow.Show();
            base.OnStartup(e);
        }

        private MakeReservationViewModel CreateMakeReservationViewModel()
        {
            return new MakeReservationViewModel(_hotel, new Services.NavigationService(_navigationStore, CreateReservationViewModel));
        }

        private ReservationListingViewModel CreateReservationViewModel()
        {
            return new ReservationListingViewModel(_hotel, new Services.NavigationService(_navigationStore, CreateMakeReservationViewModel));

        }
    }
}
