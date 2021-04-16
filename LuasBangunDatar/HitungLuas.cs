using System;

namespace LuasBangunDatar
{
    public abstract class HitungLuas
    {
        public abstract double Luas { get; }
    }

    public class Persegi: HitungLuas
    {
        private double Panjang;
        public Persegi (double Panjang)
        {
            this.Panjang = Panjang;
        }
        public override double Luas => Panjang * Panjang;
    }

    public class PersegiPanjang : HitungLuas
    {
        private double Panjang, Lebar;

        public PersegiPanjang (double Panjang, double Lebar)
        {
            this.Panjang = Panjang;
            this.Lebar = Lebar;
        }

        public override double Luas => Panjang * Lebar;
    }

    public class Segitiga: HitungLuas
    {
        public double Alas, Tinggi;

        public Segitiga (double Alas, double Tinggi)
        {
            this.Alas = Alas;
            this.Tinggi = Tinggi;
        }
        public override double Luas => 0.5 * Alas * Tinggi;
    }

    public class Lingkaran: HitungLuas
    {
        public double Radius;

        public Lingkaran (double Radius)
        {
            this.Radius = Radius;
        }

        public override double Luas => Math.PI * Radius * Radius;
    }

    public class LayangLayang: HitungLuas
    {
        public double Diagonal1, Diagonal2;

        public LayangLayang (double Diagonal1, double Diagonal2)
        {
            this.Diagonal1 = Diagonal1;
            this.Diagonal2 = Diagonal2;
        }

        public override double Luas => 0.5 * Diagonal1 * Diagonal2;
    }
}
