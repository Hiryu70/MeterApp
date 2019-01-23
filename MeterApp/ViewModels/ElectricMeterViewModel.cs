namespace MeterApp.ViewModels
{
    public sealed class ElectricMeterViewModel : BaseMeterViewModel
    {
        public ElectricMeterViewModel()
        {
            Service = ServiceCategory.Electric;
        }

        public int Electricity { get; set; }
    }
}