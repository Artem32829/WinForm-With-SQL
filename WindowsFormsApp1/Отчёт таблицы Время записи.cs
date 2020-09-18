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
    public partial class Отчёт_таблицы_Время_записи : Form
    {
        public Отчёт_таблицы_Время_записи()
        {
            InitializeComponent();
        }

        private void Отчёт_таблицы_Время_записи_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "отчеты.Отчет_Время_записи". При необходимости она может быть перемещена или удалена.
            this.отчет_Время_записиTableAdapter.Fill(this.отчеты.Отчет_Время_записи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ФильмыDataSet.Время_записи". При необходимости она может быть перемещена или удалена.
            this.Время_записиTableAdapter.Fill(this.ФильмыDataSet.Время_записи);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
