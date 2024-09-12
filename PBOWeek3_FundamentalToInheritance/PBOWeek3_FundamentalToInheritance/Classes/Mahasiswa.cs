using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBOWeek3_FundamentalToInheritance.Classes
{
    public class Mahasiswa : Orang
    {
        public string NIM, prodi; /*String karena NIM tidak dioperasikan secara matematis*/
        public int jmlSKS, golUKT;

        public void InfoMahasiswa(string name, string jenisKelamin, string NIM, string prodi, int jmlSKS, int golUKT)
        {
            this.InfoPerson(name, jenisKelamin, hobby, umur);
            this.NIM = NIM;
            this.prodi = prodi;
            this.jmlSKS = jmlSKS;
            this.golUKT = golUKT;
        }

        public string getInfoMhs()
        {
            return $"Nama: {name}\nJenis Kelamin: {jenisKelamin}\nNIM: {NIM}\nProdi: {prodi}\nJumlah SKS: {jmlSKS}\nGol UKT: {golUKT}";
        }

        public int GetGolUKT(int golUKT)
        {
            int ukt = 0;
            if (golUKT == 1)
            {
                ukt = 500000;
            }
            else if (golUKT == 2)
            {
                ukt = 1000000;
            }
            else if (golUKT == 3)
            {
                ukt = 2000000;
            }
            else
            {
                ukt = 3000000; // Default untuk golongan lain
            }
            return ukt;
        }
    }
}
