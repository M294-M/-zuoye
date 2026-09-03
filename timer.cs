namespace WinFormsApp11
    
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000; 
            timer1.Start();
            timer1.Tick += timer1_Tick;

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            DateTime gqtime = new DateTime(dt.Year, 10, 1, 0, 0, 0);
            TimeSpan ts = gqtime - dt;
            label1.Text = $"距离国庆还有：{ts.Days}天 {ts.Hours}小时 {ts.Minutes}分钟 {ts.Seconds}秒";

        }
    }
}
