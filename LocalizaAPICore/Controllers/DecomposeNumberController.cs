using LocalizaAPICore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LocalizaAPICore.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DecomposeNumberController : ControllerBase
	{

		// GET api/decomposenumber/5
		[HttpGet("{value}")]
		public DecomposeNumber Get(int value)
		{

			List<int> divisors = GetDivisors(value).ToList();
			List<int> primers = GetPrimers(divisors).ToList();

			var decomposedNumbers = new DecomposeNumber
			{
				Divisor = divisors,
				Primer = primers
			};

			return decomposedNumbers;
		}

		private static IEnumerable<int> GetDivisors(int value)
		{
			return from n in Enumerable.Range(1, value)
				   where value % n == 0
				   orderby n
				   select n;
		}

		private static IEnumerable<int> GetPrimers(List<int> range)
		{
			return from n in range
				   let w = (int)Math.Sqrt(n)
				   where Enumerable.Range(2, w).All((i) => n > 1 && n % i > 0 || n == 2)
				   orderby n
				   select n;
		}
	}
}
