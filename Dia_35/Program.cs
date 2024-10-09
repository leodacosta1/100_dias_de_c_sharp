// learn.microsoft.com

// Add logic to C# console applications (Get started with C#, Part 3) 
// Evaluate Boolean expressions to make decisions in C# 

// =========================================================== //
// Unit 3 of 9 > Exercise - Implement the conditional operator //
// =========================================================== //

// <evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>


int saleAmount = 1001;
// saleAmount é maior que 1000? Se verdadeiro, retorne 100. Se falso, retorne 50.
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");

// versão simplificada, retirando a variável discount
int saleAmount2 = 1001;
Console.WriteLine($"Discount: {(saleAmount2 > 1000 ? 100 : 50)}");