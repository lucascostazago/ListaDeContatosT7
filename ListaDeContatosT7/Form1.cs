using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ListaDeContatosT7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Contato[] contatos = new Contato[0];

        private void Escrever(Contato contato) //Verde é o tipo, azul é o nome
        {
            StreamWriter escreverEmArquivo = new StreamWriter("Contatos.txt");
            escreverEmArquivo.WriteLine(contatos.Length + 1);
            escreverEmArquivo.WriteLine(contato.Nome);
            escreverEmArquivo.WriteLine(contato.Sobrenome);
            escreverEmArquivo.WriteLine(contato.Telefone);

            for(int x = 0; x < contatos.Length; x++)
            {
                escreverEmArquivo.WriteLine(contatos[x].Nome);
                escreverEmArquivo.WriteLine(contatos[x].Sobrenome);
                escreverEmArquivo.WriteLine(contatos[x].Telefone);
            }

            escreverEmArquivo.Close();
        }

        private void Ler()
        {
            StreamReader lerArquivo = new StreamReader("Contatos.txt");
            contatos = new Contato[Convert.ToInt32(lerArquivo.ReadLine())];

            for(int x = 0; x < contatos.Length; x++)
            {
                contatos[x] = new Contato();
                contatos[x].Nome = lerArquivo.ReadLine();
                contatos[x].Sobrenome = lerArquivo.ReadLine();
                contatos[x].Telefone = lerArquivo.ReadLine();
            }

            lerArquivo.Close(); 
        }

        private void Exibir()
        {
            listBoxContatos.Items.Clear();
            for (int x = 0;x < contatos.Length; x++)
            {
                listBoxContatos.Items.Add(contatos[x].ToString());
            }
        }
        private void LimparFormulario()
        {
            textBoxName.Text = String.Empty;
            textBoxSobrenome.Text = String.Empty;
            texBoxTelefone.Text = String.Empty;
        }




        private void addContato_Click(object sender, EventArgs e)
        {
            //Um objeto é uma instancia de uma classe
            Contato contato = new Contato();
            contato.Nome = textBoxName.Text;
            contato.Sobrenome = textBoxSobrenome.Text;
            contato.Telefone = texBoxTelefone.Text;

            //listBoxContatos.Items.Add(contato.ToString());
            texBoxTelefone.Clear();
            textBoxName.Clear();
            textBoxSobrenome.Clear();

            Escrever(contato);
            Ler();
            Exibir();
            LimparFormulario(); 
        }

        private void lable1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxContatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void texBoxTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSobrenome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ler();
            Exibir();
        }
    }
}
