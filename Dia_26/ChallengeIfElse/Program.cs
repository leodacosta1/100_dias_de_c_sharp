Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

Console.WriteLine(daysUntilExpiration);
// Subscription expiration tracker
if (daysUntilExpiration == 0)
{
    Console.WriteLine($"Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine($"Your subscription expires within a day!");
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days");
}
else
{
    Console.WriteLine($"Your subscription will expire soon. Renew now!");
}

// Discount logic
if (daysUntilExpiration <= 5)
{
    discountPercentage = 10;
    if (daysUntilExpiration == 1)
    {
        discountPercentage += 10;             
    }    
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}