using System;

namespace LuasBangunDatar
{
    class Program
    {
        static void Main(string[] args)
        {
            string confirm = "ya";
            while (confirm == "ya")
            {
                Console.WriteLine(
                    "------ Pilih Bidang Datar ------" +
                    "\n1. Persegi" +
                    "\n2. Persegi Panjang" +
                    "\n3. Segitiga" +
                    "\n4. Lingkaran" +
                    "\n5. Layang-Layang"
                );
                Console.WriteLine("Pilihan:");
                try
                {
                    int menu = Convert.ToInt32(Console.ReadLine());
                    switch (menu)
                    {
                        case 1:
                            Console.WriteLine("Masukkan panjang sisi persegi:");
                            double panjang = Convert.ToDouble(Console.ReadLine());
                            Persegi persegi = new Persegi(panjang);
                            Console.WriteLine("Luas persegi adalah {0} dan kelilingnya adalah {1}", persegi.Luas, persegi.Keliling);
                            break;
                        case 2:
                            Console.WriteLine("Masukkan panjang sisi persegi panjang:");
                            panjang = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Masukkan lebar sisi persegi panjang:");
                            double lebar = Convert.ToDouble(Console.ReadLine());
                            PersegiPanjang persegiPanjang = new PersegiPanjang(panjang, lebar);
                            Console.WriteLine("Luas persegi panjang adalah {0} dan kelilingnya adalah {1}", persegiPanjang.Luas, persegiPanjang.Keliling);
                            break;
                        case 3:
                            Console.WriteLine("Masukkan alas segitiga:");
                            double alas = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Masukkan tinggi segitiga:");
                            double tinggi = Convert.ToDouble(Console.ReadLine());
                            Segitiga segitiga = new Segitiga(alas, tinggi);
                            Console.WriteLine("Luas segitiga adalah {0} dan kelilingnya adalah {1}", segitiga.Luas, segitiga.Keliling);
                            break;
                        case 4:
                            Console.WriteLine("Masukkan jari-jari lingkaran:");
                            double radius = Convert.ToDouble(Console.ReadLine());
                            Lingkaran lingkaran = new Lingkaran(radius);
                            Console.WriteLine("Luas lingkaran adalah {0} dan kelilingnya adalah {1}", lingkaran.Luas, lingkaran.Keliling);
                            break;
                        case 5:
                            Console.WriteLine("Masukkan Diagonal 1 Layang-Layang:");
                            double d1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Masukkan Diagonal 2 Layang-Layang:");
                            double d2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Masukkan Sisi 1 Layang-Layang:");
                            double s1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Masukkan Sisi 2 Layang-Layang:");
                            double s2 = Convert.ToDouble(Console.ReadLine());
                            LayangLayang layangLayang = new LayangLayang(d1, d2, s1, s2);
                            Console.WriteLine("Luas layang-layang adalah {0} dan kelilingnya adalah {1}", layangLayang.Luas, layangLayang.Keliling);
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Masukkan angka!");
                }
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Ketik \"Ya\" untuk menghitung luas bidang lain");
                confirm = Console.ReadLine().ToLower();
                Console.Clear();
            }
        }
    }
}
