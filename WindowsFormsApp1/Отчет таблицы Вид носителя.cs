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
    public partial class Отчет_таблицы_Вид_носителя : Form
    {
        public Отчет_таблицы_Вид_носителя()
        {
            InitializeComponent();
        }

        private void Отчет_таблицы_Вид_носителя_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ФильмыDataSet.Вид_носителя". При необходимости она может быть перемещена или удалена.
            this.Вид_носителяTableAdapter.Fill(this.ФильмыDataSet.Вид_носителя);

            this.reportViewer1.RefreshReport();
        }
    }
}
