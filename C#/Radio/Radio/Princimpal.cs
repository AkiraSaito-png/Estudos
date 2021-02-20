using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radio
{
    public partial class Rádio : Form
    {
        Thread cadastrar;

        public Rádio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void cadastro_Click(object sender, EventArgs e)
        {
            cadastrar = new Thread(metodoCadastrar);
        }

        private void metodoCadastrar()
        {
            Application.Run(new Cadastro())
        }
    }
}
