using System;

public class Pogodba {
	private int id;
	public int Id {
		get {
			return id;
		}
		set {
			id = value;
		}
	}
	private int idNepremicnine;
	public int IdNepremicnine {
		get {
			return idNepremicnine;
		}
		set {
			idNepremicnine = value;
		}
	}
	private Nepremicnina nepremicnina;
	public Nepremicnina Nepremicnina {
		get {
			return nepremicnina;
		}
		set {
			nepremicnina = value;
		}
	}
	private Uporabnik najemnik;
	public Uporabnik Najemnik {
		get {
			return najemnik;
		}
		set {
			najemnik = value;
		}
	}
	private Uporabnik najemodajalec;
	public Uporabnik Najemodajalec {
		get {
			return najemodajalec;
		}
		set {
			najemodajalec = value;
		}
	}
	private DateTime datumSklenitve;
	public DateTime DatumSklenitve {
		get {
			return datumSklenitve;
		}
		set {
			datumSklenitve = value;
		}
	}
	private double znesekNajemnine = 150;
	public double ZnesekNajemnine {
		get {
			return znesekNajemnine;
		}
		set {
			znesekNajemnine = value;
		}
	}
	private double znesekVarscine;
	public double ZnesekVarscine {
		get {
			return znesekVarscine;
		}
		set {
			znesekVarscine = value;
		}
	}

	public Pogodba() { }
    public Pogodba(
        int id,
        int idNepremicnine,
        Nepremicnina nepremicnina,
        Uporabnik najemnik,
        Uporabnik najemodajalec,
        DateTime datumSklenitve,
        double znesekNajemnine,
        double znesekVarscine)
    {
        this.Id = id;
        this.IdNepremicnine = idNepremicnine;
        this.Nepremicnina = nepremicnina;
        this.Najemnik = najemnik;
        this.Najemodajalec = najemodajalec;
        this.DatumSklenitve = datumSklenitve;
        this.ZnesekNajemnine = znesekNajemnine;
        this.ZnesekVarscine = znesekVarscine;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Nepremicnina: {Nepremicnina?.Naziv}, Najemnik: {Najemnik?.Ime} {Najemnik?.Priimek}, Najemodajalec: {Najemodajalec?.Ime} {Najemodajalec?.Priimek}, Datum: {DatumSklenitve}, Najemnina: {ZnesekNajemnine}, Varscina: {ZnesekVarscine}";
    }

    private Backend backend;

}
