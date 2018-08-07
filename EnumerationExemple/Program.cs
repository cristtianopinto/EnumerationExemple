using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationExemple
{
    public enum JourSemaine
    {
        lundi = 1,
        Mardi = 2,
        Mercredi = 3,
        Jeudi = 4,
        Vendredi = 5,
        Samedi = 6,
        Dimanche = 7,
    }
    public class Evenement
    {
        public JourSemaine Jour { get; set; } 
    }
    class Program
    {
        public static int  SaisierEntier(string Message)
        {
            Console.WriteLine(Message);
            int i;
            bool CaMarche;
            CaMarche = int.TryParse (Console.ReadLine(),out i); // LE BON METHODE
            while (!CaMarche)
            {
                Console.WriteLine("Tapez un nombre!");
                CaMarche = int.TryParse(Console.ReadLine(), out i);
            }
            return i;
        }
        static void Main(string[] args)
        {
            var even = new Evenement();
            even.Jour = (JourSemaine)2;
            Console.WriteLine(even.Jour);
            
            try
            {


                var entier1 = SaisierEntier("Nombre 1:");
                Console.WriteLine("Nombre2 :");
                var entier2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Bravo...");

                var division = entier1/ entier2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Vous ne pouvez pas faire division par 0");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Euh..."+ex.Message);

                //throw ex;//ENTENDER
            }
            

            Console.ReadKey();
        }
    }
}
