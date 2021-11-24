namespace course
{
    public interface IReadOnlyCell
    {
        Item Item { get; }
        int Count { get; }
    }
}