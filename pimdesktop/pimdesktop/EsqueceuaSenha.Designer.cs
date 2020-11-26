namespace pimdesktop
{
    partial class EsqueceuaSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EsqueceuaSenha));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NumReg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cpfcnpj = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EntraSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ConfSenha = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entre com seu CPF";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(179, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 203);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // NumReg
            // 
            this.NumReg.Location = new System.Drawing.Point(11, 82);
            this.NumReg.Name = "NumReg";
            this.NumReg.Size = new System.Drawing.Size(162, 20);
            this.NumReg.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Entre com seu número de registro";
            // 
            // cpfcnpj
            // 
            this.cpfcnpj.Location = new System.Drawing.Point(11, 29);
            this.cpfcnpj.Mask = "000.000.000-00";
            this.cpfcnpj.Name = "cpfcnpj";
            this.cpfcnpj.Size = new System.Drawing.Size(162, 20);
            this.cpfcnpj.TabIndex = 1;
            this.cpfcnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 97;
            this.label3.Text = "Digite sua nova senha";
            // 
            // EntraSenha
            // 
            this.EntraSenha.Location = new System.Drawing.Point(11, 139);
            this.EntraSenha.Name = "EntraSenha";
            this.EntraSenha.PasswordChar = '*';
            this.EntraSenha.Size = new System.Drawing.Size(162, 20);
            this.EntraSenha.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 99;
            this.label4.Text = "Confirme sua nova senha";
            // 
            // ConfSenha
            // 
            this.ConfSenha.Location = new System.Drawing.Point(11, 189);
            this.ConfSenha.Name = "ConfSenha";
            this.ConfSenha.PasswordChar = '*';
            this.ConfSenha.Size = new System.Drawing.Size(162, 20);
            this.ConfSenha.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(11, 229);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(162, 47);
            this.button5.TabIndex = 5;
            this.button5.Text = "Enviar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // EsqueceuaSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 288);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ConfSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EntraSenha);
            this.Controls.Add(this.cpfcnpj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumReg);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "EsqueceuaSenha";
            this.Text = "EsqueceuaSenha";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox NumReg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox cpfcnpj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EntraSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ConfSenha;
        private System.Windows.Forms.Button button5;
    }
}