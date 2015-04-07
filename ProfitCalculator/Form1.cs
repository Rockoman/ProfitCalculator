using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ProfitCalculator
{
    public partial class Form1 : Form
    {
        int count = 0;
        CultureInfo us = new CultureInfo("en-US");


        public Form1()
        {
            InitializeComponent();
        }

        private void productInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.productsDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productsDataSet.ProductInfo' table. You can move, or remove it, as needed.
            this.productInfoTableAdapter.Fill(this.productsDataSet.ProductInfo);
            //start timer
            timer1.Start();

        }

       //add a new row to the database
        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Update();
            chart1.DataBind();
            try
            {
                this.productInfoBindingSource.AddNew();
            }
            catch
            {
                this.Validate();
                this.tableAdapterManager.UpdateAll(this.productsDataSet);
            }
        }

        //update data
        private void button3_Click(object sender, EventArgs e)
        {
            chart1.Update();
            chart1.DataBind();
            try
            {
                this.Validate();
                this.productInfoBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.productsDataSet);
            }
            catch
            {
                MessageBox.Show("Please enter a product name.");
            }
            
        }

        //remove a row from the database
        private void button4_Click(object sender, EventArgs e)
        {
            this.productInfoBindingSource.RemoveCurrent();
        }

        private void productInfoBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //assign number of rows to count
            count = productInfoBindingSource.Count;
            //display count on the status label
            if (count == 1)
                lblStatus.Text = "There is 1 product.";
            else
                lblStatus.Text = "There are " + count.ToString() + " products.";
        }

        private void searchProductToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productInfoTableAdapter.SearchProduct(this.productsDataSet.ProductInfo, productToolStripTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void searchProductToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //convert textboxes to numeric values
            double pricePer = Double.Parse(txtCostProduct.Text);
            double shipCosts = Double.Parse(txtCostShipping.Text);
            double sellPrice = Double.Parse(txtSellPrice.Text);
            double estimateShip = Double.Parse(txtSellShipping.Text);
            int quantity = Int32.Parse(txtCostQuantity.Text);
            double fees = Double.Parse(txtFeePercent.Text);
            //convert fee
            double newFee = fees / 100;

            //calculate price of each product after shipping
            double priceAfterShip = (pricePer * quantity + shipCosts) / quantity;
            //calculate fees per each product
            double feePer = (newFee * sellPrice);
            //calculate total fees
            double totalFees = feePer * quantity;
            //calculate profit per product
            double profitPer = sellPrice - feePer - priceAfterShip - estimateShip;
            //calculate total profit
            double totalProfit = profitPer * quantity;


            
            //display values in textboxes
            txtCostProduct.Text = pricePer.ToString("C", us);
            txtCostShipping.Text = shipCosts.ToString("C", us);
            txtSellPrice.Text = sellPrice.ToString("C", us);
            txtSellShipping.Text = estimateShip.ToString("C", us);
            txtFeePercent.Text = fees.ToString();
            txtCostEach.Text = priceAfterShip.ToString("C", us);
            txtFeesEach.Text = feePer.ToString("C", us);
            txtFeesTotal.Text = totalFees.ToString("C", us);
            txtProfitEach.Text = profitPer.ToString("C", us);
            txtProfitTotal.Text = totalProfit.ToString("C", us);

            //update chart with new information
            chart1.Update();
            chart1.DataBind();


        }
    }
}
