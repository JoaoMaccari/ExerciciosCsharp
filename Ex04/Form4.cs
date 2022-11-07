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
    public partial class Form4 : Form {
        public Form4() {
            InitializeComponent();
        }

        private void btn_mostrarSelecionados_Click(object sender, EventArgs e) {
            string txt = "";

            foreach (string i in clb_transportes.CheckedItems) {
                txt += i + ", ";
            }
            

            MessageBox.Show(txt);
        }

        private void btn_limparLista_Click(object sender, EventArgs e) {
            clb_transportes.Items.Clear();
        }

        private void btn_resetarLista_Click(object sender, EventArgs e) {
            clb_transportes.Items.Clear();

            clb_transportes.Items.Add("carro" ,false);
            clb_transportes.Items.Add("aviao", false);
            clb_transportes.Items.Add("navio", false);
            clb_transportes.Items.Add("trem", false);
        }

        private void btn_addNovoTransporte_Click(object sender, EventArgs e) {

            if (tb_novoTransporte.Text != "") {
                clb_transportes.Items.Add(tb_novoTransporte.Text);
            }

            
        }
    }
}
