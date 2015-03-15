namespace TV_Advertisement
{
    partial class TvChannelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TvChannelForm));
            this.dB_AdvertisementDataSet1 = new TV_Advertisement.DB_AdvertisementDataSet1();
            this.tV_ChannelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tV_ChannelTableAdapter = new TV_Advertisement.DB_AdvertisementDataSet1TableAdapters.TV_ChannelTableAdapter();
            this.tableAdapterManager = new TV_Advertisement.DB_AdvertisementDataSet1TableAdapters.TableAdapterManager();
            this.tV_ChannelBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tV_ChannelBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tV_ChannelDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dB_AdvertisementDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tV_ChannelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tV_ChannelBindingNavigator)).BeginInit();
            this.tV_ChannelBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tV_ChannelDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dB_AdvertisementDataSet1
            // 
            this.dB_AdvertisementDataSet1.DataSetName = "DB_AdvertisementDataSet1";
            this.dB_AdvertisementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tV_ChannelBindingSource
            // 
            this.tV_ChannelBindingSource.DataMember = "TV_Channel";
            this.tV_ChannelBindingSource.DataSource = this.dB_AdvertisementDataSet1;
            // 
            // tV_ChannelTableAdapter
            // 
            this.tV_ChannelTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Adv_SegmentTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TV_ChannelTableAdapter = this.tV_ChannelTableAdapter;
            this.tableAdapterManager.UpdateOrder = TV_Advertisement.DB_AdvertisementDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tV_ChannelBindingNavigator
            // 
            this.tV_ChannelBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tV_ChannelBindingNavigator.BindingSource = this.tV_ChannelBindingSource;
            this.tV_ChannelBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tV_ChannelBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tV_ChannelBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tV_ChannelBindingNavigatorSaveItem});
            this.tV_ChannelBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tV_ChannelBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tV_ChannelBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tV_ChannelBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tV_ChannelBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tV_ChannelBindingNavigator.Name = "tV_ChannelBindingNavigator";
            this.tV_ChannelBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tV_ChannelBindingNavigator.Size = new System.Drawing.Size(549, 25);
            this.tV_ChannelBindingNavigator.TabIndex = 0;
            this.tV_ChannelBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tV_ChannelBindingNavigatorSaveItem
            // 
            this.tV_ChannelBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tV_ChannelBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tV_ChannelBindingNavigatorSaveItem.Image")));
            this.tV_ChannelBindingNavigatorSaveItem.Name = "tV_ChannelBindingNavigatorSaveItem";
            this.tV_ChannelBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tV_ChannelBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.tV_ChannelBindingNavigatorSaveItem.Click += new System.EventHandler(this.tV_ChannelBindingNavigatorSaveItem_Click);
            // 
            // tV_ChannelDataGridView
            // 
            this.tV_ChannelDataGridView.AutoGenerateColumns = false;
            this.tV_ChannelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tV_ChannelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tV_ChannelDataGridView.DataSource = this.tV_ChannelBindingSource;
            this.tV_ChannelDataGridView.Location = new System.Drawing.Point(0, 28);
            this.tV_ChannelDataGridView.Name = "tV_ChannelDataGridView";
            this.tV_ChannelDataGridView.Size = new System.Drawing.Size(537, 220);
            this.tV_ChannelDataGridView.TabIndex = 1;
            this.tV_ChannelDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.tV_ChannelDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 41;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Second_Cost";
            this.dataGridViewTextBoxColumn3.HeaderText = "Стоимость секунды";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Viewers_MaxValue_Month";
            this.dataGridViewTextBoxColumn4.HeaderText = "Макс. кол-во зрителей за месяц";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(289, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Поиск по названию";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // TvChannelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 256);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tV_ChannelDataGridView);
            this.Controls.Add(this.tV_ChannelBindingNavigator);
            this.MaximizeBox = false;
            this.Name = "TvChannelForm";
            this.Text = "База данных телеканалов";
            this.Load += new System.EventHandler(this.TvChannelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_AdvertisementDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tV_ChannelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tV_ChannelBindingNavigator)).EndInit();
            this.tV_ChannelBindingNavigator.ResumeLayout(false);
            this.tV_ChannelBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tV_ChannelDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_AdvertisementDataSet1 dB_AdvertisementDataSet1;
        private System.Windows.Forms.BindingSource tV_ChannelBindingSource;
        private DB_AdvertisementDataSet1TableAdapters.TV_ChannelTableAdapter tV_ChannelTableAdapter;
        private DB_AdvertisementDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tV_ChannelBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tV_ChannelBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tV_ChannelDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox textBox1;
    }
}