namespace TwoCars
{
    public partial class Form1 : Form
    {
        private readonly Random random = new Random();
        private int score = 0;
        private int obsSpeed = 6;
        private int Car_L_Target = 134;
        private int Car_R_Target = 246;
        private int step = 45;
        private int minDistance = 100; // Distância mínima entre os objetos

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            score = 0;
            obsSpeed = 6;
            Car_L_Target = 134;
            Car_R_Target = 246;
            labelScore.Text = "Score: 0";
            ReposicaoObs_L(picPoint_L);
            ReposicaoObs_R(picPoint_R);
            ReposicaoObs_L(picObs_L);
            ReposicaoObs_R(picObs_R);
            timer1.Start();
        }

        public void CheckSobreposicao()
        {
            if (Math.Abs(picObs_L.Top - picPoint_L.Top) < minDistance)
            {
                ReposicaoObs_L(picPoint_L);
            }
            if (Math.Abs(picObs_R.Top - picPoint_R.Top) < minDistance)
            {
                ReposicaoObs_R(picPoint_R);
            }
        }

        private void ReposicaoObs_L(PictureBox obj)
        {
            obj.Top = random.Next(-500, -100);
            //obj.Left = 31;
            var n = random.Next(100);
            if (n < 50)
            {
                obj.Left = 31;
            }
            else
            {
                obj.Left = 140;
            }
        }

        private void ReposicaoObs_R(PictureBox obj)
        {
            obj.Top = random.Next(-500, -100);
            //obj.Left = 360;
            var n = random.Next(100);
            if (n < 50)
            {
                obj.Left = 253;
            }
            else
            {
                obj.Left = 360;
            }
        }

        private void Ponto()
        {
            score++;
            labelScore.Text = $"Score: {score.ToString()}";
            if (score % 10 == 0) { obsSpeed++; }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Movimenta obstaculos para baixo
            MovePicDown();

            // Mover carro Suavemente
            MovePlayerCar(Car_L, Car_L_Target);
            MovePlayerCar(Car_R, Car_R_Target);
        }

        private void MovePicDown()
        {
            CheckSobreposicao();
            picPoint_L.Top += obsSpeed;
            picPoint_R.Top += obsSpeed;
            picObs_L.Top += obsSpeed;
            picObs_R.Top += obsSpeed;

            // Left
            if (picPoint_L.Bounds.IntersectsWith(Car_L.Bounds))
            {
                Ponto();
                ReposicaoObs_L(picPoint_L);
            }
            if (picObs_L.Top > Car_R.Top + 100) // (Car_R.Top + 100) Representa que passou para trás do carro
            {
                ReposicaoObs_L(picObs_L);
            }
            if (picObs_L.Bounds.IntersectsWith(Car_L.Bounds) || picPoint_L.Top > Car_R.Top + 100)
            {
                endGame();
            }

            // Right
            if (picPoint_R.Bounds.IntersectsWith(Car_R.Bounds))
            {
                Ponto();
                ReposicaoObs_R(picPoint_R);
            }
            if (picObs_R.Top > Car_R.Top + 100)
            {
                ReposicaoObs_R(picObs_R);
            }
            if (picObs_R.Bounds.IntersectsWith(Car_R.Bounds) || picPoint_R.Top > Car_R.Top + 100)
            {
                endGame();
            }
        }

        private void endGame()
        {
            timer1.Stop();
            MessageBox.Show("Perdeu!");
            InitializeGame();
        }

        private void MovePlayerCar(PictureBox car, int target)
        {
            int difference = target - car.Left;

            if (Math.Abs(difference) >= step)
            {
                car.Left += (difference > 0) ? step : -step;
            }
            else
            {
                car.Left = target;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Carro Esquerdo
            if (e.KeyChar == 'A' || e.KeyChar == 'a')
            {
                Car_L_Target = 25;
            }
            if (e.KeyChar == 'S' || e.KeyChar == 's')
            {
                Car_L_Target = 134;
            }

            // Carro Direito
            if (e.KeyChar == 'D' || e.KeyChar == 'd')
            {
                Car_R_Target = 246;
            }
            if (e.KeyChar == 'F' || e.KeyChar == 'f')
            {
                Car_R_Target = 353;
            }
        }
    }
}
