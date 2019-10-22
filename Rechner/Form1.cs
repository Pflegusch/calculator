using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Rechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operations solution = new Operations();

            if ((nenner1.Text == null || nenner2.Text == null || zähler2.Text == null || zähler1.Text == null)) {
                resultBox.AppendText("Die Eingabefelder sind nicht alle voll!"); 
            }

            double x1 = Convert.ToDouble(nenner1.Text);
            double x2 = Convert.ToDouble(nenner2.Text);
            double y1 = Convert.ToDouble(zähler1.Text);
            double y2 = Convert.ToDouble(zähler2.Text);

            if (listBox1.Text == null)
            {
                resultBox.AppendText("Operation fehlt"); 
            } else if (listBox1.GetItemText(listBox1.SelectedItem).Contains("+")) {
                resultBox.AppendText(solution.addition(x1, x2, y1, y2).ToString() + "\n");
            }
            else if (listBox1.GetItemText(listBox1.SelectedItem).Contains("x"))
            {
                resultBox.AppendText(solution.multiplication(x1, x2, y1, y2).ToString() + "\n");
            }
            else if (listBox1.GetItemText(listBox1.SelectedItem).Contains("-"))
            {
                resultBox.AppendText(solution.subtraction(x1, x2, y1, y2).ToString() + "\n");
            }
            else if (listBox1.GetItemText(listBox1.SelectedItem).Contains("/"))
            {
                resultBox.AppendText(solution.division(x1, x2, y1, y2).ToString() + "\n");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nenner1.Text = ""; 
            nenner2.Text = ""; 
            zähler1.Text = ""; 
            zähler2.Text = "";
            resultBox.Text = "Result: \n"; 
        }

        private void resultBox_TextChanged(object sender, EventArgs e)
        {
            resultBox.SelectionStart = resultBox.Text.Length;
            resultBox.ScrollToCaret();
        }
    }
}
