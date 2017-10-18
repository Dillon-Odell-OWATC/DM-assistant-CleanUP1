using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM_Assistant.Entities
{

    abstract class Creature
    {
        //No constuctor relying on the Default Values
        //Making it so I am able to set the stats for the class
        #region Class Properties
        public int STR { get; set; }
        public int DEX { get; set; }
        public int CON { get; set; }
        public int INT { get; set; }
        public int WIS { get; set; }
        public int CHA { get; set; }
        public int HP { get; set; }
        public int AC { get; set; }
        public int Speed { get; set; }
        public int EXP { get; set; }
        public string Name { get; set; }
        public string Alignment { get; set; }
        public string Race { get; set; }
        public string Maker { get; set; }
#endregion
    }
}
