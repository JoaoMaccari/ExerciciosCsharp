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
    public partial class Filho_form3 : Form {

        public Form3 fcb;
        public Filho_form3() {
            InitializeComponent();

            //opem forms recebe uma coleção contida em um formulário
            //neste caso estou pegando todos os chekeds do form3 e jogando para dentro de uma variavel
            fcb = Application.OpenForms["Form3"] as Form3;

            //o cheked do formulário filho recebe o checked do formulário pai
            cb_carro.Checked = fcb.cb_carro.Checked;
            cb_aviao.Checked = fcb.cb_aviao.Checked;
            cb_navio.Checked = fcb.cb_navio.Checked;
            cb_onibus.Checked = fcb.cb_onibus.Checked;
        }



        //crio em evento que ao alterar o checked do filho tambem vai alterar o do pai
        private void cb_carro_CheckedChanged(object sender, EventArgs e) {
            fcb.cb_carro.Checked = cb_carro.Checked;
        }

        private void cb_aviao_CheckedChanged(object sender, EventArgs e) {
            fcb.cb_aviao.Checked = cb_aviao.Checked;
        }

        private void cb_onibus_CheckedChanged(object sender, EventArgs e) {
            fcb.cb_onibus.Checked = cb_onibus.Checked;
        }

        private void cb_navio_CheckedChanged(object sender, EventArgs e) {
            fcb.cb_navio.Checked = cb_navio.Checked;
        }
    }
}
