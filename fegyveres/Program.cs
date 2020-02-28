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
            Felpakol(fegyvertár); //Az összes fegyvert berakja a fegyvertárba és feltölti a fegyvertárat
            Listázó(fegyvertár); //Kiírja a képernyőre aktuálisan milyen fegyvereink vannak és a bennük lévő töltények számát
            Console.WriteLine($"{FegyverSzám(fegyvertár)} db fegyver van a tárban.\n");
            Kivesz(fegyvertár); //Egy fegyvert kivesz a fegyvertárból
            Felvesz(fegyvertár, fegyverek.Puska); //Egy fegyvert berak a tár végére
            //Kiürít(fegyvertár); //Kiürítí a fegyvertárat
            int dbt = Csekkol(fegyvertár, fegyverek.Ágyú); //Egy adott fegyverben hány töltény van
            Console.WriteLine($"A(z) ágyúban {dbt} db töltény van.");

            Console.ReadKey();
        }

        static int Csekkol(List<Fegyver> fegyvertár, fegyverek aktFegyver)
        {
            int i = 0;
            while (fegyvertár[i].név!=aktFegyver)
            {
                i++;
            }
            int db = fegyvertár[i].töltény;
            return db;
        }

        static int FegyverSzám(List<Fegyver> fegyvertár)
        {
            return fegyvertár.Count;
        }

        static void Felvesz(List<Fegyver> fegyvertár, fegyverek fegy)
        {
            bool van = false;
            int i = 0;
            foreach (Fegyver f in fegyvertár)
            {
                if (f.név==fegy)
                {
                    van = true;
                    break;
                }
                i++;
            }
            Fegyver akt = fegyvertár[i];
            if (van)
            {
                switch (fegyvertár[i].név)
                {
                    case fegyverek.Pisztoly:
                        akt.töltény = MaxPisztoly;
                        break;
                    case fegyverek.Puska:
                        akt.töltény = MaxPuska;
                        break;
                    case fegyverek.Ágyú:
                        akt.töltény = MaxÁgyú;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Fegyver újfegyver = new Fegyver();
                újfegyver.név = fegy;
                switch (újfegyver.név)
                {
                    case fegyverek.Pisztoly:
                        újfegyver.töltény = MaxPisztoly;
                        break;
                    case fegyverek.Puska:
                        újfegyver.töltény = MaxPuska;
                        break;
                    case fegyverek.Ágyú:
                        újfegyver.töltény = MaxÁgyú;
                        break;
                    default:
                        break;
                }
                fegyvertár.Add(újfegyver);
            }
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
