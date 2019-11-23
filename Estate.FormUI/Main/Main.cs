using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estate.FormUI.Main
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNewHouse_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(new House.UINewHouse());
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(new House.UiHouseList());
        }

        private void btnEditHouse_Click(object sender, EventArgs e)
        {
            House.UiFindHouse test = new House.UiFindHouse();
            
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(test);
            test.Dock = DockStyle.Fill;
        }
    }
}
