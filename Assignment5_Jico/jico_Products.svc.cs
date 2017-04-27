using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Configuration;
using System.Data.SqlClient;

namespace Assignment5_Jico
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "jico_Products" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select jico_Products.svc or jico_Products.svc.cs at the Solution Explorer and start debugging.
    public class jico_Products : Ijico_Products
    {
        public List<Products> ReturnProduct()
        {
            List<Products> product = new List<Products>();
            string connectionString = WebConfigurationManager.ConnectionStrings["ProductDS"].ConnectionString;
            


            

            SqlConnection con = new SqlConnection(connectionString);


            //create command object

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * from Product";
            cmd.Connection = con;
            
            using (con)
            {
                con.Open(); // open connection
                SqlDataReader reader = cmd.ExecuteReader(); // reading data
                while (reader.Read())
                {
                    Products p = new Products();

                    p.ProductID = (int)reader["ProductID"]; //creating constructor of data
                    p.Name = (string)reader["Name"];

                    product.Add(p); // adding to products List
                    


                }
                return product;
            }
            

            

        }
    }
}
