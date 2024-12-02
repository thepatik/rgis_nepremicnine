using System;

public class Placilo
{
    private int id;
    public int Id
    {
        get
        {
            return id;
        }
        set
        {
            id = value;
        }
    }

    private int mesec = 1;
    public int Mesec
    {
        get
        {
            return mesec;
        }
        set
        {
            mesec = value;
        }
    }

    private Pogodba pogodba;
    public Pogodba Pogodba
    {
        get
        {
            return pogodba;
        }
        set
        {
            if (value == null) throw new ArgumentNullException(nameof(Pogodba), "Pogodba ne more biti null");
            pogodba = value;
        }
    }

    private double znesek;
    public double Znesek
    {
        get
        {
            return znesek;
        }
        set
        {
            znesek = value;
        }
    }

    /// <summary>
    /// Tukaj se shrani ID plaèila ponudnika plaèilnih storitev (zunanji)
    /// </summary>
    private string placiloIdZunanji;
    public string PlaciloIdZunanji
    {
        get
        {
            return placiloIdZunanji;
        }
        set
        {
            placiloIdZunanji = value;
        }
    }

    private Backend backend;

    // Konstruktor za inicializacijo plaèila
    public Placilo(int id, int mesec, Pogodba pogodba, double znesek, string placiloIdZunanji)
    {
        this.Id = id;
        this.Mesec = mesec;
        this.Pogodba = pogodba;
        this.Znesek = znesek;
        this.PlaciloIdZunanji = placiloIdZunanji;
    }

    // Metoda za izpis plaèila kot string (za testiranje)
    public override string ToString()
    {
        return $"ID: {Id}, Mesec: {Mesec}, Pogodba ID: {Pogodba?.Id}, Znesek: {Znesek} EUR, Zunanji ID: {PlaciloIdZunanji}";
    }

}
