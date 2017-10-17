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
    public partial class MakeMonster : Form
    {
        public MakeMonster()
        {
            InitializeComponent();
        }
        //Functions for setting attributes
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

        private void txtCHA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWIS_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtINT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCON_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDEX_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSTR_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFlying_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSpeed_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
