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
    }
}
