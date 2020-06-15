using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        //private string prS1;

        private void Form1_Load(object sender, EventArgs e)
        {
            prS1 = Properties.Settings.Default.prS1;  //BackColor - это имя параметра, идет загрузка параметра   
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.BackColor = this.BackColor;//Присваиваем параметру цвет фона формы
            Properties.Settings.Default.Save();//Сохраняем изменения
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textOut.Text += "\n" + prS1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textOut.Text);
        //    string prS1 = Properties.Settings.Default.prS1;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textOut.Clear();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            textOut.Text += "\n" + "Спина не прямая, Отжимаешься, как девочка";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button1.Visible)
            {
                button1.Visible = false;
                textBox1.Visible = true;
                button5.Visible = true;
            }
            else
            {
                button1.Visible = true;
                textBox1.Visible = false;
                button5.Visible = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            prS1 = textBox1.Text;
            button1.Text = textBox1.Text;
            button1.Visible = true;
            textBox1.Visible = false;
            button5.Visible = false;
        }
    }


    }

