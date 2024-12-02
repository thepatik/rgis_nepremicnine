namespace Nepremicnine__
{
    public class testapp
    {
        public static void Main()
        {
            // Ustvarjanje uporabnikov
            Uporabnik uporabnik1 = new Uporabnik("Janez", "Novak", new DateOnly(1990, 1, 1), "janez.novak@example.com", "password123");
            Uporabnik uporabnik2 = new Uporabnik("Maja", "Horvat", new DateOnly(1985, 7, 15), "maja.horvat@example.com", "securepass");

            // Ustvarjanje nepremičnin
            Nepremicnina nepremicnina1 = new Nepremicnina(1, "Stanovanje v centru mesta", "Trg republike 1", "Ljubljana", 1000, 85.0, 250000, 1985, uporabnik2);
            Nepremicnina nepremicnina2 = new Nepremicnina(2, "Hiša na obrobju", "Zeleni hrib 5", "Kranj", 4000, 120.5, 320000, 2000, uporabnik2);

            // Ustvarjanje pogodb
            Pogodba pogodba1 = new Pogodba(1, nepremicnina1.Id, nepremicnina1, uporabnik1, nepremicnina1.Lastnik, DateTime.Now, 850.0, 1700.0);
            Pogodba pogodba2 = new Pogodba(2, nepremicnina2.Id, nepremicnina2, uporabnik1, nepremicnina2.Lastnik, DateTime.Now.AddDays(-30), 1200.0, 2400.0);

            // Ustvarjanje plačil na podlagi pogodb
            Placilo placilo1 = new Placilo(1, 1, pogodba1, pogodba1.ZnesekNajemnine, "PAY123456");
            Placilo placilo2 = new Placilo(2, 2, pogodba1, pogodba1.ZnesekNajemnine, "PAY123457");
            Placilo placilo3 = new Placilo(3, 1, pogodba2, pogodba2.ZnesekNajemnine, "PAY123458");
            Placilo placilo4 = new Placilo(4, 2, pogodba2, pogodba2.ZnesekNajemnine, "PAY123459");
            Oglas oglas = new Oglas(1, DateTime.Now, DateTime.Now.AddDays(30), nepremicnina1, uporabnik1, "oddaja");



            // Izpis pogodb in plačil
            Console.WriteLine(pogodba1);
            Console.WriteLine(pogodba2);

            Console.WriteLine(placilo1);
            Console.WriteLine(placilo2);
            Console.WriteLine(placilo3);
            Console.WriteLine(placilo4);

            

        }
    }
}
