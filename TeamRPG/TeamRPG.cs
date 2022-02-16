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
        public static void Main(String[] args)
        {
            Console.WriteLine(Die.D20.Roll());

            Console.WriteLine(DieExtentions.RollCustom(5));
        }
    }
}