using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class MyButton : Button
        {
            private int countClick;
           
            public void countClickPlus()
            {
                countClick ++;
            }
            public int getCountClick()
            {
                return this.countClick;
            }
        }


        MyButton mbt = new MyButton();
        

        private void Form1_Load(object sender, EventArgs e)
        {

            //mbt.Location = new System.Drawing.Point(this.ClientRectangle.Width / 2 - 125 / 2, this.ClientRectangle.Height / 2 - 32);
            mbt.Location = new System.Drawing.Point(0,0);
            mbt.Size = new Size(150, 100);
            mbt.Text = "Жмак";
            mbt.MouseDown += new MouseEventHandler(mbt_click);
            Controls.Add(mbt);
        }
        private void mbt_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                mbt.Text = "Нажали \n " + mbt.getCountClick() + "\n раз(а)";
                timer1.Start();
            }
            else {
                mbt.countClickPlus();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mbt.Text = "Жмак";
        }
    }
}