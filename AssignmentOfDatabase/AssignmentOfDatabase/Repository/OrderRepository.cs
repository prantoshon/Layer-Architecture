using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOfDatabase.Repository
{
    public class OrderRepository
    {  
           public bool AddOrder(string name , string price , string quantity)
        {


           
                        //Conncetion
                        string conncetionString = @"Server=DESKTOP-QREDJ0M; DATABASE=MyDataBase; Integrated Security=TRUE";
                        SqlConnection sqlConnection = new SqlConnection(conncetionString);

                        //sqlquery
                        string commandString = "INSERT INTO Orders(ItemName, Price, Quanity ) VALUES('" + name + "','" + price + "','"+quantity+"')";
                        SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                        //Excution
                        sqlConnection.Open();

                        int isExcuted = sqlCommand.ExecuteNonQuery();
                        if (isExcuted > 0)
                        {
                           return true;
                        }
                        
                        sqlConnection.Close();
                        return false;
                   
                    
              }


           public DataTable ShowAllInformation()
           {

              
                   //conncetion
                   string conncetion = @"Server=DESKTOP-QREDJ0M; DATABASE= MyDataBase; Integrated Security=TRUE";
                   SqlConnection sqlConncetion = new SqlConnection(conncetion);

                   //command
                   string command = "SELECT *FROM Orders";
                   SqlCommand sqlCommand = new SqlCommand(command, sqlConncetion);

                   //excute
                   sqlConncetion.Open();
                   SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                   DataTable dataTable = new DataTable();
                   sqlDataAdapter.Fill(dataTable);

                   //show
                   
                      
                      
                   
                   
                   sqlConncetion.Close();
                   return dataTable;
              
               }

           public bool DeleteData(string id)
           {
                 //conncention
                   string conncetion = @"Server=DESKTOP-QREDJ0M; DATABASE=MyDataBase;Integrated Security=TRUE";
                   SqlConnection sqlConncetion = new SqlConnection(conncetion);

                   //command
                   string command = "DELETE FROM Orders WHERE OrderId ='" + id+ "'";
                   SqlCommand sqlCommand = new SqlCommand(command, sqlConncetion);

                   //excute 
                   sqlConncetion.Open();
                   int isExcuted = sqlCommand.ExecuteNonQuery();
                   if (isExcuted > 0)
                   {
                       return true;

                   }
              
                   sqlConncetion.Close();
                   return false;
               
              
           }

           public DataTable SearchInformation(string name)
           {

                   string conncetion = @"Server=DESKTOP-QREDJ0M; DATABASE=MyDataBase; Integrated Security=TRUE";
                   SqlConnection sqlConncetion = new SqlConnection(conncetion);

                   string command = "SELECT * FROM Orders Where ItemName = '" + name + "'";
                   SqlCommand sqlCommand = new SqlCommand(command, sqlConncetion);

                   sqlConncetion.Open();
                   SqlDataAdapter sqlDataAdapater = new SqlDataAdapter(sqlCommand);
                   DataTable dataTable = new DataTable();
                   sqlDataAdapater.Fill(dataTable);

                
                   sqlConncetion.Close();
                   return dataTable;
               
              
           }

           public bool UpdateInformation(string name , string price ,string quantity , string id)
           {
               
                   //conncetion
                   string conncetion = @"Server=DESKTOP-QREDJ0M; DATABASE=MyDataBase; Integrated Security=TRUE";
                   SqlConnection sqlConncetion = new SqlConnection(conncetion);

                   //command
                   string command = "UPDATE Orders  SET ItemName ='" + name + "' ,  Price ='" + price+ "' ,Quanity='" + quantity + "' WHERE OrderId ='" + id+ "'";
                   SqlCommand sqlCommand = new SqlCommand(command, sqlConncetion);

                   //Exute
                   sqlConncetion.Open();
                   int isExcuted = sqlCommand.ExecuteNonQuery();
                   if (isExcuted > 0)
                   {
                       return true;
                   }
                   
                   sqlConncetion.Close();
                   return false;


           }




           
    }
}
