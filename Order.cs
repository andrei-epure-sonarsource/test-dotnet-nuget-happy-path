internal sealed record Order(string Number, string Product, int Quantity, decimal UnitPrice)
{
    public decimal Total => Quantity * UnitPrice;
}
