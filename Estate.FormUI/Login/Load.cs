using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estate.FormUI.Login
{
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
           
        }
        int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counter==4)
            {
                timer1.Stop();
                Login lg = new Login();
                lg.Show();
                this.Hide();
            }
            counter++;
            
        }

        private void Load_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
