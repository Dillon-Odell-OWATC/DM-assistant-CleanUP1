using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using DM_Assistant.Entities;

namespace DM_Assistant.Forms
{
    public partial class MakeSheet : Form
    {
        #region Object/Type Initialisation
        Player NewPlayer;
        #endregion

        #region Constructors
        public MakeSheet()
        {
            InitializeComponent();
            NewPlayer = new Player();
        }
        #endregion

        #region Form Methods
        private void CheckSkills()
        {
            int Mod;
            int SkillNumber = 0;

            foreach (GroupBox grp in GrpSkills.Controls.OfType<GroupBox>())
            {
                //Skill Offsets
                switch (grp.Text)
                {
                    case "STR":
                        SkillNumber = 0;
                        break;
                    case "DEX":
                        SkillNumber = 2;
                        break;
                    case "CON":
                        SkillNumber = 6;
                        break;
                    case "INT":
                        SkillNumber = 7;
                        break;
                    case "WIS":
                        SkillNumber = 13;
                        break;
                    case "CHA":
                        SkillNumber = 19;
                        break;
                    default:
                        return;
                }
                foreach (CheckBox ctr in grp.Controls.OfType<CheckBox>())
                {
                    if (ctr.Checked)
                    {
                        Mod = SetSkill(SkillNumber, ctr.Checked, NewPlayer.STR);
                        foreach (Label lbl in grp.Controls.OfType<Label>())
                        {
                            if (lbl.Name.Contains(ctr.Text.))
                            {
                                lbl.Text = Mod <= 0 ? Mod.ToString("0") : "+" + Mod.ToString("0");
                            }
                        }
                        SkillNumber++;
                    }
                }
            }
        }
        
        /* Stat mod according to level, has not been tested yet. */
        private int SetStatMod(int Stat)
        {
            int intMod = -5;
            if (Stat > 1)
                return Stat >= 20 ? 5 : (int)((double)(intMod + Stat / 2));
            else
                return intMod;
        }
        
        /* Returns Mod for the Skill Number */
        public int SetSkill(int SkillNum, bool Proficant, int Statlvl)
        {
            int SkillProficancy = 0;
            SkillProficancy = SetStatMod(Statlvl);
            NewPlayer.SetSkillsArray(SkillNum, Proficant);
            if (Proficant)
            {
                SkillProficancy += NewPlayer.ProficancyMod;
            }
            return SkillProficancy;
        }
        #endregion
        #region Event Handlers
        /* Makes changes to the Level, and Proficancy (Based on Level) */
        private void txtEXP_TextChanged(object sender, EventArgs e)
        {
            int intEXP;
            int intLevel;
            if (int.TryParse(txtEXP.Text, out intEXP))
            {
                NewPlayer.EXP = intEXP;

                /*You can set this back... You should have an algorithm rather than a chart
                //For levels.. but if need be, use and compare with a Dictionary instead of 
                //A long switch statement for each XP reached.  It seems DnD has a type of format,
                //it is possible to make an alogirthm for this, but I do not see one right off the bat.*/
                intLevel = (int)Math.Round((100 * Math.Sqrt(intEXP)) / 3000);

                /* Should be able to improve this.. just too lazy */
                if (intLevel > 20 || intLevel <= 1)
                    intLevel = intLevel > 20 ? 20 : 1;

                lblLevel.Text = intLevel.ToString();

                NewPlayer.ProficancyMod = intLevel <= 4 ? 2 : 2 + ((int)intLevel - 1 / 4);
                lblProficiency.Text = "+" + NewPlayer.ProficancyMod;
            }
            else if (txtEXP.Text != "")
            {
                MessageBox.Show("only numbers for EXP please");
            }
            CheckSkills();
        }

