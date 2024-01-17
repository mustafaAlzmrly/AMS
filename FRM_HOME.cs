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
    public partial class FRM_HOME : Form
    {
        public FRM_HOME()
        {
            InitializeComponent();
        }

        private void FRM_HOME_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_AMS_PRODataSet.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.dB_AMS_PRODataSet.Items);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            FRM_ADD fadd = new FRM_ADD();
            f.pn.Controls.Clear();
            f.pn.Controls.Add(fadd.panel1);
        }
    }
}
