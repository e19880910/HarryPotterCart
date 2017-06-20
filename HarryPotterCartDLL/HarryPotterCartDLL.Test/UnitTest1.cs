using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HarryPotterCartDLL.Test
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void Buy1Book_Return_100()
		{
			//arrange
			var target = new PotterShoppingCart();
			target.Buy(1, 1);
			target.Buy(2, 0);
			target.Buy(3, 0);
			target.Buy(4, 0);
			target.Buy(5, 0);
			
			//act
			var actual = target.CheckOut();
			var expected = 100;

			//assert
			Assert.AreEqual(expected, actual);
		}
	}
}
