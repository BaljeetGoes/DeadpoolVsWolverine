using System.Media;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        SoundPlayer sound;

        public Form1()
        {
            InitializeComponent();
            sound = new SoundPlayer(@"C:\Users\Wande\Downloads\proyectos\Deadpool vs Wolverine\imagenes\theme.wav");
            sound.PlayLooping();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            sound.Stop();
            Form2 nuevoForm = new Form2();
            nuevoForm.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (pictureBox4.Image != null)
                pictureBox4.Image = null; 
            else
                pictureBox4.Image = Image.FromFile("C:/Users/Wande/Downloads/proyectos/Deadpool vs Wolverine/imagenes/press.png");

        }
    }
}
