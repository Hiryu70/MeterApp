using System;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace MeterApp.ViewModels
{
    internal sealed class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel()
        {
            UpdateMetersCommand = new RelayCommand(UpdateMeters);
            UpdateMeters();
        }

        public RelayCommand UpdateMetersCommand { get; }

        public ObservableCollection<BaseMeterViewModel> Meters { get; } = new ObservableCollection<BaseMeterViewModel>();

        private void UpdateMeters()
        {
            Meters.Clear();

            var random = new Random();
            var meter1 = new ElectricMeterViewModel()
            {
                Name = "ElectricMeter1",
                Electricity = random.Next(0, 100)
            };
            Meters.Add(meter1);

            var meter2 = new GasMeterViewModel
            {
                Name = "GasMeter1",
                Gas = random.Next(0, 100)
            };
            Meters.Add(meter2);
        }
    }
}