using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Projet_IHM.Converters
{
    class String2imageConverter : IValueConverter
    {
        private static string imagesPath;

        static String2imageConverter()
        {
            imagesPath = Path.Combine(Directory.GetCurrentDirectory(), "..\\images\\");
        }


        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string imageName = value as string;

            if (string.IsNullOrWhiteSpace(imageName)) return null;

            string imagePath = Path.Combine(imagesPath, imageName);

            return new Uri(imagePath, UriKind.RelativeOrAbsolute);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
