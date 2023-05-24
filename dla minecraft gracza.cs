class towar
{
    public string nazwa;
    public int cena;
    public int ilosc;

    public virtual void wyswietl()
    {
        Console.WriteLine("nazwa:" + nazwa + "cena: " +  cena + "ilosc: " + ilosc);
    }
}

class gwozdzie : towar
{
    public double dlugosc;
    public double grubosc;
    public string rodzaj_lepka;

    public override void wyswietl()
    {
        Console.Write("dlugosc: " + dlugosc + "grubosc: " + grubosc + "rodzaj_lepka: " +  rodzaj_lepka);
    }
}

class papier_scierny : towar
{
    public string ziarnistosc;
    public double szerokosc;

    public override void wyswietl()
    {
        Console.Write("ziarnistosc: " + ziarnistosc + "szerokosc: " + szerokosc);
    }
}

class meble : towar
{
    public string kolekcja;

    public override void wyswietl()
    {
        Console.Write("kolekcja: " + kolekcja);
    }
}
