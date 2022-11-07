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
    public partial class Form3 : Form {

        //lista do tipo checkbox que vai agrupar todos os checkboxs
        List<CheckBox> transportes = new List<CheckBox>();

        public Form3() {
            InitializeComponent();

            //no construtor já adiciono todos as labels a lista
            transportes.Add(cb_carro);
            transportes.Add(cb_aviao);
            transportes.Add(cb_navio);
            transportes.Add(cb_onibus);
        }

       

        private void button1_Click(object sender, EventArgs e) {
            string txt = "";

            foreach (CheckBox t in transportes) {
                if (t.Checked) {
                    txt += t.Text + ", ";
                }
            }

            MessageBox.Show(txt);
            
        }

        private void button2_Click(object sender, EventArgs e) {
            Filho_form3 filho_form3 = new Filho_form3();
            filho_form3.ShowDialog();
        }
    }
}
