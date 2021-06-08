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
    private readonly IPromotionService _promotionService;

    public Cart(List<Product> products = null, IPromotionService promotionService = null)
    {
      _products = products;
      _promotionService = promotionService;
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
