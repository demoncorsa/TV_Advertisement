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
    public partial class TvChannelForm : Form
    {
        public TvChannelForm()
        {
            InitializeComponent();
        }

        private void tV_ChannelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tV_ChannelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_AdvertisementDataSet1);

        }

        private void TvChannelForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_AdvertisementDataSet1.TV_Channel". При необходимости она может быть перемещена или удалена.
            this.tV_ChannelTableAdapter.Fill(this.dB_AdvertisementDataSet1.TV_Channel);

        }

        private void tV_ChannelDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null)
            {
                MessageBox.Show("Неверный тип введенных данных или пустое поле!");
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                for (int i = 0; i < tV_ChannelDataGridView.Rows.Count - 1; i++)
                {
                    if (tV_ChannelDataGridView[1, i].Value.ToString().TrimEnd(' ') == textBox1.Text)
                    {
                        MessageBox.Show("Телеканал: " + textBox1.Text + " найден!");
                        break;
                    }
                }
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
