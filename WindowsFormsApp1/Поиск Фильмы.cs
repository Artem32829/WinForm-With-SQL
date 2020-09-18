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
    public partial class Поиск_Фильмы : Form
    {
        public Поиск_Фильмы()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.фильмыprocTableAdapter.Fill(this.dataSet1.Фильмыproc, названиеToolStripTextBox.Text, new System.Nullable<System.TimeSpan>(((System.TimeSpan)(System.Convert.ChangeType(продолжительностьToolStripTextBox.Text, typeof(System.TimeSpan))))), фамилияToolStripTextBox.Text, имяToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Поиск_Фильмы_Load(object sender, EventArgs e)
        {

        }
    }
}
