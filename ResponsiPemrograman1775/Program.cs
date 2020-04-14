using System;

namespace ResponsiPemrograman1775
{
    class Karyawan
    {
        int NIK;
        string Nama;
        int GajiBulanan;
        static void Main(string[] args)
        {
            Karyawan karyawan = new Karyawan();
            karyawan.NIK = 190302123;
            karyawan.Nama = "Paijo";
            karyawan.GajiBulanan = 3000000;

            Karyawan karyawan2 = new Karyawan();
            karyawan2.NIK = 190302124;
            karyawan2.Nama = "Jono";
            karyawan2.GajiBulanan = 2000000;

            karyawan.Validasi();

            karyawan2.Validasi2();


        }

        private void Validasi()
        {
            Console.WriteLine("no" + "   " + "Nik/Nama" + "   " + "Gaji Bulanan");
            Console.WriteLine("========================================");
            Console.Write("1." + " " + this.NIK + " " + this.Nama + " ");
            if (GajiBulanan > 0)
            {
                Console.Write(this.GajiBulanan);
            }
            else if (GajiBulanan <0)
            {
                Console.WriteLine("0");

            }

            
        }
        
        private void Validasi2()
        {
            Console.WriteLine("");
            Console.Write("2." + " " + this.NIK + " " + this.Nama + " ");
            if (GajiBulanan > 0)
            {
                Console.Write(this.GajiBulanan);
            }
            else if (GajiBulanan < 0)
            {
                Console.Write("0");
            }

        }
    }
}
