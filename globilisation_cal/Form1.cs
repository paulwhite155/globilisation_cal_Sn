using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace globilisation_cal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //System.Globalization.GregorianCalendar g = new System.Globalization.GregorianCalendar();  you could use this way
            System.Globalization.GregorianCalendar g;
            g = new System.Globalization.GregorianCalendar();
            this.textBox1.Text = g.GetYear(DateTime.Now).ToString();
            this.textBox2.Text = g.GetMonth(DateTime.Now).ToString();
            this.textBox3.Text = g.GetDayOfMonth(DateTime.Now).ToString();
            this.textBox4.Text = g.GetDayOfWeek(DateTime.Now).ToString();

            Int32 m;
            Int32.TryParse(this.textBox2.Text, out m);

            this.textBox5.Text = month_num_to_name(m);


        }
            

        

        //------------------------------
         public string month_num_to_name(Int32 m )
        {

            string a;
            switch (m)
            {
                case 1:
                    a = "January";
                    break;
                case 2:
                    a = "Febrary";
                    break;
                case 3:
                    a = "March";
                    break;
                case 4:
                    a = "april";
                    break;
                case 5:
                    a = "may ";
                    break;
                case 6:
                    a = "june";
                    break;
                case 7:
                    a = "July";
                    break;
                case 8:
                    a = "August";
                    break;
                case 9:
                    a = "September";
                    break;
                case 10:
                    a = "october ";
                    break;
                case 11:
                    a = "novemeber";
                    break;
                case 12:
                    a = "decemeber";
                    break;
                default:
                    a = "unknown";
                    break;
             }
            return a;
        
         }

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Globalization.GregorianCalendar g;
            g = new System.Globalization.GregorianCalendar();
            this.year_label1.Text = g.GetYear(DateTime.Now).ToString();
           
            //this.textBox2.Text= g.GetMonth(DateTime.Now).ToString();
            this.daymonth_label1.Text = g.GetDayOfMonth(DateTime.Now).ToString();
            this.dayweek_label1.Text = g.GetDayOfWeek(DateTime.Now).ToString();

            Int32 m;
            Int32.TryParse(g.GetMonth(DateTime.Now).ToString(), out m);

            this.month_label2.Text = month_num_to_name(m); 
        }
    }
    
}
