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
    public partial class Поиск_Время_записи : Form
    {
        public Поиск_Время_записи()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.времяЗаписиprocTableAdapter.Fill(this.dataSet1.ВремяЗаписиproc, new System.Nullable<int>(((int)(System.Convert.ChangeType(годToolStripTextBox.Text, typeof(int))))), фильмToolStripTextBox.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(памятьToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
