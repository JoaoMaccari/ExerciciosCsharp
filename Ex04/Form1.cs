﻿using System;
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
            }
            else {
                List<string> carList = new List<string>();

                carList.Add(txb_inputVeiculo.Text);

                foreach (string i in carList) {
                    txb_listaVeiculo.Text += i + "\r\n";
                }
            }
        }
    }
}
