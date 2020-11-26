using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace pimdesktop
{   

    public partial class TeladeEntrada : Form
    {
        //variavel global
        string setor = "";

        public TeladeEntrada()
        {
            
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //identifica setor pertence o usuario / senha
            setor = "3";
            Login login = new Login(setor);
            //redireciona
            login.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { setor = "5";
            Login login = new Login(setor);
            
            login.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            setor = "1";
            Login login = new Login(setor);

            login.ShowDialog();
        }

        private void linkEsqueceuaSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EsqueceuaSenha esqueceuaSenha = new EsqueceuaSenha();

            esqueceuaSenha.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            setor = "4";
            Login login = new Login(setor);

            login.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            setor = "2";
            Login login = new Login(setor);

            login.ShowDialog();
        }
    }
}
