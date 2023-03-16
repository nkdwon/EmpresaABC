using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaABC
{
    public partial class FormularioCadastroCliente : Form
    {
        public FormularioCadastroCliente()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //capturar dados da tela
            string nomeCliente = txtnome.Text;
            int idade = int.Parse(txtidade.Text);
            float salario = float.Parse(txtsalario.Text);
            bool PCD = bool.Parse(txtPCD.Text);


            MessageBox.Show("Nome: " + nomeCliente);
            MessageBox.Show("Idade: " + idade);
            MessageBox.Show("Salário: " + salario);
            MessageBox.Show("PCD: " + PCD);
            
        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
