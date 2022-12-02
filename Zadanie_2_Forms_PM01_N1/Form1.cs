using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Zadanie_2_Forms_PM01_N1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
				try
				{
					int a = 0;
					a = int.Parse(textBox1.Text);
					if ((a < 10 || a > 99) && (a > -10 || a < -99))
					{
						textBox2.Text = string.Format("Число должно быть двузначным.");
						return;
					}
					int b = 0, c = 0;
					b = Math.Abs(a / 10);
					c = Math.Abs(a % 10);
					int Sum = b + c;
					if (Sum % 3 == 0)
					{
						textBox2.Text = string.Format("Сумма цифр {0} кратна трём.", Sum);
					}
					else
					{
						textBox2.Text = string.Format("Сумма цифр {0} не кратна трём.", Sum);
					}
				}
				catch
				{
					textBox2.Text = string.Format("Можно вводить только числа!");
				}
			}
		}
	}
