
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
            this.lbl_insert = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_apagar = new System.Windows.Forms.Button();
            this.txb_inputVeiculo = new System.Windows.Forms.TextBox();
            this.txb_listaVeiculo = new System.Windows.Forms.TextBox();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_insert
            // 
            this.lbl_insert.AutoSize = true;
            this.lbl_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_insert.Location = new System.Drawing.Point(9, 40);
            this.lbl_insert.Name = "lbl_insert";
            this.lbl_insert.Size = new System.Drawing.Size(122, 18);
            this.lbl_insert.TabIndex = 0;
            this.lbl_insert.Text = "Insira um veículo:";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(243, 33);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(126, 26);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "ADICIONAR";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            this.btn_add.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_add_KeyPress);
            // 
            // btn_apagar
            // 
            this.btn_apagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_apagar.Location = new System.Drawing.Point(243, 74);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(126, 29);
            this.btn_apagar.TabIndex = 2;
            this.btn_apagar.Text = "APAGAR";
            this.btn_apagar.UseVisualStyleBackColor = true;
            this.btn_apagar.Click += new System.EventHandler(this.btn_apagar_Click);
            // 
            // txb_inputVeiculo
            // 
            this.txb_inputVeiculo.Location = new System.Drawing.Point(137, 38);
            this.txb_inputVeiculo.Name = "txb_inputVeiculo";
            this.txb_inputVeiculo.Size = new System.Drawing.Size(100, 20);
            this.txb_inputVeiculo.TabIndex = 3;
            // 
            // txb_listaVeiculo
            // 
            this.txb_listaVeiculo.Location = new System.Drawing.Point(12, 76);
            this.txb_listaVeiculo.Multiline = true;
            this.txb_listaVeiculo.Name = "txb_listaVeiculo";
            this.txb_listaVeiculo.Size = new System.Drawing.Size(225, 158);
            this.txb_listaVeiculo.TabIndex = 4;
            // 
            // btn_enviar
            // 
            this.btn_enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enviar.Location = new System.Drawing.Point(243, 121);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(126, 31);
            this.btn_enviar.TabIndex = 5;
            this.btn_enviar.Text = "ENVIAR";
            this.btn_enviar.UseVisualStyleBackColor = true;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(243, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "MOSTRAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 258);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.txb_listaVeiculo);
            this.Controls.Add(this.txb_inputVeiculo);
            this.Controls.Add(this.btn_apagar);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_insert);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_insert;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_apagar;
        private System.Windows.Forms.TextBox txb_inputVeiculo;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txb_listaVeiculo;
    }
}

