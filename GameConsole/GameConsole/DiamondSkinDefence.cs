using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsole
{
    public class DiamondSkinDefence : ISpecialDefence
    {
        public int CalculateDamageReduction(int totalDamage)
        {
            return 1;
        }
    }
}
