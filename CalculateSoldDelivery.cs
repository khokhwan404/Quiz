using System;

public class CalculateSoldDelivery {
    public int Delivery;

    public CalculateSoldDelivery(int Delivery) {
        this.Delivery = Delivery;
    }

    public int CalculateDelivery(int soldDelivery) {
        return soldDelivery * this.Delivery;
    }


}