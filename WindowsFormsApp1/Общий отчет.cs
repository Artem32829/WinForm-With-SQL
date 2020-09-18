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
    public partial class Общий_отчет : Form
    {
        public Общий_отчет()
        {
            InitializeComponent();
        }

        private void Общий_отчет_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ФильмыDataSet1.Общий_отчет". При необходимости она может быть перемещена или удалена.
            this.Общий_отчетTableAdapter.Fill(this.ФильмыDataSet1.Общий_отчет);

            this.reportViewer1.RefreshReport();
        }
    }
}
