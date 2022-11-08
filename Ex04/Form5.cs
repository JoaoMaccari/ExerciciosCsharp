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
    public partial class Form5 : Form {
        public Form5() {
            InitializeComponent();
        }

        private void btn_mostrarSelecionados_Click(object sender, EventArgs e) {
            MessageBox.Show(cb_transportes.Text);
        }

        private void btn_limpar_Click(object sender, EventArgs e) {
            cb_transportes.Items.Clear();
        }

        private void btn_resetarElementos_Click(object sender, EventArgs e) {
            cb_transportes.Items.Clear();
            cb_transportes.Items.Add("Carro");
            cb_transportes.Items.Add("Avião");
            cb_transportes.Items.Add("Navio");
            cb_transportes.Items.Add("ônibus");
            cb_transportes.Items.Add("Trem");
        }

        private void cb_transportes_SelectedIndexChanged(object sender, EventArgs e) {
            tbx_inputTransporte.Text = cb_transportes.Text;
        }

        private void btn_addComboBox_Click(object sender, EventArgs e) {

            if (tbx_inputTransporte.Text != "") {

                if (cb_transportes.FindString(tbx_inputTransporte.Text) <0) {
                    cb_transportes.Items.Add(tbx_inputTransporte.Text);

                }

            }

            
            tbx_inputTransporte.Clear();
                
        }
    }
}
