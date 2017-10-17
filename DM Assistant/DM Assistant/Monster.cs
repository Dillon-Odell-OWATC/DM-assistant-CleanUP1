using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM_Assistant
{
    class Monster : Creature
    {
        public Monster()
            :base()
        {

        }
        public int FlyingSpeed { get; set; }
        public string Skills { get; set; }
        public string FeatsAndTraits { get; set; }
        public string Actions { get; set; }
        public string LegendaryActions { get; set; }

    }
}
