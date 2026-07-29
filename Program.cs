Console.WriteLine("===== Shopping Bill Generator =====");
Console.Write("Product Name:");
string? Name = Console.ReadLine();
Console.Write("Quantity:");
double Quantity = Convert.ToDouble(Console.ReadLine());
Console.Write("Price per unit: ");
double PricePerUnit = Convert.ToDouble(Console.ReadLine());

double Total = (Quantity * PricePerUnit);
Console.WriteLine("Total:" + Total);

double GST = (Total + (Total*0.18));

double Final_Amount = Total + GST;
Console.Write($"Final Amount: Rs.{Final_Amount}");