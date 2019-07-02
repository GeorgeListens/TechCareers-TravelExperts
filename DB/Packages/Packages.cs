using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mySQL.Packages
{
    public class Packages
    {
        public Packages() { }

        public int PackageId { get; set; }
        public string PkgName { get; set; }
        public DateTime? PkgStartDate { get; set; }
        public DateTime? PkgEndDate { get; set; }
        public string PkgDesc { get; set; }
        public decimal PkgBasePrice { get; set; }
        public decimal? PkgAgencyCommission { get; set; }

        // makes identival copy of Customer
        public Packages Clone()
        {
            Packages copy = new Packages();
            copy.PackageId = this.PackageId;
            copy.PkgName = this.PkgName;
            copy.PkgStartDate = this.PkgStartDate;
            copy.PkgEndDate = this.PkgEndDate;
            copy.PkgDesc = this.PkgDesc;
            copy.PkgBasePrice = this.PkgBasePrice;
            copy.PkgAgencyCommission = this.PkgAgencyCommission;
            return copy;
        }
    }
}
