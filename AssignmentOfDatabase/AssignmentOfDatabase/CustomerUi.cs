﻿using System;
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
    public partial class CustomerUi : Form
    {
        CustomerManager _customerManager = new CustomerManager();

        public CustomerUi()
        {
            InitializeComponent();

        }

        private void CustomerUi_Load(object sender, EventArgs e)
        {
           
        }

        private void itemUIButton_Click(object sender, EventArgs e)
        {
            ItemUI itemUi = new ItemUI();
            itemUi.Show();
            this.Hide();
        }



    

       


  

 

    



        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text)) 
            {
                MessageBox.Show("Name is Empty");
                return;
            }
            if (string.IsNullOrEmpty(addressTextBox.Text))
            {
                MessageBox.Show("Address is Empty");
                return;
            }

            if (string.IsNullOrEmpty(numberTextBox.Text))
            {
                MessageBox.Show("Number is Empty");
                return;
            }

            if (_customerManager.NameExist(nameTextBox.Text)) 
            {
                MessageBox.Show("Name is Already use");
                return;
            }

            if (_customerManager.AddCustomer(nameTextBox.Text, addressTextBox.Text, numberTextBox.Text))
            {
                MessageBox.Show("Saved");
                displayDataGridView.DataSource = _customerManager.ShowAllInformation();
                customerIdTextBox.Clear();
                nameTextBox.Clear();
                addressTextBox.Clear();
                numberTextBox.Clear();
            }
            else 
            {
                MessageBox.Show("Not Saved");
            }

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            displayDataGridView.DataSource = _customerManager.ShowAllInformation();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(customerIdTextBox.Text))
            {
                MessageBox.Show("Id is Empty");
                return;
            }
            if (_customerManager.DeleteData(customerIdTextBox.Text))
            {
                MessageBox.Show("Deleted");
                displayDataGridView.DataSource = _customerManager.ShowAllInformation();
                customerIdTextBox.Clear();
                nameTextBox.Clear();
                addressTextBox.Clear();
                numberTextBox.Clear();
            }
            else 
            {
                MessageBox.Show("Id Not Find");
                return;
            }
        }

        private void upadteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(customerIdTextBox.Text))
            {
                MessageBox.Show("Id is Empty");
                return;
            }
            if (_customerManager.UpdateInformation(nameTextBox.Text, addressTextBox.Text, numberTextBox.Text, customerIdTextBox.Text)) 
            {
                MessageBox.Show("Updated");
                displayDataGridView.DataSource = _customerManager.ShowAllInformation();
                customerIdTextBox.Clear();
                nameTextBox.Clear();
                addressTextBox.Clear();
                numberTextBox.Clear();
             
            }
            else
            {
                MessageBox.Show("Id Not Find");
                return;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchNameTextBox.Text))
            {
                MessageBox.Show("Name is Empty");
                return;
            }

            displayDataGridView.DataSource = _customerManager.SeachInformation(searchNameTextBox.Text);
        }

        private void orderPageButton_Click(object sender, EventArgs e)
        {
            OrderUi orderUi = new OrderUi();
            orderUi.Show();
            this.Hide();
        }




    }
}
