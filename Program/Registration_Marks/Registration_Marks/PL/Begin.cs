using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Registration_Marks.PL
{
    public partial class Begin : Form
    {
        public Begin()
        {
            InitializeComponent();
        }

        private void Begin_Load(object sender, EventArgs e)
        {
            timer1.Start();
            progressBar1.Value = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            
            progressBar1.Value++;
            if (progressBar1.Value >= 100)
            {
                timer1.Enabled = false;
                Login frm = new Login();
                frm.Show();
                this.Hide();

            }

        }
    }
}
