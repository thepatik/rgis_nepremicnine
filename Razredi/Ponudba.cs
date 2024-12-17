using System;

public class Ponudba {
	private int id;
	public int Id {
		get {
			return id;
		}
		set {
			id = value;
		}
	}
	private Oglas oglas;
	public Oglas Oglas {
		get {
			return oglas;
		}
		set {
			oglas = value;
		}
	}
	private double vrednostPonudbe;
	public double VrednostPonudbe {
		get {
			return vrednostPonudbe;
		}
		set {
			vrednostPonudbe = value;
		}
	}
	private Uporabnik ponudnik;
	public Uporabnik Ponudnik {
		get {
			return ponudnik;
		}
		set {
			ponudnik = value;
		}
	}
	private int idUporabnika;
	public int IdUporabnika {
		get {
			return idUporabnika;
		}
		set {
			idUporabnika = value;
		}
	}

    Pogodba pogodba;

    public Pogodba Pogodba
    {
        get
        {
            return pogodba;
        }
        set
        {
            pogodba = value;
        }
    }

	public Ponudba(int id, Oglas oglas, double vrednostPonudbe, Uporabnik ponudnik, int idUporabnika, Pogodba pogodba)
    {
        Id = id;
        Oglas = oglas;
        VrednostPonudbe = vrednostPonudbe;
        Ponudnik = ponudnik;
        IdUporabnika = idUporabnika;
        Pogodba = pogodba;
    }

	public Ponudba() { }
}
