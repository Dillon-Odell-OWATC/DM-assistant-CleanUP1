using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM_Assistant
{
    class Player:Creature
    {
        private int _ProficancyMod;
        //Other player only features to be set later

        public Player()
            :base()
        {

        }
        public int ProficancyMod
        {
            get { return _ProficancyMod; }
            set { _ProficancyMod = value; }
        }
    }
}
