namespace _06._Store_Boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            List<Box> boxesList = new List<Box>();

            while (command != "end")
            {
                string[] input = command.
                    Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                int serialNumber = int.Parse(input[0]);
                string itemName = input[1];
                int itemQty = int.Parse(input[2]);
                double itemPrice = double.Parse(input[3]);

                Box box = new Box(serialNumber, itemName, itemQty, itemPrice);

                boxesList.Add(box);



                command = Console.ReadLine();
            }

            boxesList = boxesList.OrderByDescending(s => s.PricePerBox).ToList();

            foreach (Box item in boxesList)
            {
                Console.WriteLine($"{item.SerialNumber}");
                Console.WriteLine($"-- {item.ItemName} - ${item.ItemPrice:f2}: {item.ItemQty}");
                Console.WriteLine($"-- ${item.PricePerBox:f2}");
            }
        }
    }


}
class Box
{
    public int SerialNumber { get; set; }

    public string ItemName { get; set; }

    public int ItemQty { get; set; }

    public double ItemPrice { get; set; }
    public double PricePerBox { get; set; }


    public Box(int serialNumber, string itemName, int itemQty, double itemPrice)
    {
        this.SerialNumber = serialNumber;
        this.ItemName = itemName;
        this.ItemQty = itemQty;
        this.ItemPrice = itemPrice;
        this.PricePerBox = itemQty * itemPrice;
    }
}