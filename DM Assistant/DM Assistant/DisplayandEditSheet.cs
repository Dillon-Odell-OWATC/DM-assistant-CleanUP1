using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace DM_Assistant
{
    public partial class DisplayandEditSheet : Form
    {
        public DisplayandEditSheet()
        {
            InitializeComponent();
        }
        //declairing the player class
        Player NewPlayer = new Player();
        CheckBox[] chk = new CheckBox[24];
        //Slill Checks check to see what skills are checkboxed and sets the newplayer object correctly sets the corresponding lables to display correct values
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
        //Sets the skills after loading
        private void SetSkillschk()
        {
            int SkillNum = 0;
            chk[SkillNum] = chkSTRSavingThrow;
            SkillNum++;
            chk[SkillNum] = chkAthletics;
            SkillNum++;
            chk[SkillNum] = chkDEXSavingThrow;
            SkillNum++;
            chk[SkillNum] = chkAcrobatics;
            SkillNum++;
            chk[SkillNum] = chkSleightOfHand;
            SkillNum++;
            chk[SkillNum] = chkStealth;
            SkillNum++;
            chk[SkillNum] = chkCONSavingThrow;
            SkillNum++;
            chk[SkillNum] = chkINTSavingThrow;
            SkillNum++;
            chk[SkillNum] = chkArcana;
            SkillNum++;
            chk[SkillNum] = chkHistory;
            SkillNum++;
            chk[SkillNum] = chkInvestigation;
            SkillNum++;
            chk[SkillNum] = chkNature;
            SkillNum++;
            chk[SkillNum] = chkReligion;
            SkillNum++;
            chk[SkillNum] = chkWISSavingThrow;
            SkillNum++;
            chk[SkillNum] = chkAnimalHandling;
            SkillNum++;
            chk[SkillNum] = chkInsight;
            SkillNum++;
            chk[SkillNum] = chkMedicine;
            SkillNum++;
            chk[SkillNum] = chkPerception;
            SkillNum++;
            chk[SkillNum] = chkSurvival;
            SkillNum++;
            chk[SkillNum] = chkCHASavingThrow;
            SkillNum++;
            chk[SkillNum] = chkDeception;
            SkillNum++;
            chk[SkillNum] = chkIntimidation;
            SkillNum++;
            chk[SkillNum] = chkPerformance;
            SkillNum++;
            chk[SkillNum] = chkPersuasion;
        }
        //Functions for setting player attributes
        private void SetSTR()
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
            else if (txtSTR.Text != "")
            {
                MessageBox.Show("only numbers for STR please");
            }
            STRSkillCheck();
        }
        private void SetDEX()
        {
            int DEX;
            if (int.TryParse(txtDEX.Text, out DEX))
            {
                NewPlayer.DEX = DEX;
                DEX = SetStatMod(DEX);
                if (DEX <= 0)
                {
                    lblDEX.Text = DEX.ToString("0");
                }
                else
                {
                    lblDEX.Text = "+" + DEX.ToString("0");
                }
            }
            else if (txtDEX.Text != "")
            {
                MessageBox.Show("only numbers for DEX please");
            }
            DEXSkillCheck();
        }
        private void SetCON()
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
            else if (txtCON.Text != "")
            {
                MessageBox.Show("only numbers for CON please");
            }
            CONSkillCheck();
        }
        private void SetINT()
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
            else if (txtINT.Text != "")
            {
                MessageBox.Show("only numbers for INT please");
            }
            INTSkillCheck();
        }
        private void SetWIS()
        {
            int WIS;
            int PassiveWis;
            if (int.TryParse(txtWIS.Text, out WIS))
            {
                NewPlayer.WIS = WIS;
                WIS = SetStatMod(WIS);
                PassiveWis = 10 + WIS;
                lblPassiveWisdom.Text = PassiveWis.ToString();
                if (WIS <= 0)
                {
                    lblWIS.Text = WIS.ToString("0");
                }
                else
                {
                    lblWIS.Text = "+" + WIS.ToString("0");
                }
            }
            else if (txtWIS.Text != "")
            {
                MessageBox.Show("only numbers for WIS please");
            }
            WISSkillCheck();
        }
        private void SetCHA()
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
            else if (txtCHA.Text != "")
            {
                MessageBox.Show("only numbers for CHA please");
            }
            CHASkillCheck();
        }
        private void SetSpeed()
        {
            int Speed;
            if (int.TryParse(txtSpeed.Text, out Speed))
            {
                NewPlayer.Speed = Speed;
            }
            else if (txtSpeed.Text != "")
            {
                MessageBox.Show("only numbers for Speed please");
            }
        }
        private void SetHP()
        {
            int HP;
            if (int.TryParse(txtHP.Text, out HP))
            {
                NewPlayer.HP = HP;
            }
            else if (txtHP.Text != "")
            {
                MessageBox.Show("only numbers for HP please");
            }
        }
        private void SetAC()
        {
            int AC;
            if (int.TryParse(txtAC.Text, out AC))
            {
                NewPlayer.AC = AC;
            }
            else if (txtAC.Text != "")
            {
                MessageBox.Show("only numbers for AC please");
            }
        }
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
        //Sets the level off the exp and the proficancy bounus off the level
        private void SetEXP()
        {
            //Sets the lvl according to the exp 
            int intEXP;
            int intLevel;
            int intProficancy;
            // used to keep the skills list up to date
            if (int.TryParse(txtEXP.Text, out intEXP))
            {
                NewPlayer.EXP = intEXP;
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
                if (int.TryParse(lblLevel.Text, out intLevel))
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
            else if (txtEXP.Text != "")
            {
                MessageBox.Show("only numbers for EXP please");
            }
            SkillCheck();
        }
        //returns the mod for the skill panel
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
        //lets user pick file location and name and save it
        public void SaveFile()
        {
            //Grabs the info from the test boxes and formats them into a single line 
            string strAmmunition = Regex.Replace(txtAmmunition.Text, @"\t|\r|\n", "<br>");
            string strArmor = Regex.Replace(txtArmor.Text, @"\t|\r|\n", "<br>");
            string strTresures = Regex.Replace(txtTresures.Text, @"\t|\r|\n", "<br>");
            string strCurrency = Regex.Replace(txtCurrency.Text, @"\t|\r|\n", "<br>");
            string strWeapons = Regex.Replace(txtWeapons.Text, @"\t|\r|\n", "<br>");
            string strFlaws = Regex.Replace(txtFlaws.Text, @"\t|\r|\n", "<br>");
            string strBonds = Regex.Replace(txtBonds.Text, @"\t|\r|\n", "<br>");
            string strIdeals = Regex.Replace(txtIdeals.Text, @"\t|\r|\n", "<br>");
            string strPersonalityTraits = Regex.Replace(txtPersonalityTraits.Text, @"\t|\r|\n", "<br>");
            string strLanguages = Regex.Replace(txtLanguages.Text, @"\t|\r|\n", "<br>");
            string strProficiencies = Regex.Replace(txtProficiencies.Text, @"\t|\r|\n", "<br>");
            string strTraits = Regex.Replace(txtTraits.Text, @"\t|\r|\n", "<br>");
            string strFeats = Regex.Replace(txtFeats.Text, @"\t|\r|\n", "<br>");
            string strOtherInventory = Regex.Replace(txtOtherInventory.Text, @"\t|\r|\n", "<br>");
            try
            {
                SaveFileDialog SaveLocation = new SaveFileDialog();
                SaveLocation.ShowDialog();
                if (SaveLocation.FileName != "")
                {
                    int CONSKILLSNUM = 24;
                    //makes the file and sets the save line order
                    StreamWriter PlayerSheet = new StreamWriter(SaveLocation.FileName);
                    PlayerSheet.WriteLine(NewPlayer.Name);
                    PlayerSheet.WriteLine(NewPlayer.EXP);
                    PlayerSheet.WriteLine(lblRace.Text);
                    PlayerSheet.WriteLine(NewPlayer.Class);
                    PlayerSheet.WriteLine(lblBackground.Text);
                    PlayerSheet.WriteLine(NewPlayer.Alignment);
                    PlayerSheet.WriteLine(NewPlayer.STR);
                    PlayerSheet.WriteLine(NewPlayer.DEX);
                    PlayerSheet.WriteLine(NewPlayer.CON);
                    PlayerSheet.WriteLine(NewPlayer.INT);
                    PlayerSheet.WriteLine(NewPlayer.WIS);
                    PlayerSheet.WriteLine(NewPlayer.CHA);
                    PlayerSheet.WriteLine(NewPlayer.Speed);
                    PlayerSheet.WriteLine(NewPlayer.AC);
                    PlayerSheet.WriteLine(NewPlayer.HP);
                    PlayerSheet.WriteLine(strFeats);
                    PlayerSheet.WriteLine(strTraits);
                    PlayerSheet.WriteLine(strProficiencies);
                    PlayerSheet.WriteLine(strLanguages);
                    PlayerSheet.WriteLine(strPersonalityTraits);
                    PlayerSheet.WriteLine(strIdeals);
                    PlayerSheet.WriteLine(strBonds);
                    PlayerSheet.WriteLine(strFlaws);
                    PlayerSheet.WriteLine(strWeapons);
                    PlayerSheet.WriteLine(strCurrency);
                    PlayerSheet.WriteLine(strTresures);
                    PlayerSheet.WriteLine(strArmor);
                    PlayerSheet.WriteLine(strAmmunition);
                    PlayerSheet.WriteLine(strOtherInventory);
                    PlayerSheet.WriteLine(txtMaker.Text);
                    //Saves the Skill list
                    for (int I = 0; I < CONSKILLSNUM; I++)
                    {
                        if (NewPlayer.GetSkillArray(I))
                        {
                            PlayerSheet.WriteLine("True");
                        }
                        else
                        {
                            PlayerSheet.WriteLine("False");
                        }
                    }
                    PlayerSheet.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //lets user pick file location and load it
        public void OpenFile()
        {
            OpenFileDialog OpenLocation = new OpenFileDialog();
            OpenLocation.ShowDialog();
            if (OpenLocation.FileName != "")
            {
                //Number of skills
                int CONSKILLSNUM = 24;
                int TempInt;
                string TempString ="";
                //Reads file and sets up the txtboxes labkes and checkboxes to the right values
                try
                {
                    StreamReader PlayerSheet = new StreamReader(OpenLocation.FileName);
                    txtName.Text = PlayerSheet.ReadLine();
                    txtEXP.Text = PlayerSheet.ReadLine();
                    lblRace.Text = PlayerSheet.ReadLine();
                    txtClass.Text = PlayerSheet.ReadLine();
                    lblBackground.Text = PlayerSheet.ReadLine();
                    cmbAlignment.Text = PlayerSheet.ReadLine();
                    if (int.TryParse(PlayerSheet.ReadLine(), out TempInt))
                    {
                        txtSTR.Text = TempInt.ToString();
                    }
                    if (int.TryParse(PlayerSheet.ReadLine(), out TempInt))
                    {
                        txtDEX.Text = TempInt.ToString();
                    }
                    if (int.TryParse(PlayerSheet.ReadLine(), out TempInt))
                    {
                        txtCON.Text = TempInt.ToString();
                    }
                    if (int.TryParse(PlayerSheet.ReadLine(), out TempInt))
                    {
                        txtINT.Text = TempInt.ToString();
                    }
                    if (int.TryParse(PlayerSheet.ReadLine(), out TempInt))
                    {
                        txtWIS.Text = TempInt.ToString();
                    }
                    if (int.TryParse(PlayerSheet.ReadLine(), out TempInt))
                    {
                        txtCHA.Text = TempInt.ToString();
                    }
                    if (int.TryParse(PlayerSheet.ReadLine(), out TempInt))
                    {
                        txtSpeed.Text = TempInt.ToString();
                    }
                    if (int.TryParse(PlayerSheet.ReadLine(), out TempInt))
                    {
                        txtAC.Text = TempInt.ToString();
                    }
                    if (int.TryParse(PlayerSheet.ReadLine(), out TempInt))
                    {
                        txtHP.Text = TempInt.ToString();
                    }
                    TempString = PlayerSheet.ReadLine();
                    txtFeats.Text = TempString.Replace("<br><br>", System.Environment.NewLine);
                    TempString = PlayerSheet.ReadLine();
                    txtTraits.Text = TempString.Replace("<br><br>", System.Environment.NewLine);
                    TempString = PlayerSheet.ReadLine();
                    txtProficiencies.Text = TempString.Replace("<br><br>", System.Environment.NewLine);
                    TempString = PlayerSheet.ReadLine();
                    txtLanguages.Text = TempString.Replace("<br><br>", System.Environment.NewLine);
                    TempString = PlayerSheet.ReadLine();
                    txtPersonalityTraits.Text = TempString.Replace("<br><br>", System.Environment.NewLine);
                    TempString = PlayerSheet.ReadLine();
                    txtIdeals.Text = TempString.Replace("<br><br>", System.Environment.NewLine);
                    TempString = PlayerSheet.ReadLine();
                    txtBonds.Text = TempString.Replace("<br><br>", System.Environment.NewLine);
                    TempString = PlayerSheet.ReadLine();
                    txtFlaws.Text = TempString.Replace("<br><br>", System.Environment.NewLine);
                    TempString = PlayerSheet.ReadLine();
                    txtWeapons.Text = TempString.Replace("<br><br>", System.Environment.NewLine);
                    TempString = PlayerSheet.ReadLine();
                    txtCurrency.Text = TempString.Replace("<br><br>", System.Environment.NewLine);
                    TempString = PlayerSheet.ReadLine();
                    txtTresures.Text = TempString.Replace("<br><br>", System.Environment.NewLine);
                    TempString = PlayerSheet.ReadLine();
                    txtArmor.Text = TempString.Replace("<br><br>", System.Environment.NewLine);
                    TempString = PlayerSheet.ReadLine();
                    txtAmmunition.Text = TempString.Replace("<br><br>", System.Environment.NewLine);
                    TempString = PlayerSheet.ReadLine();
                    txtOtherInventory.Text = TempString.Replace("<br><br>", System.Environment.NewLine);
                    txtMaker.Text = PlayerSheet.ReadLine();
                    SetSkillschk();
                    for (int I = 0; I <= CONSKILLSNUM; I++)
                    {
                        TempString = PlayerSheet.ReadLine();
                        if (TempString == "True")
                        {
                            NewPlayer.SetSkillsArray(I, true);
                            chk[I].Checked = true;

                        }
                        else if (TempString == "False")
                        {
                            NewPlayer.SetSkillsArray(I, false);
                            chk[I].Checked = false;
                        }
                    }
                    PlayerSheet.Close();
                    SetSTR();
                    SetDEX();
                    SetCON();
                    SetINT();
                    SetWIS();
                    SetCHA();
                    SetEXP();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DisplayandEditSheet_Load(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            NewPlayer.Name = txtName.Text;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

        private void txtClass_TextChanged(object sender, EventArgs e)
        {
            NewPlayer.Class = txtClass.Text;
        }

        private void cmbAlignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            NewPlayer.Alignment = cmbAlignment.Text;
        }

        private void txtSpeed_TextChanged(object sender, EventArgs e)
        {
            SetSpeed();
        }

        private void txtAC_TextChanged(object sender, EventArgs e)
        {
            SetAC();
        }

        private void txtHP_TextChanged(object sender, EventArgs e)
        {
            SetHP();
        }
    }
}
