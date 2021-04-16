using System;

namespace LuasBangunDatar
{
    public abstract class HitungLuasKeliling
    {
        public abstract double Luas { get; }
        public abstract double Keliling { get; }
    }

    public class Persegi: HitungLuasKeliling
    {
        private double Panjang;
        public Persegi (double Panjang)
        {
            this.Panjang = Panjang;
        }
        public override double Luas => Panjang * Panjang;
        public override double Keliling => Panjang * 4;
    }

    public class PersegiPanjang : HitungLuasKeliling
    {
        private double Panjang, Lebar;

        public PersegiPanjang (double Panjang, double Lebar)
        {
            this.Panjang = Panjang;
            this.Lebar = Lebar;
        }

        public override double Luas => Panjang * Lebar;
        public override double Keliling => (2 * Panjang) + (2 * Lebar);
    }

    public class Segitiga: HitungLuasKeliling
    {
        public double Alas, Tinggi;

        public Segitiga (double Alas, double Tinggi)
        {
            this.Alas = Alas;
            this.Tinggi = Tinggi;
        }
        public override double Luas => 0.5 * Alas * Tinggi;
        public override double Keliling => 3 * Alas;
    }

    public class Lingkaran: HitungLuasKeliling
    {
        public double Radius;

        public Lingkaran (double Radius)
        {
            this.Radius = Radius;
        }

        public override double Luas => Math.PI * Radius * Radius;
        public override double Keliling => 2 * Math.PI * Radius; 
    }

    public class LayangLayang: HitungLuasKeliling
    {
        public double Diagonal1, Diagonal2;
        public double Sisi1, Sisi2;

        public LayangLayang (double Diagonal1, double Diagonal2, double Sisi1, double Sisi2)
        {
            this.Diagonal1 = Diagonal1;
            this.Diagonal2 = Diagonal2;
            this.Sisi1 = Sisi1;
            this.Sisi2 = Sisi2;
        }

        public override double Luas => 0.5 * Diagonal1 * Diagonal2;
        public override double Keliling => 2 * (Sisi1 + Sisi2);
    }
}
