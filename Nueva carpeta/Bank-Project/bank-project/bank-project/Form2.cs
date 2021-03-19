using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bank_project
{
    public partial class cajeroExpress : Form
    {
        int numCaja = 0;
        public cajeroExpress()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            numCaja = 1;
            this.Close();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            numCaja = 2;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            numCaja = 3;
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            numCaja = 4;
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            numCaja = 5;
            this.Close();
        }
        public int getNumCaja()
        {
            return numCaja;
        }
    }
}
