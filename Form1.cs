using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Mensagem1", "Aviso do sistema", MessageBoxButtons.OK);
            MessageBox.Show("Mensagem2", "Aviso do sistema", MessageBoxButtons.OK);
            MessageBox.Show("Mensagem3", "Aviso do sistema", MessageBoxButtons.OK);
            MessageBox.Show("Mensagem4", "Aviso do sistema", MessageBoxButtons.OK);
            MessageBox.Show("Mensagem5", "Aviso do sistema", MessageBoxButtons.OK);
            MessageBox.Show("Mensagem6", "Aviso do sistema", MessageBoxButtons.OK);
            MessageBox.Show("Mensagem7", "Aviso do sistema", MessageBoxButtons.OK);
            this.Close();
        }
    }
}
