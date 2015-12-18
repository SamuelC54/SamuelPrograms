using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QIK_v1
{
    public partial class Form1 : Form
    {
        int clickIndex = 1;
        int[] adnSelect = new int[4];
        Color[] adn = new Color[4];
        Color goal;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        void randomize()
        {
            goal = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
            adn[0] = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
            adn[1] = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
            adn[2] = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
            adn[3] = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
        }
        void afficher()
        {
            pic_goal.BackColor = goal;
            pic_choix1.BackColor = adn[0];
            pic_choix2.BackColor = adn[1];
            pic_choix3.BackColor = adn[2];
            pic_choix4.BackColor = adn[3];
        }
        void initialisation()
        {
            randomize();
            afficher();
            calculScore();
            lb_mutation.Text = tb_mutation.Value.ToString();
        }

        private void but_reset_Click(object sender, EventArgs e)
        {
            initialisation();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initialisation();
        }

        string right(string sValue, int iMaxLength)
        {
            //Check if the value is valid
            if (string.IsNullOrEmpty(sValue))
            {
                //Set valid empty string as string could be null
                sValue = string.Empty;
            }
            else if (sValue.Length > iMaxLength)
            {
                //Make the string no longer than the max length
                sValue = sValue.Substring(sValue.Length - iMaxLength, iMaxLength);
            }

            //Return the string
            return sValue;
        }
       
        private void Button_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;

            if(clickIndex == 1)
            {
                adnSelect[Int32.Parse((right(button.Name, 1)))-1] = 1;
                clickIndex++;
                lb_info.Text = "Choose the Father";
            }
            else if (clickIndex == 2 && adnSelect[Int32.Parse((right(button.Name, 1)))-1] != 1)
            {
                adnSelect[Int32.Parse((right(button.Name, 1)))-1] = 2;

                croisement();
                mutation();
                afficher();
                calculScore();

                resetadnSelect();
                clickIndex = 1;

                lb_info.Text = "Choose the Mother";
            }

            pic_choix1.Refresh();
            pic_choix2.Refresh();
            pic_choix3.Refresh(); 
            pic_choix4.Refresh();
        }

        private void pic_choix_Paint(object sender, PaintEventArgs e)
        {
            var picture = (PictureBox)sender;

            int index = Int32.Parse((right(picture.Name, 1)));

            if (adnSelect[index-1] == 1)
            { 
                using (Font myFont = new Font("Arial", 14))
                {
                    e.Graphics.DrawString("M", myFont, Brushes.Black, new Point(3, 3));
                }
            }
        }
        void resetadnSelect()
        {
           for(int i=0; i<adnSelect.Length; i++)
           {
               adnSelect[i] = 0;
           }
        }
        void calculScore()
        {
            int score;

            score = Math.Abs(adn[0].R - goal.R) + Math.Abs(adn[0].G - goal.G) + Math.Abs(adn[0].B - goal.B);

            lb_Score.Text = score.ToString();
        }
        void mutation()
        {
            int randomR, randomG, randomB;
            int min = 0, max = 0;
            int mutationValue = tb_mutation.Value;
            
            for (int i = 1; i < adnSelect.Length; i++)
            {
               
                //--R
                min = Convert.ToInt32(adn[i].R - mutationValue);
                if (min < 0) min = 0;
                max = Convert.ToInt32(adn[i].R + mutationValue);
                if (max > 255) max = 255;
                
                randomR = random.Next(min, max);
                //--- G
                min = Convert.ToInt32(adn[i].G - mutationValue);
                if (min < 0) min = 0;
                max = Convert.ToInt32(adn[i].G + mutationValue);
                if (max > 255) max = 255;
                
                randomG = random.Next(min, max);
                //--- B
                min = Convert.ToInt32(adn[i].B - mutationValue);
                if (min < 0) min = 0;
                max = Convert.ToInt32(adn[i].B + mutationValue);
                if (max > 255) max = 255;

                randomB = random.Next(min, max);
                //---

                adn[i] = Color.FromArgb(randomR, randomG, randomB);
            }
        }

        void croisement()
        {
            int mother, father; // mother est plus forte
            Color tempMother = Color.White, tempFather = Color.White;
            int randomR,randomG,randomB;

            for (int i = 0; i < adnSelect.Length; i++)
            {
                if (adnSelect[i] == 1)
                {
                    mother = i;
                    tempMother = adn[i];
                }
                else if (adnSelect[i] == 2)
                {
                    father = i;
                    tempFather = adn[i];
                }
            }

            adn[0] = tempMother;

            for (int i = 1; i < adnSelect.Length; i++)
            {
                if (tempMother.R < tempFather.R)
                {
                    randomR = random.Next(tempMother.R, tempFather.R);
                }
                else
                {
                    randomR = random.Next(tempFather.R, tempMother.R);
                }

                if (tempMother.G < tempFather.G)
                {
                    randomG = random.Next(tempMother.G, tempFather.G);
                }
                else
                {
                    randomG = random.Next(tempFather.G, tempMother.G);
                }
                
                if (tempMother.B < tempFather.B)
                {
                    randomB = random.Next(tempMother.B, tempFather.B);
                }
                else
                {
                    randomB = random.Next(tempFather.B, tempMother.B);
                }

                adn[i] = Color.FromArgb(randomR, randomG, randomB);
            }

        }

        private void tb_mutation_Scroll(object sender, EventArgs e)
        {
            lb_mutation.Text = tb_mutation.Value.ToString();
        }
    }
}
