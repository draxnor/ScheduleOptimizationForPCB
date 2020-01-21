using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }



        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics G = e.Graphics;
            G.Clear(Color.LightGray);
            Pen px = new Pen(Color.Black);
            List<SolidBrush> br = new List<SolidBrush>(5);
            br.Add(new SolidBrush(Color.Yellow));
            br.Add(new SolidBrush(Color.Red));
            br.Add(new SolidBrush(Color.Blue));
            br.Add(new SolidBrush(Color.Gray));
            br.Add(new SolidBrush(Color.Green));

            if (Form1.aplication.getOrderOfTasks().Count < 1)
            {
                return;
            }

            int xP1, wP1, yP1, xP2, wP2, yP2, h = 30;
            int x0 = 50;
            int n = Form1.aplication.getOrderOfTasks().Count;

            // do usuniecia potem
            foreach (Task it in Form1.aplication.getOrderOfTasks())
            {
                Console.WriteLine(" p1:");
                Console.WriteLine(it.timeOfFinishOperationP1.ToString());
                Console.WriteLine(" p2:");
                Console.WriteLine(it.timeOfFinishOperationP2.ToString());
            }
                

            for (int i = 0; i < n; i++)
            {
                xP1 = x0+(Form1.aplication.getOrderOfTasks()[i].timeOfFinishOperationP1 - Form1.aplication.getOrderOfTasks()[i].timeP1) * 10;
                wP1 = Form1.aplication.getOrderOfTasks()[i].timeP1 * 30;
                yP1 = 0;
                xP2 = x0 + (Form1.aplication.getOrderOfTasks()[i].timeOfFinishOperationP2 - Form1.aplication.getOrderOfTasks()[i].timeP2) * 10;
                wP2 = Form1.aplication.getOrderOfTasks()[i].timeP2 * 30;
                yP2 = 50;

                G.FillRectangle(br[i % 5], xP1, yP1, wP1, h);
                G.FillRectangle(br[i % 5], xP2, yP2, wP2, h);
            }
            Font myFont = new Font("Arial", 14);
            G.DrawString("SMD", myFont, Brushes.Black, new PointF(2, 0));
            G.DrawString("THT", myFont, Brushes.Black, new PointF(2, 50));

            cmax_textbox.Text = Form1.aplication.getOrderOfTasks()[n - 1].timeOfFinishOperationP2.ToString();
        }

        private void zamknij_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
