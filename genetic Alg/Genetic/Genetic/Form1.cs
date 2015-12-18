using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Genetic
{
    public partial class Form1 : Form
    {
        Point[] location = new Point[100];//le max de point = 100
        int[,] gene = new int[100,6];
        int nbPoint = 0;
        bool startChemin;
        Random random = new Random();
        int[] longueur = new int[6];
        int pluspetitIndex = 0;
        int pluspetitIndex2 = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int i;
            int choixGene = 0;

            if (rbGene0.Checked) choixGene = 0;
            if (rbGene1.Checked) choixGene = 1;
            if (rbGene2.Checked) choixGene = 2;
            if (rbGene3.Checked) choixGene = 3;
            if (rbGene4.Checked) choixGene = 4;
            if (rbGene5.Checked) choixGene = 5;

            if (startChemin)
            {
                for (i = 0; i < nbPoint - 1; i++)
                {
                    e.Graphics.DrawLine(new Pen(Color.Red, 2f), new Point(location[gene[i, choixGene]].X, location[gene[i, choixGene]].Y), new Point(location[gene[i + 1, choixGene]].X, location[gene[i + 1, choixGene]].Y));
                }
            }

            for (i = 0; i < nbPoint; i++)
            {
                using (Font myFont = new Font("Arial", 14))
                {
                    e.Graphics.DrawEllipse(new Pen(Color.Black, 2f), location[i].X, location[i].Y, 3, 3);
                    e.Graphics.DrawString(i.ToString(), myFont, Brushes.Green, new Point(location[i].X, location[i].Y));
                }
            }
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            location[nbPoint].X = e.X;
            location[nbPoint].Y = e.Y;
            nbPoint++;
            pictureBox1.Refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            afficher();
            afficherADN();
        }
        static public int Distance(int x1, int y1, int x2, int y2)
        {
            int result;

            result = Convert.ToInt32(Math.Sqrt((y2 - y1) * (y2 - y1) + (x2 - x1) * (x2 - x1)));

            return result;
        }
        void shuffle(int choix)
        {
            //Fisher-Yates Shuffle Modern Algorithm
            //https://www.youtube.com/watch?v=tLxBwSL3lPQ
            int i;
            int temp;
            int randomNumber;

            for (i = nbPoint-1 ; i > 1; i--)
            {
                randomNumber = random.Next(0, i-1);
                temp = gene[randomNumber, choix];
                gene[randomNumber, choix] = gene[i, choix];
                gene[i, choix] = temp;
            }
        }
        private void rbGene0_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }
        private void rbGene1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }
        private void rbGene2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }
        private void rbGene3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }
        private void rbGene4_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }
        private void rbGene5_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            selection();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            croisement();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            randomGene();
        }
        void afficherADN()
        {
            int i;
            int choixGene = 0;
            label7.Text = "";

            if (rbGene0.Checked) choixGene = 0;
            if (rbGene1.Checked) choixGene = 1;
            if (rbGene2.Checked) choixGene = 2;
            if (rbGene3.Checked) choixGene = 3;
            if (rbGene4.Checked) choixGene = 4;
            if (rbGene5.Checked) choixGene = 5;

            for (i = 0; i < nbPoint; i++)
            {
                label7.Text = label7.Text + gene[i, choixGene].ToString() + " - ";
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            afficherADN();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            mutation();
        }
        void mutation()
        {
            int i,j;
            int aleatoireIndex1;
            int aleatoireIndex2;
            int temp;

            for (j = 1; j < 3; j++){  //nb de mutation
                for (i = 1; i < 6; i++){
                    aleatoireIndex1 = random.Next(0, nbPoint - 1);
                    aleatoireIndex2 = random.Next(0, nbPoint - 1);
                    temp = gene[aleatoireIndex1, i];
                    gene[aleatoireIndex1, i] = gene[aleatoireIndex2, i];
                    gene[aleatoireIndex2, i] = temp;
                }
            }
        }
        void randomGene()
        {
            int i;

            for (i = 0; i < nbPoint; i++)
            {
                gene[i, 0] = i;
                gene[i, 1] = i;
                gene[i, 2] = i;
                gene[i, 3] = i;
                gene[i, 4] = i;
                gene[i, 5] = i;
            }

            shuffle(0);//shuffle le tableau
            shuffle(1);
            shuffle(2);
            shuffle(3);
            shuffle(4);
            shuffle(5);
        }
        void croisement()
        {
            int i, j, k;
            int[] mother = new int[100];
            int[] father = new int[100];
            int separation1, separation2;
            int temp;

            for (i = 0; i < nbPoint; i++)
            {
                mother[i] = gene[i, pluspetitIndex];
                father[i] = gene[i, pluspetitIndex2];
            }

            for (i = 0; i < nbPoint; i++)
            {
                gene[i, 0] = mother[i];
                gene[i, 1] = father[i];
                gene[i, 2] = mother[i];
                gene[i, 3] = mother[i];
                gene[i, 4] = mother[i];
                gene[i, 5] = mother[i];
            }

            for (j = 2; j < 6; j++)
            {
                separation1 = random.Next(0, nbPoint-1);
                separation2 = random.Next(separation1+1, nbPoint-1);

                for (i = separation1; i < separation2; i++)
                {
                    temp = gene[i,j];
                    for (k = 0; k < nbPoint; k++)
                    {
                        if (gene[k, j] == father[i]) gene[k,j] = temp;
                    }
                    gene[i, j] = father[i];
                }
            }
        }
        void selection()
        {
            int i;
            int pluspetit = 999999999;
            int pluspetit2 = 999999999;

            for (i = 0; i < 6; i++)
            {
                if (pluspetit > longueur[i])
                {
                    pluspetit = longueur[i];
                    pluspetitIndex = i;
                }
            }
            for (i = 0; i < 6; i++)
            {
                if (pluspetit2 > longueur[i] && longueur[i] != pluspetit)
                {
                    pluspetit2 = longueur[i];
                    pluspetitIndex2 = i;
                }
            }

            if (pluspetitIndex == 0 || pluspetitIndex2 == 0) LbDistance0.Font = new Font(LbDistance0.Font.FontFamily, LbDistance0.Font.Size, FontStyle.Bold);
            if (pluspetitIndex == 1 || pluspetitIndex2 == 1) LbDistance1.Font = new Font(LbDistance1.Font.FontFamily, LbDistance1.Font.Size, FontStyle.Bold);
            if (pluspetitIndex == 2 || pluspetitIndex2 == 2) LbDistance2.Font = new Font(LbDistance2.Font.FontFamily, LbDistance2.Font.Size, FontStyle.Bold);
            if (pluspetitIndex == 3 || pluspetitIndex2 == 3) LbDistance3.Font = new Font(LbDistance3.Font.FontFamily, LbDistance3.Font.Size, FontStyle.Bold);
            if (pluspetitIndex == 4 || pluspetitIndex2 == 4) LbDistance4.Font = new Font(LbDistance4.Font.FontFamily, LbDistance4.Font.Size, FontStyle.Bold);
            if (pluspetitIndex == 5 || pluspetitIndex2 == 5) LbDistance5.Font = new Font(LbDistance5.Font.FontFamily, LbDistance5.Font.Size, FontStyle.Bold);
        }
        void afficher()
        {
            int i, j;

            for (j = 0; j < 6; j++)
            {
                longueur[j] = 0;
            }

            startChemin = true;

            pictureBox1.Refresh();

            LbDistance0.Font = new Font(LbDistance0.Font.FontFamily, LbDistance0.Font.Size);
            LbDistance1.Font = new Font(LbDistance1.Font.FontFamily, LbDistance1.Font.Size);
            LbDistance2.Font = new Font(LbDistance2.Font.FontFamily, LbDistance2.Font.Size);
            LbDistance3.Font = new Font(LbDistance3.Font.FontFamily, LbDistance3.Font.Size);
            LbDistance4.Font = new Font(LbDistance4.Font.FontFamily, LbDistance4.Font.Size);
            LbDistance5.Font = new Font(LbDistance5.Font.FontFamily, LbDistance5.Font.Size);

            for (j = 0; j < 6; j++)
            {
                for (i = 0; i < nbPoint - 1; i++)
                {
                    longueur[j] = longueur[j] + Distance(location[gene[i, j]].X, location[gene[i, j]].Y, location[gene[i + 1, j]].X, location[gene[i + 1, j]].Y);

                }
            }

            LbDistance0.Text = longueur[0].ToString();
            LbDistance1.Text = longueur[1].ToString();
            LbDistance2.Text = longueur[2].ToString();
            LbDistance3.Text = longueur[3].ToString();
            LbDistance4.Text = longueur[4].ToString();
            LbDistance5.Text = longueur[5].ToString();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            afficher();
            afficherADN();
            selection();
            croisement();
            mutation();
        }
    }
}