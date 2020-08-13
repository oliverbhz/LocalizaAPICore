using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using LocalizaAPICore.Controllers;
using Microsoft.AspNetCore.Mvc;
using FluentAssertions;
using System.Linq;

namespace LocalizaAPICoreTest
{
	public class DecomposeNumberTest
	{
		private readonly DecomposeNumberController _controller = new DecomposeNumberController();

		[Fact]
		public void Decompose()
		{
			var okResult = _controller.Get(40);

			List<int> primer = EhPrimo(okResult.Primer).ToList();
			Assert.Equal(okResult.Primer, primer);

			List<int> divisor = EhtDivisor(okResult.Divisor).ToList();
			Assert.Equal(okResult.Divisor, divisor);
		}

		private static IEnumerable<int> EhPrimo(List<int> range)
		{
			return from n in range
				   let w = (int)Math.Sqrt(n)
				   where Enumerable.Range(2, w).All((i) => n > 1 && n % i > 0 || n == 2)
				   orderby n
				   select n;
		}

		private static IEnumerable<int> EhtDivisor(List<int> range)
		{
			return from n in range
				   let w = (int)Math.Sqrt(n)
				   where Enumerable.Range(2, w).All((i) => n % n == 0)
				   orderby n
				   select n;
		}
	}
}
