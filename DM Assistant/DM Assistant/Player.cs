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
        private int _EXP;
        private string _Class;
        private string _Background;
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
        public int EXP
        {
            get { return _EXP; }
            set { _EXP = value; }
        }
        public string Class
        {
            get { return _Class; }
            set { _Class = value; }
        }
        public string Background
        {
            get { return _Background; }
            set { _Background = value; }
        }
    }
}
