using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp14
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer=new();
        public Random rand=new Random();
        public int high = 0;
        private Label lab;
        public Form1()
        {
            InitializeComponent();
            timer.Tick += timer_Tick;
            this.KeyUp += Form1_KeyUp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //游戏开始创建label
            Createlabel();
            //创建定时器
            timer.Interval = 10;
            //timer.Tick-=timer_Tick;//防止重复绑定事件
           // timer.Tick += timer_Tick;
            timer.Start();
            this.KeyPreview = true;//让窗体可以接收键盘事件获取光标
            this.ActiveControl = null;//失去光标
            //this.KeyUp -= Form1_KeyUp;
            //this.KeyUp += Form1_KeyUp;

        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //e.KeyCode获取点击键盘的键
            //判断label的text是否和按下的键相等
            //相等删除
            if (!Enum.TryParse(lab.Text, true, out Keys k)) return;
            if (k == e.KeyCode)
            {
                panel1.Controls.Remove(lab);
               Createlabel();  //结束后再开始时创建 
            }

        }
        private void timer_Tick(object sender, EventArgs e)
        {
            //让label下落
            high += 2;
            lab.Top= high;
            if (lab.Top >= panel1.Height - 30)
            {
                timer.Stop();
                MessageBox.Show("游戏结束");
                //timer.Stop();
                panel1.Controls.Clear();

            }
        


        }
        public void Createlabel()
        {
            high = 0;
            string arr = "QWERTYUIOPASDFGHJKLZXCVBNM";
           lab= new Label();
            lab.Text = arr[rand.Next(arr.Length)].ToString();
            lab.Size = new Size(30, 30);
            lab.Font = new Font("微软雅黑", 12, FontStyle.Bold);
            lab.Location = new Point(rand.Next(panel1.Width-30), 0);
            lab.TextAlign = ContentAlignment.MiddleCenter;
            panel1.Controls.Add(lab);
        }
    }
}
