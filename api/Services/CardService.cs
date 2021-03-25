using System;
using api.Models;

namespace api.Services
{
	public class CardService
	{
		private RandomService _rand;

		public CardService(RandomService rand)
		{
			_rand = rand;
		}

		public Card GetRandom()
		{
			return new Card 
			{
				Suit = GetRandomSuit(),
				Face = GetRandomFace()
			};
		}

		public Suit GetRandomSuit()
		{
			return (Suit)_rand.GetInt(1, 5);
		}

		public int GetRandomFace()
		{
			return _rand.GetInt(0, 14);
		}
	}
}