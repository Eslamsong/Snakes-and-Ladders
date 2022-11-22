using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snakes_and_Ladders
{
    public partial class Form1 : Form
    {
        int flag = 0;
        bool white = false ,purple=false;
        int x =20, y = 465 ,dicevalue,p=0;
        int bx = 20, by = 465, p2 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                button2.Enabled = false;
            }
            pictureBox5.Visible = false;
            pictureBox4.Visible=false;
            pictureBox3.Image = Image.FromFile(@"E:\ITI 3-months\Oop C#\Labs\Snakes and Ladders\Resources\Dice-And-Roll.png");
            pictureBox3.SizeMode=PictureBoxSizeMode.StretchImage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dicevalue = code.rolldice(pictureBox3);
            label2.Text = dicevalue.ToString();

            if (purple == true)
            {
                code.move(ref bx, ref by, ref p2, dicevalue, pictureBox5, label10);

            }

            if (label2.Text == "6" && purple == false)
            {
                pictureBox5.Visible = true;
                pictureBox2.Visible = false;
                purple = true;
                pictureBox5.Location = new Point(bx, by);
                

                p2++;
                label10.Text = p.ToString();
            }

            if (p2 == 100)
            {
                MessageBox.Show("PLAYER 2 WON THE GAME !");
                button2.Enabled = false;
                button1.Enabled = false;
            }

            code.laddersteps(ref bx, ref by, ref p2, pictureBox5, label10);
            code.Snakes(ref bx, ref by, ref p2, pictureBox5, label10);

            if (dicevalue == 6)
            {
                flag = 1;
            }
            else
            {
                flag = 0;
                button2.Enabled = false;    
                button1.Enabled = true; 
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
             dicevalue = code.rolldice(pictureBox3);
             label2.Text= dicevalue.ToString();

            if (white == true)
            {
                code.move( ref x,ref y,ref p,dicevalue,pictureBox4, label8);
               
            }

            if (label2.Text == "6" && white==false)
            {
                pictureBox4.Visible=true;
                pictureBox1.Visible = false;
                white=true;
                pictureBox4.Location = new Point(x, y);
            
                
                p++;
                label8.Text = p.ToString();
            }


            if (p == 100)
            {
                MessageBox.Show("PLAYER 1 WON THE GAME !");
                button1.Enabled=false;  
                button2.Enabled=false;  
            }

            code.laddersteps(ref x, ref y, ref p, pictureBox4, label8);
            code.Snakes(ref x, ref y, ref p, pictureBox4, label8);

            if (dicevalue == 6)
            {
                flag = 0;
            }
            else
            {
                flag = 1;
                button1.Enabled = false;
                button2.Enabled = true;
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

     
    }
}
