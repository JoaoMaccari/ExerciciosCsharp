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
    public partial class Form8 : Form {

        List<string> carro = new List<string>();
        public Form8() {
            InitializeComponent();

            carro.Add("Golf");
            carro.Add("Focus");
            carro.Add("Vectra");
            carro.Add("cruze");

            lb_carros.DataSource = carro;
        }

        private void btn_addCarro_Click(object sender, EventArgs e) {

            if (tb_Inputcarro.Text == "") {
                MessageBox.Show("Digite um carro");
                tb_Inputcarro.Focus();
            }
            else {
                carro.Add(tb_Inputcarro.Text);

                tb_Inputcarro.Clear();

                lb_carros.DataSource = null;
                lb_carros.DataSource = carro;
            }
        }

        private void btn_remover_Click(object sender, EventArgs e) {
            //removeAt remove um elemento da lista no indice especificado
            //passo a minha listBox com o selectedIndex, que devolve a posição do indice que foi selecionado
            carro.RemoveAt(lb_carros.SelectedIndex);

            //atualizo o dataSource
            lb_carros.DataSource = null;
            lb_carros.DataSource = carro;
        }

        private void btn_obter_Click(object sender, EventArgs e) {

            //PEGANDO DIRETO DA LISTA
            //posso usar o metodo da minha listBox  pra pegar o item selecionado
            //tb_Inputcarro.Text = carro[lb_carros.SelectedIndex];

            //PEGANDO DA LIST BOX
            tb_Inputcarro.Text = lb_carros.SelectedItem.ToString();
        }
    }
}
