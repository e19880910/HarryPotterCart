using System;
using System.Collections.Generic;

namespace HarryPotterCartDLL
{
	public class PotterShoppingCart
	{
		private UInt32[] _bookCounts;
		private UInt32 _maxBookCount;

		public PotterShoppingCart()
		{
			_bookCounts = new UInt32[5];
			_maxBookCount = 0;
		}

		public void Buy(UInt32 volumeNo, UInt32 bookCount)
		{
			_bookCounts[volumeNo - 1] += bookCount;
			_maxBookCount = _maxBookCount < _bookCounts[volumeNo - 1]? _bookCounts[volumeNo - 1] : _maxBookCount;
		}

		public decimal CheckOut()
		{
			var price = 0m;
			var diffVolumeCount = 0;
			var discount = 0m;
			for (int i = 0; i < _maxBookCount; i++)
			{
				discount = 0m;
				diffVolumeCount = 0;
				for (int volume = 0; volume < _bookCounts.Length; volume++)
				{
					if (_bookCounts[volume] > 0)
					{
						diffVolumeCount++;
						_bookCounts[volume]--;
					}
				}

				discount = GetDiscountBy(diffVolumeCount);
				price += diffVolumeCount * 100 * discount;
			}
			
			return price;
		}


		private decimal GetDiscountBy(int diffVolumeCount)
		{
			switch (diffVolumeCount)
			{
				case 1:
					return 1m;
				case 2:
					return 0.95m;
				case 3:
					return 0.9m;
				case 4:
					return 0.8m;
				case 5:
					return 0.75m;
				default:
					return 1m;
			}
		}

	}
}