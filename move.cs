using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class move : Form
    {
        public move()
        {
            InitializeComponent();
            //initmove();
            this.KeyDown += Move_KeyDown;
            //MessageBox.Show(this.Height.ToString());
            //MessageBox.Show(this.Width.ToString());
            //MessageBox.Show(box.Height.ToString());
            //MessageBox.Show(box.Width.ToString());
        }
        private int speed = 5;
        //private void initmove()
        //{
        //    this.KeyDown += Move_KeyDown;
        //}

        private void Move_KeyDown(object sender, KeyEventArgs e)
        {
           Point n=box.Location;
            switch (e.KeyCode)
            {
                case Keys.W:
                    n.Y -= speed;
                    break;
                case Keys.S:
                    n.Y += speed;
                    break;
                case Keys.A:
                    n.X -= speed;
                    break;
                case Keys.D:
                    n.X += speed;
                    break;
                default:
                    break;
            }
            if(n.X<0) n.X = 0;
            if(n.Y<0) n.Y = 0;
            if(n.X > this.Width - box.Width) n.X = this.Width - box.Width;
            if(n.Y > this.Height - box.Height) n.Y = this.Height - box.Height;
            box.Location = n;
        }
        
    }
}
