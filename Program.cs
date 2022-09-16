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

    }

    static void PrintCostInformation (CalculateCost weekly) {
        Console.WriteLine("฿{0}",weekly.Calculate(127));
    }
    
}