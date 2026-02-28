namespace Joc
{
    public partial class Form1 : Form
    {
        private const int LATURA_ELEMENT = 100;
        private readonly Bitmap IMG_SOSEA;
        private readonly Bitmap IMG_BALOT;
        private readonly Bitmap IMG_MASINA;

        private Bitmap bmp = new Bitmap(400, 600);
        private Graphics canvas;

        private int coloanaMasina = 1;

        private int[,] obstacole = new int[6,4];
        private Random random = new Random();
        private int factorDeIntarziereBalot;
        private int intarziereCurentaBalot;


        public Form1()
        {        
            InitializeComponent();

            IMG_SOSEA = new Bitmap("img\\sosea.png");
            IMG_BALOT = new Bitmap("img\\balot.png");
            IMG_MASINA = new Bitmap("img\\masinuta.png");
            canvas = Graphics.FromImage(bmp);
            for (int i = 0; i < obstacole.GetLength(0); i++)
            {
                for (int j = 0; j < obstacole.GetLength(1); j++)
                {
                    obstacole[i, j] = 0;
                }
            }

            factorDeIntarziereBalot = 15;
            intarziereCurentaBalot = 0;
        }

        private void tmDraw_Tick(object sender, EventArgs e)
        {
            canvas.DrawImage(IMG_SOSEA, 0, 0);

            intarziereCurentaBalot+=3;

            if (intarziereCurentaBalot >= factorDeIntarziereBalot)
            {

                for (int i = obstacole.GetLength(0) - 1; i > 0; i--)
                {
                    for (int j = 0; j < obstacole.GetLength(1); j++)
                    {
                        obstacole[i, j] = obstacole[i - 1, j];
                    }
                }

                for (int j = 0; j < obstacole.GetLength(1); j++)
                {
                    obstacole[0, j] = generateBalot() ? 1 : 0;
                }

                intarziereCurentaBalot = 0;
            }

            for (int i = 0; i < obstacole.GetLength(0); i++)
            {
                for (int j = 0; j < obstacole.GetLength(1); j++)
                {
                    if (obstacole[i, j] == 1)
                    {
                        canvas.DrawImage(
                                IMG_BALOT,
                                j * LATURA_ELEMENT + 20,
                                i * LATURA_ELEMENT + 20);
                    }
                }
            }

            canvas.DrawImage(
                IMG_MASINA,
                coloanaMasina * LATURA_ELEMENT + (LATURA_ELEMENT - IMG_MASINA.Width) / 2,
                4 * LATURA_ELEMENT);

            pictureBox1.Image = bmp;

            if (obstacole[4, coloanaMasina] == 1)
            {
                tmDraw.Enabled = false;
                MessageBox.Show("CAR CRASH!!!!!");
            }
        }

        private bool generateBalot()
        {
            int rnd = random.Next();
            return rnd % 7 == 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                coloanaMasina = coloanaMasina < 3 ? coloanaMasina + 1 : coloanaMasina;
            }

            if (e.KeyCode == Keys.Left)
            {
                coloanaMasina = coloanaMasina > 0 ? coloanaMasina - 1 : coloanaMasina;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Focus();
        }
    }
}
