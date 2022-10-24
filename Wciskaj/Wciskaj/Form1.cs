namespace Wciskaj
{
    public partial class Form1 : Form
    {
        readonly Random c;
        int punkty;
        public Form1()
        {
            InitializeComponent();
            c = new Random();
            punkty = 0;
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            punkty++;
            label1.Text = "Punkty: " + punkty.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int maxX = this.Size.Width - button1.Size.Width - 50;
            int maxY = this.Size.Height - button1.Size.Height - 50;
            Point p = new Point();
            p.X = c.Next(12, maxX);
            p.Y = c.Next(12, maxY);
            button1.Location = p;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}