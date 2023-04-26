using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadSaViseFormi
{
    class Student
    {
        string ime, prezime, smjer, brojIndeksa;
        DateTime datumRodjenja;

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Smjer { get => smjer; set => smjer = value; }
        public string BrojIndeksa { get => brojIndeksa; set => brojIndeksa = value; }
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }

        public override string ToString()
        {
            return "Student "+Ime+" "+Prezime+" | "+BrojIndeksa+" | smjer: "+Smjer+" | Rođen: "+DatumRodjenja;
        }
        public Student()
        {

        }
        public Student(string i, string p, string bI, string s, DateTime dR)
        {
            Ime = i;
            Prezime = p;
            BrojIndeksa = bI;
            Smjer = s;
            DatumRodjenja = dR;
        }
    }
}
