using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KnowledgeCheck2;


Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<Shirt>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var shirt = new Shirt();

    Console.WriteLine("Begin New Record Entry\n" +
        "__________________________________\n");
    Console.WriteLine("Enter the price of the shirt: (In Decimal Form, ex. 12.00)");
    shirt.Price = decimal.Parse(Console.ReadLine());

    Console.WriteLine("How many of this shirt are you adding to the stock? (In digits, ex. 13)");
    shirt.NumberInStock = int.Parse(Console.ReadLine());

    Console.WriteLine("What size is the shirt? (Enter Small, Medium, Large, or X-Large)");
    shirt.Size = Console.ReadLine();

    Console.WriteLine("Enter the material of shirt:");
    shirt.Material = Console.ReadLine();

    Console.WriteLine("Is the shirt collared? (Enter TRUE if yes, Enter FALSE if no) ");
    shirt.IsCollared = bool.Parse(Console.ReadLine());

    Console.WriteLine("Does the shirt have buttons? (Enter TRUE if yes, Enter FALSE if no) ");
    shirt.HasButtons = bool.Parse(Console.ReadLine());

    recordList.Add(shirt);

    
}

// Print out the list of records using Console.WriteLine()
Console.WriteLine("Printing your records...\n\n");
foreach (var shirt in recordList) 
{
    Console.WriteLine($" Shirt Price: {shirt.Price}\n Number of This Shirt Added to Stock: {shirt.NumberInStock}\n Shirt Size: {shirt.Size}\n Shirt Material: {shirt.Material}\n Shirt Collared? {shirt.IsCollared}\n Shirt Has Buttons? {shirt.HasButtons}\n\n\n");
   
}
Console.WriteLine("End of Records");


