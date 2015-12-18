using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QIK_v2
{
    public partial class Form1 : Form
    {
        int pickState = 1;
        int[] adnSelect = new int[4];
        int[,] adn = new int[4,50];
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            this.but_choix0.Click += new System.EventHandler(this.Button_Click);
            this.but_choix1.Click += new System.EventHandler(this.Button_Click);
            this.but_choix2.Click += new System.EventHandler(this.Button_Click);
            this.but_choix3.Click += new System.EventHandler(this.Button_Click);
        }
        void randomize()
        {
            for (int i = 0; i < adnSelect.Length; i++)
            {
                for (int j = 0; j < lbox_ingredient.Items.Count; j++)
                {
                    adn[i, j] = random.Next(1000);
                }
            }
        }
        void initialisation()
        {
            resetadnSelect();
            randomize();
            afficher();
            pickState = 1;
            lb_info.Text = "Choose your favorite Drink";
        }
        private void Button_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
           

            if(pickState == 1)
            {
                adnSelect[int.Parse(right(button.Name, 1))] = 1;
                pickState++;
                lb_info.Text = "Choose your second favorite Drink";
                button.Enabled = false;
            }
            else if (pickState == 2)
            {
                adnSelect[int.Parse(right(button.Name, 1))] = 2;

                
                croisement();
                mutation();
                afficher();
                resetadnSelect();

                pickState = 1;

                lb_info.Text = "Choose your favorite Drink";
            }
        }
        void croisement()
        {
            int[] tempMother = new int[50];
            int[] tempFather = new int[50];
            int i,k;

           
            //-----
            for (i = 0; i < adnSelect.Length; i++)
            {
                if(adnSelect[i] == 1)
                {
                    for (k = 0; k < lbox_ingredient.Items.Count; k++)
                    {
                        tempMother[k] = adn[i,k];
                    }
                }
                else if(adnSelect[i] == 2)
                {
                    for (k = 0; k < lbox_ingredient.Items.Count; k++)
                    {
                        tempFather[k] = adn[i,k];
                    }
                }
            }
           
            //-----
            for (k = 0; k < lbox_ingredient.Items.Count; k++)
            {
                adn[0, k] = tempMother[k];
            }
            //-----
            for (i = 1; i < adnSelect.Length; i++)
            {
                for (k = 0; k < lbox_ingredient.Items.Count; k++)
                {
                    if (tempMother[k] < tempFather[k])
                    {
                        adn[i, k] = random.Next(tempMother[k], tempFather[k]);
                    }
                    else
                    {
                        adn[i, k] = random.Next(tempFather[k], tempMother[k]);
                    }
                }
            }
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
        void resetadnSelect()
        {
            /*foreach (var b in this.Controls.OfType<Button>())
           {
               b.Enabled = true;
           }*/
            but_choix0.Enabled = true; //fuck it
            but_choix1.Enabled = true;
            but_choix2.Enabled = true;
            but_choix3.Enabled = true;

            for (int i = 0; i < adnSelect.Length; i++)
            {
                adnSelect[i] = 0;
            }
        }
        void afficher()
        {
            int somme0 = 0, somme1 = 0, somme2 = 0, somme3 = 0;
            int j;
            lbox_choix0.Items.Clear();
            lbox_choix1.Items.Clear();
            lbox_choix2.Items.Clear();
            lbox_choix3.Items.Clear();

            for(j=0; j < lbox_ingredient.Items.Count; j++){
                somme0 += adn[0, j];
                somme1 += adn[1, j];
                somme2 += adn[2, j];
                somme3 += adn[3, j];
            }
            for(j=0; j < lbox_ingredient.Items.Count; j++){
                lbox_choix0.Items.Add(Math.Round((adn[0, j] * double.Parse(tb_size.Text) / somme0), 1) + " ml de " + lbox_ingredient.Items[j].ToString());
                lbox_choix1.Items.Add(Math.Round((adn[1, j] * double.Parse(tb_size.Text) / somme1), 1) + "ml de " + lbox_ingredient.Items[j].ToString());
                lbox_choix2.Items.Add(Math.Round((adn[2, j] * double.Parse(tb_size.Text) / somme2), 1) + "ml de " + lbox_ingredient.Items[j].ToString());
                lbox_choix3.Items.Add(Math.Round((adn[3, j] * double.Parse(tb_size.Text) / somme3), 1) + "ml de " + lbox_ingredient.Items[j].ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initialisation();
        }

        private void but_reset_Click(object sender, EventArgs e)
        {
            initialisation();
        }
        void mutation()
        {
            int i = 0, j = 0;
            int min = 0, max = 0;
            int mutationValue = int.Parse(tb_mutation.Text);

            for (i = 1; i < adnSelect.Length; i++)
            {
                for (j = 0; j < lbox_ingredient.Items.Count; j++)
                {
                    min = adn[i,j] - mutationValue/2*10;
                    if (min < 0) min = 0;
                    max = adn[i,j] + mutationValue/2*10;
                    if (max > 1000) max = 1000;

                    adn[i,j] = random.Next(min, max);
                }
            }
        }
    }
}

