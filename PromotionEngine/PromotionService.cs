using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
  public class PromotionService : IPromotionService
  {
    public List<PromotionRule> Rules;

    public (List<Product> products, int price) ApplyPromotion(List<Product> products)
    {
      int totalPromoPrice = 0;
      foreach (PromotionRule rule in Rules)
      {
        var isOfferApplies = rule.Products.TrueForAll(s => products.Any(k => k.Name == s.Name && k.Quantity >= s.Quantity));
        totalPromoPrice += rule.PromoPrice;
        rule.Products.ForEach(s => products.FirstOrDefault(k => k.Name == s.Name && k.Quantity >= s.Quantity).Quantity -= s.Quantity);
        products.RemoveAll(s => s.Quantity == 0);
      }
      return (products, totalPromoPrice);
    }
  }
}
