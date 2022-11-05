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
            if (txb_inputVeiculo.Text == "") {
                MessageBox.Show("Insira um veículo");
                txb_inputVeiculo.Clear();
                txb_inputVeiculo.Focus();
            }

            else {
                List<string> carList = new List<string>();

                carList.Add(txb_inputVeiculo.Text);

                foreach (string i in carList) {
                    txb_listaVeiculo.Text += i + "\r\n";
                }

                txb_inputVeiculo.Clear();
                txb_inputVeiculo.Focus();
            }
        }

        private void btn_apagar_Click(object sender, EventArgs e) {
            txb_listaVeiculo.Clear();
        }

        private void btn_enviar_Click(object sender, EventArgs e) {
            Form2 newForm = new Form2(txb_listaVeiculo.Text);
            newForm.ShowDialog();
        }

        private void btn_add_KeyPress(object sender, KeyPressEventArgs e) {

        }
    }
}
