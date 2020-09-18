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
    public partial class Отчёт_таблицы_Актёры : Form
    {
        public Отчёт_таблицы_Актёры()
        {
            InitializeComponent();
        }

        private void Отчёт_таблицы_Актёры_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ФильмыDataSet.Актеры". При необходимости она может быть перемещена или удалена.
            this.АктерыTableAdapter.Fill(this.ФильмыDataSet.Актеры);

            this.reportViewer1.RefreshReport();
        }
    }
}
