using System;

public class Uporabnik
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

    private string ime;
	public string Ime {
		get {
			return ime;
		}
		set {
			ime = value;
		}
	}
	public string Priimek;
	private DateOnly datumRojstva;
	public DateOnly DatumRojstva {
		get {
			return datumRojstva;
		}
		set {
			datumRojstva = value;
		}
	}
	private string email;
	public string Email {
		get {
			return email;
		}
		set {
			email = value;
		}
	}
	private string geslo;
	public string Geslo {
		get {
			return geslo;
		}
		set {
			geslo = value;
		}
	}

	private string tipUporabnika = "najemnik";
	public string TipUporabnika {
		get {
			return tipUporabnika;
		}
		set {
			tipUporabnika = value;
		}
	}

    // Konstruktor za uporabnika
	public Uporabnik() { }

    public Uporabnik(string ime, string priimek, DateOnly datumRojstva, string email, string geslo, string tipUporabnika = "najemnik")
    {
        this.Ime = ime;
        this.Priimek = priimek;
        this.DatumRojstva = datumRojstva;
        this.Email = email;
        this.Geslo = geslo;
        this.TipUporabnika = tipUporabnika;
    }

    // Metoda za vrnitev uporabnika kot string (za testiranje)
    public override string ToString()
    {
        return $"{Ime} {Priimek}, Email: {Email}, Tip: {TipUporabnika}, Rojen: {DatumRojstva}";
    }
}
