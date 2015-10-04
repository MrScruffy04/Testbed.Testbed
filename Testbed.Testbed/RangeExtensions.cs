using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace Testbed.Testbed
{
	public static class RangeExtensions
	{
		public static IEnumerable<char> GetValues(this Range<char> range)
		{
			for (char i = range.LowerBound; i <= range.UpperBound; i++)
			{
				yield return i;
			}
		}
	}
}
