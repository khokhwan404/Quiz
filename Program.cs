public class Program {

    static void Main(string[] args) {

        Console.Write("จำนวนเงินทุน: ");
        int fund = int.Parse(Console.ReadLine());
        Console.Write("ชื่อสาขา: ");
        string fields = Console.ReadLine();
        Console.Write("สถานที่: ");
        string place = Console.ReadLine();

        // InputOwnerInfo owner1 = new InputOwnerInfo();
        // InputOwnerInfo owner2 = new InputOwnerInfo();
        // InputOwnerInfo owner3 = new InputOwnerInfo();

        CalculateCost week1 = new CalculateCost(26);
        CalculateCost week2 = new CalculateCost(27);
        CalculateCost week3 = new CalculateCost(35);
        CalculateCost week4 = new CalculateCost(50);
        

        PrintCostInformation (week1);
        PrintCostInformation (week2);
        PrintCostInformation (week3);
        PrintCostInformation (week4);

        CalculateSoldDelivery week01 = new CalculateSoldDelivery(78);
        CalculateSoldDelivery week02 = new CalculateSoldDelivery(96);
        CalculateSoldDelivery week03 = new CalculateSoldDelivery(159);
        CalculateSoldDelivery week04 = new CalculateSoldDelivery(271);
        

        PrintCostDelivery (week01);
        PrintCostDelivery (week02);
        PrintCostDelivery (week03);
        PrintCostDelivery (week04);

    }

    static void PrintCostInformation (CalculateCost weekly) {
        Console.WriteLine("฿{0}",weekly.Calculate(127));
    }

    static void PrintCostDelivery (CalculateSoldDelivery weekly) {
        Console.WriteLine("฿{0}",weekly.CalculateDelivery(357));
    }

}