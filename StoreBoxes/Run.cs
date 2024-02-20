namespace StoreBoxes
{
    public class Run
    {
        static void Main(string[] args)
        {

            string command = Console.ReadLine();

            List<Box> list = new List<Box>();   

            while(command != "end")
            {
                string[] input = command.Split(" ");

                string serialNumber = input[0];
                string itemName = input[1];
                int itemQty = int.Parse(input[2]);
                decimal itemPrice = decimal.Parse(input[3]);
                decimal pricePerBox = itemQty * itemPrice;

                Item currentItem = new(itemName, itemPrice);
                Box currentBox = new(serialNumber,currentItem,itemQty,pricePerBox);

                list.Add(currentBox);

                command = Console.ReadLine();
            }


            list = list.OrderByDescending(b => b.GetPricePerBox()).ToList();

            foreach (Box box in list)
            {
                Console.WriteLine(box.GetSerialNumber());
                Console.WriteLine($"-- {box.GetItem().GetName()} – ${box.GetItem().GetPrice():F2}: {box.GetItemQty()}");
                Console.WriteLine($"-- ${box.GetPricePerBox():F2}");
            }

        }
    }
}
