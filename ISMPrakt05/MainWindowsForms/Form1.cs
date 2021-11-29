using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainLib;

namespace MainWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool Check(string str,out int truenum)
        {
            if(!int.TryParse(str,out truenum)|| Convert.ToInt32(str) < 0)
            {
                MessageBox.Show("Error");
                return false;
            }
            else 
            {
                return true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tmp;
            string Text = textBox1.Text;
            if(!Check(Text,out tmp))
            {
                return;
            }

            int[] arr = new int[Convert.ToInt32(Text)];
            dataGridView1.RowCount = 1;
            dataGridView1.ColumnCount = Convert.ToInt32(Text);

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = TaskArr.RandomArr(Convert.ToInt32(Text))[i];
                dataGridView1[i, 0].Value = arr[i];
                dataGridView1.Columns[i].HeaderText = i.ToString();
            }
            TaskArr.SumNegative(arr);
                textBox2.Text = TaskArr.SumNegative(arr).ToString();
            TaskArr.MaxNumberAmoungPairedElem(arr);
                textBox3.Text = TaskArr.MaxNumberAmoungPairedElem(arr).ToString();
            TaskArr.MultiplicationOfPairedIndex(arr);
                textBox4.Text = TaskArr.MultiplicationOfPairedIndex(arr).ToString();
            TaskArr.MaxIndex(arr);
                textBox5.Text = TaskArr.MaxIndex(arr).ToString();
            TaskArr.AbsMaxNumber(arr);
                textBox6.Text = TaskArr.AbsMaxNumber(arr).ToString();
            TaskArr.SumIndexWithPositiveElement(arr);
                textBox7.Text = TaskArr.SumIndexWithPositiveElement(arr).ToString();
            TaskArr.CountOfUnpairedElement(arr);
                textBox8.Text = TaskArr.CountOfUnpairedElement(arr).ToString();
        }
    }
}
