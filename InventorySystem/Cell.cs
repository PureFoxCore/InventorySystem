using System;

namespace course
{
    public class Cell : IReadOnlyCell
    {
        public Item Item { get; private set; }
        public int Count { get; private set; }

        public Cell(Item item, int count)
        {
            if (count <= 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            Item = item;
            Count = count;
        }

        public float Weight => Item.Weight * Count;

        public void Merge(Cell newCell)
        {
            if (newCell.Item != Item)
                throw new InvalidOperationException();

            Count += newCell.Count;
        }
    }
}