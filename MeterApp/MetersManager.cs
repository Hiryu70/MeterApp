using GalaSoft.MvvmLight.Command;
using System.Collections.Generic;

namespace MeterApp
{
	class MetersManager
	{
		public MetersManager()
		{
			UpdateMetersCommand = new RelayCommand(UpdateMeters);
		}

		public RelayCommand UpdateMetersCommand { get; set; }

		public List<MeterVm> Meters { get; set; } = new List<MeterVm>();

		private void UpdateMeters()
		{
			Meters.Clear();

			MeterVm meter1 = new MeterVm();
			meter1.Name = "Meter1";
			meter1.DeviceType = DeviceType.Zigbee;
			meter1.Service = ServiceCategory.Electric;
			Meters.Add(meter1);

			MeterVm meter2 = new MeterVm();
			meter2.Name = "Meter2";
			meter2.DeviceType = DeviceType.Gsm;
			meter2.Service = ServiceCategory.Water;
			Meters.Add(meter2);
		}
	}
}
