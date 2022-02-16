/// <summary>
/// Ability score containment and arithmetic
/// 
/// Author: Alex Capsambelis
/// </summary>

namespace TeamRPG.Creatures
{
    /// <summary>
    /// Container for the ability scores for every creature
    /// </summary>
    public class AbilityScores
    {
        private int str;        // Strength
        private int dex;        // Dexterity
        private int phys;       // Physicality

        private int con;        // Constitution
        private int ctr;        // Concentration
        private int fort;       // Fortitude

        private int itl;        // Intelligence
        private int wis;        // Wisdom
        private int reas;       // Reason

        private int ami;        // Amicability
        private int prs;        // Presence
        private int chsa;       // Charisma

        /// <summary>
        /// Default constructor
        /// </summary>
        public AbilityScores() : this(10, 10, 10, 10, 10, 10, 10, 10) { }
        
        /// <summary>
        /// Constructor, takes 8 ability scores
        /// and calculates the 4 derived scores
        /// </summary>
        /// <param name="str">Strength</param>
        /// <param name="dex">Dexterity</param>
        /// <param name="con">Constitution</param>
        /// <param name="ctr">Concentration</param>
        /// <param name="itl">Intelligence</param>
        /// <param name="wis">Widsom</param>
        /// <param name="ami">Amicability</param>
        /// <param name="prs">Presence</param>
        public AbilityScores(int str, int dex, int con, int ctr,
                             int itl, int wis, int ami, int prs)
        {
            this.str = str;
            this.dex = dex;
            this.phys = str + dex;    
                
            this.con = con;
            this.ctr = ctr;
            this.fort = con + ctr;

            this.itl = itl;
            this.wis = wis;
            this.reas = itl + wis;

            this.ami = ami;
            this.prs = prs;
            this.chsa = ami + prs;
        }

        /// <summary>
        /// Override the ToString to print important data more readable
        /// </summary>
        /// <returns>String with formatted data</returns>
        public override string ToString()
        {
            return string.Format("STR: {0} - DEX: {1}\n  PHYS: {2}\n" +
                   "CON: {3} - CTR: {4}\n  FORT: {5}\n" +
                   "ITL: {6} - WIS: {7}\n  REAS: {8}\n" +
                   "AMI: {9} - PRS: {10}\n  CHSA: {11}\n",
                   str, dex, phys, con, ctr, fort,
                   itl, wis, reas, ami, prs, chsa);
        }
    }
}
