using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeterApp
{
	public class MeterVm
	{
		public string Name { get; set; }

		public ServiceCategory Service { get; set; }

		public DeviceType DeviceType { get; set; }

		
	}

	public enum ServiceCategory
	{
		Electric,
		Water,
		Gas
	}

	public enum DeviceType
	{
		Zigbee,
		Gsm
	}
}