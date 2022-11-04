
namespace Ex04 {
    partial class Form1 {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.lbl_01 = new System.Windows.Forms.Label();
            this.txt_veiculo = new System.Windows.Forms.TextBox();
            this.txt_listaVeiculo = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_limpa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_01
            // 
            this.lbl_01.AutoSize = true;
            this.lbl_01.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_01.Location = new System.Drawing.Point(9, 27);
            this.lbl_01.Name = "lbl_01";
            this.lbl_01.Size = new System.Drawing.Size(132, 16);
            this.lbl_01.TabIndex = 0;
            this.lbl_01.Text = "Insira um veículo: ";
            // 
            // txt_veiculo
            // 
            this.txt_veiculo.Location = new System.Drawing.Point(150, 26);
            this.txt_veiculo.Name = "txt_veiculo";
            this.txt_veiculo.Size = new System.Drawing.Size(100, 20);
            this.txt_veiculo.TabIndex = 1;
            // 
            // txt_listaVeiculo
            // 
            this.txt_listaVeiculo.Location = new System.Drawing.Point(12, 53);
            this.txt_listaVeiculo.Multiline = true;
            this.txt_listaVeiculo.Name = "txt_listaVeiculo";
            this.txt_listaVeiculo.Size = new System.Drawing.Size(238, 117);
            this.txt_listaVeiculo.TabIndex = 2;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(258, 24);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "ADICIONAR";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_limpa
            // 
            this.btn_limpa.Location = new System.Drawing.Point(102, 190);
            this.btn_limpa.Name = "btn_limpa";
            this.btn_limpa.Size = new System.Drawing.Size(75, 23);
            this.btn_limpa.TabIndex = 4;
            this.btn_limpa.Text = "LIMPAR";
            this.btn_limpa.UseVisualStyleBackColor = true;
            this.btn_limpa.Click += new System.EventHandler(this.btn_limpa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 247);
            this.Controls.Add(this.btn_limpa);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_listaVeiculo);
            this.Controls.Add(this.txt_veiculo);
            this.Controls.Add(this.lbl_01);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_01;
        private System.Windows.Forms.TextBox txt_veiculo;
        private System.Windows.Forms.TextBox txt_listaVeiculo;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_limpa;
    }
}

