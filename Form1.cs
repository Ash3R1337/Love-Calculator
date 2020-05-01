using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LovaCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name1 = textBox1.Text.ToLower();
            string name2 = textBox2.Text.ToLower();
            Random rnd = new Random();
            if (name1.Length > 1 && name2.Length > 1)
            {

                    MessageBox.Show(
                        name1 + " и " + name2 + ": Совместимость - " + rnd.Next(0, 100) + "%",
                        "Результат",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                MessageBox.Show(
                   "Введите имена",
                   "Ошибка",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error,
                       MessageBoxDefaultButton.Button1,
                       MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string name1 = textBox1.Text.ToLower();
                string name2 = textBox2.Text.ToLower();
                Random rnd = new Random();
                if (name1.Length > 1 && name2.Length > 1)
                { 
                        MessageBox.Show(
                            name1 + " и " + name2 + ": Совместимость - " + rnd.Next(0, 100) + "%",
                            "Результат",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly);
                    
                }
                else
                {
                    MessageBox.Show(
                       "Введите имена",
                       "Ошибка",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error,
                           MessageBoxDefaultButton.Button1,
                           MessageBoxOptions.DefaultDesktopOnly);
                }
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string name1 = textBox1.Text.ToLower();
                string name2 = textBox2.Text.ToLower();
                Random rnd = new Random();
                if (name1.Length > 1 && name2.Length > 1)
                {
                        MessageBox.Show(
                            name1 + " и " + name2 + ": Совместимость - " + rnd.Next(0, 100) + "%",
                            "Результат",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly);
                }
                else
                {
                    MessageBox.Show(
                       "Введите имена",
                       "Ошибка",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error,
                           MessageBoxDefaultButton.Button1,
                           MessageBoxOptions.DefaultDesktopOnly);
                }
            }
        }
    }
}
