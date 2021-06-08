using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine;

namespace PromotionEngineTests
{
  [TestClass]
  class CartTests
  {
    [TestMethod("Should return cart price")]
    public void Should_return_cart_price()
    {
      //arrange 
      Cart c = new Cart();
      //act
      var result = c.GetPrice();
      //assert
      Assert.Equals(result,10);
    }
  }
}
