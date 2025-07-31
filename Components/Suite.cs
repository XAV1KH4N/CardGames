public interface ISuite
{
  string Name { get; }
  string Symbol { get; }
}

public readonly struct BritishSuite : ISuite
{
  public string Name { get; }
  public string Symbol { get; }

  private BritishSuite(string name, string symbol)
  {
    Name = name;
    Symbol = symbol;
  }

  public static readonly BritishSuite Hearts = new BritishSuite("Hearts", "♥");
  public static readonly BritishSuite Clubs = new BritishSuite("Clubs", "♣");
  public static readonly BritishSuite Diamonds = new BritishSuite("Diamonds", "♦");
  public static readonly BritishSuite Spades = new BritishSuite("Spades", "♠");

  public override string ToString() => $"{Symbol} {Name}";
    
  public static readonly IReadOnlyList<BritishSuite> All = new[]
  {
    Hearts, Clubs, Diamonds, Spades
  };
}
