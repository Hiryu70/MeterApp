using System;
using System.Collections.Generic;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using MeterApp.ViewModels;

namespace MeterApp
{
	public sealed partial class MainPage
	{
		public MainPage()
		{
			InitializeComponent();
		    InitializeControl();
		}

	    private void InitializeControl()
	    {
            //var myDataTemplateSeletor = new MyDataTemplateSelector
            //{
            //    TemplateDictionary = new Dictionary<Type, DataTemplate>
            //    {
            //        {typeof(BaseMeterViewModel), ElectricTemplate},
            //        {typeof(ElectricMeterViewModel), ElectricTemplate},
            //        {typeof(GasMeterViewModel), GasTemplate}
            //    }
            //};

            //MetersGridView.ItemTemplateSelector = myDataTemplateSeletor;

            DataContext = new MainPageViewModel();
        }


        public sealed class MyDataTemplateSelector : DataTemplateSelector
        {
            public Dictionary<Type, DataTemplate> TemplateDictionary { get; set; }
            protected override DataTemplate SelectTemplateCore(object item)
            {
                Type itemType = item.GetType();
                if (!TemplateDictionary.Keys.Contains(itemType))
                {
                    return null;
                }
                return TemplateDictionary[itemType];
            }

            protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
            {
                Type itemType = item.GetType();
                if (!TemplateDictionary.Keys.Contains(itemType))
                {
                    return null;
                }
                return TemplateDictionary[itemType];
            }
        }
    }
}