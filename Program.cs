Console.WriteLine("===== Shopping Bill Generator =====");
Console.Write("Product Name:");
string? Name = Console.ReadLine();
Console.Write("Quantity:");
decimal Quantity = Convert.ToDecimal(Console.ReadLine());
Console.Write("Price per unit: ");
decimal PricePerUnit = Convert.ToDecimal(Console.ReadLine());

decimal Total = (Quantity * PricePerUnit);
Console.WriteLine("Total:" + Total);

decimal GST = (Total + (Total * 0.18m));

decimal Final_Amount = Total + GST;
Console.Write($"Final Amount: Rs.{Final_Amount}");