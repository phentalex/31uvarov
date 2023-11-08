using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31uvarov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            DataTable table = new DataTable();

            table.Rows.Clear();
            table.Columns.Clear();
            table.Columns.Add("X", typeof(string));
            table.Columns.Add("Y", typeof(string));

            double x1 = Convert.ToDouble(textBox1.Text);
            double x2 = Convert.ToDouble(textBox2.Text);
            double dx = Convert.ToDouble(textBox3.Text);
            double r = 2;
            double y, x = x1;
            if (x >= -4 && x <= 5)
            {
                if (x <= 0)
                {
                    for (int i = 0; x <= 0 && x <= x2; i++)
                    {
                        y = -x * 0.5;
                        table.Rows.Add(x, y);
                        x += dx;
                    }
                }
                if (x <= 2)
                {
                    for (int i = 0; x < 2 && x <= x2; i++)
                    {
                        y = Math.Sqrt(Math.Pow(r, 2) - Math.Pow(x, 2)) - 2;
                        table.Rows.Add(x, -y);
                        x += dx;
                    }
                }
                if (x <= 4)
                {
                    for (int i = 0; x < 4 && x <= x2; i++)
                    {
                        y = Math.Sqrt(Math.Pow(r, 2) - Math.Pow(x - 2, 2));
                        table.Rows.Add(x, y);
                        x += dx;
                    }
                }
                if (x <= 5)
                {
                    for (int i = 0; x <= 5 && x <= x2; i++)
                    {
                        y = -x + 4;
                        table.Rows.Add(x, y);
                        x += dx;
                    }
                }
            }
            else
            {
                MessageBox.Show("Введите значения Х в интервале от Х=-4 до Х=5.");
            }

            dataGridView1.DataSource = table;
        }
    }
}
