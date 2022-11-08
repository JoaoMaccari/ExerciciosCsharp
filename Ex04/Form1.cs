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

        public int num;
        public string veiculosForm2;

        public Form1() {
            InitializeComponent();

            num = 0;

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

            //botão que instancia um objeto do tipo Form2
            
            //passagem de 2 parametros para o formulario 2
            Form2 newForm = new Form2(txb_listaVeiculo.Text, this);
            newForm.ShowDialog();
        }

        private void btn_add_KeyPress(object sender, KeyPressEventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            MessageBox.Show(num.ToString());
        }

        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e) {
            Form3 f_checkbox = new Form3();
            f_checkbox.ShowDialog();
        }

        private void checkedListBoxToolStripMenuItem_Click(object sender, EventArgs e) {
            Form4 f_checkedListBox = new Form4();
            f_checkedListBox.ShowDialog();
        }

        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e) {
            Form5 f_combobox = new Form5();
            f_combobox.ShowDialog();
        }

        private void dateTimePickerToolStripMenuItem_Click(object sender, EventArgs e) {
            Form6 f_dateTimePicker = new Form6();
            f_dateTimePicker.ShowDialog();

            
        }

        private void lbellinkLabelToolStripMenuItem_Click(object sender, EventArgs e) {
            Form7 f_linkLabel = new Form7();
            f_linkLabel.ShowDialog();
        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e) {
            Form8 f_listBox = new Form8();
            f_listBox.ShowDialog();
        }
    }
}
