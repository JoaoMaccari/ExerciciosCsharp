
namespace Ex04 {
    partial class Form5 {
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
            this.cb_transportes = new System.Windows.Forms.ComboBox();
            this.btn_mostrarSelecionados = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_resetarElementos = new System.Windows.Forms.Button();
            this.btn_addComboBox = new System.Windows.Forms.Button();
            this.tbx_inputTransporte = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cb_transportes
            // 
            this.cb_transportes.FormattingEnabled = true;
            this.cb_transportes.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "Ônibus",
            "Trem"});
            this.cb_transportes.Location = new System.Drawing.Point(12, 12);
            this.cb_transportes.Name = "cb_transportes";
            this.cb_transportes.Size = new System.Drawing.Size(178, 21);
            this.cb_transportes.TabIndex = 0;
            this.cb_transportes.SelectedIndexChanged += new System.EventHandler(this.cb_transportes_SelectedIndexChanged);
            // 
            // btn_mostrarSelecionados
            // 
            this.btn_mostrarSelecionados.Location = new System.Drawing.Point(196, 10);
            this.btn_mostrarSelecionados.Name = "btn_mostrarSelecionados";
            this.btn_mostrarSelecionados.Size = new System.Drawing.Size(184, 23);
            this.btn_mostrarSelecionados.TabIndex = 1;
            this.btn_mostrarSelecionados.Text = "Mostrar Selecionado";
            this.btn_mostrarSelecionados.UseVisualStyleBackColor = true;
            this.btn_mostrarSelecionados.Click += new System.EventHandler(this.btn_mostrarSelecionados_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(196, 41);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(184, 23);
            this.btn_limpar.TabIndex = 2;
            this.btn_limpar.Text = "Limpar Elementos";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_resetarElementos
            // 
            this.btn_resetarElementos.Location = new System.Drawing.Point(196, 70);
            this.btn_resetarElementos.Name = "btn_resetarElementos";
            this.btn_resetarElementos.Size = new System.Drawing.Size(184, 23);
            this.btn_resetarElementos.TabIndex = 3;
            this.btn_resetarElementos.Text = "Resetar Elementos";
            this.btn_resetarElementos.UseVisualStyleBackColor = true;
            this.btn_resetarElementos.Click += new System.EventHandler(this.btn_resetarElementos_Click);
            // 
            // btn_addComboBox
            // 
            this.btn_addComboBox.Location = new System.Drawing.Point(196, 151);
            this.btn_addComboBox.Name = "btn_addComboBox";
            this.btn_addComboBox.Size = new System.Drawing.Size(184, 23);
            this.btn_addComboBox.TabIndex = 4;
            this.btn_addComboBox.Text = "Adicionar ao ComboBox";
            this.btn_addComboBox.UseVisualStyleBackColor = true;
            this.btn_addComboBox.Click += new System.EventHandler(this.btn_addComboBox_Click);
            // 
            // tbx_inputTransporte
            // 
            this.tbx_inputTransporte.Location = new System.Drawing.Point(196, 125);
            this.tbx_inputTransporte.Name = "tbx_inputTransporte";
            this.tbx_inputTransporte.Size = new System.Drawing.Size(184, 20);
            this.tbx_inputTransporte.TabIndex = 5;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 221);
            this.Controls.Add(this.tbx_inputTransporte);
            this.Controls.Add(this.btn_addComboBox);
            this.Controls.Add(this.btn_resetarElementos);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_mostrarSelecionados);
            this.Controls.Add(this.cb_transportes);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_transportes;
        private System.Windows.Forms.Button btn_mostrarSelecionados;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_resetarElementos;
        private System.Windows.Forms.Button btn_addComboBox;
        private System.Windows.Forms.TextBox tbx_inputTransporte;
    }
}