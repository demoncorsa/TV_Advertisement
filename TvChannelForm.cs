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
    }
}
