using System;
using GFT_Proj.src.Entities;

namespace GFT_Proj
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus ", 26, "Knight");
            Wizard wizard = new Wizard("Jenica ", 23, "White Wizard");
            Archer archer = new Archer("Sohrus ", 21, "Archer");

            Console.WriteLine(arus.Attack(2));
            Console.WriteLine(wizard.Attack(8));
            Console.WriteLine(archer.Attack(5));
        }
    }
}