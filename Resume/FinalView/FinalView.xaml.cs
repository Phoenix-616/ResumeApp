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
using System.Windows.Shapes;
using Microsoft.Win32;
using Newtonsoft.Json;
using Resume.Models;

namespace Resume.FinalView
{
    /// <summary>
    /// Interaction logic for FinalView.xaml
    /// </summary>
    public partial class FinalView : Window
    {
        public FinalView(Person worker)
        {
            Worker = worker;
            InitializeComponent();
        }

        public Person Worker { get; set; }

        private void GeneratePDF(object sender, RoutedEventArgs e)
        {
            //Вот поэтому я и иду на стажера :)
            var mul = 1;
            var h = (int) (Final.Height * mul);
            var w = (int) (Final.Width * mul);
            var bitmap = new RenderTargetBitmap(w, h, 96 * mul, 96 * mul, PixelFormats.Pbgra32);
            bitmap.Render(Final);
            PngBitmapEncoder image = new PngBitmapEncoder();
            image.Frames.Add(BitmapFrame.Create(bitmap));
            System.Drawing.Image imgOut;
            using (var fs = new MemoryStream())
            {
                image.Save(fs);
                imgOut = System.Drawing.Image.FromStream(fs);
            }
            var saveDialog = new SaveFileDialog
            {
                Filter = "PDF файл|*.pdf",
                Title = "Сохранить резюме"
            };
            saveDialog.ShowDialog();
            if (saveDialog.FileName != "")
            {
                PDFManager.SaveImg2PDF(imgOut, saveDialog.FileName);
                
            }
        }
    }
}
