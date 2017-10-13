using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DM_Assistant
{
    public partial class MakeSheet : Form
    {
        public MakeSheet()
        {
            InitializeComponent();
        }
        //declairing the player class
        Player NewPlayer = new Player();
        //Sets StatMod Accoding to stat level
        private int SetStatMod(int Stat)
        {
            int intMod = 0;
            switch (Stat)
            {
                case 1:
                    intMod = -5;
                    break;
                case 2:
                case 3:
                    intMod = -4;
                    break;
                case 4:
                case 5:
                    intMod = -3;
                        break;
                case 6:
                case 7:
                    intMod = -2;
                    break;
                case 8:
                case 9:
                    intMod = -1;
                    break;
                case 10:
                case 11:
                    intMod = 0;
                    break;
                case 12:
                case 13:
                    intMod = 1;
                    break;
                case 14:
                case 15:
                    intMod = 2;
                    break;
                case 16:
                case 17:
                    intMod = 3;
                    break;
                case 18:
                case 19:
                    intMod = 4;
                    break;
                case 20:
                    intMod = 5;
                    break;
            }
            return intMod;
        }
        private void txtEXP_TextChanged(object sender, EventArgs e)
        {
            //Sets the lvl according to the exp 
            int intEXP;
            int intLevel;
            int intProficancy;
            // used to keep the skills list up to date
            if (int.TryParse(txtEXP.Text, out intEXP))
            {
                if (intEXP > 355000)
                {
                    lblLevel.Text = "20";
                }
                else if (intEXP >= 305000)
                {
                    lblLevel.Text = "19";
                }
                else if (intEXP >= 265000)
                {
                    lblLevel.Text = "18";
                }
                else if (intEXP >= 225000)
                {
                    lblLevel.Text = "17";
                }
                else if (intEXP >= 195000)
                {
                    lblLevel.Text = "16";
                }
                else if (intEXP >= 165000)
                {
                    lblLevel.Text = "15";
                }
                else if (intEXP >= 140000)
                {
                    lblLevel.Text = "14";
                }
                else if (intEXP >= 120000)
                {
                    lblLevel.Text = "13";
                }
                else if (intEXP >= 100000)
                {
                    lblLevel.Text = "12";
                }
                else if (intEXP >= 85000)
                {
                    lblLevel.Text = "11";
                }
                else if (intEXP >= 64000)
                {
                    lblLevel.Text = "10";
                }
                else if (intEXP >= 48000)
                {
                    lblLevel.Text = "9";
                }
                else if (intEXP >= 34000)
                {
                    lblLevel.Text = "8";
                }
                else if (intEXP >= 23000)
                {
                    lblLevel.Text = "7";
                }
                else if (intEXP >= 14000)
                {
                    lblLevel.Text = "6";
                }
                else if (intEXP >= 6500)
                {
                    lblLevel.Text = "5";
                }
                else if (intEXP >= 2700)
                {
                    lblLevel.Text = "4";
                }
                else if (intEXP >= 900)
                {
                    lblLevel.Text = "3";
                }
                else if (intEXP >= 300)
                {
                    lblLevel.Text = "2";
                }
                else if (intEXP >= 0)
                {
                    lblLevel.Text = "1";
                }
                //Sets proficancy bounus according to level
                if(int.TryParse(lblLevel.Text, out intLevel))
                {
                    switch (intLevel)
                    {
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                            intProficancy = 2;
                            NewPlayer.ProficancyMod = intProficancy;
                            lblProficiency.Text = "+" + intProficancy;
                            break;
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                            intProficancy = 3;
                            NewPlayer.ProficancyMod = intProficancy;
                            lblProficiency.Text = "+" + intProficancy;
                            break;
                        case 9:
                        case 10:
                        case 11:
                        case 12:
                            intProficancy = 4;
                            NewPlayer.ProficancyMod = intProficancy;
                            lblProficiency.Text = "+" + intProficancy;
                            break;
                        case 13:
                        case 14:
                        case 15:
                        case 16:
                            intProficancy = 5;
                            NewPlayer.ProficancyMod = intProficancy;
                            lblProficiency.Text = "+" + intProficancy;
                            break;
                        case 17:
                        case 18:
                        case 19:
                        case 20:
                            intProficancy = 6;
                            NewPlayer.ProficancyMod = intProficancy;
                            lblProficiency.Text = "+" + intProficancy;
                            break;
                    }

                }
            }
            SkillCheck();
        }
 
        //returns the mod for the skill panel
        public int SetSkill(int SkillNum, bool Proficant, int Statlvl)
        {
            int SkillProficancy = 0;
            SkillProficancy = SetStatMod(Statlvl);
            if (Proficant)
            {
                NewPlayer.SetSkillsArray(SkillNum, Proficant);
                if (NewPlayer.GetSkillArray(SkillNum))
                {
                    SkillProficancy += NewPlayer.ProficancyMod;
                }
            }
            return SkillProficancy;
        }
        private void txtSTR_TextChanged(object sender, EventArgs e)
        {
            int STR;
            if (int.TryParse(txtSTR.Text, out STR))
            {
                NewPlayer.STR = STR;
                STR = SetStatMod(STR);
                if (STR <= 0)
                {
                    lblSTR.Text = STR.ToString("0");
                }
                else
                {
                    lblSTR.Text = "+" + STR.ToString("0");
                }
            }
            STRSkillCheck();
        }

        private void txtDEX_TextChanged(object sender, EventArgs e)
        {
            int DEX;
            if (int.TryParse(txtDEX.Text, out DEX))
            {
                NewPlayer.DEX = DEX;
                DEX = SetStatMod(DEX);
                if (DEX <= 0)
                {
                    lblDEX.Text = DEX.ToString("0");
                    txtInitative.Text = DEX.ToString("0");
                }
                else
                {
                    lblDEX.Text = "+" + DEX.ToString("0");
                    txtInitative.Text ="+" + DEX.ToString("0");
                }
            }
            DEXSkillCheck();
        }

        private void txtCON_TextChanged(object sender, EventArgs e)
        {
            int CON;
            if (int.TryParse(txtCON.Text, out CON))
            {
                NewPlayer.CON = CON;
                CON = SetStatMod(CON);
                if (CON <= 0)
                {
                    lblCON.Text = CON.ToString("0");
                }
                else
                {
                    lblCON.Text = "+" + CON.ToString("0");
                }
            }
            CONSkillCheck();
        }

        private void txtINT_TextChanged(object sender, EventArgs e)
        {
            int INT;
            if (int.TryParse(txtINT.Text, out INT))
            {
                NewPlayer.INT = INT;
                INT = SetStatMod(INT);
                if (INT <= 0)
                {
                    lblINT.Text = INT.ToString("0");
                }
                else
                {
                    lblINT.Text = "+" + INT.ToString("0");
                }
            }
            INTSkillCheck();
        }

        private void txtWIS_TextChanged(object sender, EventArgs e)
        {
            int WIS;
            if (int.TryParse(txtWIS.Text, out WIS))
            {
                NewPlayer.WIS = WIS;
                WIS = SetStatMod(WIS);
                if (WIS <= 0)
                {
                    lblWIS.Text = WIS.ToString("0");
                }
                else
                {
                    lblWIS.Text = "+" + WIS.ToString("0");
                }
            }
            WISSkillCheck();
        }

        private void txtCHA_TextChanged(object sender, EventArgs e)
        {
            int CHA;
            if (int.TryParse(txtCHA.Text, out CHA))
            {
                NewPlayer.CHA = CHA;
                CHA = SetStatMod(CHA);
                if (CHA <= 0)
                {
                    lblCHA.Text = CHA.ToString("0");
                }
                else
                {
                    lblCHA.Text = "+" + CHA.ToString("0");
                }
            }
            CHASkillCheck();
            MessageBox.Show(NewPlayer.CHA.ToString());
        }

        private void cmbRace_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MakeSheet_Load(object sender, EventArgs e)
        {
             
        }
        private void STRSkillCheck()
        {
            int Mod;
            int SkillNumber = 0;
            //str skills check 
            // Skill 0
            if (chkSTRSavingThrow.Checked)
            {
                Mod = SetSkill(SkillNumber, true, NewPlayer.STR);
                if (Mod <= 0)
                {
                    lblSTRSavingThrow.Text = Mod.ToString("0");
                }
                else
                {
                    lblSTRSavingThrow.Text = "+" + Mod.ToString("0");
                }
            }
            else if (!chkSTRSavingThrow.Checked)
            {
                Mod = SetSkill(SkillNumber, false, NewPlayer.STR);
                if (Mod <= 0)
                {
                    lblSTRSavingThrow.Text = Mod.ToString("0");
                }
                else
                {
                    lblSTRSavingThrow.Text = "+" + Mod.ToString("0");
                }
            }
            //changes it to the next skill check
            //1
            SkillNumber++;
            if (chkAthletics.Checked)
            {
                Mod = SetSkill(1, true, NewPlayer.STR);
                if (Mod <= 0)
                {
                    lblAthletics.Text = Mod.ToString("0");
                }
                else
                {
                    lblAthletics.Text = "+" + Mod.ToString("0");
                }
            }
            else if (!chkAthletics.Checked)
            {
                Mod = SetSkill(1, false, NewPlayer.STR);
                if (Mod <= 0)
                {
                    lblAthletics.Text = Mod.ToString("0");
                }
                else
                {
                    lblAthletics.Text = "+" + Mod.ToString("0");
                }
            }
        }
        private void DEXSkillCheck()
        {
            int SkillNumber = 1;
            int Mod;
            //2
            SkillNumber++;
            if (chkDEXSavingThrow.Checked)
            {
                Mod = SetSkill(SkillNumber, true, NewPlayer.DEX);
                if (Mod <= 0)
                {
                    lblDEXSavingThrow.Text = Mod.ToString("0");
                }
                else
                {
                    lblDEXSavingThrow.Text = "+" + Mod.ToString("0");
                }
            }
            else if (!chkDEXSavingThrow.Checked)
            {
                Mod = SetSkill(SkillNumber, false, NewPlayer.DEX);
                if (Mod <= 0)
                {
                    lblDEXSavingThrow.Text = Mod.ToString("0");
                }
                else
                {
                    lblDEXSavingThrow.Text = "+" + Mod.ToString("0");
                }
            }
            //3
            SkillNumber++;
            if (chkAcrobatics.Checked)
            {
                Mod = SetSkill(SkillNumber, true, NewPlayer.DEX);
                if (Mod <= 0)
                {
                    lblAcrobatics.Text = Mod.ToString("0");
                }
                else
                {
                    lblAcrobatics.Text = "+" + Mod.ToString("0");
                }
            }
            else if (!chkAcrobatics.Checked)
            {
                Mod = SetSkill(SkillNumber, false, NewPlayer.DEX);
                if (Mod <= 0)
                {
                    lblAcrobatics.Text = Mod.ToString("0");
                }
                else
                {
                    lblAcrobatics.Text = "+" + Mod.ToString("0");
                }
            }
            //4
            SkillNumber++;
            if (chkSleightOfHand.Checked)
            {
                Mod = SetSkill(SkillNumber, true, NewPlayer.DEX);
                if (Mod <= 0)
                {
                    lblSleightOfHand.Text = Mod.ToString("0");
                }
                else
                {
                    lblSleightOfHand.Text = "+" + Mod.ToString("0");
                }
            }
            else if (!chkSleightOfHand.Checked)
            {
                Mod = SetSkill(SkillNumber, false, NewPlayer.DEX);
                if (Mod <= 0)
                {
                    lblSleightOfHand.Text = Mod.ToString("0");
                }
                else
                {
                    lblSleightOfHand.Text = "+" + Mod.ToString("0");
                }
            }
            //5
            SkillNumber++;
            if (chkStealth.Checked)
            {
                Mod = SetSkill(SkillNumber, true, NewPlayer.DEX);
                if (Mod <= 0)
                {
                    lblStealth.Text = Mod.ToString("0");
                }
                else
                {
                    lblStealth.Text = "+" + Mod.ToString("0");
                }
            }
            else if (!chkStealth.Checked)
            {
                Mod = SetSkill(SkillNumber, false, NewPlayer.DEX);
                if (Mod <= 0)
                {
                    lblStealth.Text = Mod.ToString("0");
                }
                else
                {
                    lblStealth.Text = "+" + Mod.ToString("0");
                }
            }
        }
        private void CONSkillCheck()
        {
            int SkillNumber = 5;
            int Mod;
            //con skill check 
            //6
            SkillNumber++;
            if (chkCONSavingThrow.Checked)
            {
                Mod = SetSkill(SkillNumber, true, NewPlayer.CON);
                if (Mod <= 0)
                {
                    lblCONSavingThrow.Text = Mod.ToString("0");
                }
                else
                {
                    lblCONSavingThrow.Text = "+" + Mod.ToString("0");
                }
            }
            else if (!chkCONSavingThrow.Checked)
            {
                Mod = SetSkill(SkillNumber, false, NewPlayer.CON);
                if (Mod <= 0)
                {
                    lblCONSavingThrow.Text = Mod.ToString("0");
                }
                else
                {
                    lblCONSavingThrow.Text = "+" + Mod.ToString("0");
                }
            }
        }
        private void INTSkillCheck()
        {

            int SkillNumber = 6;
            int Mod;
            //INT skill check 
            //7
            SkillNumber++;
            if (chkINTSavingThrow.Checked)
            {
                Mod = SetSkill(SkillNumber, true, NewPlayer.INT);
                if (Mod <= 0)
                {
                    lblINTSavingThrow.Text = Mod.ToString("0");
                }
                else
                {
                    lblINTSavingThrow.Text = "+" + Mod.ToString("0");
                }
            }
            else if (!chkINTSavingThrow.Checked)
            {
                Mod = SetSkill(SkillNumber, false, NewPlayer.INT);
                if (Mod <= 0)
                {
                    lblINTSavingThrow.Text = Mod.ToString("0");
                }
                else
                {
                    lblINTSavingThrow.Text = "+" + Mod.ToString("0");
                }
            }
            //8
            SkillNumber++;
            if (chkArcana.Checked)
            {
                Mod = SetSkill(SkillNumber, true, NewPlayer.INT);
                if (Mod <= 0)
                {
                    lblArcana.Text = Mod.ToString("0");
                }
                else
                {
                    lblArcana.Text = "+" + Mod.ToString("0");
                }
            }
            else if (!chkArcana.Checked)
            {
                Mod = SetSkill(SkillNumber, false, NewPlayer.INT);
                if (Mod <= 0)
                {
                    lblArcana.Text = Mod.ToString("0");
                }
                else
                {
                    lblArcana.Text = "+" + Mod.ToString("0");
                }
            }
            //9
            SkillNumber++;
            if (chkHistory.Checked)
            {
                Mod = SetSkill(SkillNumber, true, NewPlayer.INT);
                if (Mod <= 0)
                {
                    lblHistory.Text = Mod.ToString("0");
                }
                else
                {
                    lblHistory.Text = "+" + Mod.ToString("0");
                }
            }
            else if (!chkHistory.Checked)
            {
                Mod = SetSkill(SkillNumber, false, NewPlayer.INT);
                if (Mod <= 0)
                {
                    lblHistory.Text = Mod.ToString("0");
                }
                else
                {
                    lblHistory.Text = "+" + Mod.ToString("0");
                }
            }
            //10
            SkillNumber++;
            if (chkInvestigation.Checked)
            {
                Mod = SetSkill(SkillNumber, true, NewPlayer.INT);
                if (Mod <= 0)
                {
                    lblInvestigation.Text = Mod.ToString("0");
                }
                else
                {
                    lblInvestigation.Text = "+" + Mod.ToString("0");
                }
            }
            else if (!chkInvestigation.Checked)
            {
                Mod = SetSkill(SkillNumber, false, NewPlayer.INT);
                if (Mod <= 0)
                {
                    lblInvestigation.Text = Mod.ToString("0");
                }
                else
                {
                    lblInvestigation.Text = "+" + Mod.ToString("0");
                }
            }
            //11
            SkillNumber++;
            if (chkNature.Checked)
            {
                Mod = SetSkill(SkillNumber, true, NewPlayer.INT);
                if (Mod <= 0)
                {
                    lblNature.Text = Mod.ToString("0");
                }
                else
                {
                    lblNature.Text = "+" + Mod.ToString("0");
                }
            }
            else if (!chkNature.Checked)
            {
                Mod = SetSkill(SkillNumber, false, NewPlayer.INT);
                if (Mod <= 0)
                {
                    lblNature.Text = Mod.ToString("0");
                }
                else
                {
                    lblNature.Text = "+" + Mod.ToString("0");
                }
            }
            //12
            SkillNumber++;
            if (chkReligion.Checked)
            {
                Mod = SetSkill(SkillNumber, true, NewPlayer.INT);
                if (Mod <= 0)
                {
                    lblReligion.Text = Mod.ToString("0");
                }
                else
                {
                    lblReligion.Text = "+" + Mod.ToString("0");
                }
            }
            else if (!chkReligion.Checked)
            {
                Mod = SetSkill(SkillNumber, false, NewPlayer.INT);
                if (Mod <= 0)
                {
                    lblReligion.Text = Mod.ToString("0");
                }
                else
                {
                    lblReligion.Text = "+" + Mod.ToString("0");
                }
            }
        }
        private void WISSkillCheck()
        {
            int SkillNumber = 12;
            int Mod;
            //wis skill check 
            //13
            SkillNumber++;
            if (chkWISSavingThrow.Checked)
            {
                Mod = SetSkill(SkillNumber, true, NewPlayer.WIS);
                if (Mod <= 0)
                {
                    lblWISSavingThrow.Text = Mod.ToString("0");
                }
                else
                {
                    lblWISSavingThrow.Text = "+" + Mod.ToString("0");
                }
            }
            else if (!chkWISSavingThrow.Checked)
            {
                Mod = SetSkill(SkillNumber, false, NewPlayer.WIS);
                if (Mod <= 0)
                {
                    lblWISSavingThrow.Text = Mod.ToString("0");
                }
                else
                {
                    lblWISSavingThrow.Text = "+" + Mod.ToString("0");
                }
            }
            //14
            SkillNumber++;
            if (chkAnimalHandling.Checked)
            {
                Mod = SetSkill(SkillNumber, true, NewPlayer.WIS);
                if (Mod <= 0)
                {
                    lblAnimalHandling.Text = Mod.ToString("0");
                }
                else
                {
                    lblAnimalHandling.Text = "+" + Mod.ToString("0");
                }
            }
            else if (!chkAnimalHandling.Checked)
            {
                Mod = SetSkill(SkillNumber, false, NewPlayer.WIS);
                if (Mod <= 0)
                {
                    lblAnimalHandling.Text = Mod.ToString("0");
                }
                else
                {
                    lblAnimalHandling.Text = "+" + Mod.ToString("0");
                }
            }
            //15
            SkillNumber++;
            if (chkInsight.Checked)
            {
                Mod = SetSkill(SkillNumber, true, NewPlayer.WIS);
                if (Mod <= 0)
                {
                    lblInsight.Text = Mod.ToString("0");
                }
                else
                {
                    lblInsight.Text = "+" + Mod.ToString("0");
                }
            }
            else if (!chkInsight.Checked)
            {
                Mod = SetSkill(SkillNumber, false, NewPlayer.WIS);
                if (Mod <= 0)
                {
                    lblInsight.Text = Mod.ToString("0");
                }
                else
                {
                    lblInsight.Text = "+" + Mod.ToString("0");
                }
            }
            //16
            SkillNumber++;
            if (chkMedicine.Checked)
            {
                Mod = SetSkill(SkillNumber, true, NewPlayer.WIS);
                if (Mod <= 0)
                {
                    lblMedicine.Text = Mod.ToString("0");
                }
                else
                {
                    lblMedicine.Text = "+" + Mod.ToString("0");
                }
            }
            else if (!chkMedicine.Checked)
            {
                Mod = SetSkill(SkillNumber, false, NewPlayer.WIS);
                if (Mod <= 0)
                {
                    lblMedicine.Text = Mod.ToString("0");
                }
                else
                {
                    lblMedicine.Text = "+" + Mod.ToString("0");
                }
            }
            //17
            SkillNumber++;
            if (chkPerception.Checked)
            {
                Mod = SetSkill(SkillNumber, true, NewPlayer.WIS);
                if (Mod <= 0)
                {
                    lblPerception.Text = Mod.ToString("0");
                }
                else
                {
                    lblPerception.Text = "+" + Mod.ToString("0");
                }
            }
            else if (!chkPerception.Checked)
            {
                Mod = SetSkill(SkillNumber, false, NewPlayer.WIS);
                if (Mod <= 0)
                {
                    lblPerception.Text = Mod.ToString("0");
                }
                else
                {
                    lblPerception.Text = "+" + Mod.ToString("0");
                }
            }
            //18
            SkillNumber++;
            if (chkSurvival.Checked)
            {
                Mod = SetSkill(SkillNumber, true, NewPlayer.WIS);
                if (Mod <= 0)
                {
                    lblSurvival.Text = Mod.ToString("0");
                }
                else
                {
                    lblSurvival.Text = "+" + Mod.ToString("0");
                }
            }
            else if (!chkSurvival.Checked)
            {
                Mod = SetSkill(SkillNumber, false, NewPlayer.WIS);
                if (Mod <= 0)
                {
                    lblSurvival.Text = Mod.ToString("0");
                }
                else
                {
                    lblSurvival.Text = "+" + Mod.ToString("0");
                }
            }
        }
        private void CHASkillCheck()
        {
            int SkillNumber = 18;
            int Mod;
            //cha skill check 
            //19
            SkillNumber++;
            if (chkCHASavingThrow.Checked)
            {
                Mod = SetSkill(SkillNumber, true, NewPlayer.CHA);
                if (Mod <= 0)
                {
                    lblCHASavingThrow.Text = Mod.ToString("0");
                }
                else
                {
                    lblCHASavingThrow.Text = "+" + Mod.ToString("0");
                }
            }
            else if (!chkCHASavingThrow.Checked)
            {
                Mod = SetSkill(SkillNumber, false, NewPlayer.CHA);
                if (Mod <= 0)
                {
                    lblCHASavingThrow.Text = Mod.ToString("0");
                }
                else
                {
                    lblCHASavingThrow.Text = "+" + Mod.ToString("0");
                }
            }
            //20
            SkillNumber++;
            if (chkDeception.Checked)
            {
                Mod = SetSkill(SkillNumber, true, NewPlayer.CHA);
                if (Mod <= 0)
                {
                    lblDeception.Text = Mod.ToString("0");
                }
                else
                {
                    lblDeception.Text = "+" + Mod.ToString("0");
                }
            }
            else if (!chkDeception.Checked)
            {
                Mod = SetSkill(SkillNumber, false, NewPlayer.CHA);
                if (Mod <= 0)
                {
                    lblDeception.Text = Mod.ToString("0");
                }
                else
                {
                    lblDeception.Text = "+" + Mod.ToString("0");
                }
            }
            //21
            SkillNumber++;
            if (chkIntimidation.Checked)
            {
                Mod = SetSkill(SkillNumber, true, NewPlayer.CHA);
                if (Mod <= 0)
                {
                    lblIntimidation.Text = Mod.ToString("0");
                }
                else
                {
                    lblIntimidation.Text = "+" + Mod.ToString("0");
                }
            }
            else if (!chkIntimidation.Checked)
            {
                Mod = SetSkill(SkillNumber, false, NewPlayer.CHA);
                if (Mod <= 0)
                {
                    lblIntimidation.Text = Mod.ToString("0");
                }
                else
                {
                    lblIntimidation.Text = "+" + Mod.ToString("0");
                }
            }
            //22
            SkillNumber++;
            if (chkPerformance.Checked)
            {
                Mod = SetSkill(SkillNumber, true, NewPlayer.CHA);
                if (Mod <= 0)
                {
                    lblPerformance.Text = Mod.ToString("0");
                }
                else
                {
                    lblPerformance.Text = "+" + Mod.ToString("0");
                }
            }
            else if (!chkPerformance.Checked)
            {
                Mod = SetSkill(SkillNumber, false, NewPlayer.CHA);
                if (Mod <= 0)
                {
                    lblPerformance.Text = Mod.ToString("0");
                }
                else
                {
                    lblPerformance.Text = "+" + Mod.ToString("0");
                }
            }
            //23
            SkillNumber++;
            if (chkPersuasion.Checked)
            {
                Mod = SetSkill(SkillNumber, true, NewPlayer.CHA);
                if (Mod <= 0)
                {
                    lblPersuasion.Text = Mod.ToString("0");
                }
                else
                {
                    lblPersuasion.Text = "+" + Mod.ToString("0");
                }
            }
            else if (!chkPersuasion.Checked)
            {
                Mod = SetSkill(SkillNumber, false, NewPlayer.CHA);
                if (Mod <= 0)
                {
                    lblPersuasion.Text = Mod.ToString("0");
                }
                else
                {
                    lblPersuasion.Text = "+" + Mod.ToString("0");
                }
            }
        }
        private void SkillCheck()
        {
            STRSkillCheck();
            DEXSkillCheck();
            CONSkillCheck();
            INTSkillCheck();
            WISSkillCheck();
            CHASkillCheck();
        }
        //Checkboxes
        private void chkSTRSavingThrow_CheckedChanged(object sender, EventArgs e)
        {
            STRSkillCheck();
        }

        private void chkAthletics_CheckedChanged(object sender, EventArgs e)
        {
            STRSkillCheck();
        }

        private void chkDEXSavingThrow_CheckedChanged(object sender, EventArgs e)
        {
            DEXSkillCheck();
        }

        private void chkAcrobatics_CheckedChanged(object sender, EventArgs e)
        {
            DEXSkillCheck();
        }

        private void chkSleightOfHand_CheckedChanged(object sender, EventArgs e)
        {
            DEXSkillCheck();
        }

        private void chkStealth_CheckedChanged(object sender, EventArgs e)
        {
            DEXSkillCheck();
        }

        private void chkCONSavingThrow_CheckedChanged(object sender, EventArgs e)
        {
            CONSkillCheck();
        }

        private void chkINTSavingThrow_CheckedChanged(object sender, EventArgs e)
        {
            INTSkillCheck();
        }

        private void chkArcana_CheckedChanged(object sender, EventArgs e)
        {
            INTSkillCheck();
        }

        private void chkHistory_CheckedChanged(object sender, EventArgs e)
        {
            INTSkillCheck();
        }

        private void chkInvestigation_CheckedChanged(object sender, EventArgs e)
        {
            INTSkillCheck();
        }

        private void chkNature_CheckedChanged(object sender, EventArgs e)
        {
            INTSkillCheck();
        }

        private void chkReligion_CheckedChanged(object sender, EventArgs e)
        {
            INTSkillCheck();
        }

        private void chkWISSavingThrow_CheckedChanged(object sender, EventArgs e)
        {
            WISSkillCheck();
        }

        private void chkAnimalHandling_CheckedChanged(object sender, EventArgs e)
        {
            WISSkillCheck();
        }

        private void chkInsight_CheckedChanged(object sender, EventArgs e)
        {
            WISSkillCheck();
        }

        private void chkMedicine_CheckedChanged(object sender, EventArgs e)
        {
            WISSkillCheck();
        }

        private void chkPerception_CheckedChanged(object sender, EventArgs e)
        {
            WISSkillCheck();
        }

        private void chkSurvival_CheckedChanged(object sender, EventArgs e)
        {
            WISSkillCheck();
        }

        private void chkCHASavingThrow_CheckedChanged(object sender, EventArgs e)
        {
            CHASkillCheck();
        }

        private void chkDeception_CheckedChanged(object sender, EventArgs e)
        {
            CHASkillCheck();
        }

        private void chkIntimidation_CheckedChanged(object sender, EventArgs e)
        {
            CHASkillCheck();
        }

        private void chkPerformance_CheckedChanged(object sender, EventArgs e)
        {
            CHASkillCheck();
        }

        private void chkPersuasion_CheckedChanged(object sender, EventArgs e)
        {
            CHASkillCheck();
        }
    }
}
