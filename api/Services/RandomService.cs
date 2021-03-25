using System;

namespace api.Services
{
	public class RandomService
	{
		private readonly Random _rand = new Random();

		public int GetInt(int min, int max)
		{
			return _rand.Next(min, max);
		}

		public double GetDouble(double min, double max)
		{
			return min +_rand.NextDouble() * (max - min);
		}
	}
}