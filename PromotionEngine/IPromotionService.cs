using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
  public interface IPromotionService
  {
    bool ApplyPromotion(List<Product> products);
  }
}
