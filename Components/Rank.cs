public interface IRank
{
  int Value { get; }
  string Name { get; }
}

public readonly struct BritishRank : IRank
{
  public int Value { get; }
  public string Name { get; }

    private BritishRank(string name, int value)
    {
        Name = name;
        Value = value;
    }

  public static readonly BritishRank ONE = new BritishRank("ONE", 1);
  public static readonly BritishRank TWO = new BritishRank("TWO", 2);
  public static readonly BritishRank THREE = new BritishRank("THREE", 3);
  public static readonly BritishRank FOUR = new BritishRank("FOUR", 4);
  public static readonly BritishRank FIVE = new BritishRank("FIVE", 5);
  public static readonly BritishRank SIX = new BritishRank("SIX", 6);
  public static readonly BritishRank SEVEN = new BritishRank("SEVEN", 7);
  public static readonly BritishRank EIGHT = new BritishRank("EIGHT", 8);
  public static readonly BritishRank NINE = new BritishRank("NINE", 9);
  public static readonly BritishRank TEN = new BritishRank("TEN", 10);
  public static readonly BritishRank JACK = new BritishRank("JACK", 11);
  public static readonly BritishRank QUEEN = new BritishRank("QUEEN", 12);
  public static readonly BritishRank KING = new BritishRank("KING", 13);


  public override string ToString() => $"{Name}";
    
  public static readonly IReadOnlyList<BritishRank> All = new[]
  {
    ONE, TWO, THREE, FOUR, FIVE, SIX, SEVEN,
    EIGHT, NINE, TEN, JACK, QUEEN, KING
  };
}
