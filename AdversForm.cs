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
    public partial class AdversForm : Form
    {
        public AdversForm()
        {
            InitializeComponent();
        }

        private void adv_SegmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.adv_SegmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_AdvertisementDataSet1);

        }

        private void AdversForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_AdvertisementDataSet1.Adv_Segment". При необходимости она может быть перемещена или удалена.
            this.adv_SegmentTableAdapter.Fill(this.dB_AdvertisementDataSet1.Adv_Segment);

        }

        private void adv_SegmentDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
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
                for (int i = 0; i < adv_SegmentDataGridView.Rows.Count - 1; i++)
                {
                    if (adv_SegmentDataGridView[1, i].Value.ToString().TrimEnd(' ') == textBox1.Text)
                    {
                        MessageBox.Show("Рекламный ролик: " +  textBox1.Text + " найден!");
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
