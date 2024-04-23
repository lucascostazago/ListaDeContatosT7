using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDeContatosT7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addContato_Click(object sender, EventArgs e)
        {
            //Um objeto é uma instancia de uma classe
            Contato contato = new Contato();
            contato.Nome = textBoxName.Text;
            contato.Sobrenome = textBoxSobrenome.Text;
            contato.Telefone = texBoxTelefone.Text;

            listBoxContatos.Items.Add(contato.ToString());
            texBoxTelefone.Clear();
            textBoxName.Clear();
            textBoxSobrenome.Clear();
        }

        private void lable1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
