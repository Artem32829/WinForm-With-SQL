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
    public partial class Главная : Form
    {
        public Главная()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Актёры v1 = new Актёры();
            v1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Вид_носителя v2 = new Вид_носителя();
            v2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Время_записи v3 = new Время_записи();
            v3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Время_съемки v4 = new Время_съемки();
            v4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Жанры v5 = new Жанры();
            v5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Использование v6 = new Использование();
            v6.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Носитель v7 = new Носитель();
            v7.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
           Режиссёры v8 = new Режиссёры();
            v8.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Фильмы v9 = new Фильмы();
            v9.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Общий_отчет v10 = new Общий_отчет();
            v10.Show();
        }
    }
}
