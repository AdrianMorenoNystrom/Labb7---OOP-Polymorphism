namespace Labb7___OOP_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instanser av alla klasser jag skapat.
            Geometri cirkel = new Cirkel();
            Geometri fyrkant = new Fyrkant();
            Geometri rektangel = new Rektangel();
            Geometri parallellogram = new Parallellogram();
            Geometri ellips = new Ellips();

            Console.WriteLine($"Cirkel area(Radie*Radie*3,14): {cirkel.Area()}");
            Console.WriteLine($"Fyrkant area(Sida*Sida): {fyrkant.Area()}");
            Console.WriteLine($"Rektangel area(Längd*Bredd): {rektangel.Area()}");
            Console.WriteLine($"Parallellogram area(Bas*Höjd): {parallellogram.Area()}");
            Console.WriteLine($"Ellips area(3,14*A-axel*B-axel): {ellips.Area()}");



        }
    }
}