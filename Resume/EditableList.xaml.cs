using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Resume
{
    /// <summary>
    /// Interaction logic for EditableList.xaml
    /// </summary>
    public partial class EditableList : UserControl
    {
        public EditableList()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty ItemsSourceProperty = ItemsControl.ItemsSourceProperty.AddOwner(typeof(EditableList));
        public IEnumerable ItemsSource
        {
            get => (IEnumerable)GetValue(ItemsSourceProperty);
            set => SetValue(ItemsSourceProperty, value);
        }

        private void DelButtonClick(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                var addMethod = ItemsSource.GetType().GetMethod("Remove");
                addMethod?.Invoke(ItemsSource, new[] { button.DataContext });
            }
        }

        private void AddButtonClick(object sender, RoutedEventArgs e)
        {
            if (sender is Button)
            {
                var type = ItemsList.ItemsSource.GetType().GenericTypeArguments[0];
                var addMethod = ItemsSource.GetType().GetMethod("Add");
                if (type == typeof(string))
                {
                    addMethod?.Invoke(ItemsSource, new[] { "" });
                }
                else
                {
                    addMethod?.Invoke(ItemsSource, new[] { Activator.CreateInstance(type) });
                }
            }
        }

        private void UpButtonClick(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                var indexOfMethod = ItemsSource.GetType().GetMethod("IndexOf");
                int? tmp = indexOfMethod?.Invoke(ItemsSource, new[] { button.DataContext }) as int?;
                var moveMethod = ItemsSource.GetType().GetMethod("Move");
                if (tmp != null && tmp > 0) moveMethod?.Invoke(ItemsSource, new object[] { tmp, tmp - 1 });
            }
        }

        private void DownButtonClick(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                var indexOfMethod = ItemsSource.GetType().GetMethod("IndexOf");
                int? tmp = indexOfMethod?.Invoke(ItemsSource, new[] { button.DataContext }) as int?;
                var prop = ItemsSource.GetType().GetProperty("Count", BindingFlags.Public | BindingFlags.Instance);
                var moveMethod = ItemsSource.GetType().GetMethod("Move");
                if (tmp != null && prop != null && tmp < (int)prop.GetValue(ItemsSource) - 1) moveMethod?.Invoke(ItemsSource, new object[] { tmp, tmp + 1 });
            }
        }
    }
}
