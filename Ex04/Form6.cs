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
    public partial class Form6 : Form {
        public Form6() {
            InitializeComponent();
        }

        private void btn_obterData_Click(object sender, EventArgs e) {
            txb_dataCompleta.Text = dtp.Text;

            txb_dia.Text = dtp.Value.Day.ToString();
            txb_mes.Text = dtp.Value.Month.ToString();
            txb_ano.Text = dtp.Value.Year.ToString();
        }

        private void btn_setaData_Click(object sender, EventArgs e) {

            int d, m, a;

            d = Convert.ToInt32(txb_dia.Text);
            m = Convert.ToInt32(txb_mes.Text);
            a = Convert.ToInt32(txb_ano.Text);

            DateTime dt = new DateTime(a, m, d);

            
            dtp.Value = dt;
        }

        private void btn_dataAtual_Click(object sender, EventArgs e) {
            dtp.Value = DateTime.Now;
        }
    }
}
