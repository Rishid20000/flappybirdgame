using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappybirdwinform
{
    public partial class Form1 : Form
    {

        int pipespeed = 8;
        int gravity = 12;
        int score = 0;




        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            FlappyBird.Top += gravity;
            pipebottom.Left -= pipespeed;
            pipetop.Left -= pipespeed;
            scoretext.Text = "Score:" + score;

            if(pipetop.Left < -100)
            { pipetop.Left = 800;
                score++;           
            }//ratio of forms 
            
            if(pipebottom.Left < -140)
            { pipebottom.Left = 900;
                score++;           
            }
            
            if(FlappyBird.Bounds.IntersectsWith(pipetop.Bounds) ||
                FlappyBird.Bounds.IntersectsWith(pipebottom.Bounds) ||
                FlappyBird.Bounds.IntersectsWith(ground.Bounds))
            
            { endGame(); }

            if (FlappyBird.Top < -10)//upper boundary
            { endGame(); }



            if(score > 7)
            { pipespeed = 10; }

            if(score > 10)
                { pipespeed = 15 ; }

            if (score > 20)
            { pipespeed = 17; }

            if (score > 30)
            { pipespeed = 20; }

            if (score > 40)
            { pipespeed = 22; }

            if (score > 50)
            { pipespeed = 25; }




        }

        private void gameKeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            { gravity = -10; }

        }

        private void gameKeyisup(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            { gravity = 10; }
        }

        private void endGame()
        {
            gameTimer.Stop();
            if (score < 10)
            { scoretext.Text += " looser "; }
            else if (score > 20 && score<30)
            { scoretext.Text += " good try!"; }
            else if (score > 30)
            { scoretext.Text += " great "; }
            
        }


    }
}
