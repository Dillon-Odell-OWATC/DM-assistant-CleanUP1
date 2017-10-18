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
    public partial class MakeMonster : Form
    {
        public MakeMonster()
        {
            InitializeComponent();
        }
        Monster NewMonster = new Monster();
        //Functions for setting attributes
        private void SetSTR()
        {
            int STR;
            if (int.TryParse(txtSTR.Text, out STR))
            {
                NewMonster.STR = STR;
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
        }
        private void SetDEX()
        {
            int DEX;
            if (int.TryParse(txtDEX.Text, out DEX))
            {
                NewMonster.DEX = DEX;
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
        }
        private void SetCON()
        {
            int CON;
            if (int.TryParse(txtCON.Text, out CON))
            {
                NewMonster.CON = CON;
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
        }
        private void SetINT()
        {
            int INT;
            if (int.TryParse(txtINT.Text, out INT))
            {
                NewMonster.INT = INT;
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
        }
        private void SetWIS()
        {
            int WIS;
            if (int.TryParse(txtWIS.Text, out WIS))
            {
                NewMonster.WIS = WIS;
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
            else if (txtWIS.Text != "")
            {
                MessageBox.Show("only numbers for WIS please");
            }
        }
        private void SetCHA()
        {
            int CHA;
            if (int.TryParse(txtCHA.Text, out CHA))
            {
                NewMonster.CHA = CHA;
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
        }
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
        private void SetFlying()
        {
            int Flying;
            if (int.TryParse(txtFlying.Text, out Flying))
            {
                NewMonster.FlyingSpeed = Flying;
            }
            else if (txtFlying.Text != "")
            {
                MessageBox.Show("only numbers for Flying please");
            }
        }
        private void SetSpeed()
        {
            int Speed;
            if (int.TryParse(txtSpeed.Text, out Speed))
            {
                NewMonster.Speed = Speed;
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
                NewMonster.HP = HP;
            }
            else if (txtHP.Text != "")
            {
                MessageBox.Show("only numbers for HP please");
            }
        }
        private void SetEXP()
        {
            int EXP;
            if (int.TryParse(txtEXP.Text, out EXP))
            {
                NewMonster.EXP = EXP;
            }
            else if (txtEXP.Text != "")
            {
                MessageBox.Show("only numbers for EXP please");
            }
        }
        private void SetAC()
        {
            int AC;
            if (int.TryParse(txtAC.Text, out AC))
            {
                NewMonster.AC = AC;
            }
            else if (txtAC.Text != "")
            {
                MessageBox.Show("only numbers for AC please");
            }
        }
        private void SaveMonster()
        {
            string strSkills = Regex.Replace(txtSkills.Text, @"\t|\r|\n", "<br>");
            string strFeatsTraits = Regex.Replace(txtTraits.Text, @"\t|\r|\n", "<br>");
            string strActions = Regex.Replace(txtAction.Text, @"\t|\r|\n", "<br>");
            string strLegandaryActions = Regex.Replace(txtLegendaryActions.Text, @"\t|\r|\n", "<br>");
            try
            {
                SaveFileDialog SaveLocation = new SaveFileDialog();
                SaveLocation.ShowDialog();
                if (SaveLocation.FileName != "")
                {
                    StreamWriter MonsterSheet = new StreamWriter(SaveLocation.FileName);
                    MonsterSheet.WriteLine(NewMonster.Name);
                    MonsterSheet.WriteLine(NewMonster.AC);
                    MonsterSheet.WriteLine(NewMonster.HP);
                    MonsterSheet.WriteLine(NewMonster.Speed);
                    MonsterSheet.WriteLine(NewMonster.FlyingSpeed);
                    MonsterSheet.WriteLine(NewMonster.EXP);
                    MonsterSheet.WriteLine(NewMonster.STR);
                    MonsterSheet.WriteLine(NewMonster.DEX);
                    MonsterSheet.WriteLine(NewMonster.CON);
                    MonsterSheet.WriteLine(NewMonster.INT);
                    MonsterSheet.WriteLine(NewMonster.WIS);
                    MonsterSheet.WriteLine(NewMonster.CHA);
                    MonsterSheet.WriteLine(strSkills);
                    MonsterSheet.WriteLine(strFeatsTraits);
                    MonsterSheet.WriteLine(strActions);
                    MonsterSheet.WriteLine(strLegandaryActions);
                    MonsterSheet.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void txtCHA_TextChanged(object sender, EventArgs e)
        {
            SetCHA();
        }

        private void txtWIS_TextChanged(object sender, EventArgs e)
        {
            SetWIS();
        }

        private void txtINT_TextChanged(object sender, EventArgs e)
        {
            SetINT();
        }

        private void txtCON_TextChanged(object sender, EventArgs e)
        {
            SetCON();
        }

        private void txtDEX_TextChanged(object sender, EventArgs e)
        {
            SetDEX();
        }

        private void txtSTR_TextChanged(object sender, EventArgs e)
        {
            SetSTR();
        }

        private void txtFlying_TextChanged(object sender, EventArgs e)
        {
            SetFlying();
        }

        private void txtSpeed_TextChanged(object sender, EventArgs e)
        {
            SetSpeed();
        }

        private void txtHP_TextChanged(object sender, EventArgs e)
        {
            SetHP();
        }

        private void txtAC_TextChanged(object sender, EventArgs e)
        {
            SetAC();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            NewMonster.Name = txtName.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveMonster();
        }

        private void chkLegandaryActions_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLegandaryActions.Checked)
            {
                txtLegendaryActions.Enabled = true;
            }
            else
            {
                txtLegendaryActions.Enabled = false;
            }
        }

        private void txtEXP_TextChanged(object sender, EventArgs e)
        {
            SetEXP();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
