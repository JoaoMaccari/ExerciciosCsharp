using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Text;

namespace Ex03 {
    public partial class Form1 : Form {

        Thread nt;
        public Form1() {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e) {
            string senha = "123456";
            string login = "joaoMaccari";

            if (txtLogin.Text == login && txtSenha.Text == senha) {

                MessageBox.Show("Conectado");

                this.Close();
                nt = new Thread(novoForm);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
            else {
                MessageBox.Show("Login / senha incorretos");
            }

            

        }

            private void novoForm() {
            Application.Run(new Form2());
            }
    }
}
