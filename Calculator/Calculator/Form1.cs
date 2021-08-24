using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure close this application?",
                      "Exit",
                       MessageBoxButtons.OKCancel,
                       MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
        private int  countDot(string txt)
        {
            int counter = 0;
            for(int i=0;i<txt.Length;i++)
            {
                if(txt[i]=='.')
                {
                    counter++;
                }
            }
            return counter;
        }
        private void checkDot()
        {
            if (txtWindow.Text.Contains('.'))
            {
                activeButtons();
                btnDot.Enabled = false;
                if (txtWindow.Text.Contains('-') || txtWindow.Text.Contains('+') || txtWindow.Text.Contains('*') || txtWindow.Text.Contains('/') || txtWindow.Text.Contains('^'))
                {
                    inActiveButtons();
                    btnDot.Enabled = true;
                    btnEqual.Enabled = true;
                }
            }
            if(countDot(txtWindow.Text)==2)
            {
                btnDot.Enabled = false;
            }
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            txtWindow.ForeColor = Color.Black;
            txtWindow.Text += "0";
            btnEqual.Enabled = true;
            btnDot.Enabled = true;
            checkDot();
            activateMinus();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtWindow.ForeColor = Color.Black;
            txtWindow.Text += "1";
            btnEqual.Enabled = true;
            btnDot.Enabled = true;
            checkDot();
            activateMinus();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtWindow.ForeColor = Color.Black;
            txtWindow.Text += "2";
            btnEqual.Enabled = true;
            btnDot.Enabled = true;
            checkDot();
            activateMinus();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtWindow.ForeColor = Color.Black;
            txtWindow.Text += "3";
            btnEqual.Enabled = true;
            btnDot.Enabled = true;
            checkDot();
            activateMinus();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtWindow.ForeColor = Color.Black;
            txtWindow.Text += "4";
            btnEqual.Enabled = true;
            btnDot.Enabled = true;
            checkDot();
            activateMinus();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtWindow.ForeColor = Color.Black;
            txtWindow.Text += "5";
            btnEqual.Enabled = true;
            btnDot.Enabled = true;
            checkDot();
            activateMinus();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtWindow.ForeColor = Color.Black;
            txtWindow.Text += "6";
            btnEqual.Enabled = true;
            btnDot.Enabled = true;
            checkDot();
            activateMinus();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtWindow.ForeColor = Color.Black;
            txtWindow.Text += "7";
            btnEqual.Enabled = true;
            btnDot.Enabled = true;
            checkDot();
            activateMinus();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtWindow.ForeColor = Color.Black;
            txtWindow.Text += "8";
            btnEqual.Enabled = true;
            btnDot.Enabled = true;
            checkDot();
            activateMinus();
           
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtWindow.ForeColor = Color.Black;
            txtWindow.Text += "9";
            btnEqual.Enabled = true;
            btnDot.Enabled = true;
            checkDot();
            activateMinus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtWindow.ForeColor = Color.Black;
            txtWindow.Clear();
            activeButtons();
            counter = 0;
        }
        private void checkResult(double num)
        {
            txtWindow.ForeColor = num < 0 ? Color.Red : Color.Green;
        }
        private void activeButtons()
        {
            btnDivision.Enabled = true;
            btnAdd.Enabled = true;
            btnSubstract.Enabled = true;
            btnMultiply.Enabled = true;
            btnMod.Enabled = true;
            btnPow.Enabled = true;
            btnCos.Enabled = true;
            btnSin.Enabled = true;
            btnTan.Enabled = true;
            btnCot.Enabled = true;
            btnAbs.Enabled = true;
            btnFactor.Enabled = true;
            btnDot.Enabled = true;
            btnEqual.Enabled = true;
        }
        private void inActiveButtons()
        {
            btnDivision.Enabled = false;
            btnAdd.Enabled = false;
            btnSubstract.Enabled = false;
            btnMultiply.Enabled = false;
            btnMod.Enabled = false;
            btnPow.Enabled = false;
            btnCos.Enabled = false;
            btnSin.Enabled = false;
            btnTan.Enabled = false;
            btnCot.Enabled = false;
            btnAbs.Enabled = false;
            btnFactor.Enabled = false;
            btnEqual.Enabled = false;
            btnDot.Enabled = false;
        }
        private void activateMinus()
        {
            if (txtWindow.Text[0] == '-' && counter == 1)
            {
                btnSubstract.Enabled = true;
                btnAdd.Enabled = true;
                btnMultiply.Enabled = true;
                btnDivision.Enabled = true;
                btnSin.Enabled = true;
                btnCos.Enabled = true;
                btnTan.Enabled = true;
                btnCot.Enabled = true;
                btnPow.Enabled = true;
                btnAbs.Enabled = true;
                btnDot.Enabled = true;
            }
        }
        private void btnDivision_Click(object sender, EventArgs e)
        {
            txtWindow.ForeColor = Color.Black;
            if (txtWindow.Text != "")
            {
                txtWindow.Text += "/";
                inActiveButtons();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtWindow.ForeColor = Color.Black;
            if(txtWindow.Text!="")
            {
                txtWindow.Text += "+";
                inActiveButtons();
            }
           
        }
        int counter = 0;
        private void btnSubs_Click(object sender, EventArgs e)
        {
            txtWindow.ForeColor = Color.Black;
            if (txtWindow.Text!=""&&txtWindow.Text[0]=='-')
            {
                counter++;
            }
            txtWindow.Text += "-";
            counter++;
            inActiveButtons();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            txtWindow.ForeColor = Color.Black;
            if (txtWindow.Text != "")
            {
                txtWindow.Text += "*";
                inActiveButtons();
            }
        }
        private void btnMod_Click(object sender, EventArgs e)
        {
            txtWindow.ForeColor = Color.Black;
            if (txtWindow.Text != "")
            {
                txtWindow.Text += "%";
                inActiveButtons();
            }
        }
        private void btnPow_Click(object sender, EventArgs e)
        {
            txtWindow.ForeColor = Color.Black;
            if (txtWindow.Text != "")
            {
                txtWindow.Text += "^";
                inActiveButtons();
            }
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
           for(int i=1;i<txtWindow.Text.Length;i++)
            {
                if(txtWindow.Text[i]=='/'|| txtWindow.Text[i] == '*'||txtWindow.Text[i] == '+'||txtWindow.Text[i] == '-'||txtWindow.Text[i]=='%'|| txtWindow.Text[i] =='^')
                {
                    double result = 0;
                    string temp1 = txtWindow.Text.Substring(0, i);
                    string temp2 = txtWindow.Text.Substring(i+1,txtWindow.Text.Length-(i+1));
                    if(txtWindow.Text[i] == '/')
                    {
                        if(Convert.ToDouble(temp2)==0)
                        {
                            txtWindow.Text = "Zero Division ERROR";
                        }
                        else
                        {
                            result = Convert.ToDouble(temp1) / Convert.ToDouble(temp2);
                            txtWindow.Text = result.ToString();
                        }
                       
                    }
                    else if(txtWindow.Text[i] == '*')
                    {
                        result= Convert.ToDouble(temp1) * Convert.ToDouble(temp2);
                        txtWindow.Text = result.ToString();
                    }
                    else if (txtWindow.Text[i] == '+')
                    {
                        result = Convert.ToDouble(temp1) + Convert.ToDouble(temp2);
                        txtWindow.Text = result.ToString();
                    }
                    else if (txtWindow.Text[i] == '-')
                    {
                        result = Convert.ToDouble(temp1) - Convert.ToDouble(temp2);
                        txtWindow.Text = result.ToString();
                    }
                    else if (txtWindow.Text[i] == '%')
                    {
                        result = Convert.ToDouble(temp1) % Convert.ToDouble(temp2);
                        txtWindow.Text = result.ToString();
                    }
                    else if (txtWindow.Text[i] == '^')
                    {
                        result = Math.Pow(Convert.ToDouble(temp1) , Convert.ToDouble(temp2));
                        txtWindow.Text = result.ToString();
                    }
                    checkResult(result);
                }
            }
            activeButtons();
            if(txtWindow.Text.Contains('.'))
            {
                btnDot.Enabled = false;
            }
            counter = 0;
        }
        private double calculateFactorial(double num)
        {
            double result = 1;
            for(int i=1;i<=num;i++)
            {
                result *= i;
            }
            return result;
        }
        double num = 0;
        private void btnFactor_Click(object sender, EventArgs e)
        {
            num=Convert.ToDouble(txtWindow.Text);
            checkResult(num);
            txtWindow.Text=calculateFactorial(num).ToString();
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            num=txtWindow.Text == "" ? 0:Convert.ToDouble(txtWindow.Text);
            checkResult(num);
            txtWindow.Text = Math.Sin(num*Math.PI/180).ToString();
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            num = txtWindow.Text == "" ? 0 : Convert.ToDouble(txtWindow.Text);
            checkResult(num);
            txtWindow.Text = Math.Cos(num * Math.PI / 180).ToString();
        }

        private void btnAbs_Click(object sender, EventArgs e)
        {
            num = txtWindow.Text == "" ? 0 : Convert.ToDouble(txtWindow.Text);
            num = num < 0 ? num * -1 : num;
            checkResult(num);
            txtWindow.Text = num.ToString();
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            num = txtWindow.Text == "" ? 0 : Convert.ToDouble(txtWindow.Text);
            checkResult(num);
            txtWindow.Text = Math.Tan(num * Math.PI / 180).ToString();
        }
        private void btnCot_Click(object sender, EventArgs e)
        {
            num = txtWindow.Text == "" ? 0 : Convert.ToDouble(txtWindow.Text);
            checkResult(num);
            txtWindow.Text = (1 / Math.Tan(num * Math.PI / 180)).ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(txtWindow.Text!="")
            {
                if (!(txtWindow.Text[txtWindow.Text.Length - 1] - 48 >= 0 && txtWindow.Text[txtWindow.Text.Length - 1] - 48 <= 9))
                {
                    activeButtons();
                }
                txtWindow.Text = txtWindow.Text.Substring(0, txtWindow.Text.Length - 1);
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtWindow.Text += ".";
            inActiveButtons();
        }
    }
}
