using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wafa_Maulana_1086_C_UTSPBO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TiketBioskop tiketReguler = new TiketReguler("Wafa Maulana", 2, "Ophenheimer", 20.000, 3);
            TiketBioskop tiketReguler2 = new TiketReguler("Wafa Maulana", 3, "Ophenheimer 2", 20.000, 1);
            TiketBioskop tiketPremiere = new TiketPremiere("Mantamana", 2, "Eveything at once", 25.000, 11.000, 4);

            tiketPremiere.tambahRiwayat();
            tiketReguler.tambahRiwayat();

            tiketPremiere.tambahRiwayat();
        }
    }
}
