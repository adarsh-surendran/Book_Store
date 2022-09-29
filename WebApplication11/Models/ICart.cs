using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication11.Models
{
    public interface ICart
    {
        Cart AddtoCart(Cart cart);
        void DeletefromCart(string uname,int bid);
        List<Cart> ViewCart();
        
    }
}
