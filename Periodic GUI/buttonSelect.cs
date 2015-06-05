using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Periodic_GUI
{
    public partial class buttonSelect : Form
    {
        static double num;
        static int amt;
        static int count;
        
       
        public buttonSelect(double number, int counted)
        {
            num = number;
            count = counted;
            InitializeComponent();
        }
        public buttonSelect(double number)
        {
            num = number;
        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        public double getNum()
        {
            return num;
        }

        public double getAmt()
        {
            return amt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            //Uses dropdown
            Form1 table = new Form1();
            if (comboBox1.SelectedIndex > -1)
            {
                object m = comboBox1.SelectedItem;
                double k = Convert.ToDouble(m);
                amt = Convert.ToInt32(k);
                table.setDang(k * count);                
            }
            //uses keyboard input
            else
            {
                //protects crashing from text box returning "" or a non numerical input
               string j = comboBox1.Text;

               int myInt;
               bool isNumerical = int.TryParse(j, out myInt);

               if (j.Equals("") || !(isNumerical))
               {
                   this.Close();
               }
               else  
               {
                   double g = Convert.ToDouble(j);
                   amt = Convert.ToInt32(g);
                   if (g > 0)
                      table.setDang(g * count);                      
               }
            }             
            this.Close();
        }

        private void buttonSelect_Load(object sender, EventArgs e)
        {

        }
    }
}
