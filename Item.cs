using System;
using System.Collections.Generic;
using System.Text;

namespace MidtermProject
{
    public class Item
    {
        //make variables
        public string Name = "";
        public string Description = "";

        //constructor
        public Item(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public void AddClue(List<Item> Inventory)
        {
            Inventory.Add(this);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("You got a clue! \n" + Name + ": " + Description);
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}
