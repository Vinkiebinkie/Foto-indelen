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
    public class Fotos
    {
        

        public static string[] HaalFotos(string folder)
        {
            return Directory.GetFiles(folder);
        }

        public static int AantalFotos(string[] bestanden)
        {
            int Aantal = 0;   
            foreach (var item in bestanden)
            {
                
                if (bestanden.Contains("IMG")) 
                {
                    Aantal++;
                  //  Console.WriteLine(item.ToString());
                }
                
            }
            return Aantal;
        }

        public DateTime DatumGenomen()
        {
            return new DateTime(2000, 1, 1, 1, 1, 1);
        }



    }
}
