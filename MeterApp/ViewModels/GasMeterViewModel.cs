namespace MeterApp.ViewModels
{
    public sealed class GasMeterViewModel : BaseMeterViewModel
    {
        public GasMeterViewModel()
        {
            Service = ServiceCategory.Gas;
        }

        public int Gas { get; set; }
    }
}