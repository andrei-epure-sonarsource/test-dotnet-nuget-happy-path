using Newtonsoft.Json;

var orders = new[]
{
    new Order("A-100", "Coffee beans", 2, 12.50m),
    new Order("A-101", "Tea sampler", 1, 9.90m),
    new Order("A-102", "Coffee filter", 3, 4.25m)
};

var summary = OrderSummary.Create(orders);
Console.WriteLine(JsonConvert.SerializeObject(summary, Formatting.Indented));
