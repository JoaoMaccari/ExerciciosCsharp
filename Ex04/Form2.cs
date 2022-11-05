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
    public partial class Form2 : Form {

        Form1 fp;


        //construtor do form2. vai solicitar 2 parametros toda vez que instanciar um objeto do tipo fomr2
        public Form2(string v, Form1 f) {
            InitializeComponent();

            txt_listaForm2.Text = v;
            fp = f;
            f.num = 10;
            
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e) {
            fp.txb_listaVeiculo.Text = txt_listaForm2.Text;
        }
    }
}
