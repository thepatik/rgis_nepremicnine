using System;

/// <summary>
/// Abstraktni razred od katerega dedujejo vsa druga okna kI, se pojavijo
/// </summary>
public abstract class Okno {
	private int dolzina = 0;
	public int Dolzina {
		get {
			return dolzina;
		}
		set {
			dolzina = value;
		}
	}
	private int sirina = 0;
	public int Sirina {
		get {
			return sirina;
		}
		set {
			sirina = value;
		}
	}
	private bool isVisible;
	public bool IsVisible {
		get {
			return isVisible;
		}
		set {
			isVisible = value;
		}
	}
	private int pozicijaX = 0;
	public int PozicijaX {
		get {
			return pozicijaX;
		}
		set {
			pozicijaX = value;
		}
	}
	private int pozicijaY = 0;
	public int PozicijaY {
		get {
			return pozicijaY;
		}
		set {
			pozicijaY = value;
		}
	}
	private bool isLoggedIn = false;
	public bool IsLoggedIn {
		get {
			return isLoggedIn;
		}
		set {
			isLoggedIn = value;
		}
	}
	private Uporabnik userData = null;
	public Uporabnik UserData {
		get {
			return userData;
		}
		set {
			userData = value;
		}
	}

	public void Odpri() {
		throw new System.NotImplementedException("Not implemented");
	}

}
