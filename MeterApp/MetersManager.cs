using GalaSoft.MvvmLight.Command;
using System.Collections.Generic;
using MeterApp.ViewModels;

namespace MeterApp
{
	internal sealed class MetersManager
	{
		public MetersManager()
		{
			UpdateMetersCommand = new RelayCommand(UpdateMeters);
			UpdateMeters();
		}

		public RelayCommand UpdateMetersCommand { get; set; }

		public string Title { get; set; } = "Meters";

		public List<BaseMeterViewModel> Meters { get; set; } = new List<BaseMeterViewModel>();

		private void UpdateMeters()
		{
			Meters.Clear();

			var meter1 = new ElectricMeterViewModel()
			{
				Name = "ElectricMeter1",
			};
			Meters.Add(meter1);

			var meter2 = new GasMeterViewModel
			{
				Name = "GasMeter1",
			};
			Meters.Add(meter2);
		}
	}
}