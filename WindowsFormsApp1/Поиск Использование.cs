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
    public partial class Поиск_Использование : Form
    {
        public Поиск_Использование()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.использованиеprocTableAdapter.Fill(this.dataSet1.Использованиеproc, new System.Nullable<int>(((int)(System.Convert.ChangeType(годToolStripTextBox.Text, typeof(int))))), жанрToolStripTextBox.Text, фильмToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
