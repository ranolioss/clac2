using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalCu
{
    public partial class Form1 : Form
    {
        double firstNumber, secondNumber, Result;

        private void Sum_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToInt32(NOne.Text);
            secondNumber = Convert.ToInt32(Ntwo.Text);
            Result = firstNumber + secondNumber;
            Res.Text = Result.ToString();
        }

        private void Min_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToInt32(NOne.Text);
            secondNumber = Convert.ToInt32(Ntwo.Text);
            Result = firstNumber - secondNumber;
            Res.Text = Result.ToString();
        }

        private void Perc_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToInt32(NOne.Text);
            secondNumber = Convert.ToInt32(Ntwo.Text);
            Result = firstNumber % secondNumber;
            Res.Text = Result.ToString();
            if (firstNumber == 0 || secondNumber == 0)
            {
                MessageBox.Show("you can not divid number by 0");
            }
        }

        private void Divi_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToInt32(NOne.Text);
            secondNumber = Convert.ToInt32(Ntwo.Text);
            Result = firstNumber / secondNumber;
            Res.Text = Result.ToString();
            if(firstNumber==0 || secondNumber==0)
            {
                MessageBox.Show("you can not divid number by 0");
            }
        }

        private void Power_Click(object sender, EventArgs e)
        {
            int FirstNumber = Convert.ToInt32(NOne.Text);
            int SecondNumber = Convert.ToInt32(Ntwo.Text);
            Result = Powerr(FirstNumber,SecondNumber);
            Res.Text = Result.ToString();
        }
        public static int Powerr(int x, int y)
        {
            if (y == 0)
                return 1;
            else
                return x * Powerr(x, y - 1);
        }

        private void Fact_Click(object sender, EventArgs e)
        {
            int i,  fact = 1;
            firstNumber = Convert.ToInt32(NOne.Text);
            for (i = 1; i <= firstNumber; i++)
            {
                fact = fact * i;
                Res.Text = fact.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Ex_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            NOne.Text = "";
            Ntwo.Text = "";
            Res.Text = "";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Multi_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToInt32(NOne.Text);
            secondNumber = Convert.ToInt32(Ntwo.Text);
            Result = firstNumber * secondNumber;
            Res.Text = Result.ToString();
        }
    }
}
