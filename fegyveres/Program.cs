using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fegyveres
{
    class Program
    {
        enum fegyverek {Pisztoly, Puska, Ágyú};
        struct Fegyver
        {
            public fegyverek név;
            public int töltény;

        }
        const int MaxPisztoly = 100;
        const int MaxPuska = 30;
        const int MaxÁgyú = 5;
        static void Main(string[] args)
        {
            List<Fegyver> fegyvertár = new List<Fegyver>();
            //Egy fegyvert csak egy példányban tárolhatunk
            int db = FegyverSzám(fegyvertár);
            Felpakol(fegyvertár); //Az összes fegyvert berakja a fegyvertárba és feltölti a fegyvertárat
            Listázó(fegyvertár); //Kiírja a képernyőre aktuálisan milyen fegyvereink vannak és a bennük lévő töltények számát
            Console.WriteLine($"{FegyverSzám(fegyvertár)} db fegyver van a tárban.\n");
            Kivesz(fegyvertár); //Egy fegyvert kivesz a fegyvertárból
            Listázó(fegyvertár);
            Console.WriteLine($"{FegyverSzám(fegyvertár)} db fegyver van a tárban.\n");
            Felvesz(fegyvertár); //Egy fegyvert berak a tár végére
            Listázó(fegyvertár);
            Console.WriteLine($"{FegyverSzám(fegyvertár)} db fegyver van a tárban.\n");
            Kiürít(fegyvertár); //Kiürítí a fegyvertárat
            Listázó(fegyvertár);
            Console.WriteLine($"{FegyverSzám(fegyvertár)} db fegyver van a tárban.\n");
            int db = Csekkol(fegyvertár); //Egy adott fegyverben hány töltény van

            Console.ReadKey();
        }

        static int FegyverSzám(List<Fegyver> fegyvertár)
        {
            return fegyvertár.Count;
        }

        static void Felvesz(List<Fegyver> fegyvertár)
        {
            
        }

        static void Listázó(List<Fegyver> fegyvertár)
        {
            foreach (Fegyver f in fegyvertár)
            {
                Console.WriteLine($"{f.név}: {f.töltény}");
            }
            
        }

        static void Kivesz(List<Fegyver> fegyvertár)
        {

        }

        static void Kiürít(List<Fegyver> fegyvertár)
        {
            
        }

        static void Felpakol(List<Fegyver> fegyvertár)
        {
            Fegyver énPisztoly = new Fegyver();
            énPisztoly.név = fegyverek.Pisztoly;
            énPisztoly.töltény = MaxPisztoly;
            fegyvertár.Add(énPisztoly);

            Fegyver énPuska = new Fegyver();
            énPuska.név = fegyverek.Puska;
            énPuska.töltény = MaxPuska;
            fegyvertár.Add(énPuska);

            Fegyver énÁgyú = new Fegyver();
            énÁgyú.név = fegyverek.Ágyú;
            énÁgyú.töltény = MaxÁgyú;
            fegyvertár.Add(énÁgyú);

        }
    }
}
