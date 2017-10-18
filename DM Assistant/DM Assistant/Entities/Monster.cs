using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DM_Assistant.Entities
{
    class Monster : Creature
    {
        #region Constructor
        public Monster()
            :base()
        {

        }
        #endregion  
        #region Class Properties
        public int FlyingSpeed { get; set; }
        public string Skills { get; set; }
        public string FeatsAndTraits { get; set; }
        public string Actions { get; set; }
        public string LegendaryActions { get; set; }
        #endregion
    }
}
