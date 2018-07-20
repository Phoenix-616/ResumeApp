using System;
using System.Collections.Generic;
using System.IO;
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
using Microsoft.Win32;
using Newtonsoft.Json;
using Resume.Models;

namespace Resume
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Worker = new Person();
            InitializeComponent();
        }

        public Person Worker { get; set; }

        private void SaveButtonClick(object sender, RoutedEventArgs e)
        {
            var saveDialog = new SaveFileDialog
            {
                Filter = "JSON файл|*.json",
                Title = "Сохранить резюме"
            };
            saveDialog.ShowDialog();
            if (saveDialog.FileName != "")
            {
                File.WriteAllText(saveDialog.FileName, JsonConvert.SerializeObject(Worker));
            }
        }

        private void LoadButtonClick(object sender, RoutedEventArgs e)
        {
            var loadDialog = new OpenFileDialog
            {
                Filter = "JSON файл|*.json",
                Title = "Загрузить резюме"
            };
            loadDialog.ShowDialog();
            if (loadDialog.FileName != "")
            {
                var tmp = File.ReadAllText(loadDialog.FileName);
                var obj = JsonConvert.DeserializeObject<Person>(tmp);
                Worker.Reload(obj);
            }
        }

        private void GeneratePDF(object sender, RoutedEventArgs e)
        {
            var saveDialog = new SaveFileDialog
            {
                Filter = "PDF файл|*.pdf",
                Title = "Экспортировать резюме в PDF"
            };
            saveDialog.ShowDialog();
            if (saveDialog.FileName != "")
            {
            }
        }
    }
}
