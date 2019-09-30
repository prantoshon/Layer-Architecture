using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AssignmentOfDatabase.BLL;
namespace AssignmentOfDatabase
{
    public partial class OrderUi : Form
    {
        public OrderUi()
        {
            InitializeComponent();
        }

        OrderManager _orderManager = new OrderManager();
     


       

    


   


      



        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(priceTextBox.Text))
            {
                MessageBox.Show("Price is Empty");
                return;
            }

            if (string.IsNullOrEmpty(quantityTextBox.Text))
            {
                MessageBox.Show("Quanity is Empty");
                return;
            }

            if (_orderManager.AddOrder( itemNameTextBox.Text,priceTextBox.Text, quantityTextBox.Text)) 
            {
                MessageBox.Show("Saved");
                displayDataGridView.DataSource = _orderManager.ShowAllInformation();
                orderIdTextBox.Clear();
                itemNameTextBox.Clear();
                priceTextBox.Clear();
                quantityTextBox.Clear();

            }
        }

        private void customerPageButton_Click(object sender, EventArgs e)
        {
            CustomerUi customerUi = new CustomerUi();
            customerUi.Show();
            this.Hide();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            displayDataGridView.DataSource = _orderManager.ShowAllInformation();
        }

        private void itemUIButton_Click(object sender, EventArgs e)
        {
            ItemUI itemUi = new ItemUI();
            itemUi.Show();
            this.Hide();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(orderIdTextBox.Text))
            {
                MessageBox.Show("Id is Empty");
                return;
            }
            if (_orderManager.DeleteData(orderIdTextBox.Text))
            {
                MessageBox.Show("Deleted");
                displayDataGridView.DataSource = _orderManager.ShowAllInformation();
                orderIdTextBox.Clear();
                itemNameTextBox.Clear();
                priceTextBox.Clear();
                quantityTextBox.Clear();

            }
            else 
            {
                MessageBox.Show("Not Deleted");
            }
        }

        private void upadteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(orderIdTextBox.Text))
            {
                MessageBox.Show("Id is Empty");
                return;
            }
            if (_orderManager.UpdateInformation(itemNameTextBox.Text, priceTextBox.Text, quantityTextBox.Text, orderIdTextBox.Text))
            {
                MessageBox.Show("Update");
                displayDataGridView.DataSource = _orderManager.ShowAllInformation();
                orderIdTextBox.Clear();
                itemNameTextBox.Clear();
                priceTextBox.Clear();
                quantityTextBox.Clear();
            }
            else 
            {
                MessageBox.Show("Not Update");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchNameTextBox.Text))
            {
                MessageBox.Show("Name is Empty");
                return;
            }

            displayDataGridView.DataSource = _orderManager.SearchInformation(searchNameTextBox.Text);
            searchNameTextBox.Clear();
        }

        private void OrderUi_Load(object sender, EventArgs e)
        {

        }
    }
}
