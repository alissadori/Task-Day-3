using System;

namespace Task_Day_3
{

    internal class Program
    {
        public void Shopee()
        {
            int belanja = 0, diskonOngkir = 0, diskonBelanja = 0, total = 0, ongkir, pilih ;
            Console.Clear();

            Console.WriteLine("***** PROMO VOUCHER SHOPEE *****");
            Console.WriteLine("1. Min order 30rb free ongkir 5rb potongan harga belanja 5rb");
            Console.WriteLine("2. Min order 50rb free ongkir 10rb potongan harga belanja 10rb");
            Console.WriteLine("3. Min order 100rb free ongkir 20rb potongan harga belanja 10rb");
            Console.WriteLine();

            Console.Write("Masukkan belanja      = "); belanja = int.Parse(Console.ReadLine());
            Console.Write("Masukkan Ongkos Kirim = "); ongkir = int.Parse(Console.ReadLine());
            Console.Write("Pilih voucher         = "); pilih = int.Parse(Console.ReadLine());


            if (belanja < 30000)
            {
                total = belanja + ongkir;
                Console.WriteLine("Voucher Tidak Dapat Digunakan");
            }

            if (belanja >= 30000 && belanja < 50000)
            {
                if (pilih == 1)
                {
                    if (ongkir >= 5000)
                    {
                        diskonOngkir = ongkir - 5000;
                        diskonBelanja = belanja - 5000;
                        total = diskonBelanja + diskonOngkir;
                    }
                    else
                    {
                        diskonOngkir = 0;
                        diskonBelanja = belanja - 5000;
                        total = diskonBelanja + diskonOngkir;
                    }
                }

                else
                {
                    total = belanja + ongkir;
                    Console.WriteLine("Voucher Tidak Tersedia dan Tidak Dapat Digunakan");
                }
                
            }

            if (belanja >= 50000 && belanja < 100000)
            {
                if (pilih == 1)
                {
                    if (ongkir >= 5000)
                    {
                        diskonOngkir = ongkir - 5000;
                        diskonBelanja = belanja - 5000;
                        total = diskonBelanja + diskonOngkir;
                    }
                    else
                    {
                        diskonOngkir = 0;
                        diskonBelanja = belanja - 5000;
                        total = diskonBelanja + diskonOngkir;

                    }
                }

                else if (pilih == 2)
                {
                    if (ongkir >= 10000)
                    {
                        diskonOngkir = ongkir - 10000;
                        diskonBelanja = belanja - 10000;
                        total = diskonBelanja + diskonOngkir;
                    }

                    else
                    {
                        diskonOngkir = 0;
                        diskonBelanja = belanja - 10000;
                        total = diskonBelanja + diskonOngkir;
                    }
                }

                else
                {
                    total = belanja + ongkir;
                    Console.WriteLine("Voucher Tidak Tersedia dan Tidak Dapat Digunakan");
                }

            }

            if (belanja >= 100000)
            {
                if (pilih == 1)
                {
                    if (ongkir >= 5000)
                    {
                        diskonOngkir = ongkir - 5000;
                        diskonBelanja = belanja - 5000;
                        total = diskonBelanja + diskonOngkir;
                    }
                    else
                    {
                        diskonOngkir = 0;
                        diskonBelanja = belanja - 5000;
                        total = diskonBelanja + diskonOngkir;
                    }
                }

                else if (pilih == 2)
                {
                    if (ongkir >= 10000)
                    {
                        diskonOngkir = ongkir - 10000;
                        diskonBelanja = belanja - 10000;
                        total = diskonBelanja + diskonOngkir;
                    }

                    else
                    {
                        diskonOngkir = 0;
                        diskonBelanja = belanja - 10000;
                        total = diskonBelanja + diskonOngkir;
                    }
                }

                else if (pilih == 3)
                {

                    if (ongkir >= 20000)
                    {
                        diskonOngkir = ongkir - 20000;
                        diskonBelanja = belanja - 10000;
                        total = diskonBelanja + diskonOngkir;
                    }

                    else
                    {
                        diskonOngkir = 0;
                        diskonBelanja = belanja - 10000;
                        total = diskonBelanja + diskonOngkir;
                    }

                }

                else
                {
                    total = belanja + ongkir;
                    Console.WriteLine("Voucher Tidak Tersedia dan Tidak Dapat Digunakan");
                }

            }

            Console.WriteLine();
 
            Console.WriteLine($"Belanja        = {belanja,9}");
            Console.WriteLine($"Ongkos Kirim   = {ongkir,9}");
            Console.WriteLine($"Diskon Ongkir  = {diskonOngkir,9}");
            Console.WriteLine($"Diskon Belanja = {diskonBelanja,9}");
            Console.WriteLine($"Total Belanja  = {total,9}");

            Console.ReadLine();

        }

        public void Generasi()
        {
            string nama;
            int tahun;

            Console.Clear();

            Console.Write("Masukkan nama anda      = "); nama = Console.ReadLine();
            Console.Write("Tahun berapa anda lahir ? "); tahun = int.Parse(Console.ReadLine());

            if (tahun >= 1944 && tahun < 1965)
            {
                Console.WriteLine($"{nama} , berdasarkan tahun lahir anda tergolong Baby Boomer");
            }

            else if(tahun >= 1965 && tahun < 1980)
            {
                Console.WriteLine($"{nama} , berdasarkan tahun lahir anda tergolong Generasi X");

            }

            else if (tahun >= 1980 && tahun < 1995)
            {
                Console.WriteLine($"{nama} , berdasarkan tahun lahir anda tergolong Generasi Y");

            }

            else if (tahun >= 1995 && tahun < 2016)
            {
                Console.WriteLine($"{nama} , berdasarkan tahun lahir anda tergolong Generasi Z");

            }

            Console.ReadLine();

        }

