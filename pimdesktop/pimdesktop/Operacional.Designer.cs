﻿namespace pimdesktop
{
    partial class Operacional
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Operacional));
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.resol = new System.Windows.Forms.TextBox();
            this.finaliza = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.desc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nomeRZ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numeroOS = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgDados = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.telCel = new System.Windows.Forms.MaskedTextBox();
            this.telFix = new System.Windows.Forms.MaskedTextBox();
            this.cpfcnpj = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).BeginInit();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(10, 866);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(137, 46);
            this.button6.TabIndex = 14;
            this.button6.Text = "Consulta Clientes";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(498, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 216);
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 690);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Resolução";
            // 
            // resol
            // 
            this.resol.Location = new System.Drawing.Point(12, 706);
            this.resol.Multiline = true;
            this.resol.Name = "resol";
            this.resol.Size = new System.Drawing.Size(450, 140);
            this.resol.TabIndex = 12;
            // 
            // finaliza
            // 
            this.finaliza.Location = new System.Drawing.Point(354, 866);
            this.finaliza.Name = "finaliza";
            this.finaliza.Size = new System.Drawing.Size(108, 47);
            this.finaliza.TabIndex = 13;
            this.finaliza.Text = "Finalizar";
            this.finaliza.UseVisualStyleBackColor = true;
            this.finaliza.Click += new System.EventHandler(this.finaliza_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(354, 339);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 47);
            this.button5.TabIndex = 6;
            this.button5.Text = "Buscar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 525);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Descrição da solicitação";
            // 
            // desc
            // 
            this.desc.Location = new System.Drawing.Point(12, 541);
            this.desc.Multiline = true;
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(450, 140);
            this.desc.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 483);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "CPF/CNPJ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Telefone Fixo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 444);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Telefone Celular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Nome / Razão social do cliente";
            // 
            // nomeRZ
            // 
            this.nomeRZ.Location = new System.Drawing.Point(12, 418);
            this.nomeRZ.Name = "nomeRZ";
            this.nomeRZ.Size = new System.Drawing.Size(450, 20);
            this.nomeRZ.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Insira o número da O.S.";
            // 
            // numeroOS
            // 
            this.numeroOS.Location = new System.Drawing.Point(12, 372);
            this.numeroOS.Name = "numeroOS";
            this.numeroOS.Size = new System.Drawing.Size(108, 20);
            this.numeroOS.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(354, 265);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 47);
            this.button4.TabIndex = 4;
            this.button4.Text = "Fale Conosco";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(240, 265);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 47);
            this.button3.TabIndex = 3;
            this.button3.Text = "Carteira Virtual";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(126, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "Contratos inteligentes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Lista de O.S.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Tratar O.S.";
            // 
            // dgDados
            // 
            this.dgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDados.Location = new System.Drawing.Point(12, 43);
            this.dgDados.Name = "dgDados";
            this.dgDados.Size = new System.Drawing.Size(450, 216);
            this.dgDados.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Proteção de ativos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // telCel
            // 
            this.telCel.Location = new System.Drawing.Point(12, 460);
            this.telCel.Mask = "(99) 00000-0000";
            this.telCel.Name = "telCel";
            this.telCel.Size = new System.Drawing.Size(135, 20);
            this.telCel.TabIndex = 8;
            this.telCel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // telFix
            // 
            this.telFix.Location = new System.Drawing.Point(166, 460);
            this.telFix.Mask = "(99) 0000-0000";
            this.telFix.Name = "telFix";
            this.telFix.Size = new System.Drawing.Size(135, 20);
            this.telFix.TabIndex = 9;
            this.telFix.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // cpfcnpj
            // 
            this.cpfcnpj.Location = new System.Drawing.Point(10, 499);
            this.cpfcnpj.Mask = "000.000.000-00";
            this.cpfcnpj.Name = "cpfcnpj";
            this.cpfcnpj.Size = new System.Drawing.Size(450, 20);
            this.cpfcnpj.TabIndex = 10;
            this.cpfcnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // Operacional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 927);
            this.Controls.Add(this.cpfcnpj);
            this.Controls.Add(this.telFix);
            this.Controls.Add(this.telCel);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.resol);
            this.Controls.Add(this.finaliza);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nomeRZ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numeroOS);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgDados);
            this.Controls.Add(this.button1);
            this.Name = "Operacional";
            this.Text = "Operacional";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox resol;
        private System.Windows.Forms.Button finaliza;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox desc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nomeRZ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numeroOS;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgDados;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox telCel;
        private System.Windows.Forms.MaskedTextBox telFix;
        private System.Windows.Forms.MaskedTextBox cpfcnpj;
    }
}