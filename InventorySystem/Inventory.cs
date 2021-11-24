using System;
using System.Linq;
using System.Collections.Generic;

namespace course
{
    public class Inventory
    {
        private readonly List<Cell> _cells;

        public Inventory(float maxWeight)
        {
            if (maxWeight <= 0f)
                throw new ArgumentOutOfRangeException(nameof(maxWeight));

            _cells = new List<Cell>();
            MaxWeight = maxWeight;
        }

        public IReadOnlyList<IReadOnlyCell> Cells => _cells;
        public float MaxWeight { get; private set; }
        public float CurrentWeight => _cells.Sum(cell => cell.Weight);

        public void AddItem(Item item, int count)
        {
            var newCell = new Cell(item, count);

            if (CurrentWeight + newCell.Weight > MaxWeight)
                throw new InvalidOperationException();

            Cell sameCell = _cells.FirstOrDefault(cell => cell.Item == item);

            if (sameCell == null)
                _cells.Add(newCell);
            else
                sameCell.Merge(newCell);
        }
    }
}