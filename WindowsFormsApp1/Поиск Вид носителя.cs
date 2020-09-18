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
    public partial class Поиск_Вид_носителя : Form
    {
        public Поиск_Вид_носителя()
        {
            InitializeComponent();
        }

        private void Поиск_Вид_носителя_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "фильмыDataSet.Вид_носителя". При необходимости она может быть перемещена или удалена.
            this.вид_носителяTableAdapter.Fill(this.фильмыDataSet.Вид_носителя);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.видНосителяBindingSource.Filter = $" Название_Носителя like '%" + textBox1.Text + "%'";
        }
    }
}
