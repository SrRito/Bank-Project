﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_project
{
    //Clase para crear cajeros y manipular sus propiedades
    public class cCajero
    {
        //Atributos
        int id;
        int movimientos;
        int clientes;
        int tiempo;
        bool express;

        public cCajero(int id)
        {
            this.id = id;
            
        }

        public void definirExpress()
        {
            express = true;
        }
        public void addMov(int mov)
        {
            movimientos = movimientos + mov;
        }

        public string numeroCaja()
        {
            string iden = id.ToString();
            return iden;
        }
    }   
}
