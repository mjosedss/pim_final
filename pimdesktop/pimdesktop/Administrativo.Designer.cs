namespace pimdesktop
{
    partial class Administrativo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrativo));
            this.button2 = new System.Windows.Forms.Button();
            this.dgDados = new System.Windows.Forms.DataGridView();
            this.cpfcnpj = new System.Windows.Forms.MaskedTextBox();
            this.telFix = new System.Windows.Forms.MaskedTextBox();
            this.telCel = new System.Windows.Forms.MaskedTextBox();
            this.Confirma = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ConfirmaAltera = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numregistro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.setoor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cargoo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.statuus = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxSetor = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxCargo = new System.Windows.Forms.ComboBox();
            this.IncluirFuncionario = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "Lista Funcionários";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgDados
            // 
            this.dgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDados.Location = new System.Drawing.Point(12, 12);
            this.dgDados.Name = "dgDados";
            this.dgDados.Size = new System.Drawing.Size(450, 216);
            this.dgDados.TabIndex = 22;
            // 
            // cpfcnpj
            // 
            this.cpfcnpj.Location = new System.Drawing.Point(10, 455);
            this.cpfcnpj.Mask = "000.000.000-00";
            this.cpfcnpj.Name = "cpfcnpj";
            this.cpfcnpj.Size = new System.Drawing.Size(450, 20);
            this.cpfcnpj.TabIndex = 8;
            this.cpfcnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // telFix
            // 
            this.telFix.Location = new System.Drawing.Point(166, 416);
            this.telFix.Mask = "(99) 0000-0000";
            this.telFix.Name = "telFix";
            this.telFix.Size = new System.Drawing.Size(135, 20);
            this.telFix.TabIndex = 7;
            this.telFix.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // telCel
            // 
            this.telCel.Location = new System.Drawing.Point(12, 416);
            this.telCel.Mask = "(99) 00000-0000";
            this.telCel.Name = "telCel";
            this.telCel.Size = new System.Drawing.Size(135, 20);
            this.telCel.TabIndex = 6;
            this.telCel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // Confirma
            // 
            this.Confirma.Location = new System.Drawing.Point(354, 575);
            this.Confirma.Name = "Confirma";
            this.Confirma.Size = new System.Drawing.Size(108, 47);
            this.Confirma.TabIndex = 13;
            this.Confirma.Text = "Confirma";
            this.Confirma.UseVisualStyleBackColor = true;
            this.Confirma.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 439);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 82;
            this.label7.Text = "CPF/CNPJ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 81;
            this.label5.Text = "Telefone Celular";
            // 
            // ConfirmaAltera
            // 
            this.ConfirmaAltera.Location = new System.Drawing.Point(229, 575);
            this.ConfirmaAltera.Name = "ConfirmaAltera";
            this.ConfirmaAltera.Size = new System.Drawing.Size(110, 46);
            this.ConfirmaAltera.TabIndex = 15;
            this.ConfirmaAltera.Text = "Confirma";
            this.ConfirmaAltera.UseVisualStyleBackColor = true;
            this.ConfirmaAltera.Click += new System.EventHandler(this.Confirma_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(354, 295);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 47);
            this.button5.TabIndex = 4;
            this.button5.Text = "Buscar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 79;
            this.label6.Text = "Telefone Fixo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 78;
            this.label4.Text = "Nome";
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(12, 374);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(450, 20);
            this.nome.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 77;
            this.label3.Text = "Insira o número de registro";
            // 
            // numregistro
            // 
            this.numregistro.Location = new System.Drawing.Point(12, 328);
            this.numregistro.Name = "numregistro";
            this.numregistro.Size = new System.Drawing.Size(135, 20);
            this.numregistro.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 480);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 86;
            this.label1.Text = "Setor";
            // 
            // setoor
            // 
            this.setoor.Location = new System.Drawing.Point(12, 496);
            this.setoor.Name = "setoor";
            this.setoor.Size = new System.Drawing.Size(135, 20);
            this.setoor.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 480);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 88;
            this.label2.Text = "Cargo";
            // 
            // cargoo
            // 
            this.cargoo.Location = new System.Drawing.Point(168, 496);
            this.cargoo.Name = "cargoo";
            this.cargoo.Size = new System.Drawing.Size(135, 20);
            this.cargoo.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(324, 480);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 90;
            this.label8.Text = "Status";
            // 
            // statuus
            // 
            this.statuus.Location = new System.Drawing.Point(327, 496);
            this.statuus.Name = "statuus";
            this.statuus.Size = new System.Drawing.Size(135, 20);
            this.statuus.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(501, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 216);
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxSetor
            // 
            this.comboBoxSetor.FormattingEnabled = true;
            this.comboBoxSetor.Items.AddRange(new object[] {
            "Operacional",
            "Administrativo",
            "Atendimento",
            "Financeiro",
            "Comercial"});
            this.comboBoxSetor.Location = new System.Drawing.Point(12, 533);
            this.comboBoxSetor.Name = "comboBoxSetor";
            this.comboBoxSetor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSetor.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 517);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 93;
            this.label9.Text = "Setor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(165, 517);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 95;
            this.label10.Text = "Cargo";
            // 
            // comboBoxCargo
            // 
            this.comboBoxCargo.FormattingEnabled = true;
            this.comboBoxCargo.Items.AddRange(new object[] {
            "Tecnico",
            "Atendente",
            "Gerente",
            "Administrador",
            "Supervisor"});
            this.comboBoxCargo.Location = new System.Drawing.Point(168, 533);
            this.comboBoxCargo.Name = "comboBoxCargo";
            this.comboBoxCargo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCargo.TabIndex = 13;
            // 
            // IncluirFuncionario
            // 
            this.IncluirFuncionario.Location = new System.Drawing.Point(354, 575);
            this.IncluirFuncionario.Name = "IncluirFuncionario";
            this.IncluirFuncionario.Size = new System.Drawing.Size(110, 46);
            this.IncluirFuncionario.TabIndex = 16;
            this.IncluirFuncionario.Text = "Incluir Funcionário";
            this.IncluirFuncionario.UseVisualStyleBackColor = true;
            this.IncluirFuncionario.Click += new System.EventHandler(this.AlterarDados_Click);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(324, 517);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(37, 13);
            this.Status.TabIndex = 98;
            this.Status.Text = "Status";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Ativo",
            "Desligado"});
            this.comboBoxStatus.Location = new System.Drawing.Point(327, 533);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStatus.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 575);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 46);
            this.button1.TabIndex = 99;
            this.button1.Text = "Alterar Dados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Administrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 637);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.IncluirFuncionario);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBoxCargo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxSetor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.statuus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cargoo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setoor);
            this.Controls.Add(this.cpfcnpj);
            this.Controls.Add(this.telFix);
            this.Controls.Add(this.telCel);
            this.Controls.Add(this.Confirma);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ConfirmaAltera);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numregistro);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgDados);
            this.Name = "Administrativo";
            this.Text = "Administrativo";
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgDados;
        private System.Windows.Forms.MaskedTextBox cpfcnpj;
        private System.Windows.Forms.MaskedTextBox telFix;
        private System.Windows.Forms.MaskedTextBox telCel;
        private System.Windows.Forms.Button Confirma;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ConfirmaAltera;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numregistro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox setoor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cargoo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox statuus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxSetor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxCargo;
        private System.Windows.Forms.Button IncluirFuncionario;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Button button1;
    }
}