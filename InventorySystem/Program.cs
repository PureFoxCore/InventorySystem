using System;

namespace course
{
    internal class MainClass
    {
        private static void Main(string[] args)
        {
            var inventory = new Inventory(25.0f);

            inventory.AddItem(new Item(20f, "sword"), 1);
            inventory.AddItem(new Item(2f, "laptop"), 2);

            foreach (var cell in inventory.Cells)
                Console.WriteLine($"{cell.Item.Name}, {cell.Item.Weight}, {cell.Count}");

            Console.WriteLine($"{inventory.CurrentWeight}");
        }
    }
}
