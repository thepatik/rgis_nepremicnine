using System;

public class Oglas
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

    private DateTime datumObjave;
    public DateTime DatumObjave
    {
        get
        {
            return datumObjave;
        }
        set
        {
            datumObjave = value;
        }
    }

    private DateTime datumPoteka;
    public DateTime DatumPoteka
    {
        get
        {
            return datumPoteka;
        }
        set
        {
            datumPoteka = value;
        }
    }

    private Nepremicnina nepremicnina;
    public Nepremicnina Nepremicnina
    {
        get
        {
            return nepremicnina;
        }
        set
        {
            if (value == null) throw new ArgumentNullException(nameof(Nepremicnina), "Nepremicnina ne more biti null");
            nepremicnina = value;
        }
    }

    private Uporabnik objavil;
    public Uporabnik Objavil
    {
        get
        {
            return objavil;
        }
        set
        {
            if (value == null) throw new ArgumentNullException(nameof(Objavil), "Objavil ne more biti null");
            objavil = value;
        }
    }

    private string tipOglasa = "oddaja";
    public string TipOglasa
    {
        get
        {
            return tipOglasa;
        }
        set
        {
            tipOglasa = value;
        }
    }

    private Backend backend;

    // Konstruktor za inicializacijo oglasa
    public Oglas(int id, DateTime datumObjave, DateTime datumPoteka, Nepremicnina nepremicnina, Uporabnik objavil, string tipOglasa = "oddaja")
    {
        this.Id = id;
        this.DatumObjave = datumObjave;
        this.DatumPoteka = datumPoteka;
        this.Nepremicnina = nepremicnina;
        this.Objavil = objavil;
        this.TipOglasa = tipOglasa;
    }

    // Metoda za izpis oglasa kot string (za testiranje)
    public override string ToString()
    {
        return $"ID: {Id}, Datum objave: {DatumObjave.ToShortDateString()}, Datum poteka: {DatumPoteka.ToShortDateString()}, Nepremicnina: {Nepremicnina?.Naziv}, Objavil: {Objavil?.Ime} {Objavil?.Priimek}, Tip oglasa: {TipOglasa}";
    }
}
