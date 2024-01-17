using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMS_PRO_MAX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pn_home.Visible == false)
            {
                pn_home.Visible = true;
            }
            else
            {
                pn.Controls.Clear();
                pn.Controls.Add(pn_home);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pn_lift.Width == 250)
            {
                pn_lift.Width = 50;
                pn_had.Visible = false;

            }
            else
            {
                pn_lift.Width = 250;
                pn_had.Visible = true;

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FRM_HOME frm = new FRM_HOME();
            pn.Controls.Clear();
            pn.Controls.Add(frm.pn_cat);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FRM_ADD fadd = new FRM_ADD();
            pn.Controls.Clear();
            pn.Controls.Add(fadd.panel1);
        }
    }
}
