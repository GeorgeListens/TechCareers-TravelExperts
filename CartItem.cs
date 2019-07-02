using mySQL.Packages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class CartItem
{
    public CartItem() { }

    public CartItem(Packages package, int quantity)
    {
        this.Package = package;
        this.Quantity = quantity;
    }

    public Packages Package { get; set; }
    public int Quantity { get; set; }

    public void AddQuantity(int quantity)
    {
        this.Quantity += quantity;
    }

    public string Display()
    {

        string displayString = string.Format("{0} ({1} at {2})",
            Package.PkgName,
            Quantity.ToString(),
            Package.PkgBasePrice.ToString("c")
            );
        return displayString;
    }
}
