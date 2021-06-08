using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine;
using System.Collections.Generic;

namespace PromotionEngineTests
{
  [TestClass]
  public class CartTests
  {
    [TestMethod("Should return cart price")]
    public void Should_return_cart_price()
    {
      //arrange 
      Cart c = new Cart(new List<Product> {
                            new Product("E", 10, 1),
                            new Product("B", 10, 1)});
      //act
      var actual = c.GetPrice();
      //assert
      Assert.AreEqual(actual , 20);
    }
  }

}
