using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_O_GAME
{
    public partial class Form1 : Form
    {
        enum GameType { X, O } ;
        GameType current_gt = GameType.X;
        int played_games = 0;
        Button[,] btns = new Button[3, 3]; 

        public Form1()
        {
            InitializeComponent();
            btns[0, 0] = btn00; btns[0, 1] = btn01; btns[0, 2] = btn02;
            btns[1, 0] = btn10; btns[1, 1] = btn11; btns[1, 2] = btn12;
            btns[2, 0] = btn20; btns[2, 1] = btn21; btns[2, 2] = btn22;
            foreach (Button btn in btns) btn.Click += new EventHandler(btn_Click);  
        }
        void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text != "") return;
            played_games++; 
            btn.Text = current_gt.ToString();
            if (Iswin())
            {    MessageBox.Show(current_gt.ToString() + "  Is win");
            Newgame();
            return;
            }
             if (played_games == 9) 
             {
                 MessageBox.Show("The score is equal");
                 Newgame(); 
             }
             Swich_game(); 
        }
       

        void Newgame()
        {
            foreach (Button btn in btns) btn.Text = "";
            played_games = 0;
        }
            void Swich_game()
            {
                if (current_gt == GameType.X)
                    current_gt = GameType.O;
                else
                    current_gt = GameType.X; 
            }

            bool Iswin()
            {
                for (int i = 0; i <= 2; i++)
                {
                    if (btns[0, i].Text == current_gt.ToString() &&
                        btns[0, i].Text == btns[1, i].Text &&
                        btns[1, i].Text == btns[2, i].Text)
                        return true;
                    if (btns[i,0].Text == current_gt.ToString() &&
                        btns[i,0].Text == btns[i,1].Text &&
                        btns[i,1].Text == btns[i,2].Text)
                        return true;    
                }

                if (btns[0, 0].Text == current_gt.ToString() &&
                        btns[0, 0].Text == btns[1, 1].Text &&
                        btns[1, 1].Text == btns[2, 2].Text)
                    return true;

                if (btns[0, 2].Text == current_gt.ToString() &&
                        btns[0, 2].Text == btns[1, 1].Text &&
                        btns[1,1].Text == btns[2, 0].Text)
                    return true;
                return false;

               
            }
        

            private void btn00_Click(object sender, EventArgs e)
            {
               if( pictureBox2.Visible == false)
                pictureBox2.Visible = true;
               else if (pictureBox2.Visible == true)
                   pictureBox2.Visible = false;
               
            }

            private void btn01_Click(object sender, EventArgs e)
            {
                if (pictureBox2.Visible == false)
                    pictureBox2.Visible = true;
                else if (pictureBox2.Visible == true)
                    pictureBox2.Visible = false;
                
            }

            private void btn02_Click(object sender, EventArgs e)
            {
                if (pictureBox2.Visible == false)
                    pictureBox2.Visible = true;
                else if (pictureBox2.Visible == true)
                    pictureBox2.Visible = false;
                
            }

            private void btn10_Click(object sender, EventArgs e)
            {
                if (pictureBox2.Visible == false)
                    pictureBox2.Visible = true;
                else if (pictureBox2.Visible == true)
                    pictureBox2.Visible = false;
                
            }

            private void btn11_Click(object sender, EventArgs e)
            {
                if (pictureBox2.Visible == false)
                    pictureBox2.Visible = true;
                else if (pictureBox2.Visible == true)
                    pictureBox2.Visible = false;
                
            }

            private void btn12_Click(object sender, EventArgs e)
            {
                if (pictureBox2.Visible == false)
                    pictureBox2.Visible = true;
                else if (pictureBox2.Visible == true)
                    pictureBox2.Visible = false;
                
            }

            private void btn20_Click(object sender, EventArgs e)
            {
                if (pictureBox2.Visible == false)
                    pictureBox2.Visible = true;
                else if (pictureBox2.Visible == true)
                    pictureBox2.Visible = false;
                
            }

            private void btn21_Click(object sender, EventArgs e)
            {
                if (pictureBox2.Visible == false)
                    pictureBox2.Visible = true;
                else if (pictureBox2.Visible == true)
                    pictureBox2.Visible = false;
                
            }

            private void btn22_Click(object sender, EventArgs e)
            {
                if (pictureBox2.Visible == false)
                    pictureBox2.Visible = true;
                else if (pictureBox2.Visible == true)
                    pictureBox2.Visible = false;
                
            }
       
            
            
        
    }
}
