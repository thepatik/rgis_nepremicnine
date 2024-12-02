using System;

/// <summary>
/// Ta element predstavlja zeledni sistem za celotno našo aplikacijo.
/// 
/// Lakho razdelimo na veè razliènih "Backendov" ali pa pustimo enega. Opravlja vse funkcionalnosti aplikacije
/// </summary>
public class Backend {


    private List<Uporabnik> uporabniki = new List<Uporabnik>();
    private List<Nepremicnina> nepremicnine = new List<Nepremicnina>();
    private List<Ponudba> ponudbe = new List<Ponudba>();
    private List<Pogodba> pogodbe = new List<Pogodba>();
    private List<Placilo> placila = new List<Placilo>();
    public void RegistracijaUporabnika(Uporabnik novUporabnik)
    {
        if (novUporabnik == null) throw new ArgumentNullException(nameof(novUporabnik));
        uporabniki.Add(novUporabnik);
        Console.WriteLine($"Uporabnik {novUporabnik.Ime} {novUporabnik.Priimek} je bil uspešno registriran.");
    }
    public void OdjavaUporabnika() {
		throw new System.NotImplementedException("Not implemented");
	}
    public string PrijavaUporabnika(string email, string geslo)
    {
        foreach (var uporabnik in uporabniki)
        {
            if (uporabnik.Email == email && uporabnik.Geslo == geslo)
            {
                Console.WriteLine($"Uporabnik {uporabnik.Ime} {uporabnik.Priimek} je prijavljen.");
                return "Prijava uspešna";
            }
        }
        return "Prijava ni uspela";
    }
    public void DodajNepremicnino(Nepremicnina novaNepremicnina)
    {
        if (novaNepremicnina == null) throw new ArgumentNullException(nameof(novaNepremicnina));
        nepremicnine.Add(novaNepremicnina);
        Console.WriteLine($"Nepremiènina '{novaNepremicnina.Naziv}' je bila uspešno dodana.");
    }
    public Nepremicnina GetNepremicnino(ref int id)
    {
        foreach (var nepremicnina in nepremicnine)
        {
            if (nepremicnina.Id == id)
            {
                return nepremicnina;
            }
        }
        throw new Exception("Nepremiènina ni najdena.");
    }

    public List<Nepremicnina> PridobiSeznamVsehNepremicnin()
    {
        return nepremicnine;
    }
    public void OddajPonudbo() {
		throw new System.NotImplementedException("Not implemented");
	}
	public Ponudba[] PridobiSeznamPonudb() {
		throw new System.NotImplementedException("Not implemented");
	}
	public void IzbrisiPonudbo() {
		throw new System.NotImplementedException("Not implemented");
	}
	public Ponudba PridobiPonudbo(ref int id) {
		throw new System.NotImplementedException("Not implemented");
	}
	public void OddajOceno() {
		throw new System.NotImplementedException("Not implemented");
	}
    public void ShraniPogodbo(Pogodba novaPogodba)
    {
        if (novaPogodba == null) throw new ArgumentNullException(nameof(novaPogodba));
        pogodbe.Add(novaPogodba);
        Console.WriteLine($"Pogodba ID: {novaPogodba.Id} je bila uspešno shranjena.");
    }

    public Pogodba GetPogodbo(ref int id)
    {
        foreach (var pogodba in pogodbe)
        {
            if (pogodba.Id == id)
            {
                return pogodba;
            }
        }
        throw new Exception("Pogodba ni najdena.");
    }
    /// <summary>
    /// Funkcija namenjena konènemu podpisu pogodobe med obema pogodbenima strankama v postopku.
    /// </summary>
    public void PodpisiPogodbo(ref int id, ref Uporabnik uporabnik) {
		throw new System.NotImplementedException("Not implemented");
	}
    /// <param name="pogodba">Pogodba (pridobitev zneska)</param>
    /// <param name="mesec">Zaporedna številka meseca (1-12)</param>
    public void IzvediPlacilo(ref Pogodba pogodba, ref int mesec)
    {
        if (pogodba == null) throw new ArgumentNullException(nameof(pogodba));
        Placilo novoPlacilo = new Placilo(placila.Count + 1, mesec, pogodba, pogodba.ZnesekNajemnine, $"PAY-{placila.Count + 1}");
        placila.Add(novoPlacilo);
        Console.WriteLine($"Plaèilo za pogodbo ID: {pogodba.Id} za mesec {mesec} je bilo uspešno izvedeno.");
    }
    public string PotrdiPlacilo(ref int placiloId) {
		throw new System.NotImplementedException("Not implemented");
	}

	private Pogodba pogodba;
	private Nepremicnina nepremicnina;
	private Uporabnik uporabnik;
	private Ponudba ponudba;
	private Oglas oglas;
	private Placilo placilo;

}
