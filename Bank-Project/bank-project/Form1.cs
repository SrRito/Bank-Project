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
    public partial class Form1 : Form
    {
        Clientes cliente = new Clientes();
        public Form1()
        {
            InitializeComponent();
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            random.Text = "numero random:";
            random.Text = random.Text + cliente.getMovimientos();
        }
    }
}
