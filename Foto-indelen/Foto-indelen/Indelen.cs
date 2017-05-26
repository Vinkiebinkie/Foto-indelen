using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Foto_indelen
{

    

    public class Indelen
    {
        private static Regex r = new Regex(":");
        public string LeesFolder;    //Folder waarvan gelezen wordt
        public string SchrijfFolder; //Folder waarnaar geschreven wordt
        private string LeesBestand; //bestand wat verwerkt wordt
        public DateTime Vanaf;  //datum vanaf
        public DateTime Tot;    //Datum tot
        public bool jpg, mp4;
        public bool go (string[] bestanden, ProgressBar progressbar)   //indelen van de foto's
        {
            progressbar.Maximum = bestanden.Length;
            foreach (var item in bestanden)
            {

                haalLeesBestand(item.ToString());
                string extension = Path.GetExtension(LeesBestand); //Extensie van het bestand ophalen
                if (extension == ".jpg" && jpg)
                {
                    string SchrijfBestand = SchrijfFolder.ToString() + LeesBestand;
                    CheckFoto((LeesFolder + LeesBestand), SchrijfBestand);
                }
                else if (extension == ".mp4" && mp4)
                {
                    string SchrijfBestand = SchrijfFolder.ToString() + LeesBestand;
                    CheckVideo((LeesFolder + LeesBestand), SchrijfBestand);
                }
                progressbar.Value++;
            }
            progressbar.Value = 0;
            return true;
        }

        public void CheckFoto (string LeesBestand, string SchrijfBestand) //kijken of datum tijd van foto in range valt en indien nodig kopieeren
        {
            DateTime DateTaken = (GetDateCreatedFromFile(LeesBestand));
            if ((DateTaken > Vanaf) && (DateTaken < Tot))
            {
                System.IO.File.Copy(LeesBestand, SchrijfBestand, true);
            }
        }

        public void CheckVideo (string LeesBestand, string SchrijfBestand)
        {
            DateTime DateTaken = (GetDateCreatedFromFile(LeesBestand));
            if ((DateTaken> Vanaf ) && (DateTaken < Tot))
            {
                System.IO.File.Copy(LeesBestand, SchrijfBestand,true);
            }
        }
        
        public static DateTime GetDateTakenFromImage(string path) //datum en tijd van foto ophalen
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (Image myImage = Image.FromStream(fs, false, false))
            {
                try
                {
                    PropertyItem propItem = myImage.GetPropertyItem(36867);
                    string dateTaken = r.Replace(Encoding.UTF8.GetString(propItem.Value), "-", 2);
                    
                    return DateTime.Parse(dateTaken);
                }
                catch (Exception e)
                {
                    Console.WriteLine("{0} : {1}", e.GetType().Name, e.Message);
                    return new DateTime(1, 1, 1);
                }

            }
        }

        public static DateTime GetDateCreatedFromFile(string path)
        {
            return System.IO.File.GetLastWriteTime(path);
        }

        private void haalLeesBestand (string Bestand)   //lees bestand scheiden van leespath
        {
            int index, length;

            length = Bestand.Length;
            index= Bestand.LastIndexOf("\\");

            LeesBestand = Bestand.Substring(index, length - index);
        }

    }
}
