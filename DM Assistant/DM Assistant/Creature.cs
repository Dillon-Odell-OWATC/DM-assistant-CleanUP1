using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM_Assistant
{

    abstract class Creature
    {
        
        //Declairs stats that get used by both players and monsters
        private int _STR;
        private int _DEX;
        private int _CON;
        private int _INT;
        private int _WIS;
        private int _CHA;
        private int _HP;
        private int _AC;
        private int _Speed;
        private int _EXP;

        private string _Name;
        private string _Alignment;
        private string _Race;
        private string _Maker;

        //No constuctor relying on the Default Values
        //Making it so I am able to set the stats for the class
        public int STR
        {
            get { return _STR; }
            set { _STR = value; }
        }
        public int DEX
        {
            get { return _DEX; }
            set { _DEX = value; }
        }
        public int CON
        {
            get { return _CON; }
            set { _CON = value; }
        }
        public int INT
        {
            get { return _INT; }
            set { _INT = value; }
        }
        public int WIS
        {
            get { return _WIS; }
            set { _WIS = value; }
        }
        public int CHA
        {
            get { return _CHA; }
            set { _CHA = value; }
        }
        public int HP
        {
            get { return _HP; }
            set { _HP = value; }
        }
        public int AC
        {
            get { return _AC; }
            set { _AC = value; }
        }
        public int Speed
        {
            get { return _Speed; }
            set { _Speed = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string Alignment
        {
            get { return _Alignment; }
            set { _Alignment = value; }
        }
        public string Race
        {
            get { return _Race; }
            set { _Race = value; }
        }
        public string Maker
        {
            get { return _Maker; }
            set { _Maker = value; }
        }
        public int EXP
        {
            get { return _EXP; }
            set { _EXP = value; }
        }
    }
}
