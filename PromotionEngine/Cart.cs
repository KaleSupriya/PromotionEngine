using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
  public class Cart
  {
    private readonly List<Product> _products;
    public Cart(List<Product> products = null)
    {
      _products = products;
    }
    public int GetPrice()
    {
      try
      {
        if (_products != null)
        {
          return _products.Sum(x => x.Price * x.Quantity);
        }
        return 0;
      }
      catch (Exception e)
      {
        throw;
      }
    }
  }
}
