using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamRPG.Creatures
{
    public class Creature
    {
        private string name;
        private string type;
        private int level;
        private AbilityScores scores;

        public Creature()
        {
            name = "Creature";
            type = "Creature";
            level = 1;
            scores = new AbilityScores(10, 10, 10, 10, 10, 10, 10, 10);
        }

        public override string ToString()
        {
            var lineLength = name.Length + type.Length
                + 11 + level.ToString().Length;
            return name + " (" + type + ") - L. " + level
                + "\n" + new string('-', lineLength) + "\n" + scores;
        }
    }
}
