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
            fegyverek kezemben = fegyverek.KéziGránát;
            List<fegyverek> fegyvertár = new List<fegyverek>();

            fegyvertár.Add(fegyverek.Uzi);
            fegyvertár.Add(fegyverek.LángSzóró);

            Console.WriteLine("Fegyverek a tárban: ");
            foreach (fegyverek fegyver in fegyvertár)
            {
                Console.WriteLine(fegyver);
            }

            Console.ReadKey();
        }
    }
}
