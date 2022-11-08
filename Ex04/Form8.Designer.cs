
namespace Ex04 {
    partial class Form8 {
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
            this.lb_carros = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Inputcarro = new System.Windows.Forms.TextBox();
            this.btn_addCarro = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_obter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_carros
            // 
            this.lb_carros.FormattingEnabled = true;
            this.lb_carros.Location = new System.Drawing.Point(12, 12);
            this.lb_carros.Name = "lb_carros";
            this.lb_carros.Size = new System.Drawing.Size(137, 199);
            this.lb_carros.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Carro";
            // 
            // tb_Inputcarro
            // 
            this.tb_Inputcarro.Location = new System.Drawing.Point(155, 28);
            this.tb_Inputcarro.Name = "tb_Inputcarro";
            this.tb_Inputcarro.Size = new System.Drawing.Size(100, 20);
            this.tb_Inputcarro.TabIndex = 2;
            // 
            // btn_addCarro
            // 
            this.btn_addCarro.Location = new System.Drawing.Point(155, 68);
            this.btn_addCarro.Name = "btn_addCarro";
            this.btn_addCarro.Size = new System.Drawing.Size(75, 23);
            this.btn_addCarro.TabIndex = 3;
            this.btn_addCarro.Text = "ADICIONAR";
            this.btn_addCarro.UseVisualStyleBackColor = true;
            this.btn_addCarro.Click += new System.EventHandler(this.btn_addCarro_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(155, 97);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(75, 23);
            this.btn_remover.TabIndex = 4;
            this.btn_remover.Text = "REMOVER";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_obter
            // 
            this.btn_obter.Location = new System.Drawing.Point(155, 126);
            this.btn_obter.Name = "btn_obter";
            this.btn_obter.Size = new System.Drawing.Size(75, 23);
            this.btn_obter.TabIndex = 5;
            this.btn_obter.Text = "OBTER";
            this.btn_obter.UseVisualStyleBackColor = true;
            this.btn_obter.Click += new System.EventHandler(this.btn_obter_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 332);
            this.Controls.Add(this.btn_obter);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_addCarro);
            this.Controls.Add(this.tb_Inputcarro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_carros);
            this.Name = "Form8";
            this.Text = "Form8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_carros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Inputcarro;
        private System.Windows.Forms.Button btn_addCarro;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_obter;
    }
}