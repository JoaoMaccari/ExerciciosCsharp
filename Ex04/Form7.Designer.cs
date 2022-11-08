
namespace Ex04 {
    partial class Form7 {
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
            this.Label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ll_canal = new System.Windows.Forms.LinkLabel();
            this.ll_calculadora = new System.Windows.Forms.LinkLabel();
            this.ll_multiplos = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(12, 9);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(33, 13);
            this.Label.TabIndex = 0;
            this.Label.Text = "Label";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // ll_canal
            // 
            this.ll_canal.AutoSize = true;
            this.ll_canal.Location = new System.Drawing.Point(12, 72);
            this.ll_canal.Name = "ll_canal";
            this.ll_canal.Size = new System.Drawing.Size(34, 13);
            this.ll_canal.TabIndex = 2;
            this.ll_canal.TabStop = true;
            this.ll_canal.Text = "Canal";
            this.ll_canal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_canal_LinkClicked);
            // 
            // ll_calculadora
            // 
            this.ll_calculadora.AutoSize = true;
            this.ll_calculadora.Location = new System.Drawing.Point(60, 72);
            this.ll_calculadora.Name = "ll_calculadora";
            this.ll_calculadora.Size = new System.Drawing.Size(63, 13);
            this.ll_calculadora.TabIndex = 3;
            this.ll_calculadora.TabStop = true;
            this.ll_calculadora.Text = "Calculadora";
            this.ll_calculadora.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_calculadora_LinkClicked);
            // 
            // ll_multiplos
            // 
            this.ll_multiplos.AutoSize = true;
            this.ll_multiplos.Location = new System.Drawing.Point(15, 114);
            this.ll_multiplos.Name = "ll_multiplos";
            this.ll_multiplos.Size = new System.Drawing.Size(121, 13);
            this.ll_multiplos.TabIndex = 4;
            this.ll_multiplos.TabStop = true;
            this.ll_multiplos.Text = "google - canal - youtube";
            this.ll_multiplos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_multiplos_LinkClicked);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 311);
            this.Controls.Add(this.ll_multiplos);
            this.Controls.Add(this.ll_calculadora);
            this.Controls.Add(this.ll_canal);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Label);
            this.Name = "Form7";
            this.Text = "Form7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.LinkLabel ll_canal;
        private System.Windows.Forms.LinkLabel ll_calculadora;
        private System.Windows.Forms.LinkLabel ll_multiplos;
    }
}