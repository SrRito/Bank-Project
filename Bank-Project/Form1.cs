using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace claseCajera
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cCajero caja1 = new cCajero(1);
            cCajero caja2 = new cCajero(2);
            cCajero caja3 = new cCajero(3);
            cCajero caja4 = new cCajero(4);
            cCajero caja5 = new cCajero(5);

            MessageBox.Show("Creaste las cajas " + caja1.numeroCaja()+ " "+ caja2.numeroCaja() + caja3.numeroCaja() + caja4.numeroCaja() + caja5.numeroCaja());
        }

        //CLic boton definir express
        /*
           caja1.definirExpress();
           caja2.definirExpress(); 
           caja3.definirExpress(); 
           caja4.definirExpress(); 
           caja5.definirExpress(); 

        */
    }
}
