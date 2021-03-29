using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpTest2
{
    public partial class Form1 : Form
    {
        private int speed_vert = -6;
        private int speed_horz = -6;
        public Form1()
        {
            InitializeComponent();

            Timer.Enabled = true;

            Cursor.Hide();

            //this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            GamePanel.Location = new Point(Background.Right/2 - GamePanel.Width/2,
                                           Background.Bottom - Background.Bottom/10);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.D)
            {
                Cursor.Position = new Point(Cursor.Position.X + 25,
                                            Cursor.Position.Y);
            }

            if (e.KeyCode == Keys.A)
            {
                Cursor.Position = new Point(Cursor.Position.X - 25,
                                            Cursor.Position.Y);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (Cursor.Position.X < Background.Right - GamePanel.Width)
            {
                GamePanel.Left = Cursor.Position.X;
            }

            GameBall.Left += speed_horz;
            GameBall.Top += speed_vert;

            if (GameBall.Left <= Background.Left || GameBall.Right >= Background.Right)
            {
                speed_horz *= -1;
            }

            if (GameBall.Top <= Background.Top)
            {
                speed_vert *= -1;
            }

            if (GameBall.Bottom >= Background.Bottom)
            {
                Timer.Enabled = false;
            }

            if(GameBall.Bottom >= GamePanel.Top &&
               GameBall.Left >= GamePanel.Left &&
               GameBall.Right <= GamePanel.Right)
            {
                speed_vert *= -1;
                /*speed_vert += 2;
                speed_horz += 2;*/
            }
        }
    }
}
