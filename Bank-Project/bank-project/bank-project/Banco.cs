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
    public partial class Banco : Form
    {
        private int conteo;
        Clientes cliente = new Clientes();
        cajeroExpress express = new cajeroExpress();
        int x=0;
        public Banco()
        {
            InitializeComponent();
            cCajero caja1 = new cCajero(1);
            cCajero caja2 = new cCajero(2);
            cCajero caja3 = new cCajero(3);
            cCajero caja4 = new cCajero(4);
            cCajero caja5 = new cCajero(5);
            express.ShowDialog();
            x = express.getNumCaja();
            if (x != 0)
            {
                express.Close();
            }
            switch (x)
            {
                case 1:
                    caja1.definirExpress();
                    lblCaja1.Visible = true;
                    break;
                case 2:
                    caja2.definirExpress();
                    lblCaja2.Visible = true;
                    break;
                case 3:
                    caja3.definirExpress();
                    lblCaja3.Visible = true;
                    break;
                case 4:
                    caja4.definirExpress();
                    lblCaja4.Visible = true;
                    break;
                case 5:
                    caja5.definirExpress();
                    lblCaja5.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            random.Text = "numero random:";
            random.Text = random.Text + cliente.getMovimientos();
            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            conteo++;
            lblConteo.Text = conteo.ToString();
        }

    }
}