        private void StatChanged_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            int statChange;
            if (int.TryParse(txt.Text, out statChange))
            {
                switch (txt.Name)
                {
                    case "txtSTR":
                        NewPlayer.STR = statChange;
                        statChange = SetStatMod(statChange);
                        lblSTR.Text = statChange <= 0 ? statChange.ToString("0") : "+" + statChange.ToString();
                        break;
                    case "txtDEX":
                        NewPlayer.DEX = statChange;
                        statChange = SetStatMod(statChange);
                        lblDEX.Text = statChange <= 0 ? statChange.ToString("0") : "+" + statChange.ToString();
                        break;
                    case "txtCON":
                        NewPlayer.CON = statChange;
                        statChange = SetStatMod(statChange);
                        lblCON.Text = statChange <= 0 ? statChange.ToString("0") : "+" + statChange.ToString();
                        break;
                    case "txtINT":
                        NewPlayer.INT = statChange;
                        statChange = SetStatMod(statChange);
                        lblINT.Text = statChange <= 0 ? statChange.ToString("0") : "+" + statChange.ToString();
                        break;
                    case "txtWIS":
                        NewPlayer.WIS = statChange;
                        statChange = SetStatMod(statChange);
                        lblWIS.Text = statChange <= 0 ? statChange.ToString("0") : "+" + statChange.ToString();
                        break;
                    case "txtCHA":
                        NewPlayer.CHA = statChange;
                        statChange = SetStatMod(statChange);
                        lblCHA.Text = statChange <= 0 ? statChange.ToString("0") : "+" + statChange.ToString();
                        break;
                    default:
                        break;
                }
                
            }
            else if (txt.Text != "")
            {
                MessageBox.Show("only numbers for Stats please");
            }
            CheckSkills();
        }
        //sets the Race plan to work on this more 
        private void Identity_TextChanged(object sender, EventArgs e)
        {
            NewPlayer.Race = txtRace.Text;
            NewPlayer.Class = txtClass.Text;
            NewPlayer.Background = cmbBackground.Text;
            NewPlayer.Alignment = cmbAlignment.Text;
            NewPlayer.Name = txtName.Text;
        }

        private void AttributeChange_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            int statChange;
            if (int.TryParse(txt.Text, out statChange))
            {
                switch (txt.Name)
                {
                    case "txtSpeed":
                        NewPlayer.Speed = statChange;
                        break;
                    case "txtAC":
                        NewPlayer.AC = statChange;
                        break;
                    case "txtHP":
                        NewPlayer.HP = statChange;
                        break;
                    default:
                        break;
                }
            }
            else if (txtSpeed.Text != "")
            {
                MessageBox.Show("only numbers for Stats please");
            }       
        }

        /* Saves to File */
        private void btnMake_Click(object sender, EventArgs e)
        {
            NewPlayer.Ammunition = Regex.Replace(txtAmmunition.Text, @"\t|\r|\n", "<br>");
            NewPlayer.Armor = Regex.Replace(txtArmor.Text, @"\t|\r|\n", "<br>");
            NewPlayer.Treasures = Regex.Replace(txtTreasures.Text, @"\t|\r|\n", "<br>");
            NewPlayer.Currency = Regex.Replace(txtCurrency.Text, @"\t|\r|\n", "<br>");
            NewPlayer.Weapons = Regex.Replace(txtWeapons.Text, @"\t|\r|\n", "<br>");
            NewPlayer.Flaws = Regex.Replace(txtFlaws.Text, @"\t|\r|\n", "<br>");
            NewPlayer.Bonds = Regex.Replace(txtBonds.Text, @"\t|\r|\n", "<br>");
            NewPlayer.Ideals = Regex.Replace(txtIdeals.Text, @"\t|\r|\n", "<br>");
            NewPlayer.PersonalityTraits = Regex.Replace(txtPersonalityTraits.Text, @"\t|\r|\n", "<br>");
            NewPlayer.Languages = Regex.Replace(txtLanguages.Text, @"\t|\r|\n", "<br>");
            NewPlayer.Proficiencies = Regex.Replace(txtProficiencies.Text, @"\t|\r|\n", "<br>");
            NewPlayer.Traits = Regex.Replace(txtTraits.Text, @"\t|\r|\n", "<br>");
            NewPlayer.Feats = Regex.Replace(txtFeats.Text, @"\t|\r|\n", "<br>");
            NewPlayer.Other = Regex.Replace(txtOtherInventory.Text, @"\t|\r|\n", "<br>");
            NewPlayer.Maker = Regex.Replace(txtMaker.Text, @"\t|\r|\n", "<br>");
            Utilities.SaveFile(NewPlayer);
        }
        
        /* When any Checkbox Changes, this event is called */
        private void chkChange(object sender, EventArgs e)
        {
            CheckSkills();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Resets the form by making a new one and closing this one
        private void btnReset_Click(object sender, EventArgs e)
        {
            MakeSheet MakeSheet = new MakeSheet();
            MakeSheet.Show();
            this.Close();
        }
        #endregion 
    }
}
