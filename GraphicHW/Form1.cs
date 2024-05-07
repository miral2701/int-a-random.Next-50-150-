namespace GraphicHW
{
    public partial class Form1 : Form
    {
        Point p;
        Graphics g;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            p.X = e.X;
            p.Y = e.Y;
            Random random= new Random();    
            int a=random.Next(50,150);
            int b = random.Next(50, 150);


            int R = random.Next(0, 255);
            int G = random.Next(0, 255);
            int B = random.Next(0, 255);

            Brush brush = new SolidBrush(Color.FromArgb(255,R, G, B));
            g.FillEllipse(brush, p.X, p.Y, a, b);
        }

       
    }
}