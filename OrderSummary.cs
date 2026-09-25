internal sealed record OrderSummary(int OrderCount, int ItemCount, decimal Total)
{
    public static OrderSummary Create(IEnumerable<Order> orders)
    {
        ArgumentNullException.ThrowIfNull(orders);

        var materializedOrders = orders.ToArray();
        return new OrderSummary(
            materializedOrders.Length,
            materializedOrders.Sum(order => order.Quantity),
            materializedOrders.Sum(order => order.Total));
    }
}
