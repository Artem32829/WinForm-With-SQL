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
    public partial class ИспользованиеТАБЛ : Form
    {
        public ИспользованиеТАБЛ()
        {
            InitializeComponent();
        }

        private void ИспользованиеТАБЛ_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "фильмыDataSet._Жанр_фильм_год_использования". При необходимости она может быть перемещена или удалена.
            this.жанр_фильм_год_использованияTableAdapter.Fill(this.фильмыDataSet._Жанр_фильм_год_использования);

        }
    }
}
