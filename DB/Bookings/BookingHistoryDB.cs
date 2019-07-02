using mySQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TravelExpertsFinal.DB.Bookings
{
    public class BookingHistoryDB
    {
        #region GetAllByCustomer
        // retrieve all objects
        public static List<BookingHistory> GetAllByCustomer(int custid)
        {
            // create SELECT command
            string query =
                "SELECT b.BookingId, b.BookingDate, b.BookingNo, b.TravelerCount, b.CustomerId, b.TripTypeId, b.PackageId, " +
                " p.PkgName, p.PkgStartDate, p.PkgEndDate, p.PkgDesc, p.PkgBasePrice, p.PkgImg " +
                " FROM Bookings b  join Packages p on b.PackageId =p.PackageId " +
                " where b.CustomerId=@CustomerId";
            SqlConnection connection = TravelExperts.GetConection();
            List<BookingHistory> dataList = new List<BookingHistory>(); // epmty list
            BookingHistory data; // for reading
                           // create connection

            SqlCommand cmd = new SqlCommand(query, connection);
            // suply perameter value
            cmd.Parameters.AddWithValue("@CustomerId", custid);
            // open the conection
            connection.Open();

            // run the command
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            // build object list to return
            while (reader.Read()) // if there is a object with this ID
            {
                data = new BookingHistory();
                data.BookingId = Convert.ToInt32(reader["BookingId"]);
                data.BookingDate = (DateTime)reader["BookingDate"];
                data.BookingNo = reader["BookingNo"].ToString();
                data.TravelerCount = Convert.ToSingle(reader["TravelerCount"]);
                data.CustomerId = Convert.ToInt32(reader["CustomerId"]);
                data.TripTypeId = reader["TripTypeId"].ToString();
                if (reader["PackageId"].ToString() == "")
                {
                    data.PackageId = null;
                }
                else
                {
                    data.PackageId = Convert.ToInt32(reader["PackageId"].ToString());
                }
                data.PkgName = reader["PkgName"].ToString();
                data.PkgStartDate = (DateTime)reader["PkgStartDate"];
                data.PkgEndDate = (DateTime)reader["PkgEndDate"];
                data.PkgDesc = reader["PkgDesc"].ToString();
                data.PkgBasePrice = Convert.ToDecimal(reader["PkgBasePrice"]);
                data.PkgImg = reader["PkgImg"].ToString();
                dataList.Add(data);
            }

            return dataList;
        }
        #endregion
    }
}