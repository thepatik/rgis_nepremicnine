﻿using System;
using System.Collections.Generic;

public class Nepremicnina
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

    private string naziv;
    public string Naziv
    {
        get
        {
            return naziv;
        }
        set
        {
            naziv = value;
        }
    }

    private string naslov;
    public string Naslov
    {
        get
        {
            return naslov;
        }
        set
        {
            naslov = value;
        }
    }

    private string posta;
    public string Posta
    {
        get
        {
            return posta;
        }
        set
        {
            posta = value;
        }
    }

    private int postnaSt;
    public int PostnaSt
    {
        get
        {
            return postnaSt;
        }
        set
        {
            postnaSt = value;
        }
    }

    private double povrsina;
    public double Povrsina
    {
        get
        {
            return povrsina;
        }
        set
        {
            povrsina = value;
        }
    }

    private double vrednost;
    public double Vrednost
    {
        get
        {
            return vrednost;
        }
        set
        {
            vrednost = value;
        }
    }

    private int letoIzgradnje;
    public int LetoIzgradnje
    {
        get
        {
            return letoIzgradnje;
        }
        set
        {
            letoIzgradnje = value;
        }
    }

    private Uporabnik lastnik;
    public Uporabnik Lastnik
    {
        get
        {
            return lastnik;
        }
        set
        {
            if (value == null) throw new ArgumentNullException(nameof(Lastnik), "Lastnik ne more biti null");
            lastnik = value;
        }
    }

    public static List<Nepremicnina> Nepremicnine { get; } = new List<Nepremicnina>();

    
    public Nepremicnina(int id, string naziv, string naslov, string posta, int postnaSt, double povrsina, double vrednost, int letoIzgradnje, Uporabnik lastnik)
    {
        this.Id = id;
        this.Naziv = naziv;
        this.Naslov = naslov;
        this.Posta = posta;
        this.PostnaSt = postnaSt;
        this.Povrsina = povrsina;
        this.Vrednost = vrednost;
        this.LetoIzgradnje = letoIzgradnje;
        this.Lastnik = lastnik;
        Nepremicnine.Add(this); // Samodejno dodajanje v seznam
    }

     

    // Metoda za izpis nepremičnine kot string (za testiranje)
    public override string ToString()
    {
        return $"ID: {Id}, Naziv: {Naziv}, Naslov: {Naslov}, Posta: {Posta}, Površina: {Povrsina} m², Vrednost: {Vrednost} EUR, Leto: {LetoIzgradnje}, Lastnik: {Lastnik.Ime} {Lastnik.Priimek}";
    }
}
