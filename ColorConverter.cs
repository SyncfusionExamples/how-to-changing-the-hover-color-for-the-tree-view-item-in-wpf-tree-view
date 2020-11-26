using Syncfusion.UI.Xaml.TreeView.Engine;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace WpfApp1
{
    public class ExpanderTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var treeViewNode = item as TreeViewNode;
            if (treeViewNode != null && treeViewNode.Level == 0)
                return Application.Current.MainWindow.FindResource("expanderTemplate2") as DataTemplate;
            else
                return Application.Current.MainWindow.FindResource("expanderTemplate1") as DataTemplate;
        }
    }

    public class ColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is Color)) return null;

            var color = (Color)value;

            var solidColorBrush = new SolidColorBrush(color);

            return solidColorBrush;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    internal class FlowDirectionConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)value)
                return FlowDirection.RightToLeft;
            return FlowDirection.LeftToRight;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
