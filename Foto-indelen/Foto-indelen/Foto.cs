using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;

namespace Foto_indelen
{
    public class Foto
    {
        private static Regex r = new Regex(":");

        public int AantalFotos(string folder)
        {
            int Aantal=0;


            return Aantal;
        }

        public DateTime DatumGenomen()
        {
            return new DateTime(2000, 1, 1, 1, 1, 1);
        }

        public static DateTime GetDateTakenFromImage(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (Image myImage = Image.FromStream(fs, false, false))
            {
                PropertyItem propItem = myImage.GetPropertyItem(36867);
                string dateTaken = r.Replace(Encoding.UTF8.GetString(propItem.Value), "-", 2);
                return DateTime.Parse(dateTaken);
            }
        }

    }
}
