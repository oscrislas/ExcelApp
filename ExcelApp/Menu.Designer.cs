
namespace ExcelApp
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.inventoryDataSet = new ExcelApp.inventoryDataSet();
            this.pantallaExcelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pantallaExcelTableAdapter = new ExcelApp.inventoryDataSetTableAdapters.pantallaExcelTableAdapter();
            this.tableAdapterManager = new ExcelApp.inventoryDataSetTableAdapters.TableAdapterManager();
            this.pantallaExcelBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.pantallaExcelBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pantallaExcelDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pantallasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Abrir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableAdapterManager1 = new ExcelApp.inventoryDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.dir = new System.Windows.Forms.TextBox();
            this.seleccion = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pantallaExcelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pantallaExcelBindingNavigator)).BeginInit();
            this.pantallaExcelBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pantallaExcelDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pantallasBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryDataSet
            // 
            this.inventoryDataSet.DataSetName = "inventoryDataSet";
            this.inventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pantallaExcelBindingSource
            // 
            this.pantallaExcelBindingSource.DataMember = "pantallaExcel";
            this.pantallaExcelBindingSource.DataSource = this.inventoryDataSet;
            // 
            // pantallaExcelTableAdapter
            // 
            this.pantallaExcelTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.pantallaExcelTableAdapter = this.pantallaExcelTableAdapter;
            this.tableAdapterManager.UpdateOrder = ExcelApp.inventoryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pantallaExcelBindingNavigator
            // 
            this.pantallaExcelBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pantallaExcelBindingNavigator.AutoSize = false;
            this.pantallaExcelBindingNavigator.BindingSource = this.pantallaExcelBindingSource;
            this.pantallaExcelBindingNavigator.CountItem = null;
            this.pantallaExcelBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pantallaExcelBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.pantallaExcelBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.pantallaExcelBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pantallaExcelBindingNavigatorSaveItem});
            this.pantallaExcelBindingNavigator.Location = new System.Drawing.Point(232, 463);
            this.pantallaExcelBindingNavigator.MoveFirstItem = null;
            this.pantallaExcelBindingNavigator.MoveLastItem = null;
            this.pantallaExcelBindingNavigator.MoveNextItem = null;
            this.pantallaExcelBindingNavigator.MovePreviousItem = null;
            this.pantallaExcelBindingNavigator.Name = "pantallaExcelBindingNavigator";
            this.pantallaExcelBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.pantallaExcelBindingNavigator.PositionItem = null;
            this.pantallaExcelBindingNavigator.Size = new System.Drawing.Size(112, 25);
            this.pantallaExcelBindingNavigator.TabIndex = 0;
            this.pantallaExcelBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // pantallaExcelBindingNavigatorSaveItem
            // 
            this.pantallaExcelBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pantallaExcelBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pantallaExcelBindingNavigatorSaveItem.Image")));
            this.pantallaExcelBindingNavigatorSaveItem.Name = "pantallaExcelBindingNavigatorSaveItem";
            this.pantallaExcelBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 22);
            this.pantallaExcelBindingNavigatorSaveItem.Text = "Save Data";
            this.pantallaExcelBindingNavigatorSaveItem.Click += new System.EventHandler(this.pantallaExcelBindingNavigatorSaveItem_Click);
            // 
            // pantallaExcelDataGridView
            // 
            this.pantallaExcelDataGridView.AllowUserToAddRows = false;
            this.pantallaExcelDataGridView.AllowUserToResizeColumns = false;
            this.pantallaExcelDataGridView.AllowUserToResizeRows = false;
            this.pantallaExcelDataGridView.AutoGenerateColumns = false;
            this.pantallaExcelDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pantallaExcelDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.pantallaExcelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pantallaExcelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.Abrir});
            this.pantallaExcelDataGridView.DataSource = this.pantallaExcelBindingSource;
            this.pantallaExcelDataGridView.Location = new System.Drawing.Point(-3, 0);
            this.pantallaExcelDataGridView.Name = "pantallaExcelDataGridView";
            this.pantallaExcelDataGridView.RowHeadersVisible = false;
            this.pantallaExcelDataGridView.RowHeadersWidth = 62;
            this.pantallaExcelDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pantallaExcelDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pantallaExcelDataGridView.Size = new System.Drawing.Size(718, 418);
            this.pantallaExcelDataGridView.TabIndex = 1;
            this.pantallaExcelDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pantallaExcelDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "link";
            this.dataGridViewTextBoxColumn3.HeaderText = "link";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "sheet";
            this.dataGridViewTextBoxColumn4.HeaderText = "sheet";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "abrir";
            this.dataGridViewTextBoxColumn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewTextBoxColumn5.HeaderText = "abrir";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "fullscream";
            this.dataGridViewTextBoxColumn10.HeaderText = "fullscream";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn10.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "lectura";
            this.dataGridViewTextBoxColumn6.HeaderText = "lectura";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "zoom";
            this.dataGridViewTextBoxColumn7.HeaderText = "zoom";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 50;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "pantalla";
            this.dataGridViewTextBoxColumn8.DataSource = this.pantallasBindingSource;
            this.dataGridViewTextBoxColumn8.DisplayMember = "Text";
            this.dataGridViewTextBoxColumn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewTextBoxColumn8.HeaderText = "pantalla";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn8.ValueMember = "Value";
            this.dataGridViewTextBoxColumn8.Width = 50;
            // 
            // pantallasBindingSource
            // 
            this.pantallasBindingSource.DataSource = typeof(ExcelApp.Pantallas);
            this.pantallasBindingSource.CurrentChanged += new System.EventHandler(this.pantallasBindingSource_CurrentChanged);
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "escritorio";
            this.dataGridViewTextBoxColumn9.DataSource = this.pantallasBindingSource;
            this.dataGridViewTextBoxColumn9.DisplayMember = "Text";
            this.dataGridViewTextBoxColumn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewTextBoxColumn9.HeaderText = "escritorio";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn9.ValueMember = "Value";
            this.dataGridViewTextBoxColumn9.Width = 50;
            // 
            // Abrir
            // 
            this.Abrir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Abrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Abrir.HeaderText = "Abrir";
            this.Abrir.MinimumWidth = 8;
            this.Abrir.Name = "Abrir";
            this.Abrir.Text = "O";
            this.Abrir.UseColumnTextForButtonValue = true;
            this.Abrir.Width = 50;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.pantallaExcelTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = ExcelApp.inventoryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Abrir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(719, 520);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.pantallaExcelDataGridView);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.pantallaExcelBindingNavigator);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(711, 491);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Excel Conf";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 465);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Cerrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.dir);
            this.tabPage2.Controls.Add(this.seleccion);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(711, 491);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Video Conf";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(249, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Reproducir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dir
            // 
            this.dir.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ExcelApp.Properties.Settings.Default, "URL_Video", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dir.Location = new System.Drawing.Point(116, 93);
            this.dir.Name = "dir";
            this.dir.Size = new System.Drawing.Size(357, 23);
            this.dir.TabIndex = 1;
            this.dir.Text = global::ExcelApp.Properties.Settings.Default.URL_Video;
            this.dir.TextChanged += new System.EventHandler(this.dir_TextChanged);
            // 
            // seleccion
            // 
            this.seleccion.Location = new System.Drawing.Point(249, 150);
            this.seleccion.Name = "seleccion";
            this.seleccion.Size = new System.Drawing.Size(75, 23);
            this.seleccion.TabIndex = 0;
            this.seleccion.Text = "Seleccionar";
            this.seleccion.UseVisualStyleBackColor = true;
            this.seleccion.Click += new System.EventHandler(this.seleccion_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(711, 491);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Clock Conf";
            // 
            // Menu
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(720, 519);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "Menu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pantallaExcelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pantallaExcelBindingNavigator)).EndInit();
            this.pantallaExcelBindingNavigator.ResumeLayout(false);
            this.pantallaExcelBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pantallaExcelDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pantallasBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private inventoryDataSet inventoryDataSet;
        private System.Windows.Forms.BindingSource pantallaExcelBindingSource;
        private inventoryDataSetTableAdapters.pantallaExcelTableAdapter pantallaExcelTableAdapter;
        private inventoryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pantallaExcelBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton pantallaExcelBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView pantallaExcelDataGridView;
        private inventoryDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource pantallasBindingSource;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.TextBox dir;
        private System.Windows.Forms.Button seleccion;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewButtonColumn Abrir;
    }
}

