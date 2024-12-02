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

	private Backend backend;

}
