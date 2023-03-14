using System;

namespace LuasBangunDatar
{
    class Program
    {
        /// <summary>
        /// Void main, merupakan method utama yang bersifat publik yang dapat
        /// diakses dari prosedur atau fungsi manapun dengan syarat semua variabel 
        /// didalam void / prosedur tersebut juga pubic static.
        /// </summary>
        static void Main(string[] args)
        {
            /// Didalam void main terdapat pilihan yang bisa dipilih 
            /// dengan mengetikkan kata yang ingin dipilih. Console.Write 
            /// berfungsi untuk menampilkan tulisan (write)
            Console.Write("Masukkan Pilihan Bangun Ruang (Balok / Limas Segi Empat / Kubus) : ");
            /// string artinya tipe data, yang hanya dimasukkan kata tidak bisa
            /// nomor atau simbol
            string pilih, jawaban;
            /// bool adalah tipe data yang bernilai true atau false
            bool ulang = true;

            /// Setelah kalian mengetikkan salah satu kata yang ingin kalian pilih, 
            /// maka setelah ditekan enter kalian akan diberi tampilan dari method 
            /// yang kalian pilih. Misal kalian oilih balok maka sistem akan 
            /// memanggil method luasbalok
            
            /// kata "pilih" disini bertipe data string yang artinya hanya bisa dimasukkan tulisan
            /// console readline artinya untuk menampilkan output dari apa yang kita masukkan
            /// if else adalah perulangan atau kursor jika kita masukkan kata "Balok" maka sistem
            /// akan memanggil method luasbalok
            pilih = Console.ReadLine();
            if (pilih == "Balok")
            {
                luasbalok();
            }
            else if (pilih == "Limas Segi Empat")
            {
                luaslimassegiempat();
            }
            else if (pilih == "Kubus")
            {
                luaskubus();
            }

            /// Ini merupakan perulangan setelah hasil perhitungan selesai, 
            /// maka akan muncul pertanyaan apakah anda akan mengulang atau tidak. 
            /// Jika anda ketik Y maka sistem akan mengulang, tetapi jika 
            /// anda ketik N maka sistem akan berhenti
            do
            {
                Console.WriteLine("Apakah anda akan mengulang? (Y/N)");
                jawaban = Console.ReadLine();

                if (jawaban != "Y" || jawaban != "y")
                {
                    ulang = false;
                }

            } while (ulang || jawaban.Equals("y") || jawaban.Equals("Y"));
        }
        /// <summary>
        /// Method luasbalok, didalamnya terdapat perhitungan mengenai luas balok.
        /// Anda dapat memasukkan panjang, lebar, tinggi yang ingin kalian hitung maka
        /// sistem akan langsung menampilkan hasil luas dengan rumus balok yang ada.
        /// </summary>
        static void luasbalok()
        {
            string panjang, lebar, tinggi;

            /// beda tidak seperti string, double tipe data yang hanya bisa dimasukkan nomor atau angka
            double p, l, t, luas;

            Console.Write("Masukkan Panjang : ");
            panjang = Console.ReadLine();
            Console.Write("Masukkan Lebar : ");
            lebar = Console.ReadLine();
            Console.Write("Masukkan Tinggi : ");
            tinggi = Console.ReadLine();

            p = int.Parse(panjang);
            l = int.Parse(lebar);
            t = int.Parse(tinggi);

            luas = 2 * (p * l) + (p * t) + (l * t);

            Console.WriteLine("Luas adalah = " + luas);
        }
        /// <summary>
        /// Method luaslimassegiempat, di method ini anda dapat menghitung 
        /// luas limas segi empat dengan memasukkan alas, sisi, tinggi yang 
        /// ingin kalian hitung
        /// </summary>
        static void luaslimassegiempat()
        {
            string alas, sisi, tinggi;
            double a, s, t, luas;

            Console.Write("Masukkan Alas : ");
            alas = Console.ReadLine();
            Console.Write("Masukkan sisi : ");
            sisi = Console.ReadLine();
            Console.Write("Masukkan Tinggi : ");
            tinggi = Console.ReadLine();

            a = int.Parse(alas);
            s = int.Parse(sisi);
            t = int.Parse(tinggi);

            luas = 4 * (0.5 * a * t) + (s * s);

            Console.WriteLine("Luas adalah = " + luas);
        }
        /// <summary>
        /// Method luaskubus, untuk menghitung luas kubus, anda dapat
        /// memasukkan sisi yang ingin kalian hitung
        /// </summary>
        static void luaskubus()
        {
            string sisi;
            double s, luas;

            Console.Write("Masukkan sisi : ");
            sisi = Console.ReadLine();

            s = int.Parse(sisi);

            luas = 6 * s;

            Console.WriteLine("Luas adalah = " + luas);
        }
    }
}