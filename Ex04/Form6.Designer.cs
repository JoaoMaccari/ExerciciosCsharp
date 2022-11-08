
namespace Ex04 {
    partial class Form6 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.btn_obterData = new System.Windows.Forms.Button();
            this.txb_dataCompleta = new System.Windows.Forms.TextBox();
            this.txb_dia = new System.Windows.Forms.TextBox();
            this.txb_mes = new System.Windows.Forms.TextBox();
            this.txb_ano = new System.Windows.Forms.TextBox();
            this.btn_setaData = new System.Windows.Forms.Button();
            this.btn_dataAtual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(12, 12);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(241, 20);
            this.dtp.TabIndex = 0;
            // 
            // btn_obterData
            // 
            this.btn_obterData.Location = new System.Drawing.Point(259, 10);
            this.btn_obterData.Name = "btn_obterData";
            this.btn_obterData.Size = new System.Drawing.Size(178, 23);
            this.btn_obterData.TabIndex = 1;
            this.btn_obterData.Text = "Obter Data";
            this.btn_obterData.UseVisualStyleBackColor = true;
            this.btn_obterData.Click += new System.EventHandler(this.btn_obterData_Click);
            // 
            // txb_dataCompleta
            // 
            this.txb_dataCompleta.Location = new System.Drawing.Point(12, 39);
            this.txb_dataCompleta.Name = "txb_dataCompleta";
            this.txb_dataCompleta.Size = new System.Drawing.Size(241, 20);
            this.txb_dataCompleta.TabIndex = 2;
            // 
            // txb_dia
            // 
            this.txb_dia.Location = new System.Drawing.Point(12, 65);
            this.txb_dia.Name = "txb_dia";
            this.txb_dia.Size = new System.Drawing.Size(74, 20);
            this.txb_dia.TabIndex = 3;
            // 
            // txb_mes
            // 
            this.txb_mes.Location = new System.Drawing.Point(92, 65);
            this.txb_mes.Name = "txb_mes";
            this.txb_mes.Size = new System.Drawing.Size(77, 20);
            this.txb_mes.TabIndex = 4;
            // 
            // txb_ano
            // 
            this.txb_ano.Location = new System.Drawing.Point(175, 65);
            this.txb_ano.Name = "txb_ano";
            this.txb_ano.Size = new System.Drawing.Size(78, 20);
            this.txb_ano.TabIndex = 5;
            // 
            // btn_setaData
            // 
            this.btn_setaData.Location = new System.Drawing.Point(259, 61);
            this.btn_setaData.Name = "btn_setaData";
            this.btn_setaData.Size = new System.Drawing.Size(178, 23);
            this.btn_setaData.TabIndex = 6;
            this.btn_setaData.Text = "Setar Data";
            this.btn_setaData.UseVisualStyleBackColor = true;
            this.btn_setaData.Click += new System.EventHandler(this.btn_setaData_Click);
            // 
            // btn_dataAtual
            // 
            this.btn_dataAtual.Location = new System.Drawing.Point(306, 90);
            this.btn_dataAtual.Name = "btn_dataAtual";
            this.btn_dataAtual.Size = new System.Drawing.Size(75, 23);
            this.btn_dataAtual.TabIndex = 7;
            this.btn_dataAtual.Text = "Data atual";
            this.btn_dataAtual.UseVisualStyleBackColor = true;
            this.btn_dataAtual.Click += new System.EventHandler(this.btn_dataAtual_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 305);
            this.Controls.Add(this.btn_dataAtual);
            this.Controls.Add(this.btn_setaData);
            this.Controls.Add(this.txb_ano);
            this.Controls.Add(this.txb_mes);
            this.Controls.Add(this.txb_dia);
            this.Controls.Add(this.txb_dataCompleta);
            this.Controls.Add(this.btn_obterData);
            this.Controls.Add(this.dtp);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Button btn_obterData;
        private System.Windows.Forms.TextBox txb_dataCompleta;
        private System.Windows.Forms.TextBox txb_dia;
        private System.Windows.Forms.TextBox txb_mes;
        private System.Windows.Forms.TextBox txb_ano;
        private System.Windows.Forms.Button btn_setaData;
        private System.Windows.Forms.Button btn_dataAtual;
    }
}