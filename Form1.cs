using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TV_Advertisement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Клиент-серверное приложение:\n" + "''Учет рекламных роликов на телеканалах''\n" + "Разработчик: Валиев Иван, к46п");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                AdversForm f = new AdversForm();
                f.Show();
            }
            if (checkBox2.Checked == true)
            {
                TvChannelForm ff = new TvChannelForm();
                ff.Show();
            }

        }

    }
}
