using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace УчебнаяПрактика1
{
    public partial class raspisanie : Form
    {
        public raspisanie()
        {
            InitializeComponent();
        }

        private void raspisanie_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "учётDataSet.Grafik". При необходимости она может быть перемещена или удалена.
            this.grafikTableAdapter.Fill(this.учётDataSet.Grafik);

        }
    }
}
