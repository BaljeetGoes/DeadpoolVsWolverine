using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        SoundPlayer cansion;
        SoundPlayer getready;
        int countdownValue = 4;
        int vidaDeadpool = 1000, vidaWolverine = 1000;
        Random rnd = new Random();
        string jugadorInicial = "";
        int turno = 0;
        bool combateIniciado = false;
        bool deadpoolMareado = false;
        bool wolverineMareado = false;
        int ultimoDañoADeadpool = 0;
        int ultimoDañoAWolverine = 0;

        public Form2()
        {
            InitializeComponent();
            getready = new SoundPlayer(@"C:/Users/Wande/Downloads/proyectos/Deadpool vs Wolverine/imagenes/noempe.wav");
            getready.PlayLooping();
            btnPelea.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            int n = rnd.Next(1, 11);

            if (n % 2 == 0)
            {
                jugadorInicial = "Wolverine";
                MessageBox.Show("Wolverine empieza");
            }
            else
            {
                jugadorInicial = "Deadpool";
                MessageBox.Show("Deadpool empieza");
            }

            btnComenzar.Visible = false;

            combateIniciado = true;
            turno = 0;

            countdownValue = 4;
            lblCountdown.Text = "";
            timerCountdown.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timerCountdown_Tick(object sender, EventArgs e)
        {
            countdownValue--;

            switch (countdownValue)
            {
                case 3:
                    lblCountdown.Text = "3";
                    break;
                case 2:
                    lblCountdown.Text = "2";
                    break;
                case 1:
                    lblCountdown.Text = "1";
                    break;
                case 0:
                    lblPelea.Text = "¡PELEEN!";
                    lblCountdown.Text = " ";
                    break;
                case -1:
                    getready.Stop();
                    lblPelea.Text = " ";
                    timerCountdown.Stop();
                    cansion = new SoundPlayer(@"C:/Users/Wande/Downloads/proyectos/Deadpool vs Wolverine/imagenes/tema.wav");
                    cansion.PlayLooping();
                    btnPelea.Visible = true;

                    break;
            }
        }

        void CambiarSprite(string personaje, string accion)
        {
            if (personaje == "Deadpool")
            {
                switch (accion)
                {
                    case "idle": pictureBox1.Image = Image.FromFile("C:/Users/Wande/Downloads/proyectos/Deadpool vs Wolverine/imagenes/deadpool sprites/stand.gif"); break;
                    case "atacar": pictureBox1.Image = Image.FromFile("C:/Users/Wande/Downloads/proyectos/Deadpool vs Wolverine/imagenes/deadpool sprites/shoot.gif"); break;
                    case "dodge": pictureBox1.Image = Image.FromFile("C:/Users/Wande/Downloads/proyectos/Deadpool vs Wolverine/imagenes/deadpool sprites/dodge.gif"); break;
                    case "dizzy": pictureBox1.Image = Image.FromFile("C:/Users/Wande/Downloads/proyectos/Deadpool vs Wolverine/imagenes/deadpool sprites/dizzy.gif"); break;
                    case "win": pictureBox1.Image = Image.FromFile("C:/Users/Wande/Downloads/proyectos/Deadpool vs Wolverine/imagenes/deadpool sprites/win.gif"); break;
                    case "lose": pictureBox1.Image = Image.FromFile("C:/Users/Wande/Downloads/proyectos/Deadpool vs Wolverine/imagenes/deadpool sprites/lose.gif"); break;
                }
            }
            else
            {
                switch (accion)
                {
                    case "idle": pictureBox2.Image = Image.FromFile("C:/Users/Wande/Downloads/proyectos/Deadpool vs Wolverine/imagenes/wolverine sprites/stand.gif"); break;
                    case "atacar": pictureBox2.Image = Image.FromFile("C:/Users/Wande/Downloads/proyectos/Deadpool vs Wolverine/imagenes/wolverine sprites/punch.gif"); break;
                    case "dodge": pictureBox2.Image = Image.FromFile("C:/Users/Wande/Downloads/proyectos/Deadpool vs Wolverine/imagenes/wolverine sprites/dodge.gif"); break;
                    case "dizzy": pictureBox2.Image = Image.FromFile("C:/Users/Wande/Downloads/proyectos/Deadpool vs Wolverine/imagenes/wolverine sprites/dizzy.gif"); break;
                    case "win": pictureBox2.Image = Image.FromFile("C:/Users/Wande/Downloads/proyectos/Deadpool vs Wolverine/imagenes/wolverine sprites/win.gif"); break;
                    case "lose": pictureBox2.Image = Image.FromFile("C:/Users/Wande/Downloads/proyectos/Deadpool vs Wolverine/imagenes/wolverine sprites/lose.gif"); break;
                }
            }
        }


        private void SimularTurno()
        {
            if (!combateIniciado || vidaDeadpool <= 0 || vidaWolverine <= 0)
                return;

            string actual;
            if (jugadorInicial == "Deadpool")
                actual = (turno % 2 == 0) ? "Deadpool" : "Wolverine";
            else
                actual = (turno % 2 == 0) ? "Wolverine" : "Deadpool";

            CambiarSprite("Deadpool", "idle");
            CambiarSprite("Wolverine", "idle");

            if (actual == "Deadpool" && turno > 0)
            {
                int regen = (int)(ultimoDañoADeadpool * 0.05);
                vidaDeadpool += regen;
            }
            else if (actual == "Wolverine" && turno > 0)
            {
                int regen = (int)(ultimoDañoAWolverine * 0.05);
                vidaWolverine += regen;
            }

            if (actual == "Deadpool" && deadpoolMareado)
            {
                CambiarSprite("Deadpool", "dizzy"); 
                int cura = (int)(ultimoDañoADeadpool * 0.10);
                vidaDeadpool += cura;
                lblDaño.Text = "Deadpool está mareado y se recupera +" + cura;
                deadpoolMareado = false;
            }
            else if (actual == "Wolverine" && wolverineMareado)
            {
                CambiarSprite("Wolverine", "dizzy");
                int cura = (int)(ultimoDañoAWolverine * 0.10);
                vidaWolverine += cura;
                lblDaño.Text = "Wolverine está mareado y se recupera +" + cura;
                wolverineMareado = false;
            }
            else
            {
                bool evade = false;
                string oponente = (actual == "Deadpool") ? "Wolverine" : "Deadpool";

                if (actual == "Deadpool")
                    evade = new Random().Next(100) < 20;
                else
                    evade = new Random().Next(100) < 25;

                if (evade)
                {
                    CambiarSprite(actual, "atacar");
                    CambiarSprite((actual == "Deadpool") ? "Wolverine" : "Deadpool", "dodge");
                    lblDaño.Text = (actual == "Deadpool" ? "Wolverine" : "Deadpool") + " esquiva el ataque!";
                }
                else
                {
                    int daño = (actual == "Deadpool") ? rnd.Next(10, 101) : rnd.Next(10, 121);
                    CambiarSprite(actual, "atacar");

                    if (actual == "Deadpool")
                    {
                        vidaWolverine -= daño;
                        ultimoDañoAWolverine = daño;
                        if (daño >= 80) wolverineMareado = true;
                    }
                    else
                    {
                        vidaDeadpool -= daño;
                        ultimoDañoADeadpool = daño;
                        if (daño >= 100) deadpoolMareado = true;
                    }

                    lblDaño.Text = $"{actual} ataca con {daño} de daño";
                }
            }

            vidaDeadpool = Math.Clamp(vidaDeadpool, 0, 1000);
            vidaWolverine = Math.Clamp(vidaWolverine, 0, 1000);

            lifebarDeadpool.Value = vidaDeadpool;
            lifebarWolverine.Value = vidaWolverine;
            lblVidaD.Text = vidaDeadpool.ToString();
            lblVidaW.Text = vidaWolverine.ToString();

            if (vidaDeadpool <= 0)
            {
                lblPelea.Text = "¡Wolverine gana!";
                lblDaño.Text = " ";
                CambiarSprite("Deadpool", "lose");
                CambiarSprite("Wolverine", "win");
            }
            else if (vidaWolverine <= 0)
            {
                lblPelea.Text = "¡Deadpool gana!";
                lblDaño.Text = " ";
                CambiarSprite("Wolverine", "lose");
                CambiarSprite("Deadpool", "win");
            }

            turno++;

        }

        private void btnPelea_Click(object sender, EventArgs e)
        {
            SimularTurno();
        }


    }
}
