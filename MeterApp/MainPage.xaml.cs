using System;
using System.Collections.Generic;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MeterApp
{
	public sealed partial class MainPage
	{
		public MainPage()
		{
			InitializeComponent();
			DataContext = new MetersManager();
		}


	    public class MyDataTemplateSelector : DataTemplateSelector
	    {
	        public Dictionary<Type, DataTemplate> TemplateDictionary { get; set; }
	        protected override DataTemplate SelectTemplateCore(object item)
	        {
	            // select datatemplate depending on item type
	            Type itemType = item.GetType();
	            if (!TemplateDictionary.Keys.Contains(itemType))
	            {
	                return null;
	            }
	            return TemplateDictionary[itemType];
	        }

	        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
	        {
	            // select datatemplate depending on item type
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