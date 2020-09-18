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
    public partial class Поиск_Жанры : Form
    {
        public Поиск_Жанры()
        {
            InitializeComponent();
        }

        private void Поиск_Жанры_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "фильмыDataSet.Жанры". При необходимости она может быть перемещена или удалена.
            this.жанрыTableAdapter.Fill(this.фильмыDataSet.Жанры);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.жанрыBindingSource.Filter = $" Название_жанра like '%" + textBox1.Text + "%'";
        }
    }
}
