using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsole
{
    class PlayerCharacter
    {
        public PlayerCharacter()
        {
            DaysSinceLastLogin = null;
            DateOfBirth = null;
        }

        public string Name { get; set; }
        public Nullable<int> DaysSinceLastLogin { get; set; }
        public Nullable<DateTime> DateOfBirth { get; set; }
    }
}
