﻿using SRMTeste.Cadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRMTeste
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadClientes clientes = new CadClientes();
            clientes.Show();
            
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
