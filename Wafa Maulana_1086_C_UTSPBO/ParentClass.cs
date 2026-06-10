using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wafa_Maulana_1086_C_UTSPBO
{
    abstract class TiketBioskop
    {
        private string namaPenonton { get; set; }
        private int idBooking { get; set; }
        private string judulFilm { get; set; }

        public TiketBioskop(string nama, int id, string judul)
        {
            namaPenonton = nama;
            idBooking = id;
            judulFilm = judul;
        }

        public abstract void tambahRiwayat();


        public abstract void cetakRiwayat();


        public abstract double hitungTotalHarga();
        public void tampilInfo()
        {
            Console.WriteLine($"namaPenonton: {namaPenonton} | ID: {idBooking} | Film: {judulFilm} \nTotal: {hitungTotalHarga()}");
        }
    }
}
