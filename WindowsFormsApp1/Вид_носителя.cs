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
    public partial class Вид_носителя : Form
    {
        public Вид_носителя()
        {
            InitializeComponent();
        }

        private void вид_носителяBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.вид_носителяBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.фильмыDataSet);

        }

        private void Вид_носителя_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "фильмыDataSet.Вид_носителя". При необходимости она может быть перемещена или удалена.
            this.вид_носителяTableAdapter.Fill(this.фильмыDataSet.Вид_носителя);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.вид_носителяBindingSource.MoveFirst();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.вид_носителяBindingSource.MoveLast();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.вид_носителяBindingSource.MoveNext();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.вид_носителяBindingSource.MovePrevious();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.вид_носителяBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.вид_носителяBindingSource.RemoveCurrent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.вид_носителяBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.фильмыDataSet);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Отчет_таблицы_Вид_носителя v1 = new Отчет_таблицы_Вид_носителя();
            v1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Поиск_Вид_носителя v2 = new Поиск_Вид_носителя();
            v2.Show();
        }
    }
}
