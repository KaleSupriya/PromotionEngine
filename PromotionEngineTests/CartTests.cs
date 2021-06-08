using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine;
using System;
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
    [TestMethod("Should return cart price with multiple qty of single item")]
    public void Should_return_cart_price_for_multiple_qty()
    {
      //arrange 
      Cart c = new Cart(new List<Product> {
                            new Product("E", 10, 2),
                            new Product("B", 10, 1)});
      //act
      var actual = c.GetPrice();
      //assert
      Assert.AreEqual(actual, 30);
    }

    [TestMethod("Should return 0 empty cart")]
    public void Should_return_zero_empty_cart()
    {
      //arrange 
      Cart c = new Cart();
      //act
      var actual = c.GetPrice();
      //assert
      Assert.AreEqual(actual, 0);
    }
  }

}
