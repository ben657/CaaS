namespace api.Models
{
	public enum Suit
	{
		Diamonds = 1,
		Hearts,
		Spades,
		Clubs
	}

	public class Card
	{
		public Suit Suit { get; set; }
		public int Face { get; set; }

		public string Color
		{
			get
			{
				switch (Suit)
				{
					case Suit.Diamonds:
					case Suit.Hearts:
						return "Red";
					case Suit.Spades:
					case Suit.Clubs:
						return "Black";
				}

				return "Unknown";
			}
		}
	}
}