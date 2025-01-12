using System;
using System.Media;
using System.Windows.Forms;

namespace CS_Piano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        private void PlaySound(string filePath)
        {
            try
            {
                SoundPlayer sp = new SoundPlayer(filePath);
                sp.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    PlaySound(@"C:\\Users\\Mas Borrr\\source\\repos\\CS_Piano\\CS_Piano\\Resources\\C.wav");
                    break;
                case Keys.S:
                    PlaySound(@"C:\\Users\\Mas Borrr\\source\\repos\\CS_Piano\\CS_Piano\\Resources\\D.wav");
                    break;
                case Keys.D:
                    PlaySound(@"C:\\Users\\Mas Borrr\\source\\repos\\CS_Piano\\CS_Piano\\Resources\\E.wav");
                    break;
                case Keys.F:
                    PlaySound(@"C:\\Users\\Mas Borrr\\source\\repos\\CS_Piano\\CS_Piano\\Resources\\F.wav");
                    break;
                case Keys.G:
                    PlaySound(@"C:\\Users\\Mas Borrr\\source\\repos\\CS_Piano\\CS_Piano\\Resources\\G.wav");
                    break;
                case Keys.H:
                    PlaySound(@"C:\\Users\\Mas Borrr\\source\\repos\\CS_Piano\\CS_Piano\\Resources\\A.wav");
                    break;
                case Keys.J:
                    PlaySound(@"C:\\Users\\Mas Borrr\\source\\repos\\CS_Piano\\CS_Piano\\Resources\\B.wav");
                    break;
                case Keys.K:
                    PlaySound(@"C:\\Users\\Mas Borrr\\source\\repos\\CS_Piano\\CS_Piano\\Resources\\C1.wav");
                    break;
                case Keys.L:
                    PlaySound(@"C:\\Users\\Mas Borrr\\source\\repos\\CS_Piano\\CS_Piano\\Resources\\D1.wav");
                    break;
                case Keys.O:
                    PlaySound(@"C:\\Users\\Mas Borrr\\source\\repos\\CS_Piano\\CS_Piano\\Resources\\E1.wav");
                    break;
                case Keys.P:
                    PlaySound(@"C:\\Users\\Mas Borrr\\source\\repos\\CS_Piano\\CS_Piano\\Resources\\F1.wav");
                    break;
                case Keys.Q:
                    PlaySound(@"C:\\Users\\Mas Borrr\\source\\repos\\CS_Piano\\CS_Piano\\Resources\\C_s.wav");
                    break;
                case Keys.W:
                    PlaySound(@"C:\\Users\\Mas Borrr\\source\\repos\\CS_Piano\\CS_Piano\\Resources\\D_s.wav");
                    break;
                case Keys.E:
                    PlaySound(@"C:\\Users\\Mas Borrr\\source\\repos\\CS_Piano\\CS_Piano\\Resources\\F_s.wav");
                    break;
                case Keys.R:
                    PlaySound(@"C:\\Users\\Mas Borrr\\source\\repos\\CS_Piano\\CS_Piano\\Resources\\G_s.wav");
                    break;
                case Keys.T:
                    PlaySound(@"C:\\Users\\Mas Borrr\\source\\repos\\CS_Piano\\CS_Piano\\Resources\\Bb.wav");
                    break;
                case Keys.Y:
                    PlaySound(@"C:\\Users\\Mas Borrr\\source\\repos\\CS_Piano\\CS_Piano\\Resources\\C_s1.wav");
                    break;
                case Keys.U:
                    PlaySound(@"C:\\Users\\Mas Borrr\\source\\repos\\CS_Piano\\CS_Piano\\Resources\\D_s1.wav");
                    break;
                default:
                    break;
            }
        }

        // Event untuk tombol mouse piano
        private void btnMusicNoteC_Click(object sender, EventArgs e) => PlaySound(@"C:\\Users\\Mas Borrr\\source\\repos\\CS_Piano\\CS_Piano\\Resources\\C.wav");
        private void btnMusicNoteD_Click(object sender, EventArgs e) => PlaySound(@"C:\\Users\\Mas Borrr\\source\\repos\\CS_Piano\\CS_Piano\\Resources\\D.wav");
        private void btnMusicNoteE_Click(object sender, EventArgs e) => PlaySound(@"C:\\Users\\Mas Borrr\\source\\repos\\CS_Piano\\CS_Piano\\Resources\\E.wav");
        private void btnMusicNoteF_Click(object sender, EventArgs e) => PlaySound(@"C:\\Users\\Mas Borrr\\source\\repos\\CS_Piano\\CS_Piano\\Resources\\F.wav");
        private void btnMusicNoteG_Click(object sender, EventArgs e) => PlaySound(@"C:\\Users\\Mas Borrr\\source\\repos\\CS_Piano\\CS_Piano\\Resources\\G.wav");
        private void btnMusicNoteA_Click(object sender, EventArgs e) => PlaySound(@"C:\\Users\\Mas Borrr\\source\\repos\\CS_Piano\\CS_Piano\\Resources\\A.wav");
        private void btnMusicNoteB_Click(object sender, EventArgs e) => PlaySound(@"C:\\Users\\Mas Borrr\\source\\repos\\CS_Piano\\CS_Piano\\Resources\\B.wav");
        private void btnMusicNoteC1_Click(object sender, EventArgs e) => PlaySound(@"C:\\Users\\Mas Borrr\\source\\repos\\CS_Piano\\CS_Piano\\Resources\\C1.wav");
        private void btnMusicNoteD1_Click(object sender, EventArgs e) => PlaySound(@"C:\\Users\\Mas Borrr\\source\\repos\\CS_Piano\\CS_Piano\\Resources\\D1.wav");
        private void btnMusicNoteE1_Click(object sender, EventArgs e) => PlaySound(@"C:\\Users\\Mas Borrr\\source\\repos\\CS_Piano\\CS_Piano\\Resources\\E1.wav");
        private void btnMusicNoteF1_Click(object sender, EventArgs e) => PlaySound(@"C:\\Users\\Mas Borrr\\source\\repos\\CS_Piano\\CS_Piano\\Resources\\F1.wav");
        private void btnMusicNoteCS_Click(object sender, EventArgs e) => PlaySound(@"C:\\Users\\Mas Borrr\\source\\repos\\CS_Piano\\CS_Piano\\Resources\\C_s.wav");
        private void btnMusicNoteDS_Click(object sender, EventArgs e) => PlaySound(@"C:\\Users\\Mas Borrr\\source\\repos\\CS_Piano\\CS_Piano\\Resources\\D_s.wav");
        private void btnMusicNoteFS_Click(object sender, EventArgs e) => PlaySound(@"C:\\Users\\Mas Borrr\\source\\repos\\CS_Piano\\CS_Piano\\Resources\\F_s.wav");
        private void btnMusicNoteGS_Click(object sender, EventArgs e) => PlaySound(@"C:\\Users\\Mas Borrr\\source\\repos\\CS_Piano\\CS_Piano\\Resources\\G_s.wav");
        private void btnMusicNoteBB_Click(object sender, EventArgs e) => PlaySound(@"C:\\Users\\Mas Borrr\\source\\repos\\CS_Piano\\CS_Piano\\Resources\\Bb.wav");
        private void btnMusicNoteCS1_Click(object sender, EventArgs e) => PlaySound(@"C:\\Users\\Mas Borrr\\source\\repos\\CS_Piano\\CS_Piano\\Resources\\C_s1.wav");
        private void btnMusicNoteDS1_Click(object sender, EventArgs e) => PlaySound(@"C:\\Users\\Mas Borrr\\source\\repos\\CS_Piano\\CS_Piano\\Resources\\D_s1.wav");
        private void btnMusicNoteFS1_Click(object sender, EventArgs e) => PlaySound(@"C:\\Users\\Mas Borrr\\source\\repos\\CS_Piano\\CS_Piano\\Resources\\F_s1.wav");
        private void btnMusicNoteG1_Click(object sender, EventArgs e) => PlaySound(@"C:\\Users\\Mas Borrr\\source\\repos\\CS_Piano\\CS_Piano\\Resources\\G1.wav");
        private void btnMusicNoteA1_Click(object sender, EventArgs e) => PlaySound(@"C:\\Users\\Mas Borrr\\source\\repos\\CS_Piano\\CS_Piano\\Resources\\A1.wav");
        private void btnMusicNoteGS1_Click(object sender, EventArgs e) => PlaySound(@"C:\\Users\\Mas Borrr\\source\\repos\\CS_Piano\\CS_Piano\\Resources\\G_s1.wav");
        private void btnMusicNoteB1_Click(object sender, EventArgs e) => PlaySound(@"C:\\Users\\Mas Borrr\\source\\repos\\CS_Piano\\CS_Piano\\Resources\\B1.wav");
        private void btnMusicNoteAS1_Click(object sender, EventArgs e) => PlaySound(@"C:\\Users\\Mas Borrr\\source\\repos\\CS_Piano\\CS_Piano\\Resources\\A_s1.wav");


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
