namespace pimdesktop
{
    partial class Financeiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Financeiro));
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgDados = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datFinal = new System.Windows.Forms.MaskedTextBox();
            this.datInicial = new System.Windows.Forms.MaskedTextBox();
            this.somaa = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Saldoo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 47);
            this.button2.TabIndex = 3;
            this.button2.Text = "Executar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(504, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 216);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // dgDados
            // 
            this.dgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDados.Location = new System.Drawing.Point(12, 12);
            this.dgDados.Name = "dgDados";
            this.dgDados.Size = new System.Drawing.Size(450, 216);
            this.dgDados.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Entre com a data inicial";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Entre com a data final";
            // 
            // datFinal
            // 
            this.datFinal.Location = new System.Drawing.Point(11, 361);
            this.datFinal.Mask = "00/00/0000";
            this.datFinal.Name = "datFinal";
            this.datFinal.Size = new System.Drawing.Size(108, 20);
            this.datFinal.TabIndex = 2;
            // 
            // datInicial
            // 
            this.datInicial.Location = new System.Drawing.Point(11, 316);
            this.datInicial.Mask = "00/00/0000";
            this.datInicial.Name = "datInicial";
            this.datInicial.Size = new System.Drawing.Size(108, 20);
            this.datInicial.TabIndex = 1;
            // 
            // somaa
            // 
            this.somaa.Location = new System.Drawing.Point(12, 400);
            this.somaa.Name = "somaa";
            this.somaa.Size = new System.Drawing.Size(106, 20);
            this.somaa.TabIndex = 37;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(261, 243);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(108, 47);
            this.button7.TabIndex = 5;
            this.button7.Text = "Historico";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Total X Período";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Saldo Total";
            // 
            // Saldoo
            // 
            this.Saldoo.Location = new System.Drawing.Point(137, 400);
            this.Saldoo.Name = "Saldoo";
            this.Saldoo.Size = new System.Drawing.Size(108, 20);
            this.Saldoo.TabIndex = 40;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "Saldo Clientes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Financeiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Saldoo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.somaa);
            this.Controls.Add(this.datInicial);
            this.Controls.Add(this.datFinal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgDados);
            this.Name = "Financeiro";
            this.Text = "Financeiro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgDados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox datFinal;
        private System.Windows.Forms.MaskedTextBox datInicial;
        private System.Windows.Forms.TextBox somaa;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Saldoo;
        private System.Windows.Forms.Button button1;
    }
}