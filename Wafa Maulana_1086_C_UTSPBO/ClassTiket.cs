using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wafa_Maulana_1086_C_UTSPBO
{
    class TiketReguler : TiketBioskop
    {
        private int jumlahTiket { get; set; }
        private double hargaTiket { get; set; }

        private List<RiwayatNonton> daftarRiwayat;

        public TiketReguler(string namaPenonton, int idBooking, string judulFilm, double hargaTiket, int jumlahTiket) : base(namaPenonton, idBooking, judulFilm)
        {
            this.hargaTiket = hargaTiket;
            this.jumlahTiket = jumlahTiket;
        }

        class RiwayatNonton
        {

            public string jenisStudio { get; set; }
            private int jumlahTiket { get; set; }
            private DateTime tanggalNonton { get; set; }

            //Ini Bukan Comman GPT yakk, contoh aja untuk catatan
            public int JumlahTiket
            {
                get => jumlahTiket;
                set => jumlahTiket = value;
            }
            public DateTime TanggalNonton
            {
                get => tanggalNonton;
                set => tanggalNonton = value;
            }

            public RiwayatNonton(string studio, int jumlah, DateTime tanggalNonton)
            {
                this.jenisStudio = studio;
                this.JumlahTiket = jumlah;
                this.tanggalNonton = tanggalNonton;
            }

        }

        public override double hitungTotalHarga()
        {
            return (jumlahTiket * hargaTiket);
        }

        public void tambahRiwayat(int jumlah, DateTime tanggal)
        {
            var riwayat = new RiwayatNonton("Reguler", jumlah, DateTime.Now); // "this" = TiketBioskop ini
            daftarRiwayat.Add(riwayat);
        }

        public void cetakRiwayat()
        {
            this.tampilInfo();
            for (int i = 0; i < daftarRiwayat.Count(); i++)
            {
                RiwayatNonton r = daftarRiwayat[i];
                //Catatan lanjutan tadi ya kak: tanggalNonton Pakai setter -> meski fieldnya private;
                Console.WriteLine($"{i + 1} | {r.jenisStudio} | {r.TanggalNonton}");
            }
        }

    }
    class TiketPremiere : TiketBioskop
    {
        private int jumlahTiket { get; set; }
        private double hargaTiket { get; set; }
        private double biayaLounge { get; set; }

        private List<RiwayatNonton> daftarRiwayat;

        class RiwayatNonton
        {

            public string jenisStudio { get; set; }
            private int jumlahTiket { get; set; }
            private DateTime tanggalNonton { get; set; }

            //Ini Bukan Comman GPT yakk, contoh aja untuk catatan
            public int JumlahTiket
            {
                get => jumlahTiket;
                set => jumlahTiket = value;
            }
            public DateTime TanggalNonton
            {
                get => tanggalNonton;
                set => tanggalNonton = value;
            }

            public RiwayatNonton(string studio, int jumlah, DateTime tanggalNonton)
            {
                this.jenisStudio = studio;
                this.JumlahTiket = jumlah;
                this.tanggalNonton = tanggalNonton;
            }

        }
        public TiketPremiere(string namaPenonton, int idBooking, string judulFilm, double hargaTiket, double biayaLounge, int jumlahTiket) : base(namaPenonton, idBooking, judulFilm)
        {
            this.hargaTiket = hargaTiket;
            this.biayaLounge = biayaLounge;
        }

        public override double hitungTotalHarga()
        {
            return (jumlahTiket * hargaTiket) + biayaLounge;
        }

        public void tambahRiwayat(int jumlah, DateTime tanggal)
        {
            var riwayat = new RiwayatNonton("Premiere", jumlah, DateTime.Now);
            daftarRiwayat.Add(riwayat);
        }


        public void cetakRiwayat()
        {
            this.tampilInfo();
            for (int i = 0; i < daftarRiwayat.Count(); i++)
            {
                RiwayatNonton r = daftarRiwayat[i];
                //Catatan lanjutan tadi ya kak: tanggalNonton Pakai setter -> meski fieldnya private;
                Console.WriteLine($"{i + 1} | { r.jenisStudio } | { r.TanggalNonton}");
            }
        }




    }




}