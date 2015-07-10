using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza_Pacjentow
{
    class Pacjent
    {
        public string Nazwisko, Imie, Adres;
        public int Licznik_wizyt, Wiek, Nr_tel;
        public decimal Stawka;
        public Pacjent()
        {
            this.Licznik_wizyt = 0;
        }
        public Pacjent(string nazwi , string imie , string adres, int nr_tel , decimal stawka )
        {
            this.Nazwisko = nazwi;
            this.Imie = imie;
            this.Adres = adres;
            this.Nr_tel = nr_tel;
            this.Stawka = stawka;
        }
       
    }
}
