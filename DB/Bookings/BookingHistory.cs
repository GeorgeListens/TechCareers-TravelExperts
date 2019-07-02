using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelExpertsFinal.DB.Bookings
{
    public class BookingHistory
    {
        public BookingHistory() { }
        public int BookingId { get; set; }
        public DateTime? BookingDate { get; set; }
        public string BookingNo { get; set; }
        public float TravelerCount { get; set; }
        public int CustomerId { get; set; }
        public string TripTypeId { get; set; }
        public int? PackageId { get; set; }

        public string PkgName { get; set; }
        public DateTime? PkgStartDate { get; set; }
        public DateTime? PkgEndDate { get; set; }
        public string PkgDesc { get; set; }
        public decimal? PkgBasePrice { get; set; }
        public string PkgImg { get; set; }



        // makes identival copy of Customer
        public BookingHistory Clone()
        {
            BookingHistory copy = new BookingHistory();
            copy.BookingId = this.BookingId;
            copy.BookingDate = this.BookingDate;
            copy.BookingNo = this.BookingNo;
            copy.TravelerCount = this.TravelerCount;
            copy.CustomerId = this.CustomerId;
            copy.TripTypeId = this.TripTypeId;
            copy.PackageId = this.PackageId;
            copy.PkgName = this.PkgName;
            copy.PkgStartDate = this.PkgStartDate;
            copy.PkgEndDate = this.PkgEndDate;
            copy.PkgDesc = this.PkgDesc;
            copy.PkgBasePrice = this.PkgBasePrice;
            copy.PkgImg = this.PkgImg;
            return copy;
        }
    }
}