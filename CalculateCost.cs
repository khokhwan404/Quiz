using System;

public class CalculateCost {
    private int sold;
    //public int soldBaht;
    public int soldDelivery;
    public int DeliveryBaht;

    public CalculateCost(int sold) {
        this.sold = sold;
        //return sold;
    }

    public int Calculate(int soldBaht) {
        return soldBaht * this.sold;
    }

    // public int TimesDelivery(int soldDelivery) {
    //     this.soldDelivery = soldDelivery;
    //     return soldDelivery;
    // }

    // public int CostDelivery(int sold, int soldBaht) {
    //     return soldDelivery * 357;
    // }

    
}
