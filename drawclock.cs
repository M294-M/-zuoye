using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp13
{
    public partial class Form2 : Form
    {
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private int num = 0;
        private int num2 = 0;
        private int num3 = 0;
        private int Radius=100;
        private int Radiux=100;
        private int Radiuy = 100;
        private int count = 60;
        private int length = 10;
        private Font clockFont;
        private SolidBrush clockBrush;
        public Form2()
        {
            InitializeComponent();
            clockFont = new Font("微软雅黑", 12);
            clockBrush = new SolidBrush(Color.Black);

            panel1.Paint += Panel1_Paint;
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            num = DateTime.Now.Second;
            num2 = DateTime.Now.Minute;
            num3 = DateTime.Now.Hour;
            panel1.Invalidate();
        }
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using (Pen pen=new Pen(Color.Black,2))
            {
                g.DrawEllipse(pen,Radiux-Radius,Radiuy-Radius,2*Radius,2*Radius);
                int temlength=length;
                for (int i = 0; i < count; i++)
                {
                    if (i % 5 == 0) temlength = 2*length;
                    var endx = Radius * Math.Cos(360 / count * i * Math.PI / 180) + Radiux;
                    var endy = Radius * Math.Sin(360 / count * i * Math.PI / 180) + Radiuy;
                    var startx = (Radius-temlength) * Math.Cos(360 / count * i * Math.PI / 180) + Radiux;
                    var starty = (Radius-temlength) * Math.Sin(360 / count * i * Math.PI / 180) + Radiuy;
                    g.DrawLine(pen, (int)startx, (int)starty, (int)endx, (int)endy);
                    temlength = length;
                }
                //数字
                //using (Font font = new Font("微软雅黑", 12))
                using (Brush brush = Brushes.Black)
                {
                    for (int j = 1; j <= 12; j++)
                    {
                        var textx = Radiux +(Radius+5) * Math.Cos((270 + j * 30) * Math.PI / 180);
                        var texty = Radiuy + (Radius+5) * Math.Sin((270 + j * 30) * Math.PI / 180);
                        g.DrawString(j.ToString(), clockFont, clockBrush, (int)textx, (int)texty);
                    }
                }


                //绘制秒针
                using (Pen pen2=new Pen(Color.Red,2))
                {
                   var endx2=(Radius-temlength)*Math.Cos(((360/count) *num+270)*Math.PI/180)+Radiux;
                   var endy2=(Radius-temlength)*Math.Sin(((360/count) *num+270)*Math.PI/180)+Radiuy;
                   g.DrawLine(pen2, Radiux, Radiuy, (int)endx2, (int)endy2);
                }
                //绘制分针
                using (Pen pen3 = new Pen(Color.Blue, 2))
                { 
                    var endx3=(Radius-2*temlength)*Math.Cos(((360/count) *num2+270)*Math.PI/180)+Radiux;
                    var endy3=(Radius-2*temlength)*Math.Sin(((360/count) *num2+270)*Math.PI/180)+Radiuy;
                    g.DrawLine(pen3, Radiux, Radiuy, (int)endx3, (int)endy3);
                }
                //时针
                using (Pen pen4 = new Pen(Color.Green, 2))
                {
                    var endx4 = (Radius - 3 * temlength) * Math.Cos((30 * num3+num2*0.5  + 270) * Math.PI / 180) + Radiux;
                    var endy4 = (Radius - 3 * temlength) * Math.Sin((30 * num3+num2*0.5  + 270) * Math.PI / 180) + Radiuy;
                    g.DrawLine(pen4, Radiux, Radiuy, (int)endx4, (int)endy4);
                }

            }



            }
        }
    }


    public class DoubleBufferPanel : Panel
    {
        public DoubleBufferPanel()
        {
            //开启双缓冲，消除闪烁
            this.SetStyle(ControlStyles.UserPaint
                | ControlStyles.AllPaintingInWmPaint
                | ControlStyles.OptimizedDoubleBuffer, true);
            UpdateStyles();
        }
    }




