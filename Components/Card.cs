
public abstract class Card {
    private IRank rank;
    private ISuite suite; 
    public Card(IRank rank, ISuite suite) {
        this.rank = rank;
        this.suite = suite;
    }
}
