using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Login
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro();
            //email ja cadastrado
            if (cad.verificaemail(emailBox.Text))
            {
                MessageBox.Show("Email ja cadastrado!");
            }
            else if ((senhaBox1.Text == "" || senhaBox2.Text == ""))
            {
                MessageBox.Show("Digite a senha em ambos os campos!");
            }
            else if (senhaBox1.Text != senhaBox2.Text)
            {
                MessageBox.Show("Ambas as senhas devem ser iguais!");
            }
            else
            {
                MessageBox.Show(cad.Cadastrar(emailBox.Text, senhaBox1.Text));
            }
        }
    }
}
