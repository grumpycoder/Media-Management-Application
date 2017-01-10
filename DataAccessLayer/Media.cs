using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Media
    {
        public String Isbn { get; set; }
        public String MediaTitle { get; set; }
        public DateTime ReceiptDate { get; set; }
        public Boolean Purchased { get; set; }
        public Boolean Active { get; set; }
        public Boolean Donated { get; set; }
        public String Publisher { get; set; }
       
        
     
        public void AddMedia(string isbn, string title, DateTime receiptDate,Boolean purchased,Boolean active,Boolean donated, string publisher)
        {
            //create a connection.
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlMediaConnection"].ConnectionString);

            // creating a command object.
            SqlCommand sqlCommand = new SqlCommand("p_addMedia",sqlConnection);

            // connects the command object with the sql connection.
            sqlCommand.Connection = sqlConnection;

            // set the values for the command object.
            sqlCommand.Parameters.Add("ISBN", SqlDbType.VarChar, 13);
            sqlCommand.Parameters["ISBN"].Value = Isbn;

            sqlCommand.Parameters.Add("Title",SqlDbType.VarChar,140);
            sqlCommand.Parameters["Title"].Value = MediaTitle;

            sqlCommand.Parameters.Add("ReceiptDate",SqlDbType.DateTime);
            sqlCommand.Parameters["ReceiptDate"].Value = ReceiptDate;

            sqlCommand.Parameters.Add("Purchased",SqlDbType.Bit);
            sqlCommand.Parameters["Purchased"].Value = Purchased;

            sqlCommand.Parameters.Add("MediaStatusID", SqlDbType.Int);
            sqlCommand.Parameters["MediaStatusID"].Value = Active;

            sqlCommand.Parameters.Add("Donated", SqlDbType.Bit);
            sqlCommand.Parameters["Donated"].Value = Donated;

            sqlCommand.Parameters.Add("PublisherID", SqlDbType.Int);
            sqlCommand.Parameters["PublisherID"].Value = Publisher;

           try
            {
                sqlCommand.Connection.Open();
                // execute the stored procedures.
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                //may want catch an exception that involves complicaion with an integer value being convert to a string value.

            }
            finally
            {
                sqlCommand.Connection.Close();
            }  
        } // end of method 

        public void GetMedia(string isbn, string mediaTitle)
        {
            //create a connection.
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlMediaConnection"].ConnectionString);

            // creating a command object.
            SqlCommand sqlCommand = new SqlCommand("p_getMedia", sqlConnection);

            // connects the command object with the sql connection.
            sqlCommand.Connection = sqlConnection;

            // we want to pull the publisher out of the datatbase by any part of their name.


           try
            {
                sqlCommand.Connection.Open();
                // execute the stored procedures.
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                // may want to catch a general exception 

            }
            finally
            {
                sqlCommand.Connection.Close();
            } 

        } 
       public void UpdateMedia(string isbn, string mediaTitle)
        {
            //create a connection.
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlMediaConnection"].ConnectionString);

            // creating a command object.
            SqlCommand sqlCommand = new SqlCommand("p_updMedia", sqlConnection);

            // connects the command object with the sql connection.
            sqlCommand.Connection = sqlConnection;

            // we want to pull the publisher out of the datatbase by any part of their name.


            try
            {
                sqlCommand.Connection.Open();
                // execute the stored procedures.
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                // may want to catch a general exception 

            }
            finally
            {
                sqlCommand.Connection.Close();
            } 

        } 
    } // end of class
} //end of namespace
