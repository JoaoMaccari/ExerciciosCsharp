using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex04 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e) {
            if (txt_veiculo.Text == "") {
                MessageBox.Show("Insira um veículo");
            }
            else {

                List<string> listaVeiculos = new List<string>();

                      listaVeiculos.Add(txt_veiculo.Text);

                      foreach (string i in listaVeiculos) {
                           txt_listaVeiculo.Text += i + "\r\n";
                      }

                      txt_veiculo.Clear();
                      txt_veiculo.Focus();
            }
            
        }

        private void btn_limpa_Click(object sender, EventArgs e) {
            txt_listaVeiculo.Text = "";
        }
    }
}
