namespace Criptografia_MALI
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtbox_humano = new System.Windows.Forms.TextBox();
            this.txtbox_mali = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bnt_encriptar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bnt_trocar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbox_humano
            // 
            this.txtbox_humano.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_humano.Location = new System.Drawing.Point(12, 81);
            this.txtbox_humano.Multiline = true;
            this.txtbox_humano.Name = "txtbox_humano";
            this.txtbox_humano.Size = new System.Drawing.Size(380, 291);
            this.txtbox_humano.TabIndex = 0;
            this.txtbox_humano.TextChanged += new System.EventHandler(this.txtbox_humano_TextChanged);
            // 
            // txtbox_mali
            // 
            this.txtbox_mali.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_mali.Location = new System.Drawing.Point(538, 81);
            this.txtbox_mali.Multiline = true;
            this.txtbox_mali.Name = "txtbox_mali";
            this.txtbox_mali.Size = new System.Drawing.Size(380, 291);
            this.txtbox_mali.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 32);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(514, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 32);
            this.label2.TabIndex = 3;
            // 
            // bnt_encriptar
            // 
            this.bnt_encriptar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.bnt_encriptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_encriptar.Location = new System.Drawing.Point(393, 445);
            this.bnt_encriptar.Name = "bnt_encriptar";
            this.bnt_encriptar.Size = new System.Drawing.Size(147, 60);
            this.bnt_encriptar.TabIndex = 11;
            this.bnt_encriptar.Text = "CODIFICAR";
            this.bnt_encriptar.UseVisualStyleBackColor = false;
            this.bnt_encriptar.Click += new System.EventHandler(this.bnt_encriptar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(603, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 50);
            this.label3.TabIndex = 12;
            this.label3.Text = "ENCRIPTADO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(64, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 50);
            this.label4.TabIndex = 13;
            this.label4.Text = "DESCRIPTADO";
            // 
            // bnt_trocar
            // 
            this.bnt_trocar.BackColor = System.Drawing.Color.Transparent;
            this.bnt_trocar.BackgroundImage = global::Criptografia_MALI.Properties.Resources.CLEAR;
            this.bnt_trocar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnt_trocar.Location = new System.Drawing.Point(869, 396);
            this.bnt_trocar.Name = "bnt_trocar";
            this.bnt_trocar.Size = new System.Drawing.Size(49, 46);
            this.bnt_trocar.TabIndex = 4;
            this.bnt_trocar.UseVisualStyleBackColor = false;
            this.bnt_trocar.Click += new System.EventHandler(this.bnt_trocar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Criptografia_MALI.Properties.Resources.FUNDO_CONVERTER;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(930, 555);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bnt_encriptar);
            this.Controls.Add(this.bnt_trocar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_mali);
            this.Controls.Add(this.txtbox_humano);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_humano;
        private System.Windows.Forms.TextBox txtbox_mali;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bnt_trocar;
        private System.Windows.Forms.Button bnt_encriptar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}