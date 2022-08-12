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
            this.bnt_trocar = new System.Windows.Forms.Button();
            this.bnt_encriptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbox_humano
            // 
            this.txtbox_humano.Location = new System.Drawing.Point(12, 81);
            this.txtbox_humano.Name = "txtbox_humano";
            this.txtbox_humano.Size = new System.Drawing.Size(324, 22);
            this.txtbox_humano.TabIndex = 0;
            // 
            // txtbox_mali
            // 
            this.txtbox_mali.Location = new System.Drawing.Point(474, 81);
            this.txtbox_mali.Name = "txtbox_mali";
            this.txtbox_mali.Size = new System.Drawing.Size(306, 22);
            this.txtbox_mali.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Criptografia Humana";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(514, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Criptografia MALI";
            // 
            // bnt_trocar
            // 
            this.bnt_trocar.Location = new System.Drawing.Point(368, 19);
            this.bnt_trocar.Name = "bnt_trocar";
            this.bnt_trocar.Size = new System.Drawing.Size(102, 44);
            this.bnt_trocar.TabIndex = 4;
            this.bnt_trocar.Text = "TROCAR";
            this.bnt_trocar.UseVisualStyleBackColor = true;
            this.bnt_trocar.Click += new System.EventHandler(this.bnt_trocar_Click);
            // 
            // bnt_encriptar
            // 
            this.bnt_encriptar.Location = new System.Drawing.Point(340, 351);
            this.bnt_encriptar.Name = "bnt_encriptar";
            this.bnt_encriptar.Size = new System.Drawing.Size(130, 74);
            this.bnt_encriptar.TabIndex = 11;
            this.bnt_encriptar.Text = "ENCRIPTAR";
            this.bnt_encriptar.UseVisualStyleBackColor = true;
            this.bnt_encriptar.Click += new System.EventHandler(this.bnt_encriptar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bnt_encriptar);
            this.Controls.Add(this.bnt_trocar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_mali);
            this.Controls.Add(this.txtbox_humano);
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
    }
}