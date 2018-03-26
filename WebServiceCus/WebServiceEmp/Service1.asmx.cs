using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebServiceEmp.Model;

namespace WebServiceEmp
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {

        [WebMethod]
        public int Insert(Customer Cus)
        {
            int result = 0;
            try
            {


                string con = ConfigurationManager.ConnectionStrings["Store"].ConnectionString;
                SqlConnection connection = new SqlConnection(con);
                string sql = "insert into Customer (CID,CName,Addresss,City,PinCode,Country,phone_Number,Email)values(" + Cus.CID + ",'" + Cus.CName + "','" + Cus.Addresss + "','" + Cus.City + "','" + Cus.PinCode + "','" + Cus.Country + "',"+Cus.phone_Number+",'"+Cus.Email+"')";
                
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Connection.Open();
                result = cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {

            }
            return result;
        }

        [WebMethod]
        public int Update(Customer Cus, int id)
        {
            int result = 0;
            try
            {


                string con = ConfigurationManager.ConnectionStrings["Store"].ConnectionString;
                SqlConnection connection = new SqlConnection(con);
                string sql = string.Format("Update Customer set CID={0},CName='{1}',Addresss='{2}',City='{3}',PinCode='{4}',Country='{5}',phone_Number={6},Email='{7}' where CID={8}",
                    Cus.CID, Cus.CName, Cus.Addresss, Cus.City, Cus.PinCode,Cus.Country,Cus.phone_Number,Cus.Email, id);
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Connection.Open();
                result = cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {

            }
            return result;
        }

        [WebMethod]
        public int Delete(int contactd)
        {
            string con = ConfigurationManager.ConnectionStrings["Store"].ConnectionString;
            SqlConnection connection = new SqlConnection(con);
            string sql = string.Format(" delete from Customer  where CID= " + contactd);

            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.Connection.Open();
            int x = cmd.ExecuteNonQuery();
            connection.Close();
            return x;

        }
        [WebMethod]
        public Customer Search(int id)
        {
            Customer Cus = new Customer();
            try
            {


                // Employee emp = new Employee();
                string con = ConfigurationManager.ConnectionStrings["Store"].ConnectionString;
                SqlConnection connection = new SqlConnection(con);
                string sql = "Select * from Customer where CID = " + id;
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Cus.CID = int.Parse(reader["CID"].ToString());
                        Cus.CName = reader["CName"].ToString();
                        Cus.Addresss = reader["Addresss"].ToString();
                        Cus.City = reader["City"].ToString();
                        Cus.PinCode = reader["PinCode"].ToString();
                        Cus.Country = reader["Country"].ToString();
                        Cus.phone_Number = int.Parse(reader["phone_Number"].ToString());
                        Cus.Email = reader["Email"].ToString();

                    }

                }
                connection.Close();
            }
            catch (Exception ex)
            {

            }
            return Cus;
        }
    }
}