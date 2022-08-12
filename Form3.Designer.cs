namespace Criptografia_MALI
{
    partial class Form3
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
            this.bnt_voltar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_humano = new System.Windows.Forms.TextBox();
            this.txtbox_mali = new System.Windows.Forms.TextBox();
            this.bnt_decriptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bnt_voltar
            // 
            this.bnt_voltar.Location = new System.Drawing.Point(354, 26);
            this.bnt_voltar.Name = "bnt_voltar";
            this.bnt_voltar.Size = new System.Drawing.Size(102, 44);
            this.bnt_voltar.TabIndex = 9;
            this.bnt_voltar.Text = "TROCAR";
            this.bnt_voltar.UseVisualStyleBackColor = true;
            this.bnt_voltar.Click += new System.EventHandler(this.bnt_voltar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Criptografia MALI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(490, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Criptografia Humana";
            // 
            // txtbox_humano
            // 
            this.txtbox_humano.Location = new System.Drawing.Point(476, 87);
            this.txtbox_humano.Name = "txtbox_humano";
            this.txtbox_humano.Size = new System.Drawing.Size(306, 22);
            this.txtbox_humano.TabIndex = 6;
            // 
            // txtbox_mali
            // 
            this.txtbox_mali.Location = new System.Drawing.Point(14, 87);
            this.txtbox_mali.Name = "txtbox_mali";
            this.txtbox_mali.Size = new System.Drawing.Size(324, 22);
            this.txtbox_mali.TabIndex = 5;
            // 
            // bnt_decriptar
            // 
            this.bnt_decriptar.Location = new System.Drawing.Point(354, 355);
            this.bnt_decriptar.Name = "bnt_decriptar";
            this.bnt_decriptar.Size = new System.Drawing.Size(130, 74);
            this.bnt_decriptar.TabIndex = 10;
            this.bnt_decriptar.Text = "DECRIPTAR";
            this.bnt_decriptar.UseVisualStyleBackColor = true;
            this.bnt_decriptar.Click += new System.EventHandler(this.bnt_decriptar_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bnt_decriptar);
            this.Controls.Add(this.bnt_voltar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_humano);
            this.Controls.Add(this.txtbox_mali);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnt_voltar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_humano;
        private System.Windows.Forms.TextBox txtbox_mali;
        private System.Windows.Forms.Button bnt_decriptar;
    }
}