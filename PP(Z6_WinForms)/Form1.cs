using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP_Z6_WinForms_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mas1_n_TextChanged(object sender, EventArgs e)
        {
            int n = int.Parse(mas1_n.Text);
            int[] a = new int[n];
            Random rand = new Random();
            int sum = 0;
            string rez = "";
            for (int i = 0; i < n; i++)
            {
                a[i] = rand.Next(-100, 100);
                rez += a[i] + " ";
                if (a[i] % 9 == 0)
                {
                    sum += a[i];
                }
            }
            mas_one.Text = rez;
            sum1.Text = sum.ToString();
        }
        private void mas1_n_KeyPress(object sender, KeyPressEventArgs e)
        {
            char symbol = e.KeyChar;
            if (!Char.IsDigit(symbol))
            {
                e.Handled = true;
            }
        }
        private void Result_Click(object sender, EventArgs e)
        {
            int n2 = int.Parse(mas2_n2.Text);
            int m2 = int.Parse(mas2_m2.Text);
            int[,] b = new int[n2, m2];
            mas_table.RowCount = n2;
            mas_table.ColumnCount = m2;
            Random rand = new Random();
            int summ = 0;
            for (int i = 0; i < n2; i++)
            {
                for (int j = 0; j < m2; j++)
                {
                    b[i, j] = rand.Next(-99, 99);
                    mas_table.Columns[j].Width = 30;
                    mas_table.Rows[i].Cells[j].Value = b[i, j];
                    if (b[i, j] % 9 == 0)
                    {
                        summ += b[i, j];
                    }
                }
            }
            sum2.Text = summ.ToString();
        }

        private void To_Count_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int n = int.Parse(enter_n.Text);
            int[] a = new int[n];
            string rez = "";
            for (int i = 0; i < n; i++)
            {
                a[i] = rand.Next(-5,20);
                rez += a[i].ToString() + " ";
            }
            mas_a.Text = rez;
            int max = a[0];
            int imax = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                    imax = i;
                    break;
                }
            }
            Max.Text = imax.ToString();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            int n = int.Parse(size_mas_n.Text);
            int[,] mas = new int[n, n];
            Random rand = new Random();
            string rez = "";
            int buffer;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mas[i, j] = rand.Next(-10, 10);
                    rez += mas[i, j] + " ";
                }
                rez += "\n";
            }
            array_mas.Text = rez;
            string rez1 = "";
            if (n % 2 == 0)
            {
                for (int i = 0; i < n; i += 2)
                {
                    for (int j = 0; j < n; j++)
                    {
                        buffer = mas[j, i];
                        mas[j, i] = mas[j, i + 1];
                        mas[j, i + 1] = buffer;
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        rez1 += mas[i, j] + " ";
                    }
                    rez1 += "\n";
                }
                array_mas2.Text = rez1;
            }
            else {
                rez1 = "Массив нечетный!";
                array_mas2.Text = rez1;
            }
        }
        private void END_Click(object sender, EventArgs e)
        {
            int n = int.Parse(size_mas_n1.Text);
            int[][] mas1 = new int[n][];
            int[] mas2 = new int[n];
            Random rand = new Random();
            string rez = "";
            for (int i = 0; i < n; i++)
            {
                mas1[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    mas1[i][j] = rand.Next(-10, 10);
                    rez += mas1[i][j] + " ";
                }
                rez += "\n";
            }
            first.Text = rez;
            string rez1 = "";
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mas1[j][i] > 0)
                    {
                        mas2[i] = mas1[j][i];
                        break;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                rez1+=mas2[i] + " ";
            }
            second.Text = rez1;
        }
    }
}
