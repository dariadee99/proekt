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
    public partial class Сохранение : Form
    {
        public Сохранение()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Добавление spr = new Добавление();
            spr.Show();
            this.Hide();
        }
    }
}
