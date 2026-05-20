using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wafa_Maulana_1086_C_UTSPBO
{
    abstract class TiketBioskop
    {
        private int jumlahTiket { get; set; }
        private string namaPenonton { get; set;}
        private int idBooking { get; set; }
        private string judulFilm { get; set; }

        public double total { get; set; }
        public string getJumlah()
        {
            return $"{jumlahTiket}";
        }

        public void setJumlah(int jumlah)
        {
            jumlahTiket = jumlah;
        }
        public string getNama()
        {
            return namaPenonton;
        }
        public void setNama(string nama)
        {
            namaPenonton = nama;
        }
        public int getId()
        {
            return idBooking;
        }
        public void setId(int id)
        {
            idBooking = id;
        }
        public string getJudul()
        {
            return judulFilm;
        }
        public void setJudul(string judul)
        {
            judulFilm = judul;
        }
        public double getTotal()
        {
            return total;
        }
        public abstract void TampilInfo();

        public abstract string HitungTotalHarga();
    }

    class TiketReguler : TiketBioskop
    {
        public int jumlahTiket;
        public RiwayatNonton[] riwayats;
        public string studio = "Reguler";
        private double hargaTiket;

      
        public double getHarga()
        {
            return hargaTiket;
        }
        public void setHarga(double harga)
        {
            hargaTiket = harga;
        }

        public TiketReguler(string namaPenonton, int idBooking, string judulFilm, double hargaTiket, int jumlahPenonton)
        {
            setNama(namaPenonton);
            setId(idBooking);
            setJudul(judulFilm);
            setHarga(hargaTiket);
            setJumlah(jumlahPenonton);
        }


        public override string HitungTotalHarga()
        {
            total = hargaTiket * jumlahTiket;
            return $"Total {total}";
        }
        public override void TampilInfo()
        {
            Console.WriteLine($"Nama: {getNama()} | ID: {getId()} | Film: {getJudul()} | Harga: {getHarga()}");
        }
    }
    class TiketPremiere : TiketBioskop
    {
        public string studio = "Premiere";
        private double hargaTiket;
        private double biayaLounge;
        public int jumlahTiket;

        public double getHarga()
        {
            return hargaTiket;
        }
        public void setHarga(double harga)
        {
            hargaTiket = harga;
        }

        public double getLounge()
        {
            return biayaLounge;
        }
        public void setLounge(double harga)
        {
            biayaLounge = harga;
        }



        public TiketPremiere(string namaPenonton, int idBooking, string judulFilm, double hargaTiket, double biayaLounge, int jumlahPenonton)
        {
            setNama(namaPenonton);
            setId(idBooking);
            setJudul(judulFilm);
            setHarga(hargaTiket);
            setLounge(biayaLounge);
            setJumlah(jumlahPenonton);
        }

        public override string HitungTotalHarga()
        {
            total = hargaTiket * jumlahTiket + biayaLounge;
            return $"{total}";
        }
        public override void TampilInfo()
        {
            Console.WriteLine($"Nama: {getNama()} | ID: {getId()} | Film: {getJudul()} | Harga: {getHarga()} | Lounge: {getLounge()}");
        }

    
    }

    class RiwayatNonton
    {
        public TiketBioskop[] riwayats;
        private string jenisStudio { get; set; }
        private DateTime tanggalNonton;

        public string getStudio()
        {
            return jenisStudio;
        }
        public void setStudio(string studio)
        {
            jenisStudio = studio;
        }

        public RiwayatNonton(string studio, DateTime date)
        {

            setStudio(studio);
            jenisStudio = studio;
            tanggalNonton = date;
        }

        public void tambahRiwayat(TiketBioskop riwayat)
        {
            riwayats.Append(riwayat);
        }
        public void cetakRiwayat()
        {
            Console.WriteLine("ListTiket");
            foreach (var item in riwayats)
            {
                Console.WriteLine($"Nama: {item.getNama()} | ID: {item.getId()} | Film: {item.getJudul()} \n" +
                    $"Total: {item.HitungTotalHarga()}");
                Console.WriteLine($"{getStudio()} | {item.getJumlah()} | {tanggalNonton}");
            }
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
