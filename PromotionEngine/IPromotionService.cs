using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
  public interface IPromotionService
  {
    (List<Product> products, int price) ApplyPromotion(List<Product> products);
  }
}
