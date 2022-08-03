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
            MessageBox.Show("Querido professor matioli", "Aviso do sistema", MessageBoxButtons.OK);
            MessageBox.Show("Fiquei sabendo que o senhor esta com problemas de saude", "Aviso do sistema", MessageBoxButtons.OK);
            MessageBox.Show("venho lhe desejar melhoras", "Aviso do sistema", MessageBoxButtons.OK);
            MessageBox.Show("Fique com Deus", "Aviso do sistema", MessageBoxButtons.OK);
            MessageBox.Show("E que Deus te abençoe", "Aviso do sistema", MessageBoxButtons.OK);
            MessageBox.Show("De seu querido aluno", "Aviso do sistema", MessageBoxButtons.OK);
            MessageBox.Show("fulano de tal", "Aviso do sistema", MessageBoxButtons.OK);
            this.Close();
        }
    }
}
