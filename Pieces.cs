namespace pieces;
public class Pieces
{
    private int _nextMove;
    public int nextMove { get; protected set; }
    public Pieces(int NextMove)
    {
        nextMove = NextMove;
    }

    protected virtual nextMove()
    {

    }
}