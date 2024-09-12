using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBOWeek3_FundamentalToInheritance.Classes
{
    public class Orang
    {
        public string name, jenisKelamin, hobby;
        public int umur;

        public void InfoPerson(string name, string jenisKelamin, string hobby, int umur)
        {
            this.name = name;
            this.jenisKelamin = jenisKelamin;
            this.hobby = hobby;
            this.umur = umur;
        }

        public string GetInfo()
        {
            return $"Nama: {name}\nJenis Kelamin: {jenisKelamin}\nHobby: {hobby}\nUmur: {umur}";
        }
    }
}
