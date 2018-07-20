using System;
using System.Collections.Generic;
using System.Linq;
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
using Resume.Models;

namespace Resume.EditableViews
{
    /// <summary>
    /// Interaction logic for EducationView.xaml
    /// </summary>
    public partial class EducationView : UserControl
    {
        public EducationView()
        {
            InitializeComponent();
        }

        public List<Education> Educations
        {
            get => (List<Education>) GetValue(EducationsProperty);
            set => SetValue(EducationsProperty, value);
        }

        public DependencyProperty EducationsProperty = DependencyProperty.Register("Educations", typeof(List<Education>), typeof(EducationView));

        private void DelButtonClick(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.DataContext is Education ed)
            {
                Educations.Remove(ed);
            }
        }

        private void AddButtonClick(object sender, RoutedEventArgs e)
        {
            Educations.Add(new Education());
        }
    }
}
