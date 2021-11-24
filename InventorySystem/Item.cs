using System;

namespace course
{
    public class Item
    {
        public Item(float weight, string name)
        {
            if (weight <= 0f)
                throw new ArgumentOutOfRangeException(nameof(weight));

            Weight = weight;
            Name = name;
        }

        public string Name { get; }
        public float Weight { get; }
    }
}