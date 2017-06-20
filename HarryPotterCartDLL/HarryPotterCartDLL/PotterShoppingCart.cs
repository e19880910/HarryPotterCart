using System;
using System.Collections.Generic;

namespace HarryPotterCartDLL
{
	public class PotterShoppingCart
	{
		private UInt32[] _bookCounts;

		public PotterShoppingCart()
		{
			_bookCounts = new UInt32[5];
		}

		public void Buy(UInt32 volumeNo, UInt32 bookCount)
		{
			_bookCounts[volumeNo-1] += bookCount;
		}

		public object CheckOut()
		{
			decimal price = 0;
			var diffVolumeCount = -1;
			for (int volume = 0; volume < _bookCounts.Length; volume++)
			{
				price += _bookCounts[volume] * 100;
				if (_bookCounts[volume] > 0)
				{
					diffVolumeCount += 1;
				}
			}

			price = price - price * diffVolumeCount * 0.05m;

			return price;
		}
	}
}