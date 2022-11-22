using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snakes_and_Ladders
{
    internal class code
    {
        public static int rolldice (PictureBox P)
        {

            int dice = 0;
            Random rnd = new Random();
            dice = rnd.Next(1, 7);

            P.Image = Image.FromFile(@"E:\ITI 3-months\Oop C#\Labs\Snakes and Ladders\Resources\" + dice + ".png");
            P.SizeMode = PictureBoxSizeMode.StretchImage;
            return dice;
        }
        public static void move (ref int x , ref int y , ref int p,int dice, /*ref int[] pos,*/ PictureBox px, Label l)
        {

            if(dice+p > 100)
            {
                MessageBox.Show("Can't MOve");
                l.Text = "Can't MOVE";
                l.ForeColor = Color.Red;
                return;
            }
            for(int i = 0; i < dice; i++)
            {
                if (p == 10)
                {
                    x = 20;
                    y = 416;
                    p++;
                }
                else if (p == 20)
                {
                    x = 20;
                    y = 368;
                    p++;

                }
                else if (p == 30)
                {
                    x = 20;
                    y = 319;
                    p++;

                }
                else if (p == 40)
                {
                    x = 20;
                    y = 268;
                    p++;
                                      

                }
                else if (p == 50)
                {
                    x = 20;
                    y = 218;
                    p++;

                }
                else if (p == 60)
                {
                    x = 20;
                    y = 168;
                    p++;

                }
                else if (p == 70)
                {
                    x = 20;
                    y = 118;
                    p++;

                }
                else if (p == 80)
                {
                    x = 20;
                    y = 68;
                    p++;

                }
                else if (p == 90)
                {
                    x = 20;
                    y = 18;
                    p++;

                }
                else
                {
                    x += 75;
                    l.Text = p.ToString();
                    p++;
                }

                
                px.Location = new Point(x, y);
                
                //pos[p] = 1;
            }

        }//end move


        public static void laddersteps( ref int x,ref int y, ref int p, PictureBox px ,Label l)

        {
            if (p == 3)
            {
                x = 20;
                y = 218;
                p = 51;
            }

            else if (p == 6)
            {
                x = 470;
                y = 359;
                p = 27;
            }
            else if (p == 20)
            {
                x = 698;
                y = 167;
                p = 70;
            }
            else if (p == 36)
            {
                x = 321;
                y = 209;
                p = 55;
            }
            else if (p == 63)
            {
                x = 325;
                y = 9;
                p = 95;
            }
            else if (p == 68)
            {
                x = 548;
                y = 9;
                p = 98;
            }
            px.Location = new Point(x, y);
            l.Text = p.ToString();



        }//laddersteps end
        public static void Snakes(ref int x, ref int y, ref int p, PictureBox px, Label l)

        {
            if (p == 25)
            {
               
                x = 326;
                y = 466;
                p = 5;
            }

            else if (p == 34)
            {
                x = 20;
                y = 465;
                p = 1;
            }
            else if (p == 47)
            {
                x = 624;  
                y = 421;
                p = 19;
            }
            else if (p == 65)
            {
                x = 103; 
                y = 215;
                p = 52;
            }
            else if (p == 87)
            {
                x = 485;
                y = 211;
                p = 57;
            }
            else if (p == 91)
            {
                x = 21;
                y = 167;
                p = 61;
            }
            else if (p == 99)
            {
                x = 619; 
                y = 167;
                p = 69;
            }
            px.Location = new Point(x, y);
            l.Text = p.ToString();



        }//snakes end
    }
}
