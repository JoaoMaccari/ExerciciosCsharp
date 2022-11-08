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
    public partial class Form7 : Form {
        public Form7() {
            InitializeComponent();

            //"recortando" minha linked list
            // 1 parametro = posição que começa e aonde termina
            // 2 parametro = quantos caracteres possui ao todo
            // 3 parametro = link
            ll_multiplos.Links.Add(0, 6, "www.google.com.br");
            ll_multiplos.Links.Add(9, 5, "https://www.youtube.com/channel/UCpEZeJxhbU0oZCLnpmYY2bg");
            ll_multiplos.Links.Add(17, 7, "www.youtube.com");

            //posso ativar ou desativar o link com o enabe
            //passo a posição na linked list
            ll_multiplos.Links[2].Enabled = false;
        }

        private void ll_canal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCpEZeJxhbU0oZCLnpmYY2bg");
            ll_canal.LinkVisited = true;
        }

        private void ll_calculadora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void ll_multiplos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

            //uso método linkdata que se refere a um link em especifico que está sendo clicado
            //converto pra string, 
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());

            //o sender nos argumetos se refere ao objeto que foi clicado
            //converto passo ele pra uma variavel e converto para o tipo linkLabel

            //LinkLabel ll = (LinkLabel) sender;
            //ll.LinkVisited = true;

            ll_multiplos.LinkVisited = true;
        }
    }
}
