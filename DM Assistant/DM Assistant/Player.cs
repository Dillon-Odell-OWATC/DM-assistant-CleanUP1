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
        private string _Class;
        private string _Background;
        private string _Feats;
        private string _Traits;
        private string _Proficiencies;
        private string _Languages;
        private string _PersonalityTraits;
        private string _Ideals;
        private string _Bonds;
        private string _Flaws;
        private string _Weapons;
        private string _Currency;
        private string _Armor;
        private string _Tresures;
        private string _Ammunition;

        // each bool represents a differnt skill
        private bool[] _SkillsAray = new bool[24];
        private bool[] tempSkillArray = new bool[24];
        public Player()
            :base()
        {

        }
        public int ProficancyMod
        {
            get { return _ProficancyMod; }
            set { _ProficancyMod = value; }
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
        public string Feats
        {
            get { return _Feats; }
            set { _Feats = value; }
        }
        public string Traits
        {
            get { return _Traits; }
            set { _Traits = value; }
        }
        public string Proficiencies
        {
            get { return _Proficiencies; }
            set { _Proficiencies = value; }
        }
        public string Languages
        {
            get { return _Languages; }
            set { _Languages = value; }
        }
        public string PersonalityTraits
        {
            get { return _PersonalityTraits; }
            set { _PersonalityTraits = value; }
        }
        public string Ideals
        {
            get { return _Ideals; }
            set { _Ideals = value; }
        }
        public string Bonds
        {
            get { return _Bonds; }
            set { _Bonds = value; }
        }
        public string Flaws
        {
            get { return _Flaws; }
            set { _Flaws = value; }
        }
        public string Weapons
        {
            get { return _Weapons; }
            set { _Weapons = value; }
        }
        public string Currency
        {
            get { return _Currency; }
            set { _Currency = value; }
        }
        public string Armor
        {
            get { return _Armor; }
            set { _Armor = value; }
        }
        public string Tresures
        {
            get { return _Tresures; }
            set { _Tresures = value; }
        }
        public string Ammunition
        {
            get { return _Ammunition; }
            set { _Ammunition = value; }
        }
        //sets the skills array true if they are proficant false if not 
        public void SetSkillsArray(int SkillNumber, bool SkillProficant)
        {
            _SkillsAray[SkillNumber] = SkillProficant;
            tempSkillArray[SkillNumber] = _SkillsAray[SkillNumber];
        }
        public bool GetSkillArray(int SkillNumber)
        {
            return tempSkillArray[SkillNumber];
        }
    }
}
