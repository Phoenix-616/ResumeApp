using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Resume
{
    public class PDFManager
    {
        public static void SaveImg2PDF(System.Drawing.Image image, string File)
        {
            Document doc = new Document(PageSize.A4, 0, 0, 0, 0);
            using (var fs = new FileStream(File, FileMode.Create))
            {
                PdfWriter.GetInstance(doc, fs);
                doc.Open();
                iTextSharp.text.Image pic = iTextSharp.text.Image.GetInstance(image, System.Drawing.Imaging.ImageFormat.Png);
                pic.ScaleAbsolute(PageSize.A4);
                doc.Add(pic);
                doc.Close();
            }
        }
    }
}
