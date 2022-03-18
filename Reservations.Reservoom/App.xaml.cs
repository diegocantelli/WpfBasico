using Reservations.Reservoom.Exceptions;
using Reservations.Reservoom.Models;
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

        public App()
        {
            _hotel = new Hotel("Diego Suítes");
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                //Configura o DataContext da MainWindow para apontar para MainViewModel
                DataContext = new MainViewModel(_hotel)
            };

            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
