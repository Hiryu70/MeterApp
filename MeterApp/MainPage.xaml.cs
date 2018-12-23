using Windows.UI.Xaml.Controls;

namespace MeterApp
{
	public sealed partial class MainPage : Page
	{
		public MainPage()
		{
			this.InitializeComponent();
			this.DataContext = new MeterControl();
		}
	}
}