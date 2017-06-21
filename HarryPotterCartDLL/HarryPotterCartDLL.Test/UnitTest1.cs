using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HarryPotterCartDLL.Test
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void BuyVolume1_Count1_Return_100()
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
			decimal expected = 100;

			//assert
			Assert.AreEqual(expected, actual);
		}


		[TestMethod]
		public void BuyVolume1_Count1_Volume2_Count1_Return_190()
		{
			//arrange
			var target = new PotterShoppingCart();
			target.Buy(1, 1);
			target.Buy(2, 1);
			target.Buy(3, 0);
			target.Buy(4, 0);
			target.Buy(5, 0);

			//act
			var actual = target.CheckOut();
			decimal expected = 190;
			
			//assert
			Assert.AreEqual(expected, actual);
		}


		[TestMethod]
		public void BuyVolume1_Count1_Volume2_Count1_Volume3_Count1_Return_270()
		{ 
			//arrange
			var target = new PotterShoppingCart();
			target.Buy(1, 1);
			target.Buy(2, 1);
			target.Buy(3, 1);
			target.Buy(4, 0);
			target.Buy(5, 0);

			//act
			var actual = target.CheckOut();
			decimal expected = 270;

			//assert
			Assert.AreEqual(expected, actual);
		}


		[TestMethod]
		public void BuyVolume1_Count1_Volume2_Count1_Volume3_Count1_Volume4_Count1_Return_320()
		{
			//arrange
			var target = new PotterShoppingCart();
			target.Buy(1, 1);
			target.Buy(2, 1);
			target.Buy(3, 1);
			target.Buy(4, 1);
			target.Buy(5, 0);

			//act
			var actual = target.CheckOut();
			decimal expected = 320;

			//assert
			Assert.AreEqual(expected, actual);
		}


		[TestMethod]
		public void BuyVolume1_Count1_Volume2_Count1_Volume3_Count1_Volume4_Count1_Volume5_Count1_Return_375()
		{
			//arrange
			var target = new PotterShoppingCart();
			target.Buy(1, 1);
			target.Buy(2, 1);
			target.Buy(3, 1);
			target.Buy(4, 1);
			target.Buy(5, 1);

			//act
			var actual = target.CheckOut();
			decimal expected = 375;

			//assert
			Assert.AreEqual(expected, actual);
		}



		[TestMethod]
		public void BuyVolume1_Count1_Volume2_Count1_Volume3_Count2_Return_370()
		{
			//arrange
			var target = new PotterShoppingCart();
			target.Buy(1, 1);
			target.Buy(2, 1);
			target.Buy(3, 2);
			target.Buy(4, 0);
			target.Buy(5, 0);
			
			//act
			var actual = target.CheckOut();
			decimal expected = 370;

			//assert
			Assert.AreEqual(expected, actual);
		}



	}
}
