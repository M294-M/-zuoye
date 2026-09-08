using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp14
{
    public partial class Form2 : Form
    {
        private List<Labelandtimer> list = new();
        private Random rand = new Random();
        private int score = 0;
        private System.Windows.Forms.Timer Golbaltimer = new();
        bool ispause = false;
        public Form2()
        {
            InitializeComponent();
            this.Shown += Gameinit;//窗体打开后执行一次

        }
        private void Gameinit(object sender, EventArgs e)
        {
            Golbaltimer.Interval = 1000;
            Golbaltimer.Tick += (object sender, EventArgs e) => Createlabel();//不用解绑的原因是因为createlabel本身是空的，解绑和绑定的不是同一个方法
            this.KeyPreview = true;
            this.ActiveControl = null;
            this.KeyUp += Form2_KeyUp;
        }

        private void Form2_KeyUp(object? sender, KeyEventArgs e)
        {
            if (ispause) return;
            //遍历list拿到lab.text和e.keycode比较是否相等，相等删除对应的计时器
            for (int i = 0; i < list.Count; i++)
            {
                if (Enum.TryParse(list[i].lab.Text, true, out Keys k))
                {
                    if (k != e.KeyCode) continue;
                    //相等删除
                    list[i].timer.Stop();
                    panel1.Controls.Remove(list[i].lab);
                    list.RemoveAt(i);
                    label2.Text = (++score).ToString();
                    Createlabel();
                    return;



                }

            }


        }

        private void Createlabel()
        {
            Label lab = new Label();
            lab.Text = ((char)(rand.Next(65, 91))).ToString();//ascll码
            lab.Location = new Point(rand.Next(panel1.Width - 30), 0);
            lab.Size = new Size(30, 30);
            lab.TextAlign = ContentAlignment.MiddleCenter;
            lab.Font = new Font("微软雅黑", 14, FontStyle.Bold);
            panel1.Controls.Add(lab);
            //生成对应的计时器，并添加到list中,记录下降速度
            System.Windows.Forms.Timer ti = new();
            ti.Interval = 10;
            ti.Tick += (object sender, EventArgs e) => Down(lab);
            ti.Start();
            list.Add(new Labelandtimer(lab, ti));

        }
        private void Down(Label labe)
        {
            labe.Top += 2;
            if (labe.Top >= panel1.Height - 30)
            {
                Golbaltimer.Stop();
                list.ForEach(item => item.timer.Stop());
                MessageBox.Show("游戏结束");
                label2.Text = "0";
                panel1.Controls.Clear();
                list.Clear();

            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                score = 0;
                label2.Text = "0";
                Golbaltimer.Start();
                ispause= false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!ispause)
            {
                ispause = true;
                Golbaltimer.Stop();
                foreach (var item in list)
                {
                    item.timer.Stop();
                }
                button2.Text = "游戏继续";
            }
            else 
            { 
                ispause= false;
                Golbaltimer.Start();
                foreach (var item in list)
                {
                    item.timer.Start();
                
                }
                button2.Text = "暂停游戏";
            }

        }
    }


    public class Labelandtimer
    {
       public Label lab { get; set; }
        public System.Windows.Forms.Timer timer { get; set; }
        public Labelandtimer(Label la,System .Windows.Forms.Timer tm)
        { 
            lab = la;
            timer= tm;
        
        }
    
    
    
    }
}
