using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mySQL.Packages
{
    public class PackagesDB
    {
        #region GetValue
        // retrieve object with given ID
        public static Packages GetValue(int objID)
        {
            Packages obj = null;

            // create connection
            SqlConnection connection = TravelExperts.GetConection();

            // create SELECT command
            string query =
                "SELECT PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission " +
                "FROM Packages " +
                "WHERE PackageId = @PackageId ";
            SqlCommand cmd = new SqlCommand(query, connection);
            // suply perameter value
            cmd.Parameters.AddWithValue("@PackageId", objID);

            // run the SELECT query
            try
            {
                // open the conection
                connection.Open();

                // run the command
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);

                // build object object to return
                if (reader.Read()) // if there is a object with this ID
                {
                    obj = new Packages();
                    obj.PackageId = Convert.ToInt32(reader["PackageId"]);
                    obj.PkgName = reader["PkgName"].ToString();
                    obj.PkgStartDate = (DateTime)reader["PkgStartDate"];
                    obj.PkgEndDate = (DateTime)reader["PkgEndDate"];
                    obj.PkgDesc = reader["PkgDesc"].ToString();
                    obj.PkgBasePrice = Convert.ToDecimal(reader["PkgBasePrice"]);
                    obj.PkgAgencyCommission = Convert.ToDecimal(reader["PkgAgencyCommission"]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally // executes always
            {
                connection.Close();
            }

            return obj;
        }
        #endregion

        #region GetAll
        // retrieve all objects
        public static List<Packages> GetAll()
        {
            // create SELECT command
            string query =
                "SELECT PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice/*, PkgAgencyCommission*/ " +
                "FROM Packages ";
            SqlConnection connection = TravelExperts.GetConection();
            List<Packages> dataList = new List<Packages>(); // epmty list
            Packages data; // for reading
                            // create connection



            SqlCommand cmd = new SqlCommand(query, connection);
            // open the conection
            connection.Open();

            // run the command
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            // build object list to return
            while (reader.Read()) // if there is a object with this ID
            {
                data = new Packages();
                data.PackageId = Convert.ToInt32(reader["PackageId"]);
                data.PkgName = reader["PkgName"].ToString();
                data.PkgStartDate = (DateTime)reader["PkgStartDate"];
                data.PkgEndDate = (DateTime)reader["PkgEndDate"];
                data.PkgDesc = reader["PkgDesc"].ToString();
                data.PkgBasePrice = Convert.ToDecimal(reader["PkgBasePrice"]);
                //data.PkgAgencyCommission = Convert.ToDecimal(reader["PkgAgencyCommission"]);
                dataList.Add(data);
            }

            return dataList;
        }
        #endregion

        #region Add
        // insert new row to table
        // return new object
        public static int Add(Packages obj)
        {
            int custID = 0;

            // create connection
            SqlConnection connection = TravelExperts.GetConection();

            // create INSERT command
            // CustomerID is IDENTITY so no value provided
            string insertStatment =
                "INSERT INTO Packages(PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission) " +
                "OUTPUT inserted.[PackageId] " +
                "VALUES(@PackageId, @PkgName, @PkgStartDate, @PkgEndDate, @PkgDesc, @PkgBasePrice, @PkgAgencyCommission) ";
            SqlCommand cmd = new SqlCommand(insertStatment, connection);
            // suply perameter value
            cmd.Parameters.AddWithValue("@PackageId", obj.PackageId);
            cmd.Parameters.AddWithValue("@PkgName", obj.PkgName);
            cmd.Parameters.AddWithValue("@PkgStartDate", obj.PkgStartDate);
            cmd.Parameters.AddWithValue("@PkgEndDate", obj.PkgEndDate);
            cmd.Parameters.AddWithValue("@PkgDesc", obj.PkgDesc);
            cmd.Parameters.AddWithValue("@PkgBasePrice", obj.PkgBasePrice);
            cmd.Parameters.AddWithValue("@PkgAgencyCommission", obj.PkgAgencyCommission);

            // execute the INSERT command
            try
            {
                // open the conection
                connection.Open();

                // execute insert command
                custID = (int)cmd.ExecuteScalar();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally // executes always
            {
                connection.Close();
            }
            // retrieve generated customer nID to return
            return custID;
        }
        #endregion

        #region Delete
        // Delete object
        // return indicator of success
        public static bool Delete(Packages obj)
        {
            bool success = false;

            // create connection
            SqlConnection connection = TravelExperts.GetConection();

            // create DELETE command
            string deleteStatment =
                "DELETE FROM Packages " +
                "WHERE PackageId = @PackageId " + // needed for identification of object
                "AND PkgName = @PkgName " + // the rest - for optimistic concurrency
                "AND PkgStartDate = @PkgStartDate " +
                "AND PkgEndDate = @PkgEndDate " +
                "AND PkgDesc = @PkgDesc " +
                "AND PkgBasePrice = @PkgBasePrice " +
                "AND PkgAgencyCommission = @PkgAgencyCommission ";
            SqlCommand cmd = new SqlCommand(deleteStatment, connection);
            // suply perameter value
            cmd.Parameters.AddWithValue("@PackageId", obj.PackageId);
            cmd.Parameters.AddWithValue("@PkgName", obj.PkgName);
            cmd.Parameters.AddWithValue("@PkgStartDate", obj.PkgStartDate);
            cmd.Parameters.AddWithValue("@PkgEndDate", obj.PkgEndDate);
            cmd.Parameters.AddWithValue("@PkgDesc", obj.PkgDesc);
            cmd.Parameters.AddWithValue("@PkgBasePrice", obj.PkgBasePrice);
            cmd.Parameters.AddWithValue("@PkgAgencyCommission", obj.PkgAgencyCommission);

            // execute the command
            try
            {
                // open the conection
                connection.Open();

                // execute the command
                int count = cmd.ExecuteNonQuery();

                // check if successful
                if (count > 0) success = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally // executes always
            {
                connection.Close();
            }

            // retrieve generated customer nID to return
            return success;
        }
        #endregion

        #region Update
        // Update object
        // return indicator of success
        public static bool Update(Packages oldObj, Packages newObj)
        {
            bool success = false; // did not update

            // create connection
            SqlConnection connection = TravelExperts.GetConection();

            // create UPDATE command
            string updateStatment =
                "UPDATE Packages SET " +
                "PackageId = @NewPackageId, " +
                "PkgName = @NewPkgName, " +
                "PkgStartDate = @NewPkgStartDate, " +
                "PkgEndDate = @NewPkgEndDate, " +
                "PkgDesc = @NewPkgDesc, " +
                "PkgBasePrice = @NewPkgBasePrice, " +
                "PkgAgencyCommission = @NewPkgAgencyCommission " +
                "WHERE PackageId = @OldPackageId " + // identifies
                "AND PkgName = @OldPkgName " + // the rest - for optimistic concurrency
                "AND PkgStartDate = @OldPkgStartDate " +
                "AND PkgEndDate = @OldPkgEndDate " +
                "AND PkgDesc = @OldPkgDesc " +
                "AND PkgBasePrice = @OldPkgBasePrice " +
                "AND PkgAgencyCommission = @OldPkgAgencyCommission ";
            SqlCommand cmd = new SqlCommand(updateStatment, connection);
            // suply perameter value

            // New object Values
            cmd.Parameters.AddWithValue("@NewPackageId", newObj.PackageId);
            cmd.Parameters.AddWithValue("@NewPkgName", newObj.PkgName);
            cmd.Parameters.AddWithValue("@NewPkgStartDate", newObj.PkgStartDate);
            cmd.Parameters.AddWithValue("@NewPkgEndDate", newObj.PkgEndDate);
            cmd.Parameters.AddWithValue("@NewPkgDesc", newObj.PkgDesc);
            cmd.Parameters.AddWithValue("@NewPkgBasePrice", newObj.PkgBasePrice);
            cmd.Parameters.AddWithValue("@NewPkgAgencyCommission", newObj.PkgAgencyCommission);
            // ID
            cmd.Parameters.AddWithValue("@OldPackageId", oldObj.PackageId);
            // Old object Values
            cmd.Parameters.AddWithValue("@OldPkgName", oldObj.PkgName);
            cmd.Parameters.AddWithValue("@OldPkgStartDate", oldObj.PkgStartDate);
            cmd.Parameters.AddWithValue("@OldPkgEndDate", oldObj.PkgEndDate);
            cmd.Parameters.AddWithValue("@OldPkgDesc", oldObj.PkgDesc);
            cmd.Parameters.AddWithValue("@OldPkgBasePrice", oldObj.PkgBasePrice);
            cmd.Parameters.AddWithValue("@OldPkgAgencyCommission", oldObj.PkgAgencyCommission);

            // execute the UPDATE command
            try
            {
                // open the conection
                connection.Open();

                // execute the command
                int count = cmd.ExecuteNonQuery();

                // check if successful
                if (count > 0) success = true; // updated

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally // executes always
            {
                connection.Close();
            }
            // retrieve generated object ID to return
            return success;
        }
        #endregion

        // Get one package
        public static Packages GetPackage(int PackageID)
        {
            Packages package = null;

            // create connection
            SqlConnection connection = TravelExperts.GetConection();

            // create SELECT command
            string query = "SELECT PackageID, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission " +
                       "FROM Packages WHERE PackageID = @PackageID";

            SqlCommand cmd = new SqlCommand(query, connection);
            // supply parameter value
            cmd.Parameters.AddWithValue("@PackageID", PackageID);

            // run the SELECT query
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);

                // build customer object to return
                if (reader.Read()) // if there is a customer with this ID
                {
                    package = new Packages();

                    package.PackageId = (int)reader["PackageID"]; // Primary Key and thus not null
                    package.PkgName = reader["PkgName"].ToString();
                    package.PkgStartDate = (DateTime)reader["PkgStartDate"];
                    package.PkgEndDate = (DateTime)reader["PkgEndDate"];
                    package.PkgDesc = reader["PkgDesc"].ToString();
                    package.PkgBasePrice = (decimal)reader["PkgBasePrice"];
                    package.PkgAgencyCommission = (decimal)reader["PkgAgencyCommission"];

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return package;
        }

    }
}
