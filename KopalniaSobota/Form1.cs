namespace KopalniaSobota
{
    public partial class Form1 : Form
    {
        Blade Blade = new Blade();
        double points=0;
        public Form1()
        {
            InitializeComponent();
            pictureBox2.Load("https://raw.githubusercontent.com/bartex100/Mine-Clicker/main/blades/wooden.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            points+=Blade.punkty;
            label1.Text = Math.Round(points,1).ToString() + "$";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Blade.cena < points)
            {
                points -=Blade.cena;
                label1.Text = Math.Round(points).ToString() + "$";
                Blade.upBladeLevel();
                button2.Text = "Ulepszenie ostrza:\r\n" + Blade.nazwa + "\r\n"+Math.Round(Blade.cena)+"$";
            }
        }
    }
}