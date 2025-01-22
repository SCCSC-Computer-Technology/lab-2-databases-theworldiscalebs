namespace ThompsonCPT206DatabasesLab2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cityDetailsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cityDetailsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cityDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.ShowDetatilsBtn = new System.Windows.Forms.Button();
            this.ExtBtn = new System.Windows.Forms.Button();
            this.ASCPopulationBtn = new System.Windows.Forms.Button();
            this.DESCPopulationBtn = new System.Windows.Forms.Button();
            this.SortByCityBtn = new System.Windows.Forms.Button();
            this.AveragePopulationBtn = new System.Windows.Forms.Button();
            this.TotalPopulationBtn = new System.Windows.Forms.Button();
            this.HighestPopulationBtn = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityDetailsDataSet = new ThompsonCPT206DatabasesLab2.CityDetailsDataSet();
            this.cityDetailsTableAdapter = new ThompsonCPT206DatabasesLab2.CityDetailsDataSetTableAdapters.CityDetailsTableAdapter();
            this.tableAdapterManager = new ThompsonCPT206DatabasesLab2.CityDetailsDataSetTableAdapters.TableAdapterManager();
            this.LowestPopulationBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cityDetailsBindingNavigator)).BeginInit();
            this.cityDetailsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityDetailsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityDetailsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cityDetailsBindingNavigator
            // 
            this.cityDetailsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cityDetailsBindingNavigator.BindingSource = this.cityDetailsBindingSource;
            this.cityDetailsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cityDetailsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cityDetailsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cityDetailsBindingNavigatorSaveItem});
            this.cityDetailsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cityDetailsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cityDetailsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cityDetailsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cityDetailsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cityDetailsBindingNavigator.Name = "cityDetailsBindingNavigator";
            this.cityDetailsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cityDetailsBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.cityDetailsBindingNavigator.TabIndex = 0;
            this.cityDetailsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
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
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cityDetailsBindingNavigatorSaveItem
            // 
            this.cityDetailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cityDetailsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cityDetailsBindingNavigatorSaveItem.Image")));
            this.cityDetailsBindingNavigatorSaveItem.Name = "cityDetailsBindingNavigatorSaveItem";
            this.cityDetailsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cityDetailsBindingNavigatorSaveItem.Text = "Save Data";
            this.cityDetailsBindingNavigatorSaveItem.Click += new System.EventHandler(this.cityDetailsBindingNavigatorSaveItem_Click);
            // 
            // cityDetailsDataGridView
            // 
            this.cityDetailsDataGridView.AutoGenerateColumns = false;
            this.cityDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cityDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.cityDetailsDataGridView.DataSource = this.cityDetailsBindingSource;
            this.cityDetailsDataGridView.Location = new System.Drawing.Point(151, 76);
            this.cityDetailsDataGridView.Name = "cityDetailsDataGridView";
            this.cityDetailsDataGridView.Size = new System.Drawing.Size(443, 220);
            this.cityDetailsDataGridView.TabIndex = 1;
            this.toolTip1.SetToolTip(this.cityDetailsDataGridView, "sample database");
            // 
            // ShowDetatilsBtn
            // 
            this.ShowDetatilsBtn.Location = new System.Drawing.Point(151, 302);
            this.ShowDetatilsBtn.Name = "ShowDetatilsBtn";
            this.ShowDetatilsBtn.Size = new System.Drawing.Size(75, 59);
            this.ShowDetatilsBtn.TabIndex = 2;
            this.ShowDetatilsBtn.Text = "Show Details";
            this.toolTip1.SetToolTip(this.ShowDetatilsBtn, "Allows you to see each individual record on the database one by one");
            this.ShowDetatilsBtn.UseVisualStyleBackColor = true;
            this.ShowDetatilsBtn.Click += new System.EventHandler(this.ShowDetatilsBtn_Click);
            // 
            // ExtBtn
            // 
            this.ExtBtn.Location = new System.Drawing.Point(335, 439);
            this.ExtBtn.Name = "ExtBtn";
            this.ExtBtn.Size = new System.Drawing.Size(75, 59);
            this.ExtBtn.TabIndex = 3;
            this.ExtBtn.Text = "Exit";
            this.toolTip1.SetToolTip(this.ExtBtn, "closes the form");
            this.ExtBtn.UseVisualStyleBackColor = true;
            this.ExtBtn.Click += new System.EventHandler(this.ExtBtn_Click);
            // 
            // ASCPopulationBtn
            // 
            this.ASCPopulationBtn.Location = new System.Drawing.Point(257, 303);
            this.ASCPopulationBtn.Name = "ASCPopulationBtn";
            this.ASCPopulationBtn.Size = new System.Drawing.Size(86, 56);
            this.ASCPopulationBtn.TabIndex = 11;
            this.ASCPopulationBtn.Text = "ASC Population";
            this.toolTip1.SetToolTip(this.ASCPopulationBtn, "Displays cities based on ascending population count");
            this.ASCPopulationBtn.UseVisualStyleBackColor = true;
            this.ASCPopulationBtn.Click += new System.EventHandler(this.ASCPopulationBtn_Click);
            // 
            // DESCPopulationBtn
            // 
            this.DESCPopulationBtn.Location = new System.Drawing.Point(392, 305);
            this.DESCPopulationBtn.Name = "DESCPopulationBtn";
            this.DESCPopulationBtn.Size = new System.Drawing.Size(96, 56);
            this.DESCPopulationBtn.TabIndex = 12;
            this.DESCPopulationBtn.Text = "DESC Population";
            this.toolTip1.SetToolTip(this.DESCPopulationBtn, "Displays cities based on descending population count");
            this.DESCPopulationBtn.UseVisualStyleBackColor = true;
            this.DESCPopulationBtn.Click += new System.EventHandler(this.DESCPopulationBtn_Click);
            // 
            // SortByCityBtn
            // 
            this.SortByCityBtn.Location = new System.Drawing.Point(529, 305);
            this.SortByCityBtn.Name = "SortByCityBtn";
            this.SortByCityBtn.Size = new System.Drawing.Size(65, 56);
            this.SortByCityBtn.TabIndex = 13;
            this.SortByCityBtn.Text = "Sort by City";
            this.toolTip1.SetToolTip(this.SortByCityBtn, "Sorts by city in alphabetical order");
            this.SortByCityBtn.UseVisualStyleBackColor = true;
            this.SortByCityBtn.Click += new System.EventHandler(this.SortByCityBtn_Click);
            // 
            // AveragePopulationBtn
            // 
            this.AveragePopulationBtn.Location = new System.Drawing.Point(257, 382);
            this.AveragePopulationBtn.Name = "AveragePopulationBtn";
            this.AveragePopulationBtn.Size = new System.Drawing.Size(75, 51);
            this.AveragePopulationBtn.TabIndex = 14;
            this.AveragePopulationBtn.Text = "Average Population of all Cities";
            this.toolTip1.SetToolTip(this.AveragePopulationBtn, "displays the average off all the cities");
            this.AveragePopulationBtn.UseVisualStyleBackColor = true;
            this.AveragePopulationBtn.Click += new System.EventHandler(this.AveragePopulationBtn_Click);
            // 
            // TotalPopulationBtn
            // 
            this.TotalPopulationBtn.Location = new System.Drawing.Point(151, 382);
            this.TotalPopulationBtn.Name = "TotalPopulationBtn";
            this.TotalPopulationBtn.Size = new System.Drawing.Size(75, 51);
            this.TotalPopulationBtn.TabIndex = 15;
            this.TotalPopulationBtn.Text = "Total Population of all Cities";
            this.toolTip1.SetToolTip(this.TotalPopulationBtn, "displays the Total population of all the cities combined");
            this.TotalPopulationBtn.UseVisualStyleBackColor = true;
            this.TotalPopulationBtn.Click += new System.EventHandler(this.TotalPopulationBtn_Click);
            // 
            // HighestPopulationBtn
            // 
            this.HighestPopulationBtn.Location = new System.Drawing.Point(402, 382);
            this.HighestPopulationBtn.Name = "HighestPopulationBtn";
            this.HighestPopulationBtn.Size = new System.Drawing.Size(75, 51);
            this.HighestPopulationBtn.TabIndex = 16;
            this.HighestPopulationBtn.Text = "Highest Population of all Cities";
            this.toolTip1.SetToolTip(this.HighestPopulationBtn, "displays the city with the highest population");
            this.HighestPopulationBtn.UseVisualStyleBackColor = true;
            this.HighestPopulationBtn.Click += new System.EventHandler(this.HighestPopulation_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CityID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CityID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn2.HeaderText = "City";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "State";
            this.dataGridViewTextBoxColumn3.HeaderText = "State";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Population";
            this.dataGridViewTextBoxColumn4.HeaderText = "Population";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // cityDetailsBindingSource
            // 
            this.cityDetailsBindingSource.DataMember = "CityDetails";
            this.cityDetailsBindingSource.DataSource = this.cityDetailsDataSet;
            // 
            // cityDetailsDataSet
            // 
            this.cityDetailsDataSet.DataSetName = "CityDetailsDataSet";
            this.cityDetailsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cityDetailsTableAdapter
            // 
            this.cityDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CityDetailsTableAdapter = this.cityDetailsTableAdapter;
            this.tableAdapterManager.UpdateOrder = ThompsonCPT206DatabasesLab2.CityDetailsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // LowestPopulationBtn
            // 
            this.LowestPopulationBtn.Location = new System.Drawing.Point(519, 382);
            this.LowestPopulationBtn.Name = "LowestPopulationBtn";
            this.LowestPopulationBtn.Size = new System.Drawing.Size(75, 51);
            this.LowestPopulationBtn.TabIndex = 17;
            this.LowestPopulationBtn.Text = "Lowest Population of all Cities";
            this.toolTip1.SetToolTip(this.LowestPopulationBtn, "displays the city with the lowest population");
            this.LowestPopulationBtn.UseVisualStyleBackColor = true;
            this.LowestPopulationBtn.Click += new System.EventHandler(this.LowestPopulationBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.LowestPopulationBtn);
            this.Controls.Add(this.HighestPopulationBtn);
            this.Controls.Add(this.TotalPopulationBtn);
            this.Controls.Add(this.AveragePopulationBtn);
            this.Controls.Add(this.SortByCityBtn);
            this.Controls.Add(this.DESCPopulationBtn);
            this.Controls.Add(this.ASCPopulationBtn);
            this.Controls.Add(this.ExtBtn);
            this.Controls.Add(this.ShowDetatilsBtn);
            this.Controls.Add(this.cityDetailsDataGridView);
            this.Controls.Add(this.cityDetailsBindingNavigator);
            this.Name = "Form1";
            this.Text = "City Populatioon";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cityDetailsBindingNavigator)).EndInit();
            this.cityDetailsBindingNavigator.ResumeLayout(false);
            this.cityDetailsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityDetailsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityDetailsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CityDetailsDataSet cityDetailsDataSet;
        private System.Windows.Forms.BindingSource cityDetailsBindingSource;
        private CityDetailsDataSetTableAdapters.CityDetailsTableAdapter cityDetailsTableAdapter;
        private CityDetailsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cityDetailsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cityDetailsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView cityDetailsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button ShowDetatilsBtn;
        private System.Windows.Forms.Button ExtBtn;
        private System.Windows.Forms.Button ASCPopulationBtn;
        private System.Windows.Forms.Button DESCPopulationBtn;
        private System.Windows.Forms.Button SortByCityBtn;
        private System.Windows.Forms.Button AveragePopulationBtn;
        private System.Windows.Forms.Button TotalPopulationBtn;
        private System.Windows.Forms.Button HighestPopulationBtn;
        private System.Windows.Forms.Button LowestPopulationBtn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

