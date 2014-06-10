using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        long milliseconds = 0;
        long temp = 0;
        long[] values = new long[100];
        int i = 0;
        String password = "";
        String password1 = "";

        long milliseconds1 = 0;
        long temp1 = 0;
        long[] values1 = new long[100];
        int i1 = 0;

        bool check = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            password = textBox2.Text;
            password1 = textBox3.Text;
            if (password != password1) check = false;


            for (int i = 1; i < password.Length - 1; i++)
            {
                Debug.WriteLine(values[i]+"  "+values1[i]);
                if (!(values1[i] < values[i] * 1.5 && values1[i] > values[i] * 0.5))
                {
                    check = false;
                }
            }

            MessageBox.Show(check.ToString());
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            milliseconds = DateTime.Now.Ticks;
            Debug.WriteLine(milliseconds-temp);
            values[i] = milliseconds - temp;
            temp = milliseconds;
            i++;


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            milliseconds1 = DateTime.Now.Ticks;
            Debug.WriteLine(milliseconds1-temp1);
            values1[i1] = milliseconds1 - temp1;
            temp1 = milliseconds1;
            i1++;
        }
    }
}
