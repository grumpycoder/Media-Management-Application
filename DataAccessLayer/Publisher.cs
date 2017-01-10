using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Publisher
    {
       
        public Int32 Prefix { get; set; }
        public String FirstName { get; set; }
        public String MiddleName { get; set; }
        public String LastName { get; set; }
        public Int32 Suffix { get; set; }
        public String PublicationCompany { get; set; }
        public String Department { get; set; }
        public String Address1 { get; set; }
        public String Address2 { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public String PostalCode { get; set; }
        public String PhoneNumber { get; set; }
        public String Website { get; set; }
        public String EmailAddress { get; set; }

        public void AddPublisher(int prefix, string firstName, string middleName, string lastName, int suffix, string publicationCompany, string department,
                                 string address1, string address2, string city, string state, string postalCode,string phoneNumber, string website,
                                 string emailAddress)
        {
            //create a connection.
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlMediaConnection"].ConnectionString);

            // creating a command object.
            SqlCommand sqlCommand = new SqlCommand("Media.p_addPublisher", sqlConnection);

            // connects the command object with the sql connection.
            sqlCommand.Connection = sqlConnection;

            // set the values for the command object.
            sqlCommand.Parameters.Add("Prefix", SqlDbType.Int);
            sqlCommand.Parameters["Prefix"].Value = Prefix;

            sqlCommand.Parameters.Add("FirstName", SqlDbType.VarChar, 256);
            sqlCommand.Parameters["FirstName"].Value = FirstName;

            sqlCommand.Parameters.Add("MiddleName", SqlDbType.VarChar, 256);
            sqlCommand.Parameters["MiddleName"].Value = MiddleName;

            sqlCommand.Parameters.Add("LastName", SqlDbType.VarChar, 256);
            sqlCommand.Parameters["LastName"].Value = LastName;

            sqlCommand.Parameters.Add("Suffix", SqlDbType.Int);
            sqlCommand.Parameters["Suffix"].Value = Suffix;

            sqlCommand.Parameters.Add("PublicationCompany", SqlDbType.VarChar, 256);
            sqlCommand.Parameters["PublicationCompany"].Value = PublicationCompany;

            sqlCommand.Parameters.Add("Department", SqlDbType.VarChar, 256);
            sqlCommand.Parameters["Department"].Value = Department;

            sqlCommand.Parameters.Add("Address1", SqlDbType.VarChar, 100);
            sqlCommand.Parameters["Address1"].Value = Address1;

            sqlCommand.Parameters.Add("Address2", SqlDbType.VarChar, 100);
            sqlCommand.Parameters["Address2"].Value = Address2;

            sqlCommand.Parameters.Add("City", SqlDbType.VarChar, 256);
            sqlCommand.Parameters["City"].Value = City;

            sqlCommand.Parameters.Add("State", SqlDbType.Int);
            sqlCommand.Parameters["State"].Value = State;

            sqlCommand.Parameters.Add("PostalCode", SqlDbType.Char, 5);
            sqlCommand.Parameters["PostalCode"].Value = PostalCode;

            sqlCommand.Parameters.Add("PhoneNumber", SqlDbType.VarChar, 11);
            sqlCommand.Parameters["PhoneNumber"].Value = PhoneNumber;

            sqlCommand.Parameters.Add("Website", SqlDbType.VarChar, 150);
            sqlCommand.Parameters["Website"].Value = Website;

            sqlCommand.Parameters.Add("EmailAddress", SqlDbType.VarChar, 70);
            sqlCommand.Parameters["EmailAddress"].Value = EmailAddress;

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
        } // end of method  

        public void GetPublisher(string lastName )
        {
            //create a connection.
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlMediaConnection"].ConnectionString);

            // creating a command object.
            SqlCommand sqlCommand = new SqlCommand("Media.p_getPublisher", sqlConnection);

            // connects the command object with the sql connection.
            sqlCommand.Connection = sqlConnection;

            
            
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
         public void UpdatePublisher(string name)
        {
            //create a connection.
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlMediaConnection"].ConnectionString);

            // creating a command object.
            SqlCommand sqlCommand = new SqlCommand("p_updPublisher", sqlConnection);

            // connects the command object with the sql connection.
            sqlCommand.Connection = sqlConnection;

            // we want to update the publisher's file to keep the his or her information as possible.


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
} // end of namespace
