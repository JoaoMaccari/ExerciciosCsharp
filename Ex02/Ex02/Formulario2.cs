using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex02 {
    public partial class Formulario2 : Form {
        public Formulario2() {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }





        private void button1_Click(object sender, EventArgs e) {
            string nome, cidade;
            DateTime dataNasc;
            bool generoM;
            bool generoF;
            int numeroCadastro;

            nome = textBox1.Text;
            dataNasc = dateTimePicker2.Value;
            cidade = comboBox1.Text;
            generoM = radioButton1.Checked;
            generoF = radioButton2.Checked;
            numeroCadastro = Convert.ToInt32(textCadastro.Text);

            MessageBox.Show("Nome: " + nome);
            MessageBox.Show("Data Nascimento: " + dataNasc);
            MessageBox.Show("Cidade: " + cidade);
            MessageBox.Show("Gênero Masculino " + generoM);
            MessageBox.Show("Gênero Feminino " + generoF);
            MessageBox.Show("Número de Cadastro: " + numeroCadastro);
            
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}
