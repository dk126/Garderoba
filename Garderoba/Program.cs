using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garderoba
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Start());
            List<T> listaNaSpecjalnąOkazjęLato = new List<T>();
            List<T> listaNaSpecjalnąOkazjęZima = new List<T>();
            List<T> listaNaCodzieńLato = new List<T>();
            List<T> listaNaCodzieńZima = new List<T>();

            Dół spodnie1 = new Dół(true, false, @"C: \Users\dkule\Dropbox\Projekt\Zdjęcia_ubrań\Spodnie_czarne.jpg");
            Dół spodniczkajeansowa = new Dół(false, true, @"C:\Users\dkule\Dropbox\Projekt\Zdjęcia_ubrań\Spódniczka_jeansowa.jpg");
            Góra bluzka1 = new Góra(false, true, @"C:\Users\dkule\Dropbox\Projekt\Zdjęcia_ubrań\Bluzka_w_kropki.jpg");
            Sukienka sukienka1 = new Sukienka(true, @"C:\Users\dkule\Dropbox\Projekt\Zdjęcia_ubrań\Sukienka_w_kwiaty.jpg");
            
        }
    }
}
