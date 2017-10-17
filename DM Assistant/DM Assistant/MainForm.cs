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
            frmMake.Show();
        }
        private void btnDisplaySheet_Click(object sender, EventArgs e)
        {
            DisplayandEditSheet DisplayEdit = new DisplayandEditSheet();
            DisplayEdit.Show();
        }
    }
}
