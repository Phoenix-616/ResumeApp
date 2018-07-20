using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using Resume.Models;

namespace Resume.FinalView.FinalViewControls.Converter
{
    class CompleteConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool val)
            {
                return val ? "Оконченное" : "Неоконченное";
            }
            if (value is AcDegree deg)
            {
                switch (deg)
                {
                    case AcDegree.None:
                        return "Без степени";
                    case AcDegree.Bachelor:
                        return "Бакалавр";
                    case AcDegree.Master:
                        return "Магистр";
                    case AcDegree.PhD:
                        return "Кандидат наук";
                    case AcDegree.Doctor:
                        return "Доктор наук";
                }
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
