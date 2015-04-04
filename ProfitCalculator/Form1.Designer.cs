namespace ProfitCalculator
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
            System.Windows.Forms.Label productLabel;
            System.Windows.Forms.Label cost_ProductLabel;
            System.Windows.Forms.Label cost_QuantityLabel;
            System.Windows.Forms.Label cost_ShippingLabel;
            System.Windows.Forms.Label sell_PriceLabel;
            System.Windows.Forms.Label sell_ShippingLabel;
            System.Windows.Forms.Label fee_PercentLabel;
            System.Windows.Forms.Label cost_EachLabel;
            System.Windows.Forms.Label fees_EachLabel;
            System.Windows.Forms.Label fees_TotalLabel;
            System.Windows.Forms.Label profit_EachLabel;
            System.Windows.Forms.Label profit_TotalLabel;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.productInfoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.productInfoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.productTextBox = new System.Windows.Forms.TextBox();
            this.txtCostProduct = new System.Windows.Forms.TextBox();
            this.txtCostQuantity = new System.Windows.Forms.TextBox();
            this.txtCostShipping = new System.Windows.Forms.TextBox();
            this.txtSellPrice = new System.Windows.Forms.TextBox();
            this.txtSellShipping = new System.Windows.Forms.TextBox();
            this.txtFeePercent = new System.Windows.Forms.TextBox();
            this.txtCostEach = new System.Windows.Forms.TextBox();
            this.txtFeesEach = new System.Windows.Forms.TextBox();
            this.txtFeesTotal = new System.Windows.Forms.TextBox();
            this.txtProfitEach = new System.Windows.Forms.TextBox();
            this.txtProfitTotal = new System.Windows.Forms.TextBox();
            this.productInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.searchProductToolStrip = new System.Windows.Forms.ToolStrip();
            this.productToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.productToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchProductToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsDataSet = new ProfitCalculator.ProductsDataSet();
            this.productInfoTableAdapter = new ProfitCalculator.ProductsDataSetTableAdapters.ProductInfoTableAdapter();
            this.tableAdapterManager = new ProfitCalculator.ProductsDataSetTableAdapters.TableAdapterManager();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button5 = new System.Windows.Forms.Button();
            productLabel = new System.Windows.Forms.Label();
            cost_ProductLabel = new System.Windows.Forms.Label();
            cost_QuantityLabel = new System.Windows.Forms.Label();
            cost_ShippingLabel = new System.Windows.Forms.Label();
            sell_PriceLabel = new System.Windows.Forms.Label();
            sell_ShippingLabel = new System.Windows.Forms.Label();
            fee_PercentLabel = new System.Windows.Forms.Label();
            cost_EachLabel = new System.Windows.Forms.Label();
            fees_EachLabel = new System.Windows.Forms.Label();
            fees_TotalLabel = new System.Windows.Forms.Label();
            profit_EachLabel = new System.Windows.Forms.Label();
            profit_TotalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productInfoBindingNavigator)).BeginInit();
            this.productInfoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productInfoDataGridView)).BeginInit();
            this.searchProductToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // productInfoBindingNavigator
            // 
            this.productInfoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productInfoBindingNavigator.BindingSource = this.productInfoBindingSource;
            this.productInfoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productInfoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productInfoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.productInfoBindingNavigatorSaveItem});
            this.productInfoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productInfoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productInfoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productInfoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productInfoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productInfoBindingNavigator.Name = "productInfoBindingNavigator";
            this.productInfoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productInfoBindingNavigator.Size = new System.Drawing.Size(1523, 25);
            this.productInfoBindingNavigator.TabIndex = 0;
            this.productInfoBindingNavigator.Text = "bindingNavigator1";
            this.productInfoBindingNavigator.RefreshItems += new System.EventHandler(this.productInfoBindingNavigator_RefreshItems);
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // productInfoBindingNavigatorSaveItem
            // 
            this.productInfoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productInfoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productInfoBindingNavigatorSaveItem.Image")));
            this.productInfoBindingNavigatorSaveItem.Name = "productInfoBindingNavigatorSaveItem";
            this.productInfoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.productInfoBindingNavigatorSaveItem.Text = "Save Data";
            this.productInfoBindingNavigatorSaveItem.Click += new System.EventHandler(this.productInfoBindingNavigatorSaveItem_Click);
            // 
            // productLabel
            // 
            productLabel.AutoSize = true;
            productLabel.Location = new System.Drawing.Point(31, 92);
            productLabel.Name = "productLabel";
            productLabel.Size = new System.Drawing.Size(47, 13);
            productLabel.TabIndex = 1;
            productLabel.Text = "Product:";
            // 
            // productTextBox
            // 
            this.productTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productInfoBindingSource, "Product", true));
            this.productTextBox.Location = new System.Drawing.Point(112, 89);
            this.productTextBox.Name = "productTextBox";
            this.productTextBox.Size = new System.Drawing.Size(100, 20);
            this.productTextBox.TabIndex = 2;
            // 
            // cost_ProductLabel
            // 
            cost_ProductLabel.AutoSize = true;
            cost_ProductLabel.ForeColor = System.Drawing.Color.Red;
            cost_ProductLabel.Location = new System.Drawing.Point(31, 118);
            cost_ProductLabel.Name = "cost_ProductLabel";
            cost_ProductLabel.Size = new System.Drawing.Size(71, 13);
            cost_ProductLabel.TabIndex = 3;
            cost_ProductLabel.Text = "Cost Product:";
            // 
            // txtCostProduct
            // 
            this.txtCostProduct.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productInfoBindingSource, "Cost_Product", true));
            this.txtCostProduct.Location = new System.Drawing.Point(112, 115);
            this.txtCostProduct.Name = "txtCostProduct";
            this.txtCostProduct.Size = new System.Drawing.Size(100, 20);
            this.txtCostProduct.TabIndex = 4;
            // 
            // cost_QuantityLabel
            // 
            cost_QuantityLabel.AutoSize = true;
            cost_QuantityLabel.ForeColor = System.Drawing.Color.Red;
            cost_QuantityLabel.Location = new System.Drawing.Point(31, 144);
            cost_QuantityLabel.Name = "cost_QuantityLabel";
            cost_QuantityLabel.Size = new System.Drawing.Size(49, 13);
            cost_QuantityLabel.TabIndex = 5;
            cost_QuantityLabel.Text = "Quantity:";
            // 
            // txtCostQuantity
            // 
            this.txtCostQuantity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productInfoBindingSource, "Cost_Quantity", true));
            this.txtCostQuantity.Location = new System.Drawing.Point(112, 141);
            this.txtCostQuantity.Name = "txtCostQuantity";
            this.txtCostQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtCostQuantity.TabIndex = 6;
            // 
            // cost_ShippingLabel
            // 
            cost_ShippingLabel.AutoSize = true;
            cost_ShippingLabel.ForeColor = System.Drawing.Color.Red;
            cost_ShippingLabel.Location = new System.Drawing.Point(31, 170);
            cost_ShippingLabel.Name = "cost_ShippingLabel";
            cost_ShippingLabel.Size = new System.Drawing.Size(75, 13);
            cost_ShippingLabel.TabIndex = 7;
            cost_ShippingLabel.Text = "Cost Shipping:";
            // 
            // txtCostShipping
            // 
            this.txtCostShipping.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productInfoBindingSource, "Cost_Shipping", true));
            this.txtCostShipping.Location = new System.Drawing.Point(112, 167);
            this.txtCostShipping.Name = "txtCostShipping";
            this.txtCostShipping.Size = new System.Drawing.Size(100, 20);
            this.txtCostShipping.TabIndex = 8;
            // 
            // sell_PriceLabel
            // 
            sell_PriceLabel.AutoSize = true;
            sell_PriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            sell_PriceLabel.Location = new System.Drawing.Point(31, 196);
            sell_PriceLabel.Name = "sell_PriceLabel";
            sell_PriceLabel.Size = new System.Drawing.Size(54, 13);
            sell_PriceLabel.TabIndex = 9;
            sell_PriceLabel.Text = "Sell Price:";
            // 
            // txtSellPrice
            // 
            this.txtSellPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productInfoBindingSource, "Sell_Price", true));
            this.txtSellPrice.Location = new System.Drawing.Point(112, 193);
            this.txtSellPrice.Name = "txtSellPrice";
            this.txtSellPrice.Size = new System.Drawing.Size(100, 20);
            this.txtSellPrice.TabIndex = 10;
            // 
            // sell_ShippingLabel
            // 
            sell_ShippingLabel.AutoSize = true;
            sell_ShippingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            sell_ShippingLabel.Location = new System.Drawing.Point(31, 222);
            sell_ShippingLabel.Name = "sell_ShippingLabel";
            sell_ShippingLabel.Size = new System.Drawing.Size(71, 13);
            sell_ShippingLabel.TabIndex = 11;
            sell_ShippingLabel.Text = "Sell Shipping:";
            // 
            // txtSellShipping
            // 
            this.txtSellShipping.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productInfoBindingSource, "Sell_Shipping", true));
            this.txtSellShipping.Location = new System.Drawing.Point(112, 219);
            this.txtSellShipping.Name = "txtSellShipping";
            this.txtSellShipping.Size = new System.Drawing.Size(100, 20);
            this.txtSellShipping.TabIndex = 12;
            // 
            // fee_PercentLabel
            // 
            fee_PercentLabel.AutoSize = true;
            fee_PercentLabel.ForeColor = System.Drawing.Color.Red;
            fee_PercentLabel.Location = new System.Drawing.Point(31, 248);
            fee_PercentLabel.Name = "fee_PercentLabel";
            fee_PercentLabel.Size = new System.Drawing.Size(68, 13);
            fee_PercentLabel.TabIndex = 13;
            fee_PercentLabel.Text = "Fee Percent:";
            // 
            // txtFeePercent
            // 
            this.txtFeePercent.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productInfoBindingSource, "Fee_Percent", true));
            this.txtFeePercent.Location = new System.Drawing.Point(112, 245);
            this.txtFeePercent.Name = "txtFeePercent";
            this.txtFeePercent.Size = new System.Drawing.Size(100, 20);
            this.txtFeePercent.TabIndex = 14;
            // 
            // cost_EachLabel
            // 
            cost_EachLabel.AutoSize = true;
            cost_EachLabel.ForeColor = System.Drawing.Color.Red;
            cost_EachLabel.Location = new System.Drawing.Point(31, 335);
            cost_EachLabel.Name = "cost_EachLabel";
            cost_EachLabel.Size = new System.Drawing.Size(59, 13);
            cost_EachLabel.TabIndex = 15;
            cost_EachLabel.Text = "Cost Each:";
            // 
            // txtCostEach
            // 
            this.txtCostEach.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productInfoBindingSource, "Cost_Each", true));
            this.txtCostEach.Enabled = false;
            this.txtCostEach.ForeColor = System.Drawing.Color.Red;
            this.txtCostEach.Location = new System.Drawing.Point(112, 332);
            this.txtCostEach.Name = "txtCostEach";
            this.txtCostEach.Size = new System.Drawing.Size(100, 20);
            this.txtCostEach.TabIndex = 16;
            // 
            // fees_EachLabel
            // 
            fees_EachLabel.AutoSize = true;
            fees_EachLabel.ForeColor = System.Drawing.Color.Red;
            fees_EachLabel.Location = new System.Drawing.Point(31, 361);
            fees_EachLabel.Name = "fees_EachLabel";
            fees_EachLabel.Size = new System.Drawing.Size(61, 13);
            fees_EachLabel.TabIndex = 17;
            fees_EachLabel.Text = "Fees Each:";
            // 
            // txtFeesEach
            // 
            this.txtFeesEach.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productInfoBindingSource, "Fees_Each", true));
            this.txtFeesEach.Enabled = false;
            this.txtFeesEach.ForeColor = System.Drawing.Color.Red;
            this.txtFeesEach.Location = new System.Drawing.Point(112, 358);
            this.txtFeesEach.Name = "txtFeesEach";
            this.txtFeesEach.Size = new System.Drawing.Size(100, 20);
            this.txtFeesEach.TabIndex = 18;
            // 
            // fees_TotalLabel
            // 
            fees_TotalLabel.AutoSize = true;
            fees_TotalLabel.ForeColor = System.Drawing.Color.Red;
            fees_TotalLabel.Location = new System.Drawing.Point(31, 387);
            fees_TotalLabel.Name = "fees_TotalLabel";
            fees_TotalLabel.Size = new System.Drawing.Size(60, 13);
            fees_TotalLabel.TabIndex = 19;
            fees_TotalLabel.Text = "Fees Total:";
            // 
            // txtFeesTotal
            // 
            this.txtFeesTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productInfoBindingSource, "Fees_Total", true));
            this.txtFeesTotal.Enabled = false;
            this.txtFeesTotal.ForeColor = System.Drawing.Color.Red;
            this.txtFeesTotal.Location = new System.Drawing.Point(112, 384);
            this.txtFeesTotal.Name = "txtFeesTotal";
            this.txtFeesTotal.Size = new System.Drawing.Size(100, 20);
            this.txtFeesTotal.TabIndex = 20;
            // 
            // profit_EachLabel
            // 
            profit_EachLabel.AutoSize = true;
            profit_EachLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            profit_EachLabel.Location = new System.Drawing.Point(31, 413);
            profit_EachLabel.Name = "profit_EachLabel";
            profit_EachLabel.Size = new System.Drawing.Size(62, 13);
            profit_EachLabel.TabIndex = 21;
            profit_EachLabel.Text = "Profit Each:";
            // 
            // txtProfitEach
            // 
            this.txtProfitEach.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productInfoBindingSource, "Profit_Each", true));
            this.txtProfitEach.Enabled = false;
            this.txtProfitEach.ForeColor = System.Drawing.Color.Lime;
            this.txtProfitEach.Location = new System.Drawing.Point(112, 410);
            this.txtProfitEach.Name = "txtProfitEach";
            this.txtProfitEach.Size = new System.Drawing.Size(100, 20);
            this.txtProfitEach.TabIndex = 22;
            // 
            // profit_TotalLabel
            // 
            profit_TotalLabel.AutoSize = true;
            profit_TotalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            profit_TotalLabel.Location = new System.Drawing.Point(31, 439);
            profit_TotalLabel.Name = "profit_TotalLabel";
            profit_TotalLabel.Size = new System.Drawing.Size(61, 13);
            profit_TotalLabel.TabIndex = 23;
            profit_TotalLabel.Text = "Profit Total:";
            // 
            // txtProfitTotal
            // 
            this.txtProfitTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productInfoBindingSource, "Profit_Total", true));
            this.txtProfitTotal.Enabled = false;
            this.txtProfitTotal.ForeColor = System.Drawing.Color.Lime;
            this.txtProfitTotal.Location = new System.Drawing.Point(112, 436);
            this.txtProfitTotal.Name = "txtProfitTotal";
            this.txtProfitTotal.Size = new System.Drawing.Size(100, 20);
            this.txtProfitTotal.TabIndex = 24;
            // 
            // productInfoDataGridView
            // 
            this.productInfoDataGridView.AutoGenerateColumns = false;
            this.productInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productInfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.productInfoDataGridView.DataSource = this.productInfoBindingSource;
            this.productInfoDataGridView.Location = new System.Drawing.Point(239, 56);
            this.productInfoDataGridView.Name = "productInfoDataGridView";
            this.productInfoDataGridView.Size = new System.Drawing.Size(1245, 400);
            this.productInfoDataGridView.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Create New Product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(34, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Calculate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(34, 300);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 23);
            this.button3.TabIndex = 28;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(86, 300);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(47, 23);
            this.button4.TabIndex = 29;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(34, 483);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 20);
            this.lblStatus.TabIndex = 30;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // searchProductToolStrip
            // 
            this.searchProductToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.searchProductToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productToolStripLabel,
            this.productToolStripTextBox,
            this.searchProductToolStripButton});
            this.searchProductToolStrip.Location = new System.Drawing.Point(239, 28);
            this.searchProductToolStrip.Name = "searchProductToolStrip";
            this.searchProductToolStrip.Size = new System.Drawing.Size(212, 25);
            this.searchProductToolStrip.TabIndex = 31;
            this.searchProductToolStrip.Text = "searchProductToolStrip";
            this.searchProductToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.searchProductToolStrip_ItemClicked);
            // 
            // productToolStripLabel
            // 
            this.productToolStripLabel.Name = "productToolStripLabel";
            this.productToolStripLabel.Size = new System.Drawing.Size(52, 22);
            this.productToolStripLabel.Text = "Product:";
            // 
            // productToolStripTextBox
            // 
            this.productToolStripTextBox.Name = "productToolStripTextBox";
            this.productToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // searchProductToolStripButton
            // 
            this.searchProductToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchProductToolStripButton.Name = "searchProductToolStripButton";
            this.searchProductToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.searchProductToolStripButton.Text = "Search";
            this.searchProductToolStripButton.Click += new System.EventHandler(this.searchProductToolStripButton_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Product";
            this.dataGridViewTextBoxColumn1.HeaderText = "Product";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cost_Product";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cost_Product";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Cost_Quantity";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cost_Quantity";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cost_Shipping";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cost_Shipping";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Sell_Price";
            this.dataGridViewTextBoxColumn5.HeaderText = "Sell_Price";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Sell_Shipping";
            this.dataGridViewTextBoxColumn6.HeaderText = "Sell_Shipping";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Fee_Percent";
            this.dataGridViewTextBoxColumn7.HeaderText = "Fee_Percent";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Cost_Each";
            this.dataGridViewTextBoxColumn8.HeaderText = "Cost_Each";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Fees_Each";
            this.dataGridViewTextBoxColumn9.HeaderText = "Fees_Each";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Fees_Total";
            this.dataGridViewTextBoxColumn10.HeaderText = "Fees_Total";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Profit_Each";
            this.dataGridViewTextBoxColumn11.HeaderText = "Profit_Each";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Profit_Total";
            this.dataGridViewTextBoxColumn12.HeaderText = "Profit_Total";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // productInfoBindingSource
            // 
            this.productInfoBindingSource.DataMember = "ProductInfo";
            this.productInfoBindingSource.DataSource = this.productsDataSet;
            // 
            // productsDataSet
            // 
            this.productsDataSet.DataSetName = "ProductsDataSet";
            this.productsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productInfoTableAdapter
            // 
            this.productInfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProductInfoTableAdapter = this.productInfoTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProfitCalculator.ProductsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            this.chart1.DataSource = this.productInfoBindingSource;
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(239, 473);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Profit Per Item";
            series5.XValueMember = "Product";
            series5.YValueMembers = "Profit_Each";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(1245, 300);
            this.chart1.TabIndex = 32;
            this.chart1.Text = "chart1";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(139, 300);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(62, 23);
            this.button5.TabIndex = 33;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1523, 822);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.searchProductToolStrip);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.productInfoDataGridView);
            this.Controls.Add(productLabel);
            this.Controls.Add(this.productTextBox);
            this.Controls.Add(cost_ProductLabel);
            this.Controls.Add(this.txtCostProduct);
            this.Controls.Add(cost_QuantityLabel);
            this.Controls.Add(this.txtCostQuantity);
            this.Controls.Add(cost_ShippingLabel);
            this.Controls.Add(this.txtCostShipping);
            this.Controls.Add(sell_PriceLabel);
            this.Controls.Add(this.txtSellPrice);
            this.Controls.Add(sell_ShippingLabel);
            this.Controls.Add(this.txtSellShipping);
            this.Controls.Add(fee_PercentLabel);
            this.Controls.Add(this.txtFeePercent);
            this.Controls.Add(cost_EachLabel);
            this.Controls.Add(this.txtCostEach);
            this.Controls.Add(fees_EachLabel);
            this.Controls.Add(this.txtFeesEach);
            this.Controls.Add(fees_TotalLabel);
            this.Controls.Add(this.txtFeesTotal);
            this.Controls.Add(profit_EachLabel);
            this.Controls.Add(this.txtProfitEach);
            this.Controls.Add(profit_TotalLabel);
            this.Controls.Add(this.txtProfitTotal);
            this.Controls.Add(this.productInfoBindingNavigator);
            this.Name = "Form1";
            this.Text = "ProfitCalculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productInfoBindingNavigator)).EndInit();
            this.productInfoBindingNavigator.ResumeLayout(false);
            this.productInfoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productInfoDataGridView)).EndInit();
            this.searchProductToolStrip.ResumeLayout(false);
            this.searchProductToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProductsDataSet productsDataSet;
        private System.Windows.Forms.BindingSource productInfoBindingSource;
        private ProductsDataSetTableAdapters.ProductInfoTableAdapter productInfoTableAdapter;
        private ProductsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productInfoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton productInfoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox productTextBox;
        private System.Windows.Forms.TextBox txtCostProduct;
        private System.Windows.Forms.TextBox txtCostQuantity;
        private System.Windows.Forms.TextBox txtCostShipping;
        private System.Windows.Forms.TextBox txtSellPrice;
        private System.Windows.Forms.TextBox txtSellShipping;
        private System.Windows.Forms.TextBox txtFeePercent;
        private System.Windows.Forms.TextBox txtCostEach;
        private System.Windows.Forms.TextBox txtFeesEach;
        private System.Windows.Forms.TextBox txtFeesTotal;
        private System.Windows.Forms.TextBox txtProfitEach;
        private System.Windows.Forms.TextBox txtProfitTotal;
        private System.Windows.Forms.DataGridView productInfoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStrip searchProductToolStrip;
        private System.Windows.Forms.ToolStripLabel productToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox productToolStripTextBox;
        private System.Windows.Forms.ToolStripButton searchProductToolStripButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button5;
    }
}

