using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bank_project
{
    public partial class Banco : Form
    {
        private int clienteGlobal=0;
        private int conteo;
        Clientes cliente = new Clientes();
        cajeroExpress express = new cajeroExpress();
        cCajero caja1 = new cCajero(1);
        cCajero caja2 = new cCajero(2);
        cCajero caja3 = new cCajero(3);
        cCajero caja4 = new cCajero(4);
        cCajero caja5 = new cCajero(5);
        int x=0;
        public Banco()
        {
            InitializeComponent();
            
            express.ShowDialog();
            x = express.getNumCaja();
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
                    MessageBox.Show("Asegurate de elegir una caja primero");
                    Close();
                    break;
            }
            timer.Enabled = true;

            //bucle para crear clientes
            
            int filaC=0;
            
            Random clien = new Random();
            Clientes[] fila = new Clientes[53];
            int aux = clienteGlobal;
            int i = 0;
            
            while (aux < 50)
            {
                //Espera para asignar nuevos clientes intervalo de 10 segundos si o si
                //10,000 ticks equivalen, en un evento del timer (timer1)

                filaC = clien.Next(1, 6);
                clienteGlobal = clienteGlobal + filaC;

                //Rellena el array de clientes
                for(x=0; x<=filaC; x++)
                {
                    fila[i] = new Clientes();
                    i = i + 1;
                }
                //Corrobora cuantos clientes hay en la fila hasta el momento
                MessageBox.Show("Tengo " + clienteGlobal + " clientes");
            }
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            conteo++;
            lblConteo.Text = conteo.ToString();
        }

        private void Banco_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
