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

    

    public class Indelen
    {
        private static Regex r = new Regex(":");
        public string LeesFolder;    //Folder waarvan gelezen wordt
        public string SchrijfFolder; //Folder waarnaar geschreven wordt
        private string LeesBestand;
        public DateTime Vanaf;  //datum vanaf
        public DateTime Tot;    //Datum tot
        public bool go (string[] bestanden)   //indelen van de foto's
        {
            foreach (var item in bestanden)
            {

                haalLeesBestand(item.ToString());
                string extension = Path.GetExtension(LeesBestand);
                if (extension == ".jpg")
                {
                    string SchrijfBestand = SchrijfFolder.ToString() + LeesBestand;
                    CheckFoto((LeesFolder + LeesBestand), SchrijfBestand);
                }

            }
            return true;
        }

        public void CheckFoto (string LeesBestand, string SchrijfBestand)
        {
            DateTime DateTaken = (GetDateTakenFromImage(LeesBestand));
            if ((DateTaken > Vanaf) && (DateTaken < Tot))
            {
                System.IO.File.Copy(LeesBestand, SchrijfBestand);
            }
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

        private void haalLeesBestand (string Bestand)
        {
            int index, length;

            length = Bestand.Length;
            index= Bestand.LastIndexOf("\\");

            LeesBestand = Bestand.Substring(index, length - index);
        }

    }
}
