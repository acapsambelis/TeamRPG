/// <summary>
/// Dice utility classes
/// 
/// Author: Alex Capsambelis
/// </summary>

namespace TeamRPG
{
    public enum Die {
        D2 = 2,
        D3 = 3,
        D4 = 4,
        D6 = 6,
        D8 = 8,
        D10 = 10,
        D20 = 20,
        D100 = 100
    };

    public static class DieExtentions
    {
        private static Random rand = new Random();

        /// <summary>
        /// Roll a die
        /// </summary>
        /// <param name="d">Die to roll</param>
        /// <returns>random value from die</returns>
        public static int Roll(this Die d)
        {
            return rand.Next(((int)d)) + 1;
        }

        /// <summary>
        /// Roll a die and add a bonus/modifier
        /// </summary>
        /// <param name="d">Die to roll</param>
        /// <param name="bonus">bonus/modifier to add</param>
        /// <returns>random value from die + roll</returns>
        public static int Roll(this Die d, int bonus)
        {
            return Roll(d) + bonus;
        }

        /// <summary>
        /// Check to see if a random roll meets a DC
        /// </summary>
        /// <param name="d">Die to roll</param>
        /// <param name="dc">Difficulty class to beat</param>
        /// <returns>True if die roll >= dc, False otherwise</returns>
        public static bool CheckRollSuccess(this Die d, int dc)
        {
            return Roll(d) >= dc;
        }

        /// <summary>
        /// Check to see if a roll and a bonus/modifier beats a given DC
        /// </summary>
        /// <param name="d">Die to roll</param>
        /// <param name="dc">Difficulty class to beat</param>
        /// <param name="bonus">Bonus to add to roll</param>
        /// <returns>True if die roll plus bonus >= dc,
        ///          False otherwise</returns>
        public static bool CheckRollSuccess(this Die d, int dc, int bonus)
        {
            return Roll(d, bonus) >= dc;
        }

        /// <summary>
        /// Roll a die with a custom number of sides
        /// </summary>
        /// <param name="dieSize">Number of sides the die has</param>
        /// <returns>Random value based on die</returns>
        public static int RollCustom(int dieSize)
        {
            return rand.Next(dieSize) + 1;
        }

        /// <summary>
        /// Roll a custom die and add a bonus/modifier
        /// </summary>
        /// <param name="dieSize">Number of sides the die has</param>
        /// <param name="bonus">Bonus/modifier to add to roll</param>
        /// <returns>Random value based on die plus bonus</returns>
        public static int RollCustom(int dieSize, int bonus)
        {
            return RollCustom(dieSize) + bonus;
        }

        /// <summary>
        /// Check to see if a random roll meets a DC
        /// </summary>
        /// <param name="dieSize"></param>
        /// <param name="dc"></param>
        /// <returns></returns>
        public static bool CheckRollCustomSuccess(int dieSize, int dc)
        {
            return RollCustom(dieSize) >= dc;
        }

        /// <summary>
        /// Check to see if a roll and a bonus/modifier beats a given DC
        /// </summary>
        /// <param name="dieSize">Number of sides the die has</param>
        /// <param name="dc">Difficulty class to beat</param>
        /// <param name="bonus">Bonus/modifier to add to roll</param>
        /// <returns>Random value based on die plus bonus</returns>
        public static bool CheckRollCustomSuccess(
            int dieSize, int dc, int bonus)
        {
            return RollCustom(dieSize, bonus) >= dc;
        }
    }
}
