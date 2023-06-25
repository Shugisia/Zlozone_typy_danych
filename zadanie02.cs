using System;

namespace zadanie2 
{
    public struct Student
    {
        public string Imię;
        public string Nazwisko;
        public int NumerIndeksu;
        public string Kierunek;
    }

    public struct Przedmiot
    {
        public string Nazwa;
        public string Kod;
        public int PunktyECTS;
        public string Wykładowca;
    }

    public struct NauczycielAkademicki
    {
        public string Imię;
        public string Nazwisko;
        public string TytułNaukowy;
        public string Katedra;
    }
}
