namespace MeterApp
{
	public sealed partial class MainPage
	{
		public MainPage()
		{
			InitializeComponent();
			DataContext = new MetersManager();
		}
	}
}