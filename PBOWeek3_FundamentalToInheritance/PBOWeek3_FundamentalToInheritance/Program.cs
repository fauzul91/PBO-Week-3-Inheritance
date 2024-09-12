using System;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;
using PBOWeek3_FundamentalToInheritance.Classes;

class Program
{
    public static void Main(string[] args)
    {
        Mahasiswa mahasiswa1 = new Mahasiswa();
        mahasiswa1.InfoMahasiswa("Rahmat Fauzul Akbar", "Laki-laki", "232410101063", "Sistem Informasi", 22, 1);
        Console.WriteLine(mahasiswa1.getInfoMhs());

        int ukt = mahasiswa1.GetGolUKT(mahasiswa1.golUKT);
        Console.WriteLine($"Besaran UKT: {ukt}");
    }
}