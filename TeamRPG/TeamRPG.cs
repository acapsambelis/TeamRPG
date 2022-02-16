/// <summary>
/// Driver for the program
/// 
/// Author: Alex Capsambelis
/// </summary>

using System;

namespace TeamRPG
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            var c = new Creatures.Creature();
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}