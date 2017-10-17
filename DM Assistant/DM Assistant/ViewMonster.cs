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
    public partial class ViewMonster : Form
    {
        public ViewMonster()
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
        private void OpenFile()
        {
            OpenFileDialog OpenLocation = new OpenFileDialog();
            OpenLocation.ShowDialog();
            if (OpenLocation.FileName != "")
            {
                try
                {
                    string TempString = "";
                    StreamReader MonsterSheet = new StreamReader(OpenLocation.FileName);
                    txtName.Text = MonsterSheet.ReadLine();
                    txtAC.Text = MonsterSheet.ReadLine();
                    txtHP.Text = MonsterSheet.ReadLine();
                    txtSpeed.Text = MonsterSheet.ReadLine();
                    txtFlying.Text = MonsterSheet.ReadLine();
                    txtEXP.Text = MonsterSheet.ReadLine();
                    txtSTR.Text = MonsterSheet.ReadLine();
                    txtDEX.Text = MonsterSheet.ReadLine();
                    txtCON.Text = MonsterSheet.ReadLine();
                    txtINT.Text = MonsterSheet.ReadLine();
                    txtWIS.Text = MonsterSheet.ReadLine();
                    txtCHA.Text = MonsterSheet.ReadLine();
                    TempString = MonsterSheet.ReadLine();
                    txtSkills.Text = TempString.Replace("<br><br>", System.Environment.NewLine);
                    TempString = MonsterSheet.ReadLine();
                    txtTraits.Text = TempString.Replace("<br><br>", System.Environment.NewLine);
                    TempString = MonsterSheet.ReadLine();
                    txtAction.Text = TempString.Replace("<br><br>", System.Environment.NewLine);
                    TempString = MonsterSheet.ReadLine();
                    txtLegendaryActions.Text = TempString.Replace("<br><br>", System.Environment.NewLine);
                    MonsterSheet.Close();
                    SetSTR();
                    SetDEX();
                    SetCON();
                    SetINT();
                    SetWIS();
                    SetCHA();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void SaveNotes()
        {
            SaveFileDialog SaveLocation = new SaveFileDialog();
            SaveLocation.ShowDialog();
            if (SaveLocation.FileName != "")
            {
                try
                {
                    StreamWriter Notes = new StreamWriter(SaveLocation.FileName);
                    Notes.WriteLine(txtNotes.Text);
                    Notes.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void LoadNotes()
        {
            OpenFileDialog OpenLocation = new OpenFileDialog();
            OpenLocation.ShowDialog();
            if (OpenLocation.FileName != "")
            {
                try
                {
                    StreamReader Notes = new StreamReader(OpenLocation.FileName);
                    txtNotes.Text = Notes.ReadToEnd();
                    Notes.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
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
        
        private void ViewMonster_Load(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void txtSTR_TextChanged(object sender, EventArgs e)
        {
            SetSTR();
        }

        private void txtDEX_TextChanged(object sender, EventArgs e)
        {
            SetDEX();
        }

        private void txtCON_TextChanged(object sender, EventArgs e)
        {
            SetCON();
        }

        private void txtINT_TextChanged(object sender, EventArgs e)
        {
            SetINT();
        }

        private void txtWIS_TextChanged(object sender, EventArgs e)
        {
            SetWIS();
        }

        private void txtCHA_TextChanged(object sender, EventArgs e)
        {
            SetCHA();
        }

        private void btnSaveNotes_Click(object sender, EventArgs e)
        {
            SaveNotes();
        }

        private void btnLoadNotes_Click(object sender, EventArgs e)
        {
            LoadNotes();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
