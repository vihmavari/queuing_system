using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW_SMO
{
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            ClientSize = new Size(600, 600);
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void start_Load(object sender, EventArgs e)
        {
            
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("HELLO !!!\n\n");

            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0
                && numericUpDown1.Value > 0 && numericUpDown2.Value > 0 && numericUpDown3.Value > 0 && numericUpDown4.Value > 0)
            {
                double min, max, lambda;
                try
                {
                    min = Convert.ToDouble(this.textBox1.Text);
                    max = Convert.ToDouble(this.textBox2.Text);
                    lambda = Convert.ToDouble(this.textBox3.Text);

                    if (min > max)
                    {
                        MessageBox.Show("Некорректный ввод: max < min", "Error", MessageBoxButtons.OK);
                        return;
                    }

                }
                catch
                {
                    MessageBox.Show("Некорректный ввод: ошибка при преобразовании строк в double", "Error", MessageBoxButtons.OK);
                    return;
                }

                Input input = new Input(Convert.ToInt32(numericUpDown1.Value),
                                        Convert.ToInt32(numericUpDown2.Value),
                                        Convert.ToInt32(numericUpDown3.Value),
                                        Convert.ToInt32(numericUpDown4.Value),
                                        min,
                                        max,
                                        lambda);

                step_mode stepModeForm = new step_mode();
                stepModeForm.FormClosing += delegate { this.Show(); };
                Hide();
                stepModeForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Введите все параметры", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
