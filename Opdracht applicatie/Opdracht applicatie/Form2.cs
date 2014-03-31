using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht_applicatie
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int score = 0;
        int i = -1;
        int a = 0;
        int x = 0;

        string[] vragen = new string[]{
    "Hoeveel is 12 + 12?", "Welk van deze dieren is geen insect?", 
    "Wat is de lekkerste snack die je kan halen in de snackbar?",
    "Hoe heet Dylan van zijn achternaam?"
        };

        string[] antwoorden = new string[] {
   "24", "81", "729", "2", 
   "lieveheersbeestje", "aardvarken", "mier", "mot", 
   "kaassouffle mayo", "Frikadel speciaal", "patatje oorlog", "Milkshake banaan", 
   "Bartels", "Dylan-Dylan", "Dylan", "Dylan-Dylan-Dylan"
        };

        string[] goedeAntwoorden = new string[] { 
            "24", "aardvarken", "kaassouffle mayo", "Bartels" 
        };

        private void button1_Click(object sender, EventArgs e)
          {
         

            if (getAntwoord1().Equals(goedeAntwoorden[x]))
            {
                label7.Text = Convert.ToString(score);
                score++;
                x++;
                groupBox1.Text = "Goed";
            }
            else{
                x++;
                groupBox1.Text = "Fout";
            }

            if (getAntwoord2().Equals(goedeAntwoorden[x]))
            {
                label7.Text = Convert.ToString(score);
                score++;
                x++;
                groupBox2.Text = "Goed";
            }
            else
            {
                x++;
                groupBox2.Text = "Fout";
            }

            if (getAntwoord3().Equals(goedeAntwoorden[x]))
            {
                label7.Text = Convert.ToString(score);
                score++;
                x++;
                groupBox3.Text = "Goed";
            }
            else
            {
                x++;
                groupBox3.Text = "Fout";
            }

            if (getAntwoord4().Equals(goedeAntwoorden[x]))
            {
                score++;
                label7.Text = Convert.ToString(score);
                x++;
                groupBox4.Text = "Goed";
            }
            else
            {
                x++;
                groupBox4.Text = "Fout";
            }
            x = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (i < vragen.Length)
            {
                i++;
                label2.Text = vragen[i];
                radioButton1.Text = antwoorden[a];
                a++;
                radioButton2.Text = antwoorden[a];
                a++;
                radioButton3.Text = antwoorden[a];
                a++;
                radioButton4.Text = antwoorden[a];
                a++;

                i++;
                label3.Text = vragen[i];
                radioButton5.Text = antwoorden[a];
                a++;
                radioButton6.Text = antwoorden[a];
                a++;
                radioButton7.Text = antwoorden[a];
                a++;
                radioButton8.Text = antwoorden[a];
                a++;

                i++;
                label4.Text = vragen[i];
                radioButton9.Text = antwoorden[a];
                a++;
                radioButton10.Text = antwoorden[a];
                a++;
                radioButton11.Text = antwoorden[a];
                a++;
                radioButton12.Text = antwoorden[a];
                a++;

                i++;
                label5.Text = vragen[i];
                radioButton13.Text = antwoorden[a];
                a++;
                radioButton14.Text = antwoorden[a];
                a++;
                radioButton15.Text = antwoorden[a];
                a++;
                radioButton16.Text = antwoorden[a];
                a++;

                button2.Visible = false;
                button2.Enabled = false;
                button1.Visible = true;
                button1.Enabled = true;
            }
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        string getAntwoord1()
        {
            if (radioButton1.Checked)
                return radioButton1.Text.ToString();
            if (radioButton2.Checked)
                return radioButton2.Text.ToString();
            if (radioButton3.Checked)
                return radioButton3.Text.ToString();
            if (radioButton4.Checked)
                return radioButton4.Text.ToString();
            return "";
        }

        string getAntwoord2(){
            if (radioButton5.Checked)
                return radioButton5.Text.ToString();
            if (radioButton6.Checked)
                return radioButton6.Text.ToString();
            if (radioButton7.Checked)
                return radioButton7.Text.ToString();
            if (radioButton8.Checked)
                return radioButton8.Text.ToString();
            return "";
            }
        
        string getAntwoord3(){
            if (radioButton9.Checked)
                return radioButton9.Text.ToString();
            if (radioButton10.Checked)
                return radioButton10.Text.ToString();
            if (radioButton11.Checked)
                return radioButton11.Text.ToString();
            if (radioButton12.Checked)
                return radioButton12.Text.ToString();
                return "";
        }

        string getAntwoord4(){
            if (radioButton13.Checked)
                return radioButton13.Text.ToString();
            if (radioButton14.Checked)
                return radioButton14.Text.ToString();
            if (radioButton15.Checked)
                return radioButton15.Text.ToString();
            if (radioButton16.Checked)
                return radioButton16.Text.ToString();
            return "";
        }
    }
}
