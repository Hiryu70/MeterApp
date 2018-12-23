namespace MeterApp
{
	public sealed class MeterVm
	{
		public string Name { get; set; }

		public ServiceCategory Service { get; set; }

		public DeviceType DeviceType { get; set; }
	}

	public enum ServiceCategory
	{
		Electric,
		Water
	}

	public enum DeviceType
	{
		Zigbee,
		Gsm
	}
}