        public void GapokTunjangan()
        {

            int tunj, gapok, bb, gt;
            double pjk = 0, bpjs = 0, gaji = 0, tg = 0;
            string nama;

            Console.Clear();

            Console.Write("Nama         = "); nama = Console.ReadLine();
            Console.Write("Tunjangan    = "); tunj = int.Parse(Console.ReadLine());
            Console.Write("Gapok        = "); gapok = int.Parse(Console.ReadLine());
            Console.Write("Banyak bulan = "); bb = int.Parse(Console.ReadLine());

            gt = gapok + tunj;

            if (gt <= 5000000)
            {
                pjk = 0.05 * gt;
                bpjs = 0.03 * gt;
                gaji = gt - (pjk + bpjs);
                tg = (gt - (pjk + bpjs)) * bb;
            }

            else if (gt > 5000000 && gt <= 10000000)
            {
                pjk = 0.1 * gt;
                bpjs = 0.03 * gt;
                gaji = gt - (pjk + bpjs);
                tg = (gt - (pjk + bpjs)) * bb;
            }

            else if (gt > 10000000)
            {
                pjk = 0.15 * gt;
                bpjs = 0.03 * gt;
                gaji = gt - (pjk + bpjs);
                tg = (gt - (pjk + bpjs)) * bb;
            }
            Console.WriteLine();
            Console.WriteLine("Karyawan atas nama " + nama);
            Console.WriteLine($"Pajak          = {pjk,9}");
            Console.WriteLine($"BPJS           = {bpjs,9}");
            Console.WriteLine($"Gaji/bln       = {gaji,9}");
            Console.WriteLine($"Total gaji/bb  = {tg,9}");

            Console.ReadLine();

        }


        public void UpahGolongan()
        {
            int gol, jk, jl;
            double upah = 0, lembur=0, total=0;

            Console.Clear();

            Console.WriteLine("--- LIST UPAH PERGOLONGAN ---");
            Console.WriteLine("1. Golongan 1 dengan upah perjam 2000 rupiah");
            Console.WriteLine("2. Golongan 2 dengan upah perjam 3000 rupiah");
            Console.WriteLine("3. Golongan 3 dengan upah perjam 4000 rupiah");
            Console.WriteLine("4. Golongan 4 dengan upah perjam 5000 rupiah");
            Console.WriteLine();

            Console.Write("Masukkan golongan         = "); gol = int.Parse(Console.ReadLine());
            Console.Write("Masukkan banyak jam kerja = "); jk = int.Parse(Console.ReadLine());

            if (gol == 1)
            {
                if (jk > 40)
                {
                    jl = jk - 40;
                    lembur = jl * (2000 * 1.5);
                    upah = (40 * 2000);
                    total = upah + lembur;
                }
                else
                {
                    lembur = 0;
                    upah = (40 * 2000);
                }
            }

            else if (gol == 2)
            {
                if (jk > 40)
                {
                    jl = jk - 40;
                    lembur = jl * (3000 * 1.5);
                    upah = (40 * 3000);
                    total = upah + lembur;

                }
                else
                {
                    lembur = 0;
                    upah = (40 * 3000);
                }
            }

            else if (gol == 3)
            {
                if (jk > 40)
                {
                    jl = jk - 40;
                    lembur = jl * (4000 * 1.5);
                    upah = (40 * 4000);
                    total = upah + lembur;

                }
                else
                {
                    lembur = 0;
                    upah = (40 * 4000);
                }
            }

            else if (gol == 4)
            {
                if (jk > 40)
                {
                    jl = jk - 40;
                    lembur = jl * (5000 * 1.5);
                    upah = (40 * 5000);
                    total = upah + lembur;

                }
                else
                {
                    lembur = 0;
                    upah = (40 * 5000);
                }
            }

            else
            {
                Console.WriteLine("Anda bukan karyawan perusahaan ini ");
            }

            Console.WriteLine();

            Console.WriteLine($"Upah   = {upah,9}");
            Console.WriteLine($"Lembur = {lembur,9}");
            Console.WriteLine($"Total  = {total,9}");

            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            int pil;
            Program pg = new Program();

            do
            {
                Console.WriteLine("----- Menu Soal -----");
                Console.WriteLine("1. Menu Shopee");
                Console.WriteLine("2. Menu Generasi");
                Console.WriteLine("3. Menu Gaji dan Tunjangan");
                Console.WriteLine("4. Menu Upah dan Golongan");
                Console.WriteLine("5. Keluar menu");
                Console.WriteLine();
                Console.Write("Masukkan Pilihan = ");
                pil = int.Parse(Console.ReadLine());

                Console.WriteLine();

                switch (pil)
                {
                    case 1:
                        pg.Shopee();
                        break;
                    case 2:
                        pg.Generasi();
                        break;
                    case 3:
                        pg.GapokTunjangan();
                        break;
                    case 4:
                        pg.UpahGolongan();
                        break;
                    default:
                        Console.WriteLine("Menu tidak tersedia");
                        break;
                }
            } while (pil != 5);
        }
    }
}
