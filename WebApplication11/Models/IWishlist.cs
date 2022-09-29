using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication11.Models
{
    public interface IWishlist
    {
        Wishlist AddtoWishlist(Wishlist wishlist);
        void DeletefromWishlist(string uname, int bid);
        List<Wishlist> ViewWishlist();
    }
}
