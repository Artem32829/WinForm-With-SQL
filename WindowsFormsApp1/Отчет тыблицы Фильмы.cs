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
    public partial class Отчет_тыблицы_Фильмы : Form
    {
        public Отчет_тыблицы_Фильмы()
        {
            InitializeComponent();
        }

        private void Отчет_тыблицы_Фильмы_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Отчеты.Отчет_Фильмы". При необходимости она может быть перемещена или удалена.
            this.Отчет_ФильмыTableAdapter.Fill(this.Отчеты.Отчет_Фильмы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ФильмыDataSet.Фильмы". При необходимости она может быть перемещена или удалена.
            this.ФильмыTableAdapter.Fill(this.ФильмыDataSet.Фильмы);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
