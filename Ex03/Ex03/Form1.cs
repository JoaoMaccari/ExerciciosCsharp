using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex03 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            string senha = "123456";
            string login = "joaoMaccari";

            if (txtLogin.Text == login && txtSenha.Text == senha) {
                MessageBox.Show("Conectado");
            }
            else {
                MessageBox.Show("Login / senha incorretos");
            }
        }
    }
}
