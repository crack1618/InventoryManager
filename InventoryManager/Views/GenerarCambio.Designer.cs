namespace InventoryManager.Views
{
    partial class GenerarCambio
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblproducto = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.barcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xibitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iMDBProductoDataSet = new InventoryManager.IMDBProductoDataSet();
            this.productoTableAdapter = new InventoryManager.IMDBProductoDataSetTableAdapters.ProductoTableAdapter();
            this.searchChangeToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.inputToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.inputToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.typeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.typeToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchChangeToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMDBProductoDataSet)).BeginInit();
            this.searchChangeToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cambiar de:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bodega a Exhibición",
            "Exhibición a Bodega"});
            this.comboBox1.Location = new System.Drawing.Point(33, 272);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Producto:";
            // 
            // lblproducto
            // 
            this.lblproducto.AutoSize = true;
            this.lblproducto.Location = new System.Drawing.Point(98, 27);
            this.lblproducto.Name = "lblproducto";
            this.lblproducto.Size = new System.Drawing.Size(107, 13);
            this.lblproducto.TabIndex = 3;
            this.lblproducto.Text = "Nombre del Producto";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barcodeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.xibitDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(31, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(689, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cantidad:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(306, 272);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 7;
            // 
            // barcodeDataGridViewTextBoxColumn
            // 
            this.barcodeDataGridViewTextBoxColumn.DataPropertyName = "barcode";
            this.barcodeDataGridViewTextBoxColumn.HeaderText = "Código";
            this.barcodeDataGridViewTextBoxColumn.Name = "barcodeDataGridViewTextBoxColumn";
            this.barcodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.barcodeDataGridViewTextBoxColumn.Width = 75;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 300;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Precio Unitario";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 90;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "# Bodega";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockDataGridViewTextBoxColumn.Width = 90;
            // 
            // xibitDataGridViewTextBoxColumn
            // 
            this.xibitDataGridViewTextBoxColumn.DataPropertyName = "xibit";
            this.xibitDataGridViewTextBoxColumn.HeaderText = "# Exhibición";
            this.xibitDataGridViewTextBoxColumn.Name = "xibitDataGridViewTextBoxColumn";
            this.xibitDataGridViewTextBoxColumn.ReadOnly = true;
            this.xibitDataGridViewTextBoxColumn.Width = 90;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.iMDBProductoDataSet;
            // 
            // iMDBProductoDataSet
            // 
            this.iMDBProductoDataSet.DataSetName = "IMDBProductoDataSet";
            this.iMDBProductoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // searchChangeToolStrip1
            // 
            this.searchChangeToolStrip1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchChangeToolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.searchChangeToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputToolStripLabel,
            this.inputToolStripTextBox,
            this.typeToolStripLabel,
            this.typeToolStripTextBox,
            this.searchChangeToolStripButton});
            this.searchChangeToolStrip1.Location = new System.Drawing.Point(33, 53);
            this.searchChangeToolStrip1.Name = "searchChangeToolStrip1";
            this.searchChangeToolStrip1.Size = new System.Drawing.Size(546, 25);
            this.searchChangeToolStrip1.TabIndex = 8;
            this.searchChangeToolStrip1.Text = "searchChangeToolStrip1";
            // 
            // inputToolStripLabel
            // 
            this.inputToolStripLabel.Name = "inputToolStripLabel";
            this.inputToolStripLabel.Size = new System.Drawing.Size(102, 22);
            this.inputToolStripLabel.Text = "Código/Descripción:";
            // 
            // inputToolStripTextBox
            // 
            this.inputToolStripTextBox.Name = "inputToolStripTextBox1";
            this.inputToolStripTextBox.Size = new System.Drawing.Size(250, 25);
            // 
            // typeToolStripLabel
            // 
            this.typeToolStripLabel.Name = "typeToolStripLabel";
            this.typeToolStripLabel.Size = new System.Drawing.Size(57, 22);
            this.typeToolStripLabel.Text = "Producto: ";
            // 
            // typeToolStripTextBox
            // 
            this.typeToolStripTextBox.Enabled = false;
            this.typeToolStripTextBox.Name = "typeToolStripTextBox";
            this.typeToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // searchChangeToolStripButton
            // 
            this.searchChangeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.searchChangeToolStripButton.Image = global::InventoryManager.Properties.Resources.buscar;
            this.searchChangeToolStripButton.Name = "searchChangeToolStripButton";
            this.searchChangeToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.searchChangeToolStripButton.Click += new System.EventHandler(this.searchChangeToolStripButton_Click_1);
            // 
            // GenerarCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 375);
            this.Controls.Add(this.searchChangeToolStrip1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblproducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "GenerarCambio";
            this.Text = "Generar Cambio";
            this.Load += new System.EventHandler(this.GenerarCambio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMDBProductoDataSet)).EndInit();
            this.searchChangeToolStrip1.ResumeLayout(false);
            this.searchChangeToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblproducto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private IMDBProductoDataSet iMDBProductoDataSet;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private IMDBProductoDataSetTableAdapters.ProductoTableAdapter productoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xibitDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ToolStrip searchChangeToolStrip1;
        private System.Windows.Forms.ToolStripLabel inputToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox inputToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel typeToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox typeToolStripTextBox;
        private System.Windows.Forms.ToolStripButton searchChangeToolStripButton;
    }
}