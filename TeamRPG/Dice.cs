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

        public static int Roll(this Die d)
        {
            return rand.Next(((int)d)) + 1;
        }

        public static int Roll(this Die d, int bonus)
        {
            return Roll(d) + bonus;
        }

        public static bool CheckRollSuccess(this Die d, int dc)
        {
            return Roll(d) >= dc;
        }

        public static bool CheckRollSuccess(this Die d, int dc, int bonus)
        {
            return Roll(d, bonus) >= dc;
        }

        public static int RollCustom(int dieSize)
        {
            return rand.Next(dieSize) + 1;
        }

        public static int RollCustom(int dieSize, int bonus)
        {
            return RollCustom(dieSize) + bonus;
        }

        public static bool CheckRollCustomSuccess(int dieSize, int dc)
        {
            return RollCustom(dieSize) >= dc;
        }

        public static bool CheckRollCustomSuccess(
            int dieSize, int dc, int bonus)
        {
            return RollCustom(dieSize, bonus) >= dc;
        }
    }
}
