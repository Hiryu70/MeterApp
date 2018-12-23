using GalaSoft.MvvmLight.Command;
using System.Collections.Generic;

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

		public string Title { get; set; } = "Счетчики";

		public List<MeterVm> Meters { get; set; } = new List<MeterVm>();

		private void UpdateMeters()
		{
			Meters.Clear();

			var meter1 = new MeterVm
			{
				Name = "Meter1",
				DeviceType = DeviceType.Zigbee,
				Service = ServiceCategory.Electric
			};
			Meters.Add(meter1);

			var meter2 = new MeterVm
			{
				Name = "Meter2",
				DeviceType = DeviceType.Gsm,
				Service = ServiceCategory.Water
			};
			Meters.Add(meter2);
		}
	}
}