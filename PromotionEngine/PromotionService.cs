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

    public bool ApplyPromotion(List<Product> products)
    {
      return true;
    }
  }
}
