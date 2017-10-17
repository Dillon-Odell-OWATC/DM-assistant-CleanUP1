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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnMakeSheet_Click(object sender, EventArgs e)
        {
            MakeSheet frmMake = new MakeSheet();
            frmMake.ShowDialog();
        }
        private void btnDisplaySheet_Click(object sender, EventArgs e)
        {
            DisplayandEditSheet DisplayEdit = new DisplayandEditSheet();
            DisplayEdit.Show();
        }

        private void btnMakeMonsters_Click(object sender, EventArgs e)
        {
            MakeMonster frmMakeMonster = new MakeMonster();
            frmMakeMonster.ShowDialog();
        }

        private void btnDisplayMonster_Click(object sender, EventArgs e)
        {
            ViewMonster frmViewMonster = new ViewMonster();
            frmViewMonster.Show();
        }
    }
}
