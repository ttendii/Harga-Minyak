using System;
/// <summary>
/// Memberi nama project yang kita buat
/// </summary>
namespace Harga_Minyak
{/// <summary>
/// Main Class
/// </summary>
    class Program
    {/// <summary>
    /// Menghitung harga minyak
    /// </summary>
    /// <param name="args">parameter yang berisi argumen baris perintah</param>
        static void Main(string[] args)
        {// untuk menginput satuan minyak per liter
            float satuan, harga, bayar;
            Console.WriteLine("Program Perhitungan Harga Minyak");
            Console.Write("Silahkan Masukan Takaran Minyak per liter= ");
            satuan = float.Parse(Console.ReadLine());
            // untuk menghitung satuan minyak dengan harga per liternya
            harga = (100000 / 20);
            bayar = harga * satuan;
            Console.WriteLine("harga{0} dan bayar{1}", harga, bayar);
            Console.ReadKey();
        }
    }
}
