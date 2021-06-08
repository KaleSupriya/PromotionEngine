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
          var result = _promotionService.ApplyPromotion(_products);
          if (result.Item1 != null)
          {
            var noPromoProducts = result.Item1;
            return noPromoProducts.Sum(x => x.Price * x.Quantity) + result.Item2;
          }
          else
          {
            return _products.Sum(x => x.Price * x.Quantity);
          }
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
