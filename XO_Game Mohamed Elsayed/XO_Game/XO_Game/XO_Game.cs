using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace XO_Game
{
    public partial class XO_Game : Form

    {
        public string PlayerXName { get; private set; }
        public string PlayerOName { get; private set; }
        public XO_Game()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public void btn_startGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            XO_Games form1 = new XO_Games(txt_player1.Text, txt_player2.Text,R_btn_X.Checked,R_btn_O.Checked);
            form1.ShowDialog();
            this.Close();
           
        }
/*        public void btnOK_Click(object sender, EventArgs e)
        {
            PlayerXName = txt_player1.Text;
            PlayerOName = txt_player2.Text;
            this.Close();
        }*/
        private void gb_player1_Enter(object sender, EventArgs e)
        {

        }
        private void gb_player2_Enter(object sender, EventArgs e)
        {
            /*R_btn_X2.Text = "X2";
            R_btn_O2.Text = "O2";*/
        }
        private void R_btn_X_CheckedChanged(object sender, EventArgs e)
        {
            if (R_btn_X.Checked)
            {
                R_btn_O2.Checked = true;
                R_btn_X2.Checked = false;
            }
        }
        private void R_btn_O_CheckedChanged(object sender, EventArgs e)
        {
            if (R_btn_O.Checked)
            {
                R_btn_X2.Checked = true;
                R_btn_O2.Checked = false;
            }
        }
        private void R_btn_X2_CheckedChanged(object sender, EventArgs e)
        {
            if (R_btn_X2.Checked)
            {
                R_btn_O.Checked = true;
                R_btn_X.Checked = false;
            }

        }
        private void R_btn_O2_CheckedChanged(object sender, EventArgs e)
        {
            if (R_btn_O2.Checked)
            {
                R_btn_X.Checked = true;
                R_btn_X2.Checked = false;
            }

        }
        public void txt_player2_TextChanged(object sender, EventArgs e)
        {
           // string textvalue2 = txt_player2.Text;
        }
        public void txt_player1_TextChanged(object sender, EventArgs e)
        {
           // string textvalue = txt_player1.Text;
        }

    }
}
