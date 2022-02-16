/// <summary>
/// Creature class and functionality
/// 
/// Author: Alex Capsambelis
/// </summary>

namespace TeamRPG.Creatures
{
    /// <summary>
    /// Container for creature functionality
    /// </summary>
    public class Creature
    {
        private string name;
        private string type;
        private int level;
        private AbilityScores scores;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Creature()
        {
            name = "Creature";
            type = "Creature";
            level = 1;
            scores = new AbilityScores();
        }

        /// <summary>
        /// Override the ToString to print important data more readable
        /// </summary>
        /// <returns>String with formatted data</returns>
        public override string ToString()
        {
            var lineLength = name.Length + type.Length
                + 10 + level.ToString().Length;
            return name + " (" + type + ") - L. " + level
                + "\n" + new string('-', lineLength) + "\n" + scores;
        }
    }
}
