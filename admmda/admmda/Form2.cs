using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace admmda
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        DataTable tablo =new DataTable();
        private void Form2_Load(object sender, EventArgs e)
        {
            tablo.Columns.Add("e-posta", typeof(string));
            tablo.Columns.Add("telefon", typeof(int));
            tablo.Columns.Add("adsoyad", typeof(string));
            tablo.Columns.Add("dogumtarih", typeof(int));
            tablo.Columns.Add("cinsiyet", typeof(string));
            tablo.Columns.Add("şifre", typeof(string));
            tablo.Columns.Add("şifre tekrar", typeof(string));
            dataGridView1.DataSource = tablo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tablo.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text);
            dataGridView1.DataSource = tablo;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '£' || e.KeyChar == '#' || e.KeyChar == '$' || e.KeyChar == '½' || e.KeyChar == '&' || e.KeyChar == '{' ||
                e.KeyChar == '/' || e.KeyChar == '[' || e.KeyChar == '(' || e.KeyChar == ']' || e.KeyChar == ')' || e.KeyChar == '}' ||
                e.KeyChar == '=' || e.KeyChar == '?' || e.KeyChar == '?' || e.KeyChar == '_' || e.KeyChar == '|' || e.KeyChar == '!' ||
                e.KeyChar == '+' || e.KeyChar == '%' || e.KeyChar == 'ı' || e.KeyChar == 'ü' || e.KeyChar == 'ö' || e.KeyChar == 'ş' ||
                e.KeyChar == 'ç' || e.KeyChar == '@' || e.KeyChar == '-') 
            {
                e.Handled = true;
            }
        }
        
    }
}
