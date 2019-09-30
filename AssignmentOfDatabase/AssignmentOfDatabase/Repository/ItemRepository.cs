using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOfDatabase.Repository
{
    public class ItemRepository
    {
        bool isAdded;
        public bool AddItem(string name , double price )
        {
            //bool isAdded;


            //try
          //  {
                //Conncetion
                string conncetionString = @"Server=DESKTOP-QREDJ0M; DATABASE=MyDataBase; Integrated Security=TRUE";
                SqlConnection sqlConnection = new SqlConnection(conncetionString);

                //sqlquery
                string commandString = "INSERT INTO Items(ItemName, ItemPrice) VALUES('" + name + "','" + price + "')";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Excution
                sqlConnection.Open();

                int isExcuted = sqlCommand.ExecuteNonQuery();
                if (isExcuted > 0)
                {
                    isAdded = true;
                }

          //  }

          //  catch (Exception ex) 
           // {
              
           // }
            return isAdded;
        }




        public bool IsNameExist(string name )
        {
            bool nameExist = false;

         //   try
           // {
                string conncetion = @"Server=DESKTOP-QREDJ0M; DATABASE=MyDataBase; Integrated Security=TRUE";
                SqlConnection sqlConncetion = new SqlConnection(conncetion);

                string command = "SELECT * FROM Items Where ItemName = '" +name+ "'";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConncetion);

                sqlConncetion.Open();
                SqlDataAdapter sqlDataAdapater = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapater.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    nameExist = true;
                }

                sqlConncetion.Close();
           // }
         //   catch (Exception ex)
           // {
               // MessageBox.Show(ex.Message);

           // }
            return nameExist;

        }


        public bool DeleteData(string id)
        {
          // bool   isDelete = false;
           // try
           // {
                //conncention
                string conncetion = @"Server=DESKTOP-QREDJ0M; DATABASE=MyDataBase;Integrated Security=TRUE";
                SqlConnection sqlConncetion = new SqlConnection(conncetion);

                //command
                string command = "DELETE FROM Items WHERE Id =" + id + "";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConncetion);

                //excute 
                sqlConncetion.Open();
                int isExcuted = sqlCommand.ExecuteNonQuery();
                if (isExcuted > 0)
                {

                    return true;
                }
                else
                {
                   // MessageBox.Show("Not Deleted");
                }
                sqlConncetion.Close();

           // }
         //   catch (Exception ex)
         //   {
                     // MessageBox.Show(ex.Message);
       
         //   }
            return false;
        }

        public DataTable ShowAllInformation()
        {

           // try
          //  {
                //conncetion
                string conncetion = @"Server=DESKTOP-QREDJ0M; DATABASE= MyDataBase; Integrated Security=TRUE";
                SqlConnection sqlConncetion = new SqlConnection(conncetion);

                //command
                string command = "SELECT *FROM Items";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConncetion);

                //excute
                sqlConncetion.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                //show
               /* if (dataTable.Rows.Count > 0)
                {

                    /*displayDataGridView.DataSource = dataTable;
                    idTextBox.Clear();
                    itemNameTextBox.Clear();
                    itemPriceTextBox.Clear();
                    return true;
                }
                else
                {

                  //  MessageBox.Show("Data Empty");
                }*/
                sqlConncetion.Close();
                return dataTable;
            //}
           // catch (Exception ex)
            //{
              //  MessageBox.Show(ex.Message);
            //}



        }



        public bool UpdateInformation(string name , string price , string id)
        {
           // try
           // {
                //conncetion
                string conncetion = @"Server=DESKTOP-QREDJ0M; DATABASE=MyDataBase; Integrated Security=TRUE";
                SqlConnection sqlConncetion = new SqlConnection(conncetion);

                //command
                string command = "UPDATE Items  SET ItemName ='" +name + "' , ItemPrice ='" +price + "' WHERE Id ='" + id + "'";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConncetion);

                //Exute
                sqlConncetion.Open();
                int isExcuted = sqlCommand.ExecuteNonQuery();
                if (isExcuted > 0)
                {
                  return true;
                }
                else
                {
                 // MessageBox.Show("Not Upadated");
                }
                return false;
                sqlConncetion.Close();
            //}
           // catch (Exception ex)
          //  {
                //MessageBox.Show(ex.Message);
          //  }


        }


        public DataTable SeachInformation(string name)
        {

            //try
          //  {
                string conncetion = @"Server=DESKTOP-QREDJ0M; DATABASE=MyDataBase; Integrated Security=TRUE";
                SqlConnection sqlConncetion = new SqlConnection(conncetion);

                string command = "SELECT * FROM Items Where ItemName = '" + name + "'";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConncetion);

                sqlConncetion.Open();
                SqlDataAdapter sqlDataAdapater = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapater.Fill(dataTable);

              //  if (dataTable.Rows.Count > 0)
               // {
                 //   return true;
               // }
                return dataTable;
            
        }
    }
}
