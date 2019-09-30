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
    public partial class ItemUI : Form
    {
       
        
        public ItemUI()
        {
            InitializeComponent();
          
        }

        ManagerItem _mangerItem = new ManagerItem();
    


       


 


       

       

       


        private void addButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(itemNameTextBox.Text))
            {
                if (!string.IsNullOrEmpty(itemPriceTextBox.Text))
                {
                    if (!_mangerItem.IsNameExist(itemNameTextBox.Text))
                        
                    {
                        
                        bool isAdded = _mangerItem.AddItem(itemNameTextBox.Text, Convert.ToDouble(itemPriceTextBox.Text));
                        if (isAdded)
                        {
                            MessageBox.Show("Saved");
                            displayDataGridView.DataSource = _mangerItem.ShowAllInformation();
                        }
                        else 
                        {
                            MessageBox.Show("Not Saved");
                        }
                    }
                    else 
                    {
                        MessageBox.Show(itemNameTextBox  +   "Name Alraedy Exist");
                        return;
                    }
                }
                else 
                {
                    MessageBox.Show("Price is Empty");
                }
            }
            else 
            {
                MessageBox.Show("name is empty");
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            displayDataGridView.DataSource = _mangerItem.ShowAllInformation();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(idTextBox.Text)) 
            {
                MessageBox.Show("Id cant be Empty");
                return;
            }
            string id =(idTextBox.Text);
            if (_mangerItem.DeleteData((id)))
            {
                MessageBox.Show("Deleted");
                displayDataGridView.DataSource = _mangerItem.ShowAllInformation();

            }
            else 
            {
                MessageBox.Show("Not Deleted");
            }

        }

        private void upadteButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(idTextBox.Text)) 
            {
                MessageBox.Show("Id Cant be Empty");

                return;
            }

            if (_mangerItem.UpdateInformation(itemNameTextBox.Text, itemPriceTextBox.Text,idTextBox.Text))
            {
                MessageBox.Show("Updated");
                displayDataGridView.DataSource = _mangerItem.ShowAllInformation();
            }
            else 
            {
                MessageBox.Show("Not Updated");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(searchNameTextBox.Text))
            {
                MessageBox.Show("Name Cant be Empty");

                return;
            }
        
                displayDataGridView.DataSource = _mangerItem.SeachInformation(searchNameTextBox.Text);

            
        }

        private void customerUIButton_Click(object sender, EventArgs e)
        {

           
            CustomerUi customerUi = new CustomerUi();
            customerUi.Show();
            this.Hide();
            
           
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            OrderUi orderUi = new OrderUi();
            orderUi.Show();
            this.Hide();
        }

        private void ItemUI_Load(object sender, EventArgs e)
        {

        }
    }
}
