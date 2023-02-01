using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Переделанные_проекты_с_VB
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyUp += new KeyEventHandler(this.textBox1_TextChanged);
            this.Text = "Закон Ома";
           

        }
        public void Calculate()
        {
            float I, U, R;//ток, напряжение, сопротивление
            if (radioButton1.Checked == true)
            {
                //ток
                U = float.Parse(textBox1.Text);
                R= float.Parse(textBox2.Text);
                if (R != 0)
                {
                    I = U / R;
                    label4.Text = string.Format("Ток: {0:f2} A", I);
                }
                else
                        label4.Text = string.Format("Сопротивление не должно быть равно нулю");
                
            }
            if (radioButton2.Checked == true)
            {
                //напряжение
                I = float.Parse(textBox1.Text);
                R = float.Parse(textBox2.Text);
                U = I * R;
                label4.Text = string.Format("Напряжение: {0:f2} B", U);

            }
            if (radioButton3.Checked == true)
            {
                //сопротивление
                U = float.Parse(textBox1.Text);
                I = float.Parse(textBox2.Text);
                if (I != 0)
                {
                   R=U/I;
                    label4.Text = string.Format("Сопротивление: {0:f2} Ом", R);
                }
                else
                    label4.Text = string.Format("Ток не должнен быть равен нулю");

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") & (textBox2.Text != "")) Calculate();
            else label4.Text = "Нужно ввести исходные данные в оба поля";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Напряжение (Вольт):";
            label3.Text = "Сопротивление (Ом):";
            label4.Text = "";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Ток (Ампер):";
            label3.Text = "Сопротивление (Ом):";
            label4.Text = "";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Напряжение (Вольт):";
            label3.Text = "Ток (Ампер):";
            label4.Text = "";
        }

        private void textBox1_TextChanged(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                textBox2.Focus();
                textBox2_TextChanged(sender, e);
            }
        }

        private void textBox2_TextChanged(object sender, KeyEventArgs e)
        {
            if (textBox2.Text != "")
                button1.Focus();
        }
    }
}

