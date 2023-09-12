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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            Cadastro cad= new Cadastro();
            if (!cad.verificaemail(emailbox.Text))
            {
                MessageBox.Show("Email não cadastrado!");
            }
            else if (l.logar(emailbox.Text,SenhaBox.Text))
            {
                MessageBox.Show("Parabéns, você está logado!");
            }
            else
            {
                MessageBox.Show("Senha incorreta");
            }
        }
    }
}
