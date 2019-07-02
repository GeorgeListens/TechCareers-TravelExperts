using mySQL.Packages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class CartItemList
{
    private List<CartItem> cartItems;

    public CartItemList()
    {
        cartItems = new List<CartItem>();
    }

    public int Count
    {
        get { return cartItems.Count; }
    }

    // Package.PackageID is an int, and this one is barfing on "out of range"
    //public CartItem this[int index]
    //{
    //    get { return cartItems[index]; }
    //    set { cartItems[index] = value; }
    //}

    public CartItem GetItemByPackageID(int id)
    {
        foreach (CartItem c in cartItems)
            if (c.Package.PackageId == id) return c;
        return null;
 
    }

    // this is an indexer
    // access item on position i
    public CartItem this[int i]
    {
        get
        {
            CartItem c = null;
            if (i >= 0 && i < cartItems.Count)
                c = cartItems[i];
            return c;
        }
    }
    
    public static CartItemList GetCart()
    {       
        CartItemList cart = (CartItemList)HttpContext.Current.Session["Cart"];
        if (cart == null)
            HttpContext.Current.Session["Cart"] = new CartItemList();
        return (CartItemList)HttpContext.Current.Session["Cart"];
    }

    public void AddItem(Packages package, int quantity)
    {
        CartItem c = new CartItem(package, quantity);
        cartItems.Add(c);
    }

    public void RemoveAt(int index)
    {
        cartItems.RemoveAt(index);
    }

    // Clear the private list variable carItems
    public void Clear()
    {
        cartItems.Clear();
    }
}