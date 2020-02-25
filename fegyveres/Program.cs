using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fegyveres
{
    class Program
    {
        enum fegyverek {ApaÖkle, Uzi, M4, AK47, LángSzóró, KéziGránát};
        static void Main(string[] args)
        {
            List<fegyverek> fegyvertár = new List<fegyverek>();
            //Egy fegyvert csak egy példányban tárolhatunk
            int db = FegyverSzám(fegyvertár);
            Felpakol(fegyvertár); //Az összes fegyvert berakja a fegyvertárba
            Listázó(fegyvertár); //Kiírja a képernyőre aktuálisan milyen fegyvereink vannak
            Console.WriteLine($"{FegyverSzám(fegyvertár)} db fegyver van a tárban.\n");
            Kivesz(fegyvertár); //Egy fegyvert kivesz a fegyvertárból
            Listázó(fegyvertár);
            Console.WriteLine($"{FegyverSzám(fegyvertár)} db fegyver van a tárban.\n");
            Felvesz(fegyvertár, fegyverek.LángSzóró); //Egy fegyvert berak a tár végére
            Listázó(fegyvertár);
            Console.WriteLine($"{FegyverSzám(fegyvertár)} db fegyver van a tárban.\n");
            Felvesz2(fegyvertár); //Egy fegyvert berak egy meghatározott helyre
            Listázó(fegyvertár);
            Console.WriteLine($"{FegyverSzám(fegyvertár)} db fegyver van a tárban.\n");
            /*Kiürít(fegyvertár); //Kiürítí a fegyvertárat
            Listázó(fegyvertár);
            Console.WriteLine(FegyverSzám);*/
            /*HashSet<int> lottószámok = new HashSet<int>();
            Random rnd = new Random();
            while (lottószámok.Count<5)
            {
                int lottószám = rnd.Next(1, 91);
                lottószámok.Add(lottószám);
            }
            List<int> rendezett = lottószámok.ToList();
            rendezett.Sort();
            Console.WriteLine("A lottószámok: ");
            foreach (int szám in rendezett)
            {
                Console.Write($"{szám} ");
            }*/

            Console.ReadKey();
        }

        static int FegyverSzám(List<fegyverek> fegyvertár)
        {
            return fegyvertár.Count;
        }

        static void Felvesz2(List<fegyverek> fegyvertár)
        {
            fegyvertár.Insert(2, fegyverek.AK47);
        }

        static void Felvesz(List<fegyverek> fegyvertár, fegyverek LángSzóró)
        {
            if (!fegyvertár.Contains(fegyverek.LángSzóró))
            {
                fegyvertár.Add(fegyverek.LángSzóró);
            }
        }

        static void Listázó(List<fegyverek> fegyvertár)
        {
            Console.WriteLine("A tárban lévő fegyverek: ");
            foreach (fegyverek fegyver in fegyvertár)
            {
                Console.WriteLine(fegyver);
            }
        }

        static void Kivesz(List<fegyverek> fegyvertár)
        {
            fegyvertár.Remove(fegyverek.LángSzóró);
            fegyvertár.Remove(fegyverek.AK47);
        }

        /*static void Kiürít(List<fegyverek> fegyvertár)
        {
            fegyvertár.Remove(fegyverek.AK47);
            fegyvertár.Remove(fegyverek.ApaÖkle);
            fegyvertár.Remove(fegyverek.Uzi);
            fegyvertár.Remove(fegyverek.M4);
            fegyvertár.Remove(fegyverek.LángSzóró);
            fegyvertár.Remove(fegyverek.KéziGránát);
        }*/

        static void Felpakol(List<fegyverek> fegyvertár)
        {
            fegyvertár.Add(fegyverek.AK47);
            fegyvertár.Add(fegyverek.ApaÖkle);
            fegyvertár.Add(fegyverek.Uzi);
            fegyvertár.Add(fegyverek.M4);
            fegyvertár.Add(fegyverek.LángSzóró);
            fegyvertár.Add(fegyverek.KéziGránát);
        }
    }
}
