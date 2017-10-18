using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM_Assistant.Entities
{
    class Player:Creature
    {
        #region Constructors
        public Player()
            : base()
        {

        }
        #endregion  
        #region Class Properties
        public string Class { get; set; }
        public string Background { get; set; }
        public string Feats { get; set; }
        public string Traits { get; set; }
        public string Proficiencies { get; set; }
        public string Languages { get; set; }
        public string PersonalityTraits { get; set; }
        public string Ideals { get; set; }
        public string Bonds { get; set; }
        public string Flaws { get; set; }
        public string Weapons { get; set; }
        public string Currency { get; set; }
        public string Armor { get; set; }
        public string Teasures { get; set; }
        public int ProficancyMod { get; set; }
        public string Ammunition { get; set; }
        // each bool represents a differnt skill
        private bool[] _SkillsAray = new bool[24];
        private bool[] tempSkillArray = new bool[24];
#endregion

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
