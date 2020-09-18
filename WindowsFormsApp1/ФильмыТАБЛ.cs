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
    public partial class ФильмыТАБЛ : Form
    {
        public ФильмыТАБЛ()
        {
            InitializeComponent();
        }

        private void ФильмыТАБЛ_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "фильмыDataSet._Фильм_режиссер". При необходимости она может быть перемещена или удалена.
            this.фильм_режиссерTableAdapter.Fill(this.фильмыDataSet._Фильм_режиссер);

        }
    }
}
