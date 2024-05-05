using AljabarLibraries;
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        double[] persamaan = { 1, -3, -10 };
        Console.WriteLine($"akar persamaan kuadrat dari {persamaan[0]}x^2 {persamaan[1]}x {persamaan[2]} adalah");
        double[] akar = hitung.AkarPersamaanKuadrat(persamaan);
        Console.WriteLine($"hasilnya: {akar[0]} dan {akar[1]}");

        double[] persamaanLinear = { 2, -3 };
        double[] hasil = hitung.HasilKuadrat(persamaanLinear);
        Console.WriteLine($"\nhasil kuadrat dari persamaan {persamaanLinear[0]}x {persamaanLinear[1]} adalah");
        Console.WriteLine($"Hasil kuadrat: {hasil[0]}x^2 + {hasil[1]}x + {hasil[2]}");
    }
